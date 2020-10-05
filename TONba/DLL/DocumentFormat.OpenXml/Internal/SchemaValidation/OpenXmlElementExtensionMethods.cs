// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.OpenXmlElementExtensionMethods
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  internal static class OpenXmlElementExtensionMethods
  {
    internal static OpenXmlElement GetFirstChildMc(this OpenXmlElement parent, MCContext mcContext, FileFormatVersions format)
    {
      OpenXmlElement miscElementChild = parent.GetFirstNonMiscElementChild();
      return parent.GetChildMc(miscElementChild, mcContext, format);
    }

    internal static OpenXmlElement GetNextChildMc(this OpenXmlElement parent, OpenXmlElement child, MCContext mcContext, FileFormatVersions format)
    {
      OpenXmlElement miscElementSibling = child.GetNextNonMiscElementSibling();
      OpenXmlElement parent1 = child.Parent;
      if (miscElementSibling != null || parent1 == parent)
        return parent.GetChildMc(miscElementSibling, mcContext, format);
      if (parent1 is AlternateContentChoice || parent1 is AlternateContentFallback)
        parent1 = parent1.Parent;
      return parent.GetNextChildMc(parent1, mcContext, format);
    }

    private static OpenXmlElement GetChildMc(this OpenXmlElement parent, OpenXmlElement child, MCContext mcContext, FileFormatVersions format)
    {
      Stack<OpenXmlElement> openXmlElementStack = new Stack<OpenXmlElement>();
label_13:
      while (child != null)
      {
        AlternateContent acblk = child as AlternateContent;
        if (acblk == null && child.IsInVersion(format))
          return child;
        mcContext.PushMCAttributes2(child.MCAttributes, new MCContext.LookupNamespace(child.LookupNamespace));
        if (acblk != null)
        {
          openXmlElementStack.Push(child.GetNextNonMiscElementSibling());
          OpenXmlCompositeElement contentFromAcBlock = mcContext.GetContentFromACBlock(acblk, format);
          child = contentFromAcBlock == null ? (OpenXmlElement) null : contentFromAcBlock.GetFirstNonMiscElementChild();
        }
        else if (mcContext.IsIgnorableNs(child.NamespaceUri))
        {
          if (mcContext.IsProcessContent(child))
          {
            openXmlElementStack.Push(child.GetNextNonMiscElementSibling());
            child = child.GetFirstNonMiscElementChild();
          }
          else
            child = child.GetNextNonMiscElementSibling();
        }
        else
        {
          mcContext.PopMCAttributes2();
          return child;
        }
        mcContext.PopMCAttributes2();
        while (true)
        {
          if (child == null && openXmlElementStack.Count > 0)
            child = openXmlElementStack.Pop();
          else
            goto label_13;
        }
      }
      return child;
    }
  }
}

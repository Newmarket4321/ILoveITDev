// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.AlternateContentFallback
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.Collections.Generic;

namespace DocumentFormat.OpenXml
{
  public class AlternateContentFallback : OpenXmlCompositeElement
  {
    private static string tagName = "Fallback";
    private static string[] attributeTagNames = new string[0];
    private static byte[] attributeNamespaceIds = new byte[0];

    public AlternateContentFallback()
    {
    }

    public AlternateContentFallback(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public AlternateContentFallback(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public AlternateContentFallback(string outerXml)
      : base(outerXml)
    {
    }

    public static string TagName
    {
      get
      {
        return AlternateContentFallback.tagName;
      }
    }

    public override string LocalName
    {
      get
      {
        return AlternateContentFallback.tagName;
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return AlternateContent.MarkupCompatibilityNamespaceId;
      }
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return AlternateContentFallback.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return AlternateContentFallback.attributeNamespaceIds;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      return (OpenXmlSimpleType) null;
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      OpenXmlElement openXmlElement = (OpenXmlElement) null;
      if (this.Parent != null && this.Parent is AlternateContent)
      {
        OpenXmlElement parent = this.Parent.Parent;
        if (parent != null)
          openXmlElement = parent.ElementFactory(namespaceId, name);
      }
      return openXmlElement;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<AlternateContentFallback>(deep);
    }

    internal override int ElementTypeId
    {
      get
      {
        return 9005;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return true;
    }
  }
}

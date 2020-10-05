// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.AlternateContent
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.Collections.Generic;

namespace DocumentFormat.OpenXml
{
  public class AlternateContent : OpenXmlCompositeElement
  {
    private static string _mcNamespace = "http://schemas.openxmlformats.org/markup-compatibility/2006";
    private static byte _mcNamespaceId = byte.MaxValue;
    private static string tagName = nameof (AlternateContent);
    private static string[] attributeTagNames = new string[0];
    private static byte[] attributeNamespaceIds = new byte[0];

    public AlternateContent()
    {
    }

    public AlternateContent(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public AlternateContent(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public AlternateContent(string outerXml)
      : base(outerXml)
    {
    }

    public static string MarkupCompatibilityNamespace
    {
      get
      {
        return AlternateContent._mcNamespace;
      }
    }

    public static byte MarkupCompatibilityNamespaceId
    {
      get
      {
        if ((int) AlternateContent._mcNamespaceId == (int) byte.MaxValue)
          AlternateContent._mcNamespaceId = NamespaceIdMap.GetNamespaceId(AlternateContent._mcNamespace);
        return AlternateContent._mcNamespaceId;
      }
    }

    public static string TagName
    {
      get
      {
        return AlternateContent.tagName;
      }
    }

    public override string LocalName
    {
      get
      {
        return AlternateContent.tagName;
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
        return AlternateContent.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return AlternateContent.attributeNamespaceIds;
      }
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if ((int) AlternateContent.MarkupCompatibilityNamespaceId == (int) namespaceId && AlternateContentChoice.TagName == name)
        return (OpenXmlElement) new AlternateContentChoice();
      if ((int) AlternateContent.MarkupCompatibilityNamespaceId == (int) namespaceId && AlternateContentFallback.TagName == name)
        return (OpenXmlElement) new AlternateContentFallback();
      return (OpenXmlElement) null;
    }

    public AlternateContentChoice AppendNewAlternateContentChoice()
    {
      AlternateContentChoice newChild = new AlternateContentChoice();
      this.AppendChild<AlternateContentChoice>(newChild);
      return newChild;
    }

    public AlternateContentFallback AppendNewAlternateContentFallback()
    {
      AlternateContentFallback newChild = new AlternateContentFallback();
      this.AppendChild<AlternateContentFallback>(newChild);
      return newChild;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      return (OpenXmlSimpleType) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<AlternateContent>(deep);
    }

    internal override int ElementTypeId
    {
      get
      {
        return 9003;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return true;
    }
  }
}

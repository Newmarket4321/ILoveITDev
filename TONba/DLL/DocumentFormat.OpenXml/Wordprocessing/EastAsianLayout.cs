// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public class EastAsianLayout : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[5]
    {
      "id",
      "combine",
      "combineBrackets",
      "vert",
      "vertCompress"
    };
    private static byte[] attributeNamespaceIds = new byte[5]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "eastAsianLayout";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11656;

    public override string LocalName
    {
      get
      {
        return "eastAsianLayout";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11656;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return EastAsianLayout.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return EastAsianLayout.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "id")]
    public Int32Value Id
    {
      get
      {
        return (Int32Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "combine")]
    public OnOffValue Combine
    {
      get
      {
        return (OnOffValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "combineBrackets")]
    public EnumValue<CombineBracketValues> CombineBrackets
    {
      get
      {
        return (EnumValue<CombineBracketValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "vert")]
    public OnOffValue Vertical
    {
      get
      {
        return (OnOffValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "vertCompress")]
    public OnOffValue VerticalCompress
    {
      get
      {
        return (OnOffValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (23 == (int) namespaceId && "combine" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "combineBrackets" == name)
        return (OpenXmlSimpleType) new EnumValue<CombineBracketValues>();
      if (23 == (int) namespaceId && "vert" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "vertCompress" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<EastAsianLayout>(deep);
    }
  }
}

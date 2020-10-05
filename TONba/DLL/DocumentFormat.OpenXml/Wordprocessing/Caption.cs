// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.Caption
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public class Caption : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[7]
    {
      "name",
      "pos",
      "chapNum",
      "heading",
      "noLabel",
      "numFmt",
      "sep"
    };
    private static byte[] attributeNamespaceIds = new byte[7]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "caption";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11980;

    public override string LocalName
    {
      get
      {
        return "caption";
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
        return 11980;
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
        return Caption.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Caption.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "name")]
    public StringValue Name
    {
      get
      {
        return (StringValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "pos")]
    public EnumValue<CaptionPositionValues> Position
    {
      get
      {
        return (EnumValue<CaptionPositionValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "chapNum")]
    public OnOffValue ChapterNumber
    {
      get
      {
        return (OnOffValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "heading")]
    public Int32Value Heading
    {
      get
      {
        return (Int32Value) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "noLabel")]
    public OnOffValue NoLabel
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

    [SchemaAttr(23, "numFmt")]
    public EnumValue<NumberFormatValues> NumberFormat
    {
      get
      {
        return (EnumValue<NumberFormatValues>) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "sep")]
    public EnumValue<ChapterSeparatorValues> Separator
    {
      get
      {
        return (EnumValue<ChapterSeparatorValues>) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "pos" == name)
        return (OpenXmlSimpleType) new EnumValue<CaptionPositionValues>();
      if (23 == (int) namespaceId && "chapNum" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "heading" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (23 == (int) namespaceId && "noLabel" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "numFmt" == name)
        return (OpenXmlSimpleType) new EnumValue<NumberFormatValues>();
      if (23 == (int) namespaceId && "sep" == name)
        return (OpenXmlSimpleType) new EnumValue<ChapterSeparatorValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Caption>(deep);
    }
  }
}

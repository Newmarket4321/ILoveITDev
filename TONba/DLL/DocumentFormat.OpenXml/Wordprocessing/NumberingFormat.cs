// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.NumberingFormat
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public class NumberingFormat : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "val",
      "format"
    };
    private static byte[] attributeNamespaceIds = new byte[2]
    {
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "numFmt";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11853;

    public override string LocalName
    {
      get
      {
        return "numFmt";
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
        return 11853;
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
        return NumberingFormat.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return NumberingFormat.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "val")]
    public EnumValue<NumberFormatValues> Val
    {
      get
      {
        return (EnumValue<NumberFormatValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    [SchemaAttr(23, "format")]
    public StringValue Format
    {
      get
      {
        return (StringValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "val" == name)
        return (OpenXmlSimpleType) new EnumValue<NumberFormatValues>();
      if (23 == (int) namespaceId && "format" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<NumberingFormat>(deep);
    }
  }
}

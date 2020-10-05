// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.DateGroupItem
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  public class DateGroupItem : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[7]
    {
      "year",
      "month",
      "day",
      "hour",
      "minute",
      "second",
      "dateTimeGrouping"
    };
    private static byte[] attributeNamespaceIds = new byte[7];
    private const string tagName = "dateGroupItem";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11430;

    public override string LocalName
    {
      get
      {
        return "dateGroupItem";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 22;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11430;
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
        return DateGroupItem.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return DateGroupItem.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "year")]
    public UInt16Value Year
    {
      get
      {
        return (UInt16Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "month")]
    public UInt16Value Month
    {
      get
      {
        return (UInt16Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "day")]
    public UInt16Value Day
    {
      get
      {
        return (UInt16Value) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "hour")]
    public UInt16Value Hour
    {
      get
      {
        return (UInt16Value) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "minute")]
    public UInt16Value Minute
    {
      get
      {
        return (UInt16Value) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "second")]
    public UInt16Value Second
    {
      get
      {
        return (UInt16Value) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "dateTimeGrouping")]
    public EnumValue<DateTimeGroupingValues> DateTimeGrouping
    {
      get
      {
        return (EnumValue<DateTimeGroupingValues>) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "year" == name)
        return (OpenXmlSimpleType) new UInt16Value();
      if ((int) namespaceId == 0 && "month" == name)
        return (OpenXmlSimpleType) new UInt16Value();
      if ((int) namespaceId == 0 && "day" == name)
        return (OpenXmlSimpleType) new UInt16Value();
      if ((int) namespaceId == 0 && "hour" == name)
        return (OpenXmlSimpleType) new UInt16Value();
      if ((int) namespaceId == 0 && "minute" == name)
        return (OpenXmlSimpleType) new UInt16Value();
      if ((int) namespaceId == 0 && "second" == name)
        return (OpenXmlSimpleType) new UInt16Value();
      if ((int) namespaceId == 0 && "dateTimeGrouping" == name)
        return (OpenXmlSimpleType) new EnumValue<DateTimeGroupingValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DateGroupItem>(deep);
    }
  }
}

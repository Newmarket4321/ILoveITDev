// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.RangeProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  public class RangeProperties : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[8]
    {
      "autoStart",
      "autoEnd",
      "groupBy",
      "startNum",
      "endNum",
      "startDate",
      "endDate",
      "groupInterval"
    };
    private static byte[] attributeNamespaceIds = new byte[8];
    private const string tagName = "rangePr";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11186;

    public override string LocalName
    {
      get
      {
        return "rangePr";
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
        return 11186;
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
        return RangeProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return RangeProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "autoStart")]
    public BooleanValue AutoStart
    {
      get
      {
        return (BooleanValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "autoEnd")]
    public BooleanValue AutoEnd
    {
      get
      {
        return (BooleanValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "groupBy")]
    public EnumValue<GroupByValues> GroupBy
    {
      get
      {
        return (EnumValue<GroupByValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "startNum")]
    public DoubleValue StartNumber
    {
      get
      {
        return (DoubleValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "endNum")]
    public DoubleValue EndNum
    {
      get
      {
        return (DoubleValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "startDate")]
    public DateTimeValue StartDate
    {
      get
      {
        return (DateTimeValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "endDate")]
    public DateTimeValue EndDate
    {
      get
      {
        return (DateTimeValue) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "groupInterval")]
    public DoubleValue GroupInterval
    {
      get
      {
        return (DoubleValue) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "autoStart" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "autoEnd" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "groupBy" == name)
        return (OpenXmlSimpleType) new EnumValue<GroupByValues>();
      if ((int) namespaceId == 0 && "startNum" == name)
        return (OpenXmlSimpleType) new DoubleValue();
      if ((int) namespaceId == 0 && "endNum" == name)
        return (OpenXmlSimpleType) new DoubleValue();
      if ((int) namespaceId == 0 && "startDate" == name)
        return (OpenXmlSimpleType) new DateTimeValue();
      if ((int) namespaceId == 0 && "endDate" == name)
        return (OpenXmlSimpleType) new DateTimeValue();
      if ((int) namespaceId == 0 && "groupInterval" == name)
        return (OpenXmlSimpleType) new DoubleValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<RangeProperties>(deep);
    }
  }
}

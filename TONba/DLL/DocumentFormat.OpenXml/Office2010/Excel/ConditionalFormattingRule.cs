// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.ConditionalFormattingRule
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Spreadsheet;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office.Excel.Formula))]
  [ChildElementInfo(typeof (ExtensionList), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ColorScale), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DataBar), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (IconSet), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (DifferentialType), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public class ConditionalFormattingRule : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[14]
    {
      "type",
      "priority",
      "stopIfTrue",
      "aboveAverage",
      "percent",
      "bottom",
      "operator",
      "text",
      "timePeriod",
      "rank",
      "stdDev",
      "equalAverage",
      "activePresent",
      "id"
    };
    private static byte[] attributeNamespaceIds = new byte[14];
    private const string tagName = "cfRule";
    private const byte tagNsId = 53;
    internal const int ElementTypeIdConst = 12996;

    public override string LocalName
    {
      get
      {
        return "cfRule";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 53;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12996;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return ConditionalFormattingRule.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ConditionalFormattingRule.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "type")]
    public EnumValue<ConditionalFormatValues> Type
    {
      get
      {
        return (EnumValue<ConditionalFormatValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "priority")]
    public Int32Value Priority
    {
      get
      {
        return (Int32Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "stopIfTrue")]
    public BooleanValue StopIfTrue
    {
      get
      {
        return (BooleanValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "aboveAverage")]
    public BooleanValue AboveAverage
    {
      get
      {
        return (BooleanValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "percent")]
    public BooleanValue Percent
    {
      get
      {
        return (BooleanValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "bottom")]
    public BooleanValue Bottom
    {
      get
      {
        return (BooleanValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "operator")]
    public EnumValue<ConditionalFormattingOperatorValues> Operator
    {
      get
      {
        return (EnumValue<ConditionalFormattingOperatorValues>) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "text")]
    public StringValue Text
    {
      get
      {
        return (StringValue) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "timePeriod")]
    public EnumValue<TimePeriodValues> TimePeriod
    {
      get
      {
        return (EnumValue<TimePeriodValues>) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "rank")]
    public UInt32Value Rank
    {
      get
      {
        return (UInt32Value) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "stdDev")]
    public Int32Value StandardDeviation
    {
      get
      {
        return (Int32Value) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "equalAverage")]
    public BooleanValue EqualAverage
    {
      get
      {
        return (BooleanValue) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "activePresent")]
    public BooleanValue ActivePresent
    {
      get
      {
        return (BooleanValue) this.Attributes[12];
      }
      set
      {
        this.Attributes[12] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "id")]
    public StringValue Id
    {
      get
      {
        return (StringValue) this.Attributes[13];
      }
      set
      {
        this.Attributes[13] = (OpenXmlSimpleType) value;
      }
    }

    public ConditionalFormattingRule()
    {
    }

    public ConditionalFormattingRule(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ConditionalFormattingRule(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ConditionalFormattingRule(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (32 == (int) namespaceId && "f" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office.Excel.Formula();
      if (53 == (int) namespaceId && "colorScale" == name)
        return (OpenXmlElement) new ColorScale();
      if (53 == (int) namespaceId && "dataBar" == name)
        return (OpenXmlElement) new DataBar();
      if (53 == (int) namespaceId && "iconSet" == name)
        return (OpenXmlElement) new IconSet();
      if (53 == (int) namespaceId && "dxf" == name)
        return (OpenXmlElement) new DifferentialType();
      if (53 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "type" == name)
        return (OpenXmlSimpleType) new EnumValue<ConditionalFormatValues>();
      if ((int) namespaceId == 0 && "priority" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "stopIfTrue" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "aboveAverage" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "percent" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "bottom" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "operator" == name)
        return (OpenXmlSimpleType) new EnumValue<ConditionalFormattingOperatorValues>();
      if ((int) namespaceId == 0 && "text" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "timePeriod" == name)
        return (OpenXmlSimpleType) new EnumValue<TimePeriodValues>();
      if ((int) namespaceId == 0 && "rank" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "stdDev" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "equalAverage" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "activePresent" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ConditionalFormattingRule>(deep);
    }
  }
}

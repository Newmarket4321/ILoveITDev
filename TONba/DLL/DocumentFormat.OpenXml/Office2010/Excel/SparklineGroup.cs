// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.SparklineGroup
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office.Excel;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
  [ChildElementInfo(typeof (LowMarkerColor), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Sparklines), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (SeriesColor), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (HighMarkerColor), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (NegativeColor), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (Formula))]
  [ChildElementInfo(typeof (MarkersColor), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (LastMarkerColor), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (AxisColor), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (FirstMarkerColor), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public class SparklineGroup : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[17]
    {
      "manualMax",
      "manualMin",
      "lineWeight",
      "type",
      "dateAxis",
      "displayEmptyCellsAs",
      "markers",
      "high",
      "low",
      "first",
      "last",
      "negative",
      "displayXAxis",
      "displayHidden",
      "minAxisType",
      "maxAxisType",
      "rightToLeft"
    };
    private static byte[] attributeNamespaceIds = new byte[17];
    private static readonly string[] eleTagNames = new string[10]
    {
      "colorSeries",
      "colorNegative",
      "colorAxis",
      "colorMarkers",
      "colorFirst",
      "colorLast",
      "colorHigh",
      "colorLow",
      "f",
      "sparklines"
    };
    private static readonly byte[] eleNamespaceIds = new byte[10]
    {
      (byte) 53,
      (byte) 53,
      (byte) 53,
      (byte) 53,
      (byte) 53,
      (byte) 53,
      (byte) 53,
      (byte) 53,
      (byte) 32,
      (byte) 53
    };
    private const string tagName = "sparklineGroup";
    private const byte tagNsId = 53;
    internal const int ElementTypeIdConst = 13001;

    public override string LocalName
    {
      get
      {
        return "sparklineGroup";
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
        return 13001;
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
        return SparklineGroup.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return SparklineGroup.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "manualMax")]
    public DoubleValue ManualMax
    {
      get
      {
        return (DoubleValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "manualMin")]
    public DoubleValue ManualMin
    {
      get
      {
        return (DoubleValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "lineWeight")]
    public DoubleValue LineWeight
    {
      get
      {
        return (DoubleValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "type")]
    public EnumValue<SparklineTypeValues> Type
    {
      get
      {
        return (EnumValue<SparklineTypeValues>) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "dateAxis")]
    public BooleanValue DateAxis
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

    [SchemaAttr(0, "displayEmptyCellsAs")]
    public EnumValue<DisplayBlanksAsValues> DisplayEmptyCellsAs
    {
      get
      {
        return (EnumValue<DisplayBlanksAsValues>) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "markers")]
    public BooleanValue Markers
    {
      get
      {
        return (BooleanValue) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "high")]
    public BooleanValue High
    {
      get
      {
        return (BooleanValue) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "low")]
    public BooleanValue Low
    {
      get
      {
        return (BooleanValue) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "first")]
    public BooleanValue First
    {
      get
      {
        return (BooleanValue) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "last")]
    public BooleanValue Last
    {
      get
      {
        return (BooleanValue) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "negative")]
    public BooleanValue Negative
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

    [SchemaAttr(0, "displayXAxis")]
    public BooleanValue DisplayXAxis
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

    [SchemaAttr(0, "displayHidden")]
    public BooleanValue DisplayHidden
    {
      get
      {
        return (BooleanValue) this.Attributes[13];
      }
      set
      {
        this.Attributes[13] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "minAxisType")]
    public EnumValue<SparklineAxisMinMaxValues> MinAxisType
    {
      get
      {
        return (EnumValue<SparklineAxisMinMaxValues>) this.Attributes[14];
      }
      set
      {
        this.Attributes[14] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "maxAxisType")]
    public EnumValue<SparklineAxisMinMaxValues> MaxAxisType
    {
      get
      {
        return (EnumValue<SparklineAxisMinMaxValues>) this.Attributes[15];
      }
      set
      {
        this.Attributes[15] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "rightToLeft")]
    public BooleanValue RightToLeft
    {
      get
      {
        return (BooleanValue) this.Attributes[16];
      }
      set
      {
        this.Attributes[16] = (OpenXmlSimpleType) value;
      }
    }

    public SparklineGroup()
    {
    }

    public SparklineGroup(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SparklineGroup(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SparklineGroup(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (53 == (int) namespaceId && "colorSeries" == name)
        return (OpenXmlElement) new SeriesColor();
      if (53 == (int) namespaceId && "colorNegative" == name)
        return (OpenXmlElement) new NegativeColor();
      if (53 == (int) namespaceId && "colorAxis" == name)
        return (OpenXmlElement) new AxisColor();
      if (53 == (int) namespaceId && "colorMarkers" == name)
        return (OpenXmlElement) new MarkersColor();
      if (53 == (int) namespaceId && "colorFirst" == name)
        return (OpenXmlElement) new FirstMarkerColor();
      if (53 == (int) namespaceId && "colorLast" == name)
        return (OpenXmlElement) new LastMarkerColor();
      if (53 == (int) namespaceId && "colorHigh" == name)
        return (OpenXmlElement) new HighMarkerColor();
      if (53 == (int) namespaceId && "colorLow" == name)
        return (OpenXmlElement) new LowMarkerColor();
      if (32 == (int) namespaceId && "f" == name)
        return (OpenXmlElement) new Formula();
      if (53 == (int) namespaceId && "sparklines" == name)
        return (OpenXmlElement) new Sparklines();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return SparklineGroup.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return SparklineGroup.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public SeriesColor SeriesColor
    {
      get
      {
        return this.GetElement<SeriesColor>(0);
      }
      set
      {
        this.SetElement<SeriesColor>(0, value);
      }
    }

    public NegativeColor NegativeColor
    {
      get
      {
        return this.GetElement<NegativeColor>(1);
      }
      set
      {
        this.SetElement<NegativeColor>(1, value);
      }
    }

    public AxisColor AxisColor
    {
      get
      {
        return this.GetElement<AxisColor>(2);
      }
      set
      {
        this.SetElement<AxisColor>(2, value);
      }
    }

    public MarkersColor MarkersColor
    {
      get
      {
        return this.GetElement<MarkersColor>(3);
      }
      set
      {
        this.SetElement<MarkersColor>(3, value);
      }
    }

    public FirstMarkerColor FirstMarkerColor
    {
      get
      {
        return this.GetElement<FirstMarkerColor>(4);
      }
      set
      {
        this.SetElement<FirstMarkerColor>(4, value);
      }
    }

    public LastMarkerColor LastMarkerColor
    {
      get
      {
        return this.GetElement<LastMarkerColor>(5);
      }
      set
      {
        this.SetElement<LastMarkerColor>(5, value);
      }
    }

    public HighMarkerColor HighMarkerColor
    {
      get
      {
        return this.GetElement<HighMarkerColor>(6);
      }
      set
      {
        this.SetElement<HighMarkerColor>(6, value);
      }
    }

    public LowMarkerColor LowMarkerColor
    {
      get
      {
        return this.GetElement<LowMarkerColor>(7);
      }
      set
      {
        this.SetElement<LowMarkerColor>(7, value);
      }
    }

    public Formula Formula
    {
      get
      {
        return this.GetElement<Formula>(8);
      }
      set
      {
        this.SetElement<Formula>(8, value);
      }
    }

    public Sparklines Sparklines
    {
      get
      {
        return this.GetElement<Sparklines>(9);
      }
      set
      {
        this.SetElement<Sparklines>(9, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "manualMax" == name)
        return (OpenXmlSimpleType) new DoubleValue();
      if ((int) namespaceId == 0 && "manualMin" == name)
        return (OpenXmlSimpleType) new DoubleValue();
      if ((int) namespaceId == 0 && "lineWeight" == name)
        return (OpenXmlSimpleType) new DoubleValue();
      if ((int) namespaceId == 0 && "type" == name)
        return (OpenXmlSimpleType) new EnumValue<SparklineTypeValues>();
      if ((int) namespaceId == 0 && "dateAxis" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "displayEmptyCellsAs" == name)
        return (OpenXmlSimpleType) new EnumValue<DisplayBlanksAsValues>();
      if ((int) namespaceId == 0 && "markers" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "high" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "low" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "first" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "last" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "negative" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "displayXAxis" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "displayHidden" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "minAxisType" == name)
        return (OpenXmlSimpleType) new EnumValue<SparklineAxisMinMaxValues>();
      if ((int) namespaceId == 0 && "maxAxisType" == name)
        return (OpenXmlSimpleType) new EnumValue<SparklineAxisMinMaxValues>();
      if ((int) namespaceId == 0 && "rightToLeft" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SparklineGroup>(deep);
    }
  }
}

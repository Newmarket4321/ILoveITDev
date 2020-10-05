// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle
{
  [ChildElementInfo(typeof (TrendlineLabel), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (AxisTitle), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (CategoryAxis), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ChartArea), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DataLabel), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DataLabelCallout), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DataPoint), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DataPoint3D), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DataPointLine), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DataPointMarker), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (MarkerLayoutProperties), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DataPointWireframe), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DataTableStyle), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DownBar), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DropLine), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ErrorBar), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Floor), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (GridlineMajor), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (GridlineMinor), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (HiLoLine), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (LeaderLine), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (LegendStyle), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (PlotArea), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (PlotArea3D), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (SeriesAxis), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (SeriesLine), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (TitleStyle), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (TrendlineStyle), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (UpBar), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ValueAxis), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Wall), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (OfficeArtExtensionList), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class ChartStyle : OpenXmlPartRootElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "id"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[32]
    {
      "axisTitle",
      "categoryAxis",
      "chartArea",
      "dataLabel",
      "dataLabelCallout",
      "dataPoint",
      "dataPoint3D",
      "dataPointLine",
      "dataPointMarker",
      "dataPointMarkerLayout",
      "dataPointWireframe",
      "dataTable",
      "downBar",
      "dropLine",
      "errorBar",
      "floor",
      "gridlineMajor",
      "gridlineMinor",
      "hiLoLine",
      "leaderLine",
      "legend",
      "plotArea",
      "plotArea3D",
      "seriesAxis",
      "seriesLine",
      "title",
      "trendline",
      "trendlineLabel",
      "upBar",
      "valueAxis",
      "wall",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[32]
    {
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65
    };
    private const string tagName = "chartStyle";
    private const byte tagNsId = 65;
    internal const int ElementTypeIdConst = 13257;

    public override string LocalName
    {
      get
      {
        return "chartStyle";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 65;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13257;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "id")]
    public UInt32Value Id
    {
      get
      {
        return (UInt32Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    internal ChartStyle(ChartStylePart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(ChartStylePart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public ChartStylePart ChartStylePart
    {
      get
      {
        return this.OpenXmlPart as ChartStylePart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public ChartStyle(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ChartStyle(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ChartStyle(string outerXml)
      : base(outerXml)
    {
    }

    public ChartStyle()
    {
    }

    public void Save(ChartStylePart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (65 == (int) namespaceId && "axisTitle" == name)
        return (OpenXmlElement) new AxisTitle();
      if (65 == (int) namespaceId && "categoryAxis" == name)
        return (OpenXmlElement) new CategoryAxis();
      if (65 == (int) namespaceId && "chartArea" == name)
        return (OpenXmlElement) new ChartArea();
      if (65 == (int) namespaceId && "dataLabel" == name)
        return (OpenXmlElement) new DataLabel();
      if (65 == (int) namespaceId && "dataLabelCallout" == name)
        return (OpenXmlElement) new DataLabelCallout();
      if (65 == (int) namespaceId && "dataPoint" == name)
        return (OpenXmlElement) new DataPoint();
      if (65 == (int) namespaceId && "dataPoint3D" == name)
        return (OpenXmlElement) new DataPoint3D();
      if (65 == (int) namespaceId && "dataPointLine" == name)
        return (OpenXmlElement) new DataPointLine();
      if (65 == (int) namespaceId && "dataPointMarker" == name)
        return (OpenXmlElement) new DataPointMarker();
      if (65 == (int) namespaceId && "dataPointMarkerLayout" == name)
        return (OpenXmlElement) new MarkerLayoutProperties();
      if (65 == (int) namespaceId && "dataPointWireframe" == name)
        return (OpenXmlElement) new DataPointWireframe();
      if (65 == (int) namespaceId && "dataTable" == name)
        return (OpenXmlElement) new DataTableStyle();
      if (65 == (int) namespaceId && "downBar" == name)
        return (OpenXmlElement) new DownBar();
      if (65 == (int) namespaceId && "dropLine" == name)
        return (OpenXmlElement) new DropLine();
      if (65 == (int) namespaceId && "errorBar" == name)
        return (OpenXmlElement) new ErrorBar();
      if (65 == (int) namespaceId && "floor" == name)
        return (OpenXmlElement) new Floor();
      if (65 == (int) namespaceId && "gridlineMajor" == name)
        return (OpenXmlElement) new GridlineMajor();
      if (65 == (int) namespaceId && "gridlineMinor" == name)
        return (OpenXmlElement) new GridlineMinor();
      if (65 == (int) namespaceId && "hiLoLine" == name)
        return (OpenXmlElement) new HiLoLine();
      if (65 == (int) namespaceId && "leaderLine" == name)
        return (OpenXmlElement) new LeaderLine();
      if (65 == (int) namespaceId && "legend" == name)
        return (OpenXmlElement) new LegendStyle();
      if (65 == (int) namespaceId && "plotArea" == name)
        return (OpenXmlElement) new PlotArea();
      if (65 == (int) namespaceId && "plotArea3D" == name)
        return (OpenXmlElement) new PlotArea3D();
      if (65 == (int) namespaceId && "seriesAxis" == name)
        return (OpenXmlElement) new SeriesAxis();
      if (65 == (int) namespaceId && "seriesLine" == name)
        return (OpenXmlElement) new SeriesLine();
      if (65 == (int) namespaceId && "title" == name)
        return (OpenXmlElement) new TitleStyle();
      if (65 == (int) namespaceId && "trendline" == name)
        return (OpenXmlElement) new TrendlineStyle();
      if (65 == (int) namespaceId && "trendlineLabel" == name)
        return (OpenXmlElement) new TrendlineLabel();
      if (65 == (int) namespaceId && "upBar" == name)
        return (OpenXmlElement) new UpBar();
      if (65 == (int) namespaceId && "valueAxis" == name)
        return (OpenXmlElement) new ValueAxis();
      if (65 == (int) namespaceId && "wall" == name)
        return (OpenXmlElement) new Wall();
      if (65 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new OfficeArtExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public AxisTitle AxisTitle
    {
      get
      {
        return this.GetElement<AxisTitle>(0);
      }
      set
      {
        this.SetElement<AxisTitle>(0, value);
      }
    }

    public CategoryAxis CategoryAxis
    {
      get
      {
        return this.GetElement<CategoryAxis>(1);
      }
      set
      {
        this.SetElement<CategoryAxis>(1, value);
      }
    }

    public ChartArea ChartArea
    {
      get
      {
        return this.GetElement<ChartArea>(2);
      }
      set
      {
        this.SetElement<ChartArea>(2, value);
      }
    }

    public DataLabel DataLabel
    {
      get
      {
        return this.GetElement<DataLabel>(3);
      }
      set
      {
        this.SetElement<DataLabel>(3, value);
      }
    }

    public DataLabelCallout DataLabelCallout
    {
      get
      {
        return this.GetElement<DataLabelCallout>(4);
      }
      set
      {
        this.SetElement<DataLabelCallout>(4, value);
      }
    }

    public DataPoint DataPoint
    {
      get
      {
        return this.GetElement<DataPoint>(5);
      }
      set
      {
        this.SetElement<DataPoint>(5, value);
      }
    }

    public DataPoint3D DataPoint3D
    {
      get
      {
        return this.GetElement<DataPoint3D>(6);
      }
      set
      {
        this.SetElement<DataPoint3D>(6, value);
      }
    }

    public DataPointLine DataPointLine
    {
      get
      {
        return this.GetElement<DataPointLine>(7);
      }
      set
      {
        this.SetElement<DataPointLine>(7, value);
      }
    }

    public DataPointMarker DataPointMarker
    {
      get
      {
        return this.GetElement<DataPointMarker>(8);
      }
      set
      {
        this.SetElement<DataPointMarker>(8, value);
      }
    }

    public MarkerLayoutProperties MarkerLayoutProperties
    {
      get
      {
        return this.GetElement<MarkerLayoutProperties>(9);
      }
      set
      {
        this.SetElement<MarkerLayoutProperties>(9, value);
      }
    }

    public DataPointWireframe DataPointWireframe
    {
      get
      {
        return this.GetElement<DataPointWireframe>(10);
      }
      set
      {
        this.SetElement<DataPointWireframe>(10, value);
      }
    }

    public DataTableStyle DataTableStyle
    {
      get
      {
        return this.GetElement<DataTableStyle>(11);
      }
      set
      {
        this.SetElement<DataTableStyle>(11, value);
      }
    }

    public DownBar DownBar
    {
      get
      {
        return this.GetElement<DownBar>(12);
      }
      set
      {
        this.SetElement<DownBar>(12, value);
      }
    }

    public DropLine DropLine
    {
      get
      {
        return this.GetElement<DropLine>(13);
      }
      set
      {
        this.SetElement<DropLine>(13, value);
      }
    }

    public ErrorBar ErrorBar
    {
      get
      {
        return this.GetElement<ErrorBar>(14);
      }
      set
      {
        this.SetElement<ErrorBar>(14, value);
      }
    }

    public Floor Floor
    {
      get
      {
        return this.GetElement<Floor>(15);
      }
      set
      {
        this.SetElement<Floor>(15, value);
      }
    }

    public GridlineMajor GridlineMajor
    {
      get
      {
        return this.GetElement<GridlineMajor>(16);
      }
      set
      {
        this.SetElement<GridlineMajor>(16, value);
      }
    }

    public GridlineMinor GridlineMinor
    {
      get
      {
        return this.GetElement<GridlineMinor>(17);
      }
      set
      {
        this.SetElement<GridlineMinor>(17, value);
      }
    }

    public HiLoLine HiLoLine
    {
      get
      {
        return this.GetElement<HiLoLine>(18);
      }
      set
      {
        this.SetElement<HiLoLine>(18, value);
      }
    }

    public LeaderLine LeaderLine
    {
      get
      {
        return this.GetElement<LeaderLine>(19);
      }
      set
      {
        this.SetElement<LeaderLine>(19, value);
      }
    }

    public LegendStyle LegendStyle
    {
      get
      {
        return this.GetElement<LegendStyle>(20);
      }
      set
      {
        this.SetElement<LegendStyle>(20, value);
      }
    }

    public PlotArea PlotArea
    {
      get
      {
        return this.GetElement<PlotArea>(21);
      }
      set
      {
        this.SetElement<PlotArea>(21, value);
      }
    }

    public PlotArea3D PlotArea3D
    {
      get
      {
        return this.GetElement<PlotArea3D>(22);
      }
      set
      {
        this.SetElement<PlotArea3D>(22, value);
      }
    }

    public SeriesAxis SeriesAxis
    {
      get
      {
        return this.GetElement<SeriesAxis>(23);
      }
      set
      {
        this.SetElement<SeriesAxis>(23, value);
      }
    }

    public SeriesLine SeriesLine
    {
      get
      {
        return this.GetElement<SeriesLine>(24);
      }
      set
      {
        this.SetElement<SeriesLine>(24, value);
      }
    }

    public TitleStyle TitleStyle
    {
      get
      {
        return this.GetElement<TitleStyle>(25);
      }
      set
      {
        this.SetElement<TitleStyle>(25, value);
      }
    }

    public TrendlineStyle TrendlineStyle
    {
      get
      {
        return this.GetElement<TrendlineStyle>(26);
      }
      set
      {
        this.SetElement<TrendlineStyle>(26, value);
      }
    }

    public TrendlineLabel TrendlineLabel
    {
      get
      {
        return this.GetElement<TrendlineLabel>(27);
      }
      set
      {
        this.SetElement<TrendlineLabel>(27, value);
      }
    }

    public UpBar UpBar
    {
      get
      {
        return this.GetElement<UpBar>(28);
      }
      set
      {
        this.SetElement<UpBar>(28, value);
      }
    }

    public ValueAxis ValueAxis
    {
      get
      {
        return this.GetElement<ValueAxis>(29);
      }
      set
      {
        this.SetElement<ValueAxis>(29, value);
      }
    }

    public Wall Wall
    {
      get
      {
        return this.GetElement<Wall>(30);
      }
      set
      {
        this.SetElement<Wall>(30, value);
      }
    }

    public OfficeArtExtensionList OfficeArtExtensionList
    {
      get
      {
        return this.GetElement<OfficeArtExtensionList>(31);
      }
      set
      {
        this.SetElement<OfficeArtExtensionList>(31, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "id" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle>(deep);
    }
  }
}

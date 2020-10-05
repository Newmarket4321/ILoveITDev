// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.PlotArea
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (RadarChart))]
  [ChildElementInfo(typeof (LineChart))]
  [ChildElementInfo(typeof (Line3DChart))]
  [ChildElementInfo(typeof (StockChart))]
  [ChildElementInfo(typeof (Layout))]
  [ChildElementInfo(typeof (ScatterChart))]
  [ChildElementInfo(typeof (PieChart))]
  [ChildElementInfo(typeof (Pie3DChart))]
  [ChildElementInfo(typeof (DoughnutChart))]
  [ChildElementInfo(typeof (BarChart))]
  [ChildElementInfo(typeof (Bar3DChart))]
  [ChildElementInfo(typeof (OfPieChart))]
  [ChildElementInfo(typeof (SurfaceChart))]
  [ChildElementInfo(typeof (Surface3DChart))]
  [ChildElementInfo(typeof (BubbleChart))]
  [ChildElementInfo(typeof (ValueAxis))]
  [ChildElementInfo(typeof (CategoryAxis))]
  [ChildElementInfo(typeof (DateAxis))]
  [ChildElementInfo(typeof (SeriesAxis))]
  [ChildElementInfo(typeof (DataTable))]
  [ChildElementInfo(typeof (ShapeProperties))]
  [ChildElementInfo(typeof (ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (AreaChart))]
  [ChildElementInfo(typeof (Area3DChart))]
  public class PlotArea : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[24]
    {
      "layout",
      "areaChart",
      "area3DChart",
      "lineChart",
      "line3DChart",
      "stockChart",
      "radarChart",
      "scatterChart",
      "pieChart",
      "pie3DChart",
      "doughnutChart",
      "barChart",
      "bar3DChart",
      "ofPieChart",
      "surfaceChart",
      "surface3DChart",
      "bubbleChart",
      "valAx",
      "catAx",
      "dateAx",
      "serAx",
      "dTable",
      "spPr",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[24]
    {
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11
    };
    private const string tagName = "plotArea";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10484;

    public override string LocalName
    {
      get
      {
        return "plotArea";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 11;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10484;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public PlotArea()
    {
    }

    public PlotArea(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PlotArea(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PlotArea(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "layout" == name)
        return (OpenXmlElement) new Layout();
      if (11 == (int) namespaceId && "areaChart" == name)
        return (OpenXmlElement) new AreaChart();
      if (11 == (int) namespaceId && "area3DChart" == name)
        return (OpenXmlElement) new Area3DChart();
      if (11 == (int) namespaceId && "lineChart" == name)
        return (OpenXmlElement) new LineChart();
      if (11 == (int) namespaceId && "line3DChart" == name)
        return (OpenXmlElement) new Line3DChart();
      if (11 == (int) namespaceId && "stockChart" == name)
        return (OpenXmlElement) new StockChart();
      if (11 == (int) namespaceId && "radarChart" == name)
        return (OpenXmlElement) new RadarChart();
      if (11 == (int) namespaceId && "scatterChart" == name)
        return (OpenXmlElement) new ScatterChart();
      if (11 == (int) namespaceId && "pieChart" == name)
        return (OpenXmlElement) new PieChart();
      if (11 == (int) namespaceId && "pie3DChart" == name)
        return (OpenXmlElement) new Pie3DChart();
      if (11 == (int) namespaceId && "doughnutChart" == name)
        return (OpenXmlElement) new DoughnutChart();
      if (11 == (int) namespaceId && "barChart" == name)
        return (OpenXmlElement) new BarChart();
      if (11 == (int) namespaceId && "bar3DChart" == name)
        return (OpenXmlElement) new Bar3DChart();
      if (11 == (int) namespaceId && "ofPieChart" == name)
        return (OpenXmlElement) new OfPieChart();
      if (11 == (int) namespaceId && "surfaceChart" == name)
        return (OpenXmlElement) new SurfaceChart();
      if (11 == (int) namespaceId && "surface3DChart" == name)
        return (OpenXmlElement) new Surface3DChart();
      if (11 == (int) namespaceId && "bubbleChart" == name)
        return (OpenXmlElement) new BubbleChart();
      if (11 == (int) namespaceId && "valAx" == name)
        return (OpenXmlElement) new ValueAxis();
      if (11 == (int) namespaceId && "catAx" == name)
        return (OpenXmlElement) new CategoryAxis();
      if (11 == (int) namespaceId && "dateAx" == name)
        return (OpenXmlElement) new DateAxis();
      if (11 == (int) namespaceId && "serAx" == name)
        return (OpenXmlElement) new SeriesAxis();
      if (11 == (int) namespaceId && "dTable" == name)
        return (OpenXmlElement) new DataTable();
      if (11 == (int) namespaceId && "spPr" == name)
        return (OpenXmlElement) new ShapeProperties();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return PlotArea.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return PlotArea.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Layout Layout
    {
      get
      {
        return this.GetElement<Layout>(0);
      }
      set
      {
        this.SetElement<Layout>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PlotArea>(deep);
    }
  }
}

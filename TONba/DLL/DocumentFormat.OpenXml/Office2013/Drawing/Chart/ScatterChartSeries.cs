// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing.Charts;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Drawing.Chart
{
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DataLabels))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Order))]
  [ChildElementInfo(typeof (SeriesText))]
  [ChildElementInfo(typeof (ChartShapeProperties))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Drawing.Charts.Marker))]
  [ChildElementInfo(typeof (DataPoint))]
  [ChildElementInfo(typeof (Index))]
  [ChildElementInfo(typeof (Trendline))]
  [ChildElementInfo(typeof (ErrorBars))]
  [ChildElementInfo(typeof (XValues))]
  [ChildElementInfo(typeof (YValues))]
  [ChildElementInfo(typeof (Smooth))]
  [ChildElementInfo(typeof (ScatterSerExtensionList))]
  public class ScatterChartSeries : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[13]
    {
      "idx",
      "order",
      "tx",
      "spPr",
      "marker",
      "dPt",
      "dLbls",
      "trendline",
      "errBars",
      "xVal",
      "yVal",
      "smooth",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[13]
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
      (byte) 11
    };
    private const string tagName = "ser";
    private const byte tagNsId = 64;
    internal const int ElementTypeIdConst = 13239;

    public override string LocalName
    {
      get
      {
        return "ser";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 64;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13239;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public ScatterChartSeries()
    {
    }

    public ScatterChartSeries(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ScatterChartSeries(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ScatterChartSeries(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "idx" == name)
        return (OpenXmlElement) new Index();
      if (11 == (int) namespaceId && "order" == name)
        return (OpenXmlElement) new Order();
      if (11 == (int) namespaceId && "tx" == name)
        return (OpenXmlElement) new SeriesText();
      if (11 == (int) namespaceId && "spPr" == name)
        return (OpenXmlElement) new ChartShapeProperties();
      if (11 == (int) namespaceId && "marker" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Drawing.Charts.Marker();
      if (11 == (int) namespaceId && "dPt" == name)
        return (OpenXmlElement) new DataPoint();
      if (11 == (int) namespaceId && "dLbls" == name)
        return (OpenXmlElement) new DataLabels();
      if (11 == (int) namespaceId && "trendline" == name)
        return (OpenXmlElement) new Trendline();
      if (11 == (int) namespaceId && "errBars" == name)
        return (OpenXmlElement) new ErrorBars();
      if (11 == (int) namespaceId && "xVal" == name)
        return (OpenXmlElement) new XValues();
      if (11 == (int) namespaceId && "yVal" == name)
        return (OpenXmlElement) new YValues();
      if (11 == (int) namespaceId && "smooth" == name)
        return (OpenXmlElement) new Smooth();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ScatterSerExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ScatterChartSeries.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ScatterChartSeries.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Index Index
    {
      get
      {
        return this.GetElement<Index>(0);
      }
      set
      {
        this.SetElement<Index>(0, value);
      }
    }

    public Order Order
    {
      get
      {
        return this.GetElement<Order>(1);
      }
      set
      {
        this.SetElement<Order>(1, value);
      }
    }

    public SeriesText SeriesText
    {
      get
      {
        return this.GetElement<SeriesText>(2);
      }
      set
      {
        this.SetElement<SeriesText>(2, value);
      }
    }

    public ChartShapeProperties ChartShapeProperties
    {
      get
      {
        return this.GetElement<ChartShapeProperties>(3);
      }
      set
      {
        this.SetElement<ChartShapeProperties>(3, value);
      }
    }

    public DocumentFormat.OpenXml.Drawing.Charts.Marker Marker
    {
      get
      {
        return this.GetElement<DocumentFormat.OpenXml.Drawing.Charts.Marker>(4);
      }
      set
      {
        this.SetElement<DocumentFormat.OpenXml.Drawing.Charts.Marker>(4, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ScatterChartSeries>(deep);
    }
  }
}

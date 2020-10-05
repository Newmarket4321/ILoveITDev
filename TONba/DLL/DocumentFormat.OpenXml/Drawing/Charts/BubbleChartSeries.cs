// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.BubbleChartSeries
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (XValues))]
  [ChildElementInfo(typeof (Order))]
  [ChildElementInfo(typeof (SeriesText))]
  [ChildElementInfo(typeof (ChartShapeProperties))]
  [ChildElementInfo(typeof (PictureOptions))]
  [ChildElementInfo(typeof (InvertIfNegative))]
  [ChildElementInfo(typeof (DataPoint))]
  [ChildElementInfo(typeof (DataLabels))]
  [ChildElementInfo(typeof (Trendline))]
  [ChildElementInfo(typeof (ErrorBars))]
  [ChildElementInfo(typeof (Index))]
  [ChildElementInfo(typeof (YValues))]
  [ChildElementInfo(typeof (BubbleSize))]
  [ChildElementInfo(typeof (Bubble3D))]
  [ChildElementInfo(typeof (BubbleSerExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  public class BubbleChartSeries : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[15]
    {
      "idx",
      "order",
      "tx",
      "spPr",
      "pictureOptions",
      "invertIfNegative",
      "dPt",
      "dLbls",
      "trendline",
      "errBars",
      "xVal",
      "yVal",
      "bubbleSize",
      "bubble3D",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[15]
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
      (byte) 11
    };
    private const string tagName = "ser";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10615;

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
        return 11;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10615;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public BubbleChartSeries()
    {
    }

    public BubbleChartSeries(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public BubbleChartSeries(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public BubbleChartSeries(string outerXml)
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
      if (11 == (int) namespaceId && "pictureOptions" == name)
        return (OpenXmlElement) new PictureOptions();
      if (11 == (int) namespaceId && "invertIfNegative" == name)
        return (OpenXmlElement) new InvertIfNegative();
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
      if (11 == (int) namespaceId && "bubbleSize" == name)
        return (OpenXmlElement) new BubbleSize();
      if (11 == (int) namespaceId && "bubble3D" == name)
        return (OpenXmlElement) new Bubble3D();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new BubbleSerExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return BubbleChartSeries.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return BubbleChartSeries.eleNamespaceIds;
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

    public PictureOptions PictureOptions
    {
      get
      {
        return this.GetElement<PictureOptions>(4);
      }
      set
      {
        this.SetElement<PictureOptions>(4, value);
      }
    }

    public InvertIfNegative InvertIfNegative
    {
      get
      {
        return this.GetElement<InvertIfNegative>(5);
      }
      set
      {
        this.SetElement<InvertIfNegative>(5, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<BubbleChartSeries>(deep);
    }
  }
}

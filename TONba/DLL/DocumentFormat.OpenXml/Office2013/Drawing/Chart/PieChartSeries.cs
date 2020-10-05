// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing.Charts;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Drawing.Chart
{
  [ChildElementInfo(typeof (PictureOptions))]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Index))]
  [ChildElementInfo(typeof (Order))]
  [ChildElementInfo(typeof (SeriesText))]
  [ChildElementInfo(typeof (ChartShapeProperties))]
  [ChildElementInfo(typeof (DataLabels))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Drawing.Charts.Explosion))]
  [ChildElementInfo(typeof (DataPoint))]
  [ChildElementInfo(typeof (Values))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (CategoryAxisData))]
  [ChildElementInfo(typeof (PieSerExtensionList))]
  public class PieChartSeries : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[11]
    {
      "idx",
      "order",
      "tx",
      "spPr",
      "pictureOptions",
      "explosion",
      "dPt",
      "dLbls",
      "cat",
      "val",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[11]
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
      (byte) 11
    };
    private const string tagName = "ser";
    private const byte tagNsId = 64;
    internal const int ElementTypeIdConst = 13241;

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
        return 13241;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public PieChartSeries()
    {
    }

    public PieChartSeries(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PieChartSeries(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PieChartSeries(string outerXml)
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
      if (11 == (int) namespaceId && "explosion" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Drawing.Charts.Explosion();
      if (11 == (int) namespaceId && "dPt" == name)
        return (OpenXmlElement) new DataPoint();
      if (11 == (int) namespaceId && "dLbls" == name)
        return (OpenXmlElement) new DataLabels();
      if (11 == (int) namespaceId && "cat" == name)
        return (OpenXmlElement) new CategoryAxisData();
      if (11 == (int) namespaceId && "val" == name)
        return (OpenXmlElement) new Values();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new PieSerExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return PieChartSeries.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return PieChartSeries.eleNamespaceIds;
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

    public DocumentFormat.OpenXml.Drawing.Charts.Explosion Explosion
    {
      get
      {
        return this.GetElement<DocumentFormat.OpenXml.Drawing.Charts.Explosion>(5);
      }
      set
      {
        this.SetElement<DocumentFormat.OpenXml.Drawing.Charts.Explosion>(5, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PieChartSeries>(deep);
    }
  }
}

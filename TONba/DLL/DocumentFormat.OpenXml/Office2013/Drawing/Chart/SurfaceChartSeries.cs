// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Drawing.Chart.SurfaceChartSeries
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing.Charts;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Drawing.Chart
{
  [ChildElementInfo(typeof (SeriesText))]
  [ChildElementInfo(typeof (SurfaceSerExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Drawing.Charts.Bubble3D))]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ChartShapeProperties))]
  [ChildElementInfo(typeof (PictureOptions))]
  [ChildElementInfo(typeof (CategoryAxisData))]
  [ChildElementInfo(typeof (Values))]
  [ChildElementInfo(typeof (Index))]
  [ChildElementInfo(typeof (Order))]
  public class SurfaceChartSeries : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[9]
    {
      "idx",
      "order",
      "tx",
      "spPr",
      "pictureOptions",
      "cat",
      "val",
      "bubble3D",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[9]
    {
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
    internal const int ElementTypeIdConst = 13244;

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
        return 13244;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public SurfaceChartSeries()
    {
    }

    public SurfaceChartSeries(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SurfaceChartSeries(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SurfaceChartSeries(string outerXml)
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
      if (11 == (int) namespaceId && "cat" == name)
        return (OpenXmlElement) new CategoryAxisData();
      if (11 == (int) namespaceId && "val" == name)
        return (OpenXmlElement) new Values();
      if (11 == (int) namespaceId && "bubble3D" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Drawing.Charts.Bubble3D();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new SurfaceSerExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return SurfaceChartSeries.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return SurfaceChartSeries.eleNamespaceIds;
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

    public CategoryAxisData CategoryAxisData
    {
      get
      {
        return this.GetElement<CategoryAxisData>(5);
      }
      set
      {
        this.SetElement<CategoryAxisData>(5, value);
      }
    }

    public Values Values
    {
      get
      {
        return this.GetElement<Values>(6);
      }
      set
      {
        this.SetElement<Values>(6, value);
      }
    }

    public DocumentFormat.OpenXml.Drawing.Charts.Bubble3D Bubble3D
    {
      get
      {
        return this.GetElement<DocumentFormat.OpenXml.Drawing.Charts.Bubble3D>(7);
      }
      set
      {
        this.SetElement<DocumentFormat.OpenXml.Drawing.Charts.Bubble3D>(7, value);
      }
    }

    public SurfaceSerExtensionList SurfaceSerExtensionList
    {
      get
      {
        return this.GetElement<SurfaceSerExtensionList>(8);
      }
      set
      {
        this.SetElement<SurfaceSerExtensionList>(8, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SurfaceChartSeries>(deep);
    }
  }
}

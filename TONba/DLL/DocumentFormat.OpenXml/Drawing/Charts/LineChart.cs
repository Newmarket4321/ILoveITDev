// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.LineChart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (DropLines))]
  [ChildElementInfo(typeof (Grouping))]
  [ChildElementInfo(typeof (VaryColors))]
  [ChildElementInfo(typeof (LineChartSeries))]
  [ChildElementInfo(typeof (DataLabels))]
  [ChildElementInfo(typeof (ShowMarker))]
  [ChildElementInfo(typeof (LineChartExtensionList))]
  [ChildElementInfo(typeof (UpDownBars))]
  [ChildElementInfo(typeof (HighLowLines))]
  [ChildElementInfo(typeof (Smooth))]
  [ChildElementInfo(typeof (AxisId))]
  public class LineChart : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[11]
    {
      "grouping",
      "varyColors",
      "ser",
      "dLbls",
      "dropLines",
      "hiLowLines",
      "upDownBars",
      "marker",
      "smooth",
      "axId",
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
    private const string tagName = "lineChart";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10511;

    public override string LocalName
    {
      get
      {
        return "lineChart";
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
        return 10511;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public LineChart()
    {
    }

    public LineChart(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public LineChart(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public LineChart(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "grouping" == name)
        return (OpenXmlElement) new Grouping();
      if (11 == (int) namespaceId && "varyColors" == name)
        return (OpenXmlElement) new VaryColors();
      if (11 == (int) namespaceId && "ser" == name)
        return (OpenXmlElement) new LineChartSeries();
      if (11 == (int) namespaceId && "dLbls" == name)
        return (OpenXmlElement) new DataLabels();
      if (11 == (int) namespaceId && "dropLines" == name)
        return (OpenXmlElement) new DropLines();
      if (11 == (int) namespaceId && "hiLowLines" == name)
        return (OpenXmlElement) new HighLowLines();
      if (11 == (int) namespaceId && "upDownBars" == name)
        return (OpenXmlElement) new UpDownBars();
      if (11 == (int) namespaceId && "marker" == name)
        return (OpenXmlElement) new ShowMarker();
      if (11 == (int) namespaceId && "smooth" == name)
        return (OpenXmlElement) new Smooth();
      if (11 == (int) namespaceId && "axId" == name)
        return (OpenXmlElement) new AxisId();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new LineChartExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return LineChart.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return LineChart.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Grouping Grouping
    {
      get
      {
        return this.GetElement<Grouping>(0);
      }
      set
      {
        this.SetElement<Grouping>(0, value);
      }
    }

    public VaryColors VaryColors
    {
      get
      {
        return this.GetElement<VaryColors>(1);
      }
      set
      {
        this.SetElement<VaryColors>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<LineChart>(deep);
    }
  }
}

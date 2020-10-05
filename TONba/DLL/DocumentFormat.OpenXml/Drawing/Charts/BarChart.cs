// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.BarChart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (GapWidth))]
  [ChildElementInfo(typeof (BarChartExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (BarDirection))]
  [ChildElementInfo(typeof (BarGrouping))]
  [ChildElementInfo(typeof (AxisId))]
  [ChildElementInfo(typeof (BarChartSeries))]
  [ChildElementInfo(typeof (DataLabels))]
  [ChildElementInfo(typeof (VaryColors))]
  [ChildElementInfo(typeof (Overlap))]
  [ChildElementInfo(typeof (SeriesLines))]
  public class BarChart : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[10]
    {
      "barDir",
      "grouping",
      "varyColors",
      "ser",
      "dLbls",
      "gapWidth",
      "overlap",
      "serLines",
      "axId",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[10]
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
      (byte) 11
    };
    private const string tagName = "barChart";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10519;

    public override string LocalName
    {
      get
      {
        return "barChart";
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
        return 10519;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public BarChart()
    {
    }

    public BarChart(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public BarChart(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public BarChart(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "barDir" == name)
        return (OpenXmlElement) new BarDirection();
      if (11 == (int) namespaceId && "grouping" == name)
        return (OpenXmlElement) new BarGrouping();
      if (11 == (int) namespaceId && "varyColors" == name)
        return (OpenXmlElement) new VaryColors();
      if (11 == (int) namespaceId && "ser" == name)
        return (OpenXmlElement) new BarChartSeries();
      if (11 == (int) namespaceId && "dLbls" == name)
        return (OpenXmlElement) new DataLabels();
      if (11 == (int) namespaceId && "gapWidth" == name)
        return (OpenXmlElement) new GapWidth();
      if (11 == (int) namespaceId && "overlap" == name)
        return (OpenXmlElement) new Overlap();
      if (11 == (int) namespaceId && "serLines" == name)
        return (OpenXmlElement) new SeriesLines();
      if (11 == (int) namespaceId && "axId" == name)
        return (OpenXmlElement) new AxisId();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new BarChartExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return BarChart.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return BarChart.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public BarDirection BarDirection
    {
      get
      {
        return this.GetElement<BarDirection>(0);
      }
      set
      {
        this.SetElement<BarDirection>(0, value);
      }
    }

    public BarGrouping BarGrouping
    {
      get
      {
        return this.GetElement<BarGrouping>(1);
      }
      set
      {
        this.SetElement<BarGrouping>(1, value);
      }
    }

    public VaryColors VaryColors
    {
      get
      {
        return this.GetElement<VaryColors>(2);
      }
      set
      {
        this.SetElement<VaryColors>(2, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<BarChart>(deep);
    }
  }
}

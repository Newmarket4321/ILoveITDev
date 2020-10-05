// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.Bar3DChart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (DataLabels))]
  [ChildElementInfo(typeof (Bar3DChartExtensionList))]
  [ChildElementInfo(typeof (BarGrouping))]
  [ChildElementInfo(typeof (VaryColors))]
  [ChildElementInfo(typeof (BarChartSeries))]
  [ChildElementInfo(typeof (BarDirection))]
  [ChildElementInfo(typeof (GapWidth))]
  [ChildElementInfo(typeof (GapDepth))]
  [ChildElementInfo(typeof (Shape))]
  [ChildElementInfo(typeof (AxisId))]
  public class Bar3DChart : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[10]
    {
      "barDir",
      "grouping",
      "varyColors",
      "ser",
      "dLbls",
      "gapWidth",
      "gapDepth",
      "shape",
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
    private const string tagName = "bar3DChart";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10520;

    public override string LocalName
    {
      get
      {
        return "bar3DChart";
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
        return 10520;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Bar3DChart()
    {
    }

    public Bar3DChart(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Bar3DChart(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Bar3DChart(string outerXml)
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
      if (11 == (int) namespaceId && "gapDepth" == name)
        return (OpenXmlElement) new GapDepth();
      if (11 == (int) namespaceId && "shape" == name)
        return (OpenXmlElement) new Shape();
      if (11 == (int) namespaceId && "axId" == name)
        return (OpenXmlElement) new AxisId();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new Bar3DChartExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Bar3DChart.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Bar3DChart.eleNamespaceIds;
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
      return (OpenXmlElement) this.CloneImp<Bar3DChart>(deep);
    }
  }
}

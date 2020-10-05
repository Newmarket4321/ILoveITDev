// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.OfPieChart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (CustomSplit))]
  [ChildElementInfo(typeof (ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (OfPieType))]
  [ChildElementInfo(typeof (VaryColors))]
  [ChildElementInfo(typeof (PieChartSeries))]
  [ChildElementInfo(typeof (DataLabels))]
  [ChildElementInfo(typeof (GapWidth))]
  [ChildElementInfo(typeof (SplitType))]
  [ChildElementInfo(typeof (SplitPosition))]
  [ChildElementInfo(typeof (SecondPieSize))]
  [ChildElementInfo(typeof (SeriesLines))]
  public class OfPieChart : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[11]
    {
      "ofPieType",
      "varyColors",
      "ser",
      "dLbls",
      "gapWidth",
      "splitType",
      "splitPos",
      "custSplit",
      "secondPieSize",
      "serLines",
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
    private const string tagName = "ofPieChart";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10521;

    public override string LocalName
    {
      get
      {
        return "ofPieChart";
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
        return 10521;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public OfPieChart()
    {
    }

    public OfPieChart(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public OfPieChart(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public OfPieChart(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "ofPieType" == name)
        return (OpenXmlElement) new OfPieType();
      if (11 == (int) namespaceId && "varyColors" == name)
        return (OpenXmlElement) new VaryColors();
      if (11 == (int) namespaceId && "ser" == name)
        return (OpenXmlElement) new PieChartSeries();
      if (11 == (int) namespaceId && "dLbls" == name)
        return (OpenXmlElement) new DataLabels();
      if (11 == (int) namespaceId && "gapWidth" == name)
        return (OpenXmlElement) new GapWidth();
      if (11 == (int) namespaceId && "splitType" == name)
        return (OpenXmlElement) new SplitType();
      if (11 == (int) namespaceId && "splitPos" == name)
        return (OpenXmlElement) new SplitPosition();
      if (11 == (int) namespaceId && "custSplit" == name)
        return (OpenXmlElement) new CustomSplit();
      if (11 == (int) namespaceId && "secondPieSize" == name)
        return (OpenXmlElement) new SecondPieSize();
      if (11 == (int) namespaceId && "serLines" == name)
        return (OpenXmlElement) new SeriesLines();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return OfPieChart.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return OfPieChart.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public OfPieType OfPieType
    {
      get
      {
        return this.GetElement<OfPieType>(0);
      }
      set
      {
        this.SetElement<OfPieType>(0, value);
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
      return (OpenXmlElement) this.CloneImp<OfPieChart>(deep);
    }
  }
}

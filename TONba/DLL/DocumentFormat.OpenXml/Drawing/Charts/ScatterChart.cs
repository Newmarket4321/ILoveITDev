// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.ScatterChart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ScatterChartExtensionList))]
  [ChildElementInfo(typeof (VaryColors))]
  [ChildElementInfo(typeof (ScatterStyle))]
  [ChildElementInfo(typeof (ScatterChartSeries))]
  [ChildElementInfo(typeof (DataLabels))]
  [ChildElementInfo(typeof (AxisId))]
  public class ScatterChart : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[6]
    {
      "scatterStyle",
      "varyColors",
      "ser",
      "dLbls",
      "axId",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[6]
    {
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11
    };
    private const string tagName = "scatterChart";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10515;

    public override string LocalName
    {
      get
      {
        return "scatterChart";
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
        return 10515;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public ScatterChart()
    {
    }

    public ScatterChart(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ScatterChart(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ScatterChart(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "scatterStyle" == name)
        return (OpenXmlElement) new ScatterStyle();
      if (11 == (int) namespaceId && "varyColors" == name)
        return (OpenXmlElement) new VaryColors();
      if (11 == (int) namespaceId && "ser" == name)
        return (OpenXmlElement) new ScatterChartSeries();
      if (11 == (int) namespaceId && "dLbls" == name)
        return (OpenXmlElement) new DataLabels();
      if (11 == (int) namespaceId && "axId" == name)
        return (OpenXmlElement) new AxisId();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ScatterChartExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ScatterChart.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ScatterChart.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ScatterStyle ScatterStyle
    {
      get
      {
        return this.GetElement<ScatterStyle>(0);
      }
      set
      {
        this.SetElement<ScatterStyle>(0, value);
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
      return (OpenXmlElement) this.CloneImp<ScatterChart>(deep);
    }
  }
}

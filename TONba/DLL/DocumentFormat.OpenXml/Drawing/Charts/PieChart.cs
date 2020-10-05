// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.PieChart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (VaryColors))]
  [ChildElementInfo(typeof (FirstSliceAngle))]
  [ChildElementInfo(typeof (PieChartExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (PieChartSeries))]
  [ChildElementInfo(typeof (DataLabels))]
  public class PieChart : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[5]
    {
      "varyColors",
      "ser",
      "dLbls",
      "firstSliceAng",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[5]
    {
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11
    };
    private const string tagName = "pieChart";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10516;

    public override string LocalName
    {
      get
      {
        return "pieChart";
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
        return 10516;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public PieChart()
    {
    }

    public PieChart(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PieChart(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PieChart(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "varyColors" == name)
        return (OpenXmlElement) new VaryColors();
      if (11 == (int) namespaceId && "ser" == name)
        return (OpenXmlElement) new PieChartSeries();
      if (11 == (int) namespaceId && "dLbls" == name)
        return (OpenXmlElement) new DataLabels();
      if (11 == (int) namespaceId && "firstSliceAng" == name)
        return (OpenXmlElement) new FirstSliceAngle();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new PieChartExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return PieChart.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return PieChart.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public VaryColors VaryColors
    {
      get
      {
        return this.GetElement<VaryColors>(0);
      }
      set
      {
        this.SetElement<VaryColors>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PieChart>(deep);
    }
  }
}

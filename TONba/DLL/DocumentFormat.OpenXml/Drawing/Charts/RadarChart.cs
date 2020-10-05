// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.RadarChart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (RadarStyle))]
  [ChildElementInfo(typeof (DataLabels))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (RadarChartSeries))]
  [ChildElementInfo(typeof (VaryColors))]
  [ChildElementInfo(typeof (AxisId))]
  [ChildElementInfo(typeof (RadarChartExtensionList))]
  public class RadarChart : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[6]
    {
      "radarStyle",
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
    private const string tagName = "radarChart";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10514;

    public override string LocalName
    {
      get
      {
        return "radarChart";
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
        return 10514;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public RadarChart()
    {
    }

    public RadarChart(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public RadarChart(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public RadarChart(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "radarStyle" == name)
        return (OpenXmlElement) new RadarStyle();
      if (11 == (int) namespaceId && "varyColors" == name)
        return (OpenXmlElement) new VaryColors();
      if (11 == (int) namespaceId && "ser" == name)
        return (OpenXmlElement) new RadarChartSeries();
      if (11 == (int) namespaceId && "dLbls" == name)
        return (OpenXmlElement) new DataLabels();
      if (11 == (int) namespaceId && "axId" == name)
        return (OpenXmlElement) new AxisId();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new RadarChartExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return RadarChart.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return RadarChart.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public RadarStyle RadarStyle
    {
      get
      {
        return this.GetElement<RadarStyle>(0);
      }
      set
      {
        this.SetElement<RadarStyle>(0, value);
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
      return (OpenXmlElement) this.CloneImp<RadarChart>(deep);
    }
  }
}

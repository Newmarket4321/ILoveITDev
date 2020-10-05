// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.SurfaceChart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (SurfaceChartExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Wireframe))]
  [ChildElementInfo(typeof (SurfaceChartSeries))]
  [ChildElementInfo(typeof (BandFormats))]
  [ChildElementInfo(typeof (AxisId))]
  public class SurfaceChart : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[5]
    {
      "wireframe",
      "ser",
      "bandFmts",
      "axId",
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
    private const string tagName = "surfaceChart";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10522;

    public override string LocalName
    {
      get
      {
        return "surfaceChart";
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
        return 10522;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public SurfaceChart()
    {
    }

    public SurfaceChart(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SurfaceChart(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SurfaceChart(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "wireframe" == name)
        return (OpenXmlElement) new Wireframe();
      if (11 == (int) namespaceId && "ser" == name)
        return (OpenXmlElement) new SurfaceChartSeries();
      if (11 == (int) namespaceId && "bandFmts" == name)
        return (OpenXmlElement) new BandFormats();
      if (11 == (int) namespaceId && "axId" == name)
        return (OpenXmlElement) new AxisId();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new SurfaceChartExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return SurfaceChart.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return SurfaceChart.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Wireframe Wireframe
    {
      get
      {
        return this.GetElement<Wireframe>(0);
      }
      set
      {
        this.SetElement<Wireframe>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SurfaceChart>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredRadarSeries
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Drawing.Chart
{
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (RadarChartSeries), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class FilteredRadarSeries : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[1]
    {
      "ser"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 64
    };
    private const string tagName = "filteredRadarSeries";
    private const byte tagNsId = 64;
    internal const int ElementTypeIdConst = 13223;

    public override string LocalName
    {
      get
      {
        return "filteredRadarSeries";
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
        return 13223;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public FilteredRadarSeries()
    {
    }

    public FilteredRadarSeries(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public FilteredRadarSeries(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public FilteredRadarSeries(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (64 == (int) namespaceId && "ser" == name)
        return (OpenXmlElement) new RadarChartSeries();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return FilteredRadarSeries.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return FilteredRadarSeries.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public RadarChartSeries RadarChartSeries
    {
      get
      {
        return this.GetElement<RadarChartSeries>(0);
      }
      set
      {
        this.SetElement<RadarChartSeries>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<FilteredRadarSeries>(deep);
    }
  }
}

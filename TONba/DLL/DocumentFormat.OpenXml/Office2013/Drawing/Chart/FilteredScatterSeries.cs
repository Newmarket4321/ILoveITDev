// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredScatterSeries
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Drawing.Chart
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ScatterChartSeries), FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class FilteredScatterSeries : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[1]
    {
      "ser"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 64
    };
    private const string tagName = "filteredScatterSeries";
    private const byte tagNsId = 64;
    internal const int ElementTypeIdConst = 13224;

    public override string LocalName
    {
      get
      {
        return "filteredScatterSeries";
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
        return 13224;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public FilteredScatterSeries()
    {
    }

    public FilteredScatterSeries(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public FilteredScatterSeries(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public FilteredScatterSeries(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (64 == (int) namespaceId && "ser" == name)
        return (OpenXmlElement) new ScatterChartSeries();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return FilteredScatterSeries.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return FilteredScatterSeries.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ScatterChartSeries ScatterChartSeries
    {
      get
      {
        return this.GetElement<ScatterChartSeries>(0);
      }
      set
      {
        this.SetElement<ScatterChartSeries>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<FilteredScatterSeries>(deep);
    }
  }
}

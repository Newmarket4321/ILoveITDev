// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredPieSeries
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Drawing.Chart
{
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (PieChartSeries), FileFormatVersions.Office2013)]
  public class FilteredPieSeries : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[1]
    {
      "ser"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 64
    };
    private const string tagName = "filteredPieSeries";
    private const byte tagNsId = 64;
    internal const int ElementTypeIdConst = 13222;

    public override string LocalName
    {
      get
      {
        return "filteredPieSeries";
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
        return 13222;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public FilteredPieSeries()
    {
    }

    public FilteredPieSeries(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public FilteredPieSeries(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public FilteredPieSeries(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (64 == (int) namespaceId && "ser" == name)
        return (OpenXmlElement) new PieChartSeries();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return FilteredPieSeries.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return FilteredPieSeries.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public PieChartSeries PieChartSeries
    {
      get
      {
        return this.GetElement<PieChartSeries>(0);
      }
      set
      {
        this.SetElement<PieChartSeries>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<FilteredPieSeries>(deep);
    }
  }
}

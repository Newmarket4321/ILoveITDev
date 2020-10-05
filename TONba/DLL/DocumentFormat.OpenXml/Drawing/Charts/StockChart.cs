// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.StockChart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (DataLabels))]
  [ChildElementInfo(typeof (StockChartExtensionList))]
  [ChildElementInfo(typeof (LineChartSeries))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (DropLines))]
  [ChildElementInfo(typeof (HighLowLines))]
  [ChildElementInfo(typeof (UpDownBars))]
  [ChildElementInfo(typeof (AxisId))]
  public class StockChart : OpenXmlCompositeElement
  {
    private const string tagName = "stockChart";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10513;

    public override string LocalName
    {
      get
      {
        return "stockChart";
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
        return 10513;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public StockChart()
    {
    }

    public StockChart(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public StockChart(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public StockChart(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "ser" == name)
        return (OpenXmlElement) new LineChartSeries();
      if (11 == (int) namespaceId && "dLbls" == name)
        return (OpenXmlElement) new DataLabels();
      if (11 == (int) namespaceId && "dropLines" == name)
        return (OpenXmlElement) new DropLines();
      if (11 == (int) namespaceId && "hiLowLines" == name)
        return (OpenXmlElement) new HighLowLines();
      if (11 == (int) namespaceId && "upDownBars" == name)
        return (OpenXmlElement) new UpDownBars();
      if (11 == (int) namespaceId && "axId" == name)
        return (OpenXmlElement) new AxisId();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new StockChartExtensionList();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<StockChart>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.DataLabels
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (ShowBubbleSize))]
  [ChildElementInfo(typeof (Delete))]
  [ChildElementInfo(typeof (NumberingFormat))]
  [ChildElementInfo(typeof (ChartShapeProperties))]
  [ChildElementInfo(typeof (TextProperties))]
  [ChildElementInfo(typeof (DataLabelPosition))]
  [ChildElementInfo(typeof (ShowLegendKey))]
  [ChildElementInfo(typeof (ShowValue))]
  [ChildElementInfo(typeof (ShowCategoryName))]
  [ChildElementInfo(typeof (ShowSeriesName))]
  [ChildElementInfo(typeof (ShowPercent))]
  [ChildElementInfo(typeof (DataLabel))]
  [ChildElementInfo(typeof (Separator))]
  [ChildElementInfo(typeof (ShowLeaderLines))]
  [ChildElementInfo(typeof (LeaderLines))]
  [ChildElementInfo(typeof (DLblsExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  public class DataLabels : OpenXmlCompositeElement
  {
    private const string tagName = "dLbls";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10369;

    public override string LocalName
    {
      get
      {
        return "dLbls";
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
        return 10369;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public DataLabels()
    {
    }

    public DataLabels(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DataLabels(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DataLabels(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "dLbl" == name)
        return (OpenXmlElement) new DataLabel();
      if (11 == (int) namespaceId && "delete" == name)
        return (OpenXmlElement) new Delete();
      if (11 == (int) namespaceId && "numFmt" == name)
        return (OpenXmlElement) new NumberingFormat();
      if (11 == (int) namespaceId && "spPr" == name)
        return (OpenXmlElement) new ChartShapeProperties();
      if (11 == (int) namespaceId && "txPr" == name)
        return (OpenXmlElement) new TextProperties();
      if (11 == (int) namespaceId && "dLblPos" == name)
        return (OpenXmlElement) new DataLabelPosition();
      if (11 == (int) namespaceId && "showLegendKey" == name)
        return (OpenXmlElement) new ShowLegendKey();
      if (11 == (int) namespaceId && "showVal" == name)
        return (OpenXmlElement) new ShowValue();
      if (11 == (int) namespaceId && "showCatName" == name)
        return (OpenXmlElement) new ShowCategoryName();
      if (11 == (int) namespaceId && "showSerName" == name)
        return (OpenXmlElement) new ShowSeriesName();
      if (11 == (int) namespaceId && "showPercent" == name)
        return (OpenXmlElement) new ShowPercent();
      if (11 == (int) namespaceId && "showBubbleSize" == name)
        return (OpenXmlElement) new ShowBubbleSize();
      if (11 == (int) namespaceId && "separator" == name)
        return (OpenXmlElement) new Separator();
      if (11 == (int) namespaceId && "showLeaderLines" == name)
        return (OpenXmlElement) new ShowLeaderLines();
      if (11 == (int) namespaceId && "leaderLines" == name)
        return (OpenXmlElement) new LeaderLines();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new DLblsExtensionList();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DataLabels>(deep);
    }
  }
}

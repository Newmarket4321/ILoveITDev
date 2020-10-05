// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.DataLabel
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (Layout))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (DataLabelPosition))]
  [ChildElementInfo(typeof (Index))]
  [ChildElementInfo(typeof (Delete))]
  [ChildElementInfo(typeof (ChartText))]
  [ChildElementInfo(typeof (NumberingFormat))]
  [ChildElementInfo(typeof (ChartShapeProperties))]
  [ChildElementInfo(typeof (TextProperties))]
  [ChildElementInfo(typeof (ShowSeriesName))]
  [ChildElementInfo(typeof (DLblExtensionList))]
  [ChildElementInfo(typeof (ShowValue))]
  [ChildElementInfo(typeof (ShowCategoryName))]
  [ChildElementInfo(typeof (ShowLegendKey))]
  [ChildElementInfo(typeof (ShowPercent))]
  [ChildElementInfo(typeof (ShowBubbleSize))]
  [ChildElementInfo(typeof (Separator))]
  public class DataLabel : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[16]
    {
      "idx",
      "delete",
      "layout",
      "tx",
      "numFmt",
      "spPr",
      "txPr",
      "dLblPos",
      "showLegendKey",
      "showVal",
      "showCatName",
      "showSerName",
      "showPercent",
      "showBubbleSize",
      "separator",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[16]
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
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11
    };
    private const string tagName = "dLbl";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10508;

    public override string LocalName
    {
      get
      {
        return "dLbl";
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
        return 10508;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public DataLabel()
    {
    }

    public DataLabel(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DataLabel(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DataLabel(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "idx" == name)
        return (OpenXmlElement) new Index();
      if (11 == (int) namespaceId && "delete" == name)
        return (OpenXmlElement) new Delete();
      if (11 == (int) namespaceId && "layout" == name)
        return (OpenXmlElement) new Layout();
      if (11 == (int) namespaceId && "tx" == name)
        return (OpenXmlElement) new ChartText();
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
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new DLblExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DataLabel.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DataLabel.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Index Index
    {
      get
      {
        return this.GetElement<Index>(0);
      }
      set
      {
        this.SetElement<Index>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DataLabel>(deep);
    }
  }
}

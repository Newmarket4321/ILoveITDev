// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.Chartsheet
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (HeaderFooter))]
  [ChildElementInfo(typeof (ExtensionList))]
  [ChildElementInfo(typeof (ChartSheetViews))]
  [ChildElementInfo(typeof (ChartSheetProtection))]
  [ChildElementInfo(typeof (CustomChartsheetViews))]
  [ChildElementInfo(typeof (PageMargins))]
  [ChildElementInfo(typeof (ChartSheetPageSetup))]
  [ChildElementInfo(typeof (ChartSheetProperties))]
  [ChildElementInfo(typeof (Drawing))]
  [ChildElementInfo(typeof (LegacyDrawing))]
  [ChildElementInfo(typeof (LegacyDrawingHeaderFooter))]
  [ChildElementInfo(typeof (DrawingHeaderFooter), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (Picture))]
  [ChildElementInfo(typeof (WebPublishItems))]
  public class Chartsheet : OpenXmlPartRootElement
  {
    private static readonly string[] eleTagNames = new string[14]
    {
      "sheetPr",
      "sheetViews",
      "sheetProtection",
      "customSheetViews",
      "pageMargins",
      "pageSetup",
      "headerFooter",
      "drawing",
      "legacyDrawing",
      "legacyDrawingHF",
      "drawingHF",
      "picture",
      "webPublishItems",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[14]
    {
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "chartsheet";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11106;

    public override string LocalName
    {
      get
      {
        return "chartsheet";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 22;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11106;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal Chartsheet(ChartsheetPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(ChartsheetPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public ChartsheetPart ChartsheetPart
    {
      get
      {
        return this.OpenXmlPart as ChartsheetPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public Chartsheet(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Chartsheet(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Chartsheet(string outerXml)
      : base(outerXml)
    {
    }

    public Chartsheet()
    {
    }

    public void Save(ChartsheetPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "sheetPr" == name)
        return (OpenXmlElement) new ChartSheetProperties();
      if (22 == (int) namespaceId && "sheetViews" == name)
        return (OpenXmlElement) new ChartSheetViews();
      if (22 == (int) namespaceId && "sheetProtection" == name)
        return (OpenXmlElement) new ChartSheetProtection();
      if (22 == (int) namespaceId && "customSheetViews" == name)
        return (OpenXmlElement) new CustomChartsheetViews();
      if (22 == (int) namespaceId && "pageMargins" == name)
        return (OpenXmlElement) new PageMargins();
      if (22 == (int) namespaceId && "pageSetup" == name)
        return (OpenXmlElement) new ChartSheetPageSetup();
      if (22 == (int) namespaceId && "headerFooter" == name)
        return (OpenXmlElement) new HeaderFooter();
      if (22 == (int) namespaceId && "drawing" == name)
        return (OpenXmlElement) new Drawing();
      if (22 == (int) namespaceId && "legacyDrawing" == name)
        return (OpenXmlElement) new LegacyDrawing();
      if (22 == (int) namespaceId && "legacyDrawingHF" == name)
        return (OpenXmlElement) new LegacyDrawingHeaderFooter();
      if (22 == (int) namespaceId && "drawingHF" == name)
        return (OpenXmlElement) new DrawingHeaderFooter();
      if (22 == (int) namespaceId && "picture" == name)
        return (OpenXmlElement) new Picture();
      if (22 == (int) namespaceId && "webPublishItems" == name)
        return (OpenXmlElement) new WebPublishItems();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Chartsheet.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Chartsheet.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ChartSheetProperties ChartSheetProperties
    {
      get
      {
        return this.GetElement<ChartSheetProperties>(0);
      }
      set
      {
        this.SetElement<ChartSheetProperties>(0, value);
      }
    }

    public ChartSheetViews ChartSheetViews
    {
      get
      {
        return this.GetElement<ChartSheetViews>(1);
      }
      set
      {
        this.SetElement<ChartSheetViews>(1, value);
      }
    }

    public ChartSheetProtection ChartSheetProtection
    {
      get
      {
        return this.GetElement<ChartSheetProtection>(2);
      }
      set
      {
        this.SetElement<ChartSheetProtection>(2, value);
      }
    }

    public CustomChartsheetViews CustomChartsheetViews
    {
      get
      {
        return this.GetElement<CustomChartsheetViews>(3);
      }
      set
      {
        this.SetElement<CustomChartsheetViews>(3, value);
      }
    }

    public PageMargins PageMargins
    {
      get
      {
        return this.GetElement<PageMargins>(4);
      }
      set
      {
        this.SetElement<PageMargins>(4, value);
      }
    }

    public ChartSheetPageSetup ChartSheetPageSetup
    {
      get
      {
        return this.GetElement<ChartSheetPageSetup>(5);
      }
      set
      {
        this.SetElement<ChartSheetPageSetup>(5, value);
      }
    }

    public HeaderFooter HeaderFooter
    {
      get
      {
        return this.GetElement<HeaderFooter>(6);
      }
      set
      {
        this.SetElement<HeaderFooter>(6, value);
      }
    }

    public Drawing Drawing
    {
      get
      {
        return this.GetElement<Drawing>(7);
      }
      set
      {
        this.SetElement<Drawing>(7, value);
      }
    }

    public LegacyDrawing LegacyDrawing
    {
      get
      {
        return this.GetElement<LegacyDrawing>(8);
      }
      set
      {
        this.SetElement<LegacyDrawing>(8, value);
      }
    }

    public LegacyDrawingHeaderFooter LegacyDrawingHeaderFooter
    {
      get
      {
        return this.GetElement<LegacyDrawingHeaderFooter>(9);
      }
      set
      {
        this.SetElement<LegacyDrawingHeaderFooter>(9, value);
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    public DrawingHeaderFooter DrawingHeaderFooter
    {
      get
      {
        return this.GetElement<DrawingHeaderFooter>(10);
      }
      set
      {
        this.SetElement<DrawingHeaderFooter>(10, value);
      }
    }

    public Picture Picture
    {
      get
      {
        return this.GetElement<Picture>(11);
      }
      set
      {
        this.SetElement<Picture>(11, value);
      }
    }

    public WebPublishItems WebPublishItems
    {
      get
      {
        return this.GetElement<WebPublishItems>(12);
      }
      set
      {
        this.SetElement<WebPublishItems>(12, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(13);
      }
      set
      {
        this.SetElement<ExtensionList>(13, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Chartsheet>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.Worksheet
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (SheetCalculationProperties))]
  [ChildElementInfo(typeof (WorksheetExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (SheetProperties))]
  [ChildElementInfo(typeof (SheetDimension))]
  [ChildElementInfo(typeof (SheetViews))]
  [ChildElementInfo(typeof (SheetFormatProperties))]
  [ChildElementInfo(typeof (Columns))]
  [ChildElementInfo(typeof (SheetData))]
  [ChildElementInfo(typeof (SheetProtection))]
  [ChildElementInfo(typeof (ProtectedRanges))]
  [ChildElementInfo(typeof (Scenarios))]
  [ChildElementInfo(typeof (AutoFilter))]
  [ChildElementInfo(typeof (SortState))]
  [ChildElementInfo(typeof (DataConsolidate))]
  [ChildElementInfo(typeof (CustomSheetViews))]
  [ChildElementInfo(typeof (MergeCells))]
  [ChildElementInfo(typeof (PhoneticProperties))]
  [ChildElementInfo(typeof (ConditionalFormatting))]
  [ChildElementInfo(typeof (DataValidations))]
  [ChildElementInfo(typeof (Hyperlinks))]
  [ChildElementInfo(typeof (PrintOptions))]
  [ChildElementInfo(typeof (PageMargins))]
  [ChildElementInfo(typeof (PageSetup))]
  [ChildElementInfo(typeof (HeaderFooter))]
  [ChildElementInfo(typeof (RowBreaks))]
  [ChildElementInfo(typeof (ColumnBreaks))]
  [ChildElementInfo(typeof (CustomProperties))]
  [ChildElementInfo(typeof (CellWatches))]
  [ChildElementInfo(typeof (IgnoredErrors))]
  [ChildElementInfo(typeof (Drawing))]
  [ChildElementInfo(typeof (LegacyDrawing))]
  [ChildElementInfo(typeof (LegacyDrawingHeaderFooter))]
  [ChildElementInfo(typeof (DrawingHeaderFooter))]
  [ChildElementInfo(typeof (Picture))]
  [ChildElementInfo(typeof (OleObjects))]
  [ChildElementInfo(typeof (Controls))]
  [ChildElementInfo(typeof (WebPublishItems))]
  [ChildElementInfo(typeof (TableParts))]
  public class Worksheet : OpenXmlPartRootElement
  {
    private static readonly string[] eleTagNames = new string[38]
    {
      "sheetPr",
      "dimension",
      "sheetViews",
      "sheetFormatPr",
      "cols",
      "sheetData",
      "sheetCalcPr",
      "sheetProtection",
      "protectedRanges",
      "scenarios",
      "autoFilter",
      "sortState",
      "dataConsolidate",
      "customSheetViews",
      "mergeCells",
      "phoneticPr",
      "conditionalFormatting",
      "dataValidations",
      "hyperlinks",
      "printOptions",
      "pageMargins",
      "pageSetup",
      "headerFooter",
      "rowBreaks",
      "colBreaks",
      "customProperties",
      "cellWatches",
      "ignoredErrors",
      "drawing",
      "legacyDrawing",
      "legacyDrawingHF",
      "drawingHF",
      "picture",
      "oleObjects",
      "controls",
      "webPublishItems",
      "tableParts",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[38]
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
    private const string tagName = "worksheet";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11105;

    public override string LocalName
    {
      get
      {
        return "worksheet";
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
        return 11105;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal Worksheet(WorksheetPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(WorksheetPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public WorksheetPart WorksheetPart
    {
      get
      {
        return this.OpenXmlPart as WorksheetPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public Worksheet(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Worksheet(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Worksheet(string outerXml)
      : base(outerXml)
    {
    }

    public Worksheet()
    {
    }

    public void Save(WorksheetPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "sheetPr" == name)
        return (OpenXmlElement) new SheetProperties();
      if (22 == (int) namespaceId && "dimension" == name)
        return (OpenXmlElement) new SheetDimension();
      if (22 == (int) namespaceId && "sheetViews" == name)
        return (OpenXmlElement) new SheetViews();
      if (22 == (int) namespaceId && "sheetFormatPr" == name)
        return (OpenXmlElement) new SheetFormatProperties();
      if (22 == (int) namespaceId && "cols" == name)
        return (OpenXmlElement) new Columns();
      if (22 == (int) namespaceId && "sheetData" == name)
        return (OpenXmlElement) new SheetData();
      if (22 == (int) namespaceId && "sheetCalcPr" == name)
        return (OpenXmlElement) new SheetCalculationProperties();
      if (22 == (int) namespaceId && "sheetProtection" == name)
        return (OpenXmlElement) new SheetProtection();
      if (22 == (int) namespaceId && "protectedRanges" == name)
        return (OpenXmlElement) new ProtectedRanges();
      if (22 == (int) namespaceId && "scenarios" == name)
        return (OpenXmlElement) new Scenarios();
      if (22 == (int) namespaceId && "autoFilter" == name)
        return (OpenXmlElement) new AutoFilter();
      if (22 == (int) namespaceId && "sortState" == name)
        return (OpenXmlElement) new SortState();
      if (22 == (int) namespaceId && "dataConsolidate" == name)
        return (OpenXmlElement) new DataConsolidate();
      if (22 == (int) namespaceId && "customSheetViews" == name)
        return (OpenXmlElement) new CustomSheetViews();
      if (22 == (int) namespaceId && "mergeCells" == name)
        return (OpenXmlElement) new MergeCells();
      if (22 == (int) namespaceId && "phoneticPr" == name)
        return (OpenXmlElement) new PhoneticProperties();
      if (22 == (int) namespaceId && "conditionalFormatting" == name)
        return (OpenXmlElement) new ConditionalFormatting();
      if (22 == (int) namespaceId && "dataValidations" == name)
        return (OpenXmlElement) new DataValidations();
      if (22 == (int) namespaceId && "hyperlinks" == name)
        return (OpenXmlElement) new Hyperlinks();
      if (22 == (int) namespaceId && "printOptions" == name)
        return (OpenXmlElement) new PrintOptions();
      if (22 == (int) namespaceId && "pageMargins" == name)
        return (OpenXmlElement) new PageMargins();
      if (22 == (int) namespaceId && "pageSetup" == name)
        return (OpenXmlElement) new PageSetup();
      if (22 == (int) namespaceId && "headerFooter" == name)
        return (OpenXmlElement) new HeaderFooter();
      if (22 == (int) namespaceId && "rowBreaks" == name)
        return (OpenXmlElement) new RowBreaks();
      if (22 == (int) namespaceId && "colBreaks" == name)
        return (OpenXmlElement) new ColumnBreaks();
      if (22 == (int) namespaceId && "customProperties" == name)
        return (OpenXmlElement) new CustomProperties();
      if (22 == (int) namespaceId && "cellWatches" == name)
        return (OpenXmlElement) new CellWatches();
      if (22 == (int) namespaceId && "ignoredErrors" == name)
        return (OpenXmlElement) new IgnoredErrors();
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
      if (22 == (int) namespaceId && "oleObjects" == name)
        return (OpenXmlElement) new OleObjects();
      if (22 == (int) namespaceId && "controls" == name)
        return (OpenXmlElement) new Controls();
      if (22 == (int) namespaceId && "webPublishItems" == name)
        return (OpenXmlElement) new WebPublishItems();
      if (22 == (int) namespaceId && "tableParts" == name)
        return (OpenXmlElement) new TableParts();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new WorksheetExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Worksheet.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Worksheet.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public SheetProperties SheetProperties
    {
      get
      {
        return this.GetElement<SheetProperties>(0);
      }
      set
      {
        this.SetElement<SheetProperties>(0, value);
      }
    }

    public SheetDimension SheetDimension
    {
      get
      {
        return this.GetElement<SheetDimension>(1);
      }
      set
      {
        this.SetElement<SheetDimension>(1, value);
      }
    }

    public SheetViews SheetViews
    {
      get
      {
        return this.GetElement<SheetViews>(2);
      }
      set
      {
        this.SetElement<SheetViews>(2, value);
      }
    }

    public SheetFormatProperties SheetFormatProperties
    {
      get
      {
        return this.GetElement<SheetFormatProperties>(3);
      }
      set
      {
        this.SetElement<SheetFormatProperties>(3, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Worksheet>(deep);
    }
  }
}

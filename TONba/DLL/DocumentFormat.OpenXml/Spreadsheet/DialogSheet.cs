// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.DialogSheet
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (SheetFormatProperties))]
  [ChildElementInfo(typeof (LegacyDrawing))]
  [ChildElementInfo(typeof (LegacyDrawingHeaderFooter))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (SheetViews))]
  [ChildElementInfo(typeof (HeaderFooter))]
  [ChildElementInfo(typeof (ExtensionList))]
  [ChildElementInfo(typeof (CustomSheetViews))]
  [ChildElementInfo(typeof (PrintOptions))]
  [ChildElementInfo(typeof (PageMargins))]
  [ChildElementInfo(typeof (PageSetup))]
  [ChildElementInfo(typeof (SheetProtection))]
  [ChildElementInfo(typeof (Drawing))]
  [ChildElementInfo(typeof (SheetProperties))]
  [ChildElementInfo(typeof (DrawingHeaderFooter), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (OleObjects))]
  [ChildElementInfo(typeof (Controls), FileFormatVersions.Office2010)]
  public class DialogSheet : OpenXmlPartRootElement
  {
    private static readonly string[] eleTagNames = new string[16]
    {
      "sheetPr",
      "sheetViews",
      "sheetFormatPr",
      "sheetProtection",
      "customSheetViews",
      "printOptions",
      "pageMargins",
      "pageSetup",
      "headerFooter",
      "drawing",
      "legacyDrawing",
      "legacyDrawingHF",
      "drawingHF",
      "oleObjects",
      "controls",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[16]
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
      (byte) 22
    };
    private const string tagName = "dialogsheet";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11107;

    public override string LocalName
    {
      get
      {
        return "dialogsheet";
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
        return 11107;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal DialogSheet(DialogsheetPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(DialogsheetPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public DialogsheetPart DialogsheetPart
    {
      get
      {
        return this.OpenXmlPart as DialogsheetPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public DialogSheet(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DialogSheet(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DialogSheet(string outerXml)
      : base(outerXml)
    {
    }

    public DialogSheet()
    {
    }

    public void Save(DialogsheetPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "sheetPr" == name)
        return (OpenXmlElement) new SheetProperties();
      if (22 == (int) namespaceId && "sheetViews" == name)
        return (OpenXmlElement) new SheetViews();
      if (22 == (int) namespaceId && "sheetFormatPr" == name)
        return (OpenXmlElement) new SheetFormatProperties();
      if (22 == (int) namespaceId && "sheetProtection" == name)
        return (OpenXmlElement) new SheetProtection();
      if (22 == (int) namespaceId && "customSheetViews" == name)
        return (OpenXmlElement) new CustomSheetViews();
      if (22 == (int) namespaceId && "printOptions" == name)
        return (OpenXmlElement) new PrintOptions();
      if (22 == (int) namespaceId && "pageMargins" == name)
        return (OpenXmlElement) new PageMargins();
      if (22 == (int) namespaceId && "pageSetup" == name)
        return (OpenXmlElement) new PageSetup();
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
      if (22 == (int) namespaceId && "oleObjects" == name)
        return (OpenXmlElement) new OleObjects();
      if (22 == (int) namespaceId && "controls" == name)
        return (OpenXmlElement) new Controls();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DialogSheet.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DialogSheet.eleNamespaceIds;
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

    public SheetViews SheetViews
    {
      get
      {
        return this.GetElement<SheetViews>(1);
      }
      set
      {
        this.SetElement<SheetViews>(1, value);
      }
    }

    public SheetFormatProperties SheetFormatProperties
    {
      get
      {
        return this.GetElement<SheetFormatProperties>(2);
      }
      set
      {
        this.SetElement<SheetFormatProperties>(2, value);
      }
    }

    public SheetProtection SheetProtection
    {
      get
      {
        return this.GetElement<SheetProtection>(3);
      }
      set
      {
        this.SetElement<SheetProtection>(3, value);
      }
    }

    public CustomSheetViews CustomSheetViews
    {
      get
      {
        return this.GetElement<CustomSheetViews>(4);
      }
      set
      {
        this.SetElement<CustomSheetViews>(4, value);
      }
    }

    public PrintOptions PrintOptions
    {
      get
      {
        return this.GetElement<PrintOptions>(5);
      }
      set
      {
        this.SetElement<PrintOptions>(5, value);
      }
    }

    public PageMargins PageMargins
    {
      get
      {
        return this.GetElement<PageMargins>(6);
      }
      set
      {
        this.SetElement<PageMargins>(6, value);
      }
    }

    public PageSetup PageSetup
    {
      get
      {
        return this.GetElement<PageSetup>(7);
      }
      set
      {
        this.SetElement<PageSetup>(7, value);
      }
    }

    public HeaderFooter HeaderFooter
    {
      get
      {
        return this.GetElement<HeaderFooter>(8);
      }
      set
      {
        this.SetElement<HeaderFooter>(8, value);
      }
    }

    public Drawing Drawing
    {
      get
      {
        return this.GetElement<Drawing>(9);
      }
      set
      {
        this.SetElement<Drawing>(9, value);
      }
    }

    public LegacyDrawing LegacyDrawing
    {
      get
      {
        return this.GetElement<LegacyDrawing>(10);
      }
      set
      {
        this.SetElement<LegacyDrawing>(10, value);
      }
    }

    public LegacyDrawingHeaderFooter LegacyDrawingHeaderFooter
    {
      get
      {
        return this.GetElement<LegacyDrawingHeaderFooter>(11);
      }
      set
      {
        this.SetElement<LegacyDrawingHeaderFooter>(11, value);
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    public DrawingHeaderFooter DrawingHeaderFooter
    {
      get
      {
        return this.GetElement<DrawingHeaderFooter>(12);
      }
      set
      {
        this.SetElement<DrawingHeaderFooter>(12, value);
      }
    }

    public OleObjects OleObjects
    {
      get
      {
        return this.GetElement<OleObjects>(13);
      }
      set
      {
        this.SetElement<OleObjects>(13, value);
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    public Controls Controls
    {
      get
      {
        return this.GetElement<Controls>(14);
      }
      set
      {
        this.SetElement<Controls>(14, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(15);
      }
      set
      {
        this.SetElement<ExtensionList>(15, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DialogSheet>(deep);
    }
  }
}

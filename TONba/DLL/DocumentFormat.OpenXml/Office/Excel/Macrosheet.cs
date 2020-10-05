// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.Excel.Macrosheet
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office.Excel
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (SheetProperties))]
  [ChildElementInfo(typeof (SheetDimension))]
  [ChildElementInfo(typeof (SheetViews))]
  [ChildElementInfo(typeof (SheetFormatProperties))]
  [ChildElementInfo(typeof (Columns))]
  [ChildElementInfo(typeof (SheetData))]
  [ChildElementInfo(typeof (SheetProtection))]
  [ChildElementInfo(typeof (AutoFilter))]
  [ChildElementInfo(typeof (SortState))]
  [ChildElementInfo(typeof (DataConsolidate))]
  [ChildElementInfo(typeof (CustomSheetViews))]
  [ChildElementInfo(typeof (PhoneticProperties))]
  [ChildElementInfo(typeof (ConditionalFormatting))]
  [ChildElementInfo(typeof (PrintOptions))]
  [ChildElementInfo(typeof (PageMargins))]
  [ChildElementInfo(typeof (PageSetup))]
  [ChildElementInfo(typeof (HeaderFooter))]
  [ChildElementInfo(typeof (RowBreaks))]
  [ChildElementInfo(typeof (ColumnBreaks))]
  [ChildElementInfo(typeof (CustomProperties))]
  [ChildElementInfo(typeof (Drawing))]
  [ChildElementInfo(typeof (LegacyDrawing))]
  [ChildElementInfo(typeof (LegacyDrawingHeaderFooter))]
  [ChildElementInfo(typeof (Picture))]
  [ChildElementInfo(typeof (OleObjects))]
  [ChildElementInfo(typeof (DrawingHeaderFooter), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (ExtensionList))]
  public class Macrosheet : OpenXmlPartRootElement
  {
    private static readonly string[] eleTagNames = new string[27]
    {
      "sheetPr",
      "dimension",
      "sheetViews",
      "sheetFormatPr",
      "cols",
      "sheetData",
      "sheetProtection",
      "autoFilter",
      "sortState",
      "dataConsolidate",
      "customSheetViews",
      "phoneticPr",
      "conditionalFormatting",
      "printOptions",
      "pageMargins",
      "pageSetup",
      "headerFooter",
      "rowBreaks",
      "colBreaks",
      "customProperties",
      "drawing",
      "legacyDrawing",
      "legacyDrawingHF",
      "picture",
      "oleObjects",
      "drawingHF",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[27]
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
      (byte) 22
    };
    private const string tagName = "macrosheet";
    private const byte tagNsId = 32;
    internal const int ElementTypeIdConst = 12600;

    public override string LocalName
    {
      get
      {
        return "macrosheet";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 32;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12600;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal Macrosheet(MacroSheetPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(MacroSheetPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public MacroSheetPart MacroSheetPart
    {
      get
      {
        return this.OpenXmlPart as MacroSheetPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public Macrosheet(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Macrosheet(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Macrosheet(string outerXml)
      : base(outerXml)
    {
    }

    public Macrosheet()
    {
    }

    public void Save(MacroSheetPart openXmlPart)
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
      if (22 == (int) namespaceId && "sheetProtection" == name)
        return (OpenXmlElement) new SheetProtection();
      if (22 == (int) namespaceId && "autoFilter" == name)
        return (OpenXmlElement) new AutoFilter();
      if (22 == (int) namespaceId && "sortState" == name)
        return (OpenXmlElement) new SortState();
      if (22 == (int) namespaceId && "dataConsolidate" == name)
        return (OpenXmlElement) new DataConsolidate();
      if (22 == (int) namespaceId && "customSheetViews" == name)
        return (OpenXmlElement) new CustomSheetViews();
      if (22 == (int) namespaceId && "phoneticPr" == name)
        return (OpenXmlElement) new PhoneticProperties();
      if (22 == (int) namespaceId && "conditionalFormatting" == name)
        return (OpenXmlElement) new ConditionalFormatting();
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
      if (22 == (int) namespaceId && "drawing" == name)
        return (OpenXmlElement) new Drawing();
      if (22 == (int) namespaceId && "legacyDrawing" == name)
        return (OpenXmlElement) new LegacyDrawing();
      if (22 == (int) namespaceId && "legacyDrawingHF" == name)
        return (OpenXmlElement) new LegacyDrawingHeaderFooter();
      if (22 == (int) namespaceId && "picture" == name)
        return (OpenXmlElement) new Picture();
      if (22 == (int) namespaceId && "oleObjects" == name)
        return (OpenXmlElement) new OleObjects();
      if (22 == (int) namespaceId && "drawingHF" == name)
        return (OpenXmlElement) new DrawingHeaderFooter();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Macrosheet.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Macrosheet.eleNamespaceIds;
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
      return (OpenXmlElement) this.CloneImp<Macrosheet>(deep);
    }
  }
}

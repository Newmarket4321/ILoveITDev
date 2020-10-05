// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.CustomSheetView
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (RowBreaks))]
  [ChildElementInfo(typeof (PrintOptions))]
  [ChildElementInfo(typeof (PageMargins))]
  [ChildElementInfo(typeof (Pane))]
  [ChildElementInfo(typeof (Selection))]
  [ChildElementInfo(typeof (HeaderFooter))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (PageSetup))]
  [ChildElementInfo(typeof (ColumnBreaks))]
  [ChildElementInfo(typeof (AutoFilter))]
  [ChildElementInfo(typeof (ExtensionList))]
  public class CustomSheetView : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[20]
    {
      "guid",
      "scale",
      "colorId",
      "showPageBreaks",
      "showFormulas",
      "showGridLines",
      "showRowCol",
      "outlineSymbols",
      "zeroValues",
      "fitToPage",
      "printArea",
      "filter",
      "showAutoFilter",
      "hiddenRows",
      "hiddenColumns",
      "state",
      "filterUnique",
      "view",
      "showRuler",
      "topLeftCell"
    };
    private static byte[] attributeNamespaceIds = new byte[20];
    private static readonly string[] eleTagNames = new string[10]
    {
      "pane",
      "selection",
      "rowBreaks",
      "colBreaks",
      "pageMargins",
      "printOptions",
      "pageSetup",
      "headerFooter",
      "autoFilter",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[10]
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
      (byte) 22
    };
    private const string tagName = "customSheetView";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11282;

    public override string LocalName
    {
      get
      {
        return "customSheetView";
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
        return 11282;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return CustomSheetView.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return CustomSheetView.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "guid")]
    public StringValue Guid
    {
      get
      {
        return (StringValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "scale")]
    public UInt32Value Scale
    {
      get
      {
        return (UInt32Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "colorId")]
    public UInt32Value ColorId
    {
      get
      {
        return (UInt32Value) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "showPageBreaks")]
    public BooleanValue ShowPageBreaks
    {
      get
      {
        return (BooleanValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "showFormulas")]
    public BooleanValue ShowFormulas
    {
      get
      {
        return (BooleanValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "showGridLines")]
    public BooleanValue ShowGridLines
    {
      get
      {
        return (BooleanValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "showRowCol")]
    public BooleanValue ShowRowColumn
    {
      get
      {
        return (BooleanValue) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "outlineSymbols")]
    public BooleanValue OutlineSymbols
    {
      get
      {
        return (BooleanValue) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "zeroValues")]
    public BooleanValue ZeroValues
    {
      get
      {
        return (BooleanValue) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "fitToPage")]
    public BooleanValue FitToPage
    {
      get
      {
        return (BooleanValue) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "printArea")]
    public BooleanValue PrintArea
    {
      get
      {
        return (BooleanValue) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "filter")]
    public BooleanValue Filter
    {
      get
      {
        return (BooleanValue) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "showAutoFilter")]
    public BooleanValue ShowAutoFilter
    {
      get
      {
        return (BooleanValue) this.Attributes[12];
      }
      set
      {
        this.Attributes[12] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "hiddenRows")]
    public BooleanValue HiddenRows
    {
      get
      {
        return (BooleanValue) this.Attributes[13];
      }
      set
      {
        this.Attributes[13] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "hiddenColumns")]
    public BooleanValue HiddenColumns
    {
      get
      {
        return (BooleanValue) this.Attributes[14];
      }
      set
      {
        this.Attributes[14] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "state")]
    public EnumValue<SheetStateValues> State
    {
      get
      {
        return (EnumValue<SheetStateValues>) this.Attributes[15];
      }
      set
      {
        this.Attributes[15] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "filterUnique")]
    public BooleanValue FilterUnique
    {
      get
      {
        return (BooleanValue) this.Attributes[16];
      }
      set
      {
        this.Attributes[16] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "view")]
    public EnumValue<SheetViewValues> View
    {
      get
      {
        return (EnumValue<SheetViewValues>) this.Attributes[17];
      }
      set
      {
        this.Attributes[17] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "showRuler")]
    public BooleanValue ShowRuler
    {
      get
      {
        return (BooleanValue) this.Attributes[18];
      }
      set
      {
        this.Attributes[18] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "topLeftCell")]
    public StringValue TopLeftCell
    {
      get
      {
        return (StringValue) this.Attributes[19];
      }
      set
      {
        this.Attributes[19] = (OpenXmlSimpleType) value;
      }
    }

    public CustomSheetView()
    {
    }

    public CustomSheetView(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public CustomSheetView(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public CustomSheetView(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "pane" == name)
        return (OpenXmlElement) new Pane();
      if (22 == (int) namespaceId && "selection" == name)
        return (OpenXmlElement) new Selection();
      if (22 == (int) namespaceId && "rowBreaks" == name)
        return (OpenXmlElement) new RowBreaks();
      if (22 == (int) namespaceId && "colBreaks" == name)
        return (OpenXmlElement) new ColumnBreaks();
      if (22 == (int) namespaceId && "pageMargins" == name)
        return (OpenXmlElement) new PageMargins();
      if (22 == (int) namespaceId && "printOptions" == name)
        return (OpenXmlElement) new PrintOptions();
      if (22 == (int) namespaceId && "pageSetup" == name)
        return (OpenXmlElement) new PageSetup();
      if (22 == (int) namespaceId && "headerFooter" == name)
        return (OpenXmlElement) new HeaderFooter();
      if (22 == (int) namespaceId && "autoFilter" == name)
        return (OpenXmlElement) new AutoFilter();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return CustomSheetView.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return CustomSheetView.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Pane Pane
    {
      get
      {
        return this.GetElement<Pane>(0);
      }
      set
      {
        this.SetElement<Pane>(0, value);
      }
    }

    public Selection Selection
    {
      get
      {
        return this.GetElement<Selection>(1);
      }
      set
      {
        this.SetElement<Selection>(1, value);
      }
    }

    public RowBreaks RowBreaks
    {
      get
      {
        return this.GetElement<RowBreaks>(2);
      }
      set
      {
        this.SetElement<RowBreaks>(2, value);
      }
    }

    public ColumnBreaks ColumnBreaks
    {
      get
      {
        return this.GetElement<ColumnBreaks>(3);
      }
      set
      {
        this.SetElement<ColumnBreaks>(3, value);
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

    public PageSetup PageSetup
    {
      get
      {
        return this.GetElement<PageSetup>(6);
      }
      set
      {
        this.SetElement<PageSetup>(6, value);
      }
    }

    public HeaderFooter HeaderFooter
    {
      get
      {
        return this.GetElement<HeaderFooter>(7);
      }
      set
      {
        this.SetElement<HeaderFooter>(7, value);
      }
    }

    public AutoFilter AutoFilter
    {
      get
      {
        return this.GetElement<AutoFilter>(8);
      }
      set
      {
        this.SetElement<AutoFilter>(8, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(9);
      }
      set
      {
        this.SetElement<ExtensionList>(9, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "guid" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "scale" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "colorId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "showPageBreaks" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showFormulas" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showGridLines" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showRowCol" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "outlineSymbols" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "zeroValues" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "fitToPage" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "printArea" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "filter" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showAutoFilter" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "hiddenRows" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "hiddenColumns" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "state" == name)
        return (OpenXmlSimpleType) new EnumValue<SheetStateValues>();
      if ((int) namespaceId == 0 && "filterUnique" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "view" == name)
        return (OpenXmlSimpleType) new EnumValue<SheetViewValues>();
      if ((int) namespaceId == 0 && "showRuler" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "topLeftCell" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<CustomSheetView>(deep);
    }
  }
}

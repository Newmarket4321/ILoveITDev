// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.SheetView
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (Selection))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Pane))]
  [ChildElementInfo(typeof (PivotSelection))]
  [ChildElementInfo(typeof (ExtensionList))]
  public class SheetView : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[19]
    {
      "windowProtection",
      "showFormulas",
      "showGridLines",
      "showRowColHeaders",
      "showZeros",
      "rightToLeft",
      "tabSelected",
      "showRuler",
      "showOutlineSymbols",
      "defaultGridColor",
      "showWhiteSpace",
      "view",
      "topLeftCell",
      "colorId",
      "zoomScale",
      "zoomScaleNormal",
      "zoomScaleSheetLayoutView",
      "zoomScalePageLayoutView",
      "workbookViewId"
    };
    private static byte[] attributeNamespaceIds = new byte[19];
    private static readonly string[] eleTagNames = new string[4]
    {
      "pane",
      "selection",
      "pivotSelection",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "sheetView";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11281;

    public override string LocalName
    {
      get
      {
        return "sheetView";
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
        return 11281;
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
        return SheetView.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return SheetView.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "windowProtection")]
    public BooleanValue WindowProtection
    {
      get
      {
        return (BooleanValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "showFormulas")]
    public BooleanValue ShowFormulas
    {
      get
      {
        return (BooleanValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "showGridLines")]
    public BooleanValue ShowGridLines
    {
      get
      {
        return (BooleanValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "showRowColHeaders")]
    public BooleanValue ShowRowColHeaders
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

    [SchemaAttr(0, "showZeros")]
    public BooleanValue ShowZeros
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

    [SchemaAttr(0, "rightToLeft")]
    public BooleanValue RightToLeft
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

    [SchemaAttr(0, "tabSelected")]
    public BooleanValue TabSelected
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

    [SchemaAttr(0, "showRuler")]
    public BooleanValue ShowRuler
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

    [SchemaAttr(0, "showOutlineSymbols")]
    public BooleanValue ShowOutlineSymbols
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

    [SchemaAttr(0, "defaultGridColor")]
    public BooleanValue DefaultGridColor
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

    [SchemaAttr(0, "showWhiteSpace")]
    public BooleanValue ShowWhiteSpace
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

    [SchemaAttr(0, "view")]
    public EnumValue<SheetViewValues> View
    {
      get
      {
        return (EnumValue<SheetViewValues>) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "topLeftCell")]
    public StringValue TopLeftCell
    {
      get
      {
        return (StringValue) this.Attributes[12];
      }
      set
      {
        this.Attributes[12] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "colorId")]
    public UInt32Value ColorId
    {
      get
      {
        return (UInt32Value) this.Attributes[13];
      }
      set
      {
        this.Attributes[13] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "zoomScale")]
    public UInt32Value ZoomScale
    {
      get
      {
        return (UInt32Value) this.Attributes[14];
      }
      set
      {
        this.Attributes[14] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "zoomScaleNormal")]
    public UInt32Value ZoomScaleNormal
    {
      get
      {
        return (UInt32Value) this.Attributes[15];
      }
      set
      {
        this.Attributes[15] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "zoomScaleSheetLayoutView")]
    public UInt32Value ZoomScaleSheetLayoutView
    {
      get
      {
        return (UInt32Value) this.Attributes[16];
      }
      set
      {
        this.Attributes[16] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "zoomScalePageLayoutView")]
    public UInt32Value ZoomScalePageLayoutView
    {
      get
      {
        return (UInt32Value) this.Attributes[17];
      }
      set
      {
        this.Attributes[17] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "workbookViewId")]
    public UInt32Value WorkbookViewId
    {
      get
      {
        return (UInt32Value) this.Attributes[18];
      }
      set
      {
        this.Attributes[18] = (OpenXmlSimpleType) value;
      }
    }

    public SheetView()
    {
    }

    public SheetView(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SheetView(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SheetView(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "pane" == name)
        return (OpenXmlElement) new Pane();
      if (22 == (int) namespaceId && "selection" == name)
        return (OpenXmlElement) new Selection();
      if (22 == (int) namespaceId && "pivotSelection" == name)
        return (OpenXmlElement) new PivotSelection();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return SheetView.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return SheetView.eleNamespaceIds;
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

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "windowProtection" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showFormulas" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showGridLines" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showRowColHeaders" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showZeros" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "rightToLeft" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "tabSelected" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showRuler" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showOutlineSymbols" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "defaultGridColor" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showWhiteSpace" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "view" == name)
        return (OpenXmlSimpleType) new EnumValue<SheetViewValues>();
      if ((int) namespaceId == 0 && "topLeftCell" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "colorId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "zoomScale" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "zoomScaleNormal" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "zoomScaleSheetLayoutView" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "zoomScalePageLayoutView" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "workbookViewId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SheetView>(deep);
    }
  }
}

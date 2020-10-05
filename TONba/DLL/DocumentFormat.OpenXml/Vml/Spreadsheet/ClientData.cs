// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Vml.Spreadsheet
{
  [ChildElementInfo(typeof (DdeObject))]
  [ChildElementInfo(typeof (DefaultSize))]
  [ChildElementInfo(typeof (PrintObject))]
  [ChildElementInfo(typeof (Disabled))]
  [ChildElementInfo(typeof (AutoFill))]
  [ChildElementInfo(typeof (AutoLine))]
  [ChildElementInfo(typeof (AutoSizePicture))]
  [ChildElementInfo(typeof (FormulaMacro))]
  [ChildElementInfo(typeof (HorizontalTextAlignment))]
  [ChildElementInfo(typeof (Locked))]
  [ChildElementInfo(typeof (LockText))]
  [ChildElementInfo(typeof (JustifyLastLine))]
  [ChildElementInfo(typeof (SecretEdit))]
  [ChildElementInfo(typeof (DefaultButton))]
  [ChildElementInfo(typeof (HelpButton))]
  [ChildElementInfo(typeof (CancelButton))]
  [ChildElementInfo(typeof (DismissButton))]
  [ChildElementInfo(typeof (AcceleratorPrimary))]
  [ChildElementInfo(typeof (AcceleratorSecondary))]
  [ChildElementInfo(typeof (CommentRowTarget))]
  [ChildElementInfo(typeof (CommentColumnTarget))]
  [ChildElementInfo(typeof (Visible))]
  [ChildElementInfo(typeof (RowHidden))]
  [ChildElementInfo(typeof (ColumnHidden))]
  [ChildElementInfo(typeof (InputValidationType))]
  [ChildElementInfo(typeof (MultiLine))]
  [ChildElementInfo(typeof (VerticalScrollBar))]
  [ChildElementInfo(typeof (ValidIds))]
  [ChildElementInfo(typeof (FormulaRange))]
  [ChildElementInfo(typeof (MinDropDownWidth))]
  [ChildElementInfo(typeof (SelectionEntry))]
  [ChildElementInfo(typeof (Disable3DForListBoxAndDropDown))]
  [ChildElementInfo(typeof (SelectionType))]
  [ChildElementInfo(typeof (MultiSelections))]
  [ChildElementInfo(typeof (ListBoxCallbackType))]
  [ChildElementInfo(typeof (ListItem))]
  [ChildElementInfo(typeof (DropStyle))]
  [ChildElementInfo(typeof (Colored))]
  [ChildElementInfo(typeof (DropLines))]
  [ChildElementInfo(typeof (Checked))]
  [ChildElementInfo(typeof (FormulaLink))]
  [ChildElementInfo(typeof (FormulaPicture))]
  [ChildElementInfo(typeof (Disable3D))]
  [ChildElementInfo(typeof (FirstButton))]
  [ChildElementInfo(typeof (FormulaGroup))]
  [ChildElementInfo(typeof (ScrollBarPosition))]
  [ChildElementInfo(typeof (ScrollBarMin))]
  [ChildElementInfo(typeof (ScrollBarMax))]
  [ChildElementInfo(typeof (ScrollBarIncrement))]
  [ChildElementInfo(typeof (ScrollBarPageIncrement))]
  [ChildElementInfo(typeof (HorizontalScrollBar))]
  [ChildElementInfo(typeof (ScrollBarWidth))]
  [ChildElementInfo(typeof (MapOcxControl))]
  [ChildElementInfo(typeof (ClipboardFormat))]
  [ChildElementInfo(typeof (CameraObject))]
  [ChildElementInfo(typeof (RecalculateAlways))]
  [ChildElementInfo(typeof (AutoScaleFont))]
  [ChildElementInfo(typeof (UIObject))]
  [ChildElementInfo(typeof (ScriptText))]
  [ChildElementInfo(typeof (ScriptExtended))]
  [ChildElementInfo(typeof (ScriptLanguage))]
  [ChildElementInfo(typeof (ScriptLocation))]
  [ChildElementInfo(typeof (FormulaTextBox))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (VerticalTextAlignment))]
  [ChildElementInfo(typeof (MoveWithCells))]
  [ChildElementInfo(typeof (Anchor))]
  [ChildElementInfo(typeof (ResizeWithCells))]
  public class ClientData : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      nameof (ObjectType)
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "ClientData";
    private const byte tagNsId = 29;
    internal const int ElementTypeIdConst = 12507;

    public override string LocalName
    {
      get
      {
        return nameof (ClientData);
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 29;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12507;
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
        return ClientData.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ClientData.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "ObjectType")]
    public EnumValue<ObjectValues> ObjectType
    {
      get
      {
        return (EnumValue<ObjectValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    public ClientData()
    {
    }

    public ClientData(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ClientData(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ClientData(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (29 == (int) namespaceId && "MoveWithCells" == name)
        return (OpenXmlElement) new MoveWithCells();
      if (29 == (int) namespaceId && "SizeWithCells" == name)
        return (OpenXmlElement) new ResizeWithCells();
      if (29 == (int) namespaceId && "Anchor" == name)
        return (OpenXmlElement) new Anchor();
      if (29 == (int) namespaceId && "Locked" == name)
        return (OpenXmlElement) new Locked();
      if (29 == (int) namespaceId && "DefaultSize" == name)
        return (OpenXmlElement) new DefaultSize();
      if (29 == (int) namespaceId && "PrintObject" == name)
        return (OpenXmlElement) new PrintObject();
      if (29 == (int) namespaceId && "Disabled" == name)
        return (OpenXmlElement) new Disabled();
      if (29 == (int) namespaceId && "AutoFill" == name)
        return (OpenXmlElement) new AutoFill();
      if (29 == (int) namespaceId && "AutoLine" == name)
        return (OpenXmlElement) new AutoLine();
      if (29 == (int) namespaceId && "AutoPict" == name)
        return (OpenXmlElement) new AutoSizePicture();
      if (29 == (int) namespaceId && "FmlaMacro" == name)
        return (OpenXmlElement) new FormulaMacro();
      if (29 == (int) namespaceId && "TextHAlign" == name)
        return (OpenXmlElement) new HorizontalTextAlignment();
      if (29 == (int) namespaceId && "TextVAlign" == name)
        return (OpenXmlElement) new VerticalTextAlignment();
      if (29 == (int) namespaceId && "LockText" == name)
        return (OpenXmlElement) new LockText();
      if (29 == (int) namespaceId && "JustLastX" == name)
        return (OpenXmlElement) new JustifyLastLine();
      if (29 == (int) namespaceId && "SecretEdit" == name)
        return (OpenXmlElement) new SecretEdit();
      if (29 == (int) namespaceId && "Default" == name)
        return (OpenXmlElement) new DefaultButton();
      if (29 == (int) namespaceId && "Help" == name)
        return (OpenXmlElement) new HelpButton();
      if (29 == (int) namespaceId && "Cancel" == name)
        return (OpenXmlElement) new CancelButton();
      if (29 == (int) namespaceId && "Dismiss" == name)
        return (OpenXmlElement) new DismissButton();
      if (29 == (int) namespaceId && "Accel" == name)
        return (OpenXmlElement) new AcceleratorPrimary();
      if (29 == (int) namespaceId && "Accel2" == name)
        return (OpenXmlElement) new AcceleratorSecondary();
      if (29 == (int) namespaceId && "Row" == name)
        return (OpenXmlElement) new CommentRowTarget();
      if (29 == (int) namespaceId && "Column" == name)
        return (OpenXmlElement) new CommentColumnTarget();
      if (29 == (int) namespaceId && "Visible" == name)
        return (OpenXmlElement) new Visible();
      if (29 == (int) namespaceId && "RowHidden" == name)
        return (OpenXmlElement) new RowHidden();
      if (29 == (int) namespaceId && "ColHidden" == name)
        return (OpenXmlElement) new ColumnHidden();
      if (29 == (int) namespaceId && "VTEdit" == name)
        return (OpenXmlElement) new InputValidationType();
      if (29 == (int) namespaceId && "MultiLine" == name)
        return (OpenXmlElement) new MultiLine();
      if (29 == (int) namespaceId && "VScroll" == name)
        return (OpenXmlElement) new VerticalScrollBar();
      if (29 == (int) namespaceId && "ValidIds" == name)
        return (OpenXmlElement) new ValidIds();
      if (29 == (int) namespaceId && "FmlaRange" == name)
        return (OpenXmlElement) new FormulaRange();
      if (29 == (int) namespaceId && "WidthMin" == name)
        return (OpenXmlElement) new MinDropDownWidth();
      if (29 == (int) namespaceId && "Sel" == name)
        return (OpenXmlElement) new SelectionEntry();
      if (29 == (int) namespaceId && "NoThreeD2" == name)
        return (OpenXmlElement) new Disable3DForListBoxAndDropDown();
      if (29 == (int) namespaceId && "SelType" == name)
        return (OpenXmlElement) new SelectionType();
      if (29 == (int) namespaceId && "MultiSel" == name)
        return (OpenXmlElement) new MultiSelections();
      if (29 == (int) namespaceId && "LCT" == name)
        return (OpenXmlElement) new ListBoxCallbackType();
      if (29 == (int) namespaceId && "ListItem" == name)
        return (OpenXmlElement) new ListItem();
      if (29 == (int) namespaceId && "DropStyle" == name)
        return (OpenXmlElement) new DropStyle();
      if (29 == (int) namespaceId && "Colored" == name)
        return (OpenXmlElement) new Colored();
      if (29 == (int) namespaceId && "DropLines" == name)
        return (OpenXmlElement) new DropLines();
      if (29 == (int) namespaceId && "Checked" == name)
        return (OpenXmlElement) new Checked();
      if (29 == (int) namespaceId && "FmlaLink" == name)
        return (OpenXmlElement) new FormulaLink();
      if (29 == (int) namespaceId && "FmlaPict" == name)
        return (OpenXmlElement) new FormulaPicture();
      if (29 == (int) namespaceId && "NoThreeD" == name)
        return (OpenXmlElement) new Disable3D();
      if (29 == (int) namespaceId && "FirstButton" == name)
        return (OpenXmlElement) new FirstButton();
      if (29 == (int) namespaceId && "FmlaGroup" == name)
        return (OpenXmlElement) new FormulaGroup();
      if (29 == (int) namespaceId && "Val" == name)
        return (OpenXmlElement) new ScrollBarPosition();
      if (29 == (int) namespaceId && "Min" == name)
        return (OpenXmlElement) new ScrollBarMin();
      if (29 == (int) namespaceId && "Max" == name)
        return (OpenXmlElement) new ScrollBarMax();
      if (29 == (int) namespaceId && "Inc" == name)
        return (OpenXmlElement) new ScrollBarIncrement();
      if (29 == (int) namespaceId && "Page" == name)
        return (OpenXmlElement) new ScrollBarPageIncrement();
      if (29 == (int) namespaceId && "Horiz" == name)
        return (OpenXmlElement) new HorizontalScrollBar();
      if (29 == (int) namespaceId && "Dx" == name)
        return (OpenXmlElement) new ScrollBarWidth();
      if (29 == (int) namespaceId && "MapOCX" == name)
        return (OpenXmlElement) new MapOcxControl();
      if (29 == (int) namespaceId && "CF" == name)
        return (OpenXmlElement) new ClipboardFormat();
      if (29 == (int) namespaceId && "Camera" == name)
        return (OpenXmlElement) new CameraObject();
      if (29 == (int) namespaceId && "RecalcAlways" == name)
        return (OpenXmlElement) new RecalculateAlways();
      if (29 == (int) namespaceId && "AutoScale" == name)
        return (OpenXmlElement) new AutoScaleFont();
      if (29 == (int) namespaceId && "DDE" == name)
        return (OpenXmlElement) new DdeObject();
      if (29 == (int) namespaceId && "UIObj" == name)
        return (OpenXmlElement) new UIObject();
      if (29 == (int) namespaceId && "ScriptText" == name)
        return (OpenXmlElement) new ScriptText();
      if (29 == (int) namespaceId && "ScriptExtended" == name)
        return (OpenXmlElement) new ScriptExtended();
      if (29 == (int) namespaceId && "ScriptLanguage" == name)
        return (OpenXmlElement) new ScriptLanguage();
      if (29 == (int) namespaceId && "ScriptLocation" == name)
        return (OpenXmlElement) new ScriptLocation();
      if (29 == (int) namespaceId && "FmlaTxbx" == name)
        return (OpenXmlElement) new FormulaTextBox();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "ObjectType" == name)
        return (OpenXmlSimpleType) new EnumValue<ObjectValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ClientData>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.CustomUI.Box
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office.CustomUI
{
  [ChildElementInfo(typeof (SplitButton))]
  [ChildElementInfo(typeof (EditBox))]
  [ChildElementInfo(typeof (Menu))]
  [ChildElementInfo(typeof (DynamicMenu))]
  [ChildElementInfo(typeof (Box))]
  [ChildElementInfo(typeof (ButtonGroup))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ComboBox))]
  [ChildElementInfo(typeof (DropDown))]
  [ChildElementInfo(typeof (Gallery))]
  [ChildElementInfo(typeof (ControlClone))]
  [ChildElementInfo(typeof (TextLabel))]
  [ChildElementInfo(typeof (Button))]
  [ChildElementInfo(typeof (ToggleButton))]
  [ChildElementInfo(typeof (CheckBox))]
  public class Box : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[9]
    {
      "id",
      "idQ",
      "visible",
      "getVisible",
      "insertAfterMso",
      "insertBeforeMso",
      "insertAfterQ",
      "insertBeforeQ",
      "boxStyle"
    };
    private static byte[] attributeNamespaceIds = new byte[9];
    private const string tagName = "box";
    private const byte tagNsId = 34;
    internal const int ElementTypeIdConst = 12666;

    public override string LocalName
    {
      get
      {
        return "box";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 34;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12666;
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
        return Box.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Box.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "id")]
    public StringValue Id
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

    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
      get
      {
        return (StringValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
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

    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
      get
      {
        return (StringValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
      get
      {
        return (StringValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
      get
      {
        return (StringValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
      get
      {
        return (StringValue) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
      get
      {
        return (StringValue) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "boxStyle")]
    public EnumValue<BoxStyleValues> BoxStyle
    {
      get
      {
        return (EnumValue<BoxStyleValues>) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    public Box()
    {
    }

    public Box(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Box(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Box(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (34 == (int) namespaceId && "control" == name)
        return (OpenXmlElement) new ControlClone();
      if (34 == (int) namespaceId && "labelControl" == name)
        return (OpenXmlElement) new TextLabel();
      if (34 == (int) namespaceId && "button" == name)
        return (OpenXmlElement) new Button();
      if (34 == (int) namespaceId && "toggleButton" == name)
        return (OpenXmlElement) new ToggleButton();
      if (34 == (int) namespaceId && "checkBox" == name)
        return (OpenXmlElement) new CheckBox();
      if (34 == (int) namespaceId && "editBox" == name)
        return (OpenXmlElement) new EditBox();
      if (34 == (int) namespaceId && "comboBox" == name)
        return (OpenXmlElement) new ComboBox();
      if (34 == (int) namespaceId && "dropDown" == name)
        return (OpenXmlElement) new DropDown();
      if (34 == (int) namespaceId && "gallery" == name)
        return (OpenXmlElement) new Gallery();
      if (34 == (int) namespaceId && "menu" == name)
        return (OpenXmlElement) new Menu();
      if (34 == (int) namespaceId && "dynamicMenu" == name)
        return (OpenXmlElement) new DynamicMenu();
      if (34 == (int) namespaceId && "splitButton" == name)
        return (OpenXmlElement) new SplitButton();
      if (34 == (int) namespaceId && "box" == name)
        return (OpenXmlElement) new Box();
      if (34 == (int) namespaceId && "buttonGroup" == name)
        return (OpenXmlElement) new ButtonGroup();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "idQ" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "visible" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "getVisible" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "insertAfterMso" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "insertBeforeMso" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "insertAfterQ" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "insertBeforeQ" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "boxStyle" == name)
        return (OpenXmlSimpleType) new EnumValue<BoxStyleValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Box>(deep);
    }
  }
}

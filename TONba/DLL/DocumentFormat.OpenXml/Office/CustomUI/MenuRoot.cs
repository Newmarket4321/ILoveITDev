// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.CustomUI.MenuRoot
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office.CustomUI
{
  [ChildElementInfo(typeof (UnsizedSplitButton))]
  [ChildElementInfo(typeof (UnsizedDynamicMenu))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (UnsizedControlClone))]
  [ChildElementInfo(typeof (UnsizedMenu))]
  [ChildElementInfo(typeof (UnsizedButton))]
  [ChildElementInfo(typeof (CheckBox))]
  [ChildElementInfo(typeof (UnsizedGallery))]
  [ChildElementInfo(typeof (UnsizedToggleButton))]
  [ChildElementInfo(typeof (MenuSeparator))]
  public class MenuRoot : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "title",
      "getTitle",
      "itemSize"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private const string tagName = "menu";
    private const byte tagNsId = 34;
    internal const int ElementTypeIdConst = 12668;

    public override string LocalName
    {
      get
      {
        return "menu";
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
        return 12668;
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
        return MenuRoot.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return MenuRoot.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "title")]
    public StringValue Title
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

    [SchemaAttr(0, "getTitle")]
    public StringValue GetTitle
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

    [SchemaAttr(0, "itemSize")]
    public EnumValue<ItemSizeValues> ItemSize
    {
      get
      {
        return (EnumValue<ItemSizeValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    public MenuRoot()
    {
    }

    public MenuRoot(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public MenuRoot(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public MenuRoot(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (34 == (int) namespaceId && "control" == name)
        return (OpenXmlElement) new UnsizedControlClone();
      if (34 == (int) namespaceId && "button" == name)
        return (OpenXmlElement) new UnsizedButton();
      if (34 == (int) namespaceId && "checkBox" == name)
        return (OpenXmlElement) new CheckBox();
      if (34 == (int) namespaceId && "gallery" == name)
        return (OpenXmlElement) new UnsizedGallery();
      if (34 == (int) namespaceId && "toggleButton" == name)
        return (OpenXmlElement) new UnsizedToggleButton();
      if (34 == (int) namespaceId && "menuSeparator" == name)
        return (OpenXmlElement) new MenuSeparator();
      if (34 == (int) namespaceId && "splitButton" == name)
        return (OpenXmlElement) new UnsizedSplitButton();
      if (34 == (int) namespaceId && "menu" == name)
        return (OpenXmlElement) new UnsizedMenu();
      if (34 == (int) namespaceId && "dynamicMenu" == name)
        return (OpenXmlElement) new UnsizedDynamicMenu();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "title" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "getTitle" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "itemSize" == name)
        return (OpenXmlSimpleType) new EnumValue<ItemSizeValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<MenuRoot>(deep);
    }
  }
}

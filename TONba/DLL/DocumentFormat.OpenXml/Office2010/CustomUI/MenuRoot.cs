// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.CustomUI.MenuRoot
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.CustomUI
{
  [ChildElementInfo(typeof (GalleryRegular), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ControlCloneRegular), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ButtonRegular), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (CheckBox), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (MenuSeparator), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (SplitButtonRegular), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (MenuRegular), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DynamicMenuRegular), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ToggleButtonRegular), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
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
    private const byte tagNsId = 57;
    internal const int ElementTypeIdConst = 13141;

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
        return 57;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13141;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
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
      if (57 == (int) namespaceId && "control" == name)
        return (OpenXmlElement) new ControlCloneRegular();
      if (57 == (int) namespaceId && "button" == name)
        return (OpenXmlElement) new ButtonRegular();
      if (57 == (int) namespaceId && "checkBox" == name)
        return (OpenXmlElement) new CheckBox();
      if (57 == (int) namespaceId && "gallery" == name)
        return (OpenXmlElement) new GalleryRegular();
      if (57 == (int) namespaceId && "toggleButton" == name)
        return (OpenXmlElement) new ToggleButtonRegular();
      if (57 == (int) namespaceId && "menuSeparator" == name)
        return (OpenXmlElement) new MenuSeparator();
      if (57 == (int) namespaceId && "splitButton" == name)
        return (OpenXmlElement) new SplitButtonRegular();
      if (57 == (int) namespaceId && "menu" == name)
        return (OpenXmlElement) new MenuRegular();
      if (57 == (int) namespaceId && "dynamicMenu" == name)
        return (OpenXmlElement) new DynamicMenuRegular();
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

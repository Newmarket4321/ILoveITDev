// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu
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
  [ChildElementInfo(typeof (ToggleButtonRegular), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (SplitButtonRegular), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (MenuRegular), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DynamicMenuRegular), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (MenuSeparatorNoTitle), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class ContextMenu : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "idMso"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "contextMenu";
    private const byte tagNsId = 57;
    internal const int ElementTypeIdConst = 13158;

    public override string LocalName
    {
      get
      {
        return "contextMenu";
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
        return 13158;
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
        return ContextMenu.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ContextMenu.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
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

    public ContextMenu()
    {
    }

    public ContextMenu(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ContextMenu(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ContextMenu(string outerXml)
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
      if (57 == (int) namespaceId && "splitButton" == name)
        return (OpenXmlElement) new SplitButtonRegular();
      if (57 == (int) namespaceId && "menu" == name)
        return (OpenXmlElement) new MenuRegular();
      if (57 == (int) namespaceId && "dynamicMenu" == name)
        return (OpenXmlElement) new DynamicMenuRegular();
      if (57 == (int) namespaceId && "menuSeparator" == name)
        return (OpenXmlElement) new MenuSeparatorNoTitle();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "idMso" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ContextMenu>(deep);
    }
  }
}

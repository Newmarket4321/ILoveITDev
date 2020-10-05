// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.CustomUI.OfficeMenu
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office.CustomUI
{
  [ChildElementInfo(typeof (UnsizedGallery))]
  [ChildElementInfo(typeof (CheckBox))]
  [ChildElementInfo(typeof (UnsizedControlClone))]
  [ChildElementInfo(typeof (UnsizedToggleButton))]
  [ChildElementInfo(typeof (MenuSeparator))]
  [ChildElementInfo(typeof (SplitButtonWithTitle))]
  [ChildElementInfo(typeof (UnsizedButton))]
  [ChildElementInfo(typeof (UnsizedDynamicMenu))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (MenuWithTitle))]
  public class OfficeMenu : OpenXmlCompositeElement
  {
    private const string tagName = "officeMenu";
    private const byte tagNsId = 34;
    internal const int ElementTypeIdConst = 12682;

    public override string LocalName
    {
      get
      {
        return "officeMenu";
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
        return 12682;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public OfficeMenu()
    {
    }

    public OfficeMenu(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public OfficeMenu(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public OfficeMenu(string outerXml)
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
        return (OpenXmlElement) new SplitButtonWithTitle();
      if (34 == (int) namespaceId && "menu" == name)
        return (OpenXmlElement) new MenuWithTitle();
      if (34 == (int) namespaceId && "dynamicMenu" == name)
        return (OpenXmlElement) new UnsizedDynamicMenu();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<OfficeMenu>(deep);
    }
  }
}

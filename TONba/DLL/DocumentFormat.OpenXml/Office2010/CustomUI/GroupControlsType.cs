// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.CustomUI.GroupControlsType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.CustomUI
{
  [ChildElementInfo(typeof (Hyperlink), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (BackstageGroupButton), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (BackstageCheckBox), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (BackstageEditBox), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (BackstageDropDown), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (RadioGroup), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (BackstageComboBox), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (BackstageLabelControl), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (GroupBox), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (LayoutContainer), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ImageControl), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public abstract class GroupControlsType : OpenXmlCompositeElement
  {
    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (57 == (int) namespaceId && "button" == name)
        return (OpenXmlElement) new BackstageGroupButton();
      if (57 == (int) namespaceId && "checkBox" == name)
        return (OpenXmlElement) new BackstageCheckBox();
      if (57 == (int) namespaceId && "editBox" == name)
        return (OpenXmlElement) new BackstageEditBox();
      if (57 == (int) namespaceId && "dropDown" == name)
        return (OpenXmlElement) new BackstageDropDown();
      if (57 == (int) namespaceId && "radioGroup" == name)
        return (OpenXmlElement) new RadioGroup();
      if (57 == (int) namespaceId && "comboBox" == name)
        return (OpenXmlElement) new BackstageComboBox();
      if (57 == (int) namespaceId && "hyperlink" == name)
        return (OpenXmlElement) new Hyperlink();
      if (57 == (int) namespaceId && "labelControl" == name)
        return (OpenXmlElement) new BackstageLabelControl();
      if (57 == (int) namespaceId && "groupBox" == name)
        return (OpenXmlElement) new GroupBox();
      if (57 == (int) namespaceId && "layoutContainer" == name)
        return (OpenXmlElement) new LayoutContainer();
      if (57 == (int) namespaceId && "imageControl" == name)
        return (OpenXmlElement) new ImageControl();
      return (OpenXmlElement) null;
    }

    protected GroupControlsType()
    {
    }

    protected GroupControlsType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected GroupControlsType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected GroupControlsType(string outerXml)
      : base(outerXml)
    {
    }
  }
}

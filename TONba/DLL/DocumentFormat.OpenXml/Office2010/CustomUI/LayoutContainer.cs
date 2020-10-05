// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.CustomUI
{
  [ChildElementInfo(typeof (BackstageGroupButton), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (BackstageComboBox), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (BackstageCheckBox), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (BackstageEditBox), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (BackstageDropDown), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (RadioGroup), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (Hyperlink), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (BackstageLabelControl), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (GroupBox), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (LayoutContainer), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ImageControl), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public class LayoutContainer : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[6]
    {
      "id",
      "idQ",
      "tag",
      "align",
      "expand",
      "layoutChildren"
    };
    private static byte[] attributeNamespaceIds = new byte[6];
    private const string tagName = "layoutContainer";
    private const byte tagNsId = 57;
    internal const int ElementTypeIdConst = 13137;

    public override string LocalName
    {
      get
      {
        return "layoutContainer";
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
        return 13137;
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
        return LayoutContainer.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return LayoutContainer.attributeNamespaceIds;
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
    public StringValue QualifiedId
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

    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
      get
      {
        return (StringValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "align")]
    public EnumValue<ExpandValues> Align
    {
      get
      {
        return (EnumValue<ExpandValues>) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "expand")]
    public EnumValue<ExpandValues> Expand
    {
      get
      {
        return (EnumValue<ExpandValues>) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "layoutChildren")]
    public EnumValue<LayoutChildrenValues> LayoutChildren
    {
      get
      {
        return (EnumValue<LayoutChildrenValues>) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    public LayoutContainer()
    {
    }

    public LayoutContainer(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public LayoutContainer(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public LayoutContainer(string outerXml)
      : base(outerXml)
    {
    }

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

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "idQ" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "tag" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "align" == name)
        return (OpenXmlSimpleType) new EnumValue<ExpandValues>();
      if ((int) namespaceId == 0 && "expand" == name)
        return (OpenXmlSimpleType) new EnumValue<ExpandValues>();
      if ((int) namespaceId == 0 && "layoutChildren" == name)
        return (OpenXmlSimpleType) new EnumValue<LayoutChildrenValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<LayoutContainer>(deep);
    }
  }
}

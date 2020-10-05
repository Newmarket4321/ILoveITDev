// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.CustomUI
{
  [ChildElementInfo(typeof (BackstageMenuCheckBox), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (BackstageMenuButton), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (BackstageSubMenu), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (BackstageMenuToggleButton), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class BackstageMenuGroup : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[6]
    {
      "id",
      "idQ",
      "tag",
      "label",
      "getLabel",
      "itemSize"
    };
    private static byte[] attributeNamespaceIds = new byte[6];
    private const string tagName = "menuGroup";
    private const byte tagNsId = 57;
    internal const int ElementTypeIdConst = 13163;

    public override string LocalName
    {
      get
      {
        return "menuGroup";
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
        return 13163;
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
        return BackstageMenuGroup.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return BackstageMenuGroup.attributeNamespaceIds;
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

    [SchemaAttr(0, "label")]
    public StringValue Label
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

    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
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

    [SchemaAttr(0, "itemSize")]
    public EnumValue<ItemSizeValues> ItemSize
    {
      get
      {
        return (EnumValue<ItemSizeValues>) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    public BackstageMenuGroup()
    {
    }

    public BackstageMenuGroup(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public BackstageMenuGroup(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public BackstageMenuGroup(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (57 == (int) namespaceId && "button" == name)
        return (OpenXmlElement) new BackstageMenuButton();
      if (57 == (int) namespaceId && "checkBox" == name)
        return (OpenXmlElement) new BackstageMenuCheckBox();
      if (57 == (int) namespaceId && "menu" == name)
        return (OpenXmlElement) new BackstageSubMenu();
      if (57 == (int) namespaceId && "toggleButton" == name)
        return (OpenXmlElement) new BackstageMenuToggleButton();
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
      if ((int) namespaceId == 0 && "label" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "getLabel" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "itemSize" == name)
        return (OpenXmlSimpleType) new EnumValue<ItemSizeValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<BackstageMenuGroup>(deep);
    }
  }
}

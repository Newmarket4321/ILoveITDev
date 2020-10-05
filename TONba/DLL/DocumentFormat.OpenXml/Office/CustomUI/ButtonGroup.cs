// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office.CustomUI
{
  [ChildElementInfo(typeof (UnsizedMenu))]
  [ChildElementInfo(typeof (UnsizedToggleButton))]
  [ChildElementInfo(typeof (UnsizedGallery))]
  [ChildElementInfo(typeof (UnsizedControlClone))]
  [ChildElementInfo(typeof (UnsizedDynamicMenu))]
  [ChildElementInfo(typeof (UnsizedSplitButton))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (UnsizedButton))]
  public class ButtonGroup : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[8]
    {
      "id",
      "idQ",
      "visible",
      "getVisible",
      "insertAfterMso",
      "insertBeforeMso",
      "insertAfterQ",
      "insertBeforeQ"
    };
    private static byte[] attributeNamespaceIds = new byte[8];
    private const string tagName = "buttonGroup";
    private const byte tagNsId = 34;
    internal const int ElementTypeIdConst = 12667;

    public override string LocalName
    {
      get
      {
        return "buttonGroup";
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
        return 12667;
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
        return ButtonGroup.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ButtonGroup.attributeNamespaceIds;
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

    public ButtonGroup()
    {
    }

    public ButtonGroup(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ButtonGroup(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ButtonGroup(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (34 == (int) namespaceId && "control" == name)
        return (OpenXmlElement) new UnsizedControlClone();
      if (34 == (int) namespaceId && "button" == name)
        return (OpenXmlElement) new UnsizedButton();
      if (34 == (int) namespaceId && "toggleButton" == name)
        return (OpenXmlElement) new UnsizedToggleButton();
      if (34 == (int) namespaceId && "gallery" == name)
        return (OpenXmlElement) new UnsizedGallery();
      if (34 == (int) namespaceId && "menu" == name)
        return (OpenXmlElement) new UnsizedMenu();
      if (34 == (int) namespaceId && "dynamicMenu" == name)
        return (OpenXmlElement) new UnsizedDynamicMenu();
      if (34 == (int) namespaceId && "splitButton" == name)
        return (OpenXmlElement) new UnsizedSplitButton();
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
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ButtonGroup>(deep);
    }
  }
}

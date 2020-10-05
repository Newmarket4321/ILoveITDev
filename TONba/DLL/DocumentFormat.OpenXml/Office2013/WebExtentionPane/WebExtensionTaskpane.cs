// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.WebExtentionPane
{
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (WebExtensionPartReference), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (OfficeArtExtensionList), FileFormatVersions.Office2013)]
  public class WebExtensionTaskpane : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[5]
    {
      "dockstate",
      "visibility",
      "width",
      "row",
      "locked"
    };
    private static byte[] attributeNamespaceIds = new byte[5];
    private static readonly string[] eleTagNames = new string[2]
    {
      "webextensionref",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 70,
      (byte) 70
    };
    private const string tagName = "taskpane";
    private const byte tagNsId = 70;
    internal const int ElementTypeIdConst = 13357;

    public override string LocalName
    {
      get
      {
        return "taskpane";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 70;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13357;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return WebExtensionTaskpane.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return WebExtensionTaskpane.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "dockstate")]
    public StringValue DockState
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

    [SchemaAttr(0, "visibility")]
    public BooleanValue Visibility
    {
      get
      {
        return (BooleanValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "width")]
    public DoubleValue Width
    {
      get
      {
        return (DoubleValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "row")]
    public UInt32Value Row
    {
      get
      {
        return (UInt32Value) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "locked")]
    public BooleanValue Locked
    {
      get
      {
        return (BooleanValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    public WebExtensionTaskpane()
    {
    }

    public WebExtensionTaskpane(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public WebExtensionTaskpane(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public WebExtensionTaskpane(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (70 == (int) namespaceId && "webextensionref" == name)
        return (OpenXmlElement) new WebExtensionPartReference();
      if (70 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new OfficeArtExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return WebExtensionTaskpane.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return WebExtensionTaskpane.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public WebExtensionPartReference WebExtensionPartReference
    {
      get
      {
        return this.GetElement<WebExtensionPartReference>(0);
      }
      set
      {
        this.SetElement<WebExtensionPartReference>(0, value);
      }
    }

    public OfficeArtExtensionList OfficeArtExtensionList
    {
      get
      {
        return this.GetElement<OfficeArtExtensionList>(1);
      }
      set
      {
        this.SetElement<OfficeArtExtensionList>(1, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "dockstate" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "visibility" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "width" == name)
        return (OpenXmlSimpleType) new DoubleValue();
      if ((int) namespaceId == 0 && "row" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "locked" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<WebExtensionTaskpane>(deep);
    }
  }
}

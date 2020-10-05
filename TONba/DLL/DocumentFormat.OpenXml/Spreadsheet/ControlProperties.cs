// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.ControlProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (ObjectAnchor), FileFormatVersions.Office2010)]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class ControlProperties : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[15]
    {
      "locked",
      "defaultSize",
      "print",
      "disabled",
      "recalcAlways",
      "uiObject",
      "autoFill",
      "autoLine",
      "autoPict",
      "macro",
      "altText",
      "linkedCell",
      "listFillRange",
      "cf",
      "id"
    };
    private static byte[] attributeNamespaceIds = new byte[15]
    {
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 19
    };
    private static readonly string[] eleTagNames = new string[1]
    {
      "anchor"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 22
    };
    private const string tagName = "controlPr";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11386;

    public override string LocalName
    {
      get
      {
        return "controlPr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 22;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11386;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2010 & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return ControlProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ControlProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "locked")]
    public BooleanValue Locked
    {
      get
      {
        return (BooleanValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "defaultSize")]
    public BooleanValue DefaultSize
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

    [SchemaAttr(0, "print")]
    public BooleanValue Print
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

    [SchemaAttr(0, "disabled")]
    public BooleanValue Disabled
    {
      get
      {
        return (BooleanValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "recalcAlways")]
    public BooleanValue RecalcAlways
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

    [SchemaAttr(0, "uiObject")]
    public BooleanValue UiObject
    {
      get
      {
        return (BooleanValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "autoFill")]
    public BooleanValue AutoFill
    {
      get
      {
        return (BooleanValue) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "autoLine")]
    public BooleanValue AutoLine
    {
      get
      {
        return (BooleanValue) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "autoPict")]
    public BooleanValue AutoPict
    {
      get
      {
        return (BooleanValue) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "macro")]
    public StringValue Macro
    {
      get
      {
        return (StringValue) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "altText")]
    public StringValue AltText
    {
      get
      {
        return (StringValue) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "linkedCell")]
    public StringValue LinkedCell
    {
      get
      {
        return (StringValue) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "listFillRange")]
    public StringValue ListFillRange
    {
      get
      {
        return (StringValue) this.Attributes[12];
      }
      set
      {
        this.Attributes[12] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "cf")]
    public StringValue Cf
    {
      get
      {
        return (StringValue) this.Attributes[13];
      }
      set
      {
        this.Attributes[13] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(19, "id")]
    public StringValue Id
    {
      get
      {
        return (StringValue) this.Attributes[14];
      }
      set
      {
        this.Attributes[14] = (OpenXmlSimpleType) value;
      }
    }

    public ControlProperties()
    {
    }

    public ControlProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ControlProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ControlProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "anchor" == name)
        return (OpenXmlElement) new ObjectAnchor();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ControlProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ControlProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ObjectAnchor ObjectAnchor
    {
      get
      {
        return this.GetElement<ObjectAnchor>(0);
      }
      set
      {
        this.SetElement<ObjectAnchor>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "locked" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "defaultSize" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "print" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "disabled" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "recalcAlways" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "uiObject" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "autoFill" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "autoLine" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "autoPict" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "macro" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "altText" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "linkedCell" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "listFillRange" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "cf" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (19 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ControlProperties>(deep);
    }
  }
}

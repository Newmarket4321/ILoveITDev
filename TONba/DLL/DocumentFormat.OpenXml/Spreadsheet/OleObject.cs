// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.OleObject
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (EmbeddedObjectProperties), FileFormatVersions.Office2010)]
  public class OleObject : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[7]
    {
      "progId",
      "dvAspect",
      "link",
      "oleUpdate",
      "autoLoad",
      "shapeId",
      "id"
    };
    private static byte[] attributeNamespaceIds = new byte[7]
    {
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
      "objectPr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 22
    };
    private const string tagName = "oleObject";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11283;

    public override string LocalName
    {
      get
      {
        return "oleObject";
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
        return 11283;
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
        return OleObject.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return OleObject.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "progId")]
    public StringValue ProgId
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

    [SchemaAttr(0, "dvAspect")]
    public EnumValue<DataViewAspectValues> DataOrViewAspect
    {
      get
      {
        return (EnumValue<DataViewAspectValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "link")]
    public StringValue Link
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

    [SchemaAttr(0, "oleUpdate")]
    public EnumValue<OleUpdateValues> OleUpdate
    {
      get
      {
        return (EnumValue<OleUpdateValues>) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "autoLoad")]
    public BooleanValue AutoLoad
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

    [SchemaAttr(0, "shapeId")]
    public UInt32Value ShapeId
    {
      get
      {
        return (UInt32Value) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(19, "id")]
    public StringValue Id
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

    public OleObject()
    {
    }

    public OleObject(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public OleObject(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public OleObject(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "objectPr" == name)
        return (OpenXmlElement) new EmbeddedObjectProperties();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return OleObject.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return OleObject.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    public EmbeddedObjectProperties EmbeddedObjectProperties
    {
      get
      {
        return this.GetElement<EmbeddedObjectProperties>(0);
      }
      set
      {
        this.SetElement<EmbeddedObjectProperties>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "progId" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "dvAspect" == name)
        return (OpenXmlSimpleType) new EnumValue<DataViewAspectValues>();
      if ((int) namespaceId == 0 && "link" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "oleUpdate" == name)
        return (OpenXmlSimpleType) new EnumValue<OleUpdateValues>();
      if ((int) namespaceId == 0 && "autoLoad" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "shapeId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if (19 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<OleObject>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Vml.Office.OleObject
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Vml.Office
{
  [ChildElementInfo(typeof (LockedField))]
  [ChildElementInfo(typeof (LinkType))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (FieldCodes))]
  public class OleObject : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[7]
    {
      nameof (Type),
      "ProgID",
      "ShapeID",
      nameof (DrawAspect),
      "ObjectID",
      "id",
      nameof (UpdateMode)
    };
    private static byte[] attributeNamespaceIds = new byte[7]
    {
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 19,
      (byte) 0
    };
    private static readonly string[] eleTagNames = new string[3]
    {
      nameof (LinkType),
      nameof (LockedField),
      nameof (FieldCodes)
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 27,
      (byte) 27,
      (byte) 27
    };
    private const string tagName = "OLEObject";
    private const byte tagNsId = 27;
    internal const int ElementTypeIdConst = 12479;

    public override string LocalName
    {
      get
      {
        return "OLEObject";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 27;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12479;
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

    [SchemaAttr(0, "Type")]
    public EnumValue<OleValues> Type
    {
      get
      {
        return (EnumValue<OleValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "ProgID")]
    public StringValue ProgId
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

    [SchemaAttr(0, "ShapeID")]
    public StringValue ShapeId
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

    [SchemaAttr(0, "DrawAspect")]
    public EnumValue<OleDrawAspectValues> DrawAspect
    {
      get
      {
        return (EnumValue<OleDrawAspectValues>) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "ObjectID")]
    public StringValue ObjectId
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

    [SchemaAttr(19, "id")]
    public StringValue Id
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

    [SchemaAttr(0, "UpdateMode")]
    public EnumValue<OleUpdateModeValues> UpdateMode
    {
      get
      {
        return (EnumValue<OleUpdateModeValues>) this.Attributes[6];
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
      if (27 == (int) namespaceId && "LinkType" == name)
        return (OpenXmlElement) new LinkType();
      if (27 == (int) namespaceId && "LockedField" == name)
        return (OpenXmlElement) new LockedField();
      if (27 == (int) namespaceId && "FieldCodes" == name)
        return (OpenXmlElement) new FieldCodes();
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

    public LinkType LinkType
    {
      get
      {
        return this.GetElement<LinkType>(0);
      }
      set
      {
        this.SetElement<LinkType>(0, value);
      }
    }

    public LockedField LockedField
    {
      get
      {
        return this.GetElement<LockedField>(1);
      }
      set
      {
        this.SetElement<LockedField>(1, value);
      }
    }

    public FieldCodes FieldCodes
    {
      get
      {
        return this.GetElement<FieldCodes>(2);
      }
      set
      {
        this.SetElement<FieldCodes>(2, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "Type" == name)
        return (OpenXmlSimpleType) new EnumValue<OleValues>();
      if ((int) namespaceId == 0 && "ProgID" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "ShapeID" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "DrawAspect" == name)
        return (OpenXmlSimpleType) new EnumValue<OleDrawAspectValues>();
      if ((int) namespaceId == 0 && "ObjectID" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (19 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "UpdateMode" == name)
        return (OpenXmlSimpleType) new EnumValue<OleUpdateModeValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<OleObject>(deep);
    }
  }
}

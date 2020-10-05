// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.EMMA.EndPoint
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.EMMA
{
  [GeneratedCode("DomGen", "2.0")]
  public class EndPoint : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[11]
    {
      "id",
      "endpoint-role",
      "endpoint-address",
      "message-id",
      "port-num",
      "port-type",
      "endpoint-pair-ref",
      "service-name",
      "media-type",
      "medium",
      "mode"
    };
    private static byte[] attributeNamespaceIds = new byte[11]
    {
      (byte) 0,
      (byte) 44,
      (byte) 44,
      (byte) 44,
      (byte) 44,
      (byte) 44,
      (byte) 44,
      (byte) 44,
      (byte) 44,
      (byte) 44,
      (byte) 44
    };
    private const string tagName = "endpoint";
    private const byte tagNsId = 44;
    internal const int ElementTypeIdConst = 12754;

    public override string LocalName
    {
      get
      {
        return "endpoint";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 44;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12754;
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
        return EndPoint.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return EndPoint.attributeNamespaceIds;
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

    [SchemaAttr(44, "endpoint-role")]
    public EnumValue<EndPointRoleValues> EndpointRole
    {
      get
      {
        return (EnumValue<EndPointRoleValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(44, "endpoint-address")]
    public StringValue EndPointAddress
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

    [SchemaAttr(44, "message-id")]
    public StringValue MessageId
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

    [SchemaAttr(44, "port-num")]
    public IntegerValue PortNumber
    {
      get
      {
        return (IntegerValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(44, "port-type")]
    public StringValue PortType
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

    [SchemaAttr(44, "endpoint-pair-ref")]
    public StringValue EndpointPairRef
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

    [SchemaAttr(44, "service-name")]
    public StringValue ServiceName
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

    [SchemaAttr(44, "media-type")]
    public StringValue MediaType
    {
      get
      {
        return (StringValue) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(44, "medium")]
    public ListValue<EnumValue<MediumValues>> Medium
    {
      get
      {
        return (ListValue<EnumValue<MediumValues>>) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(44, "mode")]
    public ListValue<StringValue> Mode
    {
      get
      {
        return (ListValue<StringValue>) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    public EndPoint()
    {
    }

    public EndPoint(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public EndPoint(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public EndPoint(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (44 == (int) namespaceId && "endpoint-role" == name)
        return (OpenXmlSimpleType) new EnumValue<EndPointRoleValues>();
      if (44 == (int) namespaceId && "endpoint-address" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (44 == (int) namespaceId && "message-id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (44 == (int) namespaceId && "port-num" == name)
        return (OpenXmlSimpleType) new IntegerValue();
      if (44 == (int) namespaceId && "port-type" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (44 == (int) namespaceId && "endpoint-pair-ref" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (44 == (int) namespaceId && "service-name" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (44 == (int) namespaceId && "media-type" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (44 == (int) namespaceId && "medium" == name)
        return (OpenXmlSimpleType) new ListValue<EnumValue<MediumValues>>();
      if (44 == (int) namespaceId && "mode" == name)
        return (OpenXmlSimpleType) new ListValue<StringValue>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<EndPoint>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.InkML.Channel
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.InkML
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Mapping))]
  public class Channel : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[9]
    {
      "id",
      "name",
      "type",
      "default",
      "min",
      "max",
      "orientation",
      "respectTo",
      "units"
    };
    private static byte[] attributeNamespaceIds = new byte[9]
    {
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private const string tagName = "channel";
    private const byte tagNsId = 43;
    internal const int ElementTypeIdConst = 12719;

    public override string LocalName
    {
      get
      {
        return "channel";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 43;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12719;
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
        return Channel.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Channel.attributeNamespaceIds;
      }
    }

    [SchemaAttr(1, "id")]
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

    [SchemaAttr(0, "name")]
    public StringValue Name
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

    [SchemaAttr(0, "type")]
    public EnumValue<ChannelDataTypeValues> Type
    {
      get
      {
        return (EnumValue<ChannelDataTypeValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "default")]
    public StringValue Default
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

    [SchemaAttr(0, "min")]
    public DecimalValue Min
    {
      get
      {
        return (DecimalValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "max")]
    public DecimalValue Max
    {
      get
      {
        return (DecimalValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "orientation")]
    public EnumValue<ChannelValueOrientationValues> Orientation
    {
      get
      {
        return (EnumValue<ChannelValueOrientationValues>) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "respectTo")]
    public StringValue RespectTo
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

    [SchemaAttr(0, "units")]
    public StringValue Units
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

    public Channel()
    {
    }

    public Channel(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Channel(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Channel(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (43 == (int) namespaceId && "mapping" == name)
        return (OpenXmlElement) new Mapping();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (1 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "type" == name)
        return (OpenXmlSimpleType) new EnumValue<ChannelDataTypeValues>();
      if ((int) namespaceId == 0 && "default" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "min" == name)
        return (OpenXmlSimpleType) new DecimalValue();
      if ((int) namespaceId == 0 && "max" == name)
        return (OpenXmlSimpleType) new DecimalValue();
      if ((int) namespaceId == 0 && "orientation" == name)
        return (OpenXmlSimpleType) new EnumValue<ChannelValueOrientationValues>();
      if ((int) namespaceId == 0 && "respectTo" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "units" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Channel>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.EMMA.Sequence
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.EMMA
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (DerivedFrom))]
  [ChildElementInfo(typeof (Info))]
  [ChildElementInfo(typeof (Interpretation))]
  [ChildElementInfo(typeof (OneOf))]
  [ChildElementInfo(typeof (Group))]
  [ChildElementInfo(typeof (Sequence))]
  public class Sequence : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[24]
    {
      "id",
      "tokens",
      "process",
      "lang",
      "signal",
      "signal-size",
      "media-type",
      "confidence",
      "source",
      "start",
      "end",
      "time-ref-uri",
      "time-ref-anchor-point",
      "offset-to-start",
      "duration",
      "medium",
      "mode",
      "function",
      "verbal",
      "cost",
      "grammar-ref",
      "endpoint-info-ref",
      "model-ref",
      "dialog-turn"
    };
    private static byte[] attributeNamespaceIds = new byte[24]
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
      (byte) 44,
      (byte) 44,
      (byte) 44,
      (byte) 44,
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
    private const string tagName = "sequence";
    private const byte tagNsId = 44;
    internal const int ElementTypeIdConst = 12748;

    public override string LocalName
    {
      get
      {
        return "sequence";
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
        return 12748;
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
        return Sequence.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Sequence.attributeNamespaceIds;
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

    [SchemaAttr(44, "tokens")]
    public StringValue Tokens
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

    [SchemaAttr(44, "process")]
    public StringValue Process
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

    [SchemaAttr(44, "lang")]
    public StringValue Language
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

    [SchemaAttr(44, "signal")]
    public StringValue Signal
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

    [SchemaAttr(44, "signal-size")]
    public IntegerValue SignalSize
    {
      get
      {
        return (IntegerValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(44, "media-type")]
    public StringValue MediaType
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

    [SchemaAttr(44, "confidence")]
    public DecimalValue Confidence
    {
      get
      {
        return (DecimalValue) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(44, "source")]
    public StringValue Source
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

    [SchemaAttr(44, "start")]
    public UInt64Value Start
    {
      get
      {
        return (UInt64Value) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(44, "end")]
    public UInt64Value End
    {
      get
      {
        return (UInt64Value) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(44, "time-ref-uri")]
    public StringValue TimeReference
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

    [SchemaAttr(44, "time-ref-anchor-point")]
    public EnumValue<AnchorPointValues> TimeReferenceAnchorPoint
    {
      get
      {
        return (EnumValue<AnchorPointValues>) this.Attributes[12];
      }
      set
      {
        this.Attributes[12] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(44, "offset-to-start")]
    public IntegerValue OffsetToStart
    {
      get
      {
        return (IntegerValue) this.Attributes[13];
      }
      set
      {
        this.Attributes[13] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(44, "duration")]
    public IntegerValue Duration
    {
      get
      {
        return (IntegerValue) this.Attributes[14];
      }
      set
      {
        this.Attributes[14] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(44, "medium")]
    public ListValue<EnumValue<MediumValues>> Medium
    {
      get
      {
        return (ListValue<EnumValue<MediumValues>>) this.Attributes[15];
      }
      set
      {
        this.Attributes[15] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(44, "mode")]
    public ListValue<StringValue> Mode
    {
      get
      {
        return (ListValue<StringValue>) this.Attributes[16];
      }
      set
      {
        this.Attributes[16] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(44, "function")]
    public StringValue Function
    {
      get
      {
        return (StringValue) this.Attributes[17];
      }
      set
      {
        this.Attributes[17] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(44, "verbal")]
    public BooleanValue Verbal
    {
      get
      {
        return (BooleanValue) this.Attributes[18];
      }
      set
      {
        this.Attributes[18] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(44, "cost")]
    public DecimalValue Cost
    {
      get
      {
        return (DecimalValue) this.Attributes[19];
      }
      set
      {
        this.Attributes[19] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(44, "grammar-ref")]
    public StringValue GrammarRef
    {
      get
      {
        return (StringValue) this.Attributes[20];
      }
      set
      {
        this.Attributes[20] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(44, "endpoint-info-ref")]
    public StringValue EndpointInfoRef
    {
      get
      {
        return (StringValue) this.Attributes[21];
      }
      set
      {
        this.Attributes[21] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(44, "model-ref")]
    public StringValue ModelRef
    {
      get
      {
        return (StringValue) this.Attributes[22];
      }
      set
      {
        this.Attributes[22] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(44, "dialog-turn")]
    public StringValue DialogTurn
    {
      get
      {
        return (StringValue) this.Attributes[23];
      }
      set
      {
        this.Attributes[23] = (OpenXmlSimpleType) value;
      }
    }

    public Sequence()
    {
    }

    public Sequence(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Sequence(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Sequence(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (44 == (int) namespaceId && "derived-from" == name)
        return (OpenXmlElement) new DerivedFrom();
      if (44 == (int) namespaceId && "info" == name)
        return (OpenXmlElement) new Info();
      if (44 == (int) namespaceId && "interpretation" == name)
        return (OpenXmlElement) new Interpretation();
      if (44 == (int) namespaceId && "one-of" == name)
        return (OpenXmlElement) new OneOf();
      if (44 == (int) namespaceId && "group" == name)
        return (OpenXmlElement) new Group();
      if (44 == (int) namespaceId && "sequence" == name)
        return (OpenXmlElement) new Sequence();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (44 == (int) namespaceId && "tokens" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (44 == (int) namespaceId && "process" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (44 == (int) namespaceId && "lang" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (44 == (int) namespaceId && "signal" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (44 == (int) namespaceId && "signal-size" == name)
        return (OpenXmlSimpleType) new IntegerValue();
      if (44 == (int) namespaceId && "media-type" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (44 == (int) namespaceId && "confidence" == name)
        return (OpenXmlSimpleType) new DecimalValue();
      if (44 == (int) namespaceId && "source" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (44 == (int) namespaceId && "start" == name)
        return (OpenXmlSimpleType) new UInt64Value();
      if (44 == (int) namespaceId && "end" == name)
        return (OpenXmlSimpleType) new UInt64Value();
      if (44 == (int) namespaceId && "time-ref-uri" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (44 == (int) namespaceId && "time-ref-anchor-point" == name)
        return (OpenXmlSimpleType) new EnumValue<AnchorPointValues>();
      if (44 == (int) namespaceId && "offset-to-start" == name)
        return (OpenXmlSimpleType) new IntegerValue();
      if (44 == (int) namespaceId && "duration" == name)
        return (OpenXmlSimpleType) new IntegerValue();
      if (44 == (int) namespaceId && "medium" == name)
        return (OpenXmlSimpleType) new ListValue<EnumValue<MediumValues>>();
      if (44 == (int) namespaceId && "mode" == name)
        return (OpenXmlSimpleType) new ListValue<StringValue>();
      if (44 == (int) namespaceId && "function" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (44 == (int) namespaceId && "verbal" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if (44 == (int) namespaceId && "cost" == name)
        return (OpenXmlSimpleType) new DecimalValue();
      if (44 == (int) namespaceId && "grammar-ref" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (44 == (int) namespaceId && "endpoint-info-ref" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (44 == (int) namespaceId && "model-ref" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (44 == (int) namespaceId && "dialog-turn" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Sequence>(deep);
    }
  }
}

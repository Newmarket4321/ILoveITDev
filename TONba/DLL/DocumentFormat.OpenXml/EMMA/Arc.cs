// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.EMMA.Arc
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.EMMA
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Info))]
  public class Arc : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[12]
    {
      "from",
      "to",
      "start",
      "end",
      "offset-to-start",
      "duration",
      "confidence",
      "cost",
      "lang",
      "medium",
      "mode",
      "source"
    };
    private static byte[] attributeNamespaceIds = new byte[12]
    {
      (byte) 0,
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
    private const string tagName = "arc";
    private const byte tagNsId = 44;
    internal const int ElementTypeIdConst = 12756;

    public override string LocalName
    {
      get
      {
        return "arc";
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
        return 12756;
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
        return Arc.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Arc.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "from")]
    public IntegerValue From
    {
      get
      {
        return (IntegerValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "to")]
    public IntegerValue To
    {
      get
      {
        return (IntegerValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(44, "start")]
    public UInt64Value Start
    {
      get
      {
        return (UInt64Value) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(44, "end")]
    public UInt64Value End
    {
      get
      {
        return (UInt64Value) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(44, "offset-to-start")]
    public IntegerValue OffsetToStart
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

    [SchemaAttr(44, "duration")]
    public IntegerValue Duration
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

    [SchemaAttr(44, "confidence")]
    public DecimalValue Confidence
    {
      get
      {
        return (DecimalValue) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(44, "cost")]
    public DecimalValue Cost
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

    [SchemaAttr(44, "lang")]
    public StringValue Language
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

    [SchemaAttr(44, "source")]
    public StringValue Source
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

    public Arc()
    {
    }

    public Arc(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Arc(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Arc(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (44 == (int) namespaceId && "info" == name)
        return (OpenXmlElement) new Info();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "from" == name)
        return (OpenXmlSimpleType) new IntegerValue();
      if ((int) namespaceId == 0 && "to" == name)
        return (OpenXmlSimpleType) new IntegerValue();
      if (44 == (int) namespaceId && "start" == name)
        return (OpenXmlSimpleType) new UInt64Value();
      if (44 == (int) namespaceId && "end" == name)
        return (OpenXmlSimpleType) new UInt64Value();
      if (44 == (int) namespaceId && "offset-to-start" == name)
        return (OpenXmlSimpleType) new IntegerValue();
      if (44 == (int) namespaceId && "duration" == name)
        return (OpenXmlSimpleType) new IntegerValue();
      if (44 == (int) namespaceId && "confidence" == name)
        return (OpenXmlSimpleType) new DecimalValue();
      if (44 == (int) namespaceId && "cost" == name)
        return (OpenXmlSimpleType) new DecimalValue();
      if (44 == (int) namespaceId && "lang" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (44 == (int) namespaceId && "medium" == name)
        return (OpenXmlSimpleType) new ListValue<EnumValue<MediumValues>>();
      if (44 == (int) namespaceId && "mode" == name)
        return (OpenXmlSimpleType) new ListValue<StringValue>();
      if (44 == (int) namespaceId && "source" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Arc>(deep);
    }
  }
}

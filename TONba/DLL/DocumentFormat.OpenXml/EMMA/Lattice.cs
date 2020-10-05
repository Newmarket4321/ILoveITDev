// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.EMMA.Lattice
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.EMMA
{
  [ChildElementInfo(typeof (Node))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Arc))]
  public class Lattice : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "initial",
      "final",
      "time-ref-uri",
      "time-ref-anchor-point"
    };
    private static byte[] attributeNamespaceIds = new byte[4]
    {
      (byte) 0,
      (byte) 0,
      (byte) 44,
      (byte) 44
    };
    private const string tagName = "lattice";
    private const byte tagNsId = 44;
    internal const int ElementTypeIdConst = 12743;

    public override string LocalName
    {
      get
      {
        return "lattice";
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
        return 12743;
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
        return Lattice.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Lattice.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "initial")]
    public IntegerValue Initial
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

    [SchemaAttr(0, "final")]
    public ListValue<DecimalValue> Final
    {
      get
      {
        return (ListValue<DecimalValue>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(44, "time-ref-uri")]
    public StringValue TimeReference
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

    [SchemaAttr(44, "time-ref-anchor-point")]
    public EnumValue<AnchorPointValues> TimeReferenceAnchorPoint
    {
      get
      {
        return (EnumValue<AnchorPointValues>) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    public Lattice()
    {
    }

    public Lattice(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Lattice(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Lattice(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (44 == (int) namespaceId && "arc" == name)
        return (OpenXmlElement) new Arc();
      if (44 == (int) namespaceId && "node" == name)
        return (OpenXmlElement) new Node();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "initial" == name)
        return (OpenXmlSimpleType) new IntegerValue();
      if ((int) namespaceId == 0 && "final" == name)
        return (OpenXmlSimpleType) new ListValue<DecimalValue>();
      if (44 == (int) namespaceId && "time-ref-uri" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (44 == (int) namespaceId && "time-ref-anchor-point" == name)
        return (OpenXmlSimpleType) new EnumValue<AnchorPointValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Lattice>(deep);
    }
  }
}

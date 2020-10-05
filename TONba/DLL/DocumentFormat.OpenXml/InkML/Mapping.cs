// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.InkML.Mapping
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.InkML
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Table))]
  [ChildElementInfo(typeof (Bind))]
  [ChildElementInfo(typeof (Matrix))]
  [ChildElementInfo(typeof (Mapping))]
  public class Mapping : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "id",
      "type",
      "mappingRef"
    };
    private static byte[] attributeNamespaceIds = new byte[3]
    {
      (byte) 1,
      (byte) 0,
      (byte) 0
    };
    private const string tagName = "mapping";
    private const byte tagNsId = 43;
    internal const int ElementTypeIdConst = 12718;

    public override string LocalName
    {
      get
      {
        return "mapping";
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
        return 12718;
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
        return Mapping.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Mapping.attributeNamespaceIds;
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

    [SchemaAttr(0, "type")]
    public EnumValue<MappingTypeValues> Type
    {
      get
      {
        return (EnumValue<MappingTypeValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "mappingRef")]
    public StringValue MappingRef
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

    public Mapping()
    {
    }

    public Mapping(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Mapping(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Mapping(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (43 == (int) namespaceId && "bind" == name)
        return (OpenXmlElement) new Bind();
      if (43 == (int) namespaceId && "table" == name)
        return (OpenXmlElement) new Table();
      if (43 == (int) namespaceId && "matrix" == name)
        return (OpenXmlElement) new Matrix();
      if (43 == (int) namespaceId && "mapping" == name)
        return (OpenXmlElement) new Mapping();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (1 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "type" == name)
        return (OpenXmlSimpleType) new EnumValue<MappingTypeValues>();
      if ((int) namespaceId == 0 && "mappingRef" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Mapping>(deep);
    }
  }
}

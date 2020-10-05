// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.ObjectEmbed
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public class ObjectEmbed : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[5]
    {
      nameof (drawAspect),
      "id",
      "progId",
      "shapeId",
      "fieldCodes"
    };
    private static byte[] attributeNamespaceIds = new byte[5]
    {
      (byte) 23,
      (byte) 19,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "objectEmbed";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 12081;

    public override string LocalName
    {
      get
      {
        return "objectEmbed";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12081;
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
        return ObjectEmbed.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ObjectEmbed.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "drawAspect")]
    public EnumValue<ObjectDrawAspect> drawAspect
    {
      get
      {
        return (EnumValue<ObjectDrawAspect>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(19, "id")]
    public StringValue Id
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

    [SchemaAttr(23, "progId")]
    public StringValue ProgId
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

    [SchemaAttr(23, "shapeId")]
    public StringValue ShapeId
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

    [SchemaAttr(23, "fieldCodes")]
    public StringValue FieldCodes
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

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "drawAspect" == name)
        return (OpenXmlSimpleType) new EnumValue<ObjectDrawAspect>();
      if (19 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "progId" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "shapeId" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "fieldCodes" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ObjectEmbed>(deep);
    }
  }
}

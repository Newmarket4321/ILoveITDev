// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.ContentType.ContentTypeSchema
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office.ContentType
{
  [GeneratedCode("DomGen", "2.0")]
  public class ContentTypeSchema : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[8]
    {
      "_",
      "_",
      "contentTypeName",
      "contentTypeID",
      "contentTypeVersion",
      "contentTypeDescription",
      "contentTypeScope",
      "versionID"
    };
    private static byte[] attributeNamespaceIds = new byte[8]
    {
      (byte) 38,
      (byte) 41,
      (byte) 41,
      (byte) 41,
      (byte) 41,
      (byte) 41,
      (byte) 41,
      (byte) 41
    };
    private const string tagName = "contentTypeSchema";
    private const byte tagNsId = 38;
    internal const int ElementTypeIdConst = 12705;

    public override string LocalName
    {
      get
      {
        return "contentTypeSchema";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 38;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12705;
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
        return ContentTypeSchema.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ContentTypeSchema.attributeNamespaceIds;
      }
    }

    [SchemaAttr(38, "_")]
    public StringValue UnderScore
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

    [SchemaAttr(41, "_")]
    public StringValue ReservedAttributeString
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

    [SchemaAttr(41, "contentTypeName")]
    public StringValue ContentTypeName
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

    [SchemaAttr(41, "contentTypeID")]
    public StringValue ContentTypeID
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

    [SchemaAttr(41, "contentTypeVersion")]
    public Int32Value ContentTypeVersion
    {
      get
      {
        return (Int32Value) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(41, "contentTypeDescription")]
    public StringValue ContentTypeDescription
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

    [SchemaAttr(41, "contentTypeScope")]
    public StringValue ContentTypeScope
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

    [SchemaAttr(41, "versionID")]
    public StringValue VersionID
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

    public ContentTypeSchema()
    {
    }

    public ContentTypeSchema(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ContentTypeSchema(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ContentTypeSchema(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (38 == (int) namespaceId && "_" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (41 == (int) namespaceId && "_" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (41 == (int) namespaceId && "contentTypeName" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (41 == (int) namespaceId && "contentTypeID" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (41 == (int) namespaceId && "contentTypeVersion" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (41 == (int) namespaceId && "contentTypeDescription" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (41 == (int) namespaceId && "contentTypeScope" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (41 == (int) namespaceId && "versionID" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ContentTypeSchema>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.CustomXmlSchemaReferences
{
  [GeneratedCode("DomGen", "2.0")]
  public class Schema : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "uri",
      "manifestLocation",
      "schemaLocation"
    };
    private static byte[] attributeNamespaceIds = new byte[3]
    {
      (byte) 25,
      (byte) 25,
      (byte) 25
    };
    private const string tagName = "schema";
    private const byte tagNsId = 25;
    internal const int ElementTypeIdConst = 12469;

    public override string LocalName
    {
      get
      {
        return "schema";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 25;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12469;
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
        return Schema.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Schema.attributeNamespaceIds;
      }
    }

    [SchemaAttr(25, "uri")]
    public StringValue Uri
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

    [SchemaAttr(25, "manifestLocation")]
    public StringValue ManifestLocation
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

    [SchemaAttr(25, "schemaLocation")]
    public StringValue SchemaLocation
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

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (25 == (int) namespaceId && "uri" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (25 == (int) namespaceId && "manifestLocation" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (25 == (int) namespaceId && "schemaLocation" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Schema>(deep);
    }
  }
}

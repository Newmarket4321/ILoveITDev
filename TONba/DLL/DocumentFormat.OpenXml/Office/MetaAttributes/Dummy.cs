// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.MetaAttributes.Dummy
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office.MetaAttributes
{
  [GeneratedCode("DomGen", "2.0")]
  public class Dummy : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[17]
    {
      "decimals",
      "default",
      "description",
      "displayName",
      "fieldsID",
      "format",
      "hidden",
      "index",
      "internalName",
      nameof (LCID),
      "list",
      "percentage",
      "readOnly",
      "requiredMultiChoice",
      "root",
      "showField",
      "web"
    };
    private static byte[] attributeNamespaceIds = new byte[17];
    private const string tagName = "DummyContentTypeElement";
    private const byte tagNsId = 41;
    internal const int ElementTypeIdConst = 12713;

    public override string LocalName
    {
      get
      {
        return "DummyContentTypeElement";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 41;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12713;
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
        return Dummy.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Dummy.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "decimals")]
    public StringValue Decimals
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

    [SchemaAttr(0, "default")]
    public StringValue Default
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

    [SchemaAttr(0, "description")]
    public StringValue Description
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

    [SchemaAttr(0, "displayName")]
    public StringValue DisplayName
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

    [SchemaAttr(0, "fieldsID")]
    public StringValue FieldsID
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

    [SchemaAttr(0, "format")]
    public StringValue Format
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

    [SchemaAttr(0, "hidden")]
    public StringValue Hidden
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

    [SchemaAttr(0, "index")]
    public Int32Value Index
    {
      get
      {
        return (Int32Value) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "internalName")]
    public StringValue InternalName
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

    [SchemaAttr(0, "LCID")]
    public Int32Value LCID
    {
      get
      {
        return (Int32Value) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "list")]
    public StringValue List
    {
      get
      {
        return (StringValue) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "percentage")]
    public StringValue Percentage
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

    [SchemaAttr(0, "readOnly")]
    public StringValue ReadOnly
    {
      get
      {
        return (StringValue) this.Attributes[12];
      }
      set
      {
        this.Attributes[12] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "requiredMultiChoice")]
    public StringValue RequiredMultiChoice
    {
      get
      {
        return (StringValue) this.Attributes[13];
      }
      set
      {
        this.Attributes[13] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "root")]
    public EnumValue<TrueOnlyValues> Root
    {
      get
      {
        return (EnumValue<TrueOnlyValues>) this.Attributes[14];
      }
      set
      {
        this.Attributes[14] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "showField")]
    public StringValue ShowField
    {
      get
      {
        return (StringValue) this.Attributes[15];
      }
      set
      {
        this.Attributes[15] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "web")]
    public StringValue Web
    {
      get
      {
        return (StringValue) this.Attributes[16];
      }
      set
      {
        this.Attributes[16] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "decimals" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "default" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "description" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "displayName" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "fieldsID" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "format" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "hidden" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "index" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "internalName" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "LCID" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "list" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "percentage" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "readOnly" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "requiredMultiChoice" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "root" == name)
        return (OpenXmlSimpleType) new EnumValue<TrueOnlyValues>();
      if ((int) namespaceId == 0 && "showField" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "web" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Dummy>(deep);
    }
  }
}

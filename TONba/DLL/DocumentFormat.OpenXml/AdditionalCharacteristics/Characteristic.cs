// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.AdditionalCharacteristics.Characteristic
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.AdditionalCharacteristics
{
  [GeneratedCode("DomGen", "2.0")]
  public class Characteristic : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "name",
      "relation",
      "val",
      "vocabulary"
    };
    private static byte[] attributeNamespaceIds = new byte[4];
    private const string tagName = "characteristic";
    private const byte tagNsId = 8;
    internal const int ElementTypeIdConst = 10823;

    public override string LocalName
    {
      get
      {
        return "characteristic";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 8;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10823;
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
        return Characteristic.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Characteristic.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "name")]
    public StringValue Name
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

    [SchemaAttr(0, "relation")]
    public EnumValue<RelationValues> Relation
    {
      get
      {
        return (EnumValue<RelationValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "val")]
    public StringValue Val
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

    [SchemaAttr(0, "vocabulary")]
    public StringValue Vocabulary
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

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "relation" == name)
        return (OpenXmlSimpleType) new EnumValue<RelationValues>();
      if ((int) namespaceId == 0 && "val" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "vocabulary" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Characteristic>(deep);
    }
  }
}

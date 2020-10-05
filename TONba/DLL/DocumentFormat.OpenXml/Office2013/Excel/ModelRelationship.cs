// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Excel.ModelRelationship
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2013.Excel
{
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class ModelRelationship : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "fromTable",
      "fromColumn",
      "toTable",
      "toColumn"
    };
    private static byte[] attributeNamespaceIds = new byte[4];
    private const string tagName = "modelRelationship";
    private const byte tagNsId = 71;
    internal const int ElementTypeIdConst = 13407;

    public override string LocalName
    {
      get
      {
        return "modelRelationship";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 71;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13407;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return ModelRelationship.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ModelRelationship.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "fromTable")]
    public StringValue FromTable
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

    [SchemaAttr(0, "fromColumn")]
    public StringValue FromColumn
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

    [SchemaAttr(0, "toTable")]
    public StringValue ToTable
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

    [SchemaAttr(0, "toColumn")]
    public StringValue ToColumn
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
      if ((int) namespaceId == 0 && "fromTable" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "fromColumn" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "toTable" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "toColumn" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ModelRelationship>(deep);
    }
  }
}

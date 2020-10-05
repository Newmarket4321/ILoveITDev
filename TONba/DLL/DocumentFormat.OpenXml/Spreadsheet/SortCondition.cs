// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.SortCondition
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  public class SortCondition : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[7]
    {
      "descending",
      "sortBy",
      "ref",
      "customList",
      "dxfId",
      "iconSet",
      "iconId"
    };
    private static byte[] attributeNamespaceIds = new byte[7];
    private const string tagName = "sortCondition";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11428;

    public override string LocalName
    {
      get
      {
        return "sortCondition";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 22;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11428;
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
        return SortCondition.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return SortCondition.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "descending")]
    public BooleanValue Descending
    {
      get
      {
        return (BooleanValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "sortBy")]
    public EnumValue<SortByValues> SortBy
    {
      get
      {
        return (EnumValue<SortByValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "ref")]
    public StringValue Reference
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

    [SchemaAttr(0, "customList")]
    public StringValue CustomList
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

    [SchemaAttr(0, "dxfId")]
    public UInt32Value FormatId
    {
      get
      {
        return (UInt32Value) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "iconSet")]
    public EnumValue<IconSetValues> IconSet
    {
      get
      {
        return (EnumValue<IconSetValues>) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "iconId")]
    public UInt32Value IconId
    {
      get
      {
        return (UInt32Value) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "descending" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "sortBy" == name)
        return (OpenXmlSimpleType) new EnumValue<SortByValues>();
      if ((int) namespaceId == 0 && "ref" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "customList" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "dxfId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "iconSet" == name)
        return (OpenXmlSimpleType) new EnumValue<IconSetValues>();
      if ((int) namespaceId == 0 && "iconId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SortCondition>(deep);
    }
  }
}

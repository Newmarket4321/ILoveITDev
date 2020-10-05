// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataTable
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class DataTable : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "legendKeys",
      "horizontalBorder",
      "verticalBorder",
      "outlineBorder"
    };
    private static byte[] attributeNamespaceIds = new byte[4];
    private const string tagName = "dataTable";
    private const byte tagNsId = 65;
    internal const int ElementTypeIdConst = 13272;

    public override string LocalName
    {
      get
      {
        return "dataTable";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 65;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13272;
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
        return DataTable.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return DataTable.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "legendKeys")]
    public EnumValue<Boolean> LegendKeys
    {
      get
      {
        return (EnumValue<Boolean>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "horizontalBorder")]
    public EnumValue<Boolean> HorizontalBorder
    {
      get
      {
        return (EnumValue<Boolean>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "verticalBorder")]
    public EnumValue<Boolean> VerticalBorder
    {
      get
      {
        return (EnumValue<Boolean>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "outlineBorder")]
    public EnumValue<Boolean> OutlineBorder
    {
      get
      {
        return (EnumValue<Boolean>) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "legendKeys" == name)
        return (OpenXmlSimpleType) new EnumValue<Boolean>();
      if ((int) namespaceId == 0 && "horizontalBorder" == name)
        return (OpenXmlSimpleType) new EnumValue<Boolean>();
      if ((int) namespaceId == 0 && "verticalBorder" == name)
        return (OpenXmlSimpleType) new EnumValue<Boolean>();
      if ((int) namespaceId == 0 && "outlineBorder" == name)
        return (OpenXmlSimpleType) new EnumValue<Boolean>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DataTable>(deep);
    }
  }
}

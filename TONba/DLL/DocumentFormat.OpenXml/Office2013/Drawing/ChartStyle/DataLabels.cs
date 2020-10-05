// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataLabels
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class DataLabels : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[6]
    {
      "position",
      "value",
      "seriesName",
      "categoryName",
      "legendKey",
      "percentage"
    };
    private static byte[] attributeNamespaceIds = new byte[6];
    private const string tagName = "dataLabels";
    private const byte tagNsId = 65;
    internal const int ElementTypeIdConst = 13271;

    public override string LocalName
    {
      get
      {
        return "dataLabels";
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
        return 13271;
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
        return DataLabels.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return DataLabels.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "position")]
    public EnumValue<DataLabelsPosition> Position
    {
      get
      {
        return (EnumValue<DataLabelsPosition>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "value")]
    public EnumValue<Boolean> Value
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

    [SchemaAttr(0, "seriesName")]
    public EnumValue<Boolean> SeriesName
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

    [SchemaAttr(0, "categoryName")]
    public EnumValue<Boolean> CategoryName
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

    [SchemaAttr(0, "legendKey")]
    public EnumValue<Boolean> LegendKey
    {
      get
      {
        return (EnumValue<Boolean>) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "percentage")]
    public EnumValue<Boolean> Percentage
    {
      get
      {
        return (EnumValue<Boolean>) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "position" == name)
        return (OpenXmlSimpleType) new EnumValue<DataLabelsPosition>();
      if ((int) namespaceId == 0 && "value" == name)
        return (OpenXmlSimpleType) new EnumValue<Boolean>();
      if ((int) namespaceId == 0 && "seriesName" == name)
        return (OpenXmlSimpleType) new EnumValue<Boolean>();
      if ((int) namespaceId == 0 && "categoryName" == name)
        return (OpenXmlSimpleType) new EnumValue<Boolean>();
      if ((int) namespaceId == 0 && "legendKey" == name)
        return (OpenXmlSimpleType) new EnumValue<Boolean>();
      if ((int) namespaceId == 0 && "percentage" == name)
        return (OpenXmlSimpleType) new EnumValue<Boolean>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DataLabels>(deep);
    }
  }
}

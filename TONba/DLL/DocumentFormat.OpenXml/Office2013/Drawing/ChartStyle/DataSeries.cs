// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataSeries
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle
{
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class DataSeries : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[8]
    {
      "overlap",
      "gapWidth",
      "gapDepth",
      "doughnutHoleSize",
      "markerVisible",
      "hiloLines",
      "dropLines",
      "seriesLines"
    };
    private static byte[] attributeNamespaceIds = new byte[8];
    private const string tagName = "dataSeries";
    private const byte tagNsId = 65;
    internal const int ElementTypeIdConst = 13270;

    public override string LocalName
    {
      get
      {
        return "dataSeries";
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
        return 13270;
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
        return DataSeries.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return DataSeries.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "overlap")]
    public SByteValue Overlap
    {
      get
      {
        return (SByteValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "gapWidth")]
    public UInt16Value GapWidth
    {
      get
      {
        return (UInt16Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "gapDepth")]
    public UInt16Value GapDepth
    {
      get
      {
        return (UInt16Value) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "doughnutHoleSize")]
    public ByteValue DoughnutHoleSize
    {
      get
      {
        return (ByteValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "markerVisible")]
    public EnumValue<Boolean> MarkerVisible
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

    [SchemaAttr(0, "hiloLines")]
    public EnumValue<Boolean> HiloLines
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

    [SchemaAttr(0, "dropLines")]
    public EnumValue<Boolean> DropLines
    {
      get
      {
        return (EnumValue<Boolean>) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "seriesLines")]
    public EnumValue<Boolean> SeriesLines
    {
      get
      {
        return (EnumValue<Boolean>) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "overlap" == name)
        return (OpenXmlSimpleType) new SByteValue();
      if ((int) namespaceId == 0 && "gapWidth" == name)
        return (OpenXmlSimpleType) new UInt16Value();
      if ((int) namespaceId == 0 && "gapDepth" == name)
        return (OpenXmlSimpleType) new UInt16Value();
      if ((int) namespaceId == 0 && "doughnutHoleSize" == name)
        return (OpenXmlSimpleType) new ByteValue();
      if ((int) namespaceId == 0 && "markerVisible" == name)
        return (OpenXmlSimpleType) new EnumValue<Boolean>();
      if ((int) namespaceId == 0 && "hiloLines" == name)
        return (OpenXmlSimpleType) new EnumValue<Boolean>();
      if ((int) namespaceId == 0 && "dropLines" == name)
        return (OpenXmlSimpleType) new EnumValue<Boolean>();
      if ((int) namespaceId == 0 && "seriesLines" == name)
        return (OpenXmlSimpleType) new EnumValue<Boolean>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DataSeries>(deep);
    }
  }
}

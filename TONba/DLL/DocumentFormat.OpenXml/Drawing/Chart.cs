// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Chart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  public class Chart : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "seriesIdx",
      "categoryIdx",
      "bldStep"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private const string tagName = "chart";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10173;

    public override string LocalName
    {
      get
      {
        return "chart";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 10;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10173;
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
        return Chart.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Chart.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "seriesIdx")]
    public Int32Value SeriesIndex
    {
      get
      {
        return (Int32Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "categoryIdx")]
    public Int32Value CategoryIndex
    {
      get
      {
        return (Int32Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "bldStep")]
    public EnumValue<ChartBuildStepValues> BuildStep
    {
      get
      {
        return (EnumValue<ChartBuildStepValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "seriesIdx" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "categoryIdx" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "bldStep" == name)
        return (OpenXmlSimpleType) new EnumValue<ChartBuildStepValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Chart>(deep);
    }
  }
}

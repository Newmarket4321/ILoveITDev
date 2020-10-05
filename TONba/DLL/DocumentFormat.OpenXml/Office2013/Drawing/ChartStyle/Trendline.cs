// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Trendline
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle
{
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class Trendline : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "add",
      "equation",
      "rsquared"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private const string tagName = "trendline";
    private const byte tagNsId = 65;
    internal const int ElementTypeIdConst = 13276;

    public override string LocalName
    {
      get
      {
        return "trendline";
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
        return 13276;
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
        return Trendline.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Trendline.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "add")]
    public EnumValue<Boolean> Add
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

    [SchemaAttr(0, "equation")]
    public EnumValue<Boolean> Equation
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

    [SchemaAttr(0, "rsquared")]
    public EnumValue<Boolean> RSquared
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

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "add" == name)
        return (OpenXmlSimpleType) new EnumValue<Boolean>();
      if ((int) namespaceId == 0 && "equation" == name)
        return (OpenXmlSimpleType) new EnumValue<Boolean>();
      if ((int) namespaceId == 0 && "rsquared" == name)
        return (OpenXmlSimpleType) new EnumValue<Boolean>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Trendline>(deep);
    }
  }
}

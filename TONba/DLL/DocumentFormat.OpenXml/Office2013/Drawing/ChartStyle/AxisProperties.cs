// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.AxisProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle
{
  [GeneratedCode("DomGen", "2.0")]
  public abstract class AxisProperties : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[7]
    {
      "visible",
      "majorTick",
      "minorTick",
      "labelPosition",
      "majorGridlines",
      "minorGridlines",
      "title"
    };
    private static byte[] attributeNamespaceIds = new byte[7];

    internal override string[] AttributeTagNames
    {
      get
      {
        return AxisProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return AxisProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "visible")]
    public EnumValue<Boolean> Visible
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

    [SchemaAttr(0, "majorTick")]
    public EnumValue<TickMarkNinch> MajorTick
    {
      get
      {
        return (EnumValue<TickMarkNinch>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "minorTick")]
    public EnumValue<TickMarkNinch> MinorTickProp
    {
      get
      {
        return (EnumValue<TickMarkNinch>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "labelPosition")]
    public EnumValue<TickLabelPositionNinch> LabelPosition
    {
      get
      {
        return (EnumValue<TickLabelPositionNinch>) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "majorGridlines")]
    public EnumValue<Boolean> MajorGridlines
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

    [SchemaAttr(0, "minorGridlines")]
    public EnumValue<Boolean> MinorGridlinesProp
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

    [SchemaAttr(0, "title")]
    public EnumValue<Boolean> TitleProp
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

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "visible" == name)
        return (OpenXmlSimpleType) new EnumValue<Boolean>();
      if ((int) namespaceId == 0 && "majorTick" == name)
        return (OpenXmlSimpleType) new EnumValue<TickMarkNinch>();
      if ((int) namespaceId == 0 && "minorTick" == name)
        return (OpenXmlSimpleType) new EnumValue<TickMarkNinch>();
      if ((int) namespaceId == 0 && "labelPosition" == name)
        return (OpenXmlSimpleType) new EnumValue<TickLabelPositionNinch>();
      if ((int) namespaceId == 0 && "majorGridlines" == name)
        return (OpenXmlSimpleType) new EnumValue<Boolean>();
      if ((int) namespaceId == 0 && "minorGridlines" == name)
        return (OpenXmlSimpleType) new EnumValue<Boolean>();
      if ((int) namespaceId == 0 && "title" == name)
        return (OpenXmlSimpleType) new EnumValue<Boolean>();
      return base.AttributeFactory(namespaceId, name);
    }
  }
}

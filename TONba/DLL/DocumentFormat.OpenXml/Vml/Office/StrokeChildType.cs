// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Vml.Office.StrokeChildType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Vml.Office
{
  [GeneratedCode("DomGen", "2.0")]
  public abstract class StrokeChildType : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[27]
    {
      "ext",
      "on",
      "weight",
      "color",
      "color2",
      "opacity",
      "linestyle",
      "miterlimit",
      "joinstyle",
      "endcap",
      "dashstyle",
      "insetpen",
      "filltype",
      "src",
      "imageaspect",
      "imagesize",
      "imagealignshape",
      "startarrow",
      "startarrowwidth",
      "startarrowlength",
      "endarrow",
      "endarrowwidth",
      "endarrowlength",
      "href",
      "althref",
      "title",
      "forcedash"
    };
    private static byte[] attributeNamespaceIds = new byte[27]
    {
      (byte) 26,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27
    };

    internal override string[] AttributeTagNames
    {
      get
      {
        return StrokeChildType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return StrokeChildType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(26, "ext")]
    public EnumValue<ExtensionHandlingBehaviorValues> Extension
    {
      get
      {
        return (EnumValue<ExtensionHandlingBehaviorValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "on")]
    public TrueFalseValue On
    {
      get
      {
        return (TrueFalseValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "weight")]
    public StringValue Weight
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

    [SchemaAttr(0, "color")]
    public StringValue Color
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

    [SchemaAttr(0, "color2")]
    public StringValue Color2
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

    [SchemaAttr(0, "opacity")]
    public StringValue Opacity
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

    [SchemaAttr(0, "linestyle")]
    public EnumValue<StrokeLineStyleValues> LineStyle
    {
      get
      {
        return (EnumValue<StrokeLineStyleValues>) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "miterlimit")]
    public DecimalValue MiterLimit
    {
      get
      {
        return (DecimalValue) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "joinstyle")]
    public EnumValue<StrokeJoinStyleValues> JoinStyle
    {
      get
      {
        return (EnumValue<StrokeJoinStyleValues>) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "endcap")]
    public EnumValue<StrokeEndCapValues> EndCap
    {
      get
      {
        return (EnumValue<StrokeEndCapValues>) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "dashstyle")]
    public StringValue DashStyle
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

    [SchemaAttr(0, "insetpen")]
    public TrueFalseValue InsetPen
    {
      get
      {
        return (TrueFalseValue) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "filltype")]
    public EnumValue<FillTypeValues> FillType
    {
      get
      {
        return (EnumValue<FillTypeValues>) this.Attributes[12];
      }
      set
      {
        this.Attributes[12] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "src")]
    public StringValue Source
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

    [SchemaAttr(0, "imageaspect")]
    public EnumValue<ImageAspectValues> ImageAspect
    {
      get
      {
        return (EnumValue<ImageAspectValues>) this.Attributes[14];
      }
      set
      {
        this.Attributes[14] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "imagesize")]
    public StringValue ImageSize
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

    [SchemaAttr(0, "imagealignshape")]
    public TrueFalseValue ImageAlignShape
    {
      get
      {
        return (TrueFalseValue) this.Attributes[16];
      }
      set
      {
        this.Attributes[16] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "startarrow")]
    public EnumValue<StrokeArrowValues> StartArrow
    {
      get
      {
        return (EnumValue<StrokeArrowValues>) this.Attributes[17];
      }
      set
      {
        this.Attributes[17] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "startarrowwidth")]
    public EnumValue<StrokeArrowWidthValues> StartArrowWidth
    {
      get
      {
        return (EnumValue<StrokeArrowWidthValues>) this.Attributes[18];
      }
      set
      {
        this.Attributes[18] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "startarrowlength")]
    public EnumValue<StrokeArrowLengthValues> StartArrowLength
    {
      get
      {
        return (EnumValue<StrokeArrowLengthValues>) this.Attributes[19];
      }
      set
      {
        this.Attributes[19] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "endarrow")]
    public EnumValue<StrokeArrowValues> EndArrow
    {
      get
      {
        return (EnumValue<StrokeArrowValues>) this.Attributes[20];
      }
      set
      {
        this.Attributes[20] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "endarrowwidth")]
    public EnumValue<StrokeArrowWidthValues> EndArrowWidth
    {
      get
      {
        return (EnumValue<StrokeArrowWidthValues>) this.Attributes[21];
      }
      set
      {
        this.Attributes[21] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "endarrowlength")]
    public EnumValue<StrokeArrowLengthValues> EndArrowLength
    {
      get
      {
        return (EnumValue<StrokeArrowLengthValues>) this.Attributes[22];
      }
      set
      {
        this.Attributes[22] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "href")]
    public StringValue Href
    {
      get
      {
        return (StringValue) this.Attributes[23];
      }
      set
      {
        this.Attributes[23] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "althref")]
    public StringValue AlternateImageReference
    {
      get
      {
        return (StringValue) this.Attributes[24];
      }
      set
      {
        this.Attributes[24] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "title")]
    public StringValue Title
    {
      get
      {
        return (StringValue) this.Attributes[25];
      }
      set
      {
        this.Attributes[25] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "forcedash")]
    public TrueFalseValue ForceDash
    {
      get
      {
        return (TrueFalseValue) this.Attributes[26];
      }
      set
      {
        this.Attributes[26] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (26 == (int) namespaceId && "ext" == name)
        return (OpenXmlSimpleType) new EnumValue<ExtensionHandlingBehaviorValues>();
      if ((int) namespaceId == 0 && "on" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "weight" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "color" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "color2" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "opacity" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "linestyle" == name)
        return (OpenXmlSimpleType) new EnumValue<StrokeLineStyleValues>();
      if ((int) namespaceId == 0 && "miterlimit" == name)
        return (OpenXmlSimpleType) new DecimalValue();
      if ((int) namespaceId == 0 && "joinstyle" == name)
        return (OpenXmlSimpleType) new EnumValue<StrokeJoinStyleValues>();
      if ((int) namespaceId == 0 && "endcap" == name)
        return (OpenXmlSimpleType) new EnumValue<StrokeEndCapValues>();
      if ((int) namespaceId == 0 && "dashstyle" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "insetpen" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "filltype" == name)
        return (OpenXmlSimpleType) new EnumValue<FillTypeValues>();
      if ((int) namespaceId == 0 && "src" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "imageaspect" == name)
        return (OpenXmlSimpleType) new EnumValue<ImageAspectValues>();
      if ((int) namespaceId == 0 && "imagesize" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "imagealignshape" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "startarrow" == name)
        return (OpenXmlSimpleType) new EnumValue<StrokeArrowValues>();
      if ((int) namespaceId == 0 && "startarrowwidth" == name)
        return (OpenXmlSimpleType) new EnumValue<StrokeArrowWidthValues>();
      if ((int) namespaceId == 0 && "startarrowlength" == name)
        return (OpenXmlSimpleType) new EnumValue<StrokeArrowLengthValues>();
      if ((int) namespaceId == 0 && "endarrow" == name)
        return (OpenXmlSimpleType) new EnumValue<StrokeArrowValues>();
      if ((int) namespaceId == 0 && "endarrowwidth" == name)
        return (OpenXmlSimpleType) new EnumValue<StrokeArrowWidthValues>();
      if ((int) namespaceId == 0 && "endarrowlength" == name)
        return (OpenXmlSimpleType) new EnumValue<StrokeArrowLengthValues>();
      if (27 == (int) namespaceId && "href" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (27 == (int) namespaceId && "althref" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (27 == (int) namespaceId && "title" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (27 == (int) namespaceId && "forcedash" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      return base.AttributeFactory(namespaceId, name);
    }
  }
}

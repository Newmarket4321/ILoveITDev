// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Vml.Stroke
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Vml.Office;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Vml
{
  [ChildElementInfo(typeof (BottomStroke))]
  [ChildElementInfo(typeof (LeftStroke))]
  [ChildElementInfo(typeof (TopStroke))]
  [ChildElementInfo(typeof (RightStroke))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ColumnStroke))]
  public class Stroke : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[28]
    {
      "id",
      "on",
      "weight",
      "color",
      "opacity",
      "linestyle",
      "miterlimit",
      "joinstyle",
      "endcap",
      "dashstyle",
      "filltype",
      "src",
      "imageaspect",
      "imagesize",
      "imagealignshape",
      "color2",
      "startarrow",
      "startarrowwidth",
      "startarrowlength",
      "endarrow",
      "endarrowwidth",
      "endarrowlength",
      "href",
      "althref",
      "title",
      "forcedash",
      "id",
      "insetpen"
    };
    private static byte[] attributeNamespaceIds = new byte[28]
    {
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
      (byte) 27,
      (byte) 19,
      (byte) 0
    };
    private static readonly string[] eleTagNames = new string[5]
    {
      "left",
      "top",
      "right",
      "bottom",
      "column"
    };
    private static readonly byte[] eleNamespaceIds = new byte[5]
    {
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27,
      (byte) 27
    };
    private const string tagName = "stroke";
    private const byte tagNsId = 26;
    internal const int ElementTypeIdConst = 12581;

    public override string LocalName
    {
      get
      {
        return "stroke";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 26;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12581;
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
        return Stroke.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Stroke.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "id")]
    public StringValue Id
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

    [SchemaAttr(0, "opacity")]
    public StringValue Opacity
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

    [SchemaAttr(0, "linestyle")]
    public EnumValue<StrokeLineStyleValues> LineStyle
    {
      get
      {
        return (EnumValue<StrokeLineStyleValues>) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "miterlimit")]
    public StringValue Miterlimit
    {
      get
      {
        return (StringValue) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "joinstyle")]
    public EnumValue<StrokeJoinStyleValues> JoinStyle
    {
      get
      {
        return (EnumValue<StrokeJoinStyleValues>) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "endcap")]
    public EnumValue<StrokeEndCapValues> EndCap
    {
      get
      {
        return (EnumValue<StrokeEndCapValues>) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "dashstyle")]
    public StringValue DashStyle
    {
      get
      {
        return (StringValue) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "filltype")]
    public EnumValue<StrokeFillTypeValues> FillType
    {
      get
      {
        return (EnumValue<StrokeFillTypeValues>) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "src")]
    public StringValue Source
    {
      get
      {
        return (StringValue) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "imageaspect")]
    public EnumValue<ImageAspectValues> ImageAspect
    {
      get
      {
        return (EnumValue<ImageAspectValues>) this.Attributes[12];
      }
      set
      {
        this.Attributes[12] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "imagesize")]
    public StringValue ImageSize
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

    [SchemaAttr(0, "imagealignshape")]
    public TrueFalseValue ImageAlignShape
    {
      get
      {
        return (TrueFalseValue) this.Attributes[14];
      }
      set
      {
        this.Attributes[14] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "color2")]
    public StringValue Color2
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

    [SchemaAttr(0, "startarrow")]
    public EnumValue<StrokeArrowValues> StartArrow
    {
      get
      {
        return (EnumValue<StrokeArrowValues>) this.Attributes[16];
      }
      set
      {
        this.Attributes[16] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "startarrowwidth")]
    public EnumValue<StrokeArrowWidthValues> StartArrowWidth
    {
      get
      {
        return (EnumValue<StrokeArrowWidthValues>) this.Attributes[17];
      }
      set
      {
        this.Attributes[17] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "startarrowlength")]
    public EnumValue<StrokeArrowLengthValues> StartArrowLength
    {
      get
      {
        return (EnumValue<StrokeArrowLengthValues>) this.Attributes[18];
      }
      set
      {
        this.Attributes[18] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "endarrow")]
    public EnumValue<StrokeArrowValues> EndArrow
    {
      get
      {
        return (EnumValue<StrokeArrowValues>) this.Attributes[19];
      }
      set
      {
        this.Attributes[19] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "endarrowwidth")]
    public EnumValue<StrokeArrowWidthValues> EndArrowWidth
    {
      get
      {
        return (EnumValue<StrokeArrowWidthValues>) this.Attributes[20];
      }
      set
      {
        this.Attributes[20] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "endarrowlength")]
    public EnumValue<StrokeArrowLengthValues> EndArrowLength
    {
      get
      {
        return (EnumValue<StrokeArrowLengthValues>) this.Attributes[21];
      }
      set
      {
        this.Attributes[21] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "href")]
    public StringValue Href
    {
      get
      {
        return (StringValue) this.Attributes[22];
      }
      set
      {
        this.Attributes[22] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "althref")]
    public StringValue AlternateImageReference
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

    [SchemaAttr(27, "title")]
    public StringValue Title
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

    [SchemaAttr(27, "forcedash")]
    public TrueFalseValue ForceDash
    {
      get
      {
        return (TrueFalseValue) this.Attributes[25];
      }
      set
      {
        this.Attributes[25] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(19, "id")]
    public StringValue RelationshipId
    {
      get
      {
        return (StringValue) this.Attributes[26];
      }
      set
      {
        this.Attributes[26] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "insetpen")]
    public TrueFalseValue Insetpen
    {
      get
      {
        return (TrueFalseValue) this.Attributes[27];
      }
      set
      {
        this.Attributes[27] = (OpenXmlSimpleType) value;
      }
    }

    public Stroke()
    {
    }

    public Stroke(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Stroke(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Stroke(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (27 == (int) namespaceId && "left" == name)
        return (OpenXmlElement) new LeftStroke();
      if (27 == (int) namespaceId && "top" == name)
        return (OpenXmlElement) new TopStroke();
      if (27 == (int) namespaceId && "right" == name)
        return (OpenXmlElement) new RightStroke();
      if (27 == (int) namespaceId && "bottom" == name)
        return (OpenXmlElement) new BottomStroke();
      if (27 == (int) namespaceId && "column" == name)
        return (OpenXmlElement) new ColumnStroke();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Stroke.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Stroke.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public LeftStroke LeftStroke
    {
      get
      {
        return this.GetElement<LeftStroke>(0);
      }
      set
      {
        this.SetElement<LeftStroke>(0, value);
      }
    }

    public TopStroke TopStroke
    {
      get
      {
        return this.GetElement<TopStroke>(1);
      }
      set
      {
        this.SetElement<TopStroke>(1, value);
      }
    }

    public RightStroke RightStroke
    {
      get
      {
        return this.GetElement<RightStroke>(2);
      }
      set
      {
        this.SetElement<RightStroke>(2, value);
      }
    }

    public BottomStroke BottomStroke
    {
      get
      {
        return this.GetElement<BottomStroke>(3);
      }
      set
      {
        this.SetElement<BottomStroke>(3, value);
      }
    }

    public ColumnStroke ColumnStroke
    {
      get
      {
        return this.GetElement<ColumnStroke>(4);
      }
      set
      {
        this.SetElement<ColumnStroke>(4, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "on" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "weight" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "color" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "opacity" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "linestyle" == name)
        return (OpenXmlSimpleType) new EnumValue<StrokeLineStyleValues>();
      if ((int) namespaceId == 0 && "miterlimit" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "joinstyle" == name)
        return (OpenXmlSimpleType) new EnumValue<StrokeJoinStyleValues>();
      if ((int) namespaceId == 0 && "endcap" == name)
        return (OpenXmlSimpleType) new EnumValue<StrokeEndCapValues>();
      if ((int) namespaceId == 0 && "dashstyle" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "filltype" == name)
        return (OpenXmlSimpleType) new EnumValue<StrokeFillTypeValues>();
      if ((int) namespaceId == 0 && "src" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "imageaspect" == name)
        return (OpenXmlSimpleType) new EnumValue<ImageAspectValues>();
      if ((int) namespaceId == 0 && "imagesize" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "imagealignshape" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "color2" == name)
        return (OpenXmlSimpleType) new StringValue();
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
      if (19 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "insetpen" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Stroke>(deep);
    }
  }
}

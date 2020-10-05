// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Vml.Fill
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Vml.Office;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Vml
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (FillExtendedProperties))]
  public class Fill : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[26]
    {
      "id",
      "type",
      "on",
      "color",
      "opacity",
      "color2",
      "src",
      "href",
      "althref",
      "size",
      "origin",
      "position",
      "aspect",
      "colors",
      "angle",
      "alignshape",
      "focus",
      "focussize",
      "focusposition",
      "method",
      "detectmouseclick",
      "title",
      "opacity2",
      "recolor",
      "rotate",
      "id"
    };
    private static byte[] attributeNamespaceIds = new byte[26]
    {
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 27,
      (byte) 27,
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
      (byte) 0,
      (byte) 0,
      (byte) 19
    };
    private static readonly string[] eleTagNames = new string[1]
    {
      "fill"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 27
    };
    private const string tagName = "fill";
    private const byte tagNsId = 26;
    internal const int ElementTypeIdConst = 12580;

    public override string LocalName
    {
      get
      {
        return "fill";
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
        return 12580;
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
        return Fill.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Fill.attributeNamespaceIds;
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

    [SchemaAttr(0, "type")]
    public EnumValue<FillTypeValues> Type
    {
      get
      {
        return (EnumValue<FillTypeValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "on")]
    public TrueFalseValue On
    {
      get
      {
        return (TrueFalseValue) this.Attributes[2];
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

    [SchemaAttr(0, "color2")]
    public StringValue Color2
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

    [SchemaAttr(0, "src")]
    public StringValue Source
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

    [SchemaAttr(27, "href")]
    public StringValue Href
    {
      get
      {
        return (StringValue) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "althref")]
    public StringValue AlternateImageReference
    {
      get
      {
        return (StringValue) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "size")]
    public StringValue Size
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

    [SchemaAttr(0, "origin")]
    public StringValue Origin
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

    [SchemaAttr(0, "position")]
    public StringValue Position
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

    [SchemaAttr(0, "aspect")]
    public EnumValue<ImageAspectValues> Aspect
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

    [SchemaAttr(0, "colors")]
    public StringValue Colors
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

    [SchemaAttr(0, "angle")]
    public DecimalValue Angle
    {
      get
      {
        return (DecimalValue) this.Attributes[14];
      }
      set
      {
        this.Attributes[14] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "alignshape")]
    public TrueFalseValue AlignShape
    {
      get
      {
        return (TrueFalseValue) this.Attributes[15];
      }
      set
      {
        this.Attributes[15] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "focus")]
    public StringValue Focus
    {
      get
      {
        return (StringValue) this.Attributes[16];
      }
      set
      {
        this.Attributes[16] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "focussize")]
    public StringValue FocusSize
    {
      get
      {
        return (StringValue) this.Attributes[17];
      }
      set
      {
        this.Attributes[17] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "focusposition")]
    public StringValue FocusPosition
    {
      get
      {
        return (StringValue) this.Attributes[18];
      }
      set
      {
        this.Attributes[18] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "method")]
    public EnumValue<FillMethodValues> Method
    {
      get
      {
        return (EnumValue<FillMethodValues>) this.Attributes[19];
      }
      set
      {
        this.Attributes[19] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "detectmouseclick")]
    public TrueFalseValue DetectMouseClick
    {
      get
      {
        return (TrueFalseValue) this.Attributes[20];
      }
      set
      {
        this.Attributes[20] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "title")]
    public StringValue Title
    {
      get
      {
        return (StringValue) this.Attributes[21];
      }
      set
      {
        this.Attributes[21] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(27, "opacity2")]
    public StringValue Opacity2
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

    [SchemaAttr(0, "recolor")]
    public TrueFalseValue Recolor
    {
      get
      {
        return (TrueFalseValue) this.Attributes[23];
      }
      set
      {
        this.Attributes[23] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "rotate")]
    public TrueFalseValue Rotate
    {
      get
      {
        return (TrueFalseValue) this.Attributes[24];
      }
      set
      {
        this.Attributes[24] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(19, "id")]
    public StringValue RelationshipId
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

    public Fill()
    {
    }

    public Fill(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Fill(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Fill(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (27 == (int) namespaceId && "fill" == name)
        return (OpenXmlElement) new FillExtendedProperties();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Fill.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Fill.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public FillExtendedProperties FillExtendedProperties
    {
      get
      {
        return this.GetElement<FillExtendedProperties>(0);
      }
      set
      {
        this.SetElement<FillExtendedProperties>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "type" == name)
        return (OpenXmlSimpleType) new EnumValue<FillTypeValues>();
      if ((int) namespaceId == 0 && "on" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "color" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "opacity" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "color2" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "src" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (27 == (int) namespaceId && "href" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (27 == (int) namespaceId && "althref" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "size" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "origin" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "position" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "aspect" == name)
        return (OpenXmlSimpleType) new EnumValue<ImageAspectValues>();
      if ((int) namespaceId == 0 && "colors" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "angle" == name)
        return (OpenXmlSimpleType) new DecimalValue();
      if ((int) namespaceId == 0 && "alignshape" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "focus" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "focussize" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "focusposition" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "method" == name)
        return (OpenXmlSimpleType) new EnumValue<FillMethodValues>();
      if (27 == (int) namespaceId && "detectmouseclick" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if (27 == (int) namespaceId && "title" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (27 == (int) namespaceId && "opacity2" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "recolor" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if ((int) namespaceId == 0 && "rotate" == name)
        return (OpenXmlSimpleType) new TrueFalseValue();
      if (19 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Fill>(deep);
    }
  }
}

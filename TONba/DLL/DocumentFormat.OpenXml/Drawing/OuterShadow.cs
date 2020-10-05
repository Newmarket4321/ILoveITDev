// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.OuterShadow
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (RgbColorModelPercentage))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (RgbColorModelHex))]
  [ChildElementInfo(typeof (HslColor))]
  [ChildElementInfo(typeof (SystemColor))]
  [ChildElementInfo(typeof (SchemeColor))]
  [ChildElementInfo(typeof (PresetColor))]
  public class OuterShadow : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[9]
    {
      "blurRad",
      "dist",
      "dir",
      "sx",
      "sy",
      "kx",
      "ky",
      "algn",
      "rotWithShape"
    };
    private static byte[] attributeNamespaceIds = new byte[9];
    private static readonly string[] eleTagNames = new string[6]
    {
      "scrgbClr",
      "srgbClr",
      "hslClr",
      "sysClr",
      "schemeClr",
      "prstClr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[6]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "outerShdw";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10076;

    public override string LocalName
    {
      get
      {
        return "outerShdw";
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
        return 10076;
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
        return OuterShadow.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return OuterShadow.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "blurRad")]
    public Int64Value BlurRadius
    {
      get
      {
        return (Int64Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "dist")]
    public Int64Value Distance
    {
      get
      {
        return (Int64Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "dir")]
    public Int32Value Direction
    {
      get
      {
        return (Int32Value) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "sx")]
    public Int32Value HorizontalRatio
    {
      get
      {
        return (Int32Value) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "sy")]
    public Int32Value VerticalRatio
    {
      get
      {
        return (Int32Value) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "kx")]
    public Int32Value HorizontalSkew
    {
      get
      {
        return (Int32Value) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "ky")]
    public Int32Value VerticalSkew
    {
      get
      {
        return (Int32Value) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "algn")]
    public EnumValue<RectangleAlignmentValues> Alignment
    {
      get
      {
        return (EnumValue<RectangleAlignmentValues>) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "rotWithShape")]
    public BooleanValue RotateWithShape
    {
      get
      {
        return (BooleanValue) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    public OuterShadow()
    {
    }

    public OuterShadow(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public OuterShadow(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public OuterShadow(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "scrgbClr" == name)
        return (OpenXmlElement) new RgbColorModelPercentage();
      if (10 == (int) namespaceId && "srgbClr" == name)
        return (OpenXmlElement) new RgbColorModelHex();
      if (10 == (int) namespaceId && "hslClr" == name)
        return (OpenXmlElement) new HslColor();
      if (10 == (int) namespaceId && "sysClr" == name)
        return (OpenXmlElement) new SystemColor();
      if (10 == (int) namespaceId && "schemeClr" == name)
        return (OpenXmlElement) new SchemeColor();
      if (10 == (int) namespaceId && "prstClr" == name)
        return (OpenXmlElement) new PresetColor();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return OuterShadow.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return OuterShadow.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public RgbColorModelPercentage RgbColorModelPercentage
    {
      get
      {
        return this.GetElement<RgbColorModelPercentage>(0);
      }
      set
      {
        this.SetElement<RgbColorModelPercentage>(0, value);
      }
    }

    public RgbColorModelHex RgbColorModelHex
    {
      get
      {
        return this.GetElement<RgbColorModelHex>(1);
      }
      set
      {
        this.SetElement<RgbColorModelHex>(1, value);
      }
    }

    public HslColor HslColor
    {
      get
      {
        return this.GetElement<HslColor>(2);
      }
      set
      {
        this.SetElement<HslColor>(2, value);
      }
    }

    public SystemColor SystemColor
    {
      get
      {
        return this.GetElement<SystemColor>(3);
      }
      set
      {
        this.SetElement<SystemColor>(3, value);
      }
    }

    public SchemeColor SchemeColor
    {
      get
      {
        return this.GetElement<SchemeColor>(4);
      }
      set
      {
        this.SetElement<SchemeColor>(4, value);
      }
    }

    public PresetColor PresetColor
    {
      get
      {
        return this.GetElement<PresetColor>(5);
      }
      set
      {
        this.SetElement<PresetColor>(5, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "blurRad" == name)
        return (OpenXmlSimpleType) new Int64Value();
      if ((int) namespaceId == 0 && "dist" == name)
        return (OpenXmlSimpleType) new Int64Value();
      if ((int) namespaceId == 0 && "dir" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "sx" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "sy" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "kx" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "ky" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "algn" == name)
        return (OpenXmlSimpleType) new EnumValue<RectangleAlignmentValues>();
      if ((int) namespaceId == 0 && "rotWithShape" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<OuterShadow>(deep);
    }
  }
}

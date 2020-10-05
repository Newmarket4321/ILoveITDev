// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Word.Shadow
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Word
{
  [ChildElementInfo(typeof (SchemeColor), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (RgbColorModelHex), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public class Shadow : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[8]
    {
      "blurRad",
      "dist",
      "dir",
      "sx",
      "sy",
      "kx",
      "ky",
      "algn"
    };
    private static byte[] attributeNamespaceIds = new byte[8]
    {
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52
    };
    private static readonly string[] eleTagNames = new string[2]
    {
      "srgbClr",
      "schemeClr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 52,
      (byte) 52
    };
    private const string tagName = "shadow";
    private const byte tagNsId = 52;
    internal const int ElementTypeIdConst = 12921;

    public override string LocalName
    {
      get
      {
        return "shadow";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 52;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12921;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return Shadow.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Shadow.attributeNamespaceIds;
      }
    }

    [SchemaAttr(52, "blurRad")]
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

    [SchemaAttr(52, "dist")]
    public Int64Value DistanceFromText
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

    [SchemaAttr(52, "dir")]
    public Int32Value DirectionAngle
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

    [SchemaAttr(52, "sx")]
    public Int32Value HorizontalScalingFactor
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

    [SchemaAttr(52, "sy")]
    public Int32Value VerticalScalingFactor
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

    [SchemaAttr(52, "kx")]
    public Int32Value HorizontalSkewAngle
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

    [SchemaAttr(52, "ky")]
    public Int32Value VerticalSkewAngle
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

    [SchemaAttr(52, "algn")]
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

    public Shadow()
    {
    }

    public Shadow(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Shadow(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Shadow(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (52 == (int) namespaceId && "srgbClr" == name)
        return (OpenXmlElement) new RgbColorModelHex();
      if (52 == (int) namespaceId && "schemeClr" == name)
        return (OpenXmlElement) new SchemeColor();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Shadow.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Shadow.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public RgbColorModelHex RgbColorModelHex
    {
      get
      {
        return this.GetElement<RgbColorModelHex>(0);
      }
      set
      {
        this.SetElement<RgbColorModelHex>(0, value);
      }
    }

    public SchemeColor SchemeColor
    {
      get
      {
        return this.GetElement<SchemeColor>(1);
      }
      set
      {
        this.SetElement<SchemeColor>(1, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (52 == (int) namespaceId && "blurRad" == name)
        return (OpenXmlSimpleType) new Int64Value();
      if (52 == (int) namespaceId && "dist" == name)
        return (OpenXmlSimpleType) new Int64Value();
      if (52 == (int) namespaceId && "dir" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (52 == (int) namespaceId && "sx" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (52 == (int) namespaceId && "sy" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (52 == (int) namespaceId && "kx" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (52 == (int) namespaceId && "ky" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (52 == (int) namespaceId && "algn" == name)
        return (OpenXmlSimpleType) new EnumValue<RectangleAlignmentValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Shadow>(deep);
    }
  }
}

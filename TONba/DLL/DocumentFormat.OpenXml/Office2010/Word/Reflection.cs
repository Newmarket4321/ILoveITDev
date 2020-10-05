// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Word.Reflection
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2010.Word
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [GeneratedCode("DomGen", "2.0")]
  public class Reflection : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[13]
    {
      "blurRad",
      "stA",
      "stPos",
      "endA",
      "endPos",
      "dist",
      "dir",
      "fadeDir",
      "sx",
      "sy",
      "kx",
      "ky",
      "algn"
    };
    private static byte[] attributeNamespaceIds = new byte[13]
    {
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52
    };
    private const string tagName = "reflection";
    private const byte tagNsId = 52;
    internal const int ElementTypeIdConst = 12922;

    public override string LocalName
    {
      get
      {
        return "reflection";
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
        return 12922;
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
        return Reflection.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Reflection.attributeNamespaceIds;
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

    [SchemaAttr(52, "stA")]
    public Int32Value StartingOpacity
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

    [SchemaAttr(52, "stPos")]
    public Int32Value StartPosition
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

    [SchemaAttr(52, "endA")]
    public Int32Value EndingOpacity
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

    [SchemaAttr(52, "endPos")]
    public Int32Value EndPosition
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

    [SchemaAttr(52, "dist")]
    public Int64Value DistanceFromText
    {
      get
      {
        return (Int64Value) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(52, "dir")]
    public Int32Value DirectionAngle
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

    [SchemaAttr(52, "fadeDir")]
    public Int32Value FadeDirection
    {
      get
      {
        return (Int32Value) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(52, "sx")]
    public Int32Value HorizontalScalingFactor
    {
      get
      {
        return (Int32Value) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(52, "sy")]
    public Int32Value VerticalScalingFactor
    {
      get
      {
        return (Int32Value) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(52, "kx")]
    public Int32Value HorizontalSkewAngle
    {
      get
      {
        return (Int32Value) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(52, "ky")]
    public Int32Value VerticalSkewAngle
    {
      get
      {
        return (Int32Value) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(52, "algn")]
    public EnumValue<RectangleAlignmentValues> Alignment
    {
      get
      {
        return (EnumValue<RectangleAlignmentValues>) this.Attributes[12];
      }
      set
      {
        this.Attributes[12] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (52 == (int) namespaceId && "blurRad" == name)
        return (OpenXmlSimpleType) new Int64Value();
      if (52 == (int) namespaceId && "stA" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (52 == (int) namespaceId && "stPos" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (52 == (int) namespaceId && "endA" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (52 == (int) namespaceId && "endPos" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (52 == (int) namespaceId && "dist" == name)
        return (OpenXmlSimpleType) new Int64Value();
      if (52 == (int) namespaceId && "dir" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (52 == (int) namespaceId && "fadeDir" == name)
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
      return (OpenXmlElement) this.CloneImp<Reflection>(deep);
    }
  }
}

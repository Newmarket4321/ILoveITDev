// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Reflection
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  public class Reflection : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[14]
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
      "algn",
      "rotWithShape"
    };
    private static byte[] attributeNamespaceIds = new byte[14];
    private const string tagName = "reflection";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10078;

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
        return 10;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10078;
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

    [SchemaAttr(0, "stA")]
    public Int32Value StartOpacity
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

    [SchemaAttr(0, "stPos")]
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

    [SchemaAttr(0, "endA")]
    public Int32Value EndAlpha
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

    [SchemaAttr(0, "endPos")]
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

    [SchemaAttr(0, "dist")]
    public Int64Value Distance
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

    [SchemaAttr(0, "dir")]
    public Int32Value Direction
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

    [SchemaAttr(0, "fadeDir")]
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

    [SchemaAttr(0, "sx")]
    public Int32Value HorizontalRatio
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

    [SchemaAttr(0, "sy")]
    public Int32Value VerticalRatio
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

    [SchemaAttr(0, "kx")]
    public Int32Value HorizontalSkew
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

    [SchemaAttr(0, "ky")]
    public Int32Value VerticalSkew
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

    [SchemaAttr(0, "algn")]
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

    [SchemaAttr(0, "rotWithShape")]
    public BooleanValue RotateWithShape
    {
      get
      {
        return (BooleanValue) this.Attributes[13];
      }
      set
      {
        this.Attributes[13] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "blurRad" == name)
        return (OpenXmlSimpleType) new Int64Value();
      if ((int) namespaceId == 0 && "stA" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "stPos" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "endA" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "endPos" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "dist" == name)
        return (OpenXmlSimpleType) new Int64Value();
      if ((int) namespaceId == 0 && "dir" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "fadeDir" == name)
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
      return (OpenXmlElement) this.CloneImp<Reflection>(deep);
    }
  }
}

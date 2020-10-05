// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Tile
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  public class Tile : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[6]
    {
      "tx",
      "ty",
      "sx",
      "sy",
      "flip",
      "algn"
    };
    private static byte[] attributeNamespaceIds = new byte[6];
    private const string tagName = "tile";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10045;

    public override string LocalName
    {
      get
      {
        return "tile";
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
        return 10045;
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
        return Tile.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Tile.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "tx")]
    public Int64Value HorizontalOffset
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

    [SchemaAttr(0, "ty")]
    public Int64Value VerticalOffset
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

    [SchemaAttr(0, "sx")]
    public Int32Value HorizontalRatio
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

    [SchemaAttr(0, "sy")]
    public Int32Value VerticalRatio
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

    [SchemaAttr(0, "flip")]
    public EnumValue<TileFlipValues> Flip
    {
      get
      {
        return (EnumValue<TileFlipValues>) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "algn")]
    public EnumValue<RectangleAlignmentValues> Alignment
    {
      get
      {
        return (EnumValue<RectangleAlignmentValues>) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "tx" == name)
        return (OpenXmlSimpleType) new Int64Value();
      if ((int) namespaceId == 0 && "ty" == name)
        return (OpenXmlSimpleType) new Int64Value();
      if ((int) namespaceId == 0 && "sx" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "sy" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "flip" == name)
        return (OpenXmlSimpleType) new EnumValue<TileFlipValues>();
      if ((int) namespaceId == 0 && "algn" == name)
        return (OpenXmlSimpleType) new EnumValue<RectangleAlignmentValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Tile>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.ColorType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  public abstract class ColorType : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[5]
    {
      "auto",
      "indexed",
      "rgb",
      "theme",
      "tint"
    };
    private static byte[] attributeNamespaceIds = new byte[5];

    internal override string[] AttributeTagNames
    {
      get
      {
        return ColorType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ColorType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "auto")]
    public BooleanValue Auto
    {
      get
      {
        return (BooleanValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "indexed")]
    public UInt32Value Indexed
    {
      get
      {
        return (UInt32Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "rgb")]
    public HexBinaryValue Rgb
    {
      get
      {
        return (HexBinaryValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "theme")]
    public UInt32Value Theme
    {
      get
      {
        return (UInt32Value) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "tint")]
    public DoubleValue Tint
    {
      get
      {
        return (DoubleValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "auto" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "indexed" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "rgb" == name)
        return (OpenXmlSimpleType) new HexBinaryValue();
      if ((int) namespaceId == 0 && "theme" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "tint" == name)
        return (OpenXmlSimpleType) new DoubleValue();
      return base.AttributeFactory(namespaceId, name);
    }
  }
}

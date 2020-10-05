// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Vml.ShapeHandle
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Vml
{
  [GeneratedCode("DomGen", "2.0")]
  public class ShapeHandle : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[9]
    {
      "position",
      "polar",
      "map",
      "invx",
      "invy",
      "switch",
      "xrange",
      "yrange",
      "radiusrange"
    };
    private static byte[] attributeNamespaceIds = new byte[9];
    private const string tagName = "h";
    private const byte tagNsId = 26;
    internal const int ElementTypeIdConst = 12598;

    public override string LocalName
    {
      get
      {
        return "h";
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
        return 12598;
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
        return ShapeHandle.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ShapeHandle.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "position")]
    public StringValue Position
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

    [SchemaAttr(0, "polar")]
    public StringValue Polar
    {
      get
      {
        return (StringValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "map")]
    public StringValue Map
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

    [SchemaAttr(0, "invx")]
    public TrueFalseBlankValue InvertX
    {
      get
      {
        return (TrueFalseBlankValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "invy")]
    public TrueFalseBlankValue InvertY
    {
      get
      {
        return (TrueFalseBlankValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "switch")]
    public TrueFalseBlankValue Switch
    {
      get
      {
        return (TrueFalseBlankValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "xrange")]
    public StringValue XRange
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

    [SchemaAttr(0, "yrange")]
    public StringValue YRange
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

    [SchemaAttr(0, "radiusrange")]
    public StringValue RadiusRange
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

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "position" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "polar" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "map" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "invx" == name)
        return (OpenXmlSimpleType) new TrueFalseBlankValue();
      if ((int) namespaceId == 0 && "invy" == name)
        return (OpenXmlSimpleType) new TrueFalseBlankValue();
      if ((int) namespaceId == 0 && "switch" == name)
        return (OpenXmlSimpleType) new TrueFalseBlankValue();
      if ((int) namespaceId == 0 && "xrange" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "yrange" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "radiusrange" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ShapeHandle>(deep);
    }
  }
}

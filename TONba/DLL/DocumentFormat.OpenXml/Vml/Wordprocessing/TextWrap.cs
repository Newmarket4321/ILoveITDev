// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Vml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public class TextWrap : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "type",
      "side",
      "anchorx",
      "anchory"
    };
    private static byte[] attributeNamespaceIds = new byte[4];
    private const string tagName = "wrap";
    private const byte tagNsId = 28;
    internal const int ElementTypeIdConst = 12505;

    public override string LocalName
    {
      get
      {
        return "wrap";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 28;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12505;
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
        return TextWrap.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TextWrap.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "type")]
    public EnumValue<WrapValues> Type
    {
      get
      {
        return (EnumValue<WrapValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "side")]
    public EnumValue<WrapSideValues> Side
    {
      get
      {
        return (EnumValue<WrapSideValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "anchorx")]
    public EnumValue<HorizontalAnchorValues> AnchorX
    {
      get
      {
        return (EnumValue<HorizontalAnchorValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "anchory")]
    public EnumValue<VerticalAnchorValues> AnchorY
    {
      get
      {
        return (EnumValue<VerticalAnchorValues>) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "type" == name)
        return (OpenXmlSimpleType) new EnumValue<WrapValues>();
      if ((int) namespaceId == 0 && "side" == name)
        return (OpenXmlSimpleType) new EnumValue<WrapSideValues>();
      if ((int) namespaceId == 0 && "anchorx" == name)
        return (OpenXmlSimpleType) new EnumValue<HorizontalAnchorValues>();
      if ((int) namespaceId == 0 && "anchory" == name)
        return (OpenXmlSimpleType) new EnumValue<VerticalAnchorValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TextWrap>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.Font
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Presentation
{
  [GeneratedCode("DomGen", "2.0")]
  public class Font : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "typeface",
      "panose",
      "pitchFamily",
      "charset"
    };
    private static byte[] attributeNamespaceIds = new byte[4];
    private const string tagName = "font";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12315;

    public override string LocalName
    {
      get
      {
        return "font";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 24;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12315;
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
        return Font.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Font.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "typeface")]
    public StringValue Typeface
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

    [SchemaAttr(0, "panose")]
    public HexBinaryValue Panose
    {
      get
      {
        return (HexBinaryValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "pitchFamily")]
    public SByteValue PitchFamily
    {
      get
      {
        return (SByteValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "charset")]
    public SByteValue CharacterSet
    {
      get
      {
        return (SByteValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "typeface" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "panose" == name)
        return (OpenXmlSimpleType) new HexBinaryValue();
      if ((int) namespaceId == 0 && "pitchFamily" == name)
        return (OpenXmlSimpleType) new SByteValue();
      if ((int) namespaceId == 0 && "charset" == name)
        return (OpenXmlSimpleType) new SByteValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Font>(deep);
    }
  }
}

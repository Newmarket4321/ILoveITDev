// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.LegacyNumbering
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public class LegacyNumbering : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "legacy",
      "legacySpace",
      "legacyIndent"
    };
    private static byte[] attributeNamespaceIds = new byte[3]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "legacy";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11918;

    public override string LocalName
    {
      get
      {
        return "legacy";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11918;
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
        return LegacyNumbering.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return LegacyNumbering.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "legacy")]
    public OnOffValue Legacy
    {
      get
      {
        return (OnOffValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "legacySpace")]
    public StringValue LegacySpace
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

    [SchemaAttr(23, "legacyIndent")]
    public StringValue LegacyIndent
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

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "legacy" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "legacySpace" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "legacyIndent" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<LegacyNumbering>(deep);
    }
  }
}

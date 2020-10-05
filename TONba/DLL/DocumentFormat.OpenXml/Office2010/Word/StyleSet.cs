// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Word.StyleSet
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2010.Word
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [GeneratedCode("DomGen", "2.0")]
  public class StyleSet : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "id",
      "val"
    };
    private static byte[] attributeNamespaceIds = new byte[2]
    {
      (byte) 52,
      (byte) 52
    };
    private const string tagName = "styleSet";
    private const byte tagNsId = 52;
    internal const int ElementTypeIdConst = 12953;

    public override string LocalName
    {
      get
      {
        return "styleSet";
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
        return 12953;
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
        return StyleSet.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return StyleSet.attributeNamespaceIds;
      }
    }

    [SchemaAttr(52, "id")]
    public UInt32Value Id
    {
      get
      {
        return (UInt32Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(52, "val")]
    public EnumValue<OnOffValues> Val
    {
      get
      {
        return (EnumValue<OnOffValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (52 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if (52 == (int) namespaceId && "val" == name)
        return (OpenXmlSimpleType) new EnumValue<OnOffValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<StyleSet>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.Word.Mcd
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office.Word
{
  [GeneratedCode("DomGen", "2.0")]
  public class Mcd : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[5]
    {
      "macroName",
      "name",
      "menuHelp",
      "bEncrypt",
      "cmg"
    };
    private static byte[] attributeNamespaceIds = new byte[5]
    {
      (byte) 33,
      (byte) 33,
      (byte) 33,
      (byte) 33,
      (byte) 33
    };
    private const string tagName = "mcd";
    private const byte tagNsId = 33;
    internal const int ElementTypeIdConst = 12619;

    public override string LocalName
    {
      get
      {
        return "mcd";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 33;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12619;
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
        return Mcd.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Mcd.attributeNamespaceIds;
      }
    }

    [SchemaAttr(33, "macroName")]
    public StringValue MacroName
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

    [SchemaAttr(33, "name")]
    public StringValue Name
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

    [SchemaAttr(33, "menuHelp")]
    public StringValue MenuHelp
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

    [SchemaAttr(33, "bEncrypt")]
    public HexBinaryValue BEncrypt
    {
      get
      {
        return (HexBinaryValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(33, "cmg")]
    public HexBinaryValue Cmg
    {
      get
      {
        return (HexBinaryValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (33 == (int) namespaceId && "macroName" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (33 == (int) namespaceId && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      if (33 == (int) namespaceId && "menuHelp" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (33 == (int) namespaceId && "bEncrypt" == name)
        return (OpenXmlSimpleType) new HexBinaryValue();
      if (33 == (int) namespaceId && "cmg" == name)
        return (OpenXmlSimpleType) new HexBinaryValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Mcd>(deep);
    }
  }
}

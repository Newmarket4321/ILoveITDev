// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.RunFonts
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public class RunFonts : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[9]
    {
      "hint",
      "ascii",
      "hAnsi",
      "eastAsia",
      "cs",
      "asciiTheme",
      "hAnsiTheme",
      "eastAsiaTheme",
      "cstheme"
    };
    private static byte[] attributeNamespaceIds = new byte[9]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "rFonts";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11623;

    public override string LocalName
    {
      get
      {
        return "rFonts";
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
        return 11623;
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
        return RunFonts.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return RunFonts.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "hint")]
    public EnumValue<FontTypeHintValues> Hint
    {
      get
      {
        return (EnumValue<FontTypeHintValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "ascii")]
    public StringValue Ascii
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

    [SchemaAttr(23, "hAnsi")]
    public StringValue HighAnsi
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

    [SchemaAttr(23, "eastAsia")]
    public StringValue EastAsia
    {
      get
      {
        return (StringValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "cs")]
    public StringValue ComplexScript
    {
      get
      {
        return (StringValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "asciiTheme")]
    public EnumValue<ThemeFontValues> AsciiTheme
    {
      get
      {
        return (EnumValue<ThemeFontValues>) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "hAnsiTheme")]
    public EnumValue<ThemeFontValues> HighAnsiTheme
    {
      get
      {
        return (EnumValue<ThemeFontValues>) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "eastAsiaTheme")]
    public EnumValue<ThemeFontValues> EastAsiaTheme
    {
      get
      {
        return (EnumValue<ThemeFontValues>) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "cstheme")]
    public EnumValue<ThemeFontValues> ComplexScriptTheme
    {
      get
      {
        return (EnumValue<ThemeFontValues>) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "hint" == name)
        return (OpenXmlSimpleType) new EnumValue<FontTypeHintValues>();
      if (23 == (int) namespaceId && "ascii" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "hAnsi" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "eastAsia" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "cs" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "asciiTheme" == name)
        return (OpenXmlSimpleType) new EnumValue<ThemeFontValues>();
      if (23 == (int) namespaceId && "hAnsiTheme" == name)
        return (OpenXmlSimpleType) new EnumValue<ThemeFontValues>();
      if (23 == (int) namespaceId && "eastAsiaTheme" == name)
        return (OpenXmlSimpleType) new EnumValue<ThemeFontValues>();
      if (23 == (int) namespaceId && "cstheme" == name)
        return (OpenXmlSimpleType) new EnumValue<ThemeFontValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<RunFonts>(deep);
    }
  }
}

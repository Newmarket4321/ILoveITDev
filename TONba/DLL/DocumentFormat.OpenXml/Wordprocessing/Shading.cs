// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.Shading
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public class Shading : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[9]
    {
      "val",
      "color",
      "themeColor",
      "themeTint",
      "themeShade",
      "fill",
      "themeFill",
      "themeFillTint",
      "themeFillShade"
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
    private const string tagName = "shd";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11565;

    public override string LocalName
    {
      get
      {
        return "shd";
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
        return 11565;
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
        return Shading.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Shading.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "val")]
    public EnumValue<ShadingPatternValues> Val
    {
      get
      {
        return (EnumValue<ShadingPatternValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "color")]
    public StringValue Color
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

    [SchemaAttr(23, "themeColor")]
    public EnumValue<ThemeColorValues> ThemeColor
    {
      get
      {
        return (EnumValue<ThemeColorValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "themeTint")]
    public StringValue ThemeTint
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

    [SchemaAttr(23, "themeShade")]
    public StringValue ThemeShade
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

    [SchemaAttr(23, "fill")]
    public StringValue Fill
    {
      get
      {
        return (StringValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "themeFill")]
    public EnumValue<ThemeColorValues> ThemeFill
    {
      get
      {
        return (EnumValue<ThemeColorValues>) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "themeFillTint")]
    public StringValue ThemeFillTint
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

    [SchemaAttr(23, "themeFillShade")]
    public StringValue ThemeFillShade
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
      if (23 == (int) namespaceId && "val" == name)
        return (OpenXmlSimpleType) new EnumValue<ShadingPatternValues>();
      if (23 == (int) namespaceId && "color" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "themeColor" == name)
        return (OpenXmlSimpleType) new EnumValue<ThemeColorValues>();
      if (23 == (int) namespaceId && "themeTint" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "themeShade" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "fill" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "themeFill" == name)
        return (OpenXmlSimpleType) new EnumValue<ThemeColorValues>();
      if (23 == (int) namespaceId && "themeFillTint" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "themeFillShade" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Shading>(deep);
    }
  }
}

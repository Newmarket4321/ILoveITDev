// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.BorderType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public abstract class BorderType : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[9]
    {
      "val",
      "color",
      "themeColor",
      "themeTint",
      "themeShade",
      "sz",
      "space",
      "shadow",
      "frame"
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

    internal override string[] AttributeTagNames
    {
      get
      {
        return BorderType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return BorderType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "val")]
    public EnumValue<BorderValues> Val
    {
      get
      {
        return (EnumValue<BorderValues>) this.Attributes[0];
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

    [SchemaAttr(23, "sz")]
    public UInt32Value Size
    {
      get
      {
        return (UInt32Value) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "space")]
    public UInt32Value Space
    {
      get
      {
        return (UInt32Value) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "shadow")]
    public OnOffValue Shadow
    {
      get
      {
        return (OnOffValue) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "frame")]
    public OnOffValue Frame
    {
      get
      {
        return (OnOffValue) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "val" == name)
        return (OpenXmlSimpleType) new EnumValue<BorderValues>();
      if (23 == (int) namespaceId && "color" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "themeColor" == name)
        return (OpenXmlSimpleType) new EnumValue<ThemeColorValues>();
      if (23 == (int) namespaceId && "themeTint" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "themeShade" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "sz" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if (23 == (int) namespaceId && "space" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if (23 == (int) namespaceId && "shadow" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "frame" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      return base.AttributeFactory(namespaceId, name);
    }
  }
}

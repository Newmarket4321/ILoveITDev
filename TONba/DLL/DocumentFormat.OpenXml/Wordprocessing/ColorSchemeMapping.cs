// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public class ColorSchemeMapping : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[12]
    {
      "bg1",
      "t1",
      "bg2",
      "t2",
      "accent1",
      "accent2",
      "accent3",
      "accent4",
      "accent5",
      "accent6",
      "hyperlink",
      "followedHyperlink"
    };
    private static byte[] attributeNamespaceIds = new byte[12]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
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
    private const string tagName = "clrSchemeMapping";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 12189;

    public override string LocalName
    {
      get
      {
        return "clrSchemeMapping";
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
        return 12189;
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
        return ColorSchemeMapping.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ColorSchemeMapping.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "bg1")]
    public EnumValue<ColorSchemeIndexValues> Background1
    {
      get
      {
        return (EnumValue<ColorSchemeIndexValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "t1")]
    public EnumValue<ColorSchemeIndexValues> Text1
    {
      get
      {
        return (EnumValue<ColorSchemeIndexValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "bg2")]
    public EnumValue<ColorSchemeIndexValues> Background2
    {
      get
      {
        return (EnumValue<ColorSchemeIndexValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "t2")]
    public EnumValue<ColorSchemeIndexValues> Text2
    {
      get
      {
        return (EnumValue<ColorSchemeIndexValues>) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "accent1")]
    public EnumValue<ColorSchemeIndexValues> Accent1
    {
      get
      {
        return (EnumValue<ColorSchemeIndexValues>) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "accent2")]
    public EnumValue<ColorSchemeIndexValues> Accent2
    {
      get
      {
        return (EnumValue<ColorSchemeIndexValues>) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "accent3")]
    public EnumValue<ColorSchemeIndexValues> Accent3
    {
      get
      {
        return (EnumValue<ColorSchemeIndexValues>) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "accent4")]
    public EnumValue<ColorSchemeIndexValues> Accent4
    {
      get
      {
        return (EnumValue<ColorSchemeIndexValues>) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "accent5")]
    public EnumValue<ColorSchemeIndexValues> Accent5
    {
      get
      {
        return (EnumValue<ColorSchemeIndexValues>) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "accent6")]
    public EnumValue<ColorSchemeIndexValues> Accent6
    {
      get
      {
        return (EnumValue<ColorSchemeIndexValues>) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "hyperlink")]
    public EnumValue<ColorSchemeIndexValues> Hyperlink
    {
      get
      {
        return (EnumValue<ColorSchemeIndexValues>) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "followedHyperlink")]
    public EnumValue<ColorSchemeIndexValues> FollowedHyperlink
    {
      get
      {
        return (EnumValue<ColorSchemeIndexValues>) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "bg1" == name)
        return (OpenXmlSimpleType) new EnumValue<ColorSchemeIndexValues>();
      if (23 == (int) namespaceId && "t1" == name)
        return (OpenXmlSimpleType) new EnumValue<ColorSchemeIndexValues>();
      if (23 == (int) namespaceId && "bg2" == name)
        return (OpenXmlSimpleType) new EnumValue<ColorSchemeIndexValues>();
      if (23 == (int) namespaceId && "t2" == name)
        return (OpenXmlSimpleType) new EnumValue<ColorSchemeIndexValues>();
      if (23 == (int) namespaceId && "accent1" == name)
        return (OpenXmlSimpleType) new EnumValue<ColorSchemeIndexValues>();
      if (23 == (int) namespaceId && "accent2" == name)
        return (OpenXmlSimpleType) new EnumValue<ColorSchemeIndexValues>();
      if (23 == (int) namespaceId && "accent3" == name)
        return (OpenXmlSimpleType) new EnumValue<ColorSchemeIndexValues>();
      if (23 == (int) namespaceId && "accent4" == name)
        return (OpenXmlSimpleType) new EnumValue<ColorSchemeIndexValues>();
      if (23 == (int) namespaceId && "accent5" == name)
        return (OpenXmlSimpleType) new EnumValue<ColorSchemeIndexValues>();
      if (23 == (int) namespaceId && "accent6" == name)
        return (OpenXmlSimpleType) new EnumValue<ColorSchemeIndexValues>();
      if (23 == (int) namespaceId && "hyperlink" == name)
        return (OpenXmlSimpleType) new EnumValue<ColorSchemeIndexValues>();
      if (23 == (int) namespaceId && "followedHyperlink" == name)
        return (OpenXmlSimpleType) new EnumValue<ColorSchemeIndexValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ColorSchemeMapping>(deep);
    }
  }
}

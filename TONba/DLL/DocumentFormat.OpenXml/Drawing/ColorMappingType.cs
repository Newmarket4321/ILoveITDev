// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.ColorMappingType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  public abstract class ColorMappingType : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[12]
    {
      "bg1",
      "tx1",
      "bg2",
      "tx2",
      "accent1",
      "accent2",
      "accent3",
      "accent4",
      "accent5",
      "accent6",
      "hlink",
      "folHlink"
    };
    private static byte[] attributeNamespaceIds = new byte[12];
    private static readonly string[] eleTagNames = new string[1]
    {
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 10
    };

    internal override string[] AttributeTagNames
    {
      get
      {
        return ColorMappingType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ColorMappingType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "bg1")]
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

    [SchemaAttr(0, "tx1")]
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

    [SchemaAttr(0, "bg2")]
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

    [SchemaAttr(0, "tx2")]
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

    [SchemaAttr(0, "accent1")]
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

    [SchemaAttr(0, "accent2")]
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

    [SchemaAttr(0, "accent3")]
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

    [SchemaAttr(0, "accent4")]
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

    [SchemaAttr(0, "accent5")]
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

    [SchemaAttr(0, "accent6")]
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

    [SchemaAttr(0, "hlink")]
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

    [SchemaAttr(0, "folHlink")]
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

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ColorMappingType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ColorMappingType.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(0);
      }
      set
      {
        this.SetElement<ExtensionList>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "bg1" == name)
        return (OpenXmlSimpleType) new EnumValue<ColorSchemeIndexValues>();
      if ((int) namespaceId == 0 && "tx1" == name)
        return (OpenXmlSimpleType) new EnumValue<ColorSchemeIndexValues>();
      if ((int) namespaceId == 0 && "bg2" == name)
        return (OpenXmlSimpleType) new EnumValue<ColorSchemeIndexValues>();
      if ((int) namespaceId == 0 && "tx2" == name)
        return (OpenXmlSimpleType) new EnumValue<ColorSchemeIndexValues>();
      if ((int) namespaceId == 0 && "accent1" == name)
        return (OpenXmlSimpleType) new EnumValue<ColorSchemeIndexValues>();
      if ((int) namespaceId == 0 && "accent2" == name)
        return (OpenXmlSimpleType) new EnumValue<ColorSchemeIndexValues>();
      if ((int) namespaceId == 0 && "accent3" == name)
        return (OpenXmlSimpleType) new EnumValue<ColorSchemeIndexValues>();
      if ((int) namespaceId == 0 && "accent4" == name)
        return (OpenXmlSimpleType) new EnumValue<ColorSchemeIndexValues>();
      if ((int) namespaceId == 0 && "accent5" == name)
        return (OpenXmlSimpleType) new EnumValue<ColorSchemeIndexValues>();
      if ((int) namespaceId == 0 && "accent6" == name)
        return (OpenXmlSimpleType) new EnumValue<ColorSchemeIndexValues>();
      if ((int) namespaceId == 0 && "hlink" == name)
        return (OpenXmlSimpleType) new EnumValue<ColorSchemeIndexValues>();
      if ((int) namespaceId == 0 && "folHlink" == name)
        return (OpenXmlSimpleType) new EnumValue<ColorSchemeIndexValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    protected ColorMappingType()
    {
    }

    protected ColorMappingType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected ColorMappingType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected ColorMappingType(string outerXml)
      : base(outerXml)
    {
    }
  }
}

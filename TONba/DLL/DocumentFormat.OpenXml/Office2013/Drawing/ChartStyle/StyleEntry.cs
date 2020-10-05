// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleEntry
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle
{
  [ChildElementInfo(typeof (ShapeProperties), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (OfficeArtExtensionList), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (TextBodyProperties), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (LineReference), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (LineWidthScale), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (FillReference), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (EffectReference), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (FontReference), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (TextCharacterPropertiesType), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public abstract class StyleEntry : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "mods"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[9]
    {
      "lnRef",
      "lineWidthScale",
      "fillRef",
      "effectRef",
      "fontRef",
      "spPr",
      "defRPr",
      "bodyPr",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[9]
    {
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65,
      (byte) 65
    };

    internal override string[] AttributeTagNames
    {
      get
      {
        return StyleEntry.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return StyleEntry.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "mods")]
    public ListValue<StringValue> Modifiers
    {
      get
      {
        return (ListValue<StringValue>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (65 == (int) namespaceId && "lnRef" == name)
        return (OpenXmlElement) new LineReference();
      if (65 == (int) namespaceId && "lineWidthScale" == name)
        return (OpenXmlElement) new LineWidthScale();
      if (65 == (int) namespaceId && "fillRef" == name)
        return (OpenXmlElement) new FillReference();
      if (65 == (int) namespaceId && "effectRef" == name)
        return (OpenXmlElement) new EffectReference();
      if (65 == (int) namespaceId && "fontRef" == name)
        return (OpenXmlElement) new FontReference();
      if (65 == (int) namespaceId && "spPr" == name)
        return (OpenXmlElement) new ShapeProperties();
      if (65 == (int) namespaceId && "defRPr" == name)
        return (OpenXmlElement) new TextCharacterPropertiesType();
      if (65 == (int) namespaceId && "bodyPr" == name)
        return (OpenXmlElement) new TextBodyProperties();
      if (65 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new OfficeArtExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return StyleEntry.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return StyleEntry.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public LineReference LineReference
    {
      get
      {
        return this.GetElement<LineReference>(0);
      }
      set
      {
        this.SetElement<LineReference>(0, value);
      }
    }

    public LineWidthScale LineWidthScale
    {
      get
      {
        return this.GetElement<LineWidthScale>(1);
      }
      set
      {
        this.SetElement<LineWidthScale>(1, value);
      }
    }

    public FillReference FillReference
    {
      get
      {
        return this.GetElement<FillReference>(2);
      }
      set
      {
        this.SetElement<FillReference>(2, value);
      }
    }

    public EffectReference EffectReference
    {
      get
      {
        return this.GetElement<EffectReference>(3);
      }
      set
      {
        this.SetElement<EffectReference>(3, value);
      }
    }

    public FontReference FontReference
    {
      get
      {
        return this.GetElement<FontReference>(4);
      }
      set
      {
        this.SetElement<FontReference>(4, value);
      }
    }

    public ShapeProperties ShapeProperties
    {
      get
      {
        return this.GetElement<ShapeProperties>(5);
      }
      set
      {
        this.SetElement<ShapeProperties>(5, value);
      }
    }

    public TextCharacterPropertiesType TextCharacterPropertiesType
    {
      get
      {
        return this.GetElement<TextCharacterPropertiesType>(6);
      }
      set
      {
        this.SetElement<TextCharacterPropertiesType>(6, value);
      }
    }

    public TextBodyProperties TextBodyProperties
    {
      get
      {
        return this.GetElement<TextBodyProperties>(7);
      }
      set
      {
        this.SetElement<TextBodyProperties>(7, value);
      }
    }

    public OfficeArtExtensionList OfficeArtExtensionList
    {
      get
      {
        return this.GetElement<OfficeArtExtensionList>(8);
      }
      set
      {
        this.SetElement<OfficeArtExtensionList>(8, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "mods" == name)
        return (OpenXmlSimpleType) new ListValue<StringValue>();
      return base.AttributeFactory(namespaceId, name);
    }

    protected StyleEntry()
    {
    }

    protected StyleEntry(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected StyleEntry(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected StyleEntry(string outerXml)
      : base(outerXml)
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle
{
  [ChildElementInfo(typeof (ComplexScriptFont))]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Outline))]
  [ChildElementInfo(typeof (NoFill))]
  [ChildElementInfo(typeof (SolidFill))]
  [ChildElementInfo(typeof (GradientFill))]
  [ChildElementInfo(typeof (BlipFill))]
  [ChildElementInfo(typeof (PatternFill))]
  [ChildElementInfo(typeof (GroupFill))]
  [ChildElementInfo(typeof (EffectList))]
  [ChildElementInfo(typeof (EffectDag))]
  [ChildElementInfo(typeof (Highlight))]
  [ChildElementInfo(typeof (UnderlineFollowsText))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Drawing.Underline))]
  [ChildElementInfo(typeof (UnderlineFillText))]
  [ChildElementInfo(typeof (UnderlineFill))]
  [ChildElementInfo(typeof (LatinFont))]
  [ChildElementInfo(typeof (EastAsianFont))]
  [ChildElementInfo(typeof (SymbolFont))]
  [ChildElementInfo(typeof (HyperlinkOnClick))]
  [ChildElementInfo(typeof (HyperlinkOnMouseOver))]
  [ChildElementInfo(typeof (RightToLeft))]
  [ChildElementInfo(typeof (ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  public class TextCharacterPropertiesType : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[17]
    {
      "kumimoji",
      "lang",
      "altLang",
      "sz",
      "b",
      "i",
      "u",
      "strike",
      "kern",
      "cap",
      "spc",
      "normalizeH",
      "baseline",
      "noProof",
      "dirty",
      "err",
      "bmk"
    };
    private static byte[] attributeNamespaceIds = new byte[17];
    private static readonly string[] eleTagNames = new string[22]
    {
      "ln",
      "noFill",
      "solidFill",
      "gradFill",
      "blipFill",
      "pattFill",
      "grpFill",
      "effectLst",
      "effectDag",
      "highlight",
      "uLnTx",
      "uLn",
      "uFillTx",
      "uFill",
      "latin",
      "ea",
      "cs",
      "sym",
      "hlinkClick",
      "hlinkMouseOver",
      "rtl",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[22]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "defRPr";
    private const byte tagNsId = 65;
    internal const int ElementTypeIdConst = 13267;

    public override string LocalName
    {
      get
      {
        return "defRPr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 65;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13267;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return TextCharacterPropertiesType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TextCharacterPropertiesType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "kumimoji")]
    public BooleanValue Kumimoji
    {
      get
      {
        return (BooleanValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "lang")]
    public StringValue Language
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

    [SchemaAttr(0, "altLang")]
    public StringValue AlternativeLanguage
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

    [SchemaAttr(0, "sz")]
    public Int32Value FontSize
    {
      get
      {
        return (Int32Value) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "b")]
    public BooleanValue Bold
    {
      get
      {
        return (BooleanValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "i")]
    public BooleanValue Italic
    {
      get
      {
        return (BooleanValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "u")]
    public EnumValue<TextUnderlineValues> Underline
    {
      get
      {
        return (EnumValue<TextUnderlineValues>) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "strike")]
    public EnumValue<TextStrikeValues> Strike
    {
      get
      {
        return (EnumValue<TextStrikeValues>) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "kern")]
    public Int32Value Kerning
    {
      get
      {
        return (Int32Value) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "cap")]
    public EnumValue<TextCapsValues> Capital
    {
      get
      {
        return (EnumValue<TextCapsValues>) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "spc")]
    public Int32Value Spacing
    {
      get
      {
        return (Int32Value) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "normalizeH")]
    public BooleanValue NormalizeHeight
    {
      get
      {
        return (BooleanValue) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "baseline")]
    public Int32Value Baseline
    {
      get
      {
        return (Int32Value) this.Attributes[12];
      }
      set
      {
        this.Attributes[12] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "noProof")]
    public BooleanValue NoProof
    {
      get
      {
        return (BooleanValue) this.Attributes[13];
      }
      set
      {
        this.Attributes[13] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "dirty")]
    public BooleanValue Dirty
    {
      get
      {
        return (BooleanValue) this.Attributes[14];
      }
      set
      {
        this.Attributes[14] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "err")]
    public BooleanValue SpellingError
    {
      get
      {
        return (BooleanValue) this.Attributes[15];
      }
      set
      {
        this.Attributes[15] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "bmk")]
    public StringValue Bookmark
    {
      get
      {
        return (StringValue) this.Attributes[16];
      }
      set
      {
        this.Attributes[16] = (OpenXmlSimpleType) value;
      }
    }

    public TextCharacterPropertiesType()
    {
    }

    public TextCharacterPropertiesType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TextCharacterPropertiesType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TextCharacterPropertiesType(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "ln" == name)
        return (OpenXmlElement) new Outline();
      if (10 == (int) namespaceId && "noFill" == name)
        return (OpenXmlElement) new NoFill();
      if (10 == (int) namespaceId && "solidFill" == name)
        return (OpenXmlElement) new SolidFill();
      if (10 == (int) namespaceId && "gradFill" == name)
        return (OpenXmlElement) new GradientFill();
      if (10 == (int) namespaceId && "blipFill" == name)
        return (OpenXmlElement) new BlipFill();
      if (10 == (int) namespaceId && "pattFill" == name)
        return (OpenXmlElement) new PatternFill();
      if (10 == (int) namespaceId && "grpFill" == name)
        return (OpenXmlElement) new GroupFill();
      if (10 == (int) namespaceId && "effectLst" == name)
        return (OpenXmlElement) new EffectList();
      if (10 == (int) namespaceId && "effectDag" == name)
        return (OpenXmlElement) new EffectDag();
      if (10 == (int) namespaceId && "highlight" == name)
        return (OpenXmlElement) new Highlight();
      if (10 == (int) namespaceId && "uLnTx" == name)
        return (OpenXmlElement) new UnderlineFollowsText();
      if (10 == (int) namespaceId && "uLn" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Drawing.Underline();
      if (10 == (int) namespaceId && "uFillTx" == name)
        return (OpenXmlElement) new UnderlineFillText();
      if (10 == (int) namespaceId && "uFill" == name)
        return (OpenXmlElement) new UnderlineFill();
      if (10 == (int) namespaceId && "latin" == name)
        return (OpenXmlElement) new LatinFont();
      if (10 == (int) namespaceId && "ea" == name)
        return (OpenXmlElement) new EastAsianFont();
      if (10 == (int) namespaceId && "cs" == name)
        return (OpenXmlElement) new ComplexScriptFont();
      if (10 == (int) namespaceId && "sym" == name)
        return (OpenXmlElement) new SymbolFont();
      if (10 == (int) namespaceId && "hlinkClick" == name)
        return (OpenXmlElement) new HyperlinkOnClick();
      if (10 == (int) namespaceId && "hlinkMouseOver" == name)
        return (OpenXmlElement) new HyperlinkOnMouseOver();
      if (10 == (int) namespaceId && "rtl" == name)
        return (OpenXmlElement) new RightToLeft();
      if (10 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TextCharacterPropertiesType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TextCharacterPropertiesType.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Outline Outline
    {
      get
      {
        return this.GetElement<Outline>(0);
      }
      set
      {
        this.SetElement<Outline>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "kumimoji" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "lang" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "altLang" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "sz" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "b" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "i" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "u" == name)
        return (OpenXmlSimpleType) new EnumValue<TextUnderlineValues>();
      if ((int) namespaceId == 0 && "strike" == name)
        return (OpenXmlSimpleType) new EnumValue<TextStrikeValues>();
      if ((int) namespaceId == 0 && "kern" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "cap" == name)
        return (OpenXmlSimpleType) new EnumValue<TextCapsValues>();
      if ((int) namespaceId == 0 && "spc" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "normalizeH" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "baseline" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "noProof" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "dirty" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "err" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "bmk" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TextCharacterPropertiesType>(deep);
    }
  }
}

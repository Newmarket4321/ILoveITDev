// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (SmallCaps))]
  [ChildElementInfo(typeof (FontSizeComplexScript))]
  [ChildElementInfo(typeof (Color))]
  [ChildElementInfo(typeof (Spacing))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Bold))]
  [ChildElementInfo(typeof (BoldComplexScript))]
  [ChildElementInfo(typeof (Italic))]
  [ChildElementInfo(typeof (ItalicComplexScript))]
  [ChildElementInfo(typeof (Caps))]
  [ChildElementInfo(typeof (Strike))]
  [ChildElementInfo(typeof (DoubleStrike))]
  [ChildElementInfo(typeof (Outline))]
  [ChildElementInfo(typeof (Shadow))]
  [ChildElementInfo(typeof (Emboss))]
  [ChildElementInfo(typeof (Imprint))]
  [ChildElementInfo(typeof (NoProof))]
  [ChildElementInfo(typeof (SnapToGrid))]
  [ChildElementInfo(typeof (Vanish))]
  [ChildElementInfo(typeof (WebHidden))]
  [ChildElementInfo(typeof (RunFonts))]
  [ChildElementInfo(typeof (CharacterScale))]
  [ChildElementInfo(typeof (Kern))]
  [ChildElementInfo(typeof (Position))]
  [ChildElementInfo(typeof (FontSize))]
  [ChildElementInfo(typeof (Underline))]
  [ChildElementInfo(typeof (TextEffect))]
  [ChildElementInfo(typeof (Border))]
  [ChildElementInfo(typeof (Shading))]
  [ChildElementInfo(typeof (FitText))]
  [ChildElementInfo(typeof (VerticalTextAlignment))]
  [ChildElementInfo(typeof (RightToLeftText))]
  [ChildElementInfo(typeof (ComplexScript))]
  [ChildElementInfo(typeof (Emphasis))]
  [ChildElementInfo(typeof (Languages))]
  [ChildElementInfo(typeof (EastAsianLayout))]
  [ChildElementInfo(typeof (SpecVanish))]
  public class NumberingSymbolRunProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[36]
    {
      "rFonts",
      "b",
      "bCs",
      "i",
      "iCs",
      "caps",
      "smallCaps",
      "strike",
      "dstrike",
      "outline",
      "shadow",
      "emboss",
      "imprint",
      "noProof",
      "snapToGrid",
      "vanish",
      "webHidden",
      "color",
      "spacing",
      "w",
      "kern",
      "position",
      "sz",
      "szCs",
      "u",
      "effect",
      "bdr",
      "shd",
      "fitText",
      "vertAlign",
      "rtl",
      "cs",
      "em",
      "lang",
      "eastAsianLayout",
      "specVanish"
    };
    private static readonly byte[] eleNamespaceIds = new byte[36]
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
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "rPr";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11921;

    public override string LocalName
    {
      get
      {
        return "rPr";
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
        return 11921;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public NumberingSymbolRunProperties()
    {
    }

    public NumberingSymbolRunProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public NumberingSymbolRunProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public NumberingSymbolRunProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "rFonts" == name)
        return (OpenXmlElement) new RunFonts();
      if (23 == (int) namespaceId && "b" == name)
        return (OpenXmlElement) new Bold();
      if (23 == (int) namespaceId && "bCs" == name)
        return (OpenXmlElement) new BoldComplexScript();
      if (23 == (int) namespaceId && "i" == name)
        return (OpenXmlElement) new Italic();
      if (23 == (int) namespaceId && "iCs" == name)
        return (OpenXmlElement) new ItalicComplexScript();
      if (23 == (int) namespaceId && "caps" == name)
        return (OpenXmlElement) new Caps();
      if (23 == (int) namespaceId && "smallCaps" == name)
        return (OpenXmlElement) new SmallCaps();
      if (23 == (int) namespaceId && "strike" == name)
        return (OpenXmlElement) new Strike();
      if (23 == (int) namespaceId && "dstrike" == name)
        return (OpenXmlElement) new DoubleStrike();
      if (23 == (int) namespaceId && "outline" == name)
        return (OpenXmlElement) new Outline();
      if (23 == (int) namespaceId && "shadow" == name)
        return (OpenXmlElement) new Shadow();
      if (23 == (int) namespaceId && "emboss" == name)
        return (OpenXmlElement) new Emboss();
      if (23 == (int) namespaceId && "imprint" == name)
        return (OpenXmlElement) new Imprint();
      if (23 == (int) namespaceId && "noProof" == name)
        return (OpenXmlElement) new NoProof();
      if (23 == (int) namespaceId && "snapToGrid" == name)
        return (OpenXmlElement) new SnapToGrid();
      if (23 == (int) namespaceId && "vanish" == name)
        return (OpenXmlElement) new Vanish();
      if (23 == (int) namespaceId && "webHidden" == name)
        return (OpenXmlElement) new WebHidden();
      if (23 == (int) namespaceId && "color" == name)
        return (OpenXmlElement) new Color();
      if (23 == (int) namespaceId && "spacing" == name)
        return (OpenXmlElement) new Spacing();
      if (23 == (int) namespaceId && "w" == name)
        return (OpenXmlElement) new CharacterScale();
      if (23 == (int) namespaceId && "kern" == name)
        return (OpenXmlElement) new Kern();
      if (23 == (int) namespaceId && "position" == name)
        return (OpenXmlElement) new Position();
      if (23 == (int) namespaceId && "sz" == name)
        return (OpenXmlElement) new FontSize();
      if (23 == (int) namespaceId && "szCs" == name)
        return (OpenXmlElement) new FontSizeComplexScript();
      if (23 == (int) namespaceId && "u" == name)
        return (OpenXmlElement) new Underline();
      if (23 == (int) namespaceId && "effect" == name)
        return (OpenXmlElement) new TextEffect();
      if (23 == (int) namespaceId && "bdr" == name)
        return (OpenXmlElement) new Border();
      if (23 == (int) namespaceId && "shd" == name)
        return (OpenXmlElement) new Shading();
      if (23 == (int) namespaceId && "fitText" == name)
        return (OpenXmlElement) new FitText();
      if (23 == (int) namespaceId && "vertAlign" == name)
        return (OpenXmlElement) new VerticalTextAlignment();
      if (23 == (int) namespaceId && "rtl" == name)
        return (OpenXmlElement) new RightToLeftText();
      if (23 == (int) namespaceId && "cs" == name)
        return (OpenXmlElement) new ComplexScript();
      if (23 == (int) namespaceId && "em" == name)
        return (OpenXmlElement) new Emphasis();
      if (23 == (int) namespaceId && "lang" == name)
        return (OpenXmlElement) new Languages();
      if (23 == (int) namespaceId && "eastAsianLayout" == name)
        return (OpenXmlElement) new EastAsianLayout();
      if (23 == (int) namespaceId && "specVanish" == name)
        return (OpenXmlElement) new SpecVanish();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return NumberingSymbolRunProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return NumberingSymbolRunProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public RunFonts RunFonts
    {
      get
      {
        return this.GetElement<RunFonts>(0);
      }
      set
      {
        this.SetElement<RunFonts>(0, value);
      }
    }

    public Bold Bold
    {
      get
      {
        return this.GetElement<Bold>(1);
      }
      set
      {
        this.SetElement<Bold>(1, value);
      }
    }

    public BoldComplexScript BoldComplexScript
    {
      get
      {
        return this.GetElement<BoldComplexScript>(2);
      }
      set
      {
        this.SetElement<BoldComplexScript>(2, value);
      }
    }

    public Italic Italic
    {
      get
      {
        return this.GetElement<Italic>(3);
      }
      set
      {
        this.SetElement<Italic>(3, value);
      }
    }

    public ItalicComplexScript ItalicComplexScript
    {
      get
      {
        return this.GetElement<ItalicComplexScript>(4);
      }
      set
      {
        this.SetElement<ItalicComplexScript>(4, value);
      }
    }

    public Caps Caps
    {
      get
      {
        return this.GetElement<Caps>(5);
      }
      set
      {
        this.SetElement<Caps>(5, value);
      }
    }

    public SmallCaps SmallCaps
    {
      get
      {
        return this.GetElement<SmallCaps>(6);
      }
      set
      {
        this.SetElement<SmallCaps>(6, value);
      }
    }

    public Strike Strike
    {
      get
      {
        return this.GetElement<Strike>(7);
      }
      set
      {
        this.SetElement<Strike>(7, value);
      }
    }

    public DoubleStrike DoubleStrike
    {
      get
      {
        return this.GetElement<DoubleStrike>(8);
      }
      set
      {
        this.SetElement<DoubleStrike>(8, value);
      }
    }

    public Outline Outline
    {
      get
      {
        return this.GetElement<Outline>(9);
      }
      set
      {
        this.SetElement<Outline>(9, value);
      }
    }

    public Shadow Shadow
    {
      get
      {
        return this.GetElement<Shadow>(10);
      }
      set
      {
        this.SetElement<Shadow>(10, value);
      }
    }

    public Emboss Emboss
    {
      get
      {
        return this.GetElement<Emboss>(11);
      }
      set
      {
        this.SetElement<Emboss>(11, value);
      }
    }

    public Imprint Imprint
    {
      get
      {
        return this.GetElement<Imprint>(12);
      }
      set
      {
        this.SetElement<Imprint>(12, value);
      }
    }

    public NoProof NoProof
    {
      get
      {
        return this.GetElement<NoProof>(13);
      }
      set
      {
        this.SetElement<NoProof>(13, value);
      }
    }

    public SnapToGrid SnapToGrid
    {
      get
      {
        return this.GetElement<SnapToGrid>(14);
      }
      set
      {
        this.SetElement<SnapToGrid>(14, value);
      }
    }

    public Vanish Vanish
    {
      get
      {
        return this.GetElement<Vanish>(15);
      }
      set
      {
        this.SetElement<Vanish>(15, value);
      }
    }

    public WebHidden WebHidden
    {
      get
      {
        return this.GetElement<WebHidden>(16);
      }
      set
      {
        this.SetElement<WebHidden>(16, value);
      }
    }

    public Color Color
    {
      get
      {
        return this.GetElement<Color>(17);
      }
      set
      {
        this.SetElement<Color>(17, value);
      }
    }

    public Spacing Spacing
    {
      get
      {
        return this.GetElement<Spacing>(18);
      }
      set
      {
        this.SetElement<Spacing>(18, value);
      }
    }

    public CharacterScale CharacterScale
    {
      get
      {
        return this.GetElement<CharacterScale>(19);
      }
      set
      {
        this.SetElement<CharacterScale>(19, value);
      }
    }

    public Kern Kern
    {
      get
      {
        return this.GetElement<Kern>(20);
      }
      set
      {
        this.SetElement<Kern>(20, value);
      }
    }

    public Position Position
    {
      get
      {
        return this.GetElement<Position>(21);
      }
      set
      {
        this.SetElement<Position>(21, value);
      }
    }

    public FontSize FontSize
    {
      get
      {
        return this.GetElement<FontSize>(22);
      }
      set
      {
        this.SetElement<FontSize>(22, value);
      }
    }

    public FontSizeComplexScript FontSizeComplexScript
    {
      get
      {
        return this.GetElement<FontSizeComplexScript>(23);
      }
      set
      {
        this.SetElement<FontSizeComplexScript>(23, value);
      }
    }

    public Underline Underline
    {
      get
      {
        return this.GetElement<Underline>(24);
      }
      set
      {
        this.SetElement<Underline>(24, value);
      }
    }

    public TextEffect TextEffect
    {
      get
      {
        return this.GetElement<TextEffect>(25);
      }
      set
      {
        this.SetElement<TextEffect>(25, value);
      }
    }

    public Border Border
    {
      get
      {
        return this.GetElement<Border>(26);
      }
      set
      {
        this.SetElement<Border>(26, value);
      }
    }

    public Shading Shading
    {
      get
      {
        return this.GetElement<Shading>(27);
      }
      set
      {
        this.SetElement<Shading>(27, value);
      }
    }

    public FitText FitText
    {
      get
      {
        return this.GetElement<FitText>(28);
      }
      set
      {
        this.SetElement<FitText>(28, value);
      }
    }

    public VerticalTextAlignment VerticalTextAlignment
    {
      get
      {
        return this.GetElement<VerticalTextAlignment>(29);
      }
      set
      {
        this.SetElement<VerticalTextAlignment>(29, value);
      }
    }

    public RightToLeftText RightToLeftText
    {
      get
      {
        return this.GetElement<RightToLeftText>(30);
      }
      set
      {
        this.SetElement<RightToLeftText>(30, value);
      }
    }

    public ComplexScript ComplexScript
    {
      get
      {
        return this.GetElement<ComplexScript>(31);
      }
      set
      {
        this.SetElement<ComplexScript>(31, value);
      }
    }

    public Emphasis Emphasis
    {
      get
      {
        return this.GetElement<Emphasis>(32);
      }
      set
      {
        this.SetElement<Emphasis>(32, value);
      }
    }

    public Languages Languages
    {
      get
      {
        return this.GetElement<Languages>(33);
      }
      set
      {
        this.SetElement<Languages>(33, value);
      }
    }

    public EastAsianLayout EastAsianLayout
    {
      get
      {
        return this.GetElement<EastAsianLayout>(34);
      }
      set
      {
        this.SetElement<EastAsianLayout>(34, value);
      }
    }

    public SpecVanish SpecVanish
    {
      get
      {
        return this.GetElement<SpecVanish>(35);
      }
      set
      {
        this.SetElement<SpecVanish>(35, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<NumberingSymbolRunProperties>(deep);
    }
  }
}

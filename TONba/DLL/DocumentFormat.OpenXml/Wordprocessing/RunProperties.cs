// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.RunProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2010.Word;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (RunFonts))]
  [ChildElementInfo(typeof (Border))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (RunStyle))]
  [ChildElementInfo(typeof (Bold))]
  [ChildElementInfo(typeof (BoldComplexScript))]
  [ChildElementInfo(typeof (Italic))]
  [ChildElementInfo(typeof (ItalicComplexScript))]
  [ChildElementInfo(typeof (Caps))]
  [ChildElementInfo(typeof (SmallCaps))]
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
  [ChildElementInfo(typeof (Color))]
  [ChildElementInfo(typeof (Spacing))]
  [ChildElementInfo(typeof (CharacterScale))]
  [ChildElementInfo(typeof (Kern))]
  [ChildElementInfo(typeof (Position))]
  [ChildElementInfo(typeof (FontSize))]
  [ChildElementInfo(typeof (FontSizeComplexScript))]
  [ChildElementInfo(typeof (Highlight))]
  [ChildElementInfo(typeof (Underline))]
  [ChildElementInfo(typeof (TextEffect))]
  [ChildElementInfo(typeof (Shading))]
  [ChildElementInfo(typeof (FitText))]
  [ChildElementInfo(typeof (VerticalTextAlignment))]
  [ChildElementInfo(typeof (RightToLeftText))]
  [ChildElementInfo(typeof (ComplexScript))]
  [ChildElementInfo(typeof (Emphasis))]
  [ChildElementInfo(typeof (Languages))]
  [ChildElementInfo(typeof (EastAsianLayout))]
  [ChildElementInfo(typeof (SpecVanish))]
  [ChildElementInfo(typeof (Glow), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.Word.Shadow), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Reflection), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (TextOutlineEffect), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (FillTextEffect), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Scene3D), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Properties3D), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Ligatures), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.Word.NumberingFormat), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (NumberSpacing), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (StylisticSets), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ContextualAlternatives), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (RunPropertiesChange))]
  public class RunProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[51]
    {
      "rStyle",
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
      "highlight",
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
      "specVanish",
      "glow",
      "shadow",
      "reflection",
      "textOutline",
      "textFill",
      "scene3d",
      "props3d",
      "ligatures",
      "numForm",
      "numSpacing",
      "stylisticSets",
      "cntxtAlts",
      "rPrChange"
    };
    private static readonly byte[] eleNamespaceIds = new byte[51]
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
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 52,
      (byte) 23
    };
    private const string tagName = "rPr";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11660;

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
        return 11660;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public RunProperties()
    {
    }

    public RunProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public RunProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public RunProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "rStyle" == name)
        return (OpenXmlElement) new RunStyle();
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
      if (23 == (int) namespaceId && "highlight" == name)
        return (OpenXmlElement) new Highlight();
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
      if (52 == (int) namespaceId && "glow" == name)
        return (OpenXmlElement) new Glow();
      if (52 == (int) namespaceId && "shadow" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.Word.Shadow();
      if (52 == (int) namespaceId && "reflection" == name)
        return (OpenXmlElement) new Reflection();
      if (52 == (int) namespaceId && "textOutline" == name)
        return (OpenXmlElement) new TextOutlineEffect();
      if (52 == (int) namespaceId && "textFill" == name)
        return (OpenXmlElement) new FillTextEffect();
      if (52 == (int) namespaceId && "scene3d" == name)
        return (OpenXmlElement) new Scene3D();
      if (52 == (int) namespaceId && "props3d" == name)
        return (OpenXmlElement) new Properties3D();
      if (52 == (int) namespaceId && "ligatures" == name)
        return (OpenXmlElement) new Ligatures();
      if (52 == (int) namespaceId && "numForm" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.Word.NumberingFormat();
      if (52 == (int) namespaceId && "numSpacing" == name)
        return (OpenXmlElement) new NumberSpacing();
      if (52 == (int) namespaceId && "stylisticSets" == name)
        return (OpenXmlElement) new StylisticSets();
      if (52 == (int) namespaceId && "cntxtAlts" == name)
        return (OpenXmlElement) new ContextualAlternatives();
      if (23 == (int) namespaceId && "rPrChange" == name)
        return (OpenXmlElement) new RunPropertiesChange();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return RunProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return RunProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public RunStyle RunStyle
    {
      get
      {
        return this.GetElement<RunStyle>(0);
      }
      set
      {
        this.SetElement<RunStyle>(0, value);
      }
    }

    public RunFonts RunFonts
    {
      get
      {
        return this.GetElement<RunFonts>(1);
      }
      set
      {
        this.SetElement<RunFonts>(1, value);
      }
    }

    public Bold Bold
    {
      get
      {
        return this.GetElement<Bold>(2);
      }
      set
      {
        this.SetElement<Bold>(2, value);
      }
    }

    public BoldComplexScript BoldComplexScript
    {
      get
      {
        return this.GetElement<BoldComplexScript>(3);
      }
      set
      {
        this.SetElement<BoldComplexScript>(3, value);
      }
    }

    public Italic Italic
    {
      get
      {
        return this.GetElement<Italic>(4);
      }
      set
      {
        this.SetElement<Italic>(4, value);
      }
    }

    public ItalicComplexScript ItalicComplexScript
    {
      get
      {
        return this.GetElement<ItalicComplexScript>(5);
      }
      set
      {
        this.SetElement<ItalicComplexScript>(5, value);
      }
    }

    public Caps Caps
    {
      get
      {
        return this.GetElement<Caps>(6);
      }
      set
      {
        this.SetElement<Caps>(6, value);
      }
    }

    public SmallCaps SmallCaps
    {
      get
      {
        return this.GetElement<SmallCaps>(7);
      }
      set
      {
        this.SetElement<SmallCaps>(7, value);
      }
    }

    public Strike Strike
    {
      get
      {
        return this.GetElement<Strike>(8);
      }
      set
      {
        this.SetElement<Strike>(8, value);
      }
    }

    public DoubleStrike DoubleStrike
    {
      get
      {
        return this.GetElement<DoubleStrike>(9);
      }
      set
      {
        this.SetElement<DoubleStrike>(9, value);
      }
    }

    public Outline Outline
    {
      get
      {
        return this.GetElement<Outline>(10);
      }
      set
      {
        this.SetElement<Outline>(10, value);
      }
    }

    public Shadow Shadow
    {
      get
      {
        return this.GetElement<Shadow>(11);
      }
      set
      {
        this.SetElement<Shadow>(11, value);
      }
    }

    public Emboss Emboss
    {
      get
      {
        return this.GetElement<Emboss>(12);
      }
      set
      {
        this.SetElement<Emboss>(12, value);
      }
    }

    public Imprint Imprint
    {
      get
      {
        return this.GetElement<Imprint>(13);
      }
      set
      {
        this.SetElement<Imprint>(13, value);
      }
    }

    public NoProof NoProof
    {
      get
      {
        return this.GetElement<NoProof>(14);
      }
      set
      {
        this.SetElement<NoProof>(14, value);
      }
    }

    public SnapToGrid SnapToGrid
    {
      get
      {
        return this.GetElement<SnapToGrid>(15);
      }
      set
      {
        this.SetElement<SnapToGrid>(15, value);
      }
    }

    public Vanish Vanish
    {
      get
      {
        return this.GetElement<Vanish>(16);
      }
      set
      {
        this.SetElement<Vanish>(16, value);
      }
    }

    public WebHidden WebHidden
    {
      get
      {
        return this.GetElement<WebHidden>(17);
      }
      set
      {
        this.SetElement<WebHidden>(17, value);
      }
    }

    public Color Color
    {
      get
      {
        return this.GetElement<Color>(18);
      }
      set
      {
        this.SetElement<Color>(18, value);
      }
    }

    public Spacing Spacing
    {
      get
      {
        return this.GetElement<Spacing>(19);
      }
      set
      {
        this.SetElement<Spacing>(19, value);
      }
    }

    public CharacterScale CharacterScale
    {
      get
      {
        return this.GetElement<CharacterScale>(20);
      }
      set
      {
        this.SetElement<CharacterScale>(20, value);
      }
    }

    public Kern Kern
    {
      get
      {
        return this.GetElement<Kern>(21);
      }
      set
      {
        this.SetElement<Kern>(21, value);
      }
    }

    public Position Position
    {
      get
      {
        return this.GetElement<Position>(22);
      }
      set
      {
        this.SetElement<Position>(22, value);
      }
    }

    public FontSize FontSize
    {
      get
      {
        return this.GetElement<FontSize>(23);
      }
      set
      {
        this.SetElement<FontSize>(23, value);
      }
    }

    public FontSizeComplexScript FontSizeComplexScript
    {
      get
      {
        return this.GetElement<FontSizeComplexScript>(24);
      }
      set
      {
        this.SetElement<FontSizeComplexScript>(24, value);
      }
    }

    public Highlight Highlight
    {
      get
      {
        return this.GetElement<Highlight>(25);
      }
      set
      {
        this.SetElement<Highlight>(25, value);
      }
    }

    public Underline Underline
    {
      get
      {
        return this.GetElement<Underline>(26);
      }
      set
      {
        this.SetElement<Underline>(26, value);
      }
    }

    public TextEffect TextEffect
    {
      get
      {
        return this.GetElement<TextEffect>(27);
      }
      set
      {
        this.SetElement<TextEffect>(27, value);
      }
    }

    public Border Border
    {
      get
      {
        return this.GetElement<Border>(28);
      }
      set
      {
        this.SetElement<Border>(28, value);
      }
    }

    public Shading Shading
    {
      get
      {
        return this.GetElement<Shading>(29);
      }
      set
      {
        this.SetElement<Shading>(29, value);
      }
    }

    public FitText FitText
    {
      get
      {
        return this.GetElement<FitText>(30);
      }
      set
      {
        this.SetElement<FitText>(30, value);
      }
    }

    public VerticalTextAlignment VerticalTextAlignment
    {
      get
      {
        return this.GetElement<VerticalTextAlignment>(31);
      }
      set
      {
        this.SetElement<VerticalTextAlignment>(31, value);
      }
    }

    public RightToLeftText RightToLeftText
    {
      get
      {
        return this.GetElement<RightToLeftText>(32);
      }
      set
      {
        this.SetElement<RightToLeftText>(32, value);
      }
    }

    public ComplexScript ComplexScript
    {
      get
      {
        return this.GetElement<ComplexScript>(33);
      }
      set
      {
        this.SetElement<ComplexScript>(33, value);
      }
    }

    public Emphasis Emphasis
    {
      get
      {
        return this.GetElement<Emphasis>(34);
      }
      set
      {
        this.SetElement<Emphasis>(34, value);
      }
    }

    public Languages Languages
    {
      get
      {
        return this.GetElement<Languages>(35);
      }
      set
      {
        this.SetElement<Languages>(35, value);
      }
    }

    public EastAsianLayout EastAsianLayout
    {
      get
      {
        return this.GetElement<EastAsianLayout>(36);
      }
      set
      {
        this.SetElement<EastAsianLayout>(36, value);
      }
    }

    public SpecVanish SpecVanish
    {
      get
      {
        return this.GetElement<SpecVanish>(37);
      }
      set
      {
        this.SetElement<SpecVanish>(37, value);
      }
    }

    public Glow Glow
    {
      get
      {
        return this.GetElement<Glow>(38);
      }
      set
      {
        this.SetElement<Glow>(38, value);
      }
    }

    public DocumentFormat.OpenXml.Office2010.Word.Shadow Shadow14
    {
      get
      {
        return this.GetElement<DocumentFormat.OpenXml.Office2010.Word.Shadow>(39);
      }
      set
      {
        this.SetElement<DocumentFormat.OpenXml.Office2010.Word.Shadow>(39, value);
      }
    }

    public Reflection Reflection
    {
      get
      {
        return this.GetElement<Reflection>(40);
      }
      set
      {
        this.SetElement<Reflection>(40, value);
      }
    }

    public TextOutlineEffect TextOutlineEffect
    {
      get
      {
        return this.GetElement<TextOutlineEffect>(41);
      }
      set
      {
        this.SetElement<TextOutlineEffect>(41, value);
      }
    }

    public FillTextEffect FillTextEffect
    {
      get
      {
        return this.GetElement<FillTextEffect>(42);
      }
      set
      {
        this.SetElement<FillTextEffect>(42, value);
      }
    }

    public Scene3D Scene3D
    {
      get
      {
        return this.GetElement<Scene3D>(43);
      }
      set
      {
        this.SetElement<Scene3D>(43, value);
      }
    }

    public Properties3D Properties3D
    {
      get
      {
        return this.GetElement<Properties3D>(44);
      }
      set
      {
        this.SetElement<Properties3D>(44, value);
      }
    }

    public Ligatures Ligatures
    {
      get
      {
        return this.GetElement<Ligatures>(45);
      }
      set
      {
        this.SetElement<Ligatures>(45, value);
      }
    }

    public DocumentFormat.OpenXml.Office2010.Word.NumberingFormat NumberingFormat
    {
      get
      {
        return this.GetElement<DocumentFormat.OpenXml.Office2010.Word.NumberingFormat>(46);
      }
      set
      {
        this.SetElement<DocumentFormat.OpenXml.Office2010.Word.NumberingFormat>(46, value);
      }
    }

    public NumberSpacing NumberSpacing
    {
      get
      {
        return this.GetElement<NumberSpacing>(47);
      }
      set
      {
        this.SetElement<NumberSpacing>(47, value);
      }
    }

    public StylisticSets StylisticSets
    {
      get
      {
        return this.GetElement<StylisticSets>(48);
      }
      set
      {
        this.SetElement<StylisticSets>(48, value);
      }
    }

    public ContextualAlternatives ContextualAlternatives
    {
      get
      {
        return this.GetElement<ContextualAlternatives>(49);
      }
      set
      {
        this.SetElement<ContextualAlternatives>(49, value);
      }
    }

    public RunPropertiesChange RunPropertiesChange
    {
      get
      {
        return this.GetElement<RunPropertiesChange>(50);
      }
      set
      {
        this.SetElement<RunPropertiesChange>(50, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<RunProperties>(deep);
    }
  }
}

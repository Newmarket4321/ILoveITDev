// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.PreviousParagraphProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (SuppressAutoHyphens))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (TopLinePunctuation))]
  [ChildElementInfo(typeof (OutlineLevel))]
  [ChildElementInfo(typeof (KeepNext))]
  [ChildElementInfo(typeof (KeepLines))]
  [ChildElementInfo(typeof (PageBreakBefore))]
  [ChildElementInfo(typeof (FrameProperties))]
  [ChildElementInfo(typeof (WidowControl))]
  [ChildElementInfo(typeof (NumberingProperties))]
  [ChildElementInfo(typeof (SuppressLineNumbers))]
  [ChildElementInfo(typeof (ParagraphBorders))]
  [ChildElementInfo(typeof (Shading))]
  [ChildElementInfo(typeof (Tabs))]
  [ChildElementInfo(typeof (Kinsoku))]
  [ChildElementInfo(typeof (WordWrap))]
  [ChildElementInfo(typeof (OverflowPunctuation))]
  [ChildElementInfo(typeof (ParagraphStyleId))]
  [ChildElementInfo(typeof (AutoSpaceDE))]
  [ChildElementInfo(typeof (AutoSpaceDN))]
  [ChildElementInfo(typeof (BiDi))]
  [ChildElementInfo(typeof (AdjustRightIndent))]
  [ChildElementInfo(typeof (SnapToGrid))]
  [ChildElementInfo(typeof (SpacingBetweenLines))]
  [ChildElementInfo(typeof (Indentation))]
  [ChildElementInfo(typeof (ContextualSpacing))]
  [ChildElementInfo(typeof (MirrorIndents))]
  [ChildElementInfo(typeof (SuppressOverlap))]
  [ChildElementInfo(typeof (Justification))]
  [ChildElementInfo(typeof (TextDirection))]
  [ChildElementInfo(typeof (TextAlignment))]
  [ChildElementInfo(typeof (TextBoxTightWrap))]
  public class PreviousParagraphProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[31]
    {
      "pStyle",
      "keepNext",
      "keepLines",
      "pageBreakBefore",
      "framePr",
      "widowControl",
      "numPr",
      "suppressLineNumbers",
      "pBdr",
      "shd",
      "tabs",
      "suppressAutoHyphens",
      "kinsoku",
      "wordWrap",
      "overflowPunct",
      "topLinePunct",
      "autoSpaceDE",
      "autoSpaceDN",
      "bidi",
      "adjustRightInd",
      "snapToGrid",
      "spacing",
      "ind",
      "contextualSpacing",
      "mirrorIndents",
      "suppressOverlap",
      "jc",
      "textDirection",
      "textAlignment",
      "textboxTightWrap",
      "outlineLvl"
    };
    private static readonly byte[] eleNamespaceIds = new byte[31]
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
      (byte) 23
    };
    private const string tagName = "pPr";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11920;

    public override string LocalName
    {
      get
      {
        return "pPr";
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
        return 11920;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public PreviousParagraphProperties()
    {
    }

    public PreviousParagraphProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PreviousParagraphProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PreviousParagraphProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "pStyle" == name)
        return (OpenXmlElement) new ParagraphStyleId();
      if (23 == (int) namespaceId && "keepNext" == name)
        return (OpenXmlElement) new KeepNext();
      if (23 == (int) namespaceId && "keepLines" == name)
        return (OpenXmlElement) new KeepLines();
      if (23 == (int) namespaceId && "pageBreakBefore" == name)
        return (OpenXmlElement) new PageBreakBefore();
      if (23 == (int) namespaceId && "framePr" == name)
        return (OpenXmlElement) new FrameProperties();
      if (23 == (int) namespaceId && "widowControl" == name)
        return (OpenXmlElement) new WidowControl();
      if (23 == (int) namespaceId && "numPr" == name)
        return (OpenXmlElement) new NumberingProperties();
      if (23 == (int) namespaceId && "suppressLineNumbers" == name)
        return (OpenXmlElement) new SuppressLineNumbers();
      if (23 == (int) namespaceId && "pBdr" == name)
        return (OpenXmlElement) new ParagraphBorders();
      if (23 == (int) namespaceId && "shd" == name)
        return (OpenXmlElement) new Shading();
      if (23 == (int) namespaceId && "tabs" == name)
        return (OpenXmlElement) new Tabs();
      if (23 == (int) namespaceId && "suppressAutoHyphens" == name)
        return (OpenXmlElement) new SuppressAutoHyphens();
      if (23 == (int) namespaceId && "kinsoku" == name)
        return (OpenXmlElement) new Kinsoku();
      if (23 == (int) namespaceId && "wordWrap" == name)
        return (OpenXmlElement) new WordWrap();
      if (23 == (int) namespaceId && "overflowPunct" == name)
        return (OpenXmlElement) new OverflowPunctuation();
      if (23 == (int) namespaceId && "topLinePunct" == name)
        return (OpenXmlElement) new TopLinePunctuation();
      if (23 == (int) namespaceId && "autoSpaceDE" == name)
        return (OpenXmlElement) new AutoSpaceDE();
      if (23 == (int) namespaceId && "autoSpaceDN" == name)
        return (OpenXmlElement) new AutoSpaceDN();
      if (23 == (int) namespaceId && "bidi" == name)
        return (OpenXmlElement) new BiDi();
      if (23 == (int) namespaceId && "adjustRightInd" == name)
        return (OpenXmlElement) new AdjustRightIndent();
      if (23 == (int) namespaceId && "snapToGrid" == name)
        return (OpenXmlElement) new SnapToGrid();
      if (23 == (int) namespaceId && "spacing" == name)
        return (OpenXmlElement) new SpacingBetweenLines();
      if (23 == (int) namespaceId && "ind" == name)
        return (OpenXmlElement) new Indentation();
      if (23 == (int) namespaceId && "contextualSpacing" == name)
        return (OpenXmlElement) new ContextualSpacing();
      if (23 == (int) namespaceId && "mirrorIndents" == name)
        return (OpenXmlElement) new MirrorIndents();
      if (23 == (int) namespaceId && "suppressOverlap" == name)
        return (OpenXmlElement) new SuppressOverlap();
      if (23 == (int) namespaceId && "jc" == name)
        return (OpenXmlElement) new Justification();
      if (23 == (int) namespaceId && "textDirection" == name)
        return (OpenXmlElement) new TextDirection();
      if (23 == (int) namespaceId && "textAlignment" == name)
        return (OpenXmlElement) new TextAlignment();
      if (23 == (int) namespaceId && "textboxTightWrap" == name)
        return (OpenXmlElement) new TextBoxTightWrap();
      if (23 == (int) namespaceId && "outlineLvl" == name)
        return (OpenXmlElement) new OutlineLevel();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return PreviousParagraphProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return PreviousParagraphProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ParagraphStyleId ParagraphStyleId
    {
      get
      {
        return this.GetElement<ParagraphStyleId>(0);
      }
      set
      {
        this.SetElement<ParagraphStyleId>(0, value);
      }
    }

    public KeepNext KeepNext
    {
      get
      {
        return this.GetElement<KeepNext>(1);
      }
      set
      {
        this.SetElement<KeepNext>(1, value);
      }
    }

    public KeepLines KeepLines
    {
      get
      {
        return this.GetElement<KeepLines>(2);
      }
      set
      {
        this.SetElement<KeepLines>(2, value);
      }
    }

    public PageBreakBefore PageBreakBefore
    {
      get
      {
        return this.GetElement<PageBreakBefore>(3);
      }
      set
      {
        this.SetElement<PageBreakBefore>(3, value);
      }
    }

    public FrameProperties FrameProperties
    {
      get
      {
        return this.GetElement<FrameProperties>(4);
      }
      set
      {
        this.SetElement<FrameProperties>(4, value);
      }
    }

    public WidowControl WidowControl
    {
      get
      {
        return this.GetElement<WidowControl>(5);
      }
      set
      {
        this.SetElement<WidowControl>(5, value);
      }
    }

    public NumberingProperties NumberingProperties
    {
      get
      {
        return this.GetElement<NumberingProperties>(6);
      }
      set
      {
        this.SetElement<NumberingProperties>(6, value);
      }
    }

    public SuppressLineNumbers SuppressLineNumbers
    {
      get
      {
        return this.GetElement<SuppressLineNumbers>(7);
      }
      set
      {
        this.SetElement<SuppressLineNumbers>(7, value);
      }
    }

    public ParagraphBorders ParagraphBorders
    {
      get
      {
        return this.GetElement<ParagraphBorders>(8);
      }
      set
      {
        this.SetElement<ParagraphBorders>(8, value);
      }
    }

    public Shading Shading
    {
      get
      {
        return this.GetElement<Shading>(9);
      }
      set
      {
        this.SetElement<Shading>(9, value);
      }
    }

    public Tabs Tabs
    {
      get
      {
        return this.GetElement<Tabs>(10);
      }
      set
      {
        this.SetElement<Tabs>(10, value);
      }
    }

    public SuppressAutoHyphens SuppressAutoHyphens
    {
      get
      {
        return this.GetElement<SuppressAutoHyphens>(11);
      }
      set
      {
        this.SetElement<SuppressAutoHyphens>(11, value);
      }
    }

    public Kinsoku Kinsoku
    {
      get
      {
        return this.GetElement<Kinsoku>(12);
      }
      set
      {
        this.SetElement<Kinsoku>(12, value);
      }
    }

    public WordWrap WordWrap
    {
      get
      {
        return this.GetElement<WordWrap>(13);
      }
      set
      {
        this.SetElement<WordWrap>(13, value);
      }
    }

    public OverflowPunctuation OverflowPunctuation
    {
      get
      {
        return this.GetElement<OverflowPunctuation>(14);
      }
      set
      {
        this.SetElement<OverflowPunctuation>(14, value);
      }
    }

    public TopLinePunctuation TopLinePunctuation
    {
      get
      {
        return this.GetElement<TopLinePunctuation>(15);
      }
      set
      {
        this.SetElement<TopLinePunctuation>(15, value);
      }
    }

    public AutoSpaceDE AutoSpaceDE
    {
      get
      {
        return this.GetElement<AutoSpaceDE>(16);
      }
      set
      {
        this.SetElement<AutoSpaceDE>(16, value);
      }
    }

    public AutoSpaceDN AutoSpaceDN
    {
      get
      {
        return this.GetElement<AutoSpaceDN>(17);
      }
      set
      {
        this.SetElement<AutoSpaceDN>(17, value);
      }
    }

    public BiDi BiDi
    {
      get
      {
        return this.GetElement<BiDi>(18);
      }
      set
      {
        this.SetElement<BiDi>(18, value);
      }
    }

    public AdjustRightIndent AdjustRightIndent
    {
      get
      {
        return this.GetElement<AdjustRightIndent>(19);
      }
      set
      {
        this.SetElement<AdjustRightIndent>(19, value);
      }
    }

    public SnapToGrid SnapToGrid
    {
      get
      {
        return this.GetElement<SnapToGrid>(20);
      }
      set
      {
        this.SetElement<SnapToGrid>(20, value);
      }
    }

    public SpacingBetweenLines SpacingBetweenLines
    {
      get
      {
        return this.GetElement<SpacingBetweenLines>(21);
      }
      set
      {
        this.SetElement<SpacingBetweenLines>(21, value);
      }
    }

    public Indentation Indentation
    {
      get
      {
        return this.GetElement<Indentation>(22);
      }
      set
      {
        this.SetElement<Indentation>(22, value);
      }
    }

    public ContextualSpacing ContextualSpacing
    {
      get
      {
        return this.GetElement<ContextualSpacing>(23);
      }
      set
      {
        this.SetElement<ContextualSpacing>(23, value);
      }
    }

    public MirrorIndents MirrorIndents
    {
      get
      {
        return this.GetElement<MirrorIndents>(24);
      }
      set
      {
        this.SetElement<MirrorIndents>(24, value);
      }
    }

    public SuppressOverlap SuppressOverlap
    {
      get
      {
        return this.GetElement<SuppressOverlap>(25);
      }
      set
      {
        this.SetElement<SuppressOverlap>(25, value);
      }
    }

    public Justification Justification
    {
      get
      {
        return this.GetElement<Justification>(26);
      }
      set
      {
        this.SetElement<Justification>(26, value);
      }
    }

    public TextDirection TextDirection
    {
      get
      {
        return this.GetElement<TextDirection>(27);
      }
      set
      {
        this.SetElement<TextDirection>(27, value);
      }
    }

    public TextAlignment TextAlignment
    {
      get
      {
        return this.GetElement<TextAlignment>(28);
      }
      set
      {
        this.SetElement<TextAlignment>(28, value);
      }
    }

    public TextBoxTightWrap TextBoxTightWrap
    {
      get
      {
        return this.GetElement<TextBoxTightWrap>(29);
      }
      set
      {
        this.SetElement<TextBoxTightWrap>(29, value);
      }
    }

    public OutlineLevel OutlineLevel
    {
      get
      {
        return this.GetElement<OutlineLevel>(30);
      }
      set
      {
        this.SetElement<OutlineLevel>(30, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PreviousParagraphProperties>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.Compatibility
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (ConvertMailMergeEscape))]
  [ChildElementInfo(typeof (AutoSpaceLikeWord95))]
  [ChildElementInfo(typeof (NoSpaceRaiseLower))]
  [ChildElementInfo(typeof (LayoutTableRowsApart))]
  [ChildElementInfo(typeof (UseWord97LineBreakRules))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (UseSingleBorderForContiguousCells))]
  [ChildElementInfo(typeof (WordPerfectJustification))]
  [ChildElementInfo(typeof (NoTabHangIndent))]
  [ChildElementInfo(typeof (NoLeading))]
  [ChildElementInfo(typeof (SpaceForUnderline))]
  [ChildElementInfo(typeof (NoColumnBalance))]
  [ChildElementInfo(typeof (BalanceSingleByteDoubleByteWidth))]
  [ChildElementInfo(typeof (NoExtraLineSpacing))]
  [ChildElementInfo(typeof (DoNotLeaveBackslashAlone))]
  [ChildElementInfo(typeof (UnderlineTrailingSpaces))]
  [ChildElementInfo(typeof (DoNotExpandShiftReturn))]
  [ChildElementInfo(typeof (SpacingInWholePoints))]
  [ChildElementInfo(typeof (LineWrapLikeWord6))]
  [ChildElementInfo(typeof (PrintBodyTextBeforeHeader))]
  [ChildElementInfo(typeof (PrintColorBlackWhite))]
  [ChildElementInfo(typeof (WordPerfectSpaceWidth))]
  [ChildElementInfo(typeof (ShowBreaksInFrames))]
  [ChildElementInfo(typeof (SubFontBySize))]
  [ChildElementInfo(typeof (SuppressBottomSpacing))]
  [ChildElementInfo(typeof (SuppressTopSpacing))]
  [ChildElementInfo(typeof (SuppressSpacingAtTopOfPage))]
  [ChildElementInfo(typeof (SuppressTopSpacingWordPerfect))]
  [ChildElementInfo(typeof (SuppressSpacingBeforeAfterPageBreak))]
  [ChildElementInfo(typeof (SwapBordersFacingPages))]
  [ChildElementInfo(typeof (TruncateFontHeightsLikeWordPerfect))]
  [ChildElementInfo(typeof (MacWordSmallCaps))]
  [ChildElementInfo(typeof (UsePrinterMetrics))]
  [ChildElementInfo(typeof (DoNotSuppressParagraphBorders))]
  [ChildElementInfo(typeof (WrapTrailSpaces))]
  [ChildElementInfo(typeof (FootnoteLayoutLikeWord8))]
  [ChildElementInfo(typeof (ShapeLayoutLikeWord8))]
  [ChildElementInfo(typeof (AlignTablesRowByRow))]
  [ChildElementInfo(typeof (ForgetLastTabAlignment))]
  [ChildElementInfo(typeof (AdjustLineHeightInTable))]
  [ChildElementInfo(typeof (DoNotUseHTMLParagraphAutoSpacing))]
  [ChildElementInfo(typeof (LayoutRawTableWidth))]
  [ChildElementInfo(typeof (DoNotBreakWrappedTables))]
  [ChildElementInfo(typeof (DoNotSnapToGridInCell))]
  [ChildElementInfo(typeof (SelectFieldWithFirstOrLastChar))]
  [ChildElementInfo(typeof (ApplyBreakingRules))]
  [ChildElementInfo(typeof (DoNotWrapTextWithPunctuation))]
  [ChildElementInfo(typeof (DoNotUseEastAsianBreakRules))]
  [ChildElementInfo(typeof (UseWord2002TableStyleRules))]
  [ChildElementInfo(typeof (GrowAutofit))]
  [ChildElementInfo(typeof (UseFarEastLayout))]
  [ChildElementInfo(typeof (UseNormalStyleForList))]
  [ChildElementInfo(typeof (DoNotUseIndentAsNumberingTabStop))]
  [ChildElementInfo(typeof (UseAltKinsokuLineBreakRules))]
  [ChildElementInfo(typeof (AllowSpaceOfSameStyleInTable))]
  [ChildElementInfo(typeof (DoNotSuppressIndentation))]
  [ChildElementInfo(typeof (DoNotAutofitConstrainedTables))]
  [ChildElementInfo(typeof (AutofitToFirstFixedWidthCell))]
  [ChildElementInfo(typeof (UnderlineTabInNumberingList))]
  [ChildElementInfo(typeof (DisplayHangulFixedWidth))]
  [ChildElementInfo(typeof (SplitPageBreakAndParagraphMark))]
  [ChildElementInfo(typeof (DoNotVerticallyAlignCellWithShape))]
  [ChildElementInfo(typeof (DoNotBreakConstrainedForcedTable))]
  [ChildElementInfo(typeof (DoNotVerticallyAlignInTextBox))]
  [ChildElementInfo(typeof (UseAnsiKerningPairs))]
  [ChildElementInfo(typeof (CachedColumnBalance))]
  [ChildElementInfo(typeof (CompatibilitySetting))]
  public class Compatibility : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[66]
    {
      "useSingleBorderforContiguousCells",
      "wpJustification",
      "noTabHangInd",
      "noLeading",
      "spaceForUL",
      "noColumnBalance",
      "balanceSingleByteDoubleByteWidth",
      "noExtraLineSpacing",
      "doNotLeaveBackslashAlone",
      "ulTrailSpace",
      "doNotExpandShiftReturn",
      "spacingInWholePoints",
      "lineWrapLikeWord6",
      "printBodyTextBeforeHeader",
      "printColBlack",
      "wpSpaceWidth",
      "showBreaksInFrames",
      "subFontBySize",
      "suppressBottomSpacing",
      "suppressTopSpacing",
      "suppressSpacingAtTopOfPage",
      "suppressTopSpacingWP",
      "suppressSpBfAfterPgBrk",
      "swapBordersFacingPages",
      "convMailMergeEsc",
      "truncateFontHeightsLikeWP6",
      "mwSmallCaps",
      "usePrinterMetrics",
      "doNotSuppressParagraphBorders",
      "wrapTrailSpaces",
      "footnoteLayoutLikeWW8",
      "shapeLayoutLikeWW8",
      "alignTablesRowByRow",
      "forgetLastTabAlignment",
      "adjustLineHeightInTable",
      "autoSpaceLikeWord95",
      "noSpaceRaiseLower",
      "doNotUseHTMLParagraphAutoSpacing",
      "layoutRawTableWidth",
      "layoutTableRowsApart",
      "useWord97LineBreakRules",
      "doNotBreakWrappedTables",
      "doNotSnapToGridInCell",
      "selectFldWithFirstOrLastChar",
      "applyBreakingRules",
      "doNotWrapTextWithPunct",
      "doNotUseEastAsianBreakRules",
      "useWord2002TableStyleRules",
      "growAutofit",
      "useFELayout",
      "useNormalStyleForList",
      "doNotUseIndentAsNumberingTabStop",
      "useAltKinsokuLineBreakRules",
      "allowSpaceOfSameStyleInTable",
      "doNotSuppressIndentation",
      "doNotAutofitConstrainedTables",
      "autofitToFirstFixedWidthCell",
      "underlineTabInNumList",
      "displayHangulFixedWidth",
      "splitPgBreakAndParaMark",
      "doNotVertAlignCellWithSp",
      "doNotBreakConstrainedForcedTable",
      "doNotVertAlignInTxbx",
      "useAnsiKerningPairs",
      "cachedColBalance",
      "compatSetting"
    };
    private static readonly byte[] eleNamespaceIds = new byte[66]
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
    private const string tagName = "compat";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 12183;

    public override string LocalName
    {
      get
      {
        return "compat";
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
        return 12183;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Compatibility()
    {
    }

    public Compatibility(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Compatibility(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Compatibility(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "useSingleBorderforContiguousCells" == name)
        return (OpenXmlElement) new UseSingleBorderForContiguousCells();
      if (23 == (int) namespaceId && "wpJustification" == name)
        return (OpenXmlElement) new WordPerfectJustification();
      if (23 == (int) namespaceId && "noTabHangInd" == name)
        return (OpenXmlElement) new NoTabHangIndent();
      if (23 == (int) namespaceId && "noLeading" == name)
        return (OpenXmlElement) new NoLeading();
      if (23 == (int) namespaceId && "spaceForUL" == name)
        return (OpenXmlElement) new SpaceForUnderline();
      if (23 == (int) namespaceId && "noColumnBalance" == name)
        return (OpenXmlElement) new NoColumnBalance();
      if (23 == (int) namespaceId && "balanceSingleByteDoubleByteWidth" == name)
        return (OpenXmlElement) new BalanceSingleByteDoubleByteWidth();
      if (23 == (int) namespaceId && "noExtraLineSpacing" == name)
        return (OpenXmlElement) new NoExtraLineSpacing();
      if (23 == (int) namespaceId && "doNotLeaveBackslashAlone" == name)
        return (OpenXmlElement) new DoNotLeaveBackslashAlone();
      if (23 == (int) namespaceId && "ulTrailSpace" == name)
        return (OpenXmlElement) new UnderlineTrailingSpaces();
      if (23 == (int) namespaceId && "doNotExpandShiftReturn" == name)
        return (OpenXmlElement) new DoNotExpandShiftReturn();
      if (23 == (int) namespaceId && "spacingInWholePoints" == name)
        return (OpenXmlElement) new SpacingInWholePoints();
      if (23 == (int) namespaceId && "lineWrapLikeWord6" == name)
        return (OpenXmlElement) new LineWrapLikeWord6();
      if (23 == (int) namespaceId && "printBodyTextBeforeHeader" == name)
        return (OpenXmlElement) new PrintBodyTextBeforeHeader();
      if (23 == (int) namespaceId && "printColBlack" == name)
        return (OpenXmlElement) new PrintColorBlackWhite();
      if (23 == (int) namespaceId && "wpSpaceWidth" == name)
        return (OpenXmlElement) new WordPerfectSpaceWidth();
      if (23 == (int) namespaceId && "showBreaksInFrames" == name)
        return (OpenXmlElement) new ShowBreaksInFrames();
      if (23 == (int) namespaceId && "subFontBySize" == name)
        return (OpenXmlElement) new SubFontBySize();
      if (23 == (int) namespaceId && "suppressBottomSpacing" == name)
        return (OpenXmlElement) new SuppressBottomSpacing();
      if (23 == (int) namespaceId && "suppressTopSpacing" == name)
        return (OpenXmlElement) new SuppressTopSpacing();
      if (23 == (int) namespaceId && "suppressSpacingAtTopOfPage" == name)
        return (OpenXmlElement) new SuppressSpacingAtTopOfPage();
      if (23 == (int) namespaceId && "suppressTopSpacingWP" == name)
        return (OpenXmlElement) new SuppressTopSpacingWordPerfect();
      if (23 == (int) namespaceId && "suppressSpBfAfterPgBrk" == name)
        return (OpenXmlElement) new SuppressSpacingBeforeAfterPageBreak();
      if (23 == (int) namespaceId && "swapBordersFacingPages" == name)
        return (OpenXmlElement) new SwapBordersFacingPages();
      if (23 == (int) namespaceId && "convMailMergeEsc" == name)
        return (OpenXmlElement) new ConvertMailMergeEscape();
      if (23 == (int) namespaceId && "truncateFontHeightsLikeWP6" == name)
        return (OpenXmlElement) new TruncateFontHeightsLikeWordPerfect();
      if (23 == (int) namespaceId && "mwSmallCaps" == name)
        return (OpenXmlElement) new MacWordSmallCaps();
      if (23 == (int) namespaceId && "usePrinterMetrics" == name)
        return (OpenXmlElement) new UsePrinterMetrics();
      if (23 == (int) namespaceId && "doNotSuppressParagraphBorders" == name)
        return (OpenXmlElement) new DoNotSuppressParagraphBorders();
      if (23 == (int) namespaceId && "wrapTrailSpaces" == name)
        return (OpenXmlElement) new WrapTrailSpaces();
      if (23 == (int) namespaceId && "footnoteLayoutLikeWW8" == name)
        return (OpenXmlElement) new FootnoteLayoutLikeWord8();
      if (23 == (int) namespaceId && "shapeLayoutLikeWW8" == name)
        return (OpenXmlElement) new ShapeLayoutLikeWord8();
      if (23 == (int) namespaceId && "alignTablesRowByRow" == name)
        return (OpenXmlElement) new AlignTablesRowByRow();
      if (23 == (int) namespaceId && "forgetLastTabAlignment" == name)
        return (OpenXmlElement) new ForgetLastTabAlignment();
      if (23 == (int) namespaceId && "adjustLineHeightInTable" == name)
        return (OpenXmlElement) new AdjustLineHeightInTable();
      if (23 == (int) namespaceId && "autoSpaceLikeWord95" == name)
        return (OpenXmlElement) new AutoSpaceLikeWord95();
      if (23 == (int) namespaceId && "noSpaceRaiseLower" == name)
        return (OpenXmlElement) new NoSpaceRaiseLower();
      if (23 == (int) namespaceId && "doNotUseHTMLParagraphAutoSpacing" == name)
        return (OpenXmlElement) new DoNotUseHTMLParagraphAutoSpacing();
      if (23 == (int) namespaceId && "layoutRawTableWidth" == name)
        return (OpenXmlElement) new LayoutRawTableWidth();
      if (23 == (int) namespaceId && "layoutTableRowsApart" == name)
        return (OpenXmlElement) new LayoutTableRowsApart();
      if (23 == (int) namespaceId && "useWord97LineBreakRules" == name)
        return (OpenXmlElement) new UseWord97LineBreakRules();
      if (23 == (int) namespaceId && "doNotBreakWrappedTables" == name)
        return (OpenXmlElement) new DoNotBreakWrappedTables();
      if (23 == (int) namespaceId && "doNotSnapToGridInCell" == name)
        return (OpenXmlElement) new DoNotSnapToGridInCell();
      if (23 == (int) namespaceId && "selectFldWithFirstOrLastChar" == name)
        return (OpenXmlElement) new SelectFieldWithFirstOrLastChar();
      if (23 == (int) namespaceId && "applyBreakingRules" == name)
        return (OpenXmlElement) new ApplyBreakingRules();
      if (23 == (int) namespaceId && "doNotWrapTextWithPunct" == name)
        return (OpenXmlElement) new DoNotWrapTextWithPunctuation();
      if (23 == (int) namespaceId && "doNotUseEastAsianBreakRules" == name)
        return (OpenXmlElement) new DoNotUseEastAsianBreakRules();
      if (23 == (int) namespaceId && "useWord2002TableStyleRules" == name)
        return (OpenXmlElement) new UseWord2002TableStyleRules();
      if (23 == (int) namespaceId && "growAutofit" == name)
        return (OpenXmlElement) new GrowAutofit();
      if (23 == (int) namespaceId && "useFELayout" == name)
        return (OpenXmlElement) new UseFarEastLayout();
      if (23 == (int) namespaceId && "useNormalStyleForList" == name)
        return (OpenXmlElement) new UseNormalStyleForList();
      if (23 == (int) namespaceId && "doNotUseIndentAsNumberingTabStop" == name)
        return (OpenXmlElement) new DoNotUseIndentAsNumberingTabStop();
      if (23 == (int) namespaceId && "useAltKinsokuLineBreakRules" == name)
        return (OpenXmlElement) new UseAltKinsokuLineBreakRules();
      if (23 == (int) namespaceId && "allowSpaceOfSameStyleInTable" == name)
        return (OpenXmlElement) new AllowSpaceOfSameStyleInTable();
      if (23 == (int) namespaceId && "doNotSuppressIndentation" == name)
        return (OpenXmlElement) new DoNotSuppressIndentation();
      if (23 == (int) namespaceId && "doNotAutofitConstrainedTables" == name)
        return (OpenXmlElement) new DoNotAutofitConstrainedTables();
      if (23 == (int) namespaceId && "autofitToFirstFixedWidthCell" == name)
        return (OpenXmlElement) new AutofitToFirstFixedWidthCell();
      if (23 == (int) namespaceId && "underlineTabInNumList" == name)
        return (OpenXmlElement) new UnderlineTabInNumberingList();
      if (23 == (int) namespaceId && "displayHangulFixedWidth" == name)
        return (OpenXmlElement) new DisplayHangulFixedWidth();
      if (23 == (int) namespaceId && "splitPgBreakAndParaMark" == name)
        return (OpenXmlElement) new SplitPageBreakAndParagraphMark();
      if (23 == (int) namespaceId && "doNotVertAlignCellWithSp" == name)
        return (OpenXmlElement) new DoNotVerticallyAlignCellWithShape();
      if (23 == (int) namespaceId && "doNotBreakConstrainedForcedTable" == name)
        return (OpenXmlElement) new DoNotBreakConstrainedForcedTable();
      if (23 == (int) namespaceId && "doNotVertAlignInTxbx" == name)
        return (OpenXmlElement) new DoNotVerticallyAlignInTextBox();
      if (23 == (int) namespaceId && "useAnsiKerningPairs" == name)
        return (OpenXmlElement) new UseAnsiKerningPairs();
      if (23 == (int) namespaceId && "cachedColBalance" == name)
        return (OpenXmlElement) new CachedColumnBalance();
      if (23 == (int) namespaceId && "compatSetting" == name)
        return (OpenXmlElement) new CompatibilitySetting();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Compatibility.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Compatibility.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public UseSingleBorderForContiguousCells UseSingleBorderForContiguousCells
    {
      get
      {
        return this.GetElement<UseSingleBorderForContiguousCells>(0);
      }
      set
      {
        this.SetElement<UseSingleBorderForContiguousCells>(0, value);
      }
    }

    public WordPerfectJustification WordPerfectJustification
    {
      get
      {
        return this.GetElement<WordPerfectJustification>(1);
      }
      set
      {
        this.SetElement<WordPerfectJustification>(1, value);
      }
    }

    public NoTabHangIndent NoTabHangIndent
    {
      get
      {
        return this.GetElement<NoTabHangIndent>(2);
      }
      set
      {
        this.SetElement<NoTabHangIndent>(2, value);
      }
    }

    public NoLeading NoLeading
    {
      get
      {
        return this.GetElement<NoLeading>(3);
      }
      set
      {
        this.SetElement<NoLeading>(3, value);
      }
    }

    public SpaceForUnderline SpaceForUnderline
    {
      get
      {
        return this.GetElement<SpaceForUnderline>(4);
      }
      set
      {
        this.SetElement<SpaceForUnderline>(4, value);
      }
    }

    public NoColumnBalance NoColumnBalance
    {
      get
      {
        return this.GetElement<NoColumnBalance>(5);
      }
      set
      {
        this.SetElement<NoColumnBalance>(5, value);
      }
    }

    public BalanceSingleByteDoubleByteWidth BalanceSingleByteDoubleByteWidth
    {
      get
      {
        return this.GetElement<BalanceSingleByteDoubleByteWidth>(6);
      }
      set
      {
        this.SetElement<BalanceSingleByteDoubleByteWidth>(6, value);
      }
    }

    public NoExtraLineSpacing NoExtraLineSpacing
    {
      get
      {
        return this.GetElement<NoExtraLineSpacing>(7);
      }
      set
      {
        this.SetElement<NoExtraLineSpacing>(7, value);
      }
    }

    public DoNotLeaveBackslashAlone DoNotLeaveBackslashAlone
    {
      get
      {
        return this.GetElement<DoNotLeaveBackslashAlone>(8);
      }
      set
      {
        this.SetElement<DoNotLeaveBackslashAlone>(8, value);
      }
    }

    public UnderlineTrailingSpaces UnderlineTrailingSpaces
    {
      get
      {
        return this.GetElement<UnderlineTrailingSpaces>(9);
      }
      set
      {
        this.SetElement<UnderlineTrailingSpaces>(9, value);
      }
    }

    public DoNotExpandShiftReturn DoNotExpandShiftReturn
    {
      get
      {
        return this.GetElement<DoNotExpandShiftReturn>(10);
      }
      set
      {
        this.SetElement<DoNotExpandShiftReturn>(10, value);
      }
    }

    public SpacingInWholePoints SpacingInWholePoints
    {
      get
      {
        return this.GetElement<SpacingInWholePoints>(11);
      }
      set
      {
        this.SetElement<SpacingInWholePoints>(11, value);
      }
    }

    public LineWrapLikeWord6 LineWrapLikeWord6
    {
      get
      {
        return this.GetElement<LineWrapLikeWord6>(12);
      }
      set
      {
        this.SetElement<LineWrapLikeWord6>(12, value);
      }
    }

    public PrintBodyTextBeforeHeader PrintBodyTextBeforeHeader
    {
      get
      {
        return this.GetElement<PrintBodyTextBeforeHeader>(13);
      }
      set
      {
        this.SetElement<PrintBodyTextBeforeHeader>(13, value);
      }
    }

    public PrintColorBlackWhite PrintColorBlackWhite
    {
      get
      {
        return this.GetElement<PrintColorBlackWhite>(14);
      }
      set
      {
        this.SetElement<PrintColorBlackWhite>(14, value);
      }
    }

    public WordPerfectSpaceWidth WordPerfectSpaceWidth
    {
      get
      {
        return this.GetElement<WordPerfectSpaceWidth>(15);
      }
      set
      {
        this.SetElement<WordPerfectSpaceWidth>(15, value);
      }
    }

    public ShowBreaksInFrames ShowBreaksInFrames
    {
      get
      {
        return this.GetElement<ShowBreaksInFrames>(16);
      }
      set
      {
        this.SetElement<ShowBreaksInFrames>(16, value);
      }
    }

    public SubFontBySize SubFontBySize
    {
      get
      {
        return this.GetElement<SubFontBySize>(17);
      }
      set
      {
        this.SetElement<SubFontBySize>(17, value);
      }
    }

    public SuppressBottomSpacing SuppressBottomSpacing
    {
      get
      {
        return this.GetElement<SuppressBottomSpacing>(18);
      }
      set
      {
        this.SetElement<SuppressBottomSpacing>(18, value);
      }
    }

    public SuppressTopSpacing SuppressTopSpacing
    {
      get
      {
        return this.GetElement<SuppressTopSpacing>(19);
      }
      set
      {
        this.SetElement<SuppressTopSpacing>(19, value);
      }
    }

    public SuppressSpacingAtTopOfPage SuppressSpacingAtTopOfPage
    {
      get
      {
        return this.GetElement<SuppressSpacingAtTopOfPage>(20);
      }
      set
      {
        this.SetElement<SuppressSpacingAtTopOfPage>(20, value);
      }
    }

    public SuppressTopSpacingWordPerfect SuppressTopSpacingWordPerfect
    {
      get
      {
        return this.GetElement<SuppressTopSpacingWordPerfect>(21);
      }
      set
      {
        this.SetElement<SuppressTopSpacingWordPerfect>(21, value);
      }
    }

    public SuppressSpacingBeforeAfterPageBreak SuppressSpacingBeforeAfterPageBreak
    {
      get
      {
        return this.GetElement<SuppressSpacingBeforeAfterPageBreak>(22);
      }
      set
      {
        this.SetElement<SuppressSpacingBeforeAfterPageBreak>(22, value);
      }
    }

    public SwapBordersFacingPages SwapBordersFacingPages
    {
      get
      {
        return this.GetElement<SwapBordersFacingPages>(23);
      }
      set
      {
        this.SetElement<SwapBordersFacingPages>(23, value);
      }
    }

    public ConvertMailMergeEscape ConvertMailMergeEscape
    {
      get
      {
        return this.GetElement<ConvertMailMergeEscape>(24);
      }
      set
      {
        this.SetElement<ConvertMailMergeEscape>(24, value);
      }
    }

    public TruncateFontHeightsLikeWordPerfect TruncateFontHeightsLikeWordPerfect
    {
      get
      {
        return this.GetElement<TruncateFontHeightsLikeWordPerfect>(25);
      }
      set
      {
        this.SetElement<TruncateFontHeightsLikeWordPerfect>(25, value);
      }
    }

    public MacWordSmallCaps MacWordSmallCaps
    {
      get
      {
        return this.GetElement<MacWordSmallCaps>(26);
      }
      set
      {
        this.SetElement<MacWordSmallCaps>(26, value);
      }
    }

    public UsePrinterMetrics UsePrinterMetrics
    {
      get
      {
        return this.GetElement<UsePrinterMetrics>(27);
      }
      set
      {
        this.SetElement<UsePrinterMetrics>(27, value);
      }
    }

    public DoNotSuppressParagraphBorders DoNotSuppressParagraphBorders
    {
      get
      {
        return this.GetElement<DoNotSuppressParagraphBorders>(28);
      }
      set
      {
        this.SetElement<DoNotSuppressParagraphBorders>(28, value);
      }
    }

    public WrapTrailSpaces WrapTrailSpaces
    {
      get
      {
        return this.GetElement<WrapTrailSpaces>(29);
      }
      set
      {
        this.SetElement<WrapTrailSpaces>(29, value);
      }
    }

    public FootnoteLayoutLikeWord8 FootnoteLayoutLikeWord8
    {
      get
      {
        return this.GetElement<FootnoteLayoutLikeWord8>(30);
      }
      set
      {
        this.SetElement<FootnoteLayoutLikeWord8>(30, value);
      }
    }

    public ShapeLayoutLikeWord8 ShapeLayoutLikeWord8
    {
      get
      {
        return this.GetElement<ShapeLayoutLikeWord8>(31);
      }
      set
      {
        this.SetElement<ShapeLayoutLikeWord8>(31, value);
      }
    }

    public AlignTablesRowByRow AlignTablesRowByRow
    {
      get
      {
        return this.GetElement<AlignTablesRowByRow>(32);
      }
      set
      {
        this.SetElement<AlignTablesRowByRow>(32, value);
      }
    }

    public ForgetLastTabAlignment ForgetLastTabAlignment
    {
      get
      {
        return this.GetElement<ForgetLastTabAlignment>(33);
      }
      set
      {
        this.SetElement<ForgetLastTabAlignment>(33, value);
      }
    }

    public AdjustLineHeightInTable AdjustLineHeightInTable
    {
      get
      {
        return this.GetElement<AdjustLineHeightInTable>(34);
      }
      set
      {
        this.SetElement<AdjustLineHeightInTable>(34, value);
      }
    }

    public AutoSpaceLikeWord95 AutoSpaceLikeWord95
    {
      get
      {
        return this.GetElement<AutoSpaceLikeWord95>(35);
      }
      set
      {
        this.SetElement<AutoSpaceLikeWord95>(35, value);
      }
    }

    public NoSpaceRaiseLower NoSpaceRaiseLower
    {
      get
      {
        return this.GetElement<NoSpaceRaiseLower>(36);
      }
      set
      {
        this.SetElement<NoSpaceRaiseLower>(36, value);
      }
    }

    public DoNotUseHTMLParagraphAutoSpacing DoNotUseHTMLParagraphAutoSpacing
    {
      get
      {
        return this.GetElement<DoNotUseHTMLParagraphAutoSpacing>(37);
      }
      set
      {
        this.SetElement<DoNotUseHTMLParagraphAutoSpacing>(37, value);
      }
    }

    public LayoutRawTableWidth LayoutRawTableWidth
    {
      get
      {
        return this.GetElement<LayoutRawTableWidth>(38);
      }
      set
      {
        this.SetElement<LayoutRawTableWidth>(38, value);
      }
    }

    public LayoutTableRowsApart LayoutTableRowsApart
    {
      get
      {
        return this.GetElement<LayoutTableRowsApart>(39);
      }
      set
      {
        this.SetElement<LayoutTableRowsApart>(39, value);
      }
    }

    public UseWord97LineBreakRules UseWord97LineBreakRules
    {
      get
      {
        return this.GetElement<UseWord97LineBreakRules>(40);
      }
      set
      {
        this.SetElement<UseWord97LineBreakRules>(40, value);
      }
    }

    public DoNotBreakWrappedTables DoNotBreakWrappedTables
    {
      get
      {
        return this.GetElement<DoNotBreakWrappedTables>(41);
      }
      set
      {
        this.SetElement<DoNotBreakWrappedTables>(41, value);
      }
    }

    public DoNotSnapToGridInCell DoNotSnapToGridInCell
    {
      get
      {
        return this.GetElement<DoNotSnapToGridInCell>(42);
      }
      set
      {
        this.SetElement<DoNotSnapToGridInCell>(42, value);
      }
    }

    public SelectFieldWithFirstOrLastChar SelectFieldWithFirstOrLastChar
    {
      get
      {
        return this.GetElement<SelectFieldWithFirstOrLastChar>(43);
      }
      set
      {
        this.SetElement<SelectFieldWithFirstOrLastChar>(43, value);
      }
    }

    public ApplyBreakingRules ApplyBreakingRules
    {
      get
      {
        return this.GetElement<ApplyBreakingRules>(44);
      }
      set
      {
        this.SetElement<ApplyBreakingRules>(44, value);
      }
    }

    public DoNotWrapTextWithPunctuation DoNotWrapTextWithPunctuation
    {
      get
      {
        return this.GetElement<DoNotWrapTextWithPunctuation>(45);
      }
      set
      {
        this.SetElement<DoNotWrapTextWithPunctuation>(45, value);
      }
    }

    public DoNotUseEastAsianBreakRules DoNotUseEastAsianBreakRules
    {
      get
      {
        return this.GetElement<DoNotUseEastAsianBreakRules>(46);
      }
      set
      {
        this.SetElement<DoNotUseEastAsianBreakRules>(46, value);
      }
    }

    public UseWord2002TableStyleRules UseWord2002TableStyleRules
    {
      get
      {
        return this.GetElement<UseWord2002TableStyleRules>(47);
      }
      set
      {
        this.SetElement<UseWord2002TableStyleRules>(47, value);
      }
    }

    public GrowAutofit GrowAutofit
    {
      get
      {
        return this.GetElement<GrowAutofit>(48);
      }
      set
      {
        this.SetElement<GrowAutofit>(48, value);
      }
    }

    public UseFarEastLayout UseFarEastLayout
    {
      get
      {
        return this.GetElement<UseFarEastLayout>(49);
      }
      set
      {
        this.SetElement<UseFarEastLayout>(49, value);
      }
    }

    public UseNormalStyleForList UseNormalStyleForList
    {
      get
      {
        return this.GetElement<UseNormalStyleForList>(50);
      }
      set
      {
        this.SetElement<UseNormalStyleForList>(50, value);
      }
    }

    public DoNotUseIndentAsNumberingTabStop DoNotUseIndentAsNumberingTabStop
    {
      get
      {
        return this.GetElement<DoNotUseIndentAsNumberingTabStop>(51);
      }
      set
      {
        this.SetElement<DoNotUseIndentAsNumberingTabStop>(51, value);
      }
    }

    public UseAltKinsokuLineBreakRules UseAltKinsokuLineBreakRules
    {
      get
      {
        return this.GetElement<UseAltKinsokuLineBreakRules>(52);
      }
      set
      {
        this.SetElement<UseAltKinsokuLineBreakRules>(52, value);
      }
    }

    public AllowSpaceOfSameStyleInTable AllowSpaceOfSameStyleInTable
    {
      get
      {
        return this.GetElement<AllowSpaceOfSameStyleInTable>(53);
      }
      set
      {
        this.SetElement<AllowSpaceOfSameStyleInTable>(53, value);
      }
    }

    public DoNotSuppressIndentation DoNotSuppressIndentation
    {
      get
      {
        return this.GetElement<DoNotSuppressIndentation>(54);
      }
      set
      {
        this.SetElement<DoNotSuppressIndentation>(54, value);
      }
    }

    public DoNotAutofitConstrainedTables DoNotAutofitConstrainedTables
    {
      get
      {
        return this.GetElement<DoNotAutofitConstrainedTables>(55);
      }
      set
      {
        this.SetElement<DoNotAutofitConstrainedTables>(55, value);
      }
    }

    public AutofitToFirstFixedWidthCell AutofitToFirstFixedWidthCell
    {
      get
      {
        return this.GetElement<AutofitToFirstFixedWidthCell>(56);
      }
      set
      {
        this.SetElement<AutofitToFirstFixedWidthCell>(56, value);
      }
    }

    public UnderlineTabInNumberingList UnderlineTabInNumberingList
    {
      get
      {
        return this.GetElement<UnderlineTabInNumberingList>(57);
      }
      set
      {
        this.SetElement<UnderlineTabInNumberingList>(57, value);
      }
    }

    public DisplayHangulFixedWidth DisplayHangulFixedWidth
    {
      get
      {
        return this.GetElement<DisplayHangulFixedWidth>(58);
      }
      set
      {
        this.SetElement<DisplayHangulFixedWidth>(58, value);
      }
    }

    public SplitPageBreakAndParagraphMark SplitPageBreakAndParagraphMark
    {
      get
      {
        return this.GetElement<SplitPageBreakAndParagraphMark>(59);
      }
      set
      {
        this.SetElement<SplitPageBreakAndParagraphMark>(59, value);
      }
    }

    public DoNotVerticallyAlignCellWithShape DoNotVerticallyAlignCellWithShape
    {
      get
      {
        return this.GetElement<DoNotVerticallyAlignCellWithShape>(60);
      }
      set
      {
        this.SetElement<DoNotVerticallyAlignCellWithShape>(60, value);
      }
    }

    public DoNotBreakConstrainedForcedTable DoNotBreakConstrainedForcedTable
    {
      get
      {
        return this.GetElement<DoNotBreakConstrainedForcedTable>(61);
      }
      set
      {
        this.SetElement<DoNotBreakConstrainedForcedTable>(61, value);
      }
    }

    public DoNotVerticallyAlignInTextBox DoNotVerticallyAlignInTextBox
    {
      get
      {
        return this.GetElement<DoNotVerticallyAlignInTextBox>(62);
      }
      set
      {
        this.SetElement<DoNotVerticallyAlignInTextBox>(62, value);
      }
    }

    public UseAnsiKerningPairs UseAnsiKerningPairs
    {
      get
      {
        return this.GetElement<UseAnsiKerningPairs>(63);
      }
      set
      {
        this.SetElement<UseAnsiKerningPairs>(63, value);
      }
    }

    public CachedColumnBalance CachedColumnBalance
    {
      get
      {
        return this.GetElement<CachedColumnBalance>(64);
      }
      set
      {
        this.SetElement<CachedColumnBalance>(64, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Compatibility>(deep);
    }
  }
}

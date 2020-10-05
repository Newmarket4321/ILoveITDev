// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLPageSetup
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System.Collections.Generic;

namespace ClosedXML.Excel
{
  public interface IXLPageSetup
  {
    IXLPrintAreas PrintAreas { get; }

    int FirstRowToRepeatAtTop { get; }

    int LastRowToRepeatAtTop { get; }

    void SetRowsToRepeatAtTop(string range);

    void SetRowsToRepeatAtTop(int firstRowToRepeatAtTop, int lastRowToRepeatAtTop);

    int FirstColumnToRepeatAtLeft { get; }

    int LastColumnToRepeatAtLeft { get; }

    void SetColumnsToRepeatAtLeft(int firstColumnToRepeatAtLeft, int lastColumnToRepeatAtLeft);

    void SetColumnsToRepeatAtLeft(string range);

    XLPageOrientation PageOrientation { get; set; }

    int PagesWide { get; set; }

    int PagesTall { get; set; }

    int Scale { get; set; }

    int HorizontalDpi { get; set; }

    int VerticalDpi { get; set; }

    long FirstPageNumber { get; set; }

    bool CenterHorizontally { get; set; }

    bool CenterVertically { get; set; }

    void AdjustTo(int pctOfNormalSize);

    void FitToPages(int pagesWide, int pagesTall);

    XLPaperSize PaperSize { get; set; }

    IXLMargins Margins { get; }

    IXLHeaderFooter Header { get; }

    IXLHeaderFooter Footer { get; }

    bool ScaleHFWithDocument { get; set; }

    bool AlignHFWithMargins { get; set; }

    bool ShowGridlines { get; set; }

    bool ShowRowAndColumnHeadings { get; set; }

    bool BlackAndWhite { get; set; }

    bool DraftQuality { get; set; }

    XLPageOrderValues PageOrder { get; set; }

    XLShowCommentsValues ShowComments { get; set; }

    List<int> RowBreaks { get; }

    List<int> ColumnBreaks { get; }

    void AddHorizontalPageBreak(int row);

    void AddVerticalPageBreak(int column);

    XLPrintErrorValues PrintErrorValue { get; set; }

    IXLPageSetup SetPageOrientation(XLPageOrientation value);

    IXLPageSetup SetPagesWide(int value);

    IXLPageSetup SetPagesTall(int value);

    IXLPageSetup SetScale(int value);

    IXLPageSetup SetHorizontalDpi(int value);

    IXLPageSetup SetVerticalDpi(int value);

    IXLPageSetup SetFirstPageNumber(long value);

    IXLPageSetup SetCenterHorizontally();

    IXLPageSetup SetCenterHorizontally(bool value);

    IXLPageSetup SetCenterVertically();

    IXLPageSetup SetCenterVertically(bool value);

    IXLPageSetup SetPaperSize(XLPaperSize value);

    IXLPageSetup SetScaleHFWithDocument();

    IXLPageSetup SetScaleHFWithDocument(bool value);

    IXLPageSetup SetAlignHFWithMargins();

    IXLPageSetup SetAlignHFWithMargins(bool value);

    IXLPageSetup SetShowGridlines();

    IXLPageSetup SetShowGridlines(bool value);

    IXLPageSetup SetShowRowAndColumnHeadings();

    IXLPageSetup SetShowRowAndColumnHeadings(bool value);

    IXLPageSetup SetBlackAndWhite();

    IXLPageSetup SetBlackAndWhite(bool value);

    IXLPageSetup SetDraftQuality();

    IXLPageSetup SetDraftQuality(bool value);

    IXLPageSetup SetPageOrder(XLPageOrderValues value);

    IXLPageSetup SetShowComments(XLShowCommentsValues value);

    IXLPageSetup SetPrintErrorValue(XLPrintErrorValues value);

    bool DifferentFirstPageOnHF { get; set; }

    IXLPageSetup SetDifferentFirstPageOnHF();

    IXLPageSetup SetDifferentFirstPageOnHF(bool value);

    bool DifferentOddEvenPagesOnHF { get; set; }

    IXLPageSetup SetDifferentOddEvenPagesOnHF();

    IXLPageSetup SetDifferentOddEvenPagesOnHF(bool value);
  }
}

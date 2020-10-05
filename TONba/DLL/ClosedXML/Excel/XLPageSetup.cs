// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLPageSetup
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace ClosedXML.Excel
{
  internal class XLPageSetup : IXLPageSetup
  {
    private int _pagesWide;
    private int _pagesTall;
    private int _scale;

    public XLPageSetup(XLPageSetup defaultPageOptions, XLWorksheet worksheet)
    {
      if (defaultPageOptions != null)
      {
        this.PrintAreas = (IXLPrintAreas) new XLPrintAreas(defaultPageOptions.PrintAreas as XLPrintAreas, worksheet);
        this.CenterHorizontally = defaultPageOptions.CenterHorizontally;
        this.CenterVertically = defaultPageOptions.CenterVertically;
        this.FirstPageNumber = defaultPageOptions.FirstPageNumber;
        this.HorizontalDpi = defaultPageOptions.HorizontalDpi;
        this.PageOrientation = defaultPageOptions.PageOrientation;
        this.VerticalDpi = defaultPageOptions.VerticalDpi;
        this.PaperSize = defaultPageOptions.PaperSize;
        this._pagesTall = defaultPageOptions.PagesTall;
        this._pagesWide = defaultPageOptions.PagesWide;
        this._scale = defaultPageOptions.Scale;
        if (defaultPageOptions.Margins != null)
          this.Margins = (IXLMargins) new XLMargins()
          {
            Top = defaultPageOptions.Margins.Top,
            Bottom = defaultPageOptions.Margins.Bottom,
            Left = defaultPageOptions.Margins.Left,
            Right = defaultPageOptions.Margins.Right,
            Header = defaultPageOptions.Margins.Header,
            Footer = defaultPageOptions.Margins.Footer
          };
        this.AlignHFWithMargins = defaultPageOptions.AlignHFWithMargins;
        this.ScaleHFWithDocument = defaultPageOptions.ScaleHFWithDocument;
        this.ShowGridlines = defaultPageOptions.ShowGridlines;
        this.ShowRowAndColumnHeadings = defaultPageOptions.ShowRowAndColumnHeadings;
        this.BlackAndWhite = defaultPageOptions.BlackAndWhite;
        this.DraftQuality = defaultPageOptions.DraftQuality;
        this.PageOrder = defaultPageOptions.PageOrder;
        this.ColumnBreaks = defaultPageOptions.ColumnBreaks.ToList<int>();
        this.RowBreaks = defaultPageOptions.RowBreaks.ToList<int>();
        this.Header = (IXLHeaderFooter) new XLHeaderFooter(defaultPageOptions.Header as XLHeaderFooter, worksheet);
        this.Footer = (IXLHeaderFooter) new XLHeaderFooter(defaultPageOptions.Footer as XLHeaderFooter, worksheet);
        this.PrintErrorValue = defaultPageOptions.PrintErrorValue;
      }
      else
      {
        this.PrintAreas = (IXLPrintAreas) new XLPrintAreas(worksheet);
        this.Header = (IXLHeaderFooter) new XLHeaderFooter(worksheet);
        this.Footer = (IXLHeaderFooter) new XLHeaderFooter(worksheet);
        this.ColumnBreaks = new List<int>();
        this.RowBreaks = new List<int>();
      }
    }

    public IXLPrintAreas PrintAreas { get; private set; }

    public int FirstRowToRepeatAtTop { get; private set; }

    public int LastRowToRepeatAtTop { get; private set; }

    public void SetRowsToRepeatAtTop(string range)
    {
      string[] strArray = range.Replace("$", "").Split(':');
      this.SetRowsToRepeatAtTop(int.Parse(strArray[0]), int.Parse(strArray[1]));
    }

    public void SetRowsToRepeatAtTop(int firstRowToRepeatAtTop, int lastRowToRepeatAtTop)
    {
      if (firstRowToRepeatAtTop <= 0)
        throw new ArgumentOutOfRangeException("The first row has to be greater than zero.");
      if (firstRowToRepeatAtTop > lastRowToRepeatAtTop)
        throw new ArgumentOutOfRangeException("The first row has to be less than the second row.");
      this.FirstRowToRepeatAtTop = firstRowToRepeatAtTop;
      this.LastRowToRepeatAtTop = lastRowToRepeatAtTop;
    }

    public int FirstColumnToRepeatAtLeft { get; private set; }

    public int LastColumnToRepeatAtLeft { get; private set; }

    public void SetColumnsToRepeatAtLeft(string range)
    {
      string[] strArray = range.Replace("$", "").Split(':');
      int result;
      if (int.TryParse(strArray[0], out result))
        this.SetColumnsToRepeatAtLeft(int.Parse(strArray[0]), int.Parse(strArray[1]));
      else
        this.SetColumnsToRepeatAtLeft(strArray[0], strArray[1]);
    }

    public void SetColumnsToRepeatAtLeft(string firstColumnToRepeatAtLeft, string lastColumnToRepeatAtLeft)
    {
      this.SetColumnsToRepeatAtLeft(XLHelper.GetColumnNumberFromLetter(firstColumnToRepeatAtLeft), XLHelper.GetColumnNumberFromLetter(lastColumnToRepeatAtLeft));
    }

    public void SetColumnsToRepeatAtLeft(int firstColumnToRepeatAtLeft, int lastColumnToRepeatAtLeft)
    {
      if (firstColumnToRepeatAtLeft <= 0)
        throw new ArgumentOutOfRangeException("The first column has to be greater than zero.");
      if (firstColumnToRepeatAtLeft > lastColumnToRepeatAtLeft)
        throw new ArgumentOutOfRangeException("The first column has to be less than the second column.");
      this.FirstColumnToRepeatAtLeft = firstColumnToRepeatAtLeft;
      this.LastColumnToRepeatAtLeft = lastColumnToRepeatAtLeft;
    }

    public XLPageOrientation PageOrientation { get; set; }

    public XLPaperSize PaperSize { get; set; }

    public int HorizontalDpi { get; set; }

    public int VerticalDpi { get; set; }

    public long FirstPageNumber { get; set; }

    public bool CenterHorizontally { get; set; }

    public bool CenterVertically { get; set; }

    public XLPrintErrorValues PrintErrorValue { get; set; }

    public IXLMargins Margins { get; set; }

    public int PagesWide
    {
      get
      {
        return this._pagesWide;
      }
      set
      {
        this._pagesWide = value;
        if (this._pagesWide <= 0)
          return;
        this._scale = 0;
      }
    }

    public int PagesTall
    {
      get
      {
        return this._pagesTall;
      }
      set
      {
        this._pagesTall = value;
        if (this._pagesTall <= 0)
          return;
        this._scale = 0;
      }
    }

    public int Scale
    {
      get
      {
        return this._scale;
      }
      set
      {
        this._scale = value;
        if (this._scale <= 0)
          return;
        this._pagesTall = 0;
        this._pagesWide = 0;
      }
    }

    public void AdjustTo(int pctOfNormalSize)
    {
      this.Scale = pctOfNormalSize;
      this._pagesWide = 0;
      this._pagesTall = 0;
    }

    public void FitToPages(int pagesWide, int pagesTall)
    {
      this._pagesWide = pagesWide;
      this._pagesTall = pagesTall;
      this._scale = 0;
    }

    public IXLHeaderFooter Header { get; private set; }

    public IXLHeaderFooter Footer { get; private set; }

    public bool ScaleHFWithDocument { get; set; }

    public bool AlignHFWithMargins { get; set; }

    public bool ShowGridlines { get; set; }

    public bool ShowRowAndColumnHeadings { get; set; }

    public bool BlackAndWhite { get; set; }

    public bool DraftQuality { get; set; }

    public XLPageOrderValues PageOrder { get; set; }

    public XLShowCommentsValues ShowComments { get; set; }

    public List<int> RowBreaks { get; private set; }

    public List<int> ColumnBreaks { get; private set; }

    public void AddHorizontalPageBreak(int row)
    {
      if (this.RowBreaks.Contains(row))
        return;
      this.RowBreaks.Add(row);
    }

    public void AddVerticalPageBreak(int column)
    {
      if (this.ColumnBreaks.Contains(column))
        return;
      this.ColumnBreaks.Add(column);
    }

    public IXLPageSetup SetPageOrientation(XLPageOrientation value)
    {
      this.PageOrientation = value;
      return (IXLPageSetup) this;
    }

    public IXLPageSetup SetPagesWide(int value)
    {
      this.PagesWide = value;
      return (IXLPageSetup) this;
    }

    public IXLPageSetup SetPagesTall(int value)
    {
      this.PagesTall = value;
      return (IXLPageSetup) this;
    }

    public IXLPageSetup SetScale(int value)
    {
      this.Scale = value;
      return (IXLPageSetup) this;
    }

    public IXLPageSetup SetHorizontalDpi(int value)
    {
      this.HorizontalDpi = value;
      return (IXLPageSetup) this;
    }

    public IXLPageSetup SetVerticalDpi(int value)
    {
      this.VerticalDpi = value;
      return (IXLPageSetup) this;
    }

    public IXLPageSetup SetFirstPageNumber(long value)
    {
      this.FirstPageNumber = value;
      return (IXLPageSetup) this;
    }

    public IXLPageSetup SetCenterHorizontally()
    {
      this.CenterHorizontally = true;
      return (IXLPageSetup) this;
    }

    public IXLPageSetup SetCenterHorizontally(bool value)
    {
      this.CenterHorizontally = value;
      return (IXLPageSetup) this;
    }

    public IXLPageSetup SetCenterVertically()
    {
      this.CenterVertically = true;
      return (IXLPageSetup) this;
    }

    public IXLPageSetup SetCenterVertically(bool value)
    {
      this.CenterVertically = value;
      return (IXLPageSetup) this;
    }

    public IXLPageSetup SetPaperSize(XLPaperSize value)
    {
      this.PaperSize = value;
      return (IXLPageSetup) this;
    }

    public IXLPageSetup SetScaleHFWithDocument()
    {
      this.ScaleHFWithDocument = true;
      return (IXLPageSetup) this;
    }

    public IXLPageSetup SetScaleHFWithDocument(bool value)
    {
      this.ScaleHFWithDocument = value;
      return (IXLPageSetup) this;
    }

    public IXLPageSetup SetAlignHFWithMargins()
    {
      this.AlignHFWithMargins = true;
      return (IXLPageSetup) this;
    }

    public IXLPageSetup SetAlignHFWithMargins(bool value)
    {
      this.AlignHFWithMargins = value;
      return (IXLPageSetup) this;
    }

    public IXLPageSetup SetShowGridlines()
    {
      this.ShowGridlines = true;
      return (IXLPageSetup) this;
    }

    public IXLPageSetup SetShowGridlines(bool value)
    {
      this.ShowGridlines = value;
      return (IXLPageSetup) this;
    }

    public IXLPageSetup SetShowRowAndColumnHeadings()
    {
      this.ShowRowAndColumnHeadings = true;
      return (IXLPageSetup) this;
    }

    public IXLPageSetup SetShowRowAndColumnHeadings(bool value)
    {
      this.ShowRowAndColumnHeadings = value;
      return (IXLPageSetup) this;
    }

    public IXLPageSetup SetBlackAndWhite()
    {
      this.BlackAndWhite = true;
      return (IXLPageSetup) this;
    }

    public IXLPageSetup SetBlackAndWhite(bool value)
    {
      this.BlackAndWhite = value;
      return (IXLPageSetup) this;
    }

    public IXLPageSetup SetDraftQuality()
    {
      this.DraftQuality = true;
      return (IXLPageSetup) this;
    }

    public IXLPageSetup SetDraftQuality(bool value)
    {
      this.DraftQuality = value;
      return (IXLPageSetup) this;
    }

    public IXLPageSetup SetPageOrder(XLPageOrderValues value)
    {
      this.PageOrder = value;
      return (IXLPageSetup) this;
    }

    public IXLPageSetup SetShowComments(XLShowCommentsValues value)
    {
      this.ShowComments = value;
      return (IXLPageSetup) this;
    }

    public IXLPageSetup SetPrintErrorValue(XLPrintErrorValues value)
    {
      this.PrintErrorValue = value;
      return (IXLPageSetup) this;
    }

    public bool DifferentFirstPageOnHF { get; set; }

    public IXLPageSetup SetDifferentFirstPageOnHF()
    {
      return this.SetDifferentFirstPageOnHF(true);
    }

    public IXLPageSetup SetDifferentFirstPageOnHF(bool value)
    {
      this.DifferentFirstPageOnHF = value;
      return (IXLPageSetup) this;
    }

    public bool DifferentOddEvenPagesOnHF { get; set; }

    public IXLPageSetup SetDifferentOddEvenPagesOnHF()
    {
      return this.SetDifferentOddEvenPagesOnHF(true);
    }

    public IXLPageSetup SetDifferentOddEvenPagesOnHF(bool value)
    {
      this.DifferentOddEvenPagesOnHF = value;
      return (IXLPageSetup) this;
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLRangeBase
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using ClosedXML.Excel.Misc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClosedXML.Excel
{
  internal abstract class XLRangeBase : IXLRangeBase, IDisposable, IXLStylized
  {
    private IXLStyle _style;
    private XLSortElements _sortRows;
    private XLSortElements _sortColumns;
    private int _styleCacheId;
    private static int IdCounter;
    private readonly int Id;
    private XLCallbackAction _shiftedRowsAction;
    private XLCallbackAction _shiftedColumnsAction;
    private XLRangeAddress _rangeAddress;

    public bool StyleChanged { get; set; }

    protected void SetStyle(IXLStyle styleToUse)
    {
      this._styleCacheId = this.Worksheet.Workbook.GetStyleId(styleToUse);
      this._style = (IXLStyle) null;
      this.StyleChanged = false;
    }

    protected void SetStyle(int styleId)
    {
      this._styleCacheId = styleId;
      this._style = (IXLStyle) null;
      this.StyleChanged = false;
    }

    public int GetStyleId()
    {
      if (this.StyleChanged)
        this.SetStyle(this.Style);
      return this._styleCacheId;
    }

    protected IXLStyle GetStyle()
    {
      return this._style ?? (this._style = (IXLStyle) new XLStyle((IXLStylized) this, this.Worksheet.Workbook.GetStyleById(this._styleCacheId), true));
    }

    protected XLRangeBase(XLRangeAddress rangeAddress)
    {
      this.Id = ++XLRangeBase.IdCounter;
      this.RangeAddress = new XLRangeAddress(rangeAddress);
    }

    protected void SubscribeToShiftedRows(Action<XLRange, int> action)
    {
      if (this.Worksheet == null || !this.Worksheet.EventTrackingEnabled)
        return;
      this._shiftedRowsAction = new XLCallbackAction(action);
      this.RangeAddress.Worksheet.RangeShiftedRows.Add(this._shiftedRowsAction);
    }

    protected void SubscribeToShiftedColumns(Action<XLRange, int> action)
    {
      if (this.Worksheet == null || !this.Worksheet.EventTrackingEnabled)
        return;
      this._shiftedColumnsAction = new XLCallbackAction(action);
      this.RangeAddress.Worksheet.RangeShiftedColumns.Add(this._shiftedColumnsAction);
    }

    public XLRangeAddress RangeAddress
    {
      get
      {
        return this._rangeAddress;
      }
      protected set
      {
        this._rangeAddress = value;
      }
    }

    public XLWorksheet Worksheet
    {
      get
      {
        return this.RangeAddress.Worksheet;
      }
    }

    public XLDataValidation NewDataValidation
    {
      get
      {
        XLDataValidation xlDataValidation = new XLDataValidation((IXLRanges) new XLRanges()
        {
          this.AsRange()
        });
        this.Worksheet.DataValidations.Add((IXLDataValidation) xlDataValidation);
        return xlDataValidation;
      }
    }

    public XLDataValidation DataValidation
    {
      get
      {
        IXLDataValidation dataValidation1 = (IXLDataValidation) null;
        List<IXLDataValidation> xlDataValidationList = new List<IXLDataValidation>();
        foreach (IXLDataValidation dataValidation2 in this.Worksheet.DataValidations)
        {
          foreach (IXLRange range in dataValidation2.Ranges.Where<IXLRange>((Func<IXLRange, bool>) (dvRange => dvRange.Intersects((IXLRangeBase) this))))
          {
            if (dataValidation1 == null)
              dataValidation1 = dataValidation2;
            dataValidation2.Ranges.Remove(range);
            foreach (IXLRangeColumn column in (IEnumerable<IXLRangeColumn>) range.Columns((Func<IXLRangeColumn, bool>) null))
            {
              if (column.Intersects((IXLRangeBase) this))
              {
                int rowNumber1 = column.RangeAddress.FirstAddress.RowNumber;
                int rowNumber2 = column.RangeAddress.LastAddress.RowNumber;
                int rowNumber3 = this.RangeAddress.FirstAddress.RowNumber;
                int rowNumber4 = this.RangeAddress.LastAddress.RowNumber;
                if (rowNumber3 > rowNumber1 && rowNumber4 < rowNumber2)
                {
                  IXLRangeColumn xlRangeColumn1 = this.Worksheet.Column(column.ColumnNumber()).Column(rowNumber1, rowNumber3 - 1);
                  xlRangeColumn1.Dispose();
                  dataValidation2.Ranges.Add((IXLRangeBase) xlRangeColumn1);
                  IXLRangeColumn xlRangeColumn2 = this.Worksheet.Column(column.ColumnNumber()).Column(rowNumber4 + 1, rowNumber2);
                  xlRangeColumn2.Dispose();
                  dataValidation2.Ranges.Add((IXLRangeBase) xlRangeColumn2);
                }
                else
                {
                  int start = rowNumber1 >= rowNumber3 ? rowNumber4 + 1 : rowNumber1;
                  if (start <= rowNumber2)
                  {
                    int end = rowNumber2 <= rowNumber4 ? rowNumber3 - 1 : rowNumber2;
                    if (end >= rowNumber1)
                    {
                      IXLRangeColumn xlRangeColumn = this.Worksheet.Column(column.ColumnNumber()).Column(start, end);
                      xlRangeColumn.Dispose();
                      dataValidation2.Ranges.Add((IXLRangeBase) xlRangeColumn);
                    }
                  }
                }
              }
              else
              {
                column.Dispose();
                dataValidation2.Ranges.Add((IXLRangeBase) column);
              }
            }
            if (!dataValidation2.Ranges.Any<IXLRange>())
              xlDataValidationList.Add(dataValidation2);
          }
        }
        xlDataValidationList.ForEach((Action<IXLDataValidation>) (dv => this.Worksheet.DataValidations.Delete(dv)));
        XLDataValidation xlDataValidation = new XLDataValidation((IXLRanges) new XLRanges()
        {
          this.AsRange()
        });
        if (dataValidation1 != null)
          xlDataValidation.CopyFrom(dataValidation1);
        this.Worksheet.DataValidations.Add((IXLDataValidation) xlDataValidation);
        return xlDataValidation;
      }
    }

    IXLRangeAddress IXLRangeBase.RangeAddress
    {
      get
      {
        return (IXLRangeAddress) this.RangeAddress;
      }
    }

    IXLWorksheet IXLRangeBase.Worksheet
    {
      get
      {
        return (IXLWorksheet) this.RangeAddress.Worksheet;
      }
    }

    public string FormulaA1
    {
      set
      {
        this.Cells().ForEach<IXLCell>((Action<IXLCell>) (c =>
        {
          c.FormulaA1 = value;
          c.FormulaReference = (IXLRangeAddress) this.RangeAddress;
        }));
      }
    }

    public string FormulaR1C1
    {
      set
      {
        this.Cells().ForEach<IXLCell>((Action<IXLCell>) (c =>
        {
          c.FormulaR1C1 = value;
          c.FormulaReference = (IXLRangeAddress) this.RangeAddress;
        }));
      }
    }

    public bool ShareString
    {
      set
      {
        this.Cells().ForEach<IXLCell>((Action<IXLCell>) (c => c.ShareString = value));
      }
    }

    public IXLHyperlinks Hyperlinks
    {
      get
      {
        XLHyperlinks xlHyperlinks = new XLHyperlinks();
        this.Worksheet.Hyperlinks.Where<XLHyperlink>((Func<XLHyperlink, bool>) (hl => this.Contains((IXLRangeBase) hl.Cell.AsRange()))).ForEach<XLHyperlink>(new Action<XLHyperlink>(xlHyperlinks.Add));
        return (IXLHyperlinks) xlHyperlinks;
      }
    }

    public object Value
    {
      set
      {
        this.Cells().ForEach<IXLCell>((Action<IXLCell>) (c => c.Value = value));
      }
    }

    public XLCellValues DataType
    {
      set
      {
        this.Cells().ForEach<IXLCell>((Action<IXLCell>) (c => c.DataType = value));
      }
    }

    public IXLRanges RangesUsed
    {
      get
      {
        return (IXLRanges) new XLRanges()
        {
          this.AsRange()
        };
      }
    }

    IXLCell IXLRangeBase.FirstCell()
    {
      return (IXLCell) this.FirstCell();
    }

    IXLCell IXLRangeBase.LastCell()
    {
      return (IXLCell) this.LastCell();
    }

    IXLCell IXLRangeBase.FirstCellUsed()
    {
      return (IXLCell) this.FirstCellUsed(false);
    }

    IXLCell IXLRangeBase.FirstCellUsed(bool includeFormats)
    {
      return (IXLCell) this.FirstCellUsed(includeFormats);
    }

    IXLCell IXLRangeBase.LastCellUsed()
    {
      return (IXLCell) this.LastCellUsed(false);
    }

    IXLCell IXLRangeBase.LastCellUsed(bool includeFormats)
    {
      return (IXLCell) this.LastCellUsed(includeFormats);
    }

    public IXLCells Cells()
    {
      return (IXLCells) new XLCells(false, false, (Func<IXLCell, bool>) null)
      {
        this.RangeAddress
      };
    }

    public IXLCells Cells(string cells)
    {
      return this.Ranges(cells).Cells();
    }

    public IXLCells Cells(Func<IXLCell, bool> predicate)
    {
      return (IXLCells) new XLCells(false, false, predicate)
      {
        this.RangeAddress
      };
    }

    public IXLCells CellsUsed()
    {
      return (IXLCells) new XLCells(true, false, (Func<IXLCell, bool>) null)
      {
        this.RangeAddress
      };
    }

    IXLCells IXLRangeBase.CellsUsed(bool includeFormats)
    {
      return (IXLCells) this.CellsUsed(includeFormats);
    }

    public IXLRange Merge()
    {
      return this.Merge(true);
    }

    public IXLRange Merge(bool checkIntersect)
    {
      if (checkIntersect)
      {
        string rangeAddress = this.RangeAddress.ToString();
        foreach (IXLRange mergedRange in this.Worksheet.Internals.MergedRanges)
        {
          if (mergedRange.Intersects(rangeAddress))
            this.Worksheet.Internals.MergedRanges.Remove(mergedRange);
        }
      }
      XLRange range = this.AsRange();
      this.Worksheet.Internals.MergedRanges.Add(range);
      return (IXLRange) range;
    }

    public IXLRange Unmerge()
    {
      string tAddress = this.RangeAddress.ToString();
      XLRange xlRange = this.AsRange();
      if (this.Worksheet.Internals.MergedRanges.Select<IXLRange, string>((Func<IXLRange, string>) (m => m.RangeAddress.ToString())).Any<string>((Func<string, bool>) (mAddress => mAddress == tAddress)))
        this.Worksheet.Internals.MergedRanges.Remove((IXLRange) xlRange);
      return (IXLRange) xlRange;
    }

    public IXLRangeBase Clear(XLClearOptions clearOptions = XLClearOptions.ContentsAndFormats)
    {
      bool includeFormats = clearOptions == XLClearOptions.Formats || clearOptions == XLClearOptions.ContentsAndFormats;
      foreach (XLCell xlCell in this.CellsUsed(includeFormats))
        xlCell.Clear(clearOptions, true);
      if (includeFormats)
        this.ClearMerged();
      if (clearOptions == XLClearOptions.ContentsAndFormats)
        this.Worksheet.Internals.CellsCollection.RemoveAll(this.RangeAddress.FirstAddress.RowNumber, this.RangeAddress.FirstAddress.ColumnNumber, this.RangeAddress.LastAddress.RowNumber, this.RangeAddress.LastAddress.ColumnNumber);
      return (IXLRangeBase) this;
    }

    public void DeleteComments()
    {
      this.Cells().DeleteComments();
    }

    public bool Contains(string rangeAddress)
    {
      string str = rangeAddress.Contains("!") ? rangeAddress.Substring(rangeAddress.IndexOf("!") + 1) : rangeAddress;
      XLAddress first;
      XLAddress last;
      if (str.Contains<char>(':'))
      {
        string[] strArray = str.Split(':');
        first = XLAddress.Create(this.Worksheet, strArray[0]);
        last = XLAddress.Create(this.Worksheet, strArray[1]);
      }
      else
      {
        first = XLAddress.Create(this.Worksheet, str);
        last = XLAddress.Create(this.Worksheet, str);
      }
      return this.Contains(first, last);
    }

    public bool Contains(IXLRangeBase range)
    {
      return this.Contains((XLAddress) range.RangeAddress.FirstAddress, (XLAddress) range.RangeAddress.LastAddress);
    }

    public bool Intersects(string rangeAddress)
    {
      using (XLRange xlRange = this.Worksheet.Range(rangeAddress))
        return this.Intersects((IXLRangeBase) xlRange);
    }

    public bool Intersects(IXLRangeBase range)
    {
      if (range.RangeAddress.IsInvalid || this.RangeAddress.IsInvalid)
        return false;
      IXLRangeAddress rangeAddress1 = range.RangeAddress;
      XLRangeAddress rangeAddress2 = this.RangeAddress;
      if (rangeAddress1.FirstAddress.ColumnNumber <= rangeAddress2.LastAddress.ColumnNumber && rangeAddress1.LastAddress.ColumnNumber >= rangeAddress2.FirstAddress.ColumnNumber && rangeAddress1.FirstAddress.RowNumber <= rangeAddress2.LastAddress.RowNumber)
        return rangeAddress1.LastAddress.RowNumber >= rangeAddress2.FirstAddress.RowNumber;
      return false;
    }

    public virtual IXLStyle Style
    {
      get
      {
        return this.GetStyle();
      }
      set
      {
        this.Cells().ForEach<IXLCell>((Action<IXLCell>) (c => c.Style = value));
      }
    }

    IXLRange IXLRangeBase.AsRange()
    {
      return (IXLRange) this.AsRange();
    }

    public virtual XLRange AsRange()
    {
      return this.Worksheet.Range((IXLAddress) this.RangeAddress.FirstAddress, (IXLAddress) this.RangeAddress.LastAddress);
    }

    public IXLRange AddToNamed(string rangeName)
    {
      return this.AddToNamed(rangeName, XLScope.Workbook);
    }

    public IXLRange AddToNamed(string rangeName, XLScope scope)
    {
      return this.AddToNamed(rangeName, scope, (string) null);
    }

    public IXLRange AddToNamed(string rangeName, XLScope scope, string comment)
    {
      IXLNamedRanges source = scope == XLScope.Workbook ? this.Worksheet.Workbook.NamedRanges : this.Worksheet.NamedRanges;
      if (source.Any<IXLNamedRange>((Func<IXLNamedRange, bool>) (nr => string.Compare(nr.Name, rangeName, true) == 0)))
        source.Single<IXLNamedRange>((Func<IXLNamedRange, bool>) (nr => string.Compare(nr.Name, rangeName, true) == 0)).Add(this.Worksheet.Workbook, this.RangeAddress.ToStringFixed(XLReferenceStyle.A1, true));
      else
        source.Add(rangeName, this.RangeAddress.ToStringFixed(XLReferenceStyle.A1, true), comment);
      return (IXLRange) this.AsRange();
    }

    public IXLRangeBase SetValue<T>(T value)
    {
      this.Cells().ForEach<IXLCell>((Action<IXLCell>) (c => c.SetValue<T>(value)));
      return (IXLRangeBase) this;
    }

    public bool IsMerged()
    {
      return this.Cells().Any<IXLCell>((Func<IXLCell, bool>) (c => c.IsMerged()));
    }

    public bool IsEmpty()
    {
      if (this.CellsUsed().Any<IXLCell>())
        return this.CellsUsed().Any<IXLCell>((Func<IXLCell, bool>) (c => c.IsEmpty()));
      return true;
    }

    public bool IsEmpty(bool includeFormats)
    {
      if (this.CellsUsed(includeFormats).Any<XLCell>())
        return this.CellsUsed(includeFormats).Any<XLCell>((Func<XLCell, bool>) (c => c.IsEmpty(includeFormats)));
      return true;
    }

    public virtual IEnumerable<IXLStyle> Styles
    {
      get
      {
        this.UpdatingStyle = true;
        foreach (IXLCell cell in (IEnumerable<IXLCell>) this.Cells())
          yield return cell.Style;
        this.UpdatingStyle = false;
      }
    }

    public virtual bool UpdatingStyle { get; set; }

    public virtual IXLStyle InnerStyle
    {
      get
      {
        return this.GetStyle();
      }
      set
      {
        this.SetStyle(value);
      }
    }

    public XLCell FirstCell()
    {
      return this.Cell(1, 1);
    }

    public XLCell LastCell()
    {
      return this.Cell(this.RowCount(), this.ColumnCount());
    }

    public XLCell FirstCellUsed()
    {
      return this.FirstCellUsed(false, (Func<IXLCell, bool>) null);
    }

    public XLCell FirstCellUsed(bool includeFormats)
    {
      return this.FirstCellUsed(includeFormats, (Func<IXLCell, bool>) null);
    }

    IXLCell IXLRangeBase.FirstCellUsed(Func<IXLCell, bool> predicate)
    {
      return (IXLCell) this.FirstCellUsed(predicate);
    }

    public XLCell FirstCellUsed(Func<IXLCell, bool> predicate)
    {
      return this.FirstCellUsed(false, predicate);
    }

    IXLCell IXLRangeBase.FirstCellUsed(bool includeFormats, Func<IXLCell, bool> predicate)
    {
      return (IXLCell) this.FirstCellUsed(includeFormats, predicate);
    }

    public XLCell FirstCellUsed(bool includeFormats, Func<IXLCell, bool> predicate)
    {
      int fRow = this.RangeAddress.FirstAddress.RowNumber;
      int lRow = this.RangeAddress.LastAddress.RowNumber;
      int fColumn = this.RangeAddress.FirstAddress.ColumnNumber;
      int lColumn = this.RangeAddress.LastAddress.ColumnNumber;
      XLSheetPoint xlSheetPoint = this.Worksheet.Internals.CellsCollection.FirstPointUsed(fRow, fColumn, lRow, lColumn, includeFormats, predicate);
      if (includeFormats)
      {
        IEnumerable<KeyValuePair<int, XLRow>> source1 = this.Worksheet.Internals.RowsCollection.Where<KeyValuePair<int, XLRow>>((Func<KeyValuePair<int, XLRow>, bool>) (r =>
        {
          if (r.Key >= fRow && r.Key <= lRow)
            return !r.Value.IsEmpty(true);
          return false;
        }));
        IEnumerable<KeyValuePair<int, XLColumn>> source2 = this.Worksheet.Internals.ColumnsCollection.Where<KeyValuePair<int, XLColumn>>((Func<KeyValuePair<int, XLColumn>, bool>) (c =>
        {
          if (c.Key >= fColumn && c.Key <= lColumn)
            return !c.Value.IsEmpty(true);
          return false;
        }));
        int row1 = 0;
        if (source1.Any<KeyValuePair<int, XLRow>>())
          row1 = xlSheetPoint.Row <= 0 ? source1.First<KeyValuePair<int, XLRow>>().Key : Math.Min(xlSheetPoint.Row, source1.First<KeyValuePair<int, XLRow>>().Key);
        int column1 = 0;
        if (source2.Any<KeyValuePair<int, XLColumn>>())
          column1 = xlSheetPoint.Column <= 0 ? source2.First<KeyValuePair<int, XLColumn>>().Key : Math.Min(xlSheetPoint.Column, source2.First<KeyValuePair<int, XLColumn>>().Key);
        if (row1 > 0 && column1 > 0)
          return this.Worksheet.Cell(row1, column1);
        if (row1 > 0 && lColumn < 16384)
        {
          for (int column2 = fColumn; column2 <= lColumn; ++column2)
          {
            XLCell xlCell = this.Worksheet.Cell(row1, column2);
            if (!xlCell.IsEmpty(true))
              return xlCell;
          }
        }
        else if (column1 > 0 && lRow < 1048576)
        {
          for (int row2 = fRow; row2 <= lRow; ++row2)
          {
            XLCell xlCell = this.Worksheet.Cell(row2, column1);
            if (!xlCell.IsEmpty(true))
              return xlCell;
          }
        }
        if (this.Worksheet.MergedRanges.Any<IXLRange>((Func<IXLRange, bool>) (r => r.Intersects((IXLRangeBase) this))))
          return this.Worksheet.Cell(this.Worksheet.MergedRanges.Where<IXLRange>((Func<IXLRange, bool>) (r => r.Intersects((IXLRangeBase) this))).Min<IXLRange>((Func<IXLRange, int>) (r => r.RangeAddress.FirstAddress.RowNumber)), this.Worksheet.MergedRanges.Where<IXLRange>((Func<IXLRange, bool>) (r => r.Intersects((IXLRangeBase) this))).Min<IXLRange>((Func<IXLRange, int>) (r => r.RangeAddress.FirstAddress.ColumnNumber)));
      }
      if (xlSheetPoint.Row > 0)
        return this.Worksheet.Cell(xlSheetPoint.Row, xlSheetPoint.Column);
      return (XLCell) null;
    }

    public XLCell LastCellUsed()
    {
      return this.LastCellUsed(false, (Func<IXLCell, bool>) null);
    }

    public XLCell LastCellUsed(bool includeFormats)
    {
      return this.LastCellUsed(includeFormats, (Func<IXLCell, bool>) null);
    }

    IXLCell IXLRangeBase.LastCellUsed(Func<IXLCell, bool> predicate)
    {
      return (IXLCell) this.LastCellUsed(predicate);
    }

    public XLCell LastCellUsed(Func<IXLCell, bool> predicate)
    {
      return this.LastCellUsed(false, predicate);
    }

    IXLCell IXLRangeBase.LastCellUsed(bool includeFormats, Func<IXLCell, bool> predicate)
    {
      return (IXLCell) this.LastCellUsed(includeFormats, predicate);
    }

    public XLCell LastCellUsed(bool includeFormats, Func<IXLCell, bool> predicate)
    {
      int fRow = this.RangeAddress.FirstAddress.RowNumber;
      int lRow = this.RangeAddress.LastAddress.RowNumber;
      int fColumn = this.RangeAddress.FirstAddress.ColumnNumber;
      int lColumn = this.RangeAddress.LastAddress.ColumnNumber;
      XLSheetPoint xlSheetPoint = this.Worksheet.Internals.CellsCollection.LastPointUsed(fRow, fColumn, lRow, lColumn, includeFormats, predicate);
      if (includeFormats)
      {
        IEnumerable<KeyValuePair<int, XLRow>> source1 = this.Worksheet.Internals.RowsCollection.Where<KeyValuePair<int, XLRow>>((Func<KeyValuePair<int, XLRow>, bool>) (r =>
        {
          if (r.Key >= fRow && r.Key <= lRow)
            return !r.Value.IsEmpty(true);
          return false;
        }));
        IEnumerable<KeyValuePair<int, XLColumn>> source2 = this.Worksheet.Internals.ColumnsCollection.Where<KeyValuePair<int, XLColumn>>((Func<KeyValuePair<int, XLColumn>, bool>) (c =>
        {
          if (c.Key >= fColumn && c.Key <= lColumn)
            return !c.Value.IsEmpty(true);
          return false;
        }));
        int row1 = 0;
        if (source1.Any<KeyValuePair<int, XLRow>>())
          row1 = Math.Max(xlSheetPoint.Row, source1.Last<KeyValuePair<int, XLRow>>().Key);
        int column1 = 0;
        if (source2.Any<KeyValuePair<int, XLColumn>>())
          column1 = Math.Max(xlSheetPoint.Column, source2.Last<KeyValuePair<int, XLColumn>>().Key);
        if (row1 > 0 && column1 > 0)
          return this.Worksheet.Cell(row1, column1);
        if (row1 > 0 && lColumn < 16384)
        {
          for (int column2 = lColumn; column2 >= fColumn; --column2)
          {
            XLCell xlCell = this.Worksheet.Cell(row1, column2);
            if (!xlCell.IsEmpty(true))
              return xlCell;
          }
        }
        else if (column1 > 0 && lRow < 1048576)
        {
          for (int row2 = lRow; row2 >= fRow; --row2)
          {
            XLCell xlCell = this.Worksheet.Cell(row2, column1);
            if (!xlCell.IsEmpty(true))
              return xlCell;
          }
        }
        if (this.Worksheet.MergedRanges.Any<IXLRange>((Func<IXLRange, bool>) (r => r.Intersects((IXLRangeBase) this))))
          return this.Worksheet.Cell(this.Worksheet.MergedRanges.Where<IXLRange>((Func<IXLRange, bool>) (r => r.Intersects((IXLRangeBase) this))).Max<IXLRange>((Func<IXLRange, int>) (r => r.RangeAddress.LastAddress.RowNumber)), this.Worksheet.MergedRanges.Where<IXLRange>((Func<IXLRange, bool>) (r => r.Intersects((IXLRangeBase) this))).Max<IXLRange>((Func<IXLRange, int>) (r => r.RangeAddress.LastAddress.ColumnNumber)));
      }
      if (xlSheetPoint.Row > 0)
        return this.Worksheet.Cell(xlSheetPoint.Row, xlSheetPoint.Column);
      return (XLCell) null;
    }

    public XLCell Cell(int row, int column)
    {
      return this.Cell(new XLAddress(this.Worksheet, row, column, false, false));
    }

    public XLCell Cell(string cellAddressInRange)
    {
      if (XLHelper.IsValidA1Address(cellAddressInRange))
        return this.Cell(XLAddress.Create(this.Worksheet, cellAddressInRange));
      return (XLCell) this.Worksheet.NamedRange(cellAddressInRange).Ranges.First<IXLRange>().FirstCell();
    }

    public XLCell Cell(int row, string column)
    {
      return this.Cell(new XLAddress(this.Worksheet, row, column, false, false));
    }

    public XLCell Cell(IXLAddress cellAddressInRange)
    {
      return this.Cell(cellAddressInRange.RowNumber, cellAddressInRange.ColumnNumber);
    }

    public XLCell Cell(XLAddress cellAddressInRange)
    {
      int num1 = cellAddressInRange.RowNumber + this.RangeAddress.FirstAddress.RowNumber - 1;
      int num2 = cellAddressInRange.ColumnNumber + this.RangeAddress.FirstAddress.ColumnNumber - 1;
      if (num1 <= 0 || num1 > 1048576)
        throw new IndexOutOfRangeException(string.Format("Row number must be between 1 and {0}", (object) 1048576));
      if (num2 <= 0 || num2 > 16384)
        throw new IndexOutOfRangeException(string.Format("Column number must be between 1 and {0}", (object) 16384));
      XLCell cell1 = this.Worksheet.Internals.CellsCollection.GetCell(num1, num2);
      if (cell1 != null)
        return cell1;
      int styleId1 = this.GetStyleId();
      int styleId2 = this.Worksheet.GetStyleId();
      if (styleId1 == styleId2)
      {
        XLRow xlRow;
        if (this.Worksheet.Internals.RowsCollection.TryGetValue(num1, out xlRow) && xlRow.GetStyleId() != styleId2)
        {
          styleId1 = xlRow.GetStyleId();
        }
        else
        {
          XLColumn xlColumn;
          if (this.Worksheet.Internals.ColumnsCollection.TryGetValue(num2, out xlColumn) && xlColumn.GetStyleId() != styleId2)
            styleId1 = xlColumn.GetStyleId();
        }
      }
      XLCell cell2 = new XLCell(this.Worksheet, new XLAddress(cellAddressInRange.Worksheet, num1, num2, cellAddressInRange.FixedRow, cellAddressInRange.FixedColumn), styleId1);
      this.Worksheet.Internals.CellsCollection.Add(num1, num2, cell2);
      return cell2;
    }

    public int RowCount()
    {
      return this.RangeAddress.LastAddress.RowNumber - this.RangeAddress.FirstAddress.RowNumber + 1;
    }

    public int RowNumber()
    {
      return this.RangeAddress.FirstAddress.RowNumber;
    }

    public int ColumnCount()
    {
      return this.RangeAddress.LastAddress.ColumnNumber - this.RangeAddress.FirstAddress.ColumnNumber + 1;
    }

    public int ColumnNumber()
    {
      return this.RangeAddress.FirstAddress.ColumnNumber;
    }

    public string ColumnLetter()
    {
      return this.RangeAddress.FirstAddress.ColumnLetter;
    }

    public virtual XLRange Range(string rangeAddressStr)
    {
      return this.Range((IXLRangeAddress) new XLRangeAddress(this.Worksheet, rangeAddressStr));
    }

    public XLRange Range(IXLCell firstCell, IXLCell lastCell)
    {
      return this.GetRange(firstCell.Address as XLAddress, lastCell.Address as XLAddress);
    }

    private XLRange GetRange(XLAddress newFirstCellAddress, XLAddress newLastCellAddress)
    {
      XLRangeParameters xlRangeParameters = new XLRangeParameters(new XLRangeAddress(newFirstCellAddress, newLastCellAddress), this.Style);
      if (newFirstCellAddress.RowNumber < this.RangeAddress.FirstAddress.RowNumber || newFirstCellAddress.RowNumber > this.RangeAddress.LastAddress.RowNumber || (newLastCellAddress.RowNumber > this.RangeAddress.LastAddress.RowNumber || newFirstCellAddress.ColumnNumber < this.RangeAddress.FirstAddress.ColumnNumber) || (newFirstCellAddress.ColumnNumber > this.RangeAddress.LastAddress.ColumnNumber || newLastCellAddress.ColumnNumber > this.RangeAddress.LastAddress.ColumnNumber))
        throw new ArgumentOutOfRangeException(string.Format("The cells {0} and {1} are outside the range '{2}'.", (object) newFirstCellAddress, (object) newLastCellAddress, (object) this.ToString()));
      return new XLRange(xlRangeParameters);
    }

    public XLRange Range(string firstCellAddress, string lastCellAddress)
    {
      return this.Range((IXLRangeAddress) new XLRangeAddress(XLAddress.Create(this.Worksheet, firstCellAddress), XLAddress.Create(this.Worksheet, lastCellAddress)));
    }

    public XLRange Range(int firstCellRow, int firstCellColumn, int lastCellRow, int lastCellColumn)
    {
      return this.Range((IXLRangeAddress) new XLRangeAddress(new XLAddress(this.Worksheet, firstCellRow, firstCellColumn, false, false), new XLAddress(this.Worksheet, lastCellRow, lastCellColumn, false, false)));
    }

    public XLRange Range(IXLAddress firstCellAddress, IXLAddress lastCellAddress)
    {
      return this.Range((IXLRangeAddress) new XLRangeAddress(firstCellAddress as XLAddress, lastCellAddress as XLAddress));
    }

    public XLRange Range(IXLRangeAddress rangeAddress)
    {
      return this.GetRange(new XLAddress((XLWorksheet) rangeAddress.FirstAddress.Worksheet, rangeAddress.FirstAddress.RowNumber + this.RangeAddress.FirstAddress.RowNumber - 1, rangeAddress.FirstAddress.ColumnNumber + this.RangeAddress.FirstAddress.ColumnNumber - 1, rangeAddress.FirstAddress.FixedRow, rangeAddress.FirstAddress.FixedColumn)
      {
        FixedRow = rangeAddress.FirstAddress.FixedRow,
        FixedColumn = rangeAddress.FirstAddress.FixedColumn
      }, new XLAddress((XLWorksheet) rangeAddress.LastAddress.Worksheet, rangeAddress.LastAddress.RowNumber + this.RangeAddress.FirstAddress.RowNumber - 1, rangeAddress.LastAddress.ColumnNumber + this.RangeAddress.FirstAddress.ColumnNumber - 1, rangeAddress.LastAddress.FixedRow, rangeAddress.LastAddress.FixedColumn)
      {
        FixedRow = rangeAddress.LastAddress.FixedRow,
        FixedColumn = rangeAddress.LastAddress.FixedColumn
      });
    }

    public IXLRanges Ranges(string ranges)
    {
      XLRanges xlRanges = new XLRanges();
      string str1 = ranges;
      char[] chArray = new char[1]{ ',' };
      foreach (string str2 in str1.Split(chArray))
        xlRanges.Add(this.Range(str2.Trim()));
      return (IXLRanges) xlRanges;
    }

    public IXLRanges Ranges(params string[] ranges)
    {
      XLRanges xlRanges = new XLRanges();
      foreach (string range in ranges)
        xlRanges.Add(this.Range(range));
      return (IXLRanges) xlRanges;
    }

    protected string FixColumnAddress(string address)
    {
      int result;
      if (int.TryParse(address, out result))
        return "A" + address;
      return address;
    }

    protected string FixRowAddress(string address)
    {
      int result;
      if (int.TryParse(address, out result))
        return XLHelper.GetColumnLetterFromNumber(result) + "1";
      return address;
    }

    public XLCells CellsUsed(bool includeFormats)
    {
      return new XLCells(true, includeFormats, (Func<IXLCell, bool>) null)
      {
        this.RangeAddress
      };
    }

    public IXLCells CellsUsed(Func<IXLCell, bool> predicate)
    {
      return (IXLCells) new XLCells(true, false, predicate)
      {
        this.RangeAddress
      };
    }

    public IXLCells CellsUsed(bool includeFormats, Func<IXLCell, bool> predicate)
    {
      return (IXLCells) new XLCells(true, includeFormats, predicate)
      {
        this.RangeAddress
      };
    }

    public IXLRangeColumns InsertColumnsAfter(int numberOfColumns)
    {
      return this.InsertColumnsAfter(numberOfColumns, true);
    }

    public IXLRangeColumns InsertColumnsAfter(int numberOfColumns, bool expandRange)
    {
      IXLRangeColumns xlRangeColumns = this.InsertColumnsAfter(false, numberOfColumns, true);
      if (expandRange)
        this.RangeAddress = new XLRangeAddress(new XLAddress(this.Worksheet, this.RangeAddress.FirstAddress.RowNumber, this.RangeAddress.FirstAddress.ColumnNumber, this.RangeAddress.FirstAddress.FixedRow, this.RangeAddress.FirstAddress.FixedColumn), new XLAddress(this.Worksheet, this.RangeAddress.LastAddress.RowNumber, this.RangeAddress.LastAddress.ColumnNumber + numberOfColumns, this.RangeAddress.LastAddress.FixedRow, this.RangeAddress.LastAddress.FixedColumn));
      return xlRangeColumns;
    }

    public IXLRangeColumns InsertColumnsAfter(bool onlyUsedCells, int numberOfColumns, bool formatFromLeft = true)
    {
      return this.InsertColumnsAfterInternal(onlyUsedCells, numberOfColumns, formatFromLeft, false);
    }

    public void InsertColumnsAfterVoid(bool onlyUsedCells, int numberOfColumns, bool formatFromLeft = true)
    {
      this.InsertColumnsAfterInternal(onlyUsedCells, numberOfColumns, formatFromLeft, true);
    }

    private IXLRangeColumns InsertColumnsAfterInternal(bool onlyUsedCells, int numberOfColumns, bool formatFromLeft = true, bool nullReturn = false)
    {
      int firstCellColumn = this.RangeAddress.FirstAddress.ColumnNumber + this.ColumnCount();
      if (firstCellColumn > 16384)
        firstCellColumn = 16384;
      int lastCellColumn = firstCellColumn + this.ColumnCount() - 1;
      if (lastCellColumn > 16384)
        lastCellColumn = 16384;
      int rowNumber = this.RangeAddress.FirstAddress.RowNumber;
      int lastCellRow = rowNumber + this.RowCount() - 1;
      if (lastCellRow > 1048576)
        lastCellRow = 1048576;
      return this.Worksheet.Range(rowNumber, firstCellColumn, lastCellRow, lastCellColumn).InsertColumnsBeforeInternal(onlyUsedCells, numberOfColumns, formatFromLeft, nullReturn);
    }

    public IXLRangeColumns InsertColumnsBefore(int numberOfColumns)
    {
      return this.InsertColumnsBefore(numberOfColumns, false);
    }

    public IXLRangeColumns InsertColumnsBefore(int numberOfColumns, bool expandRange)
    {
      IXLRangeColumns xlRangeColumns = this.InsertColumnsBefore(false, numberOfColumns, true);
      if (expandRange)
        this.RangeAddress = new XLRangeAddress(new XLAddress(this.Worksheet, this.RangeAddress.FirstAddress.RowNumber, this.RangeAddress.FirstAddress.ColumnNumber - numberOfColumns, this.RangeAddress.FirstAddress.FixedRow, this.RangeAddress.FirstAddress.FixedColumn), new XLAddress(this.Worksheet, this.RangeAddress.LastAddress.RowNumber, this.RangeAddress.LastAddress.ColumnNumber, this.RangeAddress.LastAddress.FixedRow, this.RangeAddress.LastAddress.FixedColumn));
      return xlRangeColumns;
    }

    public IXLRangeColumns InsertColumnsBefore(bool onlyUsedCells, int numberOfColumns, bool formatFromLeft = true)
    {
      return this.InsertColumnsBeforeInternal(onlyUsedCells, numberOfColumns, formatFromLeft, false);
    }

    public void InsertColumnsBeforeVoid(bool onlyUsedCells, int numberOfColumns, bool formatFromLeft = true)
    {
      this.InsertColumnsBeforeInternal(onlyUsedCells, numberOfColumns, formatFromLeft, true);
    }

    private IXLRangeColumns InsertColumnsBeforeInternal(bool onlyUsedCells, int numberOfColumns, bool formatFromLeft = true, bool nullReturn = false)
    {
      foreach (XLWorksheet xlWorksheet in this.Worksheet.Workbook.WorksheetsInternal)
      {
        foreach (XLCell cell in xlWorksheet.Internals.CellsCollection.GetCells((Func<IXLCell, bool>) (c => !XLHelper.IsNullOrWhiteSpace(c.FormulaA1))))
        {
          using (XLRange shiftedRange = this.AsRange())
            cell.ShiftFormulaColumns(shiftedRange, numberOfColumns);
        }
      }
      Dictionary<XLAddress, XLRangeBase.DataValidationToCopy> source1 = new Dictionary<XLAddress, XLRangeBase.DataValidationToCopy>();
      Dictionary<IXLAddress, XLCell> cellsToInsert = new Dictionary<IXLAddress, XLCell>();
      List<IXLAddress> first = new List<IXLAddress>();
      int columnNumber1 = this.RangeAddress.FirstAddress.ColumnNumber;
      int rowNumber1 = this.RangeAddress.FirstAddress.RowNumber;
      int rowEnd = this.RangeAddress.FirstAddress.RowNumber + this.RowCount() - 1;
      if (!onlyUsedCells)
      {
        int maxColumnUsed = this.Worksheet.Internals.CellsCollection.MaxColumnUsed;
        if (maxColumnUsed > 0)
        {
          for (int index1 = maxColumnUsed; index1 >= columnNumber1; --index1)
          {
            for (int index2 = rowEnd; index2 >= rowNumber1; --index2)
            {
              XLAddress cellAddressInRange = new XLAddress(this.Worksheet, index2, index1, false, false);
              int columnNumber2 = index1 + numberOfColumns;
              XLAddress address = new XLAddress(this.Worksheet, index2, columnNumber2, false, false);
              XLCell source2 = this.Worksheet.Internals.CellsCollection.GetCell(index2, index1) ?? this.Worksheet.Cell(cellAddressInRange);
              XLCell xlCell = new XLCell(this.Worksheet, address, source2.GetStyleId());
              xlCell.CopyValues(source2);
              xlCell.FormulaA1 = source2.FormulaA1;
              cellsToInsert.Add((IXLAddress) address, xlCell);
              first.Add((IXLAddress) cellAddressInRange);
            }
          }
        }
      }
      else
      {
        foreach (XLCell cell in this.Worksheet.Internals.CellsCollection.GetCells(rowNumber1, columnNumber1, rowEnd, this.Worksheet.Internals.CellsCollection.MaxColumnUsed, (Func<IXLCell, bool>) null))
        {
          int columnNumber2 = cell.Address.ColumnNumber + numberOfColumns;
          XLAddress address = new XLAddress(this.Worksheet, cell.Address.RowNumber, columnNumber2, false, false);
          XLCell xlCell = new XLCell(this.Worksheet, address, cell.GetStyleId());
          xlCell.CopyValues(cell);
          if (cell.HasDataValidation)
          {
            source1.Add(xlCell.Address, new XLRangeBase.DataValidationToCopy()
            {
              DataValidation = cell.DataValidation,
              SourceAddress = cell.Address
            });
            cell.DataValidation.Clear();
          }
          xlCell.FormulaA1 = cell.FormulaA1;
          cellsToInsert.Add((IXLAddress) address, xlCell);
          first.Add((IXLAddress) cell.Address);
        }
      }
      source1.ForEach<KeyValuePair<XLAddress, XLRangeBase.DataValidationToCopy>>((Action<KeyValuePair<XLAddress, XLRangeBase.DataValidationToCopy>>) (kp =>
      {
        XLCell xlCell;
        if (!cellsToInsert.TryGetValue((IXLAddress) kp.Key, out xlCell))
          xlCell = this.Worksheet.Cell(kp.Key);
        xlCell.CopyDataValidation(this.Worksheet.Cell(kp.Value.SourceAddress), kp.Value.DataValidation);
      }));
      first.ForEach((Action<IXLAddress>) (c => this.Worksheet.Internals.CellsCollection.Remove(c.RowNumber, c.ColumnNumber)));
      cellsToInsert.ForEach<KeyValuePair<IXLAddress, XLCell>>((Action<KeyValuePair<IXLAddress, XLCell>>) (c => this.Worksheet.Internals.CellsCollection.Add(c.Key.RowNumber, c.Key.ColumnNumber, c.Value)));
      int rowNumber2 = this.RangeAddress.FirstAddress.RowNumber;
      int rowNumber3 = this.RangeAddress.LastAddress.RowNumber;
      int columnNumber3 = this.RangeAddress.FirstAddress.ColumnNumber;
      int lastCellColumn = this.RangeAddress.FirstAddress.ColumnNumber + numberOfColumns - 1;
      this.Worksheet.BreakConditionalFormatsIntoCells(first.Except<IXLAddress>((IEnumerable<IXLAddress>) cellsToInsert.Keys).ToList<IXLAddress>());
      using (XLRange range = this.AsRange())
        this.Worksheet.NotifyRangeShiftedColumns(range, numberOfColumns);
      XLRange xlRange = this.Worksheet.Range(rowNumber2, columnNumber3, rowNumber3, lastCellColumn);
      if (formatFromLeft && xlRange.RangeAddress.FirstAddress.ColumnNumber > 1)
      {
        using (XLRangeColumn xlRangeColumn1 = xlRange.FirstColumn((Func<IXLRangeColumn, bool>) null))
        {
          using (XLRangeColumn xlRangeColumn2 = xlRangeColumn1.ColumnLeft())
          {
            XLCell xlCell1 = xlRangeColumn2.FirstCellUsed(true);
            XLCell xlCell2 = xlRangeColumn2.LastCellUsed(true);
            if (xlCell2 != null)
            {
              int num1 = xlCell1.Address.RowNumber - xlRangeColumn2.RangeAddress.FirstAddress.RowNumber + 1;
              int num2 = xlCell2.Address.RowNumber - xlRangeColumn2.RangeAddress.FirstAddress.RowNumber + 1;
              for (int row = num1; row <= num2; ++row)
                xlRange.Row(row).Style = xlRangeColumn2.Cell(row).Style;
            }
          }
        }
      }
      else
      {
        XLRangeRow xlRangeRow = xlRange.LastRowUsed(true, (Func<IXLRangeRow, bool>) null);
        if (xlRangeRow != null)
        {
          int num = xlRangeRow.RowNumber();
          for (int index = 1; index <= num; ++index)
          {
            IXLStyle xlStyle = this.Worksheet.Internals.RowsCollection.ContainsKey(index) ? this.Worksheet.Internals.RowsCollection[index].Style : this.Worksheet.Style;
            xlRange.Row(index).Style = xlStyle;
          }
        }
      }
      if (nullReturn)
        return (IXLRangeColumns) null;
      return xlRange.Columns((Func<IXLRangeColumn, bool>) null);
    }

    public IXLRangeRows InsertRowsBelow(int numberOfRows)
    {
      return this.InsertRowsBelow(numberOfRows, true);
    }

    public IXLRangeRows InsertRowsBelow(int numberOfRows, bool expandRange)
    {
      IXLRangeRows xlRangeRows = this.InsertRowsBelow(false, numberOfRows, true);
      if (expandRange)
        this.RangeAddress = new XLRangeAddress(new XLAddress(this.Worksheet, this.RangeAddress.FirstAddress.RowNumber, this.RangeAddress.FirstAddress.ColumnNumber, this.RangeAddress.FirstAddress.FixedRow, this.RangeAddress.FirstAddress.FixedColumn), new XLAddress(this.Worksheet, this.RangeAddress.LastAddress.RowNumber + numberOfRows, this.RangeAddress.LastAddress.ColumnNumber, this.RangeAddress.LastAddress.FixedRow, this.RangeAddress.LastAddress.FixedColumn));
      return xlRangeRows;
    }

    public IXLRangeRows InsertRowsBelow(bool onlyUsedCells, int numberOfRows, bool formatFromAbove = true)
    {
      return this.InsertRowsBelowInternal(onlyUsedCells, numberOfRows, formatFromAbove, false);
    }

    public void InsertRowsBelowVoid(bool onlyUsedCells, int numberOfRows, bool formatFromAbove = true)
    {
      this.InsertRowsBelowInternal(onlyUsedCells, numberOfRows, formatFromAbove, true);
    }

    private IXLRangeRows InsertRowsBelowInternal(bool onlyUsedCells, int numberOfRows, bool formatFromAbove, bool nullReturn)
    {
      int firstCellRow = this.RangeAddress.FirstAddress.RowNumber + this.RowCount();
      if (firstCellRow > 1048576)
        firstCellRow = 1048576;
      int lastCellRow = firstCellRow + this.RowCount() - 1;
      if (lastCellRow > 1048576)
        lastCellRow = 1048576;
      int columnNumber = this.RangeAddress.FirstAddress.ColumnNumber;
      int lastCellColumn = columnNumber + this.ColumnCount() - 1;
      if (lastCellColumn > 16384)
        lastCellColumn = 16384;
      return this.Worksheet.Range(firstCellRow, columnNumber, lastCellRow, lastCellColumn).InsertRowsAboveInternal(onlyUsedCells, numberOfRows, formatFromAbove, nullReturn);
    }

    public IXLRangeRows InsertRowsAbove(int numberOfRows)
    {
      return this.InsertRowsAbove(numberOfRows, false);
    }

    public IXLRangeRows InsertRowsAbove(int numberOfRows, bool expandRange)
    {
      IXLRangeRows xlRangeRows = this.InsertRowsAbove(false, numberOfRows, true);
      if (expandRange)
        this.RangeAddress = new XLRangeAddress(new XLAddress(this.Worksheet, this.RangeAddress.FirstAddress.RowNumber - numberOfRows, this.RangeAddress.FirstAddress.ColumnNumber, this.RangeAddress.FirstAddress.FixedRow, this.RangeAddress.FirstAddress.FixedColumn), new XLAddress(this.Worksheet, this.RangeAddress.LastAddress.RowNumber, this.RangeAddress.LastAddress.ColumnNumber, this.RangeAddress.LastAddress.FixedRow, this.RangeAddress.LastAddress.FixedColumn));
      return xlRangeRows;
    }

    public void InsertRowsAboveVoid(bool onlyUsedCells, int numberOfRows, bool formatFromAbove = true)
    {
      this.InsertRowsAboveInternal(onlyUsedCells, numberOfRows, formatFromAbove, true);
    }

    public IXLRangeRows InsertRowsAbove(bool onlyUsedCells, int numberOfRows, bool formatFromAbove = true)
    {
      return this.InsertRowsAboveInternal(onlyUsedCells, numberOfRows, formatFromAbove, false);
    }

    private IXLRangeRows InsertRowsAboveInternal(bool onlyUsedCells, int numberOfRows, bool formatFromAbove, bool nullReturn)
    {
      using (XLRange shiftedRange = this.AsRange())
      {
        foreach (XLWorksheet xlWorksheet in this.Worksheet.Workbook.WorksheetsInternal)
        {
          foreach (XLCell cell in xlWorksheet.Internals.CellsCollection.GetCells((Func<IXLCell, bool>) (c => !XLHelper.IsNullOrWhiteSpace(c.FormulaA1))))
            cell.ShiftFormulaRows(shiftedRange, numberOfRows);
        }
      }
      Dictionary<IXLAddress, XLCell> cellsToInsert = new Dictionary<IXLAddress, XLCell>();
      List<IXLAddress> first = new List<IXLAddress>();
      Dictionary<XLAddress, XLRangeBase.DataValidationToCopy> source1 = new Dictionary<XLAddress, XLRangeBase.DataValidationToCopy>();
      int rowNumber1 = this.RangeAddress.FirstAddress.RowNumber;
      int columnNumber1 = this.RangeAddress.FirstAddress.ColumnNumber;
      int columnEnd = this.RangeAddress.FirstAddress.ColumnNumber + this.ColumnCount() - 1;
      if (!onlyUsedCells)
      {
        int maxRowUsed = this.Worksheet.Internals.CellsCollection.MaxRowUsed;
        if (maxRowUsed > 0)
        {
          for (int index1 = maxRowUsed; index1 >= rowNumber1; --index1)
          {
            for (int index2 = columnEnd; index2 >= columnNumber1; --index2)
            {
              XLAddress cellAddressInRange = new XLAddress(this.Worksheet, index1, index2, false, false);
              XLAddress address = new XLAddress(this.Worksheet, index1 + numberOfRows, index2, false, false);
              XLCell source2 = this.Worksheet.Internals.CellsCollection.GetCell(index1, index2) ?? this.Worksheet.Cell(cellAddressInRange);
              XLCell xlCell = new XLCell(this.Worksheet, address, source2.GetStyleId());
              xlCell.CopyValues(source2);
              xlCell.FormulaA1 = source2.FormulaA1;
              cellsToInsert.Add((IXLAddress) address, xlCell);
              first.Add((IXLAddress) cellAddressInRange);
            }
          }
        }
      }
      else
      {
        foreach (XLCell cell in this.Worksheet.Internals.CellsCollection.GetCells(rowNumber1, columnNumber1, this.Worksheet.Internals.CellsCollection.MaxRowUsed, columnEnd, (Func<IXLCell, bool>) null))
        {
          XLAddress address = new XLAddress(this.Worksheet, cell.Address.RowNumber + numberOfRows, cell.Address.ColumnNumber, false, false);
          XLCell xlCell = new XLCell(this.Worksheet, address, cell.GetStyleId());
          xlCell.CopyValues(cell);
          if (cell.HasDataValidation)
          {
            source1.Add(xlCell.Address, new XLRangeBase.DataValidationToCopy()
            {
              DataValidation = cell.DataValidation,
              SourceAddress = cell.Address
            });
            cell.DataValidation.Clear();
          }
          xlCell.FormulaA1 = cell.FormulaA1;
          cellsToInsert.Add((IXLAddress) address, xlCell);
          first.Add((IXLAddress) cell.Address);
        }
      }
      source1.ForEach<KeyValuePair<XLAddress, XLRangeBase.DataValidationToCopy>>((Action<KeyValuePair<XLAddress, XLRangeBase.DataValidationToCopy>>) (kp =>
      {
        XLCell xlCell;
        if (!cellsToInsert.TryGetValue((IXLAddress) kp.Key, out xlCell))
          xlCell = this.Worksheet.Cell(kp.Key);
        xlCell.CopyDataValidation(this.Worksheet.Cell(kp.Value.SourceAddress), kp.Value.DataValidation);
      }));
      first.ForEach((Action<IXLAddress>) (c => this.Worksheet.Internals.CellsCollection.Remove(c.RowNumber, c.ColumnNumber)));
      cellsToInsert.ForEach<KeyValuePair<IXLAddress, XLCell>>((Action<KeyValuePair<IXLAddress, XLCell>>) (c => this.Worksheet.Internals.CellsCollection.Add(c.Key.RowNumber, c.Key.ColumnNumber, c.Value)));
      int rowNumber2 = this.RangeAddress.FirstAddress.RowNumber;
      int lastCellRow = this.RangeAddress.FirstAddress.RowNumber + numberOfRows - 1;
      int columnNumber2 = this.RangeAddress.FirstAddress.ColumnNumber;
      int columnNumber3 = this.RangeAddress.LastAddress.ColumnNumber;
      this.Worksheet.BreakConditionalFormatsIntoCells(first.Except<IXLAddress>((IEnumerable<IXLAddress>) cellsToInsert.Keys).ToList<IXLAddress>());
      using (XLRange range = this.AsRange())
        this.Worksheet.NotifyRangeShiftedRows(range, numberOfRows);
      XLRange xlRange = this.Worksheet.Range(rowNumber2, columnNumber2, lastCellRow, columnNumber3);
      if (formatFromAbove && xlRange.RangeAddress.FirstAddress.RowNumber > 1)
      {
        using (XLRangeRow xlRangeRow1 = xlRange.FirstRow((Func<IXLRangeRow, bool>) null))
        {
          using (XLRangeRow xlRangeRow2 = xlRangeRow1.RowAbove())
          {
            XLCell xlCell1 = xlRangeRow2.FirstCellUsed(true);
            XLCell xlCell2 = xlRangeRow2.LastCellUsed(true);
            if (xlCell2 != null)
            {
              int num1 = xlCell1.Address.ColumnNumber - xlRangeRow2.RangeAddress.FirstAddress.ColumnNumber + 1;
              int num2 = xlCell2.Address.ColumnNumber - xlRangeRow2.RangeAddress.FirstAddress.ColumnNumber + 1;
              for (int column = num1; column <= num2; ++column)
                xlRange.Column(column).Style = xlRangeRow2.Cell(column).Style;
            }
          }
        }
      }
      else
      {
        XLRangeColumn xlRangeColumn = xlRange.LastColumnUsed(true, (Func<IXLRangeColumn, bool>) null);
        if (xlRangeColumn != null)
        {
          int num = xlRangeColumn.ColumnNumber();
          for (int index = 1; index <= num; ++index)
          {
            IXLStyle xlStyle = this.Worksheet.Internals.ColumnsCollection.ContainsKey(index) ? this.Worksheet.Internals.ColumnsCollection[index].Style : this.Worksheet.Style;
            xlRange.Column(index).Style = xlStyle;
          }
        }
      }
      if (nullReturn)
        return (IXLRangeRows) null;
      return xlRange.Rows((Func<IXLRangeRow, bool>) null);
    }

    private void ClearMerged()
    {
      this.Worksheet.Internals.MergedRanges.Where<IXLRange>(new Func<IXLRange, bool>(this.Intersects)).ToList<IXLRange>().ForEach((Action<IXLRange>) (m => this.Worksheet.Internals.MergedRanges.Remove(m)));
    }

    public bool Contains(IXLCell cell)
    {
      return this.Contains(cell.Address as XLAddress);
    }

    public bool Contains(XLAddress first, XLAddress last)
    {
      if (this.Contains(first))
        return this.Contains(last);
      return false;
    }

    public bool Contains(XLAddress address)
    {
      if (this.RangeAddress.FirstAddress.RowNumber <= address.RowNumber && address.RowNumber <= this.RangeAddress.LastAddress.RowNumber && this.RangeAddress.FirstAddress.ColumnNumber <= address.ColumnNumber)
        return address.ColumnNumber <= this.RangeAddress.LastAddress.ColumnNumber;
      return false;
    }

    public void Delete(XLShiftDeletedCells shiftDeleteCells)
    {
      int num1 = this.RowCount();
      int num2 = this.ColumnCount();
      IXLRange xlRange = (IXLRange) this.Worksheet.Range(this.RangeAddress.FirstAddress.RowNumber, this.RangeAddress.FirstAddress.ColumnNumber, this.RangeAddress.LastAddress.RowNumber, this.RangeAddress.LastAddress.ColumnNumber);
      foreach (XLCell xlCell in this.Worksheet.Workbook.Worksheets.Cast<XLWorksheet>().SelectMany<XLWorksheet, XLCell>((Func<XLWorksheet, IEnumerable<XLCell>>) (xlWorksheet => xlWorksheet.Internals.CellsCollection.GetCells((Func<IXLCell, bool>) (c => !XLHelper.IsNullOrWhiteSpace(c.FormulaA1))))))
      {
        if (shiftDeleteCells == XLShiftDeletedCells.ShiftCellsUp)
          xlCell.ShiftFormulaRows((XLRange) xlRange, num1 * -1);
        else
          xlCell.ShiftFormulaColumns((XLRange) xlRange, num2 * -1);
      }
      Dictionary<IXLAddress, XLCell> source1 = new Dictionary<IXLAddress, XLCell>();
      List<IXLAddress> first = new List<IXLAddress>();
      IEnumerable<XLCell> cells1 = this.Worksheet.Internals.CellsCollection.GetCells(this.RangeAddress.FirstAddress.RowNumber, this.RangeAddress.FirstAddress.ColumnNumber, this.RangeAddress.LastAddress.RowNumber, this.Worksheet.Internals.CellsCollection.MaxColumnUsed, (Func<IXLCell, bool>) null);
      IEnumerable<XLCell> cells2 = this.Worksheet.Internals.CellsCollection.GetCells(this.RangeAddress.FirstAddress.RowNumber, this.RangeAddress.FirstAddress.ColumnNumber, this.Worksheet.Internals.CellsCollection.MaxRowUsed, this.RangeAddress.LastAddress.ColumnNumber, (Func<IXLCell, bool>) null);
      int num3 = shiftDeleteCells == XLShiftDeletedCells.ShiftCellsLeft ? this.ColumnCount() : 0;
      int num4 = shiftDeleteCells == XLShiftDeletedCells.ShiftCellsUp ? this.RowCount() : 0;
      foreach (XLCell source2 in shiftDeleteCells == XLShiftDeletedCells.ShiftCellsLeft ? cells1 : cells2)
      {
        XLAddress address = new XLAddress(this.Worksheet, source2.Address.RowNumber - num4, source2.Address.ColumnNumber - num3, false, false);
        XLCell xlCell = new XLCell(this.Worksheet, address, source2.GetStyleId());
        xlCell.CopyValues(source2);
        xlCell.FormulaA1 = source2.FormulaA1;
        first.Add((IXLAddress) source2.Address);
        if (shiftDeleteCells == XLShiftDeletedCells.ShiftCellsLeft ? source2.Address.ColumnNumber > this.RangeAddress.LastAddress.ColumnNumber : source2.Address.RowNumber > this.RangeAddress.LastAddress.RowNumber)
          source1.Add((IXLAddress) address, xlCell);
      }
      first.ForEach((Action<IXLAddress>) (c => this.Worksheet.Internals.CellsCollection.Remove(c.RowNumber, c.ColumnNumber)));
      source1.ForEach<KeyValuePair<IXLAddress, XLCell>>((Action<KeyValuePair<IXLAddress, XLCell>>) (c => this.Worksheet.Internals.CellsCollection.Add(c.Key.RowNumber, c.Key.ColumnNumber, c.Value)));
      this.Worksheet.Internals.MergedRanges.Where<IXLRange>(new Func<IXLRange, bool>(this.Contains)).ToList<IXLRange>().ForEach((Action<IXLRange>) (r => this.Worksheet.Internals.MergedRanges.Remove(r)));
      this.Worksheet.Hyperlinks.Where<XLHyperlink>((Func<XLHyperlink, bool>) (hl => this.Contains((IXLRangeBase) hl.Cell.AsRange()))).ToList<XLHyperlink>().ForEach((Action<XLHyperlink>) (hl => this.Worksheet.Hyperlinks.Delete(hl)));
      this.Worksheet.BreakConditionalFormatsIntoCells(first.Except<IXLAddress>((IEnumerable<IXLAddress>) source1.Keys).ToList<IXLAddress>());
      using (XLRange range = this.AsRange())
      {
        if (shiftDeleteCells == XLShiftDeletedCells.ShiftCellsUp)
          this.Worksheet.NotifyRangeShiftedRows(range, num4 * -1);
        else
          this.Worksheet.NotifyRangeShiftedColumns(range, num3 * -1);
      }
    }

    public override string ToString()
    {
      return string.Format("'{0}'!{1}:{2}", (object) this.Worksheet.Name, (object) this.RangeAddress.FirstAddress, (object) this.RangeAddress.LastAddress);
    }

    protected void ShiftColumns(IXLRangeAddress thisRangeAddress, XLRange shiftedRange, int columnsShifted)
    {
      if (thisRangeAddress.IsInvalid || shiftedRange.RangeAddress.IsInvalid)
        return;
      if (columnsShifted < 0 && thisRangeAddress.FirstAddress.ColumnNumber >= shiftedRange.RangeAddress.FirstAddress.ColumnNumber && (thisRangeAddress.LastAddress.ColumnNumber <= shiftedRange.RangeAddress.FirstAddress.ColumnNumber - columnsShifted && thisRangeAddress.FirstAddress.RowNumber >= shiftedRange.RangeAddress.FirstAddress.RowNumber) && thisRangeAddress.LastAddress.RowNumber <= shiftedRange.RangeAddress.LastAddress.RowNumber || shiftedRange.RangeAddress.FirstAddress.ColumnNumber <= thisRangeAddress.FirstAddress.ColumnNumber && shiftedRange.RangeAddress.FirstAddress.RowNumber <= thisRangeAddress.FirstAddress.RowNumber && (shiftedRange.RangeAddress.LastAddress.RowNumber >= thisRangeAddress.LastAddress.RowNumber && shiftedRange.ColumnCount() > thisRangeAddress.LastAddress.ColumnNumber - thisRangeAddress.FirstAddress.ColumnNumber + 1 + (thisRangeAddress.FirstAddress.ColumnNumber - shiftedRange.RangeAddress.FirstAddress.ColumnNumber)))
      {
        thisRangeAddress.IsInvalid = true;
      }
      else
      {
        if (shiftedRange.RangeAddress.FirstAddress.RowNumber > thisRangeAddress.FirstAddress.RowNumber || shiftedRange.RangeAddress.LastAddress.RowNumber < thisRangeAddress.LastAddress.RowNumber)
          return;
        if (shiftedRange.RangeAddress.FirstAddress.ColumnNumber <= thisRangeAddress.FirstAddress.ColumnNumber && columnsShifted > 0 || shiftedRange.RangeAddress.FirstAddress.ColumnNumber < thisRangeAddress.FirstAddress.ColumnNumber && columnsShifted < 0)
          thisRangeAddress.FirstAddress = (IXLAddress) new XLAddress(this.Worksheet, thisRangeAddress.FirstAddress.RowNumber, thisRangeAddress.FirstAddress.ColumnNumber + columnsShifted, thisRangeAddress.FirstAddress.FixedRow, thisRangeAddress.FirstAddress.FixedColumn);
        if (shiftedRange.RangeAddress.FirstAddress.ColumnNumber > thisRangeAddress.LastAddress.ColumnNumber)
          return;
        thisRangeAddress.LastAddress = (IXLAddress) new XLAddress(this.Worksheet, thisRangeAddress.LastAddress.RowNumber, thisRangeAddress.LastAddress.ColumnNumber + columnsShifted, thisRangeAddress.LastAddress.FixedRow, thisRangeAddress.LastAddress.FixedColumn);
      }
    }

    protected void ShiftRows(IXLRangeAddress thisRangeAddress, XLRange shiftedRange, int rowsShifted)
    {
      if (thisRangeAddress.IsInvalid || shiftedRange.RangeAddress.IsInvalid)
        return;
      if (rowsShifted < 0 && thisRangeAddress.FirstAddress.ColumnNumber >= shiftedRange.RangeAddress.FirstAddress.ColumnNumber && (thisRangeAddress.LastAddress.ColumnNumber <= shiftedRange.RangeAddress.FirstAddress.ColumnNumber && thisRangeAddress.FirstAddress.RowNumber >= shiftedRange.RangeAddress.FirstAddress.RowNumber) && thisRangeAddress.LastAddress.RowNumber <= shiftedRange.RangeAddress.LastAddress.RowNumber - rowsShifted || shiftedRange.RangeAddress.FirstAddress.RowNumber <= thisRangeAddress.FirstAddress.RowNumber && shiftedRange.RangeAddress.FirstAddress.ColumnNumber <= thisRangeAddress.FirstAddress.ColumnNumber && (shiftedRange.RangeAddress.LastAddress.ColumnNumber >= thisRangeAddress.LastAddress.ColumnNumber && shiftedRange.RowCount() > thisRangeAddress.LastAddress.RowNumber - thisRangeAddress.FirstAddress.RowNumber + 1 + (thisRangeAddress.FirstAddress.RowNumber - shiftedRange.RangeAddress.FirstAddress.RowNumber)))
      {
        thisRangeAddress.IsInvalid = true;
      }
      else
      {
        if (shiftedRange.RangeAddress.FirstAddress.ColumnNumber > thisRangeAddress.FirstAddress.ColumnNumber || shiftedRange.RangeAddress.LastAddress.ColumnNumber < thisRangeAddress.LastAddress.ColumnNumber)
          return;
        if (shiftedRange.RangeAddress.FirstAddress.RowNumber <= thisRangeAddress.FirstAddress.RowNumber && rowsShifted > 0 || shiftedRange.RangeAddress.FirstAddress.RowNumber < thisRangeAddress.FirstAddress.RowNumber && rowsShifted < 0)
          thisRangeAddress.FirstAddress = (IXLAddress) new XLAddress(this.Worksheet, thisRangeAddress.FirstAddress.RowNumber + rowsShifted, thisRangeAddress.FirstAddress.ColumnNumber, thisRangeAddress.FirstAddress.FixedRow, thisRangeAddress.FirstAddress.FixedColumn);
        if (shiftedRange.RangeAddress.FirstAddress.RowNumber > thisRangeAddress.LastAddress.RowNumber)
          return;
        thisRangeAddress.LastAddress = (IXLAddress) new XLAddress(this.Worksheet, thisRangeAddress.LastAddress.RowNumber + rowsShifted, thisRangeAddress.LastAddress.ColumnNumber, thisRangeAddress.LastAddress.FixedRow, thisRangeAddress.LastAddress.FixedColumn);
      }
    }

    public IXLRange RangeUsed()
    {
      return this.RangeUsed(false);
    }

    public IXLRange RangeUsed(bool includeFormats)
    {
      XLCell xlCell1 = this.FirstCellUsed(includeFormats);
      if (xlCell1 == null)
        return (IXLRange) null;
      XLCell xlCell2 = this.LastCellUsed(includeFormats);
      return (IXLRange) this.Worksheet.Range((IXLCell) xlCell1, (IXLCell) xlCell2);
    }

    public virtual void CopyTo(IXLRangeBase target)
    {
      this.CopyTo(target.FirstCell());
    }

    public virtual void CopyTo(IXLCell target)
    {
      target.Value = (object) this;
    }

    IXLPivotTable IXLRangeBase.CreatePivotTable(IXLCell targetCell)
    {
      return (IXLPivotTable) this.CreatePivotTable(targetCell);
    }

    IXLPivotTable IXLRangeBase.CreatePivotTable(IXLCell targetCell, string name)
    {
      return (IXLPivotTable) this.CreatePivotTable(targetCell, name);
    }

    public XLPivotTable CreatePivotTable(IXLCell targetCell)
    {
      return this.CreatePivotTable(targetCell, Guid.NewGuid().ToString());
    }

    public XLPivotTable CreatePivotTable(IXLCell targetCell, string name)
    {
      return (XLPivotTable) this.Worksheet.PivotTables.AddNew(name, targetCell, (IXLRange) this.AsRange());
    }

    public IXLAutoFilter SetAutoFilter()
    {
      using (XLRange xlRange = this.AsRange())
        return (IXLAutoFilter) this.Worksheet.AutoFilter.Set((IXLRangeBase) xlRange);
    }

    public IXLSortElements SortRows
    {
      get
      {
        return (IXLSortElements) this._sortRows ?? (IXLSortElements) (this._sortRows = new XLSortElements());
      }
    }

    public IXLSortElements SortColumns
    {
      get
      {
        return (IXLSortElements) this._sortColumns ?? (IXLSortElements) (this._sortColumns = new XLSortElements());
      }
    }

    public IXLRangeBase Sort()
    {
      if (!this.SortColumns.Any<IXLSortElement>())
      {
        string str = string.Empty;
        int num = this.ColumnCount();
        if (num == 16384)
          num = this.LastCellUsed(true).Address.ColumnNumber;
        for (int index = 1; index <= num; ++index)
          str = str + (object) index + ",";
        return this.Sort(str.Substring(0, str.Length - 1), XLSortOrder.Ascending, false, true);
      }
      this.SortRangeRows();
      return (IXLRangeBase) this;
    }

    public IXLRangeBase Sort(string columnsToSortBy, XLSortOrder sortOrder = XLSortOrder.Ascending, bool matchCase = false, bool ignoreBlanks = true)
    {
      this.SortColumns.Clear();
      if (XLHelper.IsNullOrWhiteSpace(columnsToSortBy))
      {
        columnsToSortBy = string.Empty;
        int num = this.ColumnCount();
        if (num == 16384)
          num = this.LastCellUsed(true).Address.ColumnNumber;
        for (int index = 1; index <= num; ++index)
          columnsToSortBy = columnsToSortBy + (object) index + ",";
        columnsToSortBy = columnsToSortBy.Substring(0, columnsToSortBy.Length - 1);
      }
      foreach (string source in ((IEnumerable<string>) columnsToSortBy.Split(',')).Select<string, string>((Func<string, string>) (coPair => coPair.Trim())))
      {
        string str;
        string strA;
        if (source.Contains<char>(' '))
        {
          string[] strArray = source.Split(' ');
          str = strArray[0];
          strA = strArray[1];
        }
        else
        {
          str = source;
          strA = sortOrder == XLSortOrder.Ascending ? "ASC" : "DESC";
        }
        int result;
        if (!int.TryParse(str, out result))
          result = XLHelper.GetColumnNumberFromLetter(str);
        this.SortColumns.Add(result, string.Compare(strA, "ASC", true) == 0 ? XLSortOrder.Ascending : XLSortOrder.Descending, ignoreBlanks, matchCase);
      }
      this.SortRangeRows();
      return (IXLRangeBase) this;
    }

    public IXLRangeBase Sort(int columnToSortBy, XLSortOrder sortOrder = XLSortOrder.Ascending, bool matchCase = false, bool ignoreBlanks = true)
    {
      return this.Sort(columnToSortBy.ToString(), sortOrder, matchCase, ignoreBlanks);
    }

    public IXLRangeBase SortLeftToRight(XLSortOrder sortOrder = XLSortOrder.Ascending, bool matchCase = false, bool ignoreBlanks = true)
    {
      this.SortRows.Clear();
      int num = this.ColumnCount();
      if (num == 16384)
        num = this.LastCellUsed(true).Address.ColumnNumber;
      for (int elementNumber = 1; elementNumber <= num; ++elementNumber)
        this.SortRows.Add(elementNumber, sortOrder, ignoreBlanks, matchCase);
      this.SortRangeColumns();
      return (IXLRangeBase) this;
    }

    private void SortRangeRows()
    {
      int end = this.RowCount();
      if (end == 1048576)
        end = this.LastCellUsed(true).Address.RowNumber;
      this.SortingRangeRows(1, end);
    }

    private void SwapRows(int row1, int row2)
    {
      int row3 = this.RangeAddress.FirstAddress.RowNumber + row1 - 1;
      int row4 = this.RangeAddress.FirstAddress.RowNumber + row2 - 1;
      int columnNumber1 = this.RangeAddress.FirstAddress.ColumnNumber;
      int columnNumber2 = this.RangeAddress.LastAddress.ColumnNumber;
      this.Worksheet.Internals.CellsCollection.SwapRanges(new XLSheetRange(new XLSheetPoint(row3, columnNumber1), new XLSheetPoint(row3, columnNumber2)), new XLSheetRange(new XLSheetPoint(row4, columnNumber1), new XLSheetPoint(row4, columnNumber2)), this.Worksheet);
    }

    private int SortRangeRows(int begPoint, int endPoint)
    {
      int num1 = begPoint;
      int num2 = begPoint + 1;
      int num3 = endPoint;
      while (num2 < endPoint && this.RowQuick(num1).CompareTo(this.RowQuick(num2), this.SortColumns) >= 0)
        ++num2;
      while (num3 > begPoint && this.RowQuick(num1).CompareTo(this.RowQuick(num3), this.SortColumns) <= 0)
        --num3;
label_10:
      while (num2 < num3)
      {
        this.SwapRows(num2, num3);
        while (num2 < endPoint && this.RowQuick(num1).CompareTo(this.RowQuick(num2), this.SortColumns) >= 0)
          ++num2;
        while (true)
        {
          if (num3 > begPoint && this.RowQuick(num1).CompareTo(this.RowQuick(num3), this.SortColumns) <= 0)
            --num3;
          else
            goto label_10;
        }
      }
      if (num1 != num3)
        this.SwapRows(num3, num1);
      return num3;
    }

    private void SortingRangeRows(int beg, int end)
    {
      if (end == beg)
        return;
      int num = this.SortRangeRows(beg, end);
      if (num > beg)
        this.SortingRangeRows(beg, num - 1);
      if (num >= end)
        return;
      this.SortingRangeRows(num + 1, end);
    }

    private void SortRangeColumns()
    {
      int end = this.ColumnCount();
      if (end == 16384)
        end = this.LastCellUsed(true).Address.ColumnNumber;
      this.SortingRangeColumns(1, end);
    }

    private void SwapColumns(int column1, int column2)
    {
      int column3 = this.RangeAddress.FirstAddress.ColumnNumber + column1 - 1;
      int column4 = this.RangeAddress.FirstAddress.ColumnNumber + column2 - 1;
      int rowNumber1 = this.RangeAddress.FirstAddress.RowNumber;
      int rowNumber2 = this.RangeAddress.LastAddress.RowNumber;
      this.Worksheet.Internals.CellsCollection.SwapRanges(new XLSheetRange(new XLSheetPoint(rowNumber1, column3), new XLSheetPoint(rowNumber2, column3)), new XLSheetRange(new XLSheetPoint(rowNumber1, column4), new XLSheetPoint(rowNumber2, column4)), this.Worksheet);
    }

    private int SortRangeColumns(int begPoint, int endPoint)
    {
      int num1 = begPoint;
      int num2 = begPoint + 1;
      int num3 = endPoint;
      while (num2 < endPoint && this.ColumnQuick(num1).CompareTo(this.ColumnQuick(num2), this.SortRows) >= 0)
        ++num2;
      while (num3 > begPoint && this.ColumnQuick(num1).CompareTo(this.ColumnQuick(num3), this.SortRows) <= 0)
        --num3;
label_10:
      while (num2 < num3)
      {
        this.SwapColumns(num2, num3);
        while (num2 < endPoint && this.ColumnQuick(num1).CompareTo(this.ColumnQuick(num2), this.SortRows) >= 0)
          ++num2;
        while (true)
        {
          if (num3 > begPoint && this.ColumnQuick(num1).CompareTo(this.ColumnQuick(num3), this.SortRows) <= 0)
            --num3;
          else
            goto label_10;
        }
      }
      if (num1 != num3)
        this.SwapColumns(num3, num1);
      return num3;
    }

    private void SortingRangeColumns(int beg, int end)
    {
      if (end == beg)
        return;
      int num = this.SortRangeColumns(beg, end);
      if (num > beg)
        this.SortingRangeColumns(beg, num - 1);
      if (num >= end)
        return;
      this.SortingRangeColumns(num + 1, end);
    }

    public XLRangeColumn ColumnQuick(int column)
    {
      return new XLRangeColumn(new XLRangeParameters(new XLRangeAddress(new XLAddress(this.Worksheet, this.RangeAddress.FirstAddress.RowNumber, this.RangeAddress.FirstAddress.ColumnNumber + column - 1, false, false), new XLAddress(this.Worksheet, this.RangeAddress.LastAddress.RowNumber, this.RangeAddress.FirstAddress.ColumnNumber + column - 1, false, false)), this.Worksheet.Style), true);
    }

    public XLRangeRow RowQuick(int row)
    {
      return new XLRangeRow(new XLRangeParameters(new XLRangeAddress(new XLAddress(this.Worksheet, this.RangeAddress.FirstAddress.RowNumber + row - 1, this.RangeAddress.FirstAddress.ColumnNumber, false, false), new XLAddress(this.Worksheet, this.RangeAddress.FirstAddress.RowNumber + row - 1, this.RangeAddress.LastAddress.ColumnNumber, false, false)), this.Worksheet.Style), true);
    }

    public void Dispose()
    {
      if (this._shiftedRowsAction != null)
      {
        this.RangeAddress.Worksheet.RangeShiftedRows.Remove(this._shiftedRowsAction);
        this._shiftedRowsAction = (XLCallbackAction) null;
      }
      if (this._shiftedColumnsAction == null)
        return;
      this.RangeAddress.Worksheet.RangeShiftedColumns.Remove(this._shiftedColumnsAction);
      this._shiftedColumnsAction = (XLCallbackAction) null;
    }

    public IXLDataValidation SetDataValidation()
    {
      return (IXLDataValidation) this.DataValidation;
    }

    public IXLConditionalFormat AddConditionalFormat()
    {
      using (XLRange range = this.AsRange())
      {
        XLConditionalFormat conditionalFormat = new XLConditionalFormat(range, false);
        this.Worksheet.ConditionalFormats.Add((IXLConditionalFormat) conditionalFormat);
        return (IXLConditionalFormat) conditionalFormat;
      }
    }

    internal IXLConditionalFormat AddConditionalFormat(IXLConditionalFormat source)
    {
      using (XLRange range = this.AsRange())
      {
        XLConditionalFormat conditionalFormat = new XLConditionalFormat(range, false);
        conditionalFormat.CopyFrom(source);
        this.Worksheet.ConditionalFormats.Add((IXLConditionalFormat) conditionalFormat);
        return (IXLConditionalFormat) conditionalFormat;
      }
    }

    public void Select()
    {
      this.Worksheet.SelectedRanges.Add((IXLRangeBase) this.AsRange());
    }

    private struct DataValidationToCopy
    {
      public XLAddress SourceAddress;
      public XLDataValidation DataValidation;
    }
  }
}

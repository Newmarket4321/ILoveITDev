// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLTableRow
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;

namespace ClosedXML.Excel
{
  internal class XLTableRow : XLRangeRow, IXLTableRow, IXLRangeRow, IXLRangeBase, IDisposable
  {
    private readonly XLTableRange _tableRange;

    public XLTableRow(XLTableRange tableRange, XLRangeRow rangeRow)
      : base(rangeRow.RangeParameters, false)
    {
      this._tableRange = tableRange;
    }

    public IXLCell Field(int index)
    {
      return this.Cell(index + 1);
    }

    public IXLCell Field(string name)
    {
      return this.Cell(this._tableRange.Table.GetFieldIndex(name) + 1);
    }

    public IXLTableRow Sort()
    {
      return this.SortLeftToRight(XLSortOrder.Ascending, false, true);
    }

    public IXLTableRow SortLeftToRight(XLSortOrder sortOrder = XLSortOrder.Ascending, bool matchCase = false, bool ignoreBlanks = true)
    {
      base.SortLeftToRight(sortOrder, matchCase, ignoreBlanks);
      return (IXLTableRow) this;
    }

    private XLTableRow RowShift(int rowsToShift)
    {
      return this._tableRange.Row(this.RowNumber() + rowsToShift);
    }

    IXLTableRow IXLTableRow.RowAbove()
    {
      return (IXLTableRow) this.RowAbove();
    }

    IXLTableRow IXLTableRow.RowAbove(int step)
    {
      return (IXLTableRow) this.RowAbove(step);
    }

    public XLTableRow RowAbove()
    {
      return this.RowAbove(1);
    }

    public XLTableRow RowAbove(int step)
    {
      return this.RowShift(step * -1);
    }

    IXLTableRow IXLTableRow.RowBelow()
    {
      return (IXLTableRow) this.RowBelow();
    }

    IXLTableRow IXLTableRow.RowBelow(int step)
    {
      return (IXLTableRow) this.RowBelow(step);
    }

    public XLTableRow RowBelow()
    {
      return this.RowBelow(1);
    }

    public XLTableRow RowBelow(int step)
    {
      return this.RowShift(step);
    }

    public IXLTableRow Clear(XLClearOptions clearOptions = XLClearOptions.ContentsAndFormats)
    {
      base.Clear(clearOptions);
      return (IXLTableRow) this;
    }

    public IXLTableRows InsertRowsAbove(int numberOfRows)
    {
      return XLHelper.InsertRowsWithoutEvents(new Func<int, bool, IXLRangeRows>(((XLRangeBase) this).InsertRowsAbove), this._tableRange, numberOfRows, !this._tableRange.Table.ShowTotalsRow);
    }

    public IXLTableRows InsertRowsBelow(int numberOfRows)
    {
      return XLHelper.InsertRowsWithoutEvents(new Func<int, bool, IXLRangeRows>(((XLRangeBase) this).InsertRowsBelow), this._tableRange, numberOfRows, !this._tableRange.Table.ShowTotalsRow);
    }

    public new void Delete()
    {
      this.Delete(XLShiftDeletedCells.ShiftCellsUp);
      this._tableRange.Table.ExpandTableRows(-1);
    }
  }
}

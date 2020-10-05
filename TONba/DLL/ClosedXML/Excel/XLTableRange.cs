// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLTableRange
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace ClosedXML.Excel
{
  internal class XLTableRange : XLRange, IXLTableRange, IXLRange, IXLRangeBase, IDisposable
  {
    private readonly XLTable _table;
    private readonly XLRange _range;

    public XLTableRange(XLRange range, XLTable table)
      : base(range.RangeParameters)
    {
      this._table = table;
      this._range = range;
    }

    IXLTableRow IXLTableRange.FirstRow(Func<IXLTableRow, bool> predicate)
    {
      return (IXLTableRow) this.FirstRow(predicate);
    }

    public XLTableRow FirstRow(Func<IXLTableRow, bool> predicate = null)
    {
      if (predicate == null)
        return new XLTableRow(this, this._range.FirstRow((Func<IXLRangeRow, bool>) null));
      int num = this._range.RowCount();
      for (int row = 1; row <= num; ++row)
      {
        XLTableRow xlTableRow = new XLTableRow(this, this._range.Row(row));
        if (predicate((IXLTableRow) xlTableRow))
          return xlTableRow;
        xlTableRow.Dispose();
      }
      return (XLTableRow) null;
    }

    IXLTableRow IXLTableRange.FirstRowUsed(Func<IXLTableRow, bool> predicate)
    {
      return (IXLTableRow) this.FirstRowUsed(false, predicate);
    }

    public XLTableRow FirstRowUsed(Func<IXLTableRow, bool> predicate = null)
    {
      return this.FirstRowUsed(false, predicate);
    }

    IXLTableRow IXLTableRange.FirstRowUsed(bool includeFormats, Func<IXLTableRow, bool> predicate)
    {
      return (IXLTableRow) this.FirstRowUsed(includeFormats, predicate);
    }

    public XLTableRow FirstRowUsed(bool includeFormats, Func<IXLTableRow, bool> predicate = null)
    {
      if (predicate == null)
        return new XLTableRow(this, this._range.FirstRowUsed(includeFormats, (Func<IXLRangeRow, bool>) null));
      int num = this._range.RowCount();
      for (int row = 1; row <= num; ++row)
      {
        XLTableRow xlTableRow = new XLTableRow(this, this._range.Row(row));
        if (!xlTableRow.IsEmpty(includeFormats) && predicate((IXLTableRow) xlTableRow))
          return xlTableRow;
        xlTableRow.Dispose();
      }
      return (XLTableRow) null;
    }

    IXLTableRow IXLTableRange.LastRow(Func<IXLTableRow, bool> predicate)
    {
      return (IXLTableRow) this.LastRow(predicate);
    }

    public XLTableRow LastRow(Func<IXLTableRow, bool> predicate = null)
    {
      if (predicate == null)
        return new XLTableRow(this, this._range.LastRow((Func<IXLRangeRow, bool>) null));
      for (int row = this._range.RowCount(); row >= 1; --row)
      {
        XLTableRow xlTableRow = new XLTableRow(this, this._range.Row(row));
        if (predicate((IXLTableRow) xlTableRow))
          return xlTableRow;
        xlTableRow.Dispose();
      }
      return (XLTableRow) null;
    }

    IXLTableRow IXLTableRange.LastRowUsed(Func<IXLTableRow, bool> predicate)
    {
      return (IXLTableRow) this.LastRowUsed(false, predicate);
    }

    public XLTableRow LastRowUsed(Func<IXLTableRow, bool> predicate = null)
    {
      return this.LastRowUsed(false, predicate);
    }

    IXLTableRow IXLTableRange.LastRowUsed(bool includeFormats, Func<IXLTableRow, bool> predicate)
    {
      return (IXLTableRow) this.LastRowUsed(includeFormats, predicate);
    }

    public XLTableRow LastRowUsed(bool includeFormats, Func<IXLTableRow, bool> predicate = null)
    {
      if (predicate == null)
        return new XLTableRow(this, this._range.LastRowUsed(includeFormats, (Func<IXLRangeRow, bool>) null));
      for (int row = this._range.RowCount(); row >= 1; --row)
      {
        XLTableRow xlTableRow = new XLTableRow(this, this._range.Row(row));
        if (!xlTableRow.IsEmpty(includeFormats) && predicate((IXLTableRow) xlTableRow))
          return xlTableRow;
        xlTableRow.Dispose();
      }
      return (XLTableRow) null;
    }

    IXLTableRow IXLTableRange.Row(int row)
    {
      return (IXLTableRow) this.Row(row);
    }

    public XLTableRow Row(int row)
    {
      if (row <= 0 || row > 1048576)
        throw new IndexOutOfRangeException(string.Format("Row number must be between 1 and {0}", (object) 1048576));
      return new XLTableRow(this, base.Row(row));
    }

    public IXLTableRows Rows(Func<IXLTableRow, bool> predicate = null)
    {
      XLTableRows xlTableRows = new XLTableRows(this.Worksheet.Style);
      int num = this._range.RowCount();
      for (int row = 1; row <= num; ++row)
      {
        XLTableRow xlTableRow = this.Row(row);
        if (predicate == null || predicate((IXLTableRow) xlTableRow))
          xlTableRows.Add((IXLTableRow) xlTableRow);
        else
          xlTableRow.Dispose();
      }
      return (IXLTableRows) xlTableRows;
    }

    public IXLTableRows Rows(int firstRow, int lastRow)
    {
      XLTableRows xlTableRows = new XLTableRows(this.Worksheet.Style);
      for (int row = firstRow; row <= lastRow; ++row)
        xlTableRows.Add((IXLTableRow) this.Row(row));
      return (IXLTableRows) xlTableRows;
    }

    public IXLTableRows Rows(string rows)
    {
      XLTableRows xlTableRows = new XLTableRows(this.Worksheet.Style);
      foreach (string str in ((IEnumerable<string>) rows.Split(',')).Select<string, string>((Func<string, string>) (pair => pair.Trim())))
      {
        string s1;
        string s2;
        if (str.Contains<char>(':') || str.Contains<char>('-'))
        {
          string[] strArray = XLHelper.SplitRange(str);
          s1 = strArray[0];
          s2 = strArray[1];
        }
        else
        {
          s1 = str;
          s2 = str;
        }
        foreach (IXLTableRow row in (IEnumerable<IXLTableRow>) this.Rows(int.Parse(s1), int.Parse(s2)))
          xlTableRows.Add(row);
      }
      return (IXLTableRows) xlTableRows;
    }

    IXLTableRows IXLTableRange.RowsUsed(bool includeFormats, Func<IXLTableRow, bool> predicate)
    {
      return this.RowsUsed(includeFormats, predicate);
    }

    public IXLTableRows RowsUsed(bool includeFormats, Func<IXLTableRow, bool> predicate = null)
    {
      XLTableRows xlTableRows = new XLTableRows(this.Worksheet.Style);
      int num = this.RowCount();
      for (int row = 1; row <= num; ++row)
      {
        XLTableRow xlTableRow = this.Row(row);
        if (!xlTableRow.IsEmpty(includeFormats) && (predicate == null || predicate((IXLTableRow) xlTableRow)))
          xlTableRows.Add((IXLTableRow) xlTableRow);
        else
          xlTableRow.Dispose();
      }
      return (IXLTableRows) xlTableRows;
    }

    IXLTableRows IXLTableRange.RowsUsed(Func<IXLTableRow, bool> predicate)
    {
      return this.RowsUsed(predicate);
    }

    public IXLTableRows RowsUsed(Func<IXLTableRow, bool> predicate = null)
    {
      return this.RowsUsed(false, predicate);
    }

    IXLTable IXLTableRange.Table
    {
      get
      {
        return (IXLTable) this._table;
      }
    }

    public XLTable Table
    {
      get
      {
        return this._table;
      }
    }

    public IXLTableRows InsertRowsAbove(int numberOfRows)
    {
      return XLHelper.InsertRowsWithoutEvents(new Func<int, bool, IXLRangeRows>(((XLRangeBase) this).InsertRowsAbove), this, numberOfRows, !this.Table.ShowTotalsRow);
    }

    public IXLTableRows InsertRowsBelow(int numberOfRows)
    {
      return XLHelper.InsertRowsWithoutEvents(new Func<int, bool, IXLRangeRows>(((XLRangeBase) this).InsertRowsBelow), this, numberOfRows, !this.Table.ShowTotalsRow);
    }

    public IXLRangeColumn Column(string column)
    {
      if (!XLHelper.IsValidColumn(column))
        return (IXLRangeColumn) this.Column(this._table.GetFieldIndex(column) + 1);
      int numberFromLetter = XLHelper.GetColumnNumberFromLetter(column);
      if (numberFromLetter <= this.ColumnCount())
        return (IXLRangeColumn) this.Column(numberFromLetter);
      return (IXLRangeColumn) this.Column(this._table.GetFieldIndex(column) + 1);
    }
  }
}

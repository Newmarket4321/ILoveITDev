// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLRange
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace ClosedXML.Excel
{
  internal class XLRange : XLRangeBase, IXLRange, IXLRangeBase, IDisposable
  {
    public XLRange(XLRangeParameters xlRangeParameters)
      : base(xlRangeParameters.RangeAddress)
    {
      this.RangeParameters = new XLRangeParameters(xlRangeParameters.RangeAddress, xlRangeParameters.DefaultStyle);
      if (!xlRangeParameters.IgnoreEvents)
      {
        this.SubscribeToShiftedRows((Action<XLRange, int>) ((range, rowShifted) => this.WorksheetRangeShiftedRows(range, rowShifted)));
        this.SubscribeToShiftedColumns((Action<XLRange, int>) ((range, columnsShifted) => this.WorksheetRangeShiftedColumns(range, columnsShifted)));
      }
      this.SetStyle(xlRangeParameters.DefaultStyle);
    }

    public XLRangeParameters RangeParameters { get; private set; }

    IXLRangeRow IXLRange.Row(int row)
    {
      return (IXLRangeRow) this.Row(row);
    }

    IXLRangeColumn IXLRange.Column(int column)
    {
      return (IXLRangeColumn) this.Column(column);
    }

    IXLRangeColumn IXLRange.Column(string column)
    {
      return (IXLRangeColumn) this.Column(column);
    }

    public IXLRangeColumns Columns(Func<IXLRangeColumn, bool> predicate = null)
    {
      XLRangeColumns xlRangeColumns = new XLRangeColumns();
      int num = this.ColumnCount();
      for (int column = 1; column <= num; ++column)
      {
        XLRangeColumn xlRangeColumn = this.Column(column);
        if (predicate == null || predicate((IXLRangeColumn) xlRangeColumn))
          xlRangeColumns.Add((IXLRangeColumn) xlRangeColumn);
        else
          xlRangeColumn.Dispose();
      }
      return (IXLRangeColumns) xlRangeColumns;
    }

    public virtual IXLRangeColumns Columns(int firstColumn, int lastColumn)
    {
      XLRangeColumns xlRangeColumns = new XLRangeColumns();
      for (int column = firstColumn; column <= lastColumn; ++column)
        xlRangeColumns.Add((IXLRangeColumn) this.Column(column));
      return (IXLRangeColumns) xlRangeColumns;
    }

    public IXLRangeColumns Columns(string firstColumn, string lastColumn)
    {
      return this.Columns(XLHelper.GetColumnNumberFromLetter(firstColumn), XLHelper.GetColumnNumberFromLetter(lastColumn));
    }

    public IXLRangeColumns Columns(string columns)
    {
      XLRangeColumns xlRangeColumns = new XLRangeColumns();
      foreach (string str1 in ((IEnumerable<string>) columns.Split(',')).Select<string, string>((Func<string, string>) (pair => pair.Trim())))
      {
        string str2;
        string str3;
        if (str1.Contains<char>(':') || str1.Contains<char>('-'))
        {
          string[] strArray = XLHelper.SplitRange(str1);
          str2 = strArray[0];
          str3 = strArray[1];
        }
        else
        {
          str2 = str1;
          str3 = str1;
        }
        int result;
        if (int.TryParse(str2, out result))
        {
          foreach (IXLRangeColumn column in (IEnumerable<IXLRangeColumn>) this.Columns(int.Parse(str2), int.Parse(str3)))
            xlRangeColumns.Add(column);
        }
        else
        {
          foreach (IXLRangeColumn column in (IEnumerable<IXLRangeColumn>) this.Columns(str2, str3))
            xlRangeColumns.Add(column);
        }
      }
      return (IXLRangeColumns) xlRangeColumns;
    }

    IXLCell IXLRange.Cell(int row, int column)
    {
      return (IXLCell) this.Cell(row, column);
    }

    IXLCell IXLRange.Cell(string cellAddressInRange)
    {
      return (IXLCell) this.Cell(cellAddressInRange);
    }

    IXLCell IXLRange.Cell(int row, string column)
    {
      return (IXLCell) this.Cell(row, column);
    }

    IXLCell IXLRange.Cell(IXLAddress cellAddressInRange)
    {
      return (IXLCell) this.Cell(cellAddressInRange);
    }

    IXLRange IXLRange.Range(IXLRangeAddress rangeAddress)
    {
      return (IXLRange) this.Range(rangeAddress);
    }

    IXLRange IXLRange.Range(string rangeAddress)
    {
      return (IXLRange) this.Range(rangeAddress);
    }

    IXLRange IXLRange.Range(IXLCell firstCell, IXLCell lastCell)
    {
      return (IXLRange) this.Range(firstCell, lastCell);
    }

    IXLRange IXLRange.Range(string firstCellAddress, string lastCellAddress)
    {
      return (IXLRange) this.Range(firstCellAddress, lastCellAddress);
    }

    IXLRange IXLRange.Range(IXLAddress firstCellAddress, IXLAddress lastCellAddress)
    {
      return (IXLRange) this.Range(firstCellAddress, lastCellAddress);
    }

    IXLRange IXLRange.Range(int firstCellRow, int firstCellColumn, int lastCellRow, int lastCellColumn)
    {
      return (IXLRange) this.Range(firstCellRow, firstCellColumn, lastCellRow, lastCellColumn);
    }

    public IXLRangeRows Rows(Func<IXLRangeRow, bool> predicate = null)
    {
      XLRangeRows xlRangeRows = new XLRangeRows();
      int num = this.RowCount();
      for (int row = 1; row <= num; ++row)
      {
        XLRangeRow xlRangeRow = this.Row(row);
        if (predicate == null || predicate((IXLRangeRow) xlRangeRow))
          xlRangeRows.Add((IXLRangeRow) this.Row(row));
        else
          xlRangeRow.Dispose();
      }
      return (IXLRangeRows) xlRangeRows;
    }

    public IXLRangeRows Rows(int firstRow, int lastRow)
    {
      XLRangeRows xlRangeRows = new XLRangeRows();
      for (int row = firstRow; row <= lastRow; ++row)
        xlRangeRows.Add((IXLRangeRow) this.Row(row));
      return (IXLRangeRows) xlRangeRows;
    }

    public IXLRangeRows Rows(string rows)
    {
      XLRangeRows xlRangeRows = new XLRangeRows();
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
        foreach (IXLRangeRow row in (IEnumerable<IXLRangeRow>) this.Rows(int.Parse(s1), int.Parse(s2)))
          xlRangeRows.Add(row);
      }
      return (IXLRangeRows) xlRangeRows;
    }

    public void Transpose(XLTransposeOptions transposeOption)
    {
      int num1 = this.RowCount();
      int num2 = this.ColumnCount();
      int squareSide = num1 > num2 ? num1 : num2;
      XLCell xlCell = this.FirstCell();
      this.MoveOrClearForTranspose(transposeOption, num1, num2);
      this.TransposeMerged(squareSide);
      this.TransposeRange(squareSide);
      this.RangeAddress.LastAddress = new XLAddress(this.Worksheet, xlCell.Address.RowNumber + num2 - 1, xlCell.Address.ColumnNumber + num1 - 1, this.RangeAddress.LastAddress.FixedRow, this.RangeAddress.LastAddress.FixedColumn);
      if (num1 > num2)
        this.Worksheet.Range(this.RangeAddress.LastAddress.RowNumber + 1, this.RangeAddress.FirstAddress.ColumnNumber, this.RangeAddress.LastAddress.RowNumber + (num1 - num2), this.RangeAddress.LastAddress.ColumnNumber).Delete(XLShiftDeletedCells.ShiftCellsUp);
      else if (num2 > num1)
        this.Worksheet.Range(this.RangeAddress.FirstAddress.RowNumber, this.RangeAddress.LastAddress.ColumnNumber + 1, this.RangeAddress.LastAddress.RowNumber, this.RangeAddress.LastAddress.ColumnNumber + (num2 - num1)).Delete(XLShiftDeletedCells.ShiftCellsLeft);
      foreach (IXLCell cell in (IEnumerable<IXLCell>) this.Range(1, 1, num2, num1).Cells())
      {
        XLBorder xlBorder = new XLBorder((IXLStylized) this, cell.Style.Border, true);
        cell.Style.Border.TopBorder = xlBorder.LeftBorder;
        cell.Style.Border.TopBorderColor = xlBorder.LeftBorderColor;
        cell.Style.Border.LeftBorder = xlBorder.TopBorder;
        cell.Style.Border.LeftBorderColor = xlBorder.TopBorderColor;
        cell.Style.Border.RightBorder = xlBorder.BottomBorder;
        cell.Style.Border.RightBorderColor = xlBorder.BottomBorderColor;
        cell.Style.Border.BottomBorder = xlBorder.RightBorder;
        cell.Style.Border.BottomBorderColor = xlBorder.RightBorderColor;
      }
    }

    public IXLTable AsTable()
    {
      return (IXLTable) new XLTable(this, false, true);
    }

    public IXLTable AsTable(string name)
    {
      return (IXLTable) new XLTable(this, name, false, true);
    }

    IXLTable IXLRange.CreateTable()
    {
      return (IXLTable) this.CreateTable();
    }

    public XLTable CreateTable()
    {
      return new XLTable(this, true, true);
    }

    IXLTable IXLRange.CreateTable(string name)
    {
      return (IXLTable) this.CreateTable(name);
    }

    public XLTable CreateTable(string name)
    {
      return new XLTable(this, name, true, true);
    }

    public IXLTable CreateTable(string name, bool setAutofilter)
    {
      return (IXLTable) new XLTable(this, name, true, setAutofilter);
    }

    public IXLRange CopyTo(IXLCell target)
    {
      base.CopyTo(target);
      int lastCellRow = target.Address.RowNumber + this.RowCount() - 1;
      if (lastCellRow > 1048576)
        lastCellRow = 1048576;
      int lastCellColumn = target.Address.ColumnNumber + this.ColumnCount() - 1;
      if (lastCellColumn > 16384)
        lastCellColumn = 16384;
      return target.Worksheet.Range(target.Address.RowNumber, target.Address.ColumnNumber, lastCellRow, lastCellColumn);
    }

    public IXLRange CopyTo(IXLRangeBase target)
    {
      base.CopyTo(target);
      int lastCellRow = target.RangeAddress.FirstAddress.RowNumber + this.RowCount() - 1;
      if (lastCellRow > 1048576)
        lastCellRow = 1048576;
      int lastCellColumn = target.RangeAddress.FirstAddress.ColumnNumber + this.ColumnCount() - 1;
      if (lastCellColumn > 16384)
        lastCellColumn = 16384;
      return target.Worksheet.Range(target.RangeAddress.FirstAddress.RowNumber, target.RangeAddress.FirstAddress.ColumnNumber, lastCellRow, lastCellColumn);
    }

    public IXLRange SetDataType(XLCellValues dataType)
    {
      this.DataType = dataType;
      return (IXLRange) this;
    }

    public IXLRange Sort()
    {
      return base.Sort().AsRange();
    }

    public IXLRange Sort(string columnsToSortBy, XLSortOrder sortOrder = XLSortOrder.Ascending, bool matchCase = false, bool ignoreBlanks = true)
    {
      return base.Sort(columnsToSortBy, sortOrder, matchCase, ignoreBlanks).AsRange();
    }

    public IXLRange Sort(int columnToSortBy, XLSortOrder sortOrder = XLSortOrder.Ascending, bool matchCase = false, bool ignoreBlanks = true)
    {
      return base.Sort(columnToSortBy, sortOrder, matchCase, ignoreBlanks).AsRange();
    }

    public IXLRange SortLeftToRight(XLSortOrder sortOrder = XLSortOrder.Ascending, bool matchCase = false, bool ignoreBlanks = true)
    {
      return base.SortLeftToRight(sortOrder, matchCase, ignoreBlanks).AsRange();
    }

    private void WorksheetRangeShiftedColumns(XLRange range, int columnsShifted)
    {
      this.ShiftColumns((IXLRangeAddress) this.RangeAddress, range, columnsShifted);
    }

    private void WorksheetRangeShiftedRows(XLRange range, int rowsShifted)
    {
      this.ShiftRows((IXLRangeAddress) this.RangeAddress, range, rowsShifted);
    }

    IXLRangeColumn IXLRange.FirstColumn(Func<IXLRangeColumn, bool> predicate)
    {
      return (IXLRangeColumn) this.FirstColumn(predicate);
    }

    public XLRangeColumn FirstColumn(Func<IXLRangeColumn, bool> predicate = null)
    {
      if (predicate == null)
        return this.Column(1);
      int num = this.ColumnCount();
      for (int column = 1; column <= num; ++column)
      {
        XLRangeColumn xlRangeColumn = this.Column(column);
        if (predicate((IXLRangeColumn) xlRangeColumn))
          return xlRangeColumn;
        xlRangeColumn.Dispose();
      }
      return (XLRangeColumn) null;
    }

    IXLRangeColumn IXLRange.LastColumn(Func<IXLRangeColumn, bool> predicate)
    {
      return (IXLRangeColumn) this.LastColumn(predicate);
    }

    public XLRangeColumn LastColumn(Func<IXLRangeColumn, bool> predicate = null)
    {
      int column1 = this.ColumnCount();
      if (predicate == null)
        return this.Column(column1);
      for (int column2 = column1; column2 >= 1; --column2)
      {
        XLRangeColumn xlRangeColumn = this.Column(column2);
        if (predicate((IXLRangeColumn) xlRangeColumn))
          return xlRangeColumn;
        xlRangeColumn.Dispose();
      }
      return (XLRangeColumn) null;
    }

    IXLRangeColumn IXLRange.FirstColumnUsed(Func<IXLRangeColumn, bool> predicate)
    {
      return (IXLRangeColumn) this.FirstColumnUsed(false, predicate);
    }

    public XLRangeColumn FirstColumnUsed(Func<IXLRangeColumn, bool> predicate = null)
    {
      return this.FirstColumnUsed(false, predicate);
    }

    IXLRangeColumn IXLRange.FirstColumnUsed(bool includeFormats, Func<IXLRangeColumn, bool> predicate)
    {
      return (IXLRangeColumn) this.FirstColumnUsed(includeFormats, predicate);
    }

    public XLRangeColumn FirstColumnUsed(bool includeFormats, Func<IXLRangeColumn, bool> predicate = null)
    {
      if (predicate == null)
      {
        int num = this.Worksheet.Internals.CellsCollection.FirstColumnUsed(this.RangeAddress.FirstAddress.RowNumber, this.RangeAddress.FirstAddress.ColumnNumber, this.RangeAddress.LastAddress.RowNumber, this.RangeAddress.LastAddress.ColumnNumber, includeFormats, (Func<IXLCell, bool>) null);
        if (num != 0)
          return this.Column(num - this.RangeAddress.FirstAddress.ColumnNumber + 1);
        return (XLRangeColumn) null;
      }
      int num1 = this.ColumnCount();
      for (int column = 1; column <= num1; ++column)
      {
        XLRangeColumn xlRangeColumn = this.Column(column);
        if (!xlRangeColumn.IsEmpty(includeFormats) && predicate((IXLRangeColumn) xlRangeColumn))
          return xlRangeColumn;
        xlRangeColumn.Dispose();
      }
      return (XLRangeColumn) null;
    }

    IXLRangeColumn IXLRange.LastColumnUsed(Func<IXLRangeColumn, bool> predicate)
    {
      return (IXLRangeColumn) this.LastColumnUsed(false, predicate);
    }

    public XLRangeColumn LastColumnUsed(Func<IXLRangeColumn, bool> predicate = null)
    {
      return this.LastColumnUsed(false, predicate);
    }

    IXLRangeColumn IXLRange.LastColumnUsed(bool includeFormats, Func<IXLRangeColumn, bool> predicate)
    {
      return (IXLRangeColumn) this.LastColumnUsed(includeFormats, predicate);
    }

    public XLRangeColumn LastColumnUsed(bool includeFormats, Func<IXLRangeColumn, bool> predicate = null)
    {
      if (predicate == null)
      {
        int num = this.Worksheet.Internals.CellsCollection.LastColumnUsed(this.RangeAddress.FirstAddress.RowNumber, this.RangeAddress.FirstAddress.ColumnNumber, this.RangeAddress.LastAddress.RowNumber, this.RangeAddress.LastAddress.ColumnNumber, includeFormats, (Func<IXLCell, bool>) null);
        if (num != 0)
          return this.Column(num - this.RangeAddress.FirstAddress.ColumnNumber + 1);
        return (XLRangeColumn) null;
      }
      for (int column = this.ColumnCount(); column >= 1; --column)
      {
        XLRangeColumn xlRangeColumn = this.Column(column);
        if (!xlRangeColumn.IsEmpty(includeFormats) && predicate((IXLRangeColumn) xlRangeColumn))
          return xlRangeColumn;
        xlRangeColumn.Dispose();
      }
      return (XLRangeColumn) null;
    }

    IXLRangeRow IXLRange.FirstRow(Func<IXLRangeRow, bool> predicate)
    {
      return (IXLRangeRow) this.FirstRow(predicate);
    }

    public XLRangeRow FirstRow(Func<IXLRangeRow, bool> predicate = null)
    {
      if (predicate == null)
        return this.Row(1);
      int num = this.RowCount();
      for (int row = 1; row <= num; ++row)
      {
        XLRangeRow xlRangeRow = this.Row(row);
        if (predicate((IXLRangeRow) xlRangeRow))
          return xlRangeRow;
        xlRangeRow.Dispose();
      }
      return (XLRangeRow) null;
    }

    IXLRangeRow IXLRange.LastRow(Func<IXLRangeRow, bool> predicate)
    {
      return (IXLRangeRow) this.LastRow(predicate);
    }

    public XLRangeRow LastRow(Func<IXLRangeRow, bool> predicate = null)
    {
      int row1 = this.RowCount();
      if (predicate == null)
        return this.Row(row1);
      for (int row2 = row1; row2 >= 1; --row2)
      {
        XLRangeRow xlRangeRow = this.Row(row2);
        if (predicate((IXLRangeRow) xlRangeRow))
          return xlRangeRow;
        xlRangeRow.Dispose();
      }
      return (XLRangeRow) null;
    }

    IXLRangeRow IXLRange.FirstRowUsed(Func<IXLRangeRow, bool> predicate)
    {
      return (IXLRangeRow) this.FirstRowUsed(false, predicate);
    }

    public XLRangeRow FirstRowUsed(Func<IXLRangeRow, bool> predicate = null)
    {
      return this.FirstRowUsed(false, predicate);
    }

    IXLRangeRow IXLRange.FirstRowUsed(bool includeFormats, Func<IXLRangeRow, bool> predicate)
    {
      return (IXLRangeRow) this.FirstRowUsed(includeFormats, predicate);
    }

    public XLRangeRow FirstRowUsed(bool includeFormats, Func<IXLRangeRow, bool> predicate = null)
    {
      if (predicate == null)
      {
        int num = this.Worksheet.Internals.CellsCollection.FirstRowUsed(this.RangeAddress.FirstAddress.RowNumber, this.RangeAddress.FirstAddress.ColumnNumber, this.RangeAddress.LastAddress.RowNumber, this.RangeAddress.LastAddress.ColumnNumber, includeFormats, (Func<IXLCell, bool>) null);
        if (num != 0)
          return this.Row(num - this.RangeAddress.FirstAddress.RowNumber + 1);
        return (XLRangeRow) null;
      }
      int num1 = this.RowCount();
      for (int row = 1; row <= num1; ++row)
      {
        XLRangeRow xlRangeRow = this.Row(row);
        if (!xlRangeRow.IsEmpty(includeFormats) && predicate((IXLRangeRow) xlRangeRow))
          return xlRangeRow;
        xlRangeRow.Dispose();
      }
      return (XLRangeRow) null;
    }

    IXLRangeRow IXLRange.LastRowUsed(Func<IXLRangeRow, bool> predicate)
    {
      return (IXLRangeRow) this.LastRowUsed(false, predicate);
    }

    public XLRangeRow LastRowUsed(Func<IXLRangeRow, bool> predicate = null)
    {
      return this.LastRowUsed(false, predicate);
    }

    IXLRangeRow IXLRange.LastRowUsed(bool includeFormats, Func<IXLRangeRow, bool> predicate)
    {
      return (IXLRangeRow) this.LastRowUsed(includeFormats, predicate);
    }

    public XLRangeRow LastRowUsed(bool includeFormats, Func<IXLRangeRow, bool> predicate = null)
    {
      if (predicate == null)
      {
        int num = this.Worksheet.Internals.CellsCollection.LastRowUsed(this.RangeAddress.FirstAddress.RowNumber, this.RangeAddress.FirstAddress.ColumnNumber, this.RangeAddress.LastAddress.RowNumber, this.RangeAddress.LastAddress.ColumnNumber, includeFormats, (Func<IXLCell, bool>) null);
        if (num != 0)
          return this.Row(num - this.RangeAddress.FirstAddress.RowNumber + 1);
        return (XLRangeRow) null;
      }
      for (int row = this.RowCount(); row >= 1; --row)
      {
        XLRangeRow xlRangeRow = this.Row(row);
        if (!xlRangeRow.IsEmpty(includeFormats) && predicate((IXLRangeRow) xlRangeRow))
          return xlRangeRow;
        xlRangeRow.Dispose();
      }
      return (XLRangeRow) null;
    }

    IXLRangeRows IXLRange.RowsUsed(bool includeFormats, Func<IXLRangeRow, bool> predicate)
    {
      return (IXLRangeRows) this.RowsUsed(includeFormats, predicate);
    }

    public XLRangeRows RowsUsed(bool includeFormats, Func<IXLRangeRow, bool> predicate = null)
    {
      XLRangeRows xlRangeRows = new XLRangeRows();
      int num = this.RowCount();
      for (int row = 1; row <= num; ++row)
      {
        XLRangeRow xlRangeRow = this.Row(row);
        if (!xlRangeRow.IsEmpty(includeFormats) && (predicate == null || predicate((IXLRangeRow) xlRangeRow)))
          xlRangeRows.Add((IXLRangeRow) xlRangeRow);
        else
          xlRangeRow.Dispose();
      }
      return xlRangeRows;
    }

    IXLRangeRows IXLRange.RowsUsed(Func<IXLRangeRow, bool> predicate)
    {
      return (IXLRangeRows) this.RowsUsed(predicate);
    }

    public XLRangeRows RowsUsed(Func<IXLRangeRow, bool> predicate = null)
    {
      return this.RowsUsed(false, predicate);
    }

    IXLRangeColumns IXLRange.ColumnsUsed(bool includeFormats, Func<IXLRangeColumn, bool> predicate)
    {
      return (IXLRangeColumns) this.ColumnsUsed(includeFormats, predicate);
    }

    public XLRangeColumns ColumnsUsed(bool includeFormats, Func<IXLRangeColumn, bool> predicate = null)
    {
      XLRangeColumns xlRangeColumns = new XLRangeColumns();
      int num = this.ColumnCount();
      for (int column = 1; column <= num; ++column)
      {
        XLRangeColumn xlRangeColumn = this.Column(column);
        if (!xlRangeColumn.IsEmpty(includeFormats) && (predicate == null || predicate((IXLRangeColumn) xlRangeColumn)))
          xlRangeColumns.Add((IXLRangeColumn) xlRangeColumn);
        else
          xlRangeColumn.Dispose();
      }
      return xlRangeColumns;
    }

    IXLRangeColumns IXLRange.ColumnsUsed(Func<IXLRangeColumn, bool> predicate)
    {
      return (IXLRangeColumns) this.ColumnsUsed(predicate);
    }

    public XLRangeColumns ColumnsUsed(Func<IXLRangeColumn, bool> predicate = null)
    {
      return this.ColumnsUsed(false, predicate);
    }

    public XLRangeRow Row(int row)
    {
      if (row <= 0 || row > 1048576)
        throw new IndexOutOfRangeException(string.Format("Row number must be between 1 and {0}", (object) 1048576));
      return new XLRangeRow(new XLRangeParameters(new XLRangeAddress(new XLAddress(this.Worksheet, this.RangeAddress.FirstAddress.RowNumber + row - 1, this.RangeAddress.FirstAddress.ColumnNumber, false, false), new XLAddress(this.Worksheet, this.RangeAddress.FirstAddress.RowNumber + row - 1, this.RangeAddress.LastAddress.ColumnNumber, false, false)), this.Worksheet.Style), false);
    }

    public XLRangeColumn Column(int column)
    {
      if (column <= 0 || column > 16384)
        throw new IndexOutOfRangeException(string.Format("Column number must be between 1 and {0}", (object) 16384));
      return new XLRangeColumn(new XLRangeParameters(new XLRangeAddress(new XLAddress(this.Worksheet, this.RangeAddress.FirstAddress.RowNumber, this.RangeAddress.FirstAddress.ColumnNumber + column - 1, false, false), new XLAddress(this.Worksheet, this.RangeAddress.LastAddress.RowNumber, this.RangeAddress.FirstAddress.ColumnNumber + column - 1, false, false)), this.Worksheet.Style), false);
    }

    public XLRangeColumn Column(string column)
    {
      return this.Column(XLHelper.GetColumnNumberFromLetter(column));
    }

    private void TransposeRange(int squareSide)
    {
      Dictionary<XLSheetPoint, XLCell> source = new Dictionary<XLSheetPoint, XLCell>();
      List<XLSheetPoint> xlSheetPointList = new List<XLSheetPoint>();
      XLRange xlRange = this.Worksheet.Range(this.RangeAddress.FirstAddress.RowNumber, this.RangeAddress.FirstAddress.ColumnNumber, this.RangeAddress.FirstAddress.RowNumber + squareSide - 1, this.RangeAddress.FirstAddress.ColumnNumber + squareSide - 1);
      int num1 = xlRange.RowCount();
      int num2 = xlRange.ColumnCount();
      for (int index1 = 1; index1 <= num1; ++index1)
      {
        for (int index2 = 1; index2 <= num2; ++index2)
        {
          XLCell otherCell = xlRange.Cell(index1, index2);
          XLAddress address = xlRange.Cell(index2, index1).Address;
          XLCell xlCell = new XLCell(this.Worksheet, address, otherCell.GetStyleId());
          xlCell.CopyFrom(otherCell, true);
          source.Add(new XLSheetPoint(address.RowNumber, address.ColumnNumber), xlCell);
          xlSheetPointList.Add(new XLSheetPoint(otherCell.Address.RowNumber, otherCell.Address.ColumnNumber));
        }
      }
      xlSheetPointList.ForEach((Action<XLSheetPoint>) (c => this.Worksheet.Internals.CellsCollection.Remove(c)));
      source.ForEach<KeyValuePair<XLSheetPoint, XLCell>>((Action<KeyValuePair<XLSheetPoint, XLCell>>) (c => this.Worksheet.Internals.CellsCollection.Add(c.Key, c.Value)));
    }

    private void TransposeMerged(int squareSide)
    {
      XLRange xlRange1 = this.Worksheet.Range(this.RangeAddress.FirstAddress.RowNumber, this.RangeAddress.FirstAddress.ColumnNumber, this.RangeAddress.FirstAddress.RowNumber + squareSide - 1, this.RangeAddress.FirstAddress.ColumnNumber + squareSide - 1);
      foreach (IXLRange xlRange2 in this.Worksheet.Internals.MergedRanges.Where<IXLRange>(new Func<IXLRange, bool>(((XLRangeBase) this).Contains)))
        xlRange2.RangeAddress.LastAddress = (IXLAddress) xlRange1.Cell(xlRange2.ColumnCount(), xlRange2.RowCount()).Address;
    }

    private void MoveOrClearForTranspose(XLTransposeOptions transposeOption, int rowCount, int columnCount)
    {
      if (transposeOption == XLTransposeOptions.MoveCells)
      {
        if (rowCount > columnCount)
        {
          this.InsertColumnsAfter(false, rowCount - columnCount, false);
        }
        else
        {
          if (columnCount <= rowCount)
            return;
          this.InsertRowsBelow(false, columnCount - rowCount, false);
        }
      }
      else if (rowCount > columnCount)
      {
        this.Worksheet.Range(this.RangeAddress.FirstAddress.RowNumber, this.RangeAddress.LastAddress.ColumnNumber + 1, this.RangeAddress.LastAddress.RowNumber, this.RangeAddress.LastAddress.ColumnNumber + (rowCount - columnCount)).Clear(XLClearOptions.ContentsAndFormats);
      }
      else
      {
        if (columnCount <= rowCount)
          return;
        this.Worksheet.Range(this.RangeAddress.LastAddress.RowNumber + 1, this.RangeAddress.FirstAddress.ColumnNumber, this.RangeAddress.LastAddress.RowNumber + (columnCount - rowCount), this.RangeAddress.LastAddress.ColumnNumber).Clear(XLClearOptions.ContentsAndFormats);
      }
    }

    public override bool Equals(object obj)
    {
      XLRange xlRange = (XLRange) obj;
      if (this.RangeAddress.Equals((object) xlRange.RangeAddress))
        return this.Worksheet.Equals((object) xlRange.Worksheet);
      return false;
    }

    public override int GetHashCode()
    {
      return this.RangeAddress.GetHashCode() ^ this.Worksheet.GetHashCode();
    }

    public IXLRange Clear(XLClearOptions clearOptions = XLClearOptions.ContentsAndFormats)
    {
      base.Clear(clearOptions);
      return (IXLRange) this;
    }
  }
}

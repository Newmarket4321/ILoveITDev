// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLRange
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;

namespace ClosedXML.Excel
{
  public interface IXLRange : IXLRangeBase, IDisposable
  {
    IXLCell Cell(int row, int column);

    IXLCell Cell(string cellAddressInRange);

    IXLCell Cell(int row, string column);

    IXLCell Cell(IXLAddress cellAddressInRange);

    IXLRangeColumn Column(int column);

    IXLRangeColumn Column(string column);

    IXLRangeColumn FirstColumn(Func<IXLRangeColumn, bool> predicate = null);

    IXLRangeColumn FirstColumnUsed(bool includeFormats, Func<IXLRangeColumn, bool> predicate = null);

    IXLRangeColumn FirstColumnUsed(Func<IXLRangeColumn, bool> predicate = null);

    IXLRangeColumn LastColumn(Func<IXLRangeColumn, bool> predicate = null);

    IXLRangeColumn LastColumnUsed(bool includeFormats, Func<IXLRangeColumn, bool> predicate = null);

    IXLRangeColumn LastColumnUsed(Func<IXLRangeColumn, bool> predicate = null);

    IXLRangeColumns Columns(Func<IXLRangeColumn, bool> predicate = null);

    IXLRangeColumns Columns(int firstColumn, int lastColumn);

    IXLRangeColumns Columns(string firstColumn, string lastColumn);

    IXLRangeColumns Columns(string columns);

    IXLRangeRow FirstRow(Func<IXLRangeRow, bool> predicate = null);

    IXLRangeRow FirstRowUsed(bool includeFormats, Func<IXLRangeRow, bool> predicate = null);

    IXLRangeRow FirstRowUsed(Func<IXLRangeRow, bool> predicate = null);

    IXLRangeRow LastRow(Func<IXLRangeRow, bool> predicate = null);

    IXLRangeRow LastRowUsed(bool includeFormats, Func<IXLRangeRow, bool> predicate = null);

    IXLRangeRow LastRowUsed(Func<IXLRangeRow, bool> predicate = null);

    IXLRangeRow Row(int row);

    IXLRangeRows Rows(Func<IXLRangeRow, bool> predicate = null);

    IXLRangeRows Rows(int firstRow, int lastRow);

    IXLRangeRows Rows(string rows);

    IXLRange Range(IXLRangeAddress rangeAddress);

    IXLRange Range(string rangeAddress);

    IXLRange Range(IXLCell firstCell, IXLCell lastCell);

    IXLRange Range(string firstCellAddress, string lastCellAddress);

    IXLRange Range(IXLAddress firstCellAddress, IXLAddress lastCellAddress);

    IXLRanges Ranges(string ranges);

    IXLRange Range(int firstCellRow, int firstCellColumn, int lastCellRow, int lastCellColumn);

    int RowCount();

    int ColumnCount();

    IXLRangeColumns InsertColumnsAfter(int numberOfColumns);

    IXLRangeColumns InsertColumnsAfter(int numberOfColumns, bool expandRange);

    IXLRangeColumns InsertColumnsBefore(int numberOfColumns);

    IXLRangeColumns InsertColumnsBefore(int numberOfColumns, bool expandRange);

    IXLRangeRows InsertRowsAbove(int numberOfRows);

    IXLRangeRows InsertRowsAbove(int numberOfRows, bool expandRange);

    IXLRangeRows InsertRowsBelow(int numberOfRows);

    IXLRangeRows InsertRowsBelow(int numberOfRows, bool expandRange);

    void Delete(XLShiftDeletedCells shiftDeleteCells);

    void Transpose(XLTransposeOptions transposeOption);

    IXLTable AsTable();

    IXLTable AsTable(string name);

    IXLTable CreateTable();

    IXLTable CreateTable(string name);

    IXLRange RangeUsed();

    IXLRange CopyTo(IXLCell target);

    IXLRange CopyTo(IXLRangeBase target);

    IXLSortElements SortRows { get; }

    IXLSortElements SortColumns { get; }

    IXLRange Sort();

    IXLRange Sort(string columnsToSortBy, XLSortOrder sortOrder = XLSortOrder.Ascending, bool matchCase = false, bool ignoreBlanks = true);

    IXLRange Sort(int columnToSortBy, XLSortOrder sortOrder = XLSortOrder.Ascending, bool matchCase = false, bool ignoreBlanks = true);

    IXLRange SortLeftToRight(XLSortOrder sortOrder = XLSortOrder.Ascending, bool matchCase = false, bool ignoreBlanks = true);

    IXLRange SetDataType(XLCellValues dataType);

    IXLRange Clear(XLClearOptions clearOptions = XLClearOptions.ContentsAndFormats);

    IXLRangeRows RowsUsed(bool includeFormats, Func<IXLRangeRow, bool> predicate = null);

    IXLRangeRows RowsUsed(Func<IXLRangeRow, bool> predicate = null);

    IXLRangeColumns ColumnsUsed(bool includeFormats, Func<IXLRangeColumn, bool> predicate = null);

    IXLRangeColumns ColumnsUsed(Func<IXLRangeColumn, bool> predicate = null);
  }
}

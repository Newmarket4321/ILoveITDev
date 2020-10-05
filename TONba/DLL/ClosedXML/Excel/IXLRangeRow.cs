// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLRangeRow
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;

namespace ClosedXML.Excel
{
  public interface IXLRangeRow : IXLRangeBase, IDisposable
  {
    IXLCell Cell(int columnNumber);

    IXLCell Cell(string columnLetter);

    new IXLCells Cells(string cellsInRow);

    IXLCells Cells(int firstColumn, int lastColumn);

    IXLCells Cells(string firstColumn, string lastColumn);

    IXLCells InsertCellsAfter(int numberOfColumns);

    IXLCells InsertCellsAfter(int numberOfColumns, bool expandRange);

    IXLCells InsertCellsBefore(int numberOfColumns);

    IXLCells InsertCellsBefore(int numberOfColumns, bool expandRange);

    IXLRangeRows InsertRowsAbove(int numberOfRows);

    IXLRangeRows InsertRowsAbove(int numberOfRows, bool expandRange);

    IXLRangeRows InsertRowsBelow(int numberOfRows);

    IXLRangeRows InsertRowsBelow(int numberOfRows, bool expandRange);

    void Delete();

    void Delete(XLShiftDeletedCells shiftDeleteCells);

    int RowNumber();

    int CellCount();

    IXLRangeRow CopyTo(IXLCell target);

    IXLRangeRow CopyTo(IXLRangeBase target);

    IXLRangeRow Sort();

    IXLRangeRow SortLeftToRight(XLSortOrder sortOrder = XLSortOrder.Ascending, bool matchCase = false, bool ignoreBlanks = true);

    IXLRangeRow Row(int start, int end);

    IXLRangeRow Row(IXLCell start, IXLCell end);

    IXLRangeRows Rows(string rows);

    IXLRangeRow SetDataType(XLCellValues dataType);

    IXLRangeRow RowAbove();

    IXLRangeRow RowAbove(int step);

    IXLRangeRow RowBelow();

    IXLRangeRow RowBelow(int step);

    IXLRow WorksheetRow();

    IXLRangeRow Clear(XLClearOptions clearOptions = XLClearOptions.ContentsAndFormats);

    IXLRangeRow RowUsed(bool includeFormats = false);
  }
}

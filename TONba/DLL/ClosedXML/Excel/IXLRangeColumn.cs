// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLRangeColumn
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;

namespace ClosedXML.Excel
{
  public interface IXLRangeColumn : IXLRangeBase, IDisposable
  {
    IXLCell Cell(int rowNumber);

    new IXLCells Cells(string cellsInColumn);

    IXLCells Cells(int firstRow, int lastRow);

    IXLRangeColumns InsertColumnsAfter(int numberOfColumns);

    IXLRangeColumns InsertColumnsAfter(int numberOfColumns, bool expandRange);

    IXLRangeColumns InsertColumnsBefore(int numberOfColumns);

    IXLRangeColumns InsertColumnsBefore(int numberOfColumns, bool expandRange);

    IXLCells InsertCellsAbove(int numberOfRows);

    IXLCells InsertCellsAbove(int numberOfRows, bool expandRange);

    IXLCells InsertCellsBelow(int numberOfRows);

    IXLCells InsertCellsBelow(int numberOfRows, bool expandRange);

    void Delete();

    void Delete(XLShiftDeletedCells shiftDeleteCells);

    int ColumnNumber();

    string ColumnLetter();

    int CellCount();

    IXLRangeColumn CopyTo(IXLCell target);

    IXLRangeColumn CopyTo(IXLRangeBase target);

    IXLRangeColumn Sort(XLSortOrder sortOrder = XLSortOrder.Ascending, bool matchCase = false, bool ignoreBlanks = true);

    IXLRangeColumn Column(int start, int end);

    IXLRangeColumn Column(IXLCell start, IXLCell end);

    IXLRangeColumns Columns(string columns);

    IXLRangeColumn SetDataType(XLCellValues dataType);

    IXLRangeColumn ColumnLeft();

    IXLRangeColumn ColumnLeft(int step);

    IXLRangeColumn ColumnRight();

    IXLRangeColumn ColumnRight(int step);

    IXLColumn WorksheetColumn();

    IXLTable AsTable();

    IXLTable AsTable(string name);

    IXLTable CreateTable();

    IXLTable CreateTable(string name);

    IXLRangeColumn Clear(XLClearOptions clearOptions = XLClearOptions.ContentsAndFormats);

    IXLRangeColumn ColumnUsed(bool includeFormats = false);
  }
}

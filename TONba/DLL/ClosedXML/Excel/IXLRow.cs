// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLRow
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;

namespace ClosedXML.Excel
{
  public interface IXLRow : IXLRangeBase, IDisposable
  {
    double Height { get; set; }

    void Delete();

    int RowNumber();

    IXLRows InsertRowsBelow(int numberOfRows);

    IXLRows InsertRowsAbove(int numberOfRows);

    IXLRow AdjustToContents();

    IXLRow AdjustToContents(int startColumn);

    IXLRow AdjustToContents(int startColumn, int endColumn);

    IXLRow AdjustToContents(double minHeight, double maxHeight);

    IXLRow AdjustToContents(int startColumn, double minHeight, double maxHeight);

    IXLRow AdjustToContents(int startColumn, int endColumn, double minHeight, double maxHeight);

    IXLRow Hide();

    IXLRow Unhide();

    bool IsHidden { get; }

    int OutlineLevel { get; set; }

    IXLRow Group();

    IXLRow Group(bool collapse);

    IXLRow Group(int outlineLevel);

    IXLRow Group(int outlineLevel, bool collapse);

    IXLRow Ungroup();

    IXLRow Ungroup(bool fromAll);

    IXLRow Collapse();

    IXLCell Cell(int columnNumber);

    IXLCell Cell(string columnLetter);

    new IXLCells Cells(string cellsInRow);

    IXLCells Cells(int firstColumn, int lastColumn);

    IXLCells Cells(string firstColumn, string lastColumn);

    IXLRow Expand();

    int CellCount();

    IXLRangeRow CopyTo(IXLCell cell);

    IXLRangeRow CopyTo(IXLRangeBase range);

    IXLRow CopyTo(IXLRow row);

    IXLRow Sort();

    IXLRow SortLeftToRight(XLSortOrder sortOrder = XLSortOrder.Ascending, bool matchCase = false, bool ignoreBlanks = true);

    IXLRangeRow Row(int start, int end);

    IXLRangeRow Row(IXLCell start, IXLCell end);

    IXLRangeRows Rows(string columns);

    IXLRow AddHorizontalPageBreak();

    IXLRow SetDataType(XLCellValues dataType);

    IXLRow RowAbove();

    IXLRow RowAbove(int step);

    IXLRow RowBelow();

    IXLRow RowBelow(int step);

    IXLRow Clear(XLClearOptions clearOptions = XLClearOptions.ContentsAndFormats);

    IXLRangeRow RowUsed(bool includeFormats = false);
  }
}

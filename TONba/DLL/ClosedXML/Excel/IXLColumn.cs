// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLColumn
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;

namespace ClosedXML.Excel
{
  public interface IXLColumn : IXLRangeBase, IDisposable
  {
    double Width { get; set; }

    void Delete();

    int ColumnNumber();

    string ColumnLetter();

    IXLColumns InsertColumnsAfter(int numberOfColumns);

    IXLColumns InsertColumnsBefore(int numberOfColumns);

    IXLCell Cell(int rowNumber);

    new IXLCells Cells(string cellsInColumn);

    IXLCells Cells(int firstRow, int lastRow);

    IXLColumn AdjustToContents();

    IXLColumn AdjustToContents(int startRow);

    IXLColumn AdjustToContents(int startRow, int endRow);

    IXLColumn AdjustToContents(double minWidth, double maxWidth);

    IXLColumn AdjustToContents(int startRow, double minWidth, double maxWidth);

    IXLColumn AdjustToContents(int startRow, int endRow, double minWidth, double maxWidth);

    IXLColumn Hide();

    IXLColumn Unhide();

    bool IsHidden { get; }

    int OutlineLevel { get; set; }

    IXLColumn Group();

    IXLColumn Group(bool collapse);

    IXLColumn Group(int outlineLevel);

    IXLColumn Group(int outlineLevel, bool collapse);

    IXLColumn Ungroup();

    IXLColumn Ungroup(bool fromAll);

    IXLColumn Collapse();

    IXLColumn Expand();

    int CellCount();

    IXLRangeColumn CopyTo(IXLCell cell);

    IXLRangeColumn CopyTo(IXLRangeBase range);

    IXLColumn CopyTo(IXLColumn column);

    IXLColumn Sort(XLSortOrder sortOrder = XLSortOrder.Ascending, bool matchCase = false, bool ignoreBlanks = true);

    IXLRangeColumn Column(int start, int end);

    IXLRangeColumn Column(IXLCell start, IXLCell end);

    IXLRangeColumns Columns(string columns);

    IXLColumn AddVerticalPageBreak();

    IXLColumn SetDataType(XLCellValues dataType);

    IXLColumn ColumnLeft();

    IXLColumn ColumnLeft(int step);

    IXLColumn ColumnRight();

    IXLColumn ColumnRight(int step);

    IXLColumn Clear(XLClearOptions clearOptions = XLClearOptions.ContentsAndFormats);

    IXLRangeColumn ColumnUsed(bool includeFormats = false);
  }
}

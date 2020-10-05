// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLWorksheet
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;

namespace ClosedXML.Excel
{
  public interface IXLWorksheet : IXLRangeBase, IDisposable
  {
    XLWorkbook Workbook { get; }

    double ColumnWidth { get; set; }

    double RowHeight { get; set; }

    string Name { get; set; }

    int Position { get; set; }

    IXLPageSetup PageSetup { get; }

    IXLOutline Outline { get; }

    IXLRow FirstRow();

    IXLRow FirstRowUsed();

    IXLRow FirstRowUsed(bool includeFormats);

    IXLRow LastRow();

    IXLRow LastRowUsed();

    IXLRow LastRowUsed(bool includeFormats);

    IXLColumn FirstColumn();

    IXLColumn FirstColumnUsed();

    IXLColumn FirstColumnUsed(bool includeFormats);

    IXLColumn LastColumn();

    IXLColumn LastColumnUsed();

    IXLColumn LastColumnUsed(bool includeFormats);

    IXLColumns Columns();

    IXLColumns Columns(string columns);

    IXLColumns Columns(string firstColumn, string lastColumn);

    IXLColumns Columns(int firstColumn, int lastColumn);

    IXLRows Rows();

    IXLRows Rows(string rows);

    IXLRows Rows(int firstRow, int lastRow);

    IXLRow Row(int row);

    IXLColumn Column(int column);

    IXLColumn Column(string column);

    IXLCell Cell(int row, int column);

    IXLCell Cell(string cellAddressInRange);

    IXLCell Cell(int row, string column);

    IXLCell Cell(IXLAddress cellAddressInRange);

    IXLRange Range(IXLRangeAddress rangeAddress);

    IXLRange Range(string rangeAddress);

    IXLRange Range(IXLCell firstCell, IXLCell lastCell);

    IXLRange Range(string firstCellAddress, string lastCellAddress);

    IXLRange Range(IXLAddress firstCellAddress, IXLAddress lastCellAddress);

    IXLRanges Ranges(string ranges);

    IXLRange Range(int firstCellRow, int firstCellColumn, int lastCellRow, int lastCellColumn);

    int RowCount();

    int ColumnCount();

    IXLWorksheet CollapseRows();

    IXLWorksheet CollapseColumns();

    IXLWorksheet ExpandRows();

    IXLWorksheet ExpandColumns();

    IXLWorksheet CollapseRows(int outlineLevel);

    IXLWorksheet CollapseColumns(int outlineLevel);

    IXLWorksheet ExpandRows(int outlineLevel);

    IXLWorksheet ExpandColumns(int outlineLevel);

    void Delete();

    IXLNamedRanges NamedRanges { get; }

    IXLNamedRange NamedRange(string rangeName);

    IXLSheetView SheetView { get; }

    IXLTable Table(int index);

    IXLTable Table(string name);

    IXLTables Tables { get; }

    IXLWorksheet CopyTo(string newSheetName);

    IXLWorksheet CopyTo(string newSheetName, int position);

    IXLWorksheet CopyTo(XLWorkbook workbook, string newSheetName);

    IXLWorksheet CopyTo(XLWorkbook workbook, string newSheetName, int position);

    IXLRange RangeUsed();

    IXLRange RangeUsed(bool includeFormats);

    IXLDataValidations DataValidations { get; }

    XLWorksheetVisibility Visibility { get; set; }

    IXLWorksheet Hide();

    IXLWorksheet Unhide();

    IXLSheetProtection Protection { get; }

    IXLSheetProtection Protect();

    IXLSheetProtection Protect(string password);

    IXLSheetProtection Unprotect();

    IXLSheetProtection Unprotect(string password);

    IXLSortElements SortRows { get; }

    IXLSortElements SortColumns { get; }

    IXLRange Sort();

    IXLRange Sort(string columnsToSortBy, XLSortOrder sortOrder = XLSortOrder.Ascending, bool matchCase = false, bool ignoreBlanks = true);

    IXLRange Sort(int columnToSortBy, XLSortOrder sortOrder = XLSortOrder.Ascending, bool matchCase = false, bool ignoreBlanks = true);

    IXLRange SortLeftToRight(XLSortOrder sortOrder = XLSortOrder.Ascending, bool matchCase = false, bool ignoreBlanks = true);

    bool ShowFormulas { get; set; }

    bool ShowGridLines { get; set; }

    bool ShowOutlineSymbols { get; set; }

    bool ShowRowColHeaders { get; set; }

    bool ShowRuler { get; set; }

    bool ShowWhiteSpace { get; set; }

    bool ShowZeros { get; set; }

    IXLWorksheet SetShowFormulas();

    IXLWorksheet SetShowFormulas(bool value);

    IXLWorksheet SetShowGridLines();

    IXLWorksheet SetShowGridLines(bool value);

    IXLWorksheet SetShowOutlineSymbols();

    IXLWorksheet SetShowOutlineSymbols(bool value);

    IXLWorksheet SetShowRowColHeaders();

    IXLWorksheet SetShowRowColHeaders(bool value);

    IXLWorksheet SetShowRuler();

    IXLWorksheet SetShowRuler(bool value);

    IXLWorksheet SetShowWhiteSpace();

    IXLWorksheet SetShowWhiteSpace(bool value);

    IXLWorksheet SetShowZeros();

    IXLWorksheet SetShowZeros(bool value);

    XLColor TabColor { get; set; }

    IXLWorksheet SetTabColor(XLColor color);

    bool TabSelected { get; set; }

    bool TabActive { get; set; }

    IXLWorksheet SetTabSelected();

    IXLWorksheet SetTabSelected(bool value);

    IXLWorksheet SetTabActive();

    IXLWorksheet SetTabActive(bool value);

    IXLPivotTable PivotTable(string name);

    IXLPivotTables PivotTables { get; }

    bool RightToLeft { get; set; }

    IXLWorksheet SetRightToLeft();

    IXLWorksheet SetRightToLeft(bool value);

    IXLBaseAutoFilter AutoFilter { get; }

    IXLRows RowsUsed(bool includeFormats = false, Func<IXLRow, bool> predicate = null);

    IXLRows RowsUsed(Func<IXLRow, bool> predicate);

    IXLColumns ColumnsUsed(bool includeFormats = false, Func<IXLColumn, bool> predicate = null);

    IXLColumns ColumnsUsed(Func<IXLColumn, bool> predicate);

    IXLRanges MergedRanges { get; }

    IXLConditionalFormats ConditionalFormats { get; }

    IXLRanges SelectedRanges { get; }

    IXLCell ActiveCell { get; set; }

    object Evaluate(string expression);

    string Author { get; set; }
  }
}

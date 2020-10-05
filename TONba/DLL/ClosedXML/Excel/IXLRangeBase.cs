// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLRangeBase
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;

namespace ClosedXML.Excel
{
  public interface IXLRangeBase : IDisposable
  {
    IXLWorksheet Worksheet { get; }

    IXLRangeAddress RangeAddress { get; }

    object Value { set; }

    XLCellValues DataType { set; }

    string FormulaA1 { set; }

    string FormulaR1C1 { set; }

    IXLStyle Style { get; set; }

    bool ShareString { set; }

    IXLHyperlinks Hyperlinks { get; }

    IXLCells Cells();

    IXLCells Cells(string cells);

    IXLCells Cells(Func<IXLCell, bool> predicate);

    IXLCells CellsUsed();

    IXLCells CellsUsed(bool includeFormats);

    IXLCells CellsUsed(Func<IXLCell, bool> predicate);

    IXLCells CellsUsed(bool includeFormats, Func<IXLCell, bool> predicate);

    IXLCell FirstCell();

    IXLCell FirstCellUsed();

    IXLCell FirstCellUsed(bool includeFormats);

    IXLCell FirstCellUsed(Func<IXLCell, bool> predicate);

    IXLCell FirstCellUsed(bool includeFormats, Func<IXLCell, bool> predicate);

    IXLCell LastCell();

    IXLCell LastCellUsed();

    IXLCell LastCellUsed(bool includeFormats);

    IXLCell LastCellUsed(Func<IXLCell, bool> predicate);

    IXLCell LastCellUsed(bool includeFormats, Func<IXLCell, bool> predicate);

    bool Contains(string rangeAddress);

    bool Contains(IXLRangeBase range);

    bool Contains(IXLCell cell);

    bool Intersects(string rangeAddress);

    bool Intersects(IXLRangeBase range);

    IXLRange Unmerge();

    IXLRange Merge();

    IXLRange Merge(bool checkIntersect);

    IXLRange AddToNamed(string rangeName);

    IXLRange AddToNamed(string rangeName, XLScope scope);

    IXLRange AddToNamed(string rangeName, XLScope scope, string comment);

    IXLRangeBase Clear(XLClearOptions clearOptions = XLClearOptions.ContentsAndFormats);

    void DeleteComments();

    IXLRangeBase SetValue<T>(T value);

    IXLRange AsRange();

    bool IsMerged();

    bool IsEmpty();

    bool IsEmpty(bool includeFormats);

    IXLPivotTable CreatePivotTable(IXLCell targetCell);

    IXLPivotTable CreatePivotTable(IXLCell targetCell, string name);

    IXLAutoFilter SetAutoFilter();

    IXLDataValidation SetDataValidation();

    IXLConditionalFormat AddConditionalFormat();

    void Select();
  }
}

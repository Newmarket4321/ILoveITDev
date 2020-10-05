// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLTableRow
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;

namespace ClosedXML.Excel
{
  public interface IXLTableRow : IXLRangeRow, IXLRangeBase, IDisposable
  {
    IXLCell Field(int index);

    IXLCell Field(string name);

    IXLTableRow Sort();

    IXLTableRow SortLeftToRight(XLSortOrder sortOrder = XLSortOrder.Ascending, bool matchCase = false, bool ignoreBlanks = true);

    IXLTableRow RowAbove();

    IXLTableRow RowAbove(int step);

    IXLTableRow RowBelow();

    IXLTableRow RowBelow(int step);

    IXLTableRow Clear(XLClearOptions clearOptions = XLClearOptions.ContentsAndFormats);

    IXLTableRows InsertRowsAbove(int numberOfRows);

    IXLTableRows InsertRowsBelow(int numberOfRows);
  }
}

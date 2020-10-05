// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLTableRange
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;

namespace ClosedXML.Excel
{
  public interface IXLTableRange : IXLRange, IXLRangeBase, IDisposable
  {
    IXLTableRow FirstRow(Func<IXLTableRow, bool> predicate = null);

    IXLTableRow FirstRowUsed(bool includeFormats, Func<IXLTableRow, bool> predicate = null);

    IXLTableRow FirstRowUsed(Func<IXLTableRow, bool> predicate = null);

    IXLTableRow LastRow(Func<IXLTableRow, bool> predicate = null);

    IXLTableRow LastRowUsed(bool includeFormats, Func<IXLTableRow, bool> predicate = null);

    IXLTableRow LastRowUsed(Func<IXLTableRow, bool> predicate = null);

    IXLTableRow Row(int row);

    IXLTableRows Rows(Func<IXLTableRow, bool> predicate = null);

    IXLTableRows Rows(int firstRow, int lastRow);

    IXLTableRows Rows(string rows);

    IXLTableRows RowsUsed(bool includeFormats, Func<IXLTableRow, bool> predicate = null);

    IXLTableRows RowsUsed(Func<IXLTableRow, bool> predicate = null);

    IXLTable Table { get; }

    IXLTableRows InsertRowsAbove(int numberOfRows);

    IXLTableRows InsertRowsBelow(int numberOfRows);
  }
}

// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLWorksheetInternals
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;

namespace ClosedXML.Excel
{
  internal class XLWorksheetInternals : IDisposable
  {
    public XLWorksheetInternals(XLCellsCollection cellsCollection, XLColumnsCollection columnsCollection, XLRowsCollection rowsCollection, XLRanges mergedRanges)
    {
      this.CellsCollection = cellsCollection;
      this.ColumnsCollection = columnsCollection;
      this.RowsCollection = rowsCollection;
      this.MergedRanges = mergedRanges;
    }

    public XLCellsCollection CellsCollection { get; private set; }

    public XLColumnsCollection ColumnsCollection { get; private set; }

    public XLRowsCollection RowsCollection { get; private set; }

    public XLRanges MergedRanges { get; internal set; }

    public void Dispose()
    {
      this.ColumnsCollection.Dispose();
      this.RowsCollection.Dispose();
      this.MergedRanges.Dispose();
    }
  }
}

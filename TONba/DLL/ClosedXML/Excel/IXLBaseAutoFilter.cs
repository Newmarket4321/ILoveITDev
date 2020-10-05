// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLBaseAutoFilter
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  public interface IXLBaseAutoFilter
  {
    bool Enabled { get; set; }

    IXLRange Range { get; set; }

    IXLBaseAutoFilter Set(IXLRangeBase range);

    IXLBaseAutoFilter Clear();

    IXLFilterColumn Column(string column);

    IXLFilterColumn Column(int column);

    IXLBaseAutoFilter Sort(int columnToSortBy, XLSortOrder sortOrder = XLSortOrder.Ascending, bool matchCase = false, bool ignoreBlanks = true);

    bool Sorted { get; set; }

    XLSortOrder SortOrder { get; set; }

    int SortColumn { get; set; }
  }
}

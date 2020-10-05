// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLNamedRange
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  public interface IXLNamedRange
  {
    string Name { get; set; }

    IXLRanges Ranges { get; }

    string Comment { get; set; }

    IXLRanges Add(XLWorkbook workbook, string rangeAddress);

    IXLRanges Add(IXLRange range);

    IXLRanges Add(IXLRanges ranges);

    void Delete();

    void Clear();

    void Remove(string rangeAddress);

    void Remove(IXLRange range);

    void Remove(IXLRanges ranges);

    IXLNamedRange SetRefersTo(string range);

    IXLNamedRange SetRefersTo(IXLRangeBase range);

    IXLNamedRange SetRefersTo(IXLRanges ranges);

    string RefersTo { get; set; }
  }
}

// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLRanges
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections;
using System.Collections.Generic;

namespace ClosedXML.Excel
{
  public interface IXLRanges : IEnumerable<IXLRange>, IEnumerable, IDisposable
  {
    void Add(IXLRangeBase range);

    void Add(IXLCell range);

    void Remove(IXLRange range);

    int Count { get; }

    bool Contains(IXLRange range);

    IXLStyle Style { get; set; }

    IXLDataValidation SetDataValidation();

    IXLRanges AddToNamed(string rangeName);

    IXLRanges AddToNamed(string rangeName, XLScope scope);

    IXLRanges AddToNamed(string rangeName, XLScope scope, string comment);

    object Value { set; }

    IXLRanges SetValue<T>(T value);

    IXLCells Cells();

    IXLCells CellsUsed();

    IXLCells CellsUsed(bool includeFormats);

    IXLRanges SetDataType(XLCellValues dataType);

    IXLRanges Clear(XLClearOptions clearOptions = XLClearOptions.ContentsAndFormats);

    void Select();
  }
}

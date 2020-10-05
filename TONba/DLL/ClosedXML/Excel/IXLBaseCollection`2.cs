// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLBaseCollection`2
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System.Collections;
using System.Collections.Generic;

namespace ClosedXML.Excel
{
  public interface IXLBaseCollection<TSingle, TMultiple> : IEnumerable<TSingle>, IEnumerable
  {
    int Count { get; }

    IXLStyle Style { get; set; }

    IXLDataValidation SetDataValidation();

    TMultiple AddToNamed(string rangeName);

    TMultiple AddToNamed(string rangeName, XLScope scope);

    TMultiple AddToNamed(string rangeName, XLScope scope, string comment);

    object Value { set; }

    TMultiple SetValue<T>(T value);

    IXLCells Cells();

    IXLCells CellsUsed();

    IXLCells CellsUsed(bool includeFormats);

    TMultiple SetDataType(XLCellValues dataType);

    TMultiple Clear(XLClearOptions clearOptions = XLClearOptions.ContentsAndFormats);
  }
}

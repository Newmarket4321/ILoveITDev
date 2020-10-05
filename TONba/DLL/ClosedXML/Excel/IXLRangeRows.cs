// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLRangeRows
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections;
using System.Collections.Generic;

namespace ClosedXML.Excel
{
  public interface IXLRangeRows : IEnumerable<IXLRangeRow>, IEnumerable, IDisposable
  {
    void Add(IXLRangeRow rowRange);

    IXLCells Cells();

    IXLCells CellsUsed();

    IXLCells CellsUsed(bool includeFormats);

    void Delete();

    IXLStyle Style { get; set; }

    IXLRangeRows SetDataType(XLCellValues dataType);

    IXLRangeRows Clear(XLClearOptions clearOptions = XLClearOptions.ContentsAndFormats);

    void Select();
  }
}

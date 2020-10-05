// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLRows
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections;
using System.Collections.Generic;

namespace ClosedXML.Excel
{
  public interface IXLRows : IEnumerable<IXLRow>, IEnumerable, IDisposable
  {
    double Height { set; }

    void Delete();

    IXLRows AdjustToContents();

    IXLRows AdjustToContents(int startColumn);

    IXLRows AdjustToContents(int startColumn, int endColumn);

    IXLRows AdjustToContents(double minHeight, double maxHeight);

    IXLRows AdjustToContents(int startColumn, double minHeight, double maxHeight);

    IXLRows AdjustToContents(int startColumn, int endColumn, double minHeight, double maxHeight);

    void Hide();

    void Unhide();

    void Group();

    void Group(bool collapse);

    void Group(int outlineLevel);

    void Group(int outlineLevel, bool collapse);

    void Ungroup();

    void Ungroup(bool fromAll);

    void Collapse();

    void Expand();

    IXLCells Cells();

    IXLCells CellsUsed();

    IXLCells CellsUsed(bool includeFormats);

    IXLStyle Style { get; set; }

    IXLRows AddHorizontalPageBreaks();

    IXLRows SetDataType(XLCellValues dataType);

    IXLRows Clear(XLClearOptions clearOptions = XLClearOptions.ContentsAndFormats);

    void Select();
  }
}

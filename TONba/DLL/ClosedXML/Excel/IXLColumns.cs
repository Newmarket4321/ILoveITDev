// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLColumns
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections;
using System.Collections.Generic;

namespace ClosedXML.Excel
{
  public interface IXLColumns : IEnumerable<IXLColumn>, IEnumerable, IDisposable
  {
    double Width { set; }

    void Delete();

    IXLColumns AdjustToContents();

    IXLColumns AdjustToContents(int startRow);

    IXLColumns AdjustToContents(int startRow, int endRow);

    IXLColumns AdjustToContents(double minWidth, double maxWidth);

    IXLColumns AdjustToContents(int startRow, double minWidth, double maxWidth);

    IXLColumns AdjustToContents(int startRow, int endRow, double minWidth, double maxWidth);

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

    IXLColumns AddVerticalPageBreaks();

    IXLColumns SetDataType(XLCellValues dataType);

    IXLColumns Clear(XLClearOptions clearOptions = XLClearOptions.ContentsAndFormats);

    void Select();
  }
}

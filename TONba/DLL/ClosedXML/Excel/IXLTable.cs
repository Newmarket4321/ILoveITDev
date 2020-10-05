// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLTable
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections.Generic;

namespace ClosedXML.Excel
{
  public interface IXLTable : IXLRange, IXLRangeBase, IDisposable
  {
    string Name { get; set; }

    bool EmphasizeFirstColumn { get; set; }

    bool EmphasizeLastColumn { get; set; }

    bool ShowRowStripes { get; set; }

    bool ShowColumnStripes { get; set; }

    bool ShowTotalsRow { get; set; }

    bool ShowAutoFilter { get; set; }

    XLTableTheme Theme { get; set; }

    IXLRangeRow HeadersRow();

    IXLRangeRow TotalsRow();

    IXLTableField Field(string fieldName);

    IXLTableField Field(int fieldIndex);

    IEnumerable<IXLTableField> Fields { get; }

    IXLTable SetEmphasizeFirstColumn();

    IXLTable SetEmphasizeFirstColumn(bool value);

    IXLTable SetEmphasizeLastColumn();

    IXLTable SetEmphasizeLastColumn(bool value);

    IXLTable SetShowRowStripes();

    IXLTable SetShowRowStripes(bool value);

    IXLTable SetShowColumnStripes();

    IXLTable SetShowColumnStripes(bool value);

    IXLTable SetShowTotalsRow();

    IXLTable SetShowTotalsRow(bool value);

    IXLTable SetShowAutoFilter();

    IXLTable SetShowAutoFilter(bool value);

    IXLTable Clear(XLClearOptions clearOptions = XLClearOptions.ContentsAndFormats);

    IXLBaseAutoFilter AutoFilter { get; }

    IXLBaseAutoFilter SetAutoFilter();

    bool ShowHeaderRow { get; set; }

    IXLTable SetShowHeaderRow();

    IXLTable SetShowHeaderRow(bool value);

    IXLTableRange DataRange { get; }
  }
}

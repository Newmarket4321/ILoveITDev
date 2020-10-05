// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLPivotField
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System.Collections.Generic;

namespace ClosedXML.Excel
{
  public interface IXLPivotField
  {
    string SourceName { get; }

    string CustomName { get; set; }

    List<XLSubtotalFunction> Subtotals { get; }

    bool IncludeNewItemsInFilter { get; set; }

    XLPivotLayout Layout { get; set; }

    bool SubtotalsAtTop { get; set; }

    bool RepeatItemLabels { get; set; }

    bool InsertBlankLines { get; set; }

    bool ShowBlankItems { get; set; }

    bool InsertPageBreaks { get; set; }

    IXLPivotField SetCustomName(string value);

    IXLPivotField AddSubtotal(XLSubtotalFunction value);

    IXLPivotField SetIncludeNewItemsInFilter();

    IXLPivotField SetIncludeNewItemsInFilter(bool value);

    IXLPivotField SetLayout(XLPivotLayout value);

    IXLPivotField SetSubtotalsAtTop();

    IXLPivotField SetSubtotalsAtTop(bool value);

    IXLPivotField SetRepeatItemLabels();

    IXLPivotField SetRepeatItemLabels(bool value);

    IXLPivotField SetInsertBlankLines();

    IXLPivotField SetInsertBlankLines(bool value);

    IXLPivotField SetShowBlankItems();

    IXLPivotField SetShowBlankItems(bool value);

    IXLPivotField SetInsertPageBreaks();

    IXLPivotField SetInsertPageBreaks(bool value);

    List<string> SharedStrings { get; set; }
  }
}

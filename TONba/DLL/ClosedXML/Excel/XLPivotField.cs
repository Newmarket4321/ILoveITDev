// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLPivotField
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System.Collections.Generic;

namespace ClosedXML.Excel
{
  public class XLPivotField : IXLPivotField
  {
    public XLPivotField(string sourceName)
    {
      this.SourceName = sourceName;
      this.SharedStrings = new List<string>();
      this.Subtotals = new List<XLSubtotalFunction>();
    }

    public string SourceName { get; private set; }

    public string CustomName { get; set; }

    public IXLPivotField SetCustomName(string value)
    {
      this.CustomName = value;
      return (IXLPivotField) this;
    }

    public List<XLSubtotalFunction> Subtotals { get; private set; }

    public IXLPivotField AddSubtotal(XLSubtotalFunction value)
    {
      this.Subtotals.Add(value);
      return (IXLPivotField) this;
    }

    public bool IncludeNewItemsInFilter { get; set; }

    public IXLPivotField SetIncludeNewItemsInFilter()
    {
      this.IncludeNewItemsInFilter = true;
      return (IXLPivotField) this;
    }

    public IXLPivotField SetIncludeNewItemsInFilter(bool value)
    {
      this.IncludeNewItemsInFilter = value;
      return (IXLPivotField) this;
    }

    public XLPivotLayout Layout { get; set; }

    public IXLPivotField SetLayout(XLPivotLayout value)
    {
      this.Layout = value;
      return (IXLPivotField) this;
    }

    public bool SubtotalsAtTop { get; set; }

    public IXLPivotField SetSubtotalsAtTop()
    {
      this.SubtotalsAtTop = true;
      return (IXLPivotField) this;
    }

    public IXLPivotField SetSubtotalsAtTop(bool value)
    {
      this.SubtotalsAtTop = value;
      return (IXLPivotField) this;
    }

    public bool RepeatItemLabels { get; set; }

    public IXLPivotField SetRepeatItemLabels()
    {
      this.RepeatItemLabels = true;
      return (IXLPivotField) this;
    }

    public IXLPivotField SetRepeatItemLabels(bool value)
    {
      this.RepeatItemLabels = value;
      return (IXLPivotField) this;
    }

    public bool InsertBlankLines { get; set; }

    public IXLPivotField SetInsertBlankLines()
    {
      this.InsertBlankLines = true;
      return (IXLPivotField) this;
    }

    public IXLPivotField SetInsertBlankLines(bool value)
    {
      this.InsertBlankLines = value;
      return (IXLPivotField) this;
    }

    public bool ShowBlankItems { get; set; }

    public IXLPivotField SetShowBlankItems()
    {
      this.ShowBlankItems = true;
      return (IXLPivotField) this;
    }

    public IXLPivotField SetShowBlankItems(bool value)
    {
      this.ShowBlankItems = value;
      return (IXLPivotField) this;
    }

    public bool InsertPageBreaks { get; set; }

    public IXLPivotField SetInsertPageBreaks()
    {
      this.InsertPageBreaks = true;
      return (IXLPivotField) this;
    }

    public IXLPivotField SetInsertPageBreaks(bool value)
    {
      this.InsertPageBreaks = value;
      return (IXLPivotField) this;
    }

    public List<string> SharedStrings { get; set; }
  }
}

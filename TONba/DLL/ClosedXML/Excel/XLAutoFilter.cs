// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLAutoFilter
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace ClosedXML.Excel
{
  internal class XLAutoFilter : IXLBaseAutoFilter, IXLAutoFilter, IDisposable
  {
    private readonly Dictionary<int, XLFilterColumn> _columns = new Dictionary<int, XLFilterColumn>();

    public XLAutoFilter()
    {
      this.Filters = new Dictionary<int, List<XLFilter>>();
    }

    public Dictionary<int, List<XLFilter>> Filters { get; private set; }

    IXLAutoFilter IXLAutoFilter.Sort(int columnToSortBy, XLSortOrder sortOrder, bool matchCase, bool ignoreBlanks)
    {
      return (IXLAutoFilter) this.Sort(columnToSortBy, sortOrder, matchCase, ignoreBlanks);
    }

    public void Dispose()
    {
      if (this.Range == null)
        return;
      this.Range.Dispose();
    }

    public bool Enabled { get; set; }

    public IXLRange Range { get; set; }

    IXLBaseAutoFilter IXLBaseAutoFilter.Clear()
    {
      return (IXLBaseAutoFilter) this.Clear();
    }

    IXLBaseAutoFilter IXLBaseAutoFilter.Set(IXLRangeBase range)
    {
      return (IXLBaseAutoFilter) this.Set(range);
    }

    IXLBaseAutoFilter IXLBaseAutoFilter.Sort(int columnToSortBy, XLSortOrder sortOrder, bool matchCase, bool ignoreBlanks)
    {
      return (IXLBaseAutoFilter) this.Sort(columnToSortBy, sortOrder, matchCase, ignoreBlanks);
    }

    public bool Sorted { get; set; }

    public XLSortOrder SortOrder { get; set; }

    public int SortColumn { get; set; }

    public IXLFilterColumn Column(string column)
    {
      return this.Column(XLHelper.GetColumnNumberFromLetter(column));
    }

    public IXLFilterColumn Column(int column)
    {
      XLFilterColumn xlFilterColumn;
      if (!this._columns.TryGetValue(column, out xlFilterColumn))
      {
        xlFilterColumn = new XLFilterColumn(this, column);
        this._columns.Add(column, xlFilterColumn);
      }
      return (IXLFilterColumn) xlFilterColumn;
    }

    public XLAutoFilter Set(IXLRangeBase range)
    {
      this.Range = range.AsRange();
      this.Enabled = true;
      return this;
    }

    public XLAutoFilter Clear()
    {
      this.Enabled = false;
      this.Filters.Clear();
      foreach (IXLRangeRow xlRangeRow in this.Range.Rows((Func<IXLRangeRow, bool>) null).Where<IXLRangeRow>((Func<IXLRangeRow, bool>) (r => r.RowNumber() > 1)))
        xlRangeRow.WorksheetRow().Unhide();
      return this;
    }

    public XLAutoFilter Sort(int columnToSortBy, XLSortOrder sortOrder, bool matchCase, bool ignoreBlanks)
    {
      XLWorksheet worksheet = this.Range.Worksheet as XLWorksheet;
      worksheet.SuspendEvents();
      this.Range.Range(this.Range.FirstCell().CellBelow(), this.Range.LastCell()).Sort(columnToSortBy, sortOrder, matchCase, ignoreBlanks);
      this.Sorted = true;
      this.SortOrder = sortOrder;
      this.SortColumn = columnToSortBy;
      if (this.Enabled)
      {
        using (IXLRangeRows xlRangeRows = this.Range.Rows(2, this.Range.RowCount()))
        {
          foreach (IXLRangeRow xlRangeRow in (IEnumerable<IXLRangeRow>) xlRangeRows)
            xlRangeRow.WorksheetRow().Unhide();
        }
        foreach (KeyValuePair<int, List<XLFilter>> filter in this.Filters)
        {
          bool flag1 = true;
          foreach (XLFilter xlFilter in filter.Value)
          {
            bool flag2 = xlFilter.Value is string;
            using (IXLRangeRows xlRangeRows = this.Range.Rows(2, this.Range.RowCount()))
            {
              foreach (IXLRangeRow xlRangeRow in (IEnumerable<IXLRangeRow>) xlRangeRows)
              {
                bool flag3 = flag2 ? xlFilter.Condition((object) xlRangeRow.Cell(filter.Key).GetString()) : xlRangeRow.Cell(filter.Key).DataType == XLCellValues.Number && xlFilter.Condition((object) xlRangeRow.Cell(filter.Key).GetDouble());
                if (flag1)
                {
                  if (flag3)
                    xlRangeRow.WorksheetRow().Unhide();
                  else
                    xlRangeRow.WorksheetRow().Hide();
                }
                else if (xlFilter.Connector == XLConnector.And)
                {
                  if (!xlRangeRow.WorksheetRow().IsHidden)
                  {
                    if (flag3)
                      xlRangeRow.WorksheetRow().Unhide();
                    else
                      xlRangeRow.WorksheetRow().Hide();
                  }
                }
                else if (flag3)
                  xlRangeRow.WorksheetRow().Unhide();
              }
              flag1 = false;
            }
          }
        }
      }
      worksheet.ResumeEvents();
      return this;
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLColumns
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ClosedXML.Excel
{
  internal class XLColumns : IXLColumns, IEnumerable<IXLColumn>, IEnumerable, IDisposable, IXLStylized
  {
    private readonly List<XLColumn> _columns = new List<XLColumn>();
    private readonly XLWorksheet _worksheet;
    internal IXLStyle style;

    public bool StyleChanged { get; set; }

    public XLColumns(XLWorksheet worksheet)
    {
      this._worksheet = worksheet;
      this.style = (IXLStyle) new XLStyle((IXLStylized) this, XLWorkbook.DefaultStyle, true);
    }

    public IEnumerator<IXLColumn> GetEnumerator()
    {
      return this._columns.Cast<IXLColumn>().OrderBy<IXLColumn, int>((Func<IXLColumn, int>) (r => r.ColumnNumber())).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return (IEnumerator) this.GetEnumerator();
    }

    public IXLStyle Style
    {
      get
      {
        return this.style;
      }
      set
      {
        this.style = (IXLStyle) new XLStyle((IXLStylized) this, value, true);
        if (this._worksheet != null)
        {
          this._worksheet.Style = value;
        }
        else
        {
          foreach (XLRangeBase column in this._columns)
            column.Style = value;
        }
      }
    }

    public double Width
    {
      set
      {
        this._columns.ForEach((Action<XLColumn>) (c => c.Width = value));
        if (this._worksheet == null)
          return;
        this._worksheet.ColumnWidth = value;
        this._worksheet.Internals.ColumnsCollection.ForEach<KeyValuePair<int, XLColumn>>((Action<KeyValuePair<int, XLColumn>>) (c => c.Value.Width = value));
      }
    }

    public void Delete()
    {
      if (this._worksheet != null)
      {
        this._worksheet.Internals.ColumnsCollection.Clear();
        this._worksheet.Internals.CellsCollection.Clear();
      }
      else
      {
        Dictionary<IXLWorksheet, List<int>> dictionary = new Dictionary<IXLWorksheet, List<int>>();
        foreach (XLColumn column in this._columns)
        {
          if (!dictionary.ContainsKey((IXLWorksheet) column.Worksheet))
            dictionary.Add((IXLWorksheet) column.Worksheet, new List<int>());
          dictionary[(IXLWorksheet) column.Worksheet].Add(column.ColumnNumber());
        }
        foreach (KeyValuePair<IXLWorksheet, List<int>> keyValuePair in dictionary)
        {
          foreach (int column in (IEnumerable<int>) keyValuePair.Value.OrderByDescending<int, int>((Func<int, int>) (c => c)))
            keyValuePair.Key.Column(column).Delete();
        }
      }
    }

    public IXLColumns AdjustToContents()
    {
      this._columns.ForEach((Action<XLColumn>) (c => c.AdjustToContents()));
      return (IXLColumns) this;
    }

    public IXLColumns AdjustToContents(int startRow)
    {
      this._columns.ForEach((Action<XLColumn>) (c => c.AdjustToContents(startRow)));
      return (IXLColumns) this;
    }

    public IXLColumns AdjustToContents(int startRow, int endRow)
    {
      this._columns.ForEach((Action<XLColumn>) (c => c.AdjustToContents(startRow, endRow)));
      return (IXLColumns) this;
    }

    public IXLColumns AdjustToContents(double minWidth, double maxWidth)
    {
      this._columns.ForEach((Action<XLColumn>) (c => c.AdjustToContents(minWidth, maxWidth)));
      return (IXLColumns) this;
    }

    public IXLColumns AdjustToContents(int startRow, double minWidth, double maxWidth)
    {
      this._columns.ForEach((Action<XLColumn>) (c => c.AdjustToContents(startRow, minWidth, maxWidth)));
      return (IXLColumns) this;
    }

    public IXLColumns AdjustToContents(int startRow, int endRow, double minWidth, double maxWidth)
    {
      this._columns.ForEach((Action<XLColumn>) (c => c.AdjustToContents(startRow, endRow, minWidth, maxWidth)));
      return (IXLColumns) this;
    }

    public void Hide()
    {
      this._columns.ForEach((Action<XLColumn>) (c => c.Hide()));
    }

    public void Unhide()
    {
      this._columns.ForEach((Action<XLColumn>) (c => c.Unhide()));
    }

    public void Group()
    {
      this.Group(false);
    }

    public void Group(int outlineLevel)
    {
      this.Group(outlineLevel, false);
    }

    public void Ungroup()
    {
      this.Ungroup(false);
    }

    public void Group(bool collapse)
    {
      this._columns.ForEach((Action<XLColumn>) (c => c.Group(collapse)));
    }

    public void Group(int outlineLevel, bool collapse)
    {
      this._columns.ForEach((Action<XLColumn>) (c => c.Group(outlineLevel, collapse)));
    }

    public void Ungroup(bool ungroupFromAll)
    {
      this._columns.ForEach((Action<XLColumn>) (c => c.Ungroup(ungroupFromAll)));
    }

    public void Collapse()
    {
      this._columns.ForEach((Action<XLColumn>) (c => c.Collapse()));
    }

    public void Expand()
    {
      this._columns.ForEach((Action<XLColumn>) (c => c.Expand()));
    }

    public IXLCells Cells()
    {
      XLCells xlCells = new XLCells(false, false, (Func<IXLCell, bool>) null);
      foreach (XLColumn column in this._columns)
        xlCells.Add(column.RangeAddress);
      return (IXLCells) xlCells;
    }

    public IXLCells CellsUsed()
    {
      XLCells xlCells = new XLCells(true, false, (Func<IXLCell, bool>) null);
      foreach (XLColumn column in this._columns)
        xlCells.Add(column.RangeAddress);
      return (IXLCells) xlCells;
    }

    public IXLCells CellsUsed(bool includeFormats)
    {
      XLCells xlCells = new XLCells(true, includeFormats, (Func<IXLCell, bool>) null);
      foreach (XLColumn column in this._columns)
        xlCells.Add(column.RangeAddress);
      return (IXLCells) xlCells;
    }

    public IXLColumns AddVerticalPageBreaks()
    {
      foreach (XLColumn column in this._columns)
        column.Worksheet.PageSetup.AddVerticalPageBreak(column.ColumnNumber());
      return (IXLColumns) this;
    }

    public IXLColumns SetDataType(XLCellValues dataType)
    {
      this._columns.ForEach((Action<XLColumn>) (c => c.DataType = dataType));
      return (IXLColumns) this;
    }

    public IEnumerable<IXLStyle> Styles
    {
      get
      {
        this.UpdatingStyle = true;
        yield return this.style;
        if (this._worksheet != null)
        {
          yield return this._worksheet.Style;
        }
        else
        {
          foreach (IXLStyle xlStyle in this._columns.SelectMany<XLColumn, IXLStyle>((Func<XLColumn, IEnumerable<IXLStyle>>) (col => col.Styles)))
            yield return xlStyle;
        }
        this.UpdatingStyle = false;
      }
    }

    public bool UpdatingStyle { get; set; }

    public IXLStyle InnerStyle
    {
      get
      {
        return this.style;
      }
      set
      {
        this.style = (IXLStyle) new XLStyle((IXLStylized) this, value, true);
      }
    }

    public IXLRanges RangesUsed
    {
      get
      {
        XLRanges retVal = new XLRanges();
        this.ForEach<IXLColumn>((Action<IXLColumn>) (c => retVal.Add((IXLRangeBase) c.AsRange())));
        return (IXLRanges) retVal;
      }
    }

    public void Add(XLColumn column)
    {
      this._columns.Add(column);
    }

    public void CollapseOnly()
    {
      this._columns.ForEach((Action<XLColumn>) (c => c.Collapsed = true));
    }

    public IXLColumns Clear(XLClearOptions clearOptions = XLClearOptions.ContentsAndFormats)
    {
      this._columns.ForEach((Action<XLColumn>) (c => c.Clear(clearOptions)));
      return (IXLColumns) this;
    }

    public void Dispose()
    {
      if (this._columns == null)
        return;
      this._columns.ForEach((Action<XLColumn>) (c => c.Dispose()));
    }

    public void Select()
    {
      foreach (IXLRangeBase xlRangeBase in this)
        xlRangeBase.Select();
    }
  }
}

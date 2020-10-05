// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLRows
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ClosedXML.Excel
{
  internal class XLRows : IXLRows, IEnumerable<IXLRow>, IEnumerable, IDisposable, IXLStylized
  {
    private readonly List<XLRow> _rows = new List<XLRow>();
    private readonly XLWorksheet _worksheet;
    internal IXLStyle style;

    public bool StyleChanged { get; set; }

    public XLRows(XLWorksheet worksheet)
    {
      this._worksheet = worksheet;
      this.style = (IXLStyle) new XLStyle((IXLStylized) this, XLWorkbook.DefaultStyle, true);
    }

    public IEnumerator<IXLRow> GetEnumerator()
    {
      return this._rows.Cast<IXLRow>().OrderBy<IXLRow, int>((Func<IXLRow, int>) (r => r.RowNumber())).GetEnumerator();
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
          foreach (XLRangeBase row in this._rows)
            row.Style = value;
        }
      }
    }

    public double Height
    {
      set
      {
        this._rows.ForEach((Action<XLRow>) (c => c.Height = value));
        if (this._worksheet == null)
          return;
        this._worksheet.RowHeight = value;
        this._worksheet.Internals.RowsCollection.ForEach<KeyValuePair<int, XLRow>>((Action<KeyValuePair<int, XLRow>>) (r => r.Value.Height = value));
      }
    }

    public void Delete()
    {
      if (this._worksheet != null)
      {
        this._worksheet.Internals.RowsCollection.Clear();
        this._worksheet.Internals.CellsCollection.Clear();
      }
      else
      {
        Dictionary<IXLWorksheet, List<int>> dictionary = new Dictionary<IXLWorksheet, List<int>>();
        foreach (XLRow row in this._rows)
        {
          if (!dictionary.ContainsKey((IXLWorksheet) row.Worksheet))
            dictionary.Add((IXLWorksheet) row.Worksheet, new List<int>());
          dictionary[(IXLWorksheet) row.Worksheet].Add(row.RowNumber());
        }
        foreach (KeyValuePair<IXLWorksheet, List<int>> keyValuePair in dictionary)
        {
          foreach (int row in (IEnumerable<int>) keyValuePair.Value.OrderByDescending<int, int>((Func<int, int>) (r => r)))
            keyValuePair.Key.Row(row).Delete();
        }
      }
    }

    public IXLRows AdjustToContents()
    {
      this._rows.ForEach((Action<XLRow>) (r => r.AdjustToContents()));
      return (IXLRows) this;
    }

    public IXLRows AdjustToContents(int startColumn)
    {
      this._rows.ForEach((Action<XLRow>) (r => r.AdjustToContents(startColumn)));
      return (IXLRows) this;
    }

    public IXLRows AdjustToContents(int startColumn, int endColumn)
    {
      this._rows.ForEach((Action<XLRow>) (r => r.AdjustToContents(startColumn, endColumn)));
      return (IXLRows) this;
    }

    public IXLRows AdjustToContents(double minHeight, double maxHeight)
    {
      this._rows.ForEach((Action<XLRow>) (r => r.AdjustToContents(minHeight, maxHeight)));
      return (IXLRows) this;
    }

    public IXLRows AdjustToContents(int startColumn, double minHeight, double maxHeight)
    {
      this._rows.ForEach((Action<XLRow>) (r => r.AdjustToContents(startColumn, minHeight, maxHeight)));
      return (IXLRows) this;
    }

    public IXLRows AdjustToContents(int startColumn, int endColumn, double minHeight, double maxHeight)
    {
      this._rows.ForEach((Action<XLRow>) (r => r.AdjustToContents(startColumn, endColumn, minHeight, maxHeight)));
      return (IXLRows) this;
    }

    public void Hide()
    {
      this._rows.ForEach((Action<XLRow>) (r => r.Hide()));
    }

    public void Unhide()
    {
      this._rows.ForEach((Action<XLRow>) (r => r.Unhide()));
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
      this._rows.ForEach((Action<XLRow>) (r => r.Group(collapse)));
    }

    public void Group(int outlineLevel, bool collapse)
    {
      this._rows.ForEach((Action<XLRow>) (r => r.Group(outlineLevel, collapse)));
    }

    public void Ungroup(bool ungroupFromAll)
    {
      this._rows.ForEach((Action<XLRow>) (r => r.Ungroup(ungroupFromAll)));
    }

    public void Collapse()
    {
      this._rows.ForEach((Action<XLRow>) (r => r.Collapse()));
    }

    public void Expand()
    {
      this._rows.ForEach((Action<XLRow>) (r => r.Expand()));
    }

    public IXLCells Cells()
    {
      XLCells xlCells = new XLCells(false, false, (Func<IXLCell, bool>) null);
      foreach (XLRow row in this._rows)
        xlCells.Add(row.RangeAddress);
      return (IXLCells) xlCells;
    }

    public IXLCells CellsUsed()
    {
      XLCells xlCells = new XLCells(true, false, (Func<IXLCell, bool>) null);
      foreach (XLRow row in this._rows)
        xlCells.Add(row.RangeAddress);
      return (IXLCells) xlCells;
    }

    public IXLCells CellsUsed(bool includeFormats)
    {
      XLCells xlCells = new XLCells(true, includeFormats, (Func<IXLCell, bool>) null);
      foreach (XLRow row in this._rows)
        xlCells.Add(row.RangeAddress);
      return (IXLCells) xlCells;
    }

    public IXLRows AddHorizontalPageBreaks()
    {
      foreach (XLRow row in this._rows)
        row.Worksheet.PageSetup.AddHorizontalPageBreak(row.RowNumber());
      return (IXLRows) this;
    }

    public IXLRows SetDataType(XLCellValues dataType)
    {
      this._rows.ForEach((Action<XLRow>) (c => c.DataType = dataType));
      return (IXLRows) this;
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
          foreach (IXLStyle xlStyle in this._rows.SelectMany<XLRow, IXLStyle>((Func<XLRow, IEnumerable<IXLStyle>>) (row => row.Styles)))
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
        this.ForEach<IXLRow>((Action<IXLRow>) (c => retVal.Add((IXLRangeBase) c.AsRange())));
        return (IXLRanges) retVal;
      }
    }

    public void Add(XLRow row)
    {
      this._rows.Add(row);
    }

    public IXLRows Clear(XLClearOptions clearOptions = XLClearOptions.ContentsAndFormats)
    {
      this._rows.ForEach((Action<XLRow>) (c => c.Clear(clearOptions)));
      return (IXLRows) this;
    }

    public void Dispose()
    {
      if (this._rows == null)
        return;
      this._rows.ForEach((Action<XLRow>) (r => r.Dispose()));
    }

    public void Select()
    {
      foreach (IXLRangeBase xlRangeBase in this)
        xlRangeBase.Select();
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLRangeColumns
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ClosedXML.Excel
{
  internal class XLRangeColumns : IXLRangeColumns, IEnumerable<IXLRangeColumn>, IEnumerable, IDisposable, IXLStylized
  {
    private readonly List<XLRangeColumn> _ranges = new List<XLRangeColumn>();
    private IXLStyle _style;

    public bool StyleChanged { get; set; }

    public XLRangeColumns()
    {
      this._style = (IXLStyle) new XLStyle((IXLStylized) this, XLWorkbook.DefaultStyle, true);
    }

    public IXLRangeColumns Clear(XLClearOptions clearOptions = XLClearOptions.ContentsAndFormats)
    {
      this._ranges.ForEach((Action<XLRangeColumn>) (c => c.Clear(clearOptions)));
      return (IXLRangeColumns) this;
    }

    public void Delete()
    {
      this._ranges.OrderByDescending<XLRangeColumn, int>((Func<XLRangeColumn, int>) (c => c.ColumnNumber())).ForEach<XLRangeColumn>((Action<XLRangeColumn>) (r => r.Delete()));
      this._ranges.Clear();
    }

    public void Add(IXLRangeColumn range)
    {
      this._ranges.Add((XLRangeColumn) range);
    }

    public IEnumerator<IXLRangeColumn> GetEnumerator()
    {
      return this._ranges.Cast<IXLRangeColumn>().OrderBy<IXLRangeColumn, int>((Func<IXLRangeColumn, int>) (r => r.Worksheet.Position)).ThenBy<IXLRangeColumn, int>((Func<IXLRangeColumn, int>) (r => r.ColumnNumber())).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return (IEnumerator) this.GetEnumerator();
    }

    public IXLStyle Style
    {
      get
      {
        return this._style;
      }
      set
      {
        this._style = (IXLStyle) new XLStyle((IXLStylized) this, value, true);
        this._ranges.ForEach((Action<XLRangeColumn>) (r => r.Style = value));
      }
    }

    public IXLCells Cells()
    {
      XLCells xlCells = new XLCells(false, false, (Func<IXLCell, bool>) null);
      foreach (XLRangeColumn range in this._ranges)
        xlCells.Add(range.RangeAddress);
      return (IXLCells) xlCells;
    }

    public IXLCells CellsUsed()
    {
      XLCells xlCells = new XLCells(true, false, (Func<IXLCell, bool>) null);
      foreach (XLRangeColumn range in this._ranges)
        xlCells.Add(range.RangeAddress);
      return (IXLCells) xlCells;
    }

    public IXLCells CellsUsed(bool includeFormats)
    {
      XLCells xlCells = new XLCells(true, includeFormats, (Func<IXLCell, bool>) null);
      foreach (XLRangeColumn range in this._ranges)
        xlCells.Add(range.RangeAddress);
      return (IXLCells) xlCells;
    }

    public IXLRangeColumns SetDataType(XLCellValues dataType)
    {
      this._ranges.ForEach((Action<XLRangeColumn>) (c => c.DataType = dataType));
      return (IXLRangeColumns) this;
    }

    public IEnumerable<IXLStyle> Styles
    {
      get
      {
        this.UpdatingStyle = true;
        yield return this._style;
        foreach (XLRangeColumn range in this._ranges)
        {
          yield return range.Style;
          foreach (XLCell cell in range.Worksheet.Internals.CellsCollection.GetCells(range.RangeAddress.FirstAddress.RowNumber, range.RangeAddress.FirstAddress.ColumnNumber, range.RangeAddress.LastAddress.RowNumber, range.RangeAddress.LastAddress.ColumnNumber, (Func<IXLCell, bool>) null))
            yield return cell.Style;
        }
        this.UpdatingStyle = false;
      }
    }

    public bool UpdatingStyle { get; set; }

    public IXLStyle InnerStyle
    {
      get
      {
        return this._style;
      }
      set
      {
        this._style = (IXLStyle) new XLStyle((IXLStylized) this, value, true);
      }
    }

    public IXLRanges RangesUsed
    {
      get
      {
        XLRanges retVal = new XLRanges();
        this.ForEach<IXLRangeColumn>((Action<IXLRangeColumn>) (c => retVal.Add((IXLRangeBase) c.AsRange())));
        return (IXLRanges) retVal;
      }
    }

    public void Dispose()
    {
      if (this._ranges == null)
        return;
      this._ranges.ForEach((Action<XLRangeColumn>) (r => r.Dispose()));
    }

    public void Select()
    {
      foreach (IXLRangeBase xlRangeBase in this)
        xlRangeBase.Select();
    }
  }
}

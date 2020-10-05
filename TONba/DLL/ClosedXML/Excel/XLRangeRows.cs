// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLRangeRows
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ClosedXML.Excel
{
  internal class XLRangeRows : IXLRangeRows, IEnumerable<IXLRangeRow>, IEnumerable, IDisposable, IXLStylized
  {
    private readonly List<XLRangeRow> _ranges = new List<XLRangeRow>();
    private IXLStyle _style;

    public bool StyleChanged { get; set; }

    public XLRangeRows()
    {
      this._style = (IXLStyle) new XLStyle((IXLStylized) this, XLWorkbook.DefaultStyle, true);
    }

    public IXLRangeRows Clear(XLClearOptions clearOptions = XLClearOptions.ContentsAndFormats)
    {
      this._ranges.ForEach((Action<XLRangeRow>) (c => c.Clear(clearOptions)));
      return (IXLRangeRows) this;
    }

    public void Delete()
    {
      this._ranges.OrderByDescending<XLRangeRow, int>((Func<XLRangeRow, int>) (r => r.RowNumber())).ForEach<XLRangeRow>((Action<XLRangeRow>) (r => r.Delete()));
      this._ranges.Clear();
    }

    public void Add(IXLRangeRow range)
    {
      this._ranges.Add((XLRangeRow) range);
    }

    public IEnumerator<IXLRangeRow> GetEnumerator()
    {
      return this._ranges.Cast<IXLRangeRow>().OrderBy<IXLRangeRow, int>((Func<IXLRangeRow, int>) (r => r.Worksheet.Position)).ThenBy<IXLRangeRow, int>((Func<IXLRangeRow, int>) (r => r.RowNumber())).GetEnumerator();
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
        this._ranges.ForEach((Action<XLRangeRow>) (r => r.Style = value));
      }
    }

    public IXLCells Cells()
    {
      XLCells xlCells = new XLCells(false, false, (Func<IXLCell, bool>) null);
      foreach (XLRangeRow range in this._ranges)
        xlCells.Add(range.RangeAddress);
      return (IXLCells) xlCells;
    }

    public IXLCells CellsUsed()
    {
      XLCells xlCells = new XLCells(true, false, (Func<IXLCell, bool>) null);
      foreach (XLRangeRow range in this._ranges)
        xlCells.Add(range.RangeAddress);
      return (IXLCells) xlCells;
    }

    public IXLCells CellsUsed(bool includeFormats)
    {
      XLCells xlCells = new XLCells(true, includeFormats, (Func<IXLCell, bool>) null);
      foreach (XLRangeRow range in this._ranges)
        xlCells.Add(range.RangeAddress);
      return (IXLCells) xlCells;
    }

    public IXLRangeRows SetDataType(XLCellValues dataType)
    {
      this._ranges.ForEach((Action<XLRangeRow>) (c => c.DataType = dataType));
      return (IXLRangeRows) this;
    }

    public IEnumerable<IXLStyle> Styles
    {
      get
      {
        this.UpdatingStyle = true;
        yield return this._style;
        foreach (XLRangeRow range in this._ranges)
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
        this.ForEach<IXLRangeRow>((Action<IXLRangeRow>) (c => retVal.Add((IXLRangeBase) c.AsRange())));
        return (IXLRanges) retVal;
      }
    }

    public void Dispose()
    {
      if (this._ranges == null)
        return;
      this._ranges.ForEach((Action<XLRangeRow>) (r => r.Dispose()));
    }

    public void Select()
    {
      foreach (IXLRangeBase xlRangeBase in this)
        xlRangeBase.Select();
    }
  }
}

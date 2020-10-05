// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLTableRows
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections;
using System.Collections.Generic;

namespace ClosedXML.Excel
{
  internal class XLTableRows : IXLTableRows, IEnumerable<IXLTableRow>, IEnumerable, IXLStylized
  {
    private readonly List<XLTableRow> _ranges = new List<XLTableRow>();
    private IXLStyle _style;

    public bool StyleChanged { get; set; }

    public XLTableRows(IXLStyle defaultStyle)
    {
      this._style = (IXLStyle) new XLStyle((IXLStylized) this, defaultStyle, true);
    }

    public IEnumerable<IXLStyle> Styles
    {
      get
      {
        this.UpdatingStyle = true;
        yield return this._style;
        foreach (XLTableRow range in this._ranges)
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
        this.ForEach<IXLTableRow>((Action<IXLTableRow>) (c => retVal.Add((IXLRangeBase) c.AsRange())));
        return (IXLRanges) retVal;
      }
    }

    public IXLTableRows Clear(XLClearOptions clearOptions = XLClearOptions.ContentsAndFormats)
    {
      this._ranges.ForEach((Action<XLTableRow>) (r => r.Clear(clearOptions)));
      return (IXLTableRows) this;
    }

    public void Add(IXLTableRow range)
    {
      this._ranges.Add((XLTableRow) range);
    }

    public IEnumerator<IXLTableRow> GetEnumerator()
    {
      List<IXLTableRow> xlTableRowList = new List<IXLTableRow>();
      this._ranges.ForEach(new Action<XLTableRow>(xlTableRowList.Add));
      return (IEnumerator<IXLTableRow>) xlTableRowList.GetEnumerator();
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
        this._ranges.ForEach((Action<XLTableRow>) (r => r.Style = value));
      }
    }

    public IXLCells Cells()
    {
      XLCells xlCells = new XLCells(false, false, (Func<IXLCell, bool>) null);
      foreach (XLTableRow range in this._ranges)
        xlCells.Add(range.RangeAddress);
      return (IXLCells) xlCells;
    }

    public IXLCells CellsUsed()
    {
      XLCells xlCells = new XLCells(true, false, (Func<IXLCell, bool>) null);
      foreach (XLTableRow range in this._ranges)
        xlCells.Add(range.RangeAddress);
      return (IXLCells) xlCells;
    }

    public IXLCells CellsUsed(bool includeFormats)
    {
      XLCells xlCells = new XLCells(false, includeFormats, (Func<IXLCell, bool>) null);
      foreach (XLTableRow range in this._ranges)
        xlCells.Add(range.RangeAddress);
      return (IXLCells) xlCells;
    }

    public void Select()
    {
      foreach (IXLRangeBase xlRangeBase in this)
        xlRangeBase.Select();
    }
  }
}

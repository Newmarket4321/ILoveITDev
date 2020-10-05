// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLRanges
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ClosedXML.Excel
{
  internal class XLRanges : IXLRanges, IEnumerable<IXLRange>, IEnumerable, IDisposable, IXLStylized
  {
    private readonly List<XLRange> _ranges = new List<XLRange>();
    private IXLStyle _style;

    public XLRanges()
    {
      this._style = (IXLStyle) new XLStyle((IXLStylized) this, XLWorkbook.DefaultStyle, true);
    }

    public IXLRanges Clear(XLClearOptions clearOptions = XLClearOptions.ContentsAndFormats)
    {
      this._ranges.ForEach((Action<XLRange>) (c => c.Clear(clearOptions)));
      return (IXLRanges) this;
    }

    public void Add(XLRange range)
    {
      ++this.Count;
      this._ranges.Add(range);
    }

    public void Add(IXLRangeBase range)
    {
      ++this.Count;
      this._ranges.Add(range.AsRange() as XLRange);
    }

    public void Add(IXLCell cell)
    {
      this.Add((IXLRangeBase) cell.AsRange());
    }

    public void Remove(IXLRange range)
    {
      --this.Count;
      this._ranges.RemoveAll((Predicate<XLRange>) (r => r.ToString() == range.ToString()));
    }

    public int Count { get; private set; }

    public IEnumerator<IXLRange> GetEnumerator()
    {
      List<IXLRange> xlRangeList = new List<IXLRange>();
      xlRangeList.AddRange(this._ranges.Where<XLRange>((Func<XLRange, bool>) (r => XLHelper.IsValidRangeAddress((IXLRangeAddress) r.RangeAddress))).Cast<IXLRange>());
      return (IEnumerator<IXLRange>) xlRangeList.GetEnumerator();
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
        foreach (XLRangeBase range in this._ranges)
          range.Style = value;
      }
    }

    public bool Contains(IXLRange range)
    {
      return this._ranges.Any<XLRange>((Func<XLRange, bool>) (r =>
      {
        if (!r.RangeAddress.IsInvalid)
          return r.Contains((IXLRangeBase) range);
        return false;
      }));
    }

    public IXLDataValidation DataValidation
    {
      get
      {
        foreach (XLRange range1 in this._ranges)
        {
          XLRange range = range1;
          foreach (IXLDataValidation dataValidation in range.Worksheet.DataValidations)
          {
            foreach (IXLRange range2 in dataValidation.Ranges.Where<IXLRange>((Func<IXLRange, bool>) (dvRange => dvRange.Intersects((IXLRangeBase) range))))
            {
              dataValidation.Ranges.Remove(range2);
              foreach (IXLCell xlCell in range2.Cells().Where<IXLCell>((Func<IXLCell, bool>) (c => !range.Contains(c.Address.ToString()))))
              {
                IXLRange xlRange = xlCell.AsRange();
                xlRange.Dispose();
                dataValidation.Ranges.Add((IXLRangeBase) xlRange);
              }
            }
          }
        }
        XLDataValidation xlDataValidation = new XLDataValidation((IXLRanges) this);
        this._ranges.First<XLRange>().Worksheet.DataValidations.Add((IXLDataValidation) xlDataValidation);
        return (IXLDataValidation) xlDataValidation;
      }
    }

    public IXLRanges AddToNamed(string rangeName)
    {
      return this.AddToNamed(rangeName, XLScope.Workbook);
    }

    public IXLRanges AddToNamed(string rangeName, XLScope scope)
    {
      return this.AddToNamed(rangeName, XLScope.Workbook, (string) null);
    }

    public IXLRanges AddToNamed(string rangeName, XLScope scope, string comment)
    {
      this._ranges.ForEach((Action<XLRange>) (r => r.AddToNamed(rangeName, scope, comment)));
      return (IXLRanges) this;
    }

    public object Value
    {
      set
      {
        this._ranges.ForEach((Action<XLRange>) (r => r.Value = value));
      }
    }

    public IXLRanges SetValue<T>(T value)
    {
      this._ranges.ForEach((Action<XLRange>) (r => r.SetValue<T>(value)));
      return (IXLRanges) this;
    }

    public IXLCells Cells()
    {
      XLCells xlCells = new XLCells(false, false, (Func<IXLCell, bool>) null);
      foreach (XLRange range in this._ranges)
        xlCells.Add(range.RangeAddress);
      return (IXLCells) xlCells;
    }

    public IXLCells CellsUsed()
    {
      XLCells xlCells = new XLCells(true, false, (Func<IXLCell, bool>) null);
      foreach (XLRange range in this._ranges)
        xlCells.Add(range.RangeAddress);
      return (IXLCells) xlCells;
    }

    public IXLCells CellsUsed(bool includeFormats)
    {
      XLCells xlCells = new XLCells(true, includeFormats, (Func<IXLCell, bool>) null);
      foreach (XLRange range in this._ranges)
        xlCells.Add(range.RangeAddress);
      return (IXLCells) xlCells;
    }

    public IXLRanges SetDataType(XLCellValues dataType)
    {
      this._ranges.ForEach((Action<XLRange>) (c => c.DataType = dataType));
      return (IXLRanges) this;
    }

    public void Dispose()
    {
      this._ranges.ForEach((Action<XLRange>) (r => r.Dispose()));
    }

    public bool StyleChanged { get; set; }

    public IEnumerable<IXLStyle> Styles
    {
      get
      {
        this.UpdatingStyle = true;
        yield return this._style;
        foreach (XLRange range in this._ranges)
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
        return (IXLRanges) this;
      }
    }

    public override string ToString()
    {
      string str = this._ranges.Aggregate<XLRange, string>(string.Empty, (Func<string, XLRange, string>) ((agg, r) => agg + r.ToString() + ","));
      if (str.Length > 0)
        str = str.Substring(0, str.Length - 1);
      return str;
    }

    public override bool Equals(object obj)
    {
      XLRanges other = (XLRanges) obj;
      if (this._ranges.Count == other._ranges.Count)
        return this._ranges.Select<XLRange, bool>((Func<XLRange, bool>) (thisRange => other._ranges.Contains<XLRange>(thisRange))).All<bool>((Func<bool, bool>) (foundOne => foundOne));
      return false;
    }

    public override int GetHashCode()
    {
      return this._ranges.Aggregate<XLRange, int>(0, (Func<int, XLRange, int>) ((current, r) => current ^ r.GetHashCode()));
    }

    public IXLDataValidation SetDataValidation()
    {
      return this.DataValidation;
    }

    public void Select()
    {
      foreach (IXLRangeBase xlRangeBase in this)
        xlRangeBase.Select();
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLCells
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ClosedXML.Excel
{
  internal class XLCells : IXLCells, IEnumerable<IXLCell>, IXLStylized, IEnumerable<XLCell>, IEnumerable
  {
    private readonly List<XLRangeAddress> _rangeAddresses = new List<XLRangeAddress>();
    private readonly bool _includeFormats;
    private readonly bool _usedCellsOnly;
    private IXLStyle _style;
    private readonly Func<IXLCell, bool> _predicate;

    public bool StyleChanged { get; set; }

    public XLCells(bool usedCellsOnly, bool includeFormats, Func<IXLCell, bool> predicate = null)
    {
      this._style = (IXLStyle) new XLStyle((IXLStylized) this, XLWorkbook.DefaultStyle, true);
      this._usedCellsOnly = usedCellsOnly;
      this._includeFormats = includeFormats;
      this._predicate = predicate;
    }

    public IEnumerator<XLCell> GetEnumerator()
    {
      Dictionary<XLWorksheet, HashSet<XLSheetPoint>> cellsInRanges = new Dictionary<XLWorksheet, HashSet<XLSheetPoint>>();
      bool oneRange = this._rangeAddresses.Count == 1;
      foreach (XLRangeAddress rangeAddress in this._rangeAddresses)
      {
        HashSet<XLSheetPoint> hash;
        if (cellsInRanges.ContainsKey(rangeAddress.Worksheet))
        {
          hash = cellsInRanges[rangeAddress.Worksheet];
        }
        else
        {
          hash = new HashSet<XLSheetPoint>();
          cellsInRanges.Add(rangeAddress.Worksheet, hash);
        }
        if (this._usedCellsOnly)
        {
          if (oneRange)
          {
            IEnumerable<XLCell> cellRange = rangeAddress.Worksheet.Internals.CellsCollection.GetCells(rangeAddress.FirstAddress.RowNumber, rangeAddress.FirstAddress.ColumnNumber, rangeAddress.LastAddress.RowNumber, rangeAddress.LastAddress.ColumnNumber, (Func<IXLCell, bool>) null).Where<XLCell>((Func<XLCell, bool>) (c =>
            {
              if (c.IsEmpty(this._includeFormats))
                return false;
              if (this._predicate != null)
                return this._predicate((IXLCell) c);
              return true;
            }));
            foreach (XLCell xlCell in cellRange)
              yield return xlCell;
          }
          else
          {
            XLRangeAddress xlRangeAddress = rangeAddress;
            foreach (XLSheetPoint xlSheetPoint in rangeAddress.Worksheet.Internals.CellsCollection.GetSheetPoints(xlRangeAddress.FirstAddress.RowNumber, xlRangeAddress.FirstAddress.ColumnNumber, xlRangeAddress.LastAddress.RowNumber, xlRangeAddress.LastAddress.ColumnNumber).Where<XLSheetPoint>((Func<XLSheetPoint, bool>) (a => !hash.Contains(a))))
              hash.Add(xlSheetPoint);
          }
        }
        else
        {
          XLCells.MinMax mm = new XLCells.MinMax()
          {
            MinRow = rangeAddress.FirstAddress.RowNumber,
            MaxRow = rangeAddress.LastAddress.RowNumber,
            MinColumn = rangeAddress.FirstAddress.ColumnNumber,
            MaxColumn = rangeAddress.LastAddress.ColumnNumber
          };
          if (mm.MaxRow > 0 && mm.MaxColumn > 0)
          {
            for (int ro = mm.MinRow; ro <= mm.MaxRow; ++ro)
            {
              for (int co = mm.MinColumn; co <= mm.MaxColumn; ++co)
              {
                if (oneRange)
                {
                  XLCell c = rangeAddress.Worksheet.Cell(ro, co);
                  if (this._predicate == null || this._predicate((IXLCell) c))
                    yield return c;
                }
                else
                {
                  XLSheetPoint xlSheetPoint = new XLSheetPoint(ro, co);
                  if (!hash.Contains(xlSheetPoint))
                    hash.Add(xlSheetPoint);
                }
              }
            }
          }
        }
      }
      if (!oneRange)
      {
        if (this._usedCellsOnly)
        {
          IEnumerable<XLCell> cellRange = cellsInRanges.SelectMany<KeyValuePair<XLWorksheet, HashSet<XLSheetPoint>>, XLCell>((Func<KeyValuePair<XLWorksheet, HashSet<XLSheetPoint>>, IEnumerable<XLCell>>) (cir => cir.Value.Select<XLSheetPoint, XLCell>((Func<XLSheetPoint, XLCell>) (a => cir.Key.Internals.CellsCollection.GetCell(a))).Where<XLCell>((Func<XLCell, bool>) (cell =>
          {
            if (cell == null || cell.IsEmpty(this._includeFormats))
              return false;
            if (this._predicate != null)
              return this._predicate((IXLCell) cell);
            return true;
          }))));
          foreach (XLCell xlCell in cellRange)
            yield return xlCell;
        }
        else
        {
          foreach (KeyValuePair<XLWorksheet, HashSet<XLSheetPoint>> keyValuePair in cellsInRanges)
          {
            foreach (XLSheetPoint xlSheetPoint in keyValuePair.Value)
            {
              XLCell c = keyValuePair.Key.Cell(xlSheetPoint.Row, xlSheetPoint.Column);
              if (this._predicate == null || this._predicate((IXLCell) c))
                yield return c;
            }
          }
        }
      }
    }

    IEnumerator<IXLCell> IEnumerable<IXLCell>.GetEnumerator()
    {
      foreach (XLCell xlCell in this)
        yield return (IXLCell) xlCell;
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
        this.ForEach<XLCell>((Action<XLCell>) (c => c.Style = this._style));
      }
    }

    public object Value
    {
      set
      {
        this.ForEach<XLCell>((Action<XLCell>) (c => c.Value = value));
      }
    }

    public IXLCells SetDataType(XLCellValues dataType)
    {
      this.ForEach<XLCell>((Action<XLCell>) (c => c.DataType = dataType));
      return (IXLCells) this;
    }

    public XLCellValues DataType
    {
      set
      {
        this.ForEach<XLCell>((Action<XLCell>) (c => c.DataType = value));
      }
    }

    public IXLCells Clear(XLClearOptions clearOptions = XLClearOptions.ContentsAndFormats)
    {
      this.ForEach<XLCell>((Action<XLCell>) (c => c.Clear(clearOptions)));
      return (IXLCells) this;
    }

    public void DeleteComments()
    {
      this.ForEach<XLCell>((Action<XLCell>) (c => c.DeleteComment()));
    }

    public string FormulaA1
    {
      set
      {
        this.ForEach<XLCell>((Action<XLCell>) (c => c.FormulaA1 = value));
      }
    }

    public string FormulaR1C1
    {
      set
      {
        this.ForEach<XLCell>((Action<XLCell>) (c => c.FormulaR1C1 = value));
      }
    }

    public IEnumerable<IXLStyle> Styles
    {
      get
      {
        this.UpdatingStyle = true;
        yield return this._style;
        foreach (XLCell xlCell in this)
          yield return xlCell.Style;
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
        this.ForEach<XLCell>((Action<XLCell>) (c => retVal.Add(c.AsRange())));
        return (IXLRanges) retVal;
      }
    }

    public void Add(XLRangeAddress rangeAddress)
    {
      this._rangeAddresses.Add(rangeAddress);
    }

    public void Add(XLCell cell)
    {
      this._rangeAddresses.Add(new XLRangeAddress(cell.Address, cell.Address));
    }

    public void Select()
    {
      foreach (XLCell xlCell in this)
        xlCell.Select();
    }

    private struct MinMax
    {
      public int MaxColumn;
      public int MaxRow;
      public int MinColumn;
      public int MinRow;
    }
  }
}

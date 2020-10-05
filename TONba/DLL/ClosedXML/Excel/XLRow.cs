// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLRow
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace ClosedXML.Excel
{
  internal class XLRow : XLRangeBase, IXLRow, IXLRangeBase, IDisposable
  {
    private bool _collapsed;
    private double _height;
    private bool _isHidden;
    private int _outlineLevel;
    private bool _loading;

    public XLRow(int row, XLRowParameters xlRowParameters)
      : base(new XLRangeAddress(new XLAddress(xlRowParameters.Worksheet, row, 1, false, false), new XLAddress(xlRowParameters.Worksheet, row, 16384, false, false)))
    {
      this.SetRowNumber(row);
      this.IsReference = xlRowParameters.IsReference;
      if (this.IsReference)
      {
        this.SubscribeToShiftedRows((Action<XLRange, int>) ((range, rowShifted) => this.WorksheetRangeShiftedRows(range, rowShifted)));
      }
      else
      {
        this.SetStyle(xlRowParameters.DefaultStyleId);
        this._height = xlRowParameters.Worksheet.RowHeight;
      }
    }

    public XLRow(XLRow row)
      : base(new XLRangeAddress(new XLAddress(row.Worksheet, row.RowNumber(), 1, false, false), new XLAddress(row.Worksheet, row.RowNumber(), 16384, false, false)))
    {
      this._height = row._height;
      this.IsReference = row.IsReference;
      if (this.IsReference)
        this.SubscribeToShiftedRows((Action<XLRange, int>) ((range, rowShifted) => this.WorksheetRangeShiftedRows(range, rowShifted)));
      this._collapsed = row._collapsed;
      this._isHidden = row._isHidden;
      this._outlineLevel = row._outlineLevel;
      this.HeightChanged = row.HeightChanged;
      this.SetStyle(row.GetStyleId());
    }

    public bool IsReference { get; private set; }

    public override IEnumerable<IXLStyle> Styles
    {
      get
      {
        this.UpdatingStyle = true;
        yield return this.Style;
        int row = this.RowNumber();
        foreach (XLCell xlCell in this.Worksheet.Internals.CellsCollection.GetCellsInRow(row))
          yield return xlCell.Style;
        this.UpdatingStyle = false;
      }
    }

    public override bool UpdatingStyle { get; set; }

    public override IXLStyle InnerStyle
    {
      get
      {
        if (!this.IsReference)
          return this.GetStyle();
        return this.Worksheet.Internals.RowsCollection[this.RowNumber()].InnerStyle;
      }
      set
      {
        if (this.IsReference)
          this.Worksheet.Internals.RowsCollection[this.RowNumber()].InnerStyle = value;
        else
          this.SetStyle(value);
      }
    }

    public bool Collapsed
    {
      get
      {
        if (!this.IsReference)
          return this._collapsed;
        return this.Worksheet.Internals.RowsCollection[this.RowNumber()].Collapsed;
      }
      set
      {
        if (this.IsReference)
          this.Worksheet.Internals.RowsCollection[this.RowNumber()].Collapsed = value;
        else
          this._collapsed = value;
      }
    }

    public bool Loading
    {
      get
      {
        if (!this.IsReference)
          return this._loading;
        return this.Worksheet.Internals.RowsCollection[this.RowNumber()].Loading;
      }
      set
      {
        if (this.IsReference)
          this.Worksheet.Internals.RowsCollection[this.RowNumber()].Loading = value;
        else
          this._loading = value;
      }
    }

    public bool HeightChanged { get; private set; }

    public double Height
    {
      get
      {
        if (!this.IsReference)
          return this._height;
        return this.Worksheet.Internals.RowsCollection[this.RowNumber()].Height;
      }
      set
      {
        if (!this.Loading)
          this.HeightChanged = true;
        if (this.IsReference)
          this.Worksheet.Internals.RowsCollection[this.RowNumber()].Height = value;
        else
          this._height = value;
      }
    }

    public void Delete()
    {
      int rowNumber = this.RowNumber();
      using (XLRange xlRange = this.AsRange())
        xlRange.Delete(XLShiftDeletedCells.ShiftCellsUp);
      this.Worksheet.Internals.RowsCollection.Remove(rowNumber);
      List<int> source = new List<int>();
      source.AddRange(this.Worksheet.Internals.RowsCollection.Where<KeyValuePair<int, XLRow>>((Func<KeyValuePair<int, XLRow>, bool>) (c => c.Key > rowNumber)).Select<KeyValuePair<int, XLRow>, int>((Func<KeyValuePair<int, XLRow>, int>) (c => c.Key)));
      foreach (int key in (IEnumerable<int>) source.OrderBy<int, int>((Func<int, int>) (r => r)))
      {
        this.Worksheet.Internals.RowsCollection.Add(key - 1, this.Worksheet.Internals.RowsCollection[key]);
        this.Worksheet.Internals.RowsCollection.Remove(key);
      }
    }

    public IXLRows InsertRowsBelow(int numberOfRows)
    {
      int row = this.RowNumber();
      this.Worksheet.Internals.RowsCollection.ShiftRowsDown(row + 1, numberOfRows);
      using (XLRow xlRow = this.Worksheet.Row(row))
      {
        using (XLRange xlRange = xlRow.AsRange())
          xlRange.InsertRowsBelowVoid(true, numberOfRows, true);
      }
      IXLRows newRows = this.Worksheet.Rows(row + 1, row + numberOfRows);
      this.CopyRows(newRows);
      return newRows;
    }

    private void CopyRows(IXLRows newRows)
    {
      foreach (IXLRow newRow in (IEnumerable<IXLRow>) newRows)
      {
        XLRow rows = this.Worksheet.Internals.RowsCollection[newRow.RowNumber()];
        rows._height = this.Height;
        rows.SetStyle(this.Style);
        rows._collapsed = this.Collapsed;
        rows._isHidden = this.IsHidden;
        rows._outlineLevel = this.OutlineLevel;
      }
    }

    public IXLRows InsertRowsAbove(int numberOfRows)
    {
      int num = this.RowNumber();
      if (num > 1)
      {
        using (XLRow xlRow = this.Worksheet.Row(num - 1))
          return xlRow.InsertRowsBelow(numberOfRows);
      }
      else
      {
        this.Worksheet.Internals.RowsCollection.ShiftRowsDown(num, numberOfRows);
        using (XLRow xlRow = this.Worksheet.Row(num))
        {
          using (XLRange xlRange = xlRow.AsRange())
            xlRange.InsertRowsAboveVoid(true, numberOfRows, true);
        }
        return this.Worksheet.Rows(num, num + numberOfRows - 1);
      }
    }

    public IXLRow Clear(XLClearOptions clearOptions = XLClearOptions.ContentsAndFormats)
    {
      base.Clear(clearOptions);
      return (IXLRow) this;
    }

    public IXLCell Cell(int columnNumber)
    {
      return (IXLCell) this.Cell(1, columnNumber);
    }

    public IXLCell Cell(string columnLetter)
    {
      return (IXLCell) this.Cell(1, columnLetter);
    }

    public new IXLCells Cells()
    {
      return (IXLCells) this.CellsUsed(true);
    }

    public new IXLCells Cells(string cellsInRow)
    {
      XLCells xlCells = new XLCells(false, false, (Func<IXLCell, bool>) null);
      string str1 = cellsInRow;
      char[] chArray = new char[1]{ ',' };
      foreach (string str2 in str1.Split(chArray))
        xlCells.Add(this.Range(str2.Trim()).RangeAddress);
      return (IXLCells) xlCells;
    }

    public IXLCells Cells(int firstColumn, int lastColumn)
    {
      return this.Cells(firstColumn.ToString() + ":" + (object) lastColumn);
    }

    public IXLCells Cells(string firstColumn, string lastColumn)
    {
      return this.Cells(XLHelper.GetColumnNumberFromLetter(firstColumn).ToString() + ":" + (object) XLHelper.GetColumnNumberFromLetter(lastColumn));
    }

    public IXLRow AdjustToContents(int startColumn)
    {
      return this.AdjustToContents(startColumn, 16384);
    }

    public IXLRow AdjustToContents(int startColumn, int endColumn)
    {
      return this.AdjustToContents(startColumn, endColumn, 0.0, double.MaxValue);
    }

    public IXLRow AdjustToContents(double minHeight, double maxHeight)
    {
      return this.AdjustToContents(1, 16384, minHeight, maxHeight);
    }

    public IXLRow AdjustToContents(int startColumn, double minHeight, double maxHeight)
    {
      return this.AdjustToContents(startColumn, 16384, minHeight, maxHeight);
    }

    public IXLRow AdjustToContents(int startColumn, int endColumn, double minHeight, double maxHeight)
    {
      Dictionary<IXLFontBase, Font> fontCache = new Dictionary<IXLFontBase, Font>();
      double num1 = minHeight;
      foreach (XLCell xlCell in this.Row(startColumn, endColumn).CellsUsed().Cast<XLCell>().Where<XLCell>((Func<XLCell, bool>) (c => !c.IsMerged())))
      {
        int textRotation = xlCell.Style.Alignment.TextRotation;
        double num2;
        if (xlCell.HasRichText || textRotation != 0 || xlCell.InnerText.Contains(Environment.NewLine))
        {
          List<KeyValuePair<IXLFontBase, string>> source = new List<KeyValuePair<IXLFontBase, string>>();
          if (xlCell.HasRichText)
          {
            foreach (IXLRichString xlRichString in (IEnumerable<IXLRichString>) xlCell.RichText)
            {
              string[] strArray = xlRichString.Text.Split(new string[1]
              {
                Environment.NewLine
              }, StringSplitOptions.None);
              int num3 = ((IEnumerable<string>) strArray).Count<string>();
              for (int index = 0; index < num3; ++index)
              {
                string str = strArray[index];
                if (index < num3 - 1)
                  str += Environment.NewLine;
                source.Add(new KeyValuePair<IXLFontBase, string>((IXLFontBase) xlRichString, str));
              }
            }
          }
          else
          {
            string[] strArray = xlCell.GetFormattedString().Split(new string[1]
            {
              Environment.NewLine
            }, StringSplitOptions.None);
            int num3 = ((IEnumerable<string>) strArray).Count<string>();
            for (int index = 0; index < num3; ++index)
            {
              string str = strArray[index];
              if (index < num3 - 1)
                str += Environment.NewLine;
              source.Add(new KeyValuePair<IXLFontBase, string>((IXLFontBase) xlCell.Style.Font, str));
            }
          }
          double num4 = (double) source.Max<KeyValuePair<IXLFontBase, string>>((Func<KeyValuePair<IXLFontBase, string>, int>) (kp => kp.Value.Length));
          double num5 = source.Max<KeyValuePair<IXLFontBase, string>>((Func<KeyValuePair<IXLFontBase, string>, double>) (kp => kp.Key.GetHeight(fontCache)));
          int num6 = source.Count<KeyValuePair<IXLFontBase, string>>((Func<KeyValuePair<IXLFontBase, string>, bool>) (kp => kp.Value.Contains(Environment.NewLine))) + 1;
          switch (textRotation)
          {
            case 0:
              num2 = num5 * (double) num6;
              break;
            case (int) byte.MaxValue:
              num2 = num4 * num5;
              break;
            default:
              num2 = (textRotation == 90 || textRotation == 180 || textRotation == (int) byte.MaxValue ? 90.0 : (double) (textRotation % 90)) / 90.0 * num5 * num4 * 0.5;
              break;
          }
        }
        else
          num2 = xlCell.Style.Font.GetHeight(fontCache);
        if (num2 >= maxHeight)
        {
          num1 = maxHeight;
          break;
        }
        if (num2 > num1)
          num1 = num2;
      }
      if (num1 <= 0.0)
        num1 = this.Worksheet.RowHeight;
      this.Height = num1;
      return (IXLRow) this;
    }

    public IXLRow Hide()
    {
      this.IsHidden = true;
      return (IXLRow) this;
    }

    public IXLRow Unhide()
    {
      this.IsHidden = false;
      return (IXLRow) this;
    }

    public bool IsHidden
    {
      get
      {
        if (!this.IsReference)
          return this._isHidden;
        return this.Worksheet.Internals.RowsCollection[this.RowNumber()].IsHidden;
      }
      set
      {
        if (this.IsReference)
          this.Worksheet.Internals.RowsCollection[this.RowNumber()].IsHidden = value;
        else
          this._isHidden = value;
      }
    }

    public override IXLStyle Style
    {
      get
      {
        if (!this.IsReference)
          return this.GetStyle();
        return this.Worksheet.Internals.RowsCollection[this.RowNumber()].Style;
      }
      set
      {
        if (this.IsReference)
        {
          this.Worksheet.Internals.RowsCollection[this.RowNumber()].Style = value;
        }
        else
        {
          this.SetStyle(value);
          int num1 = 1;
          int num2 = 0;
          int num3 = this.RowNumber();
          if (this.Worksheet.Internals.CellsCollection.RowsUsed.ContainsKey(num3))
          {
            num1 = this.Worksheet.Internals.CellsCollection.MinColumnInRow(num3);
            num2 = this.Worksheet.Internals.CellsCollection.MaxColumnInRow(num3);
          }
          if (this.Worksheet.Internals.ColumnsCollection.Count > 0)
          {
            int num4 = this.Worksheet.Internals.ColumnsCollection.Keys.Min();
            int num5 = this.Worksheet.Internals.ColumnsCollection.Keys.Max();
            if (num4 < num1)
              num1 = num4;
            if (num5 > num2)
              num2 = num5;
          }
          if (num1 <= 0 || num2 <= 0)
            return;
          for (int column = num1; column <= num2; ++column)
            this.Worksheet.Cell(num3, column).Style = value;
        }
      }
    }

    public int OutlineLevel
    {
      get
      {
        if (!this.IsReference)
          return this._outlineLevel;
        return this.Worksheet.Internals.RowsCollection[this.RowNumber()].OutlineLevel;
      }
      set
      {
        switch (value)
        {
          case 0:
          case 1:
          case 2:
          case 3:
          case 4:
          case 5:
          case 6:
          case 7:
          case 8:
            if (this.IsReference)
            {
              this.Worksheet.Internals.RowsCollection[this.RowNumber()].OutlineLevel = value;
              break;
            }
            this.Worksheet.IncrementColumnOutline(value);
            this.Worksheet.DecrementColumnOutline(this._outlineLevel);
            this._outlineLevel = value;
            break;
          default:
            throw new ArgumentOutOfRangeException(nameof (value), "Outline level must be between 0 and 8.");
        }
      }
    }

    public IXLRow Group()
    {
      return this.Group(false);
    }

    public IXLRow Group(int outlineLevel)
    {
      return this.Group(outlineLevel, false);
    }

    public IXLRow Ungroup()
    {
      return this.Ungroup(false);
    }

    public IXLRow Group(bool collapse)
    {
      if (this.OutlineLevel < 8)
        ++this.OutlineLevel;
      this.Collapsed = collapse;
      return (IXLRow) this;
    }

    public IXLRow Group(int outlineLevel, bool collapse)
    {
      this.OutlineLevel = outlineLevel;
      this.Collapsed = collapse;
      return (IXLRow) this;
    }

    public IXLRow Ungroup(bool ungroupFromAll)
    {
      if (ungroupFromAll)
        this.OutlineLevel = 0;
      else if (this.OutlineLevel > 0)
        --this.OutlineLevel;
      return (IXLRow) this;
    }

    public IXLRow Collapse()
    {
      this.Collapsed = true;
      return this.Hide();
    }

    public IXLRow Expand()
    {
      this.Collapsed = false;
      return this.Unhide();
    }

    public int CellCount()
    {
      return this.RangeAddress.LastAddress.ColumnNumber - this.RangeAddress.FirstAddress.ColumnNumber + 1;
    }

    public IXLRow Sort()
    {
      return this.SortLeftToRight(XLSortOrder.Ascending, false, true);
    }

    public IXLRow SortLeftToRight(XLSortOrder sortOrder = XLSortOrder.Ascending, bool matchCase = false, bool ignoreBlanks = true)
    {
      base.SortLeftToRight(sortOrder, matchCase, ignoreBlanks);
      return (IXLRow) this;
    }

    IXLRangeRow IXLRow.CopyTo(IXLCell target)
    {
      using (XLRange xlRange1 = this.AsRange())
      {
        using (IXLRange xlRange2 = xlRange1.CopyTo(target))
          return xlRange2.Row(1);
      }
    }

    IXLRangeRow IXLRow.CopyTo(IXLRangeBase target)
    {
      using (XLRange xlRange1 = this.AsRange())
      {
        using (IXLRange xlRange2 = xlRange1.CopyTo(target))
          return xlRange2.Row(1);
      }
    }

    public IXLRow CopyTo(IXLRow row)
    {
      row.Clear(XLClearOptions.ContentsAndFormats);
      XLRow xlRow = (XLRow) row;
      xlRow._height = this._height;
      xlRow.Style = this.GetStyle();
      using (XLRange xlRange = this.AsRange())
        xlRange.CopyTo((IXLRangeBase) row).Dispose();
      return (IXLRow) xlRow;
    }

    public IXLRangeRow Row(int start, int end)
    {
      return (IXLRangeRow) this.Range(1, start, 1, end).Row(1);
    }

    public IXLRangeRow Row(IXLCell start, IXLCell end)
    {
      return this.Row(start.Address.ColumnNumber, end.Address.ColumnNumber);
    }

    public IXLRangeRows Rows(string rows)
    {
      XLRangeRows xlRangeRows = new XLRangeRows();
      string str1 = rows;
      char[] chArray = new char[1]{ ',' };
      foreach (string str2 in str1.Split(chArray))
      {
        using (XLRange xlRange = this.AsRange())
          xlRange.Rows(str2.Trim()).ForEach<IXLRangeRow>(new Action<IXLRangeRow>(xlRangeRows.Add));
      }
      return (IXLRangeRows) xlRangeRows;
    }

    public IXLRow AddHorizontalPageBreak()
    {
      this.Worksheet.PageSetup.AddHorizontalPageBreak(this.RowNumber());
      return (IXLRow) this;
    }

    public IXLRow SetDataType(XLCellValues dataType)
    {
      this.DataType = dataType;
      return (IXLRow) this;
    }

    public IXLRangeRow RowUsed(bool includeFormats = false)
    {
      return this.Row((IXLCell) this.FirstCellUsed(includeFormats), (IXLCell) this.LastCellUsed(includeFormats));
    }

    public override XLRange AsRange()
    {
      return this.Range(1, 1, 1, 16384);
    }

    private void WorksheetRangeShiftedRows(XLRange range, int rowsShifted)
    {
      if (range.RangeAddress.FirstAddress.RowNumber > this.RowNumber())
        return;
      this.SetRowNumber(this.RowNumber() + rowsShifted);
    }

    private void SetRowNumber(int row)
    {
      if (row <= 0)
      {
        this.RangeAddress.IsInvalid = false;
      }
      else
      {
        this.RangeAddress.FirstAddress = new XLAddress(this.Worksheet, row, 1, this.RangeAddress.FirstAddress.FixedRow, this.RangeAddress.FirstAddress.FixedColumn);
        this.RangeAddress.LastAddress = new XLAddress(this.Worksheet, row, 16384, this.RangeAddress.LastAddress.FixedRow, this.RangeAddress.LastAddress.FixedColumn);
      }
    }

    public override XLRange Range(string rangeAddressStr)
    {
      string rangeAddress;
      if (rangeAddressStr.Contains<char>(':') || rangeAddressStr.Contains<char>('-'))
      {
        if (rangeAddressStr.Contains<char>('-'))
          rangeAddressStr = rangeAddressStr.Replace('-', ':');
        string[] strArray = rangeAddressStr.Split(':');
        rangeAddress = this.FixRowAddress(strArray[0]) + ":" + this.FixRowAddress(strArray[1]);
      }
      else
        rangeAddress = this.FixRowAddress(rangeAddressStr);
      return this.Range((IXLRangeAddress) new XLRangeAddress(this.Worksheet, rangeAddress));
    }

    public IXLRow AdjustToContents()
    {
      return this.AdjustToContents(1);
    }

    internal void SetStyleNoColumns(IXLStyle value)
    {
      if (this.IsReference)
      {
        this.Worksheet.Internals.RowsCollection[this.RowNumber()].SetStyleNoColumns(value);
      }
      else
      {
        this.SetStyle(value);
        foreach (XLCell xlCell in this.Worksheet.Internals.CellsCollection.GetCellsInRow(this.RowNumber()))
          xlCell.Style = value;
      }
    }

    private XLRow RowShift(int rowsToShift)
    {
      return this.Worksheet.Row(this.RowNumber() + rowsToShift);
    }

    IXLRow IXLRow.RowAbove()
    {
      return (IXLRow) this.RowAbove();
    }

    IXLRow IXLRow.RowAbove(int step)
    {
      return (IXLRow) this.RowAbove(step);
    }

    public XLRow RowAbove()
    {
      return this.RowAbove(1);
    }

    public XLRow RowAbove(int step)
    {
      return this.RowShift(step * -1);
    }

    IXLRow IXLRow.RowBelow()
    {
      return (IXLRow) this.RowBelow();
    }

    IXLRow IXLRow.RowBelow(int step)
    {
      return (IXLRow) this.RowBelow(step);
    }

    public XLRow RowBelow()
    {
      return this.RowBelow(1);
    }

    public XLRow RowBelow(int step)
    {
      return this.RowShift(step);
    }

    public new bool IsEmpty()
    {
      return this.IsEmpty(false);
    }

    public new bool IsEmpty(bool includeFormats)
    {
      if (includeFormats && !this.Style.Equals(this.Worksheet.Style))
        return false;
      return base.IsEmpty(includeFormats);
    }
  }
}

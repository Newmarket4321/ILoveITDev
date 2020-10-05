// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLColumn
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace ClosedXML.Excel
{
  internal class XLColumn : XLRangeBase, IXLColumn, IXLRangeBase, IDisposable
  {
    private bool _collapsed;
    private bool _isHidden;
    private int _outlineLevel;
    private double _width;

    public XLColumn(int column, XLColumnParameters xlColumnParameters)
      : base(new XLRangeAddress(new XLAddress(xlColumnParameters.Worksheet, 1, column, false, false), new XLAddress(xlColumnParameters.Worksheet, 1048576, column, false, false)))
    {
      this.SetColumnNumber(column);
      this.IsReference = xlColumnParameters.IsReference;
      if (this.IsReference)
      {
        this.SubscribeToShiftedColumns((Action<XLRange, int>) ((range, columnsShifted) => this.WorksheetRangeShiftedColumns(range, columnsShifted)));
      }
      else
      {
        this.SetStyle(xlColumnParameters.DefaultStyleId);
        this._width = xlColumnParameters.Worksheet.ColumnWidth;
      }
    }

    public XLColumn(XLColumn column)
      : base(new XLRangeAddress(new XLAddress(column.Worksheet, 1, column.ColumnNumber(), false, false), new XLAddress(column.Worksheet, 1048576, column.ColumnNumber(), false, false)))
    {
      this._width = column._width;
      this.IsReference = column.IsReference;
      if (this.IsReference)
        this.SubscribeToShiftedColumns((Action<XLRange, int>) ((range, columnsShifted) => this.WorksheetRangeShiftedColumns(range, columnsShifted)));
      this._collapsed = column._collapsed;
      this._isHidden = column._isHidden;
      this._outlineLevel = column._outlineLevel;
      this.SetStyle(column.GetStyleId());
    }

    public bool IsReference { get; private set; }

    public override IEnumerable<IXLStyle> Styles
    {
      get
      {
        this.UpdatingStyle = true;
        yield return this.Style;
        int column = this.ColumnNumber();
        foreach (XLCell xlCell in this.Worksheet.Internals.CellsCollection.GetCellsInColumn(column))
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
        return this.Worksheet.Internals.ColumnsCollection[this.ColumnNumber()].InnerStyle;
      }
      set
      {
        if (this.IsReference)
          this.Worksheet.Internals.ColumnsCollection[this.ColumnNumber()].InnerStyle = value;
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
        return this.Worksheet.Internals.ColumnsCollection[this.ColumnNumber()].Collapsed;
      }
      set
      {
        if (this.IsReference)
          this.Worksheet.Internals.ColumnsCollection[this.ColumnNumber()].Collapsed = value;
        else
          this._collapsed = value;
      }
    }

    public double Width
    {
      get
      {
        if (!this.IsReference)
          return this._width;
        return this.Worksheet.Internals.ColumnsCollection[this.ColumnNumber()].Width;
      }
      set
      {
        if (this.IsReference)
          this.Worksheet.Internals.ColumnsCollection[this.ColumnNumber()].Width = value;
        else
          this._width = value;
      }
    }

    public void Delete()
    {
      int columnNumber = this.ColumnNumber();
      using (XLRange xlRange = this.AsRange())
        xlRange.Delete(XLShiftDeletedCells.ShiftCellsLeft);
      this.Worksheet.Internals.ColumnsCollection.Remove(columnNumber);
      List<int> source = new List<int>();
      source.AddRange(this.Worksheet.Internals.ColumnsCollection.Where<KeyValuePair<int, XLColumn>>((Func<KeyValuePair<int, XLColumn>, bool>) (c => c.Key > columnNumber)).Select<KeyValuePair<int, XLColumn>, int>((Func<KeyValuePair<int, XLColumn>, int>) (c => c.Key)));
      foreach (int key in (IEnumerable<int>) source.OrderBy<int, int>((Func<int, int>) (c => c)))
      {
        this.Worksheet.Internals.ColumnsCollection.Add(key - 1, this.Worksheet.Internals.ColumnsCollection[key]);
        this.Worksheet.Internals.ColumnsCollection.Remove(key);
      }
    }

    public IXLColumn Clear(XLClearOptions clearOptions = XLClearOptions.ContentsAndFormats)
    {
      base.Clear(clearOptions);
      return (IXLColumn) this;
    }

    public IXLCell Cell(int rowNumber)
    {
      return (IXLCell) this.Cell(rowNumber, 1);
    }

    public new IXLCells Cells(string cellsInColumn)
    {
      XLCells xlCells = new XLCells(false, false, (Func<IXLCell, bool>) null);
      string str1 = cellsInColumn;
      char[] chArray = new char[1]{ ',' };
      foreach (string str2 in str1.Split(chArray))
        xlCells.Add(this.Range(str2.Trim()).RangeAddress);
      return (IXLCells) xlCells;
    }

    public new IXLCells Cells()
    {
      return (IXLCells) this.CellsUsed(true);
    }

    public IXLCells Cells(int firstRow, int lastRow)
    {
      return this.Cells(firstRow.ToString() + ":" + (object) lastRow);
    }

    public override IXLStyle Style
    {
      get
      {
        if (!this.IsReference)
          return this.GetStyle();
        return this.Worksheet.Internals.ColumnsCollection[this.ColumnNumber()].Style;
      }
      set
      {
        if (this.IsReference)
        {
          this.Worksheet.Internals.ColumnsCollection[this.ColumnNumber()].Style = value;
        }
        else
        {
          this.SetStyle(value);
          int num1 = 1;
          int num2 = 0;
          int num3 = this.ColumnNumber();
          if (this.Worksheet.Internals.CellsCollection.ColumnsUsed.ContainsKey(num3))
          {
            num1 = this.Worksheet.Internals.CellsCollection.MinRowInColumn(num3);
            num2 = this.Worksheet.Internals.CellsCollection.MaxRowInColumn(num3);
          }
          if (this.Worksheet.Internals.RowsCollection.Count > 0)
          {
            int num4 = this.Worksheet.Internals.RowsCollection.Keys.Min();
            int num5 = this.Worksheet.Internals.RowsCollection.Keys.Max();
            if (num4 < num1)
              num1 = num4;
            if (num5 > num2)
              num2 = num5;
          }
          if (num1 <= 0 || num2 <= 0)
            return;
          for (int row = num1; row <= num2; ++row)
            this.Worksheet.Cell(row, num3).Style = value;
        }
      }
    }

    public IXLColumns InsertColumnsAfter(int numberOfColumns)
    {
      int column = this.ColumnNumber();
      this.Worksheet.Internals.ColumnsCollection.ShiftColumnsRight(column + 1, numberOfColumns);
      using (XLColumn xlColumn = this.Worksheet.Column(column))
      {
        using (XLRange xlRange = xlColumn.AsRange())
          xlRange.InsertColumnsAfterVoid(true, numberOfColumns, true);
      }
      IXLColumns newColumns = this.Worksheet.Columns(column + 1, column + numberOfColumns);
      this.CopyColumns(newColumns);
      return newColumns;
    }

    public IXLColumns InsertColumnsBefore(int numberOfColumns)
    {
      int num = this.ColumnNumber();
      if (num > 1)
      {
        using (XLColumn xlColumn = this.Worksheet.Column(num - 1))
          return xlColumn.InsertColumnsAfter(numberOfColumns);
      }
      else
      {
        this.Worksheet.Internals.ColumnsCollection.ShiftColumnsRight(num, numberOfColumns);
        using (XLColumn xlColumn = this.Worksheet.Column(num))
        {
          using (XLRange xlRange = xlColumn.AsRange())
            xlRange.InsertColumnsBeforeVoid(true, numberOfColumns, true);
        }
        return this.Worksheet.Columns(num, num + numberOfColumns - 1);
      }
    }

    private void CopyColumns(IXLColumns newColumns)
    {
      foreach (IXLColumn newColumn in (IEnumerable<IXLColumn>) newColumns)
      {
        XLColumn columns = this.Worksheet.Internals.ColumnsCollection[newColumn.ColumnNumber()];
        columns._width = this.Width;
        columns.SetStyle(this.Style);
        columns._collapsed = this.Collapsed;
        columns._isHidden = this.IsHidden;
        columns._outlineLevel = this.OutlineLevel;
      }
    }

    public IXLColumn AdjustToContents()
    {
      return this.AdjustToContents(1);
    }

    public IXLColumn AdjustToContents(int startRow)
    {
      return this.AdjustToContents(startRow, 1048576);
    }

    public IXLColumn AdjustToContents(int startRow, int endRow)
    {
      return this.AdjustToContents(startRow, endRow, 0.0, double.MaxValue);
    }

    public IXLColumn AdjustToContents(double minWidth, double maxWidth)
    {
      return this.AdjustToContents(1, 1048576, minWidth, maxWidth);
    }

    public IXLColumn AdjustToContents(int startRow, double minWidth, double maxWidth)
    {
      return this.AdjustToContents(startRow, 1048576, minWidth, maxWidth);
    }

    public IXLColumn AdjustToContents(int startRow, int endRow, double minWidth, double maxWidth)
    {
      Dictionary<IXLFontBase, Font> fontCache = new Dictionary<IXLFontBase, Font>();
      double num1 = minWidth;
      foreach (XLCell xlCell in (IEnumerable<IXLCell>) this.Column(startRow, endRow).CellsUsed())
      {
        if (!xlCell.IsMerged())
        {
          double num2 = 0.0;
          int textRotation = xlCell.Style.Alignment.TextRotation;
          if (xlCell.HasRichText || textRotation != 0 || xlCell.InnerText.Contains(Environment.NewLine))
          {
            List<KeyValuePair<IXLFontBase, string>> keyValuePairList = new List<KeyValuePair<IXLFontBase, string>>();
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
                  keyValuePairList.Add(new KeyValuePair<IXLFontBase, string>((IXLFontBase) xlRichString, str));
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
                keyValuePairList.Add(new KeyValuePair<IXLFontBase, string>((IXLFontBase) xlCell.Style.Font, str));
              }
            }
            double num4 = 0.0;
            bool flag = false;
            double num5 = 0.0;
            int num6 = 1;
            foreach (KeyValuePair<IXLFontBase, string> keyValuePair in keyValuePairList)
            {
              IXLFontBase key = keyValuePair.Key;
              string text = keyValuePair.Value;
              int length = text.IndexOf(Environment.NewLine);
              switch (textRotation)
              {
                case 0:
                  if (length >= 0)
                  {
                    if (length > 0)
                      num4 += key.GetWidth(text.Substring(0, length), fontCache);
                    if (num4 > num2)
                      num2 = num4;
                    num4 = length < text.Length - 2 ? key.GetWidth(text.Substring(length + 2), fontCache) : 0.0;
                    continue;
                  }
                  num4 += key.GetWidth(text, fontCache);
                  continue;
                case (int) byte.MaxValue:
                  if (num4 <= 0.0)
                    num4 = key.GetWidth("X", fontCache);
                  if (length >= 0)
                  {
                    num4 += key.GetWidth("X", fontCache);
                    continue;
                  }
                  continue;
                default:
                  flag = true;
                  double width = key.GetWidth("X", fontCache);
                  if (width > num5)
                    num5 = width;
                  if (length >= 0)
                  {
                    ++num6;
                    if (length > 0)
                      num4 += key.GetWidth(text.Substring(0, length), fontCache);
                    if (num4 > num2)
                      num2 = num4;
                    num4 = length < text.Length - 2 ? key.GetWidth(text.Substring(length + 2), fontCache) : 0.0;
                    continue;
                  }
                  num4 += key.GetWidth(text, fontCache);
                  continue;
              }
            }
            if (num4 > num2)
              num2 = num4;
            if (flag)
            {
              double radian = XLColumn.DegreeToRadian(textRotation == 90 || textRotation == 180 || textRotation == (int) byte.MaxValue ? 90.0 : (double) (textRotation % 90));
              num2 = num2 * Math.Cos(radian) + num5 * (double) num6;
            }
          }
          else
            num2 = xlCell.Style.Font.GetWidth(xlCell.GetFormattedString(), fontCache);
          if (num2 >= maxWidth)
          {
            num1 = maxWidth;
            break;
          }
          if (num2 > num1)
            num1 = num2 + 1.0;
        }
      }
      if (num1 <= 0.0)
        num1 = this.Worksheet.ColumnWidth;
      this.Width = num1;
      return (IXLColumn) this;
    }

    public IXLColumn Hide()
    {
      this.IsHidden = true;
      return (IXLColumn) this;
    }

    public IXLColumn Unhide()
    {
      this.IsHidden = false;
      return (IXLColumn) this;
    }

    public bool IsHidden
    {
      get
      {
        if (!this.IsReference)
          return this._isHidden;
        return this.Worksheet.Internals.ColumnsCollection[this.ColumnNumber()].IsHidden;
      }
      set
      {
        if (this.IsReference)
          this.Worksheet.Internals.ColumnsCollection[this.ColumnNumber()].IsHidden = value;
        else
          this._isHidden = value;
      }
    }

    public int OutlineLevel
    {
      get
      {
        if (!this.IsReference)
          return this._outlineLevel;
        return this.Worksheet.Internals.ColumnsCollection[this.ColumnNumber()].OutlineLevel;
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
              this.Worksheet.Internals.ColumnsCollection[this.ColumnNumber()].OutlineLevel = value;
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

    public IXLColumn Group()
    {
      return this.Group(false);
    }

    public IXLColumn Group(bool collapse)
    {
      if (this.OutlineLevel < 8)
        ++this.OutlineLevel;
      this.Collapsed = collapse;
      return (IXLColumn) this;
    }

    public IXLColumn Group(int outlineLevel)
    {
      return this.Group(outlineLevel, false);
    }

    public IXLColumn Group(int outlineLevel, bool collapse)
    {
      this.OutlineLevel = outlineLevel;
      this.Collapsed = collapse;
      return (IXLColumn) this;
    }

    public IXLColumn Ungroup()
    {
      return this.Ungroup(false);
    }

    public IXLColumn Ungroup(bool ungroupFromAll)
    {
      if (ungroupFromAll)
        this.OutlineLevel = 0;
      else if (this.OutlineLevel > 0)
        --this.OutlineLevel;
      return (IXLColumn) this;
    }

    public IXLColumn Collapse()
    {
      this.Collapsed = true;
      return this.Hide();
    }

    public IXLColumn Expand()
    {
      this.Collapsed = false;
      return this.Unhide();
    }

    public int CellCount()
    {
      return this.RangeAddress.LastAddress.ColumnNumber - this.RangeAddress.FirstAddress.ColumnNumber + 1;
    }

    public IXLColumn Sort(XLSortOrder sortOrder = XLSortOrder.Ascending, bool matchCase = false, bool ignoreBlanks = true)
    {
      this.Sort(1, sortOrder, matchCase, ignoreBlanks);
      return (IXLColumn) this;
    }

    IXLRangeColumn IXLColumn.CopyTo(IXLCell target)
    {
      using (XLRange xlRange1 = this.AsRange())
      {
        using (IXLRange xlRange2 = xlRange1.CopyTo(target))
          return xlRange2.Column(1);
      }
    }

    IXLRangeColumn IXLColumn.CopyTo(IXLRangeBase target)
    {
      using (XLRange xlRange1 = this.AsRange())
      {
        using (IXLRange xlRange2 = xlRange1.CopyTo(target))
          return xlRange2.Column(1);
      }
    }

    public IXLColumn CopyTo(IXLColumn column)
    {
      column.Clear(XLClearOptions.ContentsAndFormats);
      XLColumn xlColumn = (XLColumn) column;
      xlColumn._width = this._width;
      xlColumn.Style = this.GetStyle();
      using (XLRange xlRange = this.AsRange())
        xlRange.CopyTo((IXLRangeBase) column).Dispose();
      return (IXLColumn) xlColumn;
    }

    public IXLRangeColumn Column(int start, int end)
    {
      return (IXLRangeColumn) this.Range(start, 1, end, 1).Column(1);
    }

    public IXLRangeColumn Column(IXLCell start, IXLCell end)
    {
      return this.Column(start.Address.RowNumber, end.Address.RowNumber);
    }

    public IXLRangeColumns Columns(string columns)
    {
      XLRangeColumns xlRangeColumns = new XLRangeColumns();
      string str1 = columns;
      char[] chArray = new char[1]{ ',' };
      foreach (string str2 in str1.Split(chArray))
      {
        using (XLRange xlRange = this.AsRange())
          xlRange.Columns(str2.Trim()).ForEach<IXLRangeColumn>(new Action<IXLRangeColumn>(xlRangeColumns.Add));
      }
      return (IXLRangeColumns) xlRangeColumns;
    }

    public IXLColumn AddVerticalPageBreak()
    {
      this.Worksheet.PageSetup.AddVerticalPageBreak(this.ColumnNumber());
      return (IXLColumn) this;
    }

    public IXLColumn SetDataType(XLCellValues dataType)
    {
      this.DataType = dataType;
      return (IXLColumn) this;
    }

    public IXLRangeColumn ColumnUsed(bool includeFormats = false)
    {
      return this.Column((IXLCell) this.FirstCellUsed(includeFormats), (IXLCell) this.LastCellUsed(includeFormats));
    }

    public override XLRange AsRange()
    {
      return this.Range(1, 1, 1048576, 1);
    }

    private void WorksheetRangeShiftedColumns(XLRange range, int columnsShifted)
    {
      if (range.RangeAddress.FirstAddress.ColumnNumber > this.ColumnNumber())
        return;
      this.SetColumnNumber(this.ColumnNumber() + columnsShifted);
    }

    private void SetColumnNumber(int column)
    {
      if (column <= 0)
      {
        this.RangeAddress.IsInvalid = false;
      }
      else
      {
        this.RangeAddress.FirstAddress = new XLAddress(this.Worksheet, 1, column, this.RangeAddress.FirstAddress.FixedRow, this.RangeAddress.FirstAddress.FixedColumn);
        this.RangeAddress.LastAddress = new XLAddress(this.Worksheet, 1048576, column, this.RangeAddress.LastAddress.FixedRow, this.RangeAddress.LastAddress.FixedColumn);
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
        rangeAddress = this.FixColumnAddress(strArray[0]) + ":" + this.FixColumnAddress(strArray[1]);
      }
      else
        rangeAddress = this.FixColumnAddress(rangeAddressStr);
      return this.Range((IXLRangeAddress) new XLRangeAddress(this.Worksheet, rangeAddress));
    }

    public IXLRangeColumn Range(int firstRow, int lastRow)
    {
      return (IXLRangeColumn) this.Range(firstRow, 1, lastRow, 1).Column(1);
    }

    private static double DegreeToRadian(double angle)
    {
      return Math.PI * angle / 180.0;
    }

    private XLColumn ColumnShift(int columnsToShift)
    {
      return this.Worksheet.Column(this.ColumnNumber() + columnsToShift);
    }

    IXLColumn IXLColumn.ColumnLeft()
    {
      return (IXLColumn) this.ColumnLeft();
    }

    IXLColumn IXLColumn.ColumnLeft(int step)
    {
      return (IXLColumn) this.ColumnLeft(step);
    }

    public XLColumn ColumnLeft()
    {
      return this.ColumnLeft(1);
    }

    public XLColumn ColumnLeft(int step)
    {
      return this.ColumnShift(step * -1);
    }

    IXLColumn IXLColumn.ColumnRight()
    {
      return (IXLColumn) this.ColumnRight();
    }

    IXLColumn IXLColumn.ColumnRight(int step)
    {
      return (IXLColumn) this.ColumnRight(step);
    }

    public XLColumn ColumnRight()
    {
      return this.ColumnRight(1);
    }

    public XLColumn ColumnRight(int step)
    {
      return this.ColumnShift(step);
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

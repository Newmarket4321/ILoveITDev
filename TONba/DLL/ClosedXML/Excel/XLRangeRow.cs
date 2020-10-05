// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLRangeRow
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace ClosedXML.Excel
{
  internal class XLRangeRow : XLRangeBase, IXLRangeRow, IXLRangeBase, IDisposable
  {
    public XLRangeRow(XLRangeParameters rangeParameters, bool quickLoad)
      : base(rangeParameters.RangeAddress)
    {
      this.RangeParameters = rangeParameters;
      if (quickLoad)
        return;
      if (!this.RangeParameters.IgnoreEvents)
      {
        this.SubscribeToShiftedRows((Action<XLRange, int>) ((range, rowsShifted) => this.WorksheetRangeShiftedRows(range, rowsShifted)));
        this.SubscribeToShiftedColumns((Action<XLRange, int>) ((range, columnsShifted) => this.WorksheetRangeShiftedColumns(range, columnsShifted)));
      }
      this.SetStyle(rangeParameters.DefaultStyle);
    }

    public XLRangeParameters RangeParameters { get; private set; }

    public IXLCell Cell(int column)
    {
      return (IXLCell) this.Cell(1, column);
    }

    public IXLCell Cell(string column)
    {
      return (IXLCell) this.Cell(1, column);
    }

    public void Delete()
    {
      this.Delete(XLShiftDeletedCells.ShiftCellsUp);
    }

    public IXLCells InsertCellsAfter(int numberOfColumns)
    {
      return this.InsertCellsAfter(numberOfColumns, true);
    }

    public IXLCells InsertCellsAfter(int numberOfColumns, bool expandRange)
    {
      return this.InsertColumnsAfter(numberOfColumns, expandRange).Cells();
    }

    public IXLCells InsertCellsBefore(int numberOfColumns)
    {
      return this.InsertCellsBefore(numberOfColumns, false);
    }

    public IXLCells InsertCellsBefore(int numberOfColumns, bool expandRange)
    {
      return this.InsertColumnsBefore(numberOfColumns, expandRange).Cells();
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

    public int CellCount()
    {
      return this.RangeAddress.LastAddress.ColumnNumber - this.RangeAddress.FirstAddress.ColumnNumber + 1;
    }

    public IXLRangeRow Sort()
    {
      return this.SortLeftToRight(XLSortOrder.Ascending, false, true);
    }

    public IXLRangeRow SortLeftToRight(XLSortOrder sortOrder = XLSortOrder.Ascending, bool matchCase = false, bool ignoreBlanks = true)
    {
      base.SortLeftToRight(sortOrder, matchCase, ignoreBlanks);
      return (IXLRangeRow) this;
    }

    public IXLRangeRow CopyTo(IXLCell target)
    {
      base.CopyTo(target);
      int lastCellRow = target.Address.RowNumber + this.RowCount() - 1;
      if (lastCellRow > 1048576)
        lastCellRow = 1048576;
      int lastCellColumn = target.Address.ColumnNumber + this.ColumnCount() - 1;
      if (lastCellColumn > 16384)
        lastCellColumn = 16384;
      return target.Worksheet.Range(target.Address.RowNumber, target.Address.ColumnNumber, lastCellRow, lastCellColumn).Row(1);
    }

    public IXLRangeRow CopyTo(IXLRangeBase target)
    {
      base.CopyTo(target);
      int lastCellRow = target.RangeAddress.FirstAddress.RowNumber + this.RowCount() - 1;
      if (lastCellRow > 1048576)
        lastCellRow = 1048576;
      int lastCellColumn = target.RangeAddress.LastAddress.ColumnNumber + this.ColumnCount() - 1;
      if (lastCellColumn > 16384)
        lastCellColumn = 16384;
      return target.Worksheet.Range(target.RangeAddress.FirstAddress.RowNumber, target.RangeAddress.LastAddress.ColumnNumber, lastCellRow, lastCellColumn).Row(1);
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
      foreach (string source in ((IEnumerable<string>) rows.Split(',')).Select<string, string>((Func<string, string>) (pair => pair.Trim())))
      {
        string firstCellAddress;
        string lastCellAddress;
        if (source.Contains<char>(':') || source.Contains<char>('-'))
        {
          string[] strArray1;
          if (!source.Contains<char>('-'))
            strArray1 = source.Split(':');
          else
            strArray1 = source.Replace('-', ':').Split(':');
          string[] strArray2 = strArray1;
          firstCellAddress = strArray2[0];
          lastCellAddress = strArray2[1];
        }
        else
        {
          firstCellAddress = source;
          lastCellAddress = source;
        }
        xlRangeRows.Add((IXLRangeRow) this.Range(firstCellAddress, lastCellAddress).FirstRow((Func<IXLRangeRow, bool>) null));
      }
      return (IXLRangeRows) xlRangeRows;
    }

    public IXLRangeRow SetDataType(XLCellValues dataType)
    {
      this.DataType = dataType;
      return (IXLRangeRow) this;
    }

    public IXLRow WorksheetRow()
    {
      return (IXLRow) this.Worksheet.Row(this.RangeAddress.FirstAddress.RowNumber);
    }

    private void WorksheetRangeShiftedColumns(XLRange range, int columnsShifted)
    {
      this.ShiftColumns((IXLRangeAddress) this.RangeAddress, range, columnsShifted);
    }

    private void WorksheetRangeShiftedRows(XLRange range, int rowsShifted)
    {
      this.ShiftRows((IXLRangeAddress) this.RangeAddress, range, rowsShifted);
    }

    public IXLRange Range(int firstColumn, int lastColumn)
    {
      return (IXLRange) this.Range(1, firstColumn, 1, lastColumn);
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

    public int CompareTo(XLRangeRow otherRow, IXLSortElements columnsToSort)
    {
      foreach (IXLSortElement xlSortElement in (IEnumerable<IXLSortElement>) columnsToSort)
      {
        XLCell xlCell1 = (XLCell) this.Cell(xlSortElement.ElementNumber);
        XLCell xlCell2 = (XLCell) otherRow.Cell(xlSortElement.ElementNumber);
        bool flag1 = xlCell1.IsEmpty();
        bool flag2 = xlCell2.IsEmpty();
        int num = !xlSortElement.IgnoreBlanks || !flag1 && !flag2 ? (xlCell1.DataType != xlCell2.DataType ? (!xlSortElement.MatchCase ? xlCell1.GetString().CompareTo(xlCell2.GetString()) : string.Compare(xlCell1.GetString(), xlCell2.GetString(), true)) : (xlCell1.DataType != XLCellValues.Text ? (xlCell1.DataType != XLCellValues.TimeSpan ? double.Parse(xlCell1.InnerText).CompareTo(double.Parse(xlCell2.InnerText)) : xlCell1.GetTimeSpan().CompareTo(xlCell2.GetTimeSpan())) : (xlSortElement.MatchCase ? xlCell1.InnerText.CompareTo(xlCell2.InnerText) : string.Compare(xlCell1.InnerText, xlCell2.InnerText, true)))) : (!flag1 || !flag2 ? (!flag1 ? (xlSortElement.SortOrder == XLSortOrder.Ascending ? -1 : 1) : (xlSortElement.SortOrder == XLSortOrder.Ascending ? 1 : -1)) : 0);
        if (num != 0)
          return xlSortElement.SortOrder == XLSortOrder.Ascending ? num : num * -1;
      }
      return 0;
    }

    private XLRangeRow RowShift(int rowsToShift)
    {
      int num = this.RowNumber() + rowsToShift;
      XLRange xlRange = this.Worksheet.Range(num, this.RangeAddress.FirstAddress.ColumnNumber, num, this.RangeAddress.LastAddress.ColumnNumber);
      XLRangeRow xlRangeRow = xlRange.FirstRow((Func<IXLRangeRow, bool>) null);
      xlRange.Dispose();
      return xlRangeRow;
    }

    IXLRangeRow IXLRangeRow.RowAbove()
    {
      return (IXLRangeRow) this.RowAbove();
    }

    IXLRangeRow IXLRangeRow.RowAbove(int step)
    {
      return (IXLRangeRow) this.RowAbove(step);
    }

    public XLRangeRow RowAbove()
    {
      return this.RowAbove(1);
    }

    public XLRangeRow RowAbove(int step)
    {
      return this.RowShift(step * -1);
    }

    IXLRangeRow IXLRangeRow.RowBelow()
    {
      return (IXLRangeRow) this.RowBelow();
    }

    IXLRangeRow IXLRangeRow.RowBelow(int step)
    {
      return (IXLRangeRow) this.RowBelow(step);
    }

    public XLRangeRow RowBelow()
    {
      return this.RowBelow(1);
    }

    public XLRangeRow RowBelow(int step)
    {
      return this.RowShift(step);
    }

    public IXLRangeRow Clear(XLClearOptions clearOptions = XLClearOptions.ContentsAndFormats)
    {
      base.Clear(clearOptions);
      return (IXLRangeRow) this;
    }

    public IXLRangeRow RowUsed(bool includeFormats = false)
    {
      return this.Row((IXLCell) this.FirstCellUsed(includeFormats), (IXLCell) this.LastCellUsed(includeFormats));
    }
  }
}

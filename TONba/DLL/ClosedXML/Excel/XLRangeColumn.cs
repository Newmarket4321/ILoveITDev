// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLRangeColumn
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace ClosedXML.Excel
{
  internal class XLRangeColumn : XLRangeBase, IXLRangeColumn, IXLRangeBase, IDisposable
  {
    public XLRangeColumn(XLRangeParameters rangeParameters, bool quickLoad)
      : base(rangeParameters.RangeAddress)
    {
      if (quickLoad)
        return;
      this.SubscribeToShiftedRows((Action<XLRange, int>) ((range, rowsShifted) => this.WorksheetRangeShiftedRows(range, rowsShifted)));
      this.SubscribeToShiftedColumns((Action<XLRange, int>) ((range, columnsShifted) => this.WorksheetRangeShiftedColumns(range, columnsShifted)));
      this.SetStyle(rangeParameters.DefaultStyle);
    }

    IXLCell IXLRangeColumn.Cell(int row)
    {
      return (IXLCell) this.Cell(row);
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

    public IXLCells Cells(int firstRow, int lastRow)
    {
      return this.Cells(firstRow.ToString() + ":" + (object) lastRow);
    }

    public void Delete()
    {
      this.Delete(XLShiftDeletedCells.ShiftCellsLeft);
    }

    public IXLCells InsertCellsAbove(int numberOfRows)
    {
      return this.InsertCellsAbove(numberOfRows, false);
    }

    public IXLCells InsertCellsAbove(int numberOfRows, bool expandRange)
    {
      return this.InsertRowsAbove(numberOfRows, expandRange).Cells();
    }

    public IXLCells InsertCellsBelow(int numberOfRows)
    {
      return this.InsertCellsBelow(numberOfRows, true);
    }

    public IXLCells InsertCellsBelow(int numberOfRows, bool expandRange)
    {
      return this.InsertRowsBelow(numberOfRows, expandRange).Cells();
    }

    public int CellCount()
    {
      return this.RangeAddress.LastAddress.RowNumber - this.RangeAddress.FirstAddress.RowNumber + 1;
    }

    public IXLRangeColumn Sort(XLSortOrder sortOrder = XLSortOrder.Ascending, bool matchCase = false, bool ignoreBlanks = true)
    {
      this.Sort(1, sortOrder, matchCase, ignoreBlanks);
      return (IXLRangeColumn) this;
    }

    public IXLRangeColumn CopyTo(IXLCell target)
    {
      base.CopyTo(target);
      int lastCellRow = target.Address.RowNumber + this.RowCount() - 1;
      if (lastCellRow > 1048576)
        lastCellRow = 1048576;
      int lastCellColumn = target.Address.ColumnNumber + this.ColumnCount() - 1;
      if (lastCellColumn > 16384)
        lastCellColumn = 16384;
      return target.Worksheet.Range(target.Address.RowNumber, target.Address.ColumnNumber, lastCellRow, lastCellColumn).Column(1);
    }

    public IXLRangeColumn CopyTo(IXLRangeBase target)
    {
      base.CopyTo(target);
      int lastCellRow = target.RangeAddress.FirstAddress.RowNumber + this.RowCount() - 1;
      if (lastCellRow > 1048576)
        lastCellRow = 1048576;
      int lastCellColumn = target.RangeAddress.FirstAddress.ColumnNumber + this.ColumnCount() - 1;
      if (lastCellColumn > 16384)
        lastCellColumn = 16384;
      return target.Worksheet.Range(target.RangeAddress.FirstAddress.RowNumber, target.RangeAddress.FirstAddress.ColumnNumber, lastCellRow, lastCellColumn).Column(1);
    }

    public IXLRangeColumn Column(int start, int end)
    {
      return (IXLRangeColumn) this.Range(start, end).FirstColumn((Func<IXLRangeColumn, bool>) null);
    }

    public IXLRangeColumn Column(IXLCell start, IXLCell end)
    {
      return this.Column(start.Address.RowNumber, end.Address.RowNumber);
    }

    public IXLRangeColumns Columns(string columns)
    {
      XLRangeColumns xlRangeColumns = new XLRangeColumns();
      foreach (string source in ((IEnumerable<string>) columns.Split(',')).Select<string, string>((Func<string, string>) (pair => pair.Trim())))
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
        xlRangeColumns.Add((IXLRangeColumn) this.Range(firstCellAddress, lastCellAddress).FirstColumn((Func<IXLRangeColumn, bool>) null));
      }
      return (IXLRangeColumns) xlRangeColumns;
    }

    public IXLRangeColumn SetDataType(XLCellValues dataType)
    {
      this.DataType = dataType;
      return (IXLRangeColumn) this;
    }

    public IXLColumn WorksheetColumn()
    {
      return (IXLColumn) this.Worksheet.Column(this.RangeAddress.FirstAddress.ColumnNumber);
    }

    public XLCell Cell(int row)
    {
      return this.Cell(row, 1);
    }

    private void WorksheetRangeShiftedColumns(XLRange range, int columnsShifted)
    {
      this.ShiftColumns((IXLRangeAddress) this.RangeAddress, range, columnsShifted);
    }

    private void WorksheetRangeShiftedRows(XLRange range, int rowsShifted)
    {
      this.ShiftRows((IXLRangeAddress) this.RangeAddress, range, rowsShifted);
    }

    public XLRange Range(int firstRow, int lastRow)
    {
      return this.Range(firstRow, 1, lastRow, 1);
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

    public int CompareTo(XLRangeColumn otherColumn, IXLSortElements rowsToSort)
    {
      foreach (IXLSortElement xlSortElement in (IEnumerable<IXLSortElement>) rowsToSort)
      {
        XLCell xlCell1 = this.Cell(xlSortElement.ElementNumber);
        XLCell xlCell2 = otherColumn.Cell(xlSortElement.ElementNumber);
        bool flag1 = xlCell1.IsEmpty();
        bool flag2 = xlCell2.IsEmpty();
        int num = !xlSortElement.IgnoreBlanks || !flag1 && !flag2 ? (xlCell1.DataType != xlCell2.DataType ? (!xlSortElement.MatchCase ? xlCell1.GetString().CompareTo(xlCell2.GetString()) : string.Compare(xlCell1.GetString(), xlCell2.GetString(), true)) : (xlCell1.DataType != XLCellValues.Text ? (xlCell1.DataType != XLCellValues.TimeSpan ? double.Parse(xlCell1.InnerText).CompareTo(double.Parse(xlCell2.InnerText)) : xlCell1.GetTimeSpan().CompareTo(xlCell2.GetTimeSpan())) : (xlSortElement.MatchCase ? xlCell1.InnerText.CompareTo(xlCell2.InnerText) : string.Compare(xlCell1.InnerText, xlCell2.InnerText, true)))) : (!flag1 || !flag2 ? (!flag1 ? (xlSortElement.SortOrder == XLSortOrder.Ascending ? -1 : 1) : (xlSortElement.SortOrder == XLSortOrder.Ascending ? 1 : -1)) : 0);
        if (num != 0)
          return xlSortElement.SortOrder == XLSortOrder.Ascending ? num : num * -1;
      }
      return 0;
    }

    private XLRangeColumn ColumnShift(int columnsToShift)
    {
      int num = this.ColumnNumber() + columnsToShift;
      return this.Worksheet.Range(this.RangeAddress.FirstAddress.RowNumber, num, this.RangeAddress.LastAddress.RowNumber, num).FirstColumn((Func<IXLRangeColumn, bool>) null);
    }

    IXLRangeColumn IXLRangeColumn.ColumnLeft()
    {
      return (IXLRangeColumn) this.ColumnLeft();
    }

    IXLRangeColumn IXLRangeColumn.ColumnLeft(int step)
    {
      return (IXLRangeColumn) this.ColumnLeft(step);
    }

    public XLRangeColumn ColumnLeft()
    {
      return this.ColumnLeft(1);
    }

    public XLRangeColumn ColumnLeft(int step)
    {
      return this.ColumnShift(step * -1);
    }

    IXLRangeColumn IXLRangeColumn.ColumnRight()
    {
      return (IXLRangeColumn) this.ColumnRight();
    }

    IXLRangeColumn IXLRangeColumn.ColumnRight(int step)
    {
      return (IXLRangeColumn) this.ColumnRight(step);
    }

    public XLRangeColumn ColumnRight()
    {
      return this.ColumnRight(1);
    }

    public XLRangeColumn ColumnRight(int step)
    {
      return this.ColumnShift(step);
    }

    public IXLTable AsTable()
    {
      using (XLRange xlRange = this.AsRange())
        return xlRange.AsTable();
    }

    public IXLTable AsTable(string name)
    {
      using (XLRange xlRange = this.AsRange())
        return xlRange.AsTable(name);
    }

    public IXLTable CreateTable()
    {
      using (XLRange xlRange = this.AsRange())
        return (IXLTable) xlRange.CreateTable();
    }

    public IXLTable CreateTable(string name)
    {
      using (XLRange xlRange = this.AsRange())
        return (IXLTable) xlRange.CreateTable(name);
    }

    public IXLRangeColumn Clear(XLClearOptions clearOptions = XLClearOptions.ContentsAndFormats)
    {
      base.Clear(clearOptions);
      return (IXLRangeColumn) this;
    }

    public IXLRangeColumn ColumnUsed(bool includeFormats = false)
    {
      return this.Column((IXLCell) this.FirstCellUsed(includeFormats), (IXLCell) this.LastCellUsed(includeFormats));
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLCellsCollection
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace ClosedXML.Excel
{
  internal class XLCellsCollection
  {
    private readonly Dictionary<int, Dictionary<int, XLCell>> rowsCollection = new Dictionary<int, Dictionary<int, XLCell>>();
    public readonly Dictionary<int, int> ColumnsUsed = new Dictionary<int, int>();
    public readonly Dictionary<int, HashSet<int>> deleted = new Dictionary<int, HashSet<int>>();
    public Dictionary<int, int> RowsUsed = new Dictionary<int, int>();
    public int MaxColumnUsed;
    public int MaxRowUsed;

    internal Dictionary<int, Dictionary<int, XLCell>> RowsCollection
    {
      get
      {
        return this.rowsCollection;
      }
    }

    public XLCellsCollection()
    {
      this.Clear();
    }

    public int Count { get; private set; }

    public void Add(XLSheetPoint sheetPoint, XLCell cell)
    {
      this.Add(sheetPoint.Row, sheetPoint.Column, cell);
    }

    public void Add(int row, int column, XLCell cell)
    {
      ++this.Count;
      XLCellsCollection.IncrementUsage(this.RowsUsed, row);
      XLCellsCollection.IncrementUsage(this.ColumnsUsed, column);
      Dictionary<int, XLCell> dictionary;
      if (!this.rowsCollection.TryGetValue(row, out dictionary))
      {
        dictionary = new Dictionary<int, XLCell>();
        this.rowsCollection.Add(row, dictionary);
      }
      dictionary.Add(column, cell);
      if (row > this.MaxRowUsed)
        this.MaxRowUsed = row;
      if (column > this.MaxColumnUsed)
        this.MaxColumnUsed = column;
      HashSet<int> intSet;
      if (!this.deleted.TryGetValue(row, out intSet))
        return;
      intSet.Remove(column);
    }

    private static void IncrementUsage(Dictionary<int, int> dictionary, int key)
    {
      if (dictionary.ContainsKey(key))
      {
        Dictionary<int, int> dictionary1;
        int index;
        (dictionary1 = dictionary)[index = key] = dictionary1[index] + 1;
      }
      else
        dictionary.Add(key, 1);
    }

    private static void DecrementUsage(Dictionary<int, int> dictionary, int key)
    {
      int num;
      if (!dictionary.TryGetValue(key, out num))
        return;
      if (num > 0)
      {
        Dictionary<int, int> dictionary1;
        int index;
        (dictionary1 = dictionary)[index = key] = dictionary1[index] - 1;
      }
      else
        dictionary.Remove(key);
    }

    public void Clear()
    {
      this.Count = 0;
      this.RowsUsed.Clear();
      this.ColumnsUsed.Clear();
      this.rowsCollection.Clear();
      this.MaxRowUsed = 0;
      this.MaxColumnUsed = 0;
    }

    public void Remove(XLSheetPoint sheetPoint)
    {
      this.Remove(sheetPoint.Row, sheetPoint.Column);
    }

    public void Remove(int row, int column)
    {
      --this.Count;
      XLCellsCollection.DecrementUsage(this.RowsUsed, row);
      XLCellsCollection.DecrementUsage(this.ColumnsUsed, row);
      HashSet<int> intSet;
      if (this.deleted.TryGetValue(row, out intSet))
      {
        if (!intSet.Contains(column))
          intSet.Add(column);
      }
      else
        this.deleted.Add(row, new HashSet<int>() { column });
      Dictionary<int, XLCell> dictionary;
      if (!this.rowsCollection.TryGetValue(row, out dictionary))
        return;
      dictionary.Remove(column);
      if (dictionary.Count != 0)
        return;
      this.rowsCollection.Remove(row);
    }

    internal IEnumerable<XLCell> GetCells(int rowStart, int columnStart, int rowEnd, int columnEnd, Func<IXLCell, bool> predicate = null)
    {
      int finalRow = rowEnd > this.MaxRowUsed ? this.MaxRowUsed : rowEnd;
      int finalColumn = columnEnd > this.MaxColumnUsed ? this.MaxColumnUsed : columnEnd;
      for (int ro = rowStart; ro <= finalRow; ++ro)
      {
        Dictionary<int, XLCell> columnsCollection;
        if (this.rowsCollection.TryGetValue(ro, out columnsCollection))
        {
          for (int co = columnStart; co <= finalColumn; ++co)
          {
            XLCell cell;
            if (columnsCollection.TryGetValue(co, out cell) && (predicate == null || predicate((IXLCell) cell)))
              yield return cell;
          }
        }
      }
    }

    internal HashSet<int> GetStyleIds(int initial)
    {
      HashSet<int> intSet = new HashSet<int>();
      intSet.Add(initial);
      foreach (KeyValuePair<int, Dictionary<int, XLCell>> rows in this.rowsCollection)
      {
        foreach (KeyValuePair<int, XLCell> keyValuePair in rows.Value)
        {
          int styleId = keyValuePair.Value.GetStyleId();
          if (!intSet.Contains(styleId))
            intSet.Add(styleId);
        }
      }
      return intSet;
    }

    internal IEnumerable<XLCell> GetCellsUsed(int rowStart, int columnStart, int rowEnd, int columnEnd, bool includeFormats, Func<IXLCell, bool> predicate = null)
    {
      int finalRow = rowEnd > this.MaxRowUsed ? this.MaxRowUsed : rowEnd;
      int finalColumn = columnEnd > this.MaxColumnUsed ? this.MaxColumnUsed : columnEnd;
      for (int ro = rowStart; ro <= finalRow; ++ro)
      {
        Dictionary<int, XLCell> columnsCollection;
        if (this.rowsCollection.TryGetValue(ro, out columnsCollection))
        {
          for (int co = columnStart; co <= finalColumn; ++co)
          {
            XLCell cell;
            if (columnsCollection.TryGetValue(co, out cell) && !cell.IsEmpty(includeFormats) && (predicate == null || predicate((IXLCell) cell)))
              yield return cell;
          }
        }
      }
    }

    public XLSheetPoint FirstPointUsed(int rowStart, int columnStart, int rowEnd, int columnEnd, bool includeFormats = false, Func<IXLCell, bool> predicate = null)
    {
      int rowEnd1 = rowEnd > this.MaxRowUsed ? this.MaxRowUsed : rowEnd;
      int columnEnd1 = columnEnd > this.MaxColumnUsed ? this.MaxColumnUsed : columnEnd;
      int row = this.FirstRowUsed(rowStart, columnStart, rowEnd1, columnEnd1, includeFormats, predicate);
      if (row == 0)
        return new XLSheetPoint(0, 0);
      int column = this.FirstColumnUsed(rowStart, columnStart, rowEnd1, columnEnd1, includeFormats, predicate);
      if (column == 0)
        return new XLSheetPoint(0, 0);
      return new XLSheetPoint(row, column);
    }

    public XLSheetPoint LastPointUsed(int rowStart, int columnStart, int rowEnd, int columnEnd, bool includeFormats = false, Func<IXLCell, bool> predicate = null)
    {
      int rowEnd1 = rowEnd > this.MaxRowUsed ? this.MaxRowUsed : rowEnd;
      int columnEnd1 = columnEnd > this.MaxColumnUsed ? this.MaxColumnUsed : columnEnd;
      int row = this.LastRowUsed(rowStart, columnStart, rowEnd1, columnEnd1, includeFormats, predicate);
      if (row == 0)
        return new XLSheetPoint(0, 0);
      int column = this.LastColumnUsed(rowStart, columnStart, rowEnd1, columnEnd1, includeFormats, predicate);
      if (column == 0)
        return new XLSheetPoint(0, 0);
      return new XLSheetPoint(row, column);
    }

    public int FirstRowUsed(int rowStart, int columnStart, int rowEnd, int columnEnd, bool includeFormats, Func<IXLCell, bool> predicate = null)
    {
      int num1 = rowEnd > this.MaxRowUsed ? this.MaxRowUsed : rowEnd;
      int num2 = columnEnd > this.MaxColumnUsed ? this.MaxColumnUsed : columnEnd;
      for (int key1 = rowStart; key1 <= num1; ++key1)
      {
        Dictionary<int, XLCell> dictionary;
        if (this.rowsCollection.TryGetValue(key1, out dictionary))
        {
          for (int key2 = columnStart; key2 <= num2; ++key2)
          {
            XLCell xlCell;
            if (dictionary.TryGetValue(key2, out xlCell) && !xlCell.IsEmpty(includeFormats) && (predicate == null || predicate((IXLCell) xlCell)))
              return key1;
          }
        }
      }
      return 0;
    }

    public int FirstColumnUsed(int rowStart, int columnStart, int rowEnd, int columnEnd, bool includeFormats, Func<IXLCell, bool> predicate = null)
    {
      int num1 = rowEnd > this.MaxRowUsed ? this.MaxRowUsed : rowEnd;
      int num2 = columnEnd > this.MaxColumnUsed ? this.MaxColumnUsed : columnEnd;
      for (int key1 = rowStart; key1 <= num1; ++key1)
      {
        Dictionary<int, XLCell> dictionary;
        if (this.rowsCollection.TryGetValue(key1, out dictionary))
        {
          for (int key2 = columnStart; key2 <= num2; ++key2)
          {
            XLCell xlCell;
            if (dictionary.TryGetValue(key2, out xlCell) && !xlCell.IsEmpty(includeFormats) && (predicate == null || predicate((IXLCell) xlCell)))
              return key2;
          }
        }
      }
      return 0;
    }

    public int LastRowUsed(int rowStart, int columnStart, int rowEnd, int columnEnd, bool includeFormats, Func<IXLCell, bool> predicate = null)
    {
      int num1 = rowEnd > this.MaxRowUsed ? this.MaxRowUsed : rowEnd;
      int num2 = columnEnd > this.MaxColumnUsed ? this.MaxColumnUsed : columnEnd;
      for (int key1 = num1; key1 >= rowStart; --key1)
      {
        Dictionary<int, XLCell> dictionary;
        if (this.rowsCollection.TryGetValue(key1, out dictionary))
        {
          for (int key2 = num2; key2 >= columnStart; --key2)
          {
            XLCell xlCell;
            if (dictionary.TryGetValue(key2, out xlCell) && !xlCell.IsEmpty(includeFormats) && (predicate == null || predicate((IXLCell) xlCell)))
              return key1;
          }
        }
      }
      return 0;
    }

    public int LastColumnUsed(int rowStart, int columnStart, int rowEnd, int columnEnd, bool includeFormats, Func<IXLCell, bool> predicate = null)
    {
      int num1 = 0;
      int num2 = rowEnd > this.MaxRowUsed ? this.MaxRowUsed : rowEnd;
      int num3 = columnEnd > this.MaxColumnUsed ? this.MaxColumnUsed : columnEnd;
      for (int key1 = num2; key1 >= rowStart; --key1)
      {
        Dictionary<int, XLCell> dictionary;
        if (this.rowsCollection.TryGetValue(key1, out dictionary))
        {
          for (int key2 = num3; key2 >= columnStart && key2 > num1; --key2)
          {
            XLCell xlCell;
            if (dictionary.TryGetValue(key2, out xlCell) && !xlCell.IsEmpty(includeFormats) && (predicate == null || predicate((IXLCell) xlCell)))
              num1 = key2;
          }
        }
      }
      return num1;
    }

    public void RemoveAll(int rowStart, int columnStart, int rowEnd, int columnEnd)
    {
      int num1 = rowEnd > this.MaxRowUsed ? this.MaxRowUsed : rowEnd;
      int num2 = columnEnd > this.MaxColumnUsed ? this.MaxColumnUsed : columnEnd;
      for (int index1 = rowStart; index1 <= num1; ++index1)
      {
        Dictionary<int, XLCell> dictionary;
        if (this.rowsCollection.TryGetValue(index1, out dictionary))
        {
          for (int index2 = columnStart; index2 <= num2; ++index2)
          {
            if (dictionary.ContainsKey(index2))
              this.Remove(index1, index2);
          }
        }
      }
    }

    public IEnumerable<XLSheetPoint> GetSheetPoints(int rowStart, int columnStart, int rowEnd, int columnEnd)
    {
      int finalRow = rowEnd > this.MaxRowUsed ? this.MaxRowUsed : rowEnd;
      int finalColumn = columnEnd > this.MaxColumnUsed ? this.MaxColumnUsed : columnEnd;
      for (int ro = rowStart; ro <= finalRow; ++ro)
      {
        Dictionary<int, XLCell> columnsCollection;
        if (this.rowsCollection.TryGetValue(ro, out columnsCollection))
        {
          for (int co = columnStart; co <= finalColumn; ++co)
          {
            if (columnsCollection.ContainsKey(co))
              yield return new XLSheetPoint(ro, co);
          }
        }
      }
    }

    public XLCell GetCell(int row, int column)
    {
      if (row > this.MaxRowUsed || column > this.MaxColumnUsed)
        return (XLCell) null;
      Dictionary<int, XLCell> dictionary;
      if (!this.rowsCollection.TryGetValue(row, out dictionary))
        return (XLCell) null;
      XLCell xlCell;
      if (!dictionary.TryGetValue(column, out xlCell))
        return (XLCell) null;
      return xlCell;
    }

    public XLCell GetCell(XLSheetPoint sp)
    {
      return this.GetCell(sp.Row, sp.Column);
    }

    internal void SwapRanges(XLSheetRange sheetRange1, XLSheetRange sheetRange2, XLWorksheet worksheet)
    {
      int num1 = sheetRange1.LastPoint.Row - sheetRange1.FirstPoint.Row + 1;
      int num2 = sheetRange1.LastPoint.Column - sheetRange1.FirstPoint.Column + 1;
      for (int index1 = 0; index1 < num1; ++index1)
      {
        for (int index2 = 0; index2 < num2; ++index2)
        {
          XLSheetPoint xlSheetPoint1 = new XLSheetPoint(sheetRange1.FirstPoint.Row + index1, sheetRange1.FirstPoint.Column + index2);
          XLSheetPoint xlSheetPoint2 = new XLSheetPoint(sheetRange2.FirstPoint.Row + index1, sheetRange2.FirstPoint.Column + index2);
          XLCell cell1 = this.GetCell(xlSheetPoint1);
          XLCell cell2 = this.GetCell(xlSheetPoint2);
          if (cell1 == null)
            cell1 = worksheet.Cell(xlSheetPoint1.Row, xlSheetPoint1.Column);
          if (cell2 == null)
            cell2 = worksheet.Cell(xlSheetPoint2.Row, xlSheetPoint2.Column);
          cell1.Address = new XLAddress(cell1.Worksheet, xlSheetPoint2.Row, xlSheetPoint2.Column, false, false);
          this.Remove(xlSheetPoint1);
          this.Add(xlSheetPoint1, cell2);
          cell2.Address = new XLAddress(cell2.Worksheet, xlSheetPoint1.Row, xlSheetPoint1.Column, false, false);
          this.Remove(xlSheetPoint2);
          this.Add(xlSheetPoint2, cell1);
        }
      }
    }

    internal IEnumerable<XLCell> GetCells()
    {
      return this.GetCells(1, 1, this.MaxRowUsed, this.MaxColumnUsed, (Func<IXLCell, bool>) null);
    }

    internal IEnumerable<XLCell> GetCells(Func<IXLCell, bool> predicate)
    {
      for (int ro = 1; ro <= this.MaxRowUsed; ++ro)
      {
        Dictionary<int, XLCell> columnsCollection;
        if (this.rowsCollection.TryGetValue(ro, out columnsCollection))
        {
          for (int co = 1; co <= this.MaxColumnUsed; ++co)
          {
            XLCell cell;
            if (columnsCollection.TryGetValue(co, out cell) && (predicate == null || predicate((IXLCell) cell)))
              yield return cell;
          }
        }
      }
    }

    public bool Contains(int row, int column)
    {
      Dictionary<int, XLCell> dictionary;
      if (this.rowsCollection.TryGetValue(row, out dictionary))
        return dictionary.ContainsKey(column);
      return false;
    }

    public int MinRowInColumn(int column)
    {
      for (int key = 1; key <= this.MaxRowUsed; ++key)
      {
        Dictionary<int, XLCell> dictionary;
        if (this.rowsCollection.TryGetValue(key, out dictionary) && dictionary.ContainsKey(column))
          return key;
      }
      return 0;
    }

    public int MaxRowInColumn(int column)
    {
      for (int maxRowUsed = this.MaxRowUsed; maxRowUsed >= 1; --maxRowUsed)
      {
        Dictionary<int, XLCell> dictionary;
        if (this.rowsCollection.TryGetValue(maxRowUsed, out dictionary) && dictionary.ContainsKey(column))
          return maxRowUsed;
      }
      return 0;
    }

    public int MinColumnInRow(int row)
    {
      Dictionary<int, XLCell> dictionary;
      if (this.rowsCollection.TryGetValue(row, out dictionary) && dictionary.Count > 0)
        return dictionary.Keys.Min();
      return 0;
    }

    public int MaxColumnInRow(int row)
    {
      Dictionary<int, XLCell> dictionary;
      if (this.rowsCollection.TryGetValue(row, out dictionary) && dictionary.Count > 0)
        return dictionary.Keys.Max();
      return 0;
    }

    public IEnumerable<XLCell> GetCellsInColumn(int column)
    {
      return this.GetCells(1, column, this.MaxRowUsed, column, (Func<IXLCell, bool>) null);
    }

    public IEnumerable<XLCell> GetCellsInRow(int row)
    {
      return this.GetCells(row, 1, row, this.MaxColumnUsed, (Func<IXLCell, bool>) null);
    }
  }
}

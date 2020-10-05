// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLTable
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClosedXML.Excel
{
  internal class XLTable : XLRange, IXLTable, IXLRange, IXLRangeBase, IDisposable
  {
    private string _name;
    internal bool _showTotalsRow;
    internal HashSet<string> _uniqueNames;
    private IXLRangeAddress _lastRangeAddress;
    private Dictionary<string, IXLTableField> _fieldNames;
    private XLAutoFilter _autoFilter;
    private bool _showAutoFilter;
    internal bool _showHeaderRow;

    public XLTable(XLRange range, bool addToTables, bool setAutofilter = true)
      : base(new XLRangeParameters(range.RangeAddress, range.Style))
    {
      this.InitializeValues(setAutofilter);
      int num = 1;
      string tableName;
      while (true)
      {
        tableName = string.Format("Table{0}", (object) num);
        if (this.Worksheet.Tables.Any<IXLTable>((Func<IXLTable, bool>) (t => t.Name == tableName)))
          ++num;
        else
          break;
      }
      this.Name = tableName;
      this.AddToTables(range, addToTables);
    }

    public XLTable(XLRange range, string name, bool addToTables, bool setAutofilter = true)
      : base(new XLRangeParameters(range.RangeAddress, range.Style))
    {
      this.InitializeValues(setAutofilter);
      this.Name = name;
      this.AddToTables(range, addToTables);
    }

    public Dictionary<string, IXLTableField> FieldNames
    {
      get
      {
        if (this._fieldNames != null && this._lastRangeAddress != null && this._lastRangeAddress.Equals((object) this.RangeAddress))
          return this._fieldNames;
        this._fieldNames = new Dictionary<string, IXLTableField>();
        this._lastRangeAddress = (IXLRangeAddress) this.RangeAddress;
        if (this.ShowHeaderRow)
        {
          IXLRangeRow xlRangeRow = this.HeadersRow();
          int num = 0;
          foreach (IXLCell cell in (IEnumerable<IXLCell>) xlRangeRow.Cells())
          {
            string key = cell.GetString();
            if (XLHelper.IsNullOrWhiteSpace(key))
            {
              key = "Column" + (object) (num + 1);
              cell.SetValue<string>(key);
            }
            if (this._fieldNames.ContainsKey(key))
              throw new ArgumentException("The header row contains more than one field name '" + key + "'.");
            this._fieldNames.Add(key, (IXLTableField) new XLTableField(this)
            {
              Index = num++
            });
          }
        }
        else
        {
          if (this._fieldNames == null)
            this._fieldNames = new Dictionary<string, IXLTableField>();
          int num = this.ColumnCount();
          for (int i = 1; i <= num; ++i)
          {
            if (!this._fieldNames.Values.Any<IXLTableField>((Func<IXLTableField, bool>) (f => f.Index == i - 1)))
              this._fieldNames.Add("Column" + (object) i, (IXLTableField) new XLTableField(this)
              {
                Index = (i - 1)
              });
          }
        }
        return this._fieldNames;
      }
    }

    internal void AddFields(IEnumerable<string> fieldNames)
    {
      this._fieldNames = new Dictionary<string, IXLTableField>();
      int num = 0;
      foreach (string fieldName in fieldNames)
        this._fieldNames.Add(fieldName, (IXLTableField) new XLTableField(this)
        {
          Index = num++,
          Name = fieldName
        });
    }

    public string RelId { get; set; }

    public IXLTableRange DataRange
    {
      get
      {
        return (IXLTableRange) new XLTableRange(!this._showHeaderRow ? (this._showTotalsRow ? this.Range(1, 1, this.RowCount() - 1, this.ColumnCount()) : this.Range(1, 1, this.RowCount(), this.ColumnCount())) : (this._showTotalsRow ? this.Range(2, 1, this.RowCount() - 1, this.ColumnCount()) : this.Range(2, 1, this.RowCount(), this.ColumnCount())), this);
      }
    }

    public XLAutoFilter AutoFilter
    {
      get
      {
        using (XLRange xlRange = this.ShowTotalsRow ? this.Range(1, 1, this.RowCount() - 1, this.ColumnCount()) : this.AsRange())
        {
          if (this._autoFilter == null)
            this._autoFilter = new XLAutoFilter();
          this._autoFilter.Range = (IXLRange) xlRange;
        }
        return this._autoFilter;
      }
    }

    public IXLBaseAutoFilter SetAutoFilter()
    {
      return (IXLBaseAutoFilter) this.AutoFilter;
    }

    public bool EmphasizeFirstColumn { get; set; }

    public bool EmphasizeLastColumn { get; set; }

    public bool ShowRowStripes { get; set; }

    public bool ShowColumnStripes { get; set; }

    public bool ShowAutoFilter
    {
      get
      {
        if (this._showHeaderRow)
          return this._showAutoFilter;
        return false;
      }
      set
      {
        this._showAutoFilter = value;
      }
    }

    public XLTableTheme Theme { get; set; }

    public string Name
    {
      get
      {
        return this._name;
      }
      set
      {
        if (this.Worksheet.Tables.Any<IXLTable>((Func<IXLTable, bool>) (t => t.Name == value)))
          throw new ArgumentException(string.Format("This worksheet already contains a table named '{0}'", (object) value));
        this._name = value;
      }
    }

    public bool ShowTotalsRow
    {
      get
      {
        return this._showTotalsRow;
      }
      set
      {
        if (value && !this._showTotalsRow)
          this.InsertRowsBelow(1);
        else if (!value && this._showTotalsRow)
          this.TotalsRow().Delete();
        this._showTotalsRow = value;
        if (this._showTotalsRow)
          this.AutoFilter.Range = (IXLRange) this.Worksheet.Range(this.RangeAddress.FirstAddress.RowNumber, this.RangeAddress.FirstAddress.ColumnNumber, this.RangeAddress.LastAddress.RowNumber - 1, this.RangeAddress.LastAddress.ColumnNumber);
        else
          this.AutoFilter.Range = (IXLRange) this.Worksheet.Range((IXLRangeAddress) this.RangeAddress);
      }
    }

    public IXLRangeRow HeadersRow()
    {
      if (!this.ShowHeaderRow)
        return (IXLRangeRow) null;
      Dictionary<string, IXLTableField> fieldNames = this.FieldNames;
      return (IXLRangeRow) this.FirstRow((Func<IXLRangeRow, bool>) null);
    }

    public IXLRangeRow TotalsRow()
    {
      if (!this.ShowTotalsRow)
        return (IXLRangeRow) null;
      return (IXLRangeRow) this.LastRow((Func<IXLRangeRow, bool>) null);
    }

    public IXLTableField Field(string fieldName)
    {
      return this.Field(this.GetFieldIndex(fieldName));
    }

    public IXLTableField Field(int fieldIndex)
    {
      return this.FieldNames.Values.First<IXLTableField>((Func<IXLTableField, bool>) (f => f.Index == fieldIndex));
    }

    public IEnumerable<IXLTableField> Fields
    {
      get
      {
        int columnCount = this.ColumnCount();
        for (int co = 0; co < columnCount; ++co)
          yield return this.Field(co);
      }
    }

    public IXLTable SetEmphasizeFirstColumn()
    {
      this.EmphasizeFirstColumn = true;
      return (IXLTable) this;
    }

    public IXLTable SetEmphasizeFirstColumn(bool value)
    {
      this.EmphasizeFirstColumn = value;
      return (IXLTable) this;
    }

    public IXLTable SetEmphasizeLastColumn()
    {
      this.EmphasizeLastColumn = true;
      return (IXLTable) this;
    }

    public IXLTable SetEmphasizeLastColumn(bool value)
    {
      this.EmphasizeLastColumn = value;
      return (IXLTable) this;
    }

    public IXLTable SetShowRowStripes()
    {
      this.ShowRowStripes = true;
      return (IXLTable) this;
    }

    public IXLTable SetShowRowStripes(bool value)
    {
      this.ShowRowStripes = value;
      return (IXLTable) this;
    }

    public IXLTable SetShowColumnStripes()
    {
      this.ShowColumnStripes = true;
      return (IXLTable) this;
    }

    public IXLTable SetShowColumnStripes(bool value)
    {
      this.ShowColumnStripes = value;
      return (IXLTable) this;
    }

    public IXLTable SetShowTotalsRow()
    {
      this.ShowTotalsRow = true;
      return (IXLTable) this;
    }

    public IXLTable SetShowTotalsRow(bool value)
    {
      this.ShowTotalsRow = value;
      return (IXLTable) this;
    }

    public IXLTable SetShowAutoFilter()
    {
      this.ShowAutoFilter = true;
      return (IXLTable) this;
    }

    public IXLTable SetShowAutoFilter(bool value)
    {
      this.ShowAutoFilter = value;
      return (IXLTable) this;
    }

    public new IXLRange Sort(string columnsToSortBy, XLSortOrder sortOrder = XLSortOrder.Ascending, bool matchCase = false, bool ignoreBlanks = true)
    {
      StringBuilder stringBuilder = new StringBuilder();
      foreach (string source in ((IEnumerable<string>) columnsToSortBy.Split(',')).Select<string, string>((Func<string, string>) (coPair => coPair.Trim())))
      {
        string str1;
        string str2;
        if (source.Contains<char>(' '))
        {
          string[] strArray = source.Split(' ');
          str1 = strArray[0];
          str2 = strArray[1];
        }
        else
        {
          str1 = source;
          str2 = "ASC";
        }
        int result;
        if (!int.TryParse(str1, out result))
          result = this.Field(str1).Index + 1;
        stringBuilder.Append(result);
        stringBuilder.Append(" ");
        stringBuilder.Append(str2);
        stringBuilder.Append(",");
      }
      return this.DataRange.Sort(stringBuilder.ToString(0, stringBuilder.Length - 1), sortOrder, matchCase, ignoreBlanks);
    }

    public IXLTable Clear(XLClearOptions clearOptions = XLClearOptions.ContentsAndFormats)
    {
      base.Clear(clearOptions);
      return (IXLTable) this;
    }

    IXLBaseAutoFilter IXLTable.AutoFilter
    {
      get
      {
        return (IXLBaseAutoFilter) this.AutoFilter;
      }
    }

    public new void Dispose()
    {
      if (this.AutoFilter != null)
        this.AutoFilter.Dispose();
      base.Dispose();
    }

    private void InitializeValues(bool setAutofilter)
    {
      this.ShowRowStripes = true;
      this._showHeaderRow = true;
      this.Theme = XLTableTheme.TableStyleLight9;
      if (setAutofilter)
        this.InitializeAutoFilter();
      this.HeadersRow().DataType = XLCellValues.Text;
      if (this.RowCount() != 1)
        return;
      this.InsertRowsBelow(1);
    }

    public void InitializeAutoFilter()
    {
      this.ShowAutoFilter = true;
    }

    private void AddToTables(XLRange range, bool addToTables)
    {
      if (!addToTables)
        return;
      this._uniqueNames = new HashSet<string>();
      int num = 1;
      foreach (IXLCell cell in (IEnumerable<IXLCell>) range.Row(1).Cells())
      {
        if (XLHelper.IsNullOrWhiteSpace(((XLCell) cell).InnerText))
          cell.Value = (object) this.GetUniqueName("Column" + num.ToInvariantString());
        this._uniqueNames.Add(cell.GetString());
        ++num;
      }
      this.Worksheet.Tables.Add((IXLTable) this);
    }

    private string GetUniqueName(string originalName)
    {
      string str = originalName;
      if (this._uniqueNames.Contains(str))
      {
        int num = 1;
        for (str = originalName + num.ToInvariantString(); this._uniqueNames.Contains(str); str = originalName + num.ToInvariantString())
          ++num;
      }
      this._uniqueNames.Add(str);
      return str;
    }

    public int GetFieldIndex(string name)
    {
      if (this.FieldNames.ContainsKey(name))
        return this.FieldNames[name].Index;
      throw new ArgumentOutOfRangeException("The header row doesn't contain field name '" + name + "'.");
    }

    public bool ShowHeaderRow
    {
      get
      {
        return this._showHeaderRow;
      }
      set
      {
        if (this._showHeaderRow == value)
          return;
        if (this._showHeaderRow)
        {
          IXLRangeRow xlRangeRow = this.HeadersRow();
          this._uniqueNames = new HashSet<string>();
          int num = 1;
          foreach (IXLCell cell in (IEnumerable<IXLCell>) xlRangeRow.Cells())
          {
            if (XLHelper.IsNullOrWhiteSpace(((XLCell) cell).InnerText))
              cell.Value = (object) this.GetUniqueName("Column" + num.ToInvariantString());
            this._uniqueNames.Add(cell.GetString());
            ++num;
          }
          xlRangeRow.Clear(XLClearOptions.ContentsAndFormats);
          this.RangeAddress.FirstAddress = new XLAddress(this.Worksheet, this.RangeAddress.FirstAddress.RowNumber + 1, this.RangeAddress.FirstAddress.ColumnNumber, this.RangeAddress.FirstAddress.FixedRow, this.RangeAddress.FirstAddress.FixedColumn);
          this.HeadersRow().DataType = XLCellValues.Text;
        }
        else
        {
          using (XLRange xlRange = this.Worksheet.Range(this.RangeAddress.FirstAddress.RowNumber - 1, this.RangeAddress.FirstAddress.ColumnNumber, this.RangeAddress.LastAddress.RowNumber, this.RangeAddress.LastAddress.ColumnNumber))
          {
            using (XLRangeRow xlRangeRow1 = xlRange.FirstRow((Func<IXLRangeRow, bool>) null))
            {
              IXLRangeRow xlRangeRow2;
              if (xlRangeRow1.IsEmpty(true))
              {
                xlRangeRow2 = (IXLRangeRow) xlRangeRow1;
                this.RangeAddress.FirstAddress = new XLAddress(this.Worksheet, this.RangeAddress.FirstAddress.RowNumber - 1, this.RangeAddress.FirstAddress.ColumnNumber, this.RangeAddress.FirstAddress.FixedRow, this.RangeAddress.FirstAddress.FixedColumn);
              }
              else
              {
                XLAddress firstAddress = this.RangeAddress.FirstAddress;
                XLAddress lastAddress = this.RangeAddress.LastAddress;
                xlRangeRow2 = xlRangeRow1.InsertRowsBelow(1, false).First<IXLRangeRow>();
                this.RangeAddress.FirstAddress = new XLAddress(this.Worksheet, firstAddress.RowNumber, firstAddress.ColumnNumber, firstAddress.FixedRow, firstAddress.FixedColumn);
                this.RangeAddress.LastAddress = new XLAddress(this.Worksheet, lastAddress.RowNumber + 1, lastAddress.ColumnNumber, lastAddress.FixedRow, lastAddress.FixedColumn);
              }
              int columnNumber = 1;
              foreach (string key in this.FieldNames.Keys)
              {
                xlRangeRow2.Cell(columnNumber).SetValue<string>(key);
                ++columnNumber;
              }
            }
          }
        }
        this._showHeaderRow = value;
      }
    }

    public IXLTable SetShowHeaderRow()
    {
      return this.SetShowHeaderRow(true);
    }

    public IXLTable SetShowHeaderRow(bool value)
    {
      this.ShowHeaderRow = value;
      return (IXLTable) this;
    }

    public void ExpandTableRows(int rows)
    {
      this.RangeAddress.LastAddress = new XLAddress(this.Worksheet, this.RangeAddress.LastAddress.RowNumber + rows, this.RangeAddress.LastAddress.ColumnNumber, this.RangeAddress.LastAddress.FixedRow, this.RangeAddress.LastAddress.FixedColumn);
    }
  }
}

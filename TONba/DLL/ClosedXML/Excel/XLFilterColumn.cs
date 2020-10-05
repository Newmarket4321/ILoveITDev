// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLFilterColumn
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace ClosedXML.Excel
{
  internal class XLFilterColumn : IXLFilterColumn
  {
    private readonly XLAutoFilter _autoFilter;
    private readonly int _column;

    public XLFilterColumn(XLAutoFilter autoFilter, int column)
    {
      this._autoFilter = autoFilter;
      this._column = column;
    }

    public void Clear()
    {
      if (!this._autoFilter.Filters.ContainsKey(this._column))
        return;
      this._autoFilter.Filters.Remove(this._column);
    }

    public IXLFilteredColumn AddFilter<T>(T value) where T : IComparable<T>
    {
      if (typeof (T) == typeof (string))
        this.ApplyCustomFilter<T>(value, XLFilterOperator.Equal, (Func<object, bool>) (v => v.ToString().Equals(value.ToString(), StringComparison.InvariantCultureIgnoreCase)), XLFilterType.Regular);
      else
        this.ApplyCustomFilter<T>(value, XLFilterOperator.Equal, (Func<object, bool>) (v => v.CastTo<T>().CompareTo(value) == 0), XLFilterType.Regular);
      return (IXLFilteredColumn) new XLFilteredColumn(this._autoFilter, this._column);
    }

    public void Top(int value, XLTopBottomType type = XLTopBottomType.Items)
    {
      this._autoFilter.Column(this._column).TopBottomPart = XLTopBottomPart.Top;
      this.SetTopBottom(value, type, true);
    }

    public void Bottom(int value, XLTopBottomType type = XLTopBottomType.Items)
    {
      this._autoFilter.Column(this._column).TopBottomPart = XLTopBottomPart.Bottom;
      this.SetTopBottom(value, type, false);
    }

    public void AboveAverage()
    {
      this.ShowAverage(true);
    }

    public void BelowAverage()
    {
      this.ShowAverage(false);
    }

    public IXLFilterConnector EqualTo<T>(T value) where T : IComparable<T>
    {
      if (typeof (T) == typeof (string))
        return this.ApplyCustomFilter<T>(value, XLFilterOperator.Equal, (Func<object, bool>) (v => v.ToString().Equals(value.ToString(), StringComparison.InvariantCultureIgnoreCase)), XLFilterType.Custom);
      return this.ApplyCustomFilter<T>(value, XLFilterOperator.Equal, (Func<object, bool>) (v => v.CastTo<T>().CompareTo(value) == 0), XLFilterType.Custom);
    }

    public IXLFilterConnector NotEqualTo<T>(T value) where T : IComparable<T>
    {
      if (typeof (T) == typeof (string))
        return this.ApplyCustomFilter<T>(value, XLFilterOperator.NotEqual, (Func<object, bool>) (v => !v.ToString().Equals(value.ToString(), StringComparison.InvariantCultureIgnoreCase)), XLFilterType.Custom);
      return this.ApplyCustomFilter<T>(value, XLFilterOperator.NotEqual, (Func<object, bool>) (v => v.CastTo<T>().CompareTo(value) != 0), XLFilterType.Custom);
    }

    public IXLFilterConnector GreaterThan<T>(T value) where T : IComparable<T>
    {
      return this.ApplyCustomFilter<T>(value, XLFilterOperator.GreaterThan, (Func<object, bool>) (v => v.CastTo<T>().CompareTo(value) > 0), XLFilterType.Custom);
    }

    public IXLFilterConnector LessThan<T>(T value) where T : IComparable<T>
    {
      return this.ApplyCustomFilter<T>(value, XLFilterOperator.LessThan, (Func<object, bool>) (v => v.CastTo<T>().CompareTo(value) < 0), XLFilterType.Custom);
    }

    public IXLFilterConnector EqualOrGreaterThan<T>(T value) where T : IComparable<T>
    {
      return this.ApplyCustomFilter<T>(value, XLFilterOperator.EqualOrGreaterThan, (Func<object, bool>) (v => v.CastTo<T>().CompareTo(value) >= 0), XLFilterType.Custom);
    }

    public IXLFilterConnector EqualOrLessThan<T>(T value) where T : IComparable<T>
    {
      return this.ApplyCustomFilter<T>(value, XLFilterOperator.EqualOrLessThan, (Func<object, bool>) (v => v.CastTo<T>().CompareTo(value) <= 0), XLFilterType.Custom);
    }

    public void Between<T>(T minValue, T maxValue) where T : IComparable<T>
    {
      this.EqualOrGreaterThan<T>(minValue).And.EqualOrLessThan<T>(maxValue);
    }

    public void NotBetween<T>(T minValue, T maxValue) where T : IComparable<T>
    {
      this.LessThan<T>(minValue).Or.GreaterThan<T>(maxValue);
    }

    public IXLFilterConnector BeginsWith(string value)
    {
      return this.ApplyCustomFilter<string>(value + "*", XLFilterOperator.Equal, (Func<object, bool>) (s => ((string) s).StartsWith(value, StringComparison.InvariantCultureIgnoreCase)), XLFilterType.Custom);
    }

    public IXLFilterConnector NotBeginsWith(string value)
    {
      return this.ApplyCustomFilter<string>(value + "*", XLFilterOperator.NotEqual, (Func<object, bool>) (s => !((string) s).StartsWith(value, StringComparison.InvariantCultureIgnoreCase)), XLFilterType.Custom);
    }

    public IXLFilterConnector EndsWith(string value)
    {
      return this.ApplyCustomFilter<string>("*" + value, XLFilterOperator.Equal, (Func<object, bool>) (s => ((string) s).EndsWith(value, StringComparison.InvariantCultureIgnoreCase)), XLFilterType.Custom);
    }

    public IXLFilterConnector NotEndsWith(string value)
    {
      return this.ApplyCustomFilter<string>("*" + value, XLFilterOperator.NotEqual, (Func<object, bool>) (s => !((string) s).EndsWith(value, StringComparison.InvariantCultureIgnoreCase)), XLFilterType.Custom);
    }

    public IXLFilterConnector Contains(string value)
    {
      return this.ApplyCustomFilter<string>("*" + value + "*", XLFilterOperator.Equal, (Func<object, bool>) (s => ((string) s).ToLower().Contains(value.ToLower())), XLFilterType.Custom);
    }

    public IXLFilterConnector NotContains(string value)
    {
      return this.ApplyCustomFilter<string>("*" + value + "*", XLFilterOperator.Equal, (Func<object, bool>) (s => !((string) s).ToLower().Contains(value.ToLower())), XLFilterType.Custom);
    }

    public XLFilterType FilterType { get; set; }

    public int TopBottomValue { get; set; }

    public XLTopBottomType TopBottomType { get; set; }

    public XLTopBottomPart TopBottomPart { get; set; }

    public XLFilterDynamicType DynamicType { get; set; }

    public double DynamicValue { get; set; }

    private void SetTopBottom(int value, XLTopBottomType type, bool takeTop = true)
    {
      this._autoFilter.Enabled = true;
      this._autoFilter.Column(this._column).SetFilterType(XLFilterType.TopBottom).SetTopBottomValue(value).SetTopBottomType(type);
      IEnumerable<double> values = this.GetValues(value, type, takeTop);
      this.Clear();
      this._autoFilter.Filters.Add(this._column, new List<XLFilter>());
      bool flag1 = true;
      XLWorksheet worksheet = this._autoFilter.Range.Worksheet as XLWorksheet;
      worksheet.SuspendEvents();
      foreach (IXLRangeRow row in (IEnumerable<IXLRangeRow>) this._autoFilter.Range.Rows(2, this._autoFilter.Range.RowCount()))
      {
        bool flag2 = false;
        foreach (double num in values)
        {
          double val = num;
          Func<object, bool> func = (Func<object, bool>) (v => (v as IComparable).CompareTo((object) val) == 0);
          if (flag1)
            this._autoFilter.Filters[this._column].Add(new XLFilter(XLFilterOperator.Equal)
            {
              Value = (object) val,
              Operator = XLFilterOperator.Equal,
              Connector = XLConnector.Or,
              Condition = func
            });
          IXLCell xlCell = row.Cell(this._column);
          if (xlCell.DataType == XLCellValues.Number && func((object) xlCell.GetDouble()))
          {
            row.WorksheetRow().Unhide();
            flag2 = true;
          }
        }
        if (!flag2)
          row.WorksheetRow().Hide();
        flag1 = false;
      }
      worksheet.ResumeEvents();
    }

    private IEnumerable<double> GetValues(int value, XLTopBottomType type, bool takeTop)
    {
      using (IXLRangeColumn xlRangeColumn1 = this._autoFilter.Range.Column(this._column))
      {
        using (IXLRangeColumn xlRangeColumn2 = xlRangeColumn1.Column(2, xlRangeColumn1.CellCount()))
        {
          IXLCells source1 = xlRangeColumn2.CellsUsed((Func<IXLCell, bool>) (c => c.DataType == XLCellValues.Number));
          if (takeTop)
          {
            if (type == XLTopBottomType.Items)
              return source1.Select<IXLCell, double>((Func<IXLCell, double>) (c => c.GetDouble())).OrderByDescending<double, double>((Func<double, double>) (d => d)).Take<double>(value).Distinct<double>();
            IEnumerable<double> source2 = source1.Select<IXLCell, double>((Func<IXLCell, double>) (c => c.GetDouble()));
            int count = source2.Count<double>() * value / 100;
            return source2.OrderByDescending<double, double>((Func<double, double>) (d => d)).Take<double>(count).Distinct<double>();
          }
          if (type == XLTopBottomType.Items)
            return source1.Select<IXLCell, double>((Func<IXLCell, double>) (c => c.GetDouble())).OrderBy<double, double>((Func<double, double>) (d => d)).Take<double>(value).Distinct<double>();
          IEnumerable<double> source3 = source1.Select<IXLCell, double>((Func<IXLCell, double>) (c => c.GetDouble()));
          int count1 = source3.Count<double>() * value / 100;
          return source3.OrderBy<double, double>((Func<double, double>) (d => d)).Take<double>(count1).Distinct<double>();
        }
      }
    }

    private void ShowAverage(bool aboveAverage)
    {
      this._autoFilter.Enabled = true;
      this._autoFilter.Column(this._column).SetFilterType(XLFilterType.Dynamic).SetDynamicType(aboveAverage ? XLFilterDynamicType.AboveAverage : XLFilterDynamicType.BelowAverage);
      IEnumerable<double> averageValues = this.GetAverageValues(aboveAverage);
      this.Clear();
      this._autoFilter.Filters.Add(this._column, new List<XLFilter>());
      bool flag1 = true;
      XLWorksheet worksheet = this._autoFilter.Range.Worksheet as XLWorksheet;
      worksheet.SuspendEvents();
      foreach (IXLRangeRow row in (IEnumerable<IXLRangeRow>) this._autoFilter.Range.Rows(2, this._autoFilter.Range.RowCount()))
      {
        bool flag2 = false;
        foreach (double num in averageValues)
        {
          double val = num;
          Func<object, bool> func = (Func<object, bool>) (v => (v as IComparable).CompareTo((object) val) == 0);
          if (flag1)
            this._autoFilter.Filters[this._column].Add(new XLFilter(XLFilterOperator.Equal)
            {
              Value = (object) val,
              Operator = XLFilterOperator.Equal,
              Connector = XLConnector.Or,
              Condition = func
            });
          IXLCell xlCell = row.Cell(this._column);
          if (xlCell.DataType == XLCellValues.Number && func((object) xlCell.GetDouble()))
          {
            row.WorksheetRow().Unhide();
            flag2 = true;
          }
        }
        if (!flag2)
          row.WorksheetRow().Hide();
        flag1 = false;
      }
      worksheet.ResumeEvents();
    }

    private IEnumerable<double> GetAverageValues(bool aboveAverage)
    {
      using (IXLRangeColumn xlRangeColumn1 = this._autoFilter.Range.Column(this._column))
      {
        using (IXLRangeColumn xlRangeColumn2 = xlRangeColumn1.Column(2, xlRangeColumn1.CellCount()))
        {
          double average = xlRangeColumn2.CellsUsed((Func<IXLCell, bool>) (c => c.DataType == XLCellValues.Number)).Select<IXLCell, double>((Func<IXLCell, double>) (c => c.GetDouble())).Average();
          if (aboveAverage)
            return xlRangeColumn2.CellsUsed((Func<IXLCell, bool>) (c => c.DataType == XLCellValues.Number)).Select<IXLCell, double>((Func<IXLCell, double>) (c => c.GetDouble())).Where<double>((Func<double, bool>) (c => c > average)).Distinct<double>();
          return xlRangeColumn2.CellsUsed((Func<IXLCell, bool>) (c => c.DataType == XLCellValues.Number)).Select<IXLCell, double>((Func<IXLCell, double>) (c => c.GetDouble())).Where<double>((Func<double, bool>) (c => c < average)).Distinct<double>();
        }
      }
    }

    private IXLFilterConnector ApplyCustomFilter<T>(T value, XLFilterOperator op, Func<object, bool> condition, XLFilterType filterType = XLFilterType.Custom) where T : IComparable<T>
    {
      this._autoFilter.Enabled = true;
      if (filterType == XLFilterType.Custom)
      {
        this.Clear();
        this._autoFilter.Filters.Add(this._column, new List<XLFilter>()
        {
          new XLFilter(XLFilterOperator.Equal)
          {
            Value = (object) value,
            Operator = op,
            Connector = XLConnector.Or,
            Condition = condition
          }
        });
      }
      else
      {
        List<XLFilter> xlFilterList;
        if (this._autoFilter.Filters.TryGetValue(this._column, out xlFilterList))
          xlFilterList.Add(new XLFilter(XLFilterOperator.Equal)
          {
            Value = (object) value,
            Operator = op,
            Connector = XLConnector.Or,
            Condition = condition
          });
        else
          this._autoFilter.Filters.Add(this._column, new List<XLFilter>()
          {
            new XLFilter(XLFilterOperator.Equal)
            {
              Value = (object) value,
              Operator = op,
              Connector = XLConnector.Or,
              Condition = condition
            }
          });
      }
      this._autoFilter.Column(this._column).FilterType = filterType;
      bool flag = typeof (T) == typeof (string);
      XLWorksheet worksheet = this._autoFilter.Range.Worksheet as XLWorksheet;
      worksheet.SuspendEvents();
      foreach (IXLRangeRow row in (IEnumerable<IXLRangeRow>) this._autoFilter.Range.Rows(2, this._autoFilter.Range.RowCount()))
      {
        if (flag ? condition((object) row.Cell(this._column).GetString()) : row.Cell(this._column).DataType == XLCellValues.Number && condition((object) row.Cell(this._column).GetDouble()))
          row.WorksheetRow().Unhide();
        else
          row.WorksheetRow().Hide();
      }
      worksheet.ResumeEvents();
      return (IXLFilterConnector) new XLFilterConnector(this._autoFilter, this._column);
    }

    public IXLFilterColumn SetFilterType(XLFilterType value)
    {
      this.FilterType = value;
      return (IXLFilterColumn) this;
    }

    public IXLFilterColumn SetTopBottomValue(int value)
    {
      this.TopBottomValue = value;
      return (IXLFilterColumn) this;
    }

    public IXLFilterColumn SetTopBottomType(XLTopBottomType value)
    {
      this.TopBottomType = value;
      return (IXLFilterColumn) this;
    }

    public IXLFilterColumn SetTopBottomPart(XLTopBottomPart value)
    {
      this.TopBottomPart = value;
      return (IXLFilterColumn) this;
    }

    public IXLFilterColumn SetDynamicType(XLFilterDynamicType value)
    {
      this.DynamicType = value;
      return (IXLFilterColumn) this;
    }

    public IXLFilterColumn SetDynamicValue(double value)
    {
      this.DynamicValue = value;
      return (IXLFilterColumn) this;
    }
  }
}

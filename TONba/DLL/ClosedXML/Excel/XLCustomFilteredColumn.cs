// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLCustomFilteredColumn
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections.Generic;

namespace ClosedXML.Excel
{
  internal class XLCustomFilteredColumn : IXLCustomFilteredColumn
  {
    private readonly XLAutoFilter _autoFilter;
    private readonly int _column;
    private readonly XLConnector _connector;

    public XLCustomFilteredColumn(XLAutoFilter autoFilter, int column, XLConnector connector)
    {
      this._autoFilter = autoFilter;
      this._column = column;
      this._connector = connector;
    }

    public void EqualTo<T>(T value) where T : IComparable<T>
    {
      if (typeof (T) == typeof (string))
        this.ApplyCustomFilter<T>(value, XLFilterOperator.Equal, (Func<object, bool>) (v => v.ToString().Equals(value.ToString(), StringComparison.InvariantCultureIgnoreCase)));
      else
        this.ApplyCustomFilter<T>(value, XLFilterOperator.Equal, (Func<object, bool>) (v => v.CastTo<T>().CompareTo(value) == 0));
    }

    public void NotEqualTo<T>(T value) where T : IComparable<T>
    {
      if (typeof (T) == typeof (string))
        this.ApplyCustomFilter<T>(value, XLFilterOperator.NotEqual, (Func<object, bool>) (v => !v.ToString().Equals(value.ToString(), StringComparison.InvariantCultureIgnoreCase)));
      else
        this.ApplyCustomFilter<T>(value, XLFilterOperator.NotEqual, (Func<object, bool>) (v => v.CastTo<T>().CompareTo(value) != 0));
    }

    public void GreaterThan<T>(T value) where T : IComparable<T>
    {
      this.ApplyCustomFilter<T>(value, XLFilterOperator.GreaterThan, (Func<object, bool>) (v => v.CastTo<T>().CompareTo(value) > 0));
    }

    public void LessThan<T>(T value) where T : IComparable<T>
    {
      this.ApplyCustomFilter<T>(value, XLFilterOperator.LessThan, (Func<object, bool>) (v => v.CastTo<T>().CompareTo(value) < 0));
    }

    public void EqualOrGreaterThan<T>(T value) where T : IComparable<T>
    {
      this.ApplyCustomFilter<T>(value, XLFilterOperator.EqualOrGreaterThan, (Func<object, bool>) (v => v.CastTo<T>().CompareTo(value) >= 0));
    }

    public void EqualOrLessThan<T>(T value) where T : IComparable<T>
    {
      this.ApplyCustomFilter<T>(value, XLFilterOperator.EqualOrLessThan, (Func<object, bool>) (v => v.CastTo<T>().CompareTo(value) <= 0));
    }

    public void BeginsWith(string value)
    {
      this.ApplyCustomFilter<string>(value + "*", XLFilterOperator.Equal, (Func<object, bool>) (s => ((string) s).StartsWith(value, StringComparison.InvariantCultureIgnoreCase)));
    }

    public void NotBeginsWith(string value)
    {
      this.ApplyCustomFilter<string>(value + "*", XLFilterOperator.NotEqual, (Func<object, bool>) (s => !((string) s).StartsWith(value, StringComparison.InvariantCultureIgnoreCase)));
    }

    public void EndsWith(string value)
    {
      this.ApplyCustomFilter<string>("*" + value, XLFilterOperator.Equal, (Func<object, bool>) (s => ((string) s).EndsWith(value, StringComparison.InvariantCultureIgnoreCase)));
    }

    public void NotEndsWith(string value)
    {
      this.ApplyCustomFilter<string>("*" + value, XLFilterOperator.NotEqual, (Func<object, bool>) (s => !((string) s).EndsWith(value, StringComparison.InvariantCultureIgnoreCase)));
    }

    public void Contains(string value)
    {
      this.ApplyCustomFilter<string>("*" + value + "*", XLFilterOperator.Equal, (Func<object, bool>) (s => ((string) s).ToLower().Contains(value.ToLower())));
    }

    public void NotContains(string value)
    {
      this.ApplyCustomFilter<string>("*" + value + "*", XLFilterOperator.Equal, (Func<object, bool>) (s => !((string) s).ToLower().Contains(value.ToLower())));
    }

    private void ApplyCustomFilter<T>(T value, XLFilterOperator op, Func<object, bool> condition) where T : IComparable<T>
    {
      this._autoFilter.Filters[this._column].Add(new XLFilter(XLFilterOperator.Equal)
      {
        Value = (object) value,
        Operator = op,
        Connector = this._connector,
        Condition = condition
      });
      using (IXLRangeRows xlRangeRows = this._autoFilter.Range.Rows(2, this._autoFilter.Range.RowCount()))
      {
        foreach (IXLRangeRow xlRangeRow in (IEnumerable<IXLRangeRow>) xlRangeRows)
        {
          if (this._connector == XLConnector.And)
          {
            if (!xlRangeRow.WorksheetRow().IsHidden)
            {
              if (condition((object) xlRangeRow.Cell(this._column).GetValue<T>()))
                xlRangeRow.WorksheetRow().Unhide().Dispose();
              else
                xlRangeRow.WorksheetRow().Hide().Dispose();
            }
          }
          else if (condition((object) xlRangeRow.Cell(this._column).GetValue<T>()))
            xlRangeRow.WorksheetRow().Unhide().Dispose();
        }
      }
    }
  }
}

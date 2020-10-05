// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLFilteredColumn
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections.Generic;

namespace ClosedXML.Excel
{
  internal class XLFilteredColumn : IXLFilteredColumn
  {
    private readonly XLAutoFilter _autoFilter;
    private readonly int _column;

    public XLFilteredColumn(XLAutoFilter autoFilter, int column)
    {
      this._autoFilter = autoFilter;
      this._column = column;
    }

    public IXLFilteredColumn AddFilter<T>(T value) where T : IComparable<T>
    {
      Func<object, bool> func;
      bool flag;
      if (typeof (T) == typeof (string))
      {
        func = (Func<object, bool>) (v => v.ToString().Equals(value.ToString(), StringComparison.InvariantCultureIgnoreCase));
        flag = true;
      }
      else
      {
        func = (Func<object, bool>) (v => v.CastTo<T>().CompareTo(value) == 0);
        flag = false;
      }
      this._autoFilter.Filters[this._column].Add(new XLFilter(XLFilterOperator.Equal)
      {
        Value = (object) value,
        Condition = func,
        Operator = XLFilterOperator.Equal,
        Connector = XLConnector.Or
      });
      using (IXLRangeRows xlRangeRows = this._autoFilter.Range.Rows(2, this._autoFilter.Range.RowCount()))
      {
        foreach (IXLRangeRow xlRangeRow in (IEnumerable<IXLRangeRow>) xlRangeRows)
        {
          if (flag && func((object) xlRangeRow.Cell(this._column).GetString()) || !flag && xlRangeRow.Cell(this._column).DataType == XLCellValues.Number && func((object) xlRangeRow.Cell(this._column).GetValue<T>()))
            xlRangeRow.WorksheetRow().Unhide().Dispose();
        }
      }
      return (IXLFilteredColumn) this;
    }
  }
}

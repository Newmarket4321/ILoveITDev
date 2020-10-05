// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLTableField
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;

namespace ClosedXML.Excel
{
  internal class XLTableField : IXLTableField
  {
    private XLTable table;
    internal string totalsRowLabel;
    internal XLTotalsRowFunction totalsRowFunction;

    public XLTableField(XLTable table)
    {
      this.table = table;
    }

    public int Index { get; internal set; }

    public string Name
    {
      get
      {
        return this.table.HeadersRow().Cell(this.Index + 1).GetString();
      }
      set
      {
        this.table.HeadersRow().Cell(this.Index + 1).SetValue<string>(value);
      }
    }

    public string TotalsRowLabel
    {
      get
      {
        return this.totalsRowLabel;
      }
      set
      {
        this.totalsRowFunction = XLTotalsRowFunction.None;
        this.table.TotalsRow().Cell(this.Index + 1).SetValue<string>(value);
        this.totalsRowLabel = value;
      }
    }

    public string TotalsRowFormulaA1
    {
      get
      {
        return this.table.TotalsRow().Cell(this.Index + 1).FormulaA1;
      }
      set
      {
        this.totalsRowFunction = XLTotalsRowFunction.Custom;
        this.table.TotalsRow().Cell(this.Index + 1).FormulaA1 = value;
      }
    }

    public string TotalsRowFormulaR1C1
    {
      get
      {
        return this.table.TotalsRow().Cell(this.Index + 1).FormulaR1C1;
      }
      set
      {
        this.totalsRowFunction = XLTotalsRowFunction.Custom;
        this.table.TotalsRow().Cell(this.Index + 1).FormulaR1C1 = value;
      }
    }

    public XLTotalsRowFunction TotalsRowFunction
    {
      get
      {
        return this.totalsRowFunction;
      }
      set
      {
        if (value != XLTotalsRowFunction.None && value != XLTotalsRowFunction.Custom)
        {
          IXLCell xlCell1 = this.table.TotalsRow().Cell(this.Index + 1);
          string str = string.Empty;
          switch (value)
          {
            case XLTotalsRowFunction.Sum:
              str = "109";
              break;
            case XLTotalsRowFunction.Minimum:
              str = "105";
              break;
            case XLTotalsRowFunction.Maximum:
              str = "104";
              break;
            case XLTotalsRowFunction.Average:
              str = "101";
              break;
            case XLTotalsRowFunction.Count:
              str = "103";
              break;
            case XLTotalsRowFunction.CountNumbers:
              str = "102";
              break;
            case XLTotalsRowFunction.StandardDeviation:
              str = "107";
              break;
            case XLTotalsRowFunction.Variance:
              str = "110";
              break;
          }
          xlCell1.FormulaA1 = "SUBTOTAL(" + str + ",[" + this.Name + "])";
          IXLCell xlCell2 = this.table.LastRow((Func<IXLRangeRow, bool>) null).Cell(this.Index + 1);
          if (xlCell2.DataType != XLCellValues.Text)
          {
            xlCell1.DataType = xlCell2.DataType;
            xlCell1.Style.NumberFormat = xlCell2.Style.NumberFormat;
          }
        }
        this.totalsRowFunction = value;
      }
    }
  }
}

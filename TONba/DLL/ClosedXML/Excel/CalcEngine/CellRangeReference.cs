// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.CalcEngine.CellRangeReference
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections;
using System.Linq;

namespace ClosedXML.Excel.CalcEngine
{
  internal class CellRangeReference : IValueObject, IEnumerable
  {
    private IXLRange _range;
    private XLCalcEngine _ce;
    private bool _evaluating;

    public CellRangeReference(IXLRange range, XLCalcEngine ce)
    {
      this._range = range;
      this._ce = ce;
    }

    public IXLRange Range
    {
      get
      {
        return this._range;
      }
    }

    public object GetValue()
    {
      return this.GetValue(this._range.FirstCell());
    }

    public IEnumerator GetEnumerator()
    {
      return (IEnumerator) this._range.Cells().Select<IXLCell, object>(new Func<IXLCell, object>(this.GetValue)).GetEnumerator();
    }

    private object GetValue(IXLCell cell)
    {
      if (this._evaluating)
        throw new Exception("Circular Reference");
      try
      {
        this._evaluating = true;
        string formulaA1 = cell.FormulaA1;
        if (XLHelper.IsNullOrWhiteSpace(formulaA1))
          return cell.Value;
        return new XLCalcEngine(cell.Worksheet).Evaluate(formulaA1);
      }
      finally
      {
        this._evaluating = false;
      }
    }
  }
}

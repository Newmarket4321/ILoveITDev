// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLPivotValueCombination
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  internal class XLPivotValueCombination : IXLPivotValueCombination
  {
    private readonly IXLPivotValue _pivotValue;

    public XLPivotValueCombination(IXLPivotValue pivotValue)
    {
      this._pivotValue = pivotValue;
    }

    public IXLPivotValue And(string item)
    {
      this._pivotValue.BaseItem = item;
      this._pivotValue.CalculationItem = XLPivotCalculationItem.Value;
      return this._pivotValue;
    }

    public IXLPivotValue AndPrevious()
    {
      this._pivotValue.CalculationItem = XLPivotCalculationItem.Previous;
      return this._pivotValue;
    }

    public IXLPivotValue AndNext()
    {
      this._pivotValue.CalculationItem = XLPivotCalculationItem.Next;
      return this._pivotValue;
    }
  }
}

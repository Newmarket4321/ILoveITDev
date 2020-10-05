// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLPivotValue
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  internal class XLPivotValue : IXLPivotValue
  {
    public XLPivotValue(string sourceName)
    {
      this.SourceName = sourceName;
      this.NumberFormat = (IXLPivotValueFormat) new XLPivotValueFormat(this);
    }

    public IXLPivotValueFormat NumberFormat { get; private set; }

    public string SourceName { get; private set; }

    public string CustomName { get; set; }

    public IXLPivotValue SetCustomName(string value)
    {
      this.CustomName = value;
      return (IXLPivotValue) this;
    }

    public XLPivotSummary SummaryFormula { get; set; }

    public IXLPivotValue SetSummaryFormula(XLPivotSummary value)
    {
      this.SummaryFormula = value;
      return (IXLPivotValue) this;
    }

    public XLPivotCalculation Calculation { get; set; }

    public IXLPivotValue SetCalculation(XLPivotCalculation value)
    {
      this.Calculation = value;
      return (IXLPivotValue) this;
    }

    public string BaseField { get; set; }

    public IXLPivotValue SetBaseField(string value)
    {
      this.BaseField = value;
      return (IXLPivotValue) this;
    }

    public string BaseItem { get; set; }

    public IXLPivotValue SetBaseItem(string value)
    {
      this.BaseItem = value;
      return (IXLPivotValue) this;
    }

    public XLPivotCalculationItem CalculationItem { get; set; }

    public IXLPivotValue SetCalculationItem(XLPivotCalculationItem value)
    {
      this.CalculationItem = value;
      return (IXLPivotValue) this;
    }

    public IXLPivotValue ShowAsNormal()
    {
      return this.SetCalculation(XLPivotCalculation.Normal);
    }

    public IXLPivotValueCombination ShowAsDifferenceFrom(string fieldSourceName)
    {
      this.BaseField = fieldSourceName;
      this.SetCalculation(XLPivotCalculation.DifferenceFrom);
      return (IXLPivotValueCombination) new XLPivotValueCombination((IXLPivotValue) this);
    }

    public IXLPivotValueCombination ShowAsPctFrom(string fieldSourceName)
    {
      this.BaseField = fieldSourceName;
      this.SetCalculation(XLPivotCalculation.PctOf);
      return (IXLPivotValueCombination) new XLPivotValueCombination((IXLPivotValue) this);
    }

    public IXLPivotValueCombination ShowAsPctDifferenceFrom(string fieldSourceName)
    {
      this.BaseField = fieldSourceName;
      this.SetCalculation(XLPivotCalculation.PctDifferenceFrom);
      return (IXLPivotValueCombination) new XLPivotValueCombination((IXLPivotValue) this);
    }

    public IXLPivotValue ShowAsRunningTotalIn(string fieldSourceName)
    {
      this.BaseField = fieldSourceName;
      return this.SetCalculation(XLPivotCalculation.RunningTotal);
    }

    public IXLPivotValue ShowAsPctOfRow()
    {
      return this.SetCalculation(XLPivotCalculation.PctOfRow);
    }

    public IXLPivotValue ShowAsPctOfColumn()
    {
      return this.SetCalculation(XLPivotCalculation.PctOfColumn);
    }

    public IXLPivotValue ShowAsPctOfTotal()
    {
      return this.SetCalculation(XLPivotCalculation.PctOfTotal);
    }

    public IXLPivotValue ShowAsIndex()
    {
      return this.SetCalculation(XLPivotCalculation.Index);
    }
  }
}

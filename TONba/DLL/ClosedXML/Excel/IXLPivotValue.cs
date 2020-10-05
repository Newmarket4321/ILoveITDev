// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLPivotValue
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  public interface IXLPivotValue
  {
    string SourceName { get; }

    string CustomName { get; set; }

    IXLPivotValueFormat NumberFormat { get; }

    XLPivotSummary SummaryFormula { get; set; }

    XLPivotCalculation Calculation { get; set; }

    string BaseField { get; set; }

    string BaseItem { get; set; }

    XLPivotCalculationItem CalculationItem { get; set; }

    IXLPivotValue SetSummaryFormula(XLPivotSummary value);

    IXLPivotValue SetCalculation(XLPivotCalculation value);

    IXLPivotValue SetBaseField(string value);

    IXLPivotValue SetBaseItem(string value);

    IXLPivotValue SetCalculationItem(XLPivotCalculationItem value);

    IXLPivotValue ShowAsNormal();

    IXLPivotValueCombination ShowAsDifferenceFrom(string fieldSourceName);

    IXLPivotValueCombination ShowAsPctFrom(string fieldSourceName);

    IXLPivotValueCombination ShowAsPctDifferenceFrom(string fieldSourceName);

    IXLPivotValue ShowAsRunningTotalIn(string fieldSourceName);

    IXLPivotValue ShowAsPctOfRow();

    IXLPivotValue ShowAsPctOfColumn();

    IXLPivotValue ShowAsPctOfTotal();

    IXLPivotValue ShowAsIndex();
  }
}

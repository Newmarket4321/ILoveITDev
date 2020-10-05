// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLDecimalCriteria
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  public class XLDecimalCriteria : XLValidationCriteria
  {
    public XLDecimalCriteria(IXLDataValidation dataValidation)
      : base(dataValidation)
    {
    }

    public void EqualTo(double value)
    {
      this.dataValidation.Value = value.ToString();
      this.dataValidation.Operator = XLOperator.EqualTo;
    }

    public void NotEqualTo(double value)
    {
      this.dataValidation.Value = value.ToString();
      this.dataValidation.Operator = XLOperator.NotEqualTo;
    }

    public void GreaterThan(double value)
    {
      this.dataValidation.Value = value.ToString();
      this.dataValidation.Operator = XLOperator.GreaterThan;
    }

    public void LessThan(double value)
    {
      this.dataValidation.Value = value.ToString();
      this.dataValidation.Operator = XLOperator.LessThan;
    }

    public void EqualOrGreaterThan(double value)
    {
      this.dataValidation.Value = value.ToString();
      this.dataValidation.Operator = XLOperator.EqualOrGreaterThan;
    }

    public void EqualOrLessThan(double value)
    {
      this.dataValidation.Value = value.ToString();
      this.dataValidation.Operator = XLOperator.EqualOrLessThan;
    }

    public void Between(double minValue, double maxValue)
    {
      this.dataValidation.MinValue = minValue.ToString();
      this.dataValidation.MaxValue = maxValue.ToString();
      this.dataValidation.Operator = XLOperator.Between;
    }

    public void NotBetween(double minValue, double maxValue)
    {
      this.dataValidation.MinValue = minValue.ToString();
      this.dataValidation.MaxValue = maxValue.ToString();
      this.dataValidation.Operator = XLOperator.NotBetween;
    }
  }
}

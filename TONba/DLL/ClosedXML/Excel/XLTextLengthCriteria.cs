// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLTextLengthCriteria
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  public class XLTextLengthCriteria : XLValidationCriteria
  {
    public XLTextLengthCriteria(IXLDataValidation dataValidation)
      : base(dataValidation)
    {
    }

    public void EqualTo(int value)
    {
      this.dataValidation.Value = value.ToString();
      this.dataValidation.Operator = XLOperator.EqualTo;
    }

    public void NotEqualTo(int value)
    {
      this.dataValidation.Value = value.ToString();
      this.dataValidation.Operator = XLOperator.NotEqualTo;
    }

    public void GreaterThan(int value)
    {
      this.dataValidation.Value = value.ToString();
      this.dataValidation.Operator = XLOperator.GreaterThan;
    }

    public void LessThan(int value)
    {
      this.dataValidation.Value = value.ToString();
      this.dataValidation.Operator = XLOperator.LessThan;
    }

    public void EqualOrGreaterThan(int value)
    {
      this.dataValidation.Value = value.ToString();
      this.dataValidation.Operator = XLOperator.EqualOrGreaterThan;
    }

    public void EqualOrLessThan(int value)
    {
      this.dataValidation.Value = value.ToString();
      this.dataValidation.Operator = XLOperator.EqualOrLessThan;
    }

    public void Between(int minValue, int maxValue)
    {
      this.dataValidation.MinValue = minValue.ToString();
      this.dataValidation.MaxValue = maxValue.ToString();
      this.dataValidation.Operator = XLOperator.Between;
    }

    public void NotBetween(int minValue, int maxValue)
    {
      this.dataValidation.MinValue = minValue.ToString();
      this.dataValidation.MaxValue = maxValue.ToString();
      this.dataValidation.Operator = XLOperator.NotBetween;
    }
  }
}

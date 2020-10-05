// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLValidationCriteria
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  public abstract class XLValidationCriteria : IXLValidationCriteria
  {
    protected IXLDataValidation dataValidation;

    internal XLValidationCriteria(IXLDataValidation dataValidation)
    {
      this.dataValidation = dataValidation;
    }

    public void EqualTo(string value)
    {
      this.dataValidation.Value = value;
      this.dataValidation.Operator = XLOperator.EqualTo;
    }

    public void NotEqualTo(string value)
    {
      this.dataValidation.Value = value;
      this.dataValidation.Operator = XLOperator.NotEqualTo;
    }

    public void GreaterThan(string value)
    {
      this.dataValidation.Value = value;
      this.dataValidation.Operator = XLOperator.GreaterThan;
    }

    public void LessThan(string value)
    {
      this.dataValidation.Value = value;
      this.dataValidation.Operator = XLOperator.LessThan;
    }

    public void EqualOrGreaterThan(string value)
    {
      this.dataValidation.Value = value;
      this.dataValidation.Operator = XLOperator.EqualOrGreaterThan;
    }

    public void EqualOrLessThan(string value)
    {
      this.dataValidation.Value = value;
      this.dataValidation.Operator = XLOperator.EqualOrLessThan;
    }

    public void Between(string minValue, string maxValue)
    {
      this.dataValidation.MinValue = minValue;
      this.dataValidation.MaxValue = maxValue;
      this.dataValidation.Operator = XLOperator.Between;
    }

    public void NotBetween(string minValue, string maxValue)
    {
      this.dataValidation.MinValue = minValue;
      this.dataValidation.MaxValue = maxValue;
      this.dataValidation.Operator = XLOperator.NotBetween;
    }

    public void EqualTo(IXLRange range)
    {
      this.dataValidation.Value = range.RangeAddress.ToStringFixed();
      this.dataValidation.Operator = XLOperator.EqualTo;
    }

    public void NotEqualTo(IXLRange range)
    {
      this.dataValidation.Value = range.RangeAddress.ToStringFixed();
      this.dataValidation.Operator = XLOperator.NotEqualTo;
    }

    public void GreaterThan(IXLRange range)
    {
      this.dataValidation.Value = range.RangeAddress.ToStringFixed();
      this.dataValidation.Operator = XLOperator.GreaterThan;
    }

    public void LessThan(IXLRange range)
    {
      this.dataValidation.Value = range.RangeAddress.ToStringFixed();
      this.dataValidation.Operator = XLOperator.LessThan;
    }

    public void EqualOrGreaterThan(IXLRange range)
    {
      this.dataValidation.Value = range.RangeAddress.ToStringFixed();
      this.dataValidation.Operator = XLOperator.EqualOrGreaterThan;
    }

    public void EqualOrLessThan(IXLRange range)
    {
      this.dataValidation.Value = range.RangeAddress.ToStringFixed();
      this.dataValidation.Operator = XLOperator.EqualOrLessThan;
    }

    public void Between(IXLRange minValue, IXLRange maxValue)
    {
      this.dataValidation.MinValue = minValue.RangeAddress.ToStringFixed();
      this.dataValidation.MaxValue = maxValue.RangeAddress.ToStringFixed();
      this.dataValidation.Operator = XLOperator.Between;
    }

    public void NotBetween(IXLRange minValue, IXLRange maxValue)
    {
      this.dataValidation.MinValue = minValue.RangeAddress.ToStringFixed();
      this.dataValidation.MaxValue = maxValue.RangeAddress.ToStringFixed();
      this.dataValidation.Operator = XLOperator.NotBetween;
    }

    public void EqualTo(IXLCell cell)
    {
      this.dataValidation.Value = cell.Address.ToStringFixed();
      this.dataValidation.Operator = XLOperator.EqualTo;
    }

    public void NotEqualTo(IXLCell cell)
    {
      this.dataValidation.Value = cell.Address.ToStringFixed();
      this.dataValidation.Operator = XLOperator.NotEqualTo;
    }

    public void GreaterThan(IXLCell cell)
    {
      this.dataValidation.Value = cell.Address.ToStringFixed();
      this.dataValidation.Operator = XLOperator.GreaterThan;
    }

    public void LessThan(IXLCell cell)
    {
      this.dataValidation.Value = cell.Address.ToStringFixed();
      this.dataValidation.Operator = XLOperator.LessThan;
    }

    public void EqualOrGreaterThan(IXLCell cell)
    {
      this.dataValidation.Value = cell.Address.ToStringFixed();
      this.dataValidation.Operator = XLOperator.EqualOrGreaterThan;
    }

    public void EqualOrLessThan(IXLCell cell)
    {
      this.dataValidation.Value = cell.Address.ToStringFixed();
      this.dataValidation.Operator = XLOperator.EqualOrLessThan;
    }

    public void Between(IXLCell minValue, IXLCell maxValue)
    {
      this.dataValidation.MinValue = minValue.Address.ToStringFixed();
      this.dataValidation.MaxValue = maxValue.Address.ToStringFixed();
      this.dataValidation.Operator = XLOperator.Between;
    }

    public void NotBetween(IXLCell minValue, IXLCell maxValue)
    {
      this.dataValidation.MinValue = minValue.Address.ToStringFixed();
      this.dataValidation.MaxValue = maxValue.Address.ToStringFixed();
      this.dataValidation.Operator = XLOperator.NotBetween;
    }
  }
}

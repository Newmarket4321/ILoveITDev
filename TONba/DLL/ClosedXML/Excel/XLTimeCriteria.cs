// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLTimeCriteria
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;

namespace ClosedXML.Excel
{
  public class XLTimeCriteria : XLValidationCriteria
  {
    public XLTimeCriteria(IXLDataValidation dataValidation)
      : base(dataValidation)
    {
    }

    private static string GetXLTime(TimeSpan value)
    {
      return (value.TotalHours / 24.0).ToString();
    }

    public void EqualTo(TimeSpan value)
    {
      this.dataValidation.Value = XLTimeCriteria.GetXLTime(value);
      this.dataValidation.Operator = XLOperator.EqualTo;
    }

    public void NotEqualTo(TimeSpan value)
    {
      this.dataValidation.Value = XLTimeCriteria.GetXLTime(value);
      this.dataValidation.Operator = XLOperator.NotEqualTo;
    }

    public void GreaterThan(TimeSpan value)
    {
      this.dataValidation.Value = XLTimeCriteria.GetXLTime(value);
      this.dataValidation.Operator = XLOperator.GreaterThan;
    }

    public void LessThan(TimeSpan value)
    {
      this.dataValidation.Value = XLTimeCriteria.GetXLTime(value);
      this.dataValidation.Operator = XLOperator.LessThan;
    }

    public void EqualOrGreaterThan(TimeSpan value)
    {
      this.dataValidation.Value = XLTimeCriteria.GetXLTime(value);
      this.dataValidation.Operator = XLOperator.EqualOrGreaterThan;
    }

    public void EqualOrLessThan(TimeSpan value)
    {
      this.dataValidation.Value = XLTimeCriteria.GetXLTime(value);
      this.dataValidation.Operator = XLOperator.EqualOrLessThan;
    }

    public void Between(TimeSpan minValue, TimeSpan maxValue)
    {
      this.dataValidation.MinValue = XLTimeCriteria.GetXLTime(minValue);
      this.dataValidation.MaxValue = XLTimeCriteria.GetXLTime(maxValue);
      this.dataValidation.Operator = XLOperator.Between;
    }

    public void NotBetween(TimeSpan minValue, TimeSpan maxValue)
    {
      this.dataValidation.MinValue = XLTimeCriteria.GetXLTime(minValue);
      this.dataValidation.MaxValue = XLTimeCriteria.GetXLTime(maxValue);
      this.dataValidation.Operator = XLOperator.NotBetween;
    }
  }
}

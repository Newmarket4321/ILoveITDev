// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLDateCriteria
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Globalization;

namespace ClosedXML.Excel
{
  public class XLDateCriteria : XLValidationCriteria
  {
    public XLDateCriteria(IXLDataValidation dataValidation)
      : base(dataValidation)
    {
    }

    public void EqualTo(DateTime value)
    {
      this.dataValidation.Value = value.ToOADate().ToString((IFormatProvider) CultureInfo.InvariantCulture);
      this.dataValidation.Operator = XLOperator.EqualTo;
    }

    public void NotEqualTo(DateTime value)
    {
      this.dataValidation.Value = value.ToOADate().ToString((IFormatProvider) CultureInfo.InvariantCulture);
      this.dataValidation.Operator = XLOperator.NotEqualTo;
    }

    public void GreaterThan(DateTime value)
    {
      this.dataValidation.Value = value.ToOADate().ToString((IFormatProvider) CultureInfo.InvariantCulture);
      this.dataValidation.Operator = XLOperator.GreaterThan;
    }

    public void LessThan(DateTime value)
    {
      this.dataValidation.Value = value.ToOADate().ToString((IFormatProvider) CultureInfo.InvariantCulture);
      this.dataValidation.Operator = XLOperator.LessThan;
    }

    public void EqualOrGreaterThan(DateTime value)
    {
      this.dataValidation.Value = value.ToOADate().ToString((IFormatProvider) CultureInfo.InvariantCulture);
      this.dataValidation.Operator = XLOperator.EqualOrGreaterThan;
    }

    public void EqualOrLessThan(DateTime value)
    {
      this.dataValidation.Value = value.ToOADate().ToString((IFormatProvider) CultureInfo.InvariantCulture);
      this.dataValidation.Operator = XLOperator.EqualOrLessThan;
    }

    public void Between(DateTime minValue, DateTime maxValue)
    {
      this.dataValidation.MinValue = minValue.ToOADate().ToString((IFormatProvider) CultureInfo.InvariantCulture);
      this.dataValidation.MaxValue = maxValue.ToOADate().ToString((IFormatProvider) CultureInfo.InvariantCulture);
      this.dataValidation.Operator = XLOperator.Between;
    }

    public void NotBetween(DateTime minValue, DateTime maxValue)
    {
      this.dataValidation.MinValue = minValue.ToOADate().ToString((IFormatProvider) CultureInfo.InvariantCulture);
      this.dataValidation.MaxValue = maxValue.ToOADate().ToString((IFormatProvider) CultureInfo.InvariantCulture);
      this.dataValidation.Operator = XLOperator.NotBetween;
    }
  }
}

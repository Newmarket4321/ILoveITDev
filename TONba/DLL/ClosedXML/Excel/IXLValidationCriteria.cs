// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLValidationCriteria
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  public interface IXLValidationCriteria
  {
    void EqualTo(string value);

    void NotEqualTo(string value);

    void GreaterThan(string value);

    void LessThan(string value);

    void EqualOrGreaterThan(string value);

    void EqualOrLessThan(string value);

    void Between(string minValue, string maxValue);

    void NotBetween(string minValue, string maxValue);

    void EqualTo(IXLRange range);

    void NotEqualTo(IXLRange range);

    void GreaterThan(IXLRange range);

    void LessThan(IXLRange range);

    void EqualOrGreaterThan(IXLRange range);

    void EqualOrLessThan(IXLRange range);

    void Between(IXLRange minValue, IXLRange maxValue);

    void NotBetween(IXLRange minValue, IXLRange maxValue);

    void EqualTo(IXLCell cell);

    void NotEqualTo(IXLCell cell);

    void GreaterThan(IXLCell cell);

    void LessThan(IXLCell cell);

    void EqualOrGreaterThan(IXLCell cell);

    void EqualOrLessThan(IXLCell cell);

    void Between(IXLCell minValue, IXLCell maxValue);

    void NotBetween(IXLCell minValue, IXLCell maxValue);
  }
}

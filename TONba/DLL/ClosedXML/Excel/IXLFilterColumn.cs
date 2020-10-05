// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLFilterColumn
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;

namespace ClosedXML.Excel
{
  public interface IXLFilterColumn
  {
    void Clear();

    IXLFilteredColumn AddFilter<T>(T value) where T : IComparable<T>;

    void Top(int value, XLTopBottomType type = XLTopBottomType.Items);

    void Bottom(int value, XLTopBottomType type = XLTopBottomType.Items);

    void AboveAverage();

    void BelowAverage();

    IXLFilterConnector EqualTo<T>(T value) where T : IComparable<T>;

    IXLFilterConnector NotEqualTo<T>(T value) where T : IComparable<T>;

    IXLFilterConnector GreaterThan<T>(T value) where T : IComparable<T>;

    IXLFilterConnector LessThan<T>(T value) where T : IComparable<T>;

    IXLFilterConnector EqualOrGreaterThan<T>(T value) where T : IComparable<T>;

    IXLFilterConnector EqualOrLessThan<T>(T value) where T : IComparable<T>;

    void Between<T>(T minValue, T maxValue) where T : IComparable<T>;

    void NotBetween<T>(T minValue, T maxValue) where T : IComparable<T>;

    IXLFilterConnector BeginsWith(string value);

    IXLFilterConnector NotBeginsWith(string value);

    IXLFilterConnector EndsWith(string value);

    IXLFilterConnector NotEndsWith(string value);

    IXLFilterConnector Contains(string value);

    IXLFilterConnector NotContains(string value);

    XLFilterType FilterType { get; set; }

    int TopBottomValue { get; set; }

    XLTopBottomType TopBottomType { get; set; }

    XLTopBottomPart TopBottomPart { get; set; }

    XLFilterDynamicType DynamicType { get; set; }

    double DynamicValue { get; set; }

    IXLFilterColumn SetFilterType(XLFilterType value);

    IXLFilterColumn SetTopBottomValue(int value);

    IXLFilterColumn SetTopBottomType(XLTopBottomType value);

    IXLFilterColumn SetTopBottomPart(XLTopBottomPart value);

    IXLFilterColumn SetDynamicType(XLFilterDynamicType value);

    IXLFilterColumn SetDynamicValue(double value);
  }
}

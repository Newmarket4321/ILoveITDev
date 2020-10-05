// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLConditionalFormat
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  public interface IXLConditionalFormat
  {
    IXLStyle Style { get; set; }

    IXLStyle WhenIsBlank();

    IXLStyle WhenNotBlank();

    IXLStyle WhenIsError();

    IXLStyle WhenNotError();

    IXLStyle WhenDateIs(XLTimePeriod timePeriod);

    IXLStyle WhenContains(string value);

    IXLStyle WhenNotContains(string value);

    IXLStyle WhenStartsWith(string value);

    IXLStyle WhenEndsWith(string value);

    IXLStyle WhenEquals(string value);

    IXLStyle WhenNotEquals(string value);

    IXLStyle WhenGreaterThan(string value);

    IXLStyle WhenLessThan(string value);

    IXLStyle WhenEqualOrGreaterThan(string value);

    IXLStyle WhenEqualOrLessThan(string value);

    IXLStyle WhenBetween(string minValue, string maxValue);

    IXLStyle WhenNotBetween(string minValue, string maxValue);

    IXLStyle WhenEquals(double value);

    IXLStyle WhenNotEquals(double value);

    IXLStyle WhenGreaterThan(double value);

    IXLStyle WhenLessThan(double value);

    IXLStyle WhenEqualOrGreaterThan(double value);

    IXLStyle WhenEqualOrLessThan(double value);

    IXLStyle WhenBetween(double minValue, double maxValue);

    IXLStyle WhenNotBetween(double minValue, double maxValue);

    IXLStyle WhenIsDuplicate();

    IXLStyle WhenIsUnique();

    IXLStyle WhenIsTrue(string formula);

    IXLStyle WhenIsTop(int value, XLTopBottomType topBottomType = XLTopBottomType.Items);

    IXLStyle WhenIsBottom(int value, XLTopBottomType topBottomType);

    IXLCFColorScaleMin ColorScale();

    IXLCFDataBarMin DataBar(XLColor color, bool showBarOnly = false);

    IXLCFIconSet IconSet(XLIconSetStyle iconSetStyle, bool reverseIconOrder = false, bool showIconOnly = false);

    XLConditionalFormatType ConditionalFormatType { get; }

    XLIconSetStyle IconSetStyle { get; }

    XLTimePeriod TimePeriod { get; }

    bool ReverseIconOrder { get; }

    bool ShowIconOnly { get; }

    bool ShowBarOnly { get; }

    IXLRange Range { get; set; }

    XLDictionary<XLFormula> Values { get; }

    XLDictionary<XLColor> Colors { get; }

    XLDictionary<XLCFContentType> ContentTypes { get; }

    XLDictionary<XLCFIconSetOperator> IconSetOperators { get; }

    XLCFOperator Operator { get; }

    bool Bottom { get; }

    bool Percent { get; }
  }
}

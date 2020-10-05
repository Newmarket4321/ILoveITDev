// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLDataValidation
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  public interface IXLDataValidation
  {
    IXLRanges Ranges { get; set; }

    bool ShowInputMessage { get; set; }

    bool ShowErrorMessage { get; set; }

    bool IgnoreBlanks { get; set; }

    bool InCellDropdown { get; set; }

    string InputTitle { get; set; }

    string InputMessage { get; set; }

    string ErrorTitle { get; set; }

    string ErrorMessage { get; set; }

    XLErrorStyle ErrorStyle { get; set; }

    XLAllowedValues AllowedValues { get; set; }

    XLOperator Operator { get; set; }

    string Value { get; set; }

    string MinValue { get; set; }

    string MaxValue { get; set; }

    XLWholeNumberCriteria WholeNumber { get; }

    XLDecimalCriteria Decimal { get; }

    XLDateCriteria Date { get; }

    XLTimeCriteria Time { get; }

    XLTextLengthCriteria TextLength { get; }

    void List(string list);

    void List(string list, bool inCellDropdown);

    void List(IXLRange range);

    void List(IXLRange range, bool inCellDropdown);

    void Custom(string customValidation);

    void Clear();

    bool IsDirty();
  }
}

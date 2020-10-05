// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLDataValidation
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;

namespace ClosedXML.Excel
{
  internal class XLDataValidation : IXLDataValidation
  {
    private XLAllowedValues _allowedValues;

    public XLDataValidation(IXLRanges ranges)
    {
      this.Ranges = (IXLRanges) new XLRanges();
      ranges.ForEach<IXLRange>((Action<IXLRange>) (r => (this.Ranges as XLRanges).Add(new XLRange(new XLRangeParameters(r.RangeAddress as XLRangeAddress, r.Worksheet.Style)
      {
        IgnoreEvents = true
      }))));
      this.Initialize();
    }

    private void Initialize()
    {
      this.AllowedValues = XLAllowedValues.AnyValue;
      this.IgnoreBlanks = true;
      this.ShowErrorMessage = true;
      this.ShowInputMessage = true;
      this.InCellDropdown = true;
      this.InputTitle = string.Empty;
      this.InputMessage = string.Empty;
      this.ErrorTitle = string.Empty;
      this.ErrorMessage = string.Empty;
      this.ErrorStyle = XLErrorStyle.Stop;
      this.Operator = XLOperator.Between;
      this.Value = string.Empty;
      this.MinValue = string.Empty;
      this.MaxValue = string.Empty;
    }

    public bool IsDirty()
    {
      if (this.AllowedValues != XLAllowedValues.AnyValue || this.ShowInputMessage && (!XLHelper.IsNullOrWhiteSpace(this.InputTitle) || !XLHelper.IsNullOrWhiteSpace(this.InputMessage)))
        return true;
      if (!this.ShowErrorMessage)
        return false;
      if (XLHelper.IsNullOrWhiteSpace(this.ErrorTitle))
        return !XLHelper.IsNullOrWhiteSpace(this.ErrorMessage);
      return true;
    }

    public XLDataValidation(IXLDataValidation dataValidation)
    {
      this.CopyFrom(dataValidation);
    }

    public IXLRanges Ranges { get; set; }

    public bool IgnoreBlanks { get; set; }

    public bool InCellDropdown { get; set; }

    public bool ShowInputMessage { get; set; }

    public string InputTitle { get; set; }

    public string InputMessage { get; set; }

    public bool ShowErrorMessage { get; set; }

    public string ErrorTitle { get; set; }

    public string ErrorMessage { get; set; }

    public XLErrorStyle ErrorStyle { get; set; }

    public XLAllowedValues AllowedValues
    {
      get
      {
        return this._allowedValues;
      }
      set
      {
        this._allowedValues = value;
      }
    }

    public XLOperator Operator { get; set; }

    public string Value
    {
      get
      {
        return this.MinValue;
      }
      set
      {
        this.MinValue = value;
      }
    }

    public string MinValue { get; set; }

    public string MaxValue { get; set; }

    public XLWholeNumberCriteria WholeNumber
    {
      get
      {
        this.AllowedValues = XLAllowedValues.WholeNumber;
        return new XLWholeNumberCriteria((IXLDataValidation) this);
      }
    }

    public XLDecimalCriteria Decimal
    {
      get
      {
        this.AllowedValues = XLAllowedValues.Decimal;
        return new XLDecimalCriteria((IXLDataValidation) this);
      }
    }

    public XLDateCriteria Date
    {
      get
      {
        this.AllowedValues = XLAllowedValues.Date;
        return new XLDateCriteria((IXLDataValidation) this);
      }
    }

    public XLTimeCriteria Time
    {
      get
      {
        this.AllowedValues = XLAllowedValues.Time;
        return new XLTimeCriteria((IXLDataValidation) this);
      }
    }

    public XLTextLengthCriteria TextLength
    {
      get
      {
        this.AllowedValues = XLAllowedValues.TextLength;
        return new XLTextLengthCriteria((IXLDataValidation) this);
      }
    }

    public void List(string list)
    {
      this.List(list, true);
    }

    public void List(string list, bool inCellDropdown)
    {
      this.AllowedValues = XLAllowedValues.List;
      this.InCellDropdown = inCellDropdown;
      this.Value = list;
    }

    public void List(IXLRange range)
    {
      this.List(range, true);
    }

    public void List(IXLRange range, bool inCellDropdown)
    {
      this.List(range.RangeAddress.ToStringFixed(XLReferenceStyle.A1, true));
    }

    public void Custom(string customValidation)
    {
      this.AllowedValues = XLAllowedValues.Custom;
      this.Value = customValidation;
    }

    public void CopyFrom(IXLDataValidation dataValidation)
    {
      if (dataValidation == this)
        return;
      if (this.Ranges == null && dataValidation.Ranges != null)
      {
        this.Ranges = (IXLRanges) new XLRanges();
        dataValidation.Ranges.ForEach<IXLRange>((Action<IXLRange>) (r => this.Ranges.Add((IXLRangeBase) r)));
      }
      this.IgnoreBlanks = dataValidation.IgnoreBlanks;
      this.InCellDropdown = dataValidation.InCellDropdown;
      this.ShowErrorMessage = dataValidation.ShowErrorMessage;
      this.ShowInputMessage = dataValidation.ShowInputMessage;
      this.InputTitle = dataValidation.InputTitle;
      this.InputMessage = dataValidation.InputMessage;
      this.ErrorTitle = dataValidation.ErrorTitle;
      this.ErrorMessage = dataValidation.ErrorMessage;
      this.ErrorStyle = dataValidation.ErrorStyle;
      this.AllowedValues = dataValidation.AllowedValues;
      this.Operator = dataValidation.Operator;
      this.MinValue = dataValidation.MinValue;
      this.MaxValue = dataValidation.MaxValue;
    }

    public void Clear()
    {
      this.Initialize();
    }
  }
}

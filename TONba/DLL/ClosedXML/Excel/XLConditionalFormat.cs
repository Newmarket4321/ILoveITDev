// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLConditionalFormat
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections.Generic;

namespace ClosedXML.Excel
{
  internal class XLConditionalFormat : IXLConditionalFormat, IXLStylized
  {
    private IXLStyle _style;
    private int _styleCacheId;

    public XLConditionalFormat(XLRange range, bool copyDefaultModify = false)
    {
      this.Range = (IXLRange) range;
      this.Style = (IXLStyle) new XLStyle((IXLStylized) this, range.Worksheet.Style, true);
      this.Values = new XLDictionary<XLFormula>();
      this.Colors = new XLDictionary<XLColor>();
      this.ContentTypes = new XLDictionary<XLCFContentType>();
      this.IconSetOperators = new XLDictionary<XLCFIconSetOperator>();
      this.CopyDefaultModify = copyDefaultModify;
    }

    public XLConditionalFormat(XLConditionalFormat other)
    {
      this.Range = other.Range;
      this.Style = (IXLStyle) new XLStyle((IXLStylized) this, other.Style, true);
      this.Values = new XLDictionary<XLFormula>(other.Values);
      this.Colors = new XLDictionary<XLColor>(other.Colors);
      this.ContentTypes = new XLDictionary<XLCFContentType>(other.ContentTypes);
      this.IconSetOperators = new XLDictionary<XLCFIconSetOperator>(other.IconSetOperators);
      this.ConditionalFormatType = other.ConditionalFormatType;
      this.TimePeriod = other.TimePeriod;
      this.IconSetStyle = other.IconSetStyle;
      this.Operator = other.Operator;
      this.Bottom = other.Bottom;
      this.Percent = other.Percent;
      this.ReverseIconOrder = other.ReverseIconOrder;
      this.ShowIconOnly = other.ShowIconOnly;
      this.ShowBarOnly = other.ShowBarOnly;
    }

    public bool CopyDefaultModify { get; set; }

    public IXLStyle Style
    {
      get
      {
        return this.GetStyle();
      }
      set
      {
        this.SetStyle(value);
      }
    }

    private IXLStyle GetStyle()
    {
      if (this._style != null)
        return this._style;
      return this._style = (IXLStyle) new XLStyle((IXLStylized) this, this.Range.Worksheet.Workbook.GetStyleById(this._styleCacheId), this.CopyDefaultModify);
    }

    private void SetStyle(IXLStyle styleToUse)
    {
      this._styleCacheId = this.Range.Worksheet.Workbook.GetStyleId(styleToUse);
      this._style = (IXLStyle) null;
      this.StyleChanged = false;
    }

    public IEnumerable<IXLStyle> Styles
    {
      get
      {
        this.UpdatingStyle = true;
        yield return this.Style;
        this.UpdatingStyle = false;
      }
    }

    public bool UpdatingStyle { get; set; }

    public IXLStyle InnerStyle { get; set; }

    public IXLRanges RangesUsed
    {
      get
      {
        return (IXLRanges) new XLRanges();
      }
    }

    public bool StyleChanged { get; set; }

    public XLDictionary<XLFormula> Values { get; private set; }

    public XLDictionary<XLColor> Colors { get; private set; }

    public XLDictionary<XLCFContentType> ContentTypes { get; private set; }

    public XLDictionary<XLCFIconSetOperator> IconSetOperators { get; private set; }

    public IXLRange Range { get; set; }

    public XLConditionalFormatType ConditionalFormatType { get; set; }

    public XLTimePeriod TimePeriod { get; set; }

    public XLIconSetStyle IconSetStyle { get; set; }

    public XLCFOperator Operator { get; set; }

    public bool Bottom { get; set; }

    public bool Percent { get; set; }

    public bool ReverseIconOrder { get; set; }

    public bool ShowIconOnly { get; set; }

    public bool ShowBarOnly { get; set; }

    public void CopyFrom(IXLConditionalFormat other)
    {
      this.Style = other.Style;
      this.ConditionalFormatType = other.ConditionalFormatType;
      this.TimePeriod = other.TimePeriod;
      this.IconSetStyle = other.IconSetStyle;
      this.Operator = other.Operator;
      this.Bottom = other.Bottom;
      this.Percent = other.Percent;
      this.ReverseIconOrder = other.ReverseIconOrder;
      this.ShowIconOnly = other.ShowIconOnly;
      this.ShowBarOnly = other.ShowBarOnly;
      this.Values.Clear();
      other.Values.ForEach<KeyValuePair<int, XLFormula>>((Action<KeyValuePair<int, XLFormula>>) (kp => this.Values.Add(kp.Key, new XLFormula(kp.Value))));
      this.CopyDictionary<XLColor>(this.Colors, other.Colors);
      this.CopyDictionary<XLCFContentType>(this.ContentTypes, other.ContentTypes);
      this.CopyDictionary<XLCFIconSetOperator>(this.IconSetOperators, other.IconSetOperators);
    }

    private void CopyDictionary<T>(XLDictionary<T> target, XLDictionary<T> source)
    {
      target.Clear();
      source.ForEach<KeyValuePair<int, T>>((Action<KeyValuePair<int, T>>) (kp => ((Dictionary<int, T>) target).Add(kp.Key, kp.Value)));
    }

    public IXLStyle WhenIsBlank()
    {
      this.ConditionalFormatType = XLConditionalFormatType.IsBlank;
      return this.Style;
    }

    public IXLStyle WhenNotBlank()
    {
      this.ConditionalFormatType = XLConditionalFormatType.NotBlank;
      return this.Style;
    }

    public IXLStyle WhenIsError()
    {
      this.ConditionalFormatType = XLConditionalFormatType.IsError;
      return this.Style;
    }

    public IXLStyle WhenNotError()
    {
      this.ConditionalFormatType = XLConditionalFormatType.NotError;
      return this.Style;
    }

    public IXLStyle WhenDateIs(XLTimePeriod timePeriod)
    {
      this.TimePeriod = timePeriod;
      this.ConditionalFormatType = XLConditionalFormatType.TimePeriod;
      return this.Style;
    }

    public IXLStyle WhenContains(string value)
    {
      this.Values.Initialize(new XLFormula()
      {
        Value = value
      });
      this.ConditionalFormatType = XLConditionalFormatType.ContainsText;
      this.Operator = XLCFOperator.Contains;
      return this.Style;
    }

    public IXLStyle WhenNotContains(string value)
    {
      this.Values.Initialize(new XLFormula()
      {
        Value = value
      });
      this.ConditionalFormatType = XLConditionalFormatType.NotContainsText;
      this.Operator = XLCFOperator.NotContains;
      return this.Style;
    }

    public IXLStyle WhenStartsWith(string value)
    {
      this.Values.Initialize(new XLFormula()
      {
        Value = value
      });
      this.ConditionalFormatType = XLConditionalFormatType.StartsWith;
      this.Operator = XLCFOperator.StartsWith;
      return this.Style;
    }

    public IXLStyle WhenEndsWith(string value)
    {
      this.Values.Initialize(new XLFormula()
      {
        Value = value
      });
      this.ConditionalFormatType = XLConditionalFormatType.EndsWith;
      this.Operator = XLCFOperator.EndsWith;
      return this.Style;
    }

    public IXLStyle WhenEquals(string value)
    {
      this.Values.Initialize(new XLFormula()
      {
        Value = value
      });
      this.Operator = XLCFOperator.Equal;
      this.ConditionalFormatType = XLConditionalFormatType.CellIs;
      return this.Style;
    }

    public IXLStyle WhenNotEquals(string value)
    {
      this.Values.Initialize(new XLFormula()
      {
        Value = value
      });
      this.Operator = XLCFOperator.NotEqual;
      this.ConditionalFormatType = XLConditionalFormatType.CellIs;
      return this.Style;
    }

    public IXLStyle WhenGreaterThan(string value)
    {
      this.Values.Initialize(new XLFormula()
      {
        Value = value
      });
      this.Operator = XLCFOperator.GreaterThan;
      this.ConditionalFormatType = XLConditionalFormatType.CellIs;
      return this.Style;
    }

    public IXLStyle WhenLessThan(string value)
    {
      this.Values.Initialize(new XLFormula()
      {
        Value = value
      });
      this.Operator = XLCFOperator.LessThan;
      this.ConditionalFormatType = XLConditionalFormatType.CellIs;
      return this.Style;
    }

    public IXLStyle WhenEqualOrGreaterThan(string value)
    {
      this.Values.Initialize(new XLFormula()
      {
        Value = value
      });
      this.Operator = XLCFOperator.EqualOrGreaterThan;
      this.ConditionalFormatType = XLConditionalFormatType.CellIs;
      return this.Style;
    }

    public IXLStyle WhenEqualOrLessThan(string value)
    {
      this.Values.Initialize(new XLFormula()
      {
        Value = value
      });
      this.Operator = XLCFOperator.EqualOrLessThan;
      this.ConditionalFormatType = XLConditionalFormatType.CellIs;
      return this.Style;
    }

    public IXLStyle WhenBetween(string minValue, string maxValue)
    {
      this.Values.Initialize(new XLFormula()
      {
        Value = minValue
      });
      this.Values.Add(new XLFormula() { Value = maxValue });
      this.Operator = XLCFOperator.Between;
      this.ConditionalFormatType = XLConditionalFormatType.CellIs;
      return this.Style;
    }

    public IXLStyle WhenNotBetween(string minValue, string maxValue)
    {
      this.Values.Initialize(new XLFormula()
      {
        Value = minValue
      });
      this.Values.Add(new XLFormula() { Value = maxValue });
      this.Operator = XLCFOperator.NotBetween;
      this.ConditionalFormatType = XLConditionalFormatType.CellIs;
      return this.Style;
    }

    public IXLStyle WhenEquals(double value)
    {
      this.Values.Initialize(new XLFormula(value));
      this.Operator = XLCFOperator.Equal;
      this.ConditionalFormatType = XLConditionalFormatType.CellIs;
      return this.Style;
    }

    public IXLStyle WhenNotEquals(double value)
    {
      this.Values.Initialize(new XLFormula(value));
      this.Operator = XLCFOperator.NotEqual;
      this.ConditionalFormatType = XLConditionalFormatType.CellIs;
      return this.Style;
    }

    public IXLStyle WhenGreaterThan(double value)
    {
      this.Values.Initialize(new XLFormula(value));
      this.Operator = XLCFOperator.GreaterThan;
      this.ConditionalFormatType = XLConditionalFormatType.CellIs;
      return this.Style;
    }

    public IXLStyle WhenLessThan(double value)
    {
      this.Values.Initialize(new XLFormula(value));
      this.Operator = XLCFOperator.LessThan;
      this.ConditionalFormatType = XLConditionalFormatType.CellIs;
      return this.Style;
    }

    public IXLStyle WhenEqualOrGreaterThan(double value)
    {
      this.Values.Initialize(new XLFormula(value));
      this.Operator = XLCFOperator.EqualOrGreaterThan;
      this.ConditionalFormatType = XLConditionalFormatType.CellIs;
      return this.Style;
    }

    public IXLStyle WhenEqualOrLessThan(double value)
    {
      this.Values.Initialize(new XLFormula(value));
      this.Operator = XLCFOperator.EqualOrLessThan;
      this.ConditionalFormatType = XLConditionalFormatType.CellIs;
      return this.Style;
    }

    public IXLStyle WhenBetween(double minValue, double maxValue)
    {
      this.Values.Initialize(new XLFormula(minValue));
      this.Values.Add(new XLFormula(maxValue));
      this.Operator = XLCFOperator.Between;
      this.ConditionalFormatType = XLConditionalFormatType.CellIs;
      return this.Style;
    }

    public IXLStyle WhenNotBetween(double minValue, double maxValue)
    {
      this.Values.Initialize(new XLFormula(minValue));
      this.Values.Add(new XLFormula(maxValue));
      this.Operator = XLCFOperator.NotBetween;
      this.ConditionalFormatType = XLConditionalFormatType.CellIs;
      return this.Style;
    }

    public IXLStyle WhenIsDuplicate()
    {
      this.ConditionalFormatType = XLConditionalFormatType.IsDuplicate;
      return this.Style;
    }

    public IXLStyle WhenIsUnique()
    {
      this.ConditionalFormatType = XLConditionalFormatType.IsUnique;
      return this.Style;
    }

    public IXLStyle WhenIsTrue(string formula)
    {
      string str = (int) formula.TrimStart()[0] == 61 ? formula : "=" + formula;
      this.Values.Initialize(new XLFormula() { Value = str });
      this.ConditionalFormatType = XLConditionalFormatType.Expression;
      return this.Style;
    }

    public IXLStyle WhenIsTop(int value, XLTopBottomType topBottomType = XLTopBottomType.Items)
    {
      this.Values.Initialize(new XLFormula(value));
      this.Percent = topBottomType == XLTopBottomType.Percent;
      this.ConditionalFormatType = XLConditionalFormatType.Top10;
      this.Bottom = false;
      return this.Style;
    }

    public IXLStyle WhenIsBottom(int value, XLTopBottomType topBottomType = XLTopBottomType.Items)
    {
      this.Values.Initialize(new XLFormula(value));
      this.Percent = topBottomType == XLTopBottomType.Percent;
      this.ConditionalFormatType = XLConditionalFormatType.Top10;
      this.Bottom = true;
      return this.Style;
    }

    public IXLCFColorScaleMin ColorScale()
    {
      this.ConditionalFormatType = XLConditionalFormatType.ColorScale;
      return (IXLCFColorScaleMin) new XLCFColorScaleMin(this);
    }

    public IXLCFDataBarMin DataBar(XLColor color, bool showBarOnly = false)
    {
      this.Colors.Initialize(color);
      this.ShowBarOnly = showBarOnly;
      this.ConditionalFormatType = XLConditionalFormatType.DataBar;
      return (IXLCFDataBarMin) new XLCFDataBarMin(this);
    }

    public IXLCFIconSet IconSet(XLIconSetStyle iconSetStyle, bool reverseIconOrder = false, bool showIconOnly = false)
    {
      this.IconSetOperators.Clear();
      this.Values.Clear();
      this.ContentTypes.Clear();
      this.ConditionalFormatType = XLConditionalFormatType.IconSet;
      this.IconSetStyle = iconSetStyle;
      this.ReverseIconOrder = reverseIconOrder;
      this.ShowIconOnly = showIconOnly;
      return (IXLCFIconSet) new XLCFIconSet(this);
    }
  }
}

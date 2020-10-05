// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLFill
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Text;

namespace ClosedXML.Excel
{
  internal class XLFill : IXLFill, IEquatable<IXLFill>
  {
    private XLColor _patternBackgroundColor;
    private XLColor _patternColor;
    private XLFillPatternValues _patternType;
    public bool PatternColorModified;
    public bool PatternBackgroundColorModified;
    public bool PatternTypeModified;
    private readonly IXLStylized _container;

    public bool Equals(IXLFill other)
    {
      if (this._patternType == other.PatternType && this._patternColor.Equals(other.PatternColor))
        return this._patternBackgroundColor.Equals(other.PatternBackgroundColor);
      return false;
    }

    private void SetStyleChanged()
    {
      if (this._container == null)
        return;
      this._container.StyleChanged = true;
    }

    public override bool Equals(object obj)
    {
      return this.Equals((IXLFill) obj);
    }

    public override int GetHashCode()
    {
      return (int) ((XLFillPatternValues) this.BackgroundColor.GetHashCode() ^ this.PatternType ^ (XLFillPatternValues) this.PatternColor.GetHashCode());
    }

    public XLColor BackgroundColor
    {
      get
      {
        return this._patternColor;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
        {
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Fill.BackgroundColor = value));
        }
        else
        {
          this._patternType = value.HasValue ? XLFillPatternValues.Solid : XLFillPatternValues.None;
          this._patternColor = value;
          this._patternBackgroundColor = value;
          this.PatternTypeModified = true;
          this.PatternColorModified = true;
          this.PatternBackgroundColorModified = true;
        }
      }
    }

    public XLColor PatternColor
    {
      get
      {
        return this._patternColor;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
        {
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Fill.PatternColor = value));
        }
        else
        {
          this._patternColor = value;
          this.PatternColorModified = true;
        }
      }
    }

    public XLColor PatternBackgroundColor
    {
      get
      {
        return this._patternBackgroundColor;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
        {
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Fill.PatternBackgroundColor = value));
        }
        else
        {
          this._patternBackgroundColor = value;
          this.PatternBackgroundColorModified = true;
        }
      }
    }

    public XLFillPatternValues PatternType
    {
      get
      {
        return this._patternType;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
        {
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Fill.PatternType = value));
        }
        else
        {
          this._patternType = value;
          this.PatternTypeModified = true;
        }
      }
    }

    public IXLStyle SetBackgroundColor(XLColor value)
    {
      this.BackgroundColor = value;
      return this._container.Style;
    }

    public IXLStyle SetPatternColor(XLColor value)
    {
      this.PatternColor = value;
      return this._container.Style;
    }

    public IXLStyle SetPatternBackgroundColor(XLColor value)
    {
      this.PatternBackgroundColor = value;
      return this._container.Style;
    }

    public IXLStyle SetPatternType(XLFillPatternValues value)
    {
      this.PatternType = value;
      return this._container.Style;
    }

    public XLFill()
      : this((IXLStylized) null, XLWorkbook.DefaultStyle.Fill, true)
    {
    }

    public XLFill(IXLStylized container, IXLFill defaultFill = null, bool useDefaultModify = true)
    {
      this._container = container;
      if (defaultFill == null)
        return;
      this._patternType = defaultFill.PatternType;
      this._patternColor = defaultFill.PatternColor;
      this._patternBackgroundColor = defaultFill.PatternBackgroundColor;
      if (!useDefaultModify)
        return;
      XLFill xlFill = defaultFill as XLFill;
      this.PatternBackgroundColorModified = xlFill.PatternBackgroundColorModified;
      this.PatternColorModified = xlFill.PatternColorModified;
      this.PatternTypeModified = xlFill.PatternTypeModified;
    }

    public override string ToString()
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append((object) this.BackgroundColor);
      stringBuilder.Append("-");
      stringBuilder.Append(this.PatternType.ToString());
      stringBuilder.Append("-");
      stringBuilder.Append((object) this.PatternColor);
      return stringBuilder.ToString();
    }
  }
}

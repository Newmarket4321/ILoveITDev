// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLNumberFormat
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;

namespace ClosedXML.Excel
{
  internal class XLNumberFormat : IXLNumberFormat, IXLNumberFormatBase, IEquatable<IXLNumberFormat>
  {
    private string _format = string.Empty;
    private readonly IXLStylized _container;
    private int _numberFormatId;

    public bool Equals(IXLNumberFormat other)
    {
      XLNumberFormat xlNumberFormat = other as XLNumberFormat;
      if (this._numberFormatId == xlNumberFormat._numberFormatId)
        return this._format == xlNumberFormat._format;
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
      return this.Equals((IXLNumberFormat) obj);
    }

    public override int GetHashCode()
    {
      return this.NumberFormatId ^ this.Format.GetHashCode();
    }

    public int NumberFormatId
    {
      get
      {
        return this._numberFormatId;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
        {
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.NumberFormat.NumberFormatId = value));
        }
        else
        {
          this._numberFormatId = value;
          this._format = string.Empty;
        }
      }
    }

    public string Format
    {
      get
      {
        return this._format;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
        {
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.NumberFormat.Format = value));
        }
        else
        {
          this._format = value;
          this._numberFormatId = -1;
        }
      }
    }

    public IXLStyle SetNumberFormatId(int value)
    {
      this.NumberFormatId = value;
      return this._container.Style;
    }

    public IXLStyle SetFormat(string value)
    {
      this.Format = value;
      return this._container.Style;
    }

    public XLNumberFormat()
      : this((IXLStylized) null, XLWorkbook.DefaultStyle.NumberFormat)
    {
    }

    public XLNumberFormat(IXLStylized container, IXLNumberFormat defaultNumberFormat)
    {
      this._container = container;
      if (defaultNumberFormat == null)
        return;
      this._numberFormatId = defaultNumberFormat.NumberFormatId;
      this._format = defaultNumberFormat.Format;
    }

    public override string ToString()
    {
      return this._numberFormatId.ToString() + "-" + this._format;
    }
  }
}

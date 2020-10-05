// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLStyle
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Text;

namespace ClosedXML.Excel
{
  internal class XLStyle : IXLStyle, IEquatable<IXLStyle>
  {
    private IXLNumberFormat numberFormat;

    public XLStyle(IXLStylized container, IXLStyle initialStyle = null, bool useDefaultModify = true)
    {
      if (initialStyle != null)
      {
        this.Font = (IXLFont) new XLFont(container, (IXLFontBase) initialStyle.Font, useDefaultModify);
        this.Alignment = (IXLAlignment) new XLAlignment(container, initialStyle.Alignment);
        this.Border = (IXLBorder) new XLBorder(container, initialStyle.Border, useDefaultModify);
        this.Fill = (IXLFill) new XLFill(container, initialStyle.Fill, useDefaultModify);
        this.NumberFormat = (IXLNumberFormat) new XLNumberFormat(container, initialStyle.NumberFormat);
        this.Protection = (IXLProtection) new XLProtection(container, initialStyle.Protection);
      }
      else
      {
        this.Font = (IXLFont) new XLFont(container, (IXLFontBase) null, true);
        this.Alignment = (IXLAlignment) new XLAlignment(container, (IXLAlignment) null);
        this.Border = (IXLBorder) new XLBorder(container, (IXLBorder) null, true);
        this.Fill = (IXLFill) new XLFill(container, (IXLFill) null, true);
        this.NumberFormat = (IXLNumberFormat) new XLNumberFormat(container, (IXLNumberFormat) null);
        this.Protection = (IXLProtection) new XLProtection(container, (IXLProtection) null);
      }
      this.DateFormat = this.NumberFormat;
    }

    public IXLFont Font { get; set; }

    public IXLAlignment Alignment { get; set; }

    public IXLBorder Border { get; set; }

    public IXLFill Fill { get; set; }

    public IXLNumberFormat NumberFormat
    {
      get
      {
        return this.numberFormat;
      }
      set
      {
        this.numberFormat = value;
        this.DateFormat = this.numberFormat;
      }
    }

    public IXLProtection Protection { get; set; }

    public IXLNumberFormat DateFormat { get; private set; }

    public override string ToString()
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append("Font:");
      stringBuilder.Append((object) this.Font);
      stringBuilder.Append(" Fill:");
      stringBuilder.Append((object) this.Fill);
      stringBuilder.Append(" Border:");
      stringBuilder.Append((object) this.Border);
      stringBuilder.Append(" NumberFormat: ");
      stringBuilder.Append((object) this.NumberFormat);
      stringBuilder.Append(" Alignment: ");
      stringBuilder.Append((object) this.Alignment);
      stringBuilder.Append(" Protection: ");
      stringBuilder.Append((object) this.Protection);
      return stringBuilder.ToString();
    }

    public bool Equals(IXLStyle other)
    {
      if (this.Font.Equals(other.Font) && this.Fill.Equals(other.Fill) && (this.Border.Equals(other.Border) && this.NumberFormat.Equals(other.NumberFormat)) && this.Alignment.Equals(other.Alignment))
        return this.Protection.Equals(other.Protection);
      return false;
    }

    public override bool Equals(object obj)
    {
      return this.Equals((IXLStyle) obj);
    }

    public override int GetHashCode()
    {
      return this.Font.GetHashCode() ^ this.Fill.GetHashCode() ^ this.Border.GetHashCode() ^ this.NumberFormat.GetHashCode() ^ this.Alignment.GetHashCode() ^ this.Protection.GetHashCode();
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLMargins
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  internal class XLMargins : IXLMargins
  {
    public double Left { get; set; }

    public double Right { get; set; }

    public double Top { get; set; }

    public double Bottom { get; set; }

    public double Header { get; set; }

    public double Footer { get; set; }

    public IXLMargins SetLeft(double value)
    {
      this.Left = value;
      return (IXLMargins) this;
    }

    public IXLMargins SetRight(double value)
    {
      this.Right = value;
      return (IXLMargins) this;
    }

    public IXLMargins SetTop(double value)
    {
      this.Top = value;
      return (IXLMargins) this;
    }

    public IXLMargins SetBottom(double value)
    {
      this.Bottom = value;
      return (IXLMargins) this;
    }

    public IXLMargins SetHeader(double value)
    {
      this.Header = value;
      return (IXLMargins) this;
    }

    public IXLMargins SetFooter(double value)
    {
      this.Footer = value;
      return (IXLMargins) this;
    }
  }
}

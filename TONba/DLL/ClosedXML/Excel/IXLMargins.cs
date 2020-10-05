// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLMargins
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  public interface IXLMargins
  {
    double Left { get; set; }

    double Right { get; set; }

    double Top { get; set; }

    double Bottom { get; set; }

    double Header { get; set; }

    double Footer { get; set; }

    IXLMargins SetLeft(double value);

    IXLMargins SetRight(double value);

    IXLMargins SetTop(double value);

    IXLMargins SetBottom(double value);

    IXLMargins SetHeader(double value);

    IXLMargins SetFooter(double value);
  }
}

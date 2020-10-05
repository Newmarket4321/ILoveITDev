// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLDrawingMargins
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  public interface IXLDrawingMargins
  {
    bool Automatic { get; set; }

    double Left { get; set; }

    double Right { get; set; }

    double Top { get; set; }

    double Bottom { get; set; }

    double All { set; }

    IXLDrawingStyle SetAutomatic();

    IXLDrawingStyle SetAutomatic(bool value);

    IXLDrawingStyle SetLeft(double value);

    IXLDrawingStyle SetRight(double value);

    IXLDrawingStyle SetTop(double value);

    IXLDrawingStyle SetBottom(double value);

    IXLDrawingStyle SetAll(double value);
  }
}

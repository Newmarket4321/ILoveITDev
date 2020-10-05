// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLDrawingColorsAndLines
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  public interface IXLDrawingColorsAndLines
  {
    XLColor FillColor { get; set; }

    double FillTransparency { get; set; }

    XLColor LineColor { get; set; }

    double LineTransparency { get; set; }

    double LineWeight { get; set; }

    XLDashStyle LineDash { get; set; }

    XLLineStyle LineStyle { get; set; }

    IXLDrawingStyle SetFillColor(XLColor value);

    IXLDrawingStyle SetFillTransparency(double value);

    IXLDrawingStyle SetLineColor(XLColor value);

    IXLDrawingStyle SetLineTransparency(double value);

    IXLDrawingStyle SetLineWeight(double value);

    IXLDrawingStyle SetLineDash(XLDashStyle value);

    IXLDrawingStyle SetLineStyle(XLLineStyle value);
  }
}

// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLDrawingColorsAndLines
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  internal class XLDrawingColorsAndLines : IXLDrawingColorsAndLines
  {
    private readonly IXLDrawingStyle _style;

    public XLDrawingColorsAndLines(IXLDrawingStyle style)
    {
      this._style = style;
    }

    public XLColor FillColor { get; set; }

    public IXLDrawingStyle SetFillColor(XLColor value)
    {
      this.FillColor = value;
      return this._style;
    }

    public double FillTransparency { get; set; }

    public IXLDrawingStyle SetFillTransparency(double value)
    {
      this.FillTransparency = value;
      return this._style;
    }

    public XLColor LineColor { get; set; }

    public IXLDrawingStyle SetLineColor(XLColor value)
    {
      this.LineColor = value;
      return this._style;
    }

    public double LineTransparency { get; set; }

    public IXLDrawingStyle SetLineTransparency(double value)
    {
      this.LineTransparency = value;
      return this._style;
    }

    public double LineWeight { get; set; }

    public IXLDrawingStyle SetLineWeight(double value)
    {
      this.LineWeight = value;
      return this._style;
    }

    public XLDashStyle LineDash { get; set; }

    public IXLDrawingStyle SetLineDash(XLDashStyle value)
    {
      this.LineDash = value;
      return this._style;
    }

    public XLLineStyle LineStyle { get; set; }

    public IXLDrawingStyle SetLineStyle(XLLineStyle value)
    {
      this.LineStyle = value;
      return this._style;
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLDrawingWeb
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  internal class XLDrawingWeb : IXLDrawingWeb
  {
    private readonly IXLDrawingStyle _style;

    public XLDrawingWeb(IXLDrawingStyle style)
    {
      this._style = style;
    }

    public string AlternateText { get; set; }

    public IXLDrawingStyle SetAlternateText(string value)
    {
      this.AlternateText = value;
      return this._style;
    }
  }
}

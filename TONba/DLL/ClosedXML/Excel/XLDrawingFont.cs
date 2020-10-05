// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLDrawingFont
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  internal class XLDrawingFont : IXLDrawingFont, IXLFontBase
  {
    private readonly IXLDrawingStyle _style;

    public XLDrawingFont(IXLDrawingStyle style)
    {
      this._style = style;
      this.FontName = "Tahoma";
      this.FontSize = 9.0;
      this.Underline = XLFontUnderlineValues.None;
      this.FontColor = XLColor.FromIndex(64);
    }

    public bool Bold { get; set; }

    public bool Italic { get; set; }

    public XLFontUnderlineValues Underline { get; set; }

    public bool Strikethrough { get; set; }

    public XLFontVerticalTextAlignmentValues VerticalAlignment { get; set; }

    public bool Shadow { get; set; }

    public double FontSize { get; set; }

    public XLColor FontColor { get; set; }

    public string FontName { get; set; }

    public XLFontFamilyNumberingValues FontFamilyNumbering { get; set; }

    public IXLDrawingStyle SetBold()
    {
      this.Bold = true;
      return this._style;
    }

    public IXLDrawingStyle SetBold(bool value)
    {
      this.Bold = value;
      return this._style;
    }

    public IXLDrawingStyle SetItalic()
    {
      this.Italic = true;
      return this._style;
    }

    public IXLDrawingStyle SetItalic(bool value)
    {
      this.Italic = value;
      return this._style;
    }

    public IXLDrawingStyle SetUnderline()
    {
      this.Underline = XLFontUnderlineValues.Single;
      return this._style;
    }

    public IXLDrawingStyle SetUnderline(XLFontUnderlineValues value)
    {
      this.Underline = value;
      return this._style;
    }

    public IXLDrawingStyle SetStrikethrough()
    {
      this.Strikethrough = true;
      return this._style;
    }

    public IXLDrawingStyle SetStrikethrough(bool value)
    {
      this.Strikethrough = value;
      return this._style;
    }

    public IXLDrawingStyle SetVerticalAlignment(XLFontVerticalTextAlignmentValues value)
    {
      this.VerticalAlignment = value;
      return this._style;
    }

    public IXLDrawingStyle SetShadow()
    {
      this.Shadow = true;
      return this._style;
    }

    public IXLDrawingStyle SetShadow(bool value)
    {
      this.Shadow = value;
      return this._style;
    }

    public IXLDrawingStyle SetFontSize(double value)
    {
      this.FontSize = value;
      return this._style;
    }

    public IXLDrawingStyle SetFontColor(XLColor value)
    {
      this.FontColor = value;
      return this._style;
    }

    public IXLDrawingStyle SetFontName(string value)
    {
      this.FontName = value;
      return this._style;
    }

    public IXLDrawingStyle SetFontFamilyNumbering(XLFontFamilyNumberingValues value)
    {
      this.FontFamilyNumbering = value;
      return this._style;
    }
  }
}

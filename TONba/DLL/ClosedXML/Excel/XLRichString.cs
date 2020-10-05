// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLRichString
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;

namespace ClosedXML.Excel
{
  internal class XLRichString : IXLRichString, IXLFontBase, IEquatable<IXLRichString>, IXLWithRichString
  {
    private IXLWithRichString _withRichString;

    public XLRichString(string text, IXLFontBase font, IXLWithRichString withRichString)
    {
      this.Text = text;
      this.CopyFont(font);
      this._withRichString = withRichString;
    }

    public string Text { get; set; }

    public IXLRichString AddText(string text)
    {
      return this._withRichString.AddText(text);
    }

    public IXLRichString AddNewLine()
    {
      return this.AddText(Environment.NewLine);
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

    public IXLRichString SetBold()
    {
      this.Bold = true;
      return (IXLRichString) this;
    }

    public IXLRichString SetBold(bool value)
    {
      this.Bold = value;
      return (IXLRichString) this;
    }

    public IXLRichString SetItalic()
    {
      this.Italic = true;
      return (IXLRichString) this;
    }

    public IXLRichString SetItalic(bool value)
    {
      this.Italic = value;
      return (IXLRichString) this;
    }

    public IXLRichString SetUnderline()
    {
      this.Underline = XLFontUnderlineValues.Single;
      return (IXLRichString) this;
    }

    public IXLRichString SetUnderline(XLFontUnderlineValues value)
    {
      this.Underline = value;
      return (IXLRichString) this;
    }

    public IXLRichString SetStrikethrough()
    {
      this.Strikethrough = true;
      return (IXLRichString) this;
    }

    public IXLRichString SetStrikethrough(bool value)
    {
      this.Strikethrough = value;
      return (IXLRichString) this;
    }

    public IXLRichString SetVerticalAlignment(XLFontVerticalTextAlignmentValues value)
    {
      this.VerticalAlignment = value;
      return (IXLRichString) this;
    }

    public IXLRichString SetShadow()
    {
      this.Shadow = true;
      return (IXLRichString) this;
    }

    public IXLRichString SetShadow(bool value)
    {
      this.Shadow = value;
      return (IXLRichString) this;
    }

    public IXLRichString SetFontSize(double value)
    {
      this.FontSize = value;
      return (IXLRichString) this;
    }

    public IXLRichString SetFontColor(XLColor value)
    {
      this.FontColor = value;
      return (IXLRichString) this;
    }

    public IXLRichString SetFontName(string value)
    {
      this.FontName = value;
      return (IXLRichString) this;
    }

    public IXLRichString SetFontFamilyNumbering(XLFontFamilyNumberingValues value)
    {
      this.FontFamilyNumbering = value;
      return (IXLRichString) this;
    }

    public bool Equals(IXLRichString other)
    {
      if (this.Text == other.Text && this.Bold.Equals(other.Bold) && (this.Italic.Equals(other.Italic) && this.Underline.Equals((object) other.Underline) && (this.Strikethrough.Equals(other.Strikethrough) && this.VerticalAlignment.Equals((object) other.VerticalAlignment))) && (this.Shadow.Equals(other.Shadow) && (this.FontSize.Equals(other.FontSize) && this.FontColor.Equals(other.FontColor) && this.FontName.Equals(other.FontName))))
        return this.FontFamilyNumbering.Equals((object) other.FontFamilyNumbering);
      return false;
    }

    public override bool Equals(object obj)
    {
      return this.Equals((IXLRichString) obj);
    }

    public override int GetHashCode()
    {
      return (int) ((XLFontFamilyNumberingValues) ((XLFontVerticalTextAlignmentValues) ((XLFontUnderlineValues) (this.Text.GetHashCode() ^ this.Bold.GetHashCode() ^ this.Italic.GetHashCode()) ^ this.Underline ^ (XLFontUnderlineValues) this.Strikethrough.GetHashCode()) ^ this.VerticalAlignment ^ (XLFontVerticalTextAlignmentValues) this.Shadow.GetHashCode() ^ (XLFontVerticalTextAlignmentValues) this.FontSize.GetHashCode() ^ (XLFontVerticalTextAlignmentValues) this.FontColor.GetHashCode() ^ (XLFontVerticalTextAlignmentValues) this.FontName.GetHashCode()) ^ this.FontFamilyNumbering);
    }
  }
}

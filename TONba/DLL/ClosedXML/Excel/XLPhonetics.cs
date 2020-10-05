// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLPhonetics
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ClosedXML.Excel
{
  internal class XLPhonetics : IXLPhonetics, IXLFontBase, IEnumerable<IXLPhonetic>, IEnumerable, IEquatable<IXLPhonetics>
  {
    private readonly List<IXLPhonetic> _phonetics = new List<IXLPhonetic>();
    private readonly IXLFontBase _defaultFont;

    public XLPhonetics(IXLFontBase defaultFont)
    {
      this._defaultFont = defaultFont;
      this.Type = XLPhoneticType.FullWidthKatakana;
      this.Alignment = XLPhoneticAlignment.Left;
      this.CopyFont(this._defaultFont);
    }

    public XLPhonetics(IXLPhonetics defaultPhonetics, IXLFontBase defaultFont)
    {
      this._defaultFont = defaultFont;
      this.Type = defaultPhonetics.Type;
      this.Alignment = defaultPhonetics.Alignment;
      this.CopyFont((IXLFontBase) defaultPhonetics);
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

    public IXLPhonetics SetBold()
    {
      this.Bold = true;
      return (IXLPhonetics) this;
    }

    public IXLPhonetics SetBold(bool value)
    {
      this.Bold = value;
      return (IXLPhonetics) this;
    }

    public IXLPhonetics SetItalic()
    {
      this.Italic = true;
      return (IXLPhonetics) this;
    }

    public IXLPhonetics SetItalic(bool value)
    {
      this.Italic = value;
      return (IXLPhonetics) this;
    }

    public IXLPhonetics SetUnderline()
    {
      this.Underline = XLFontUnderlineValues.Single;
      return (IXLPhonetics) this;
    }

    public IXLPhonetics SetUnderline(XLFontUnderlineValues value)
    {
      this.Underline = value;
      return (IXLPhonetics) this;
    }

    public IXLPhonetics SetStrikethrough()
    {
      this.Strikethrough = true;
      return (IXLPhonetics) this;
    }

    public IXLPhonetics SetStrikethrough(bool value)
    {
      this.Strikethrough = value;
      return (IXLPhonetics) this;
    }

    public IXLPhonetics SetVerticalAlignment(XLFontVerticalTextAlignmentValues value)
    {
      this.VerticalAlignment = value;
      return (IXLPhonetics) this;
    }

    public IXLPhonetics SetShadow()
    {
      this.Shadow = true;
      return (IXLPhonetics) this;
    }

    public IXLPhonetics SetShadow(bool value)
    {
      this.Shadow = value;
      return (IXLPhonetics) this;
    }

    public IXLPhonetics SetFontSize(double value)
    {
      this.FontSize = value;
      return (IXLPhonetics) this;
    }

    public IXLPhonetics SetFontColor(XLColor value)
    {
      this.FontColor = value;
      return (IXLPhonetics) this;
    }

    public IXLPhonetics SetFontName(string value)
    {
      this.FontName = value;
      return (IXLPhonetics) this;
    }

    public IXLPhonetics SetFontFamilyNumbering(XLFontFamilyNumberingValues value)
    {
      this.FontFamilyNumbering = value;
      return (IXLPhonetics) this;
    }

    public IXLPhonetics Add(string text, int start, int end)
    {
      this._phonetics.Add((IXLPhonetic) new XLPhonetic(text, start, end));
      return (IXLPhonetics) this;
    }

    public IXLPhonetics ClearText()
    {
      this._phonetics.Clear();
      return (IXLPhonetics) this;
    }

    public IXLPhonetics ClearFont()
    {
      this.CopyFont(this._defaultFont);
      return (IXLPhonetics) this;
    }

    public int Count
    {
      get
      {
        return this._phonetics.Count;
      }
    }

    public XLPhoneticAlignment Alignment { get; set; }

    public XLPhoneticType Type { get; set; }

    public IXLPhonetics SetAlignment(XLPhoneticAlignment phoneticAlignment)
    {
      this.Alignment = phoneticAlignment;
      return (IXLPhonetics) this;
    }

    public IXLPhonetics SetType(XLPhoneticType phoneticType)
    {
      this.Type = phoneticType;
      return (IXLPhonetics) this;
    }

    public IEnumerator<IXLPhonetic> GetEnumerator()
    {
      return (IEnumerator<IXLPhonetic>) this._phonetics.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return (IEnumerator) this.GetEnumerator();
    }

    public bool Equals(IXLPhonetics other)
    {
      if (other == null)
        return false;
      int count = this._phonetics.Count;
      for (int index = 0; index < count; ++index)
      {
        if (!this._phonetics[index].Equals(other.ElementAt<IXLPhonetic>(index)))
          return false;
      }
      if (this.Bold == other.Bold && this.Italic == other.Italic && (this.Underline == other.Underline && this.Strikethrough == other.Strikethrough) && (this.VerticalAlignment == other.VerticalAlignment && this.Shadow == other.Shadow && (this.FontSize == other.FontSize && this.FontColor.Equals(other.FontColor))) && this.FontName == other.FontName)
        return this.FontFamilyNumbering == other.FontFamilyNumbering;
      return false;
    }
  }
}

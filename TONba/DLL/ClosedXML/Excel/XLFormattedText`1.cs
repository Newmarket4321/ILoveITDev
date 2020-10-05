// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLFormattedText`1
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClosedXML.Excel
{
  internal class XLFormattedText<T> : IXLFormattedText<T>, IEnumerable<IXLRichString>, IEnumerable, IEquatable<IXLFormattedText<T>>, IXLWithRichString
  {
    private List<IXLRichString> _richTexts = new List<IXLRichString>();
    protected T Container;
    private readonly IXLFontBase _defaultFont;
    private IXLPhonetics _phonetics;

    public XLFormattedText(IXLFontBase defaultFont)
    {
      this.Length = 0;
      this._defaultFont = defaultFont;
    }

    public XLFormattedText(IXLFormattedText<T> defaultRichText, IXLFontBase defaultFont)
      : this(defaultFont)
    {
      foreach (IXLRichString xlRichString in (IEnumerable<IXLRichString>) defaultRichText)
        this.AddText(xlRichString.Text, (IXLFontBase) xlRichString);
      if (!defaultRichText.HasPhonetics)
        return;
      this._phonetics = (IXLPhonetics) new XLPhonetics(defaultRichText.Phonetics, defaultFont);
    }

    public XLFormattedText(string text, IXLFontBase defaultFont)
      : this(defaultFont)
    {
      this.AddText(text);
    }

    public int Count
    {
      get
      {
        return this._richTexts.Count;
      }
    }

    public int Length { get; private set; }

    public IXLRichString AddText(string text)
    {
      return this.AddText(text, this._defaultFont);
    }

    public IXLRichString AddText(string text, IXLFontBase font)
    {
      return this.AddText((IXLRichString) new XLRichString(text, font, (IXLWithRichString) this));
    }

    public IXLRichString AddText(IXLRichString richText)
    {
      this._richTexts.Add(richText);
      this.Length += richText.Text.Length;
      return richText;
    }

    public IXLRichString AddNewLine()
    {
      return this.AddText(Environment.NewLine);
    }

    public IXLFormattedText<T> ClearText()
    {
      this._richTexts.Clear();
      this.Length = 0;
      return (IXLFormattedText<T>) this;
    }

    public IXLFormattedText<T> ClearFont()
    {
      string text = this.Text;
      this.ClearText();
      this.AddText(text);
      return (IXLFormattedText<T>) this;
    }

    public override string ToString()
    {
      StringBuilder sb = new StringBuilder(this._richTexts.Count);
      this._richTexts.ForEach((Action<IXLRichString>) (rt => sb.Append(rt.Text)));
      return sb.ToString();
    }

    public IXLFormattedText<T> Substring(int index)
    {
      return this.Substring(index, this.Length - index);
    }

    public IXLFormattedText<T> Substring(int index, int length)
    {
      if (index + 1 > this.Length || this.Length - index + 1 < length || length <= 0)
        throw new IndexOutOfRangeException("Index and length must refer to a location within the string.");
      List<IXLRichString> xlRichStringList = new List<IXLRichString>();
      XLFormattedText<T> xlFormattedText = new XLFormattedText<T>(this._defaultFont);
      int num1 = 0;
      foreach (IXLRichString richText in this._richTexts)
      {
        if (num1 >= index + 1 + length)
          xlRichStringList.Add(richText);
        else if (num1 + richText.Text.Length >= index + 1)
        {
          int num2 = index - num1;
          if (num2 > 0)
            xlRichStringList.Add((IXLRichString) new XLRichString(richText.Text.Substring(0, num2), (IXLFontBase) richText, (IXLWithRichString) this));
          else if (num2 < 0)
            num2 = 0;
          int length1 = length - xlFormattedText.Length;
          if (length1 > richText.Text.Length - num2)
            length1 = richText.Text.Length - num2;
          XLRichString xlRichString = new XLRichString(richText.Text.Substring(num2, length1), (IXLFontBase) richText, (IXLWithRichString) this);
          xlRichStringList.Add((IXLRichString) xlRichString);
          xlFormattedText.AddText((IXLRichString) xlRichString);
          if (num2 + length1 < richText.Text.Length)
            xlRichStringList.Add((IXLRichString) new XLRichString(richText.Text.Substring(num2 + length1), (IXLFontBase) richText, (IXLWithRichString) this));
        }
        else
          xlRichStringList.Add(richText);
        num1 += richText.Text.Length;
      }
      this._richTexts = xlRichStringList;
      return (IXLFormattedText<T>) xlFormattedText;
    }

    public IEnumerator<IXLRichString> GetEnumerator()
    {
      return (IEnumerator<IXLRichString>) this._richTexts.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return (IEnumerator) this.GetEnumerator();
    }

    public bool Bold
    {
      set
      {
        this._richTexts.ForEach((Action<IXLRichString>) (rt => rt.Bold = value));
      }
    }

    public bool Italic
    {
      set
      {
        this._richTexts.ForEach((Action<IXLRichString>) (rt => rt.Italic = value));
      }
    }

    public XLFontUnderlineValues Underline
    {
      set
      {
        this._richTexts.ForEach((Action<IXLRichString>) (rt => rt.Underline = value));
      }
    }

    public bool Strikethrough
    {
      set
      {
        this._richTexts.ForEach((Action<IXLRichString>) (rt => rt.Strikethrough = value));
      }
    }

    public XLFontVerticalTextAlignmentValues VerticalAlignment
    {
      set
      {
        this._richTexts.ForEach((Action<IXLRichString>) (rt => rt.VerticalAlignment = value));
      }
    }

    public bool Shadow
    {
      set
      {
        this._richTexts.ForEach((Action<IXLRichString>) (rt => rt.Shadow = value));
      }
    }

    public double FontSize
    {
      set
      {
        this._richTexts.ForEach((Action<IXLRichString>) (rt => rt.FontSize = value));
      }
    }

    public XLColor FontColor
    {
      set
      {
        this._richTexts.ForEach((Action<IXLRichString>) (rt => rt.FontColor = value));
      }
    }

    public string FontName
    {
      set
      {
        this._richTexts.ForEach((Action<IXLRichString>) (rt => rt.FontName = value));
      }
    }

    public XLFontFamilyNumberingValues FontFamilyNumbering
    {
      set
      {
        this._richTexts.ForEach((Action<IXLRichString>) (rt => rt.FontFamilyNumbering = value));
      }
    }

    public IXLFormattedText<T> SetBold()
    {
      this.Bold = true;
      return (IXLFormattedText<T>) this;
    }

    public IXLFormattedText<T> SetBold(bool value)
    {
      this.Bold = value;
      return (IXLFormattedText<T>) this;
    }

    public IXLFormattedText<T> SetItalic()
    {
      this.Italic = true;
      return (IXLFormattedText<T>) this;
    }

    public IXLFormattedText<T> SetItalic(bool value)
    {
      this.Italic = value;
      return (IXLFormattedText<T>) this;
    }

    public IXLFormattedText<T> SetUnderline()
    {
      this.Underline = XLFontUnderlineValues.Single;
      return (IXLFormattedText<T>) this;
    }

    public IXLFormattedText<T> SetUnderline(XLFontUnderlineValues value)
    {
      this.Underline = value;
      return (IXLFormattedText<T>) this;
    }

    public IXLFormattedText<T> SetStrikethrough()
    {
      this.Strikethrough = true;
      return (IXLFormattedText<T>) this;
    }

    public IXLFormattedText<T> SetStrikethrough(bool value)
    {
      this.Strikethrough = value;
      return (IXLFormattedText<T>) this;
    }

    public IXLFormattedText<T> SetVerticalAlignment(XLFontVerticalTextAlignmentValues value)
    {
      this.VerticalAlignment = value;
      return (IXLFormattedText<T>) this;
    }

    public IXLFormattedText<T> SetShadow()
    {
      this.Shadow = true;
      return (IXLFormattedText<T>) this;
    }

    public IXLFormattedText<T> SetShadow(bool value)
    {
      this.Shadow = value;
      return (IXLFormattedText<T>) this;
    }

    public IXLFormattedText<T> SetFontSize(double value)
    {
      this.FontSize = value;
      return (IXLFormattedText<T>) this;
    }

    public IXLFormattedText<T> SetFontColor(XLColor value)
    {
      this.FontColor = value;
      return (IXLFormattedText<T>) this;
    }

    public IXLFormattedText<T> SetFontName(string value)
    {
      this.FontName = value;
      return (IXLFormattedText<T>) this;
    }

    public IXLFormattedText<T> SetFontFamilyNumbering(XLFontFamilyNumberingValues value)
    {
      this.FontFamilyNumbering = value;
      return (IXLFormattedText<T>) this;
    }

    public bool Equals(IXLFormattedText<T> other)
    {
      int count = this.Count;
      if (count != other.Count)
        return false;
      for (int index = 0; index < count; ++index)
      {
        if (this._richTexts.ElementAt<IXLRichString>(index) != other.ElementAt<IXLRichString>(index))
          return false;
      }
      if (this._phonetics != null)
        return this.Phonetics.Equals(other.Phonetics);
      return true;
    }

    public string Text
    {
      get
      {
        return this.ToString();
      }
    }

    public IXLPhonetics Phonetics
    {
      get
      {
        return this._phonetics ?? (this._phonetics = (IXLPhonetics) new XLPhonetics(this._defaultFont));
      }
    }

    public bool HasPhonetics
    {
      get
      {
        return this._phonetics != null;
      }
    }
  }
}

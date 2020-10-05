// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLFont
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Text;

namespace ClosedXML.Excel
{
  internal class XLFont : IXLFont, IXLFontBase, IEquatable<IXLFont>
  {
    private readonly IXLStylized _container;
    private bool _bold;
    private XLColor _fontColor;
    private XLFontFamilyNumberingValues _fontFamilyNumbering;
    private string _fontName;
    private double _fontSize;
    private bool _italic;
    private bool _shadow;
    private bool _strikethrough;
    private XLFontUnderlineValues _underline;
    private XLFontVerticalTextAlignmentValues _verticalAlignment;
    private bool _fontColorModified;

    public XLFont()
      : this((IXLStylized) null, (IXLFontBase) XLWorkbook.DefaultStyle.Font, true)
    {
    }

    public XLFont(IXLStylized container, IXLFontBase defaultFont, bool useDefaultModify = true)
    {
      this._container = container;
      if (defaultFont == null)
        return;
      this._bold = defaultFont.Bold;
      this._italic = defaultFont.Italic;
      this._underline = defaultFont.Underline;
      this._strikethrough = defaultFont.Strikethrough;
      this._verticalAlignment = defaultFont.VerticalAlignment;
      this._shadow = defaultFont.Shadow;
      this._fontSize = defaultFont.FontSize;
      this._fontColor = defaultFont.FontColor;
      this._fontName = defaultFont.FontName;
      this._fontFamilyNumbering = defaultFont.FontFamilyNumbering;
      if (!useDefaultModify)
        return;
      XLFont xlFont = defaultFont as XLFont;
      if (xlFont == null)
        return;
      this.BoldModified = xlFont.BoldModified;
      this.ItalicModified = xlFont.ItalicModified;
      this.UnderlineModified = xlFont.UnderlineModified;
      this.StrikethroughModified = xlFont.StrikethroughModified;
      this.VerticalAlignmentModified = xlFont.VerticalAlignmentModified;
      this.ShadowModified = xlFont.ShadowModified;
      this.FontSizeModified = xlFont.FontSizeModified;
      this.FontColorModified = xlFont.FontColorModified;
      this.FontNameModified = xlFont.FontNameModified;
      this.FontFamilyNumberingModified = xlFont.FontFamilyNumberingModified;
    }

    public bool BoldModified { get; set; }

    public bool Bold
    {
      get
      {
        return this._bold;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
        {
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Font.Bold = value));
        }
        else
        {
          this._bold = value;
          this.BoldModified = true;
        }
      }
    }

    public bool ItalicModified { get; set; }

    public bool Italic
    {
      get
      {
        return this._italic;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
        {
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Font.Italic = value));
        }
        else
        {
          this._italic = value;
          this.ItalicModified = true;
        }
      }
    }

    public bool UnderlineModified { get; set; }

    public XLFontUnderlineValues Underline
    {
      get
      {
        return this._underline;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
        {
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Font.Underline = value));
        }
        else
        {
          this._underline = value;
          this.UnderlineModified = true;
        }
      }
    }

    public bool StrikethroughModified { get; set; }

    public bool Strikethrough
    {
      get
      {
        return this._strikethrough;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
        {
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Font.Strikethrough = value));
        }
        else
        {
          this._strikethrough = value;
          this.StrikethroughModified = true;
        }
      }
    }

    public bool VerticalAlignmentModified { get; set; }

    public XLFontVerticalTextAlignmentValues VerticalAlignment
    {
      get
      {
        return this._verticalAlignment;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
        {
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Font.VerticalAlignment = value));
        }
        else
        {
          this._verticalAlignment = value;
          this.VerticalAlignmentModified = true;
        }
      }
    }

    public bool ShadowModified { get; set; }

    public bool Shadow
    {
      get
      {
        return this._shadow;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
        {
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Font.Shadow = value));
        }
        else
        {
          this._shadow = value;
          this.ShadowModified = true;
        }
      }
    }

    public bool FontSizeModified { get; set; }

    public double FontSize
    {
      get
      {
        return this._fontSize;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
        {
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Font.FontSize = value));
        }
        else
        {
          this._fontSize = value;
          this.FontSizeModified = true;
        }
      }
    }

    public bool FontColorModified
    {
      get
      {
        return this._fontColorModified;
      }
      set
      {
        this._fontColorModified = value;
      }
    }

    public XLColor FontColor
    {
      get
      {
        return this._fontColor;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
        {
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Font.FontColor = value));
        }
        else
        {
          this._fontColor = value;
          this.FontColorModified = true;
        }
      }
    }

    public bool FontNameModified { get; set; }

    public string FontName
    {
      get
      {
        return this._fontName;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
        {
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Font.FontName = value));
        }
        else
        {
          this._fontName = value;
          this.FontNameModified = true;
        }
      }
    }

    public bool FontFamilyNumberingModified { get; set; }

    public XLFontFamilyNumberingValues FontFamilyNumbering
    {
      get
      {
        return this._fontFamilyNumbering;
      }
      set
      {
        this.SetStyleChanged();
        if (this._container != null && !this._container.UpdatingStyle)
        {
          this._container.Styles.ForEach<IXLStyle>((Action<IXLStyle>) (s => s.Font.FontFamilyNumbering = value));
        }
        else
        {
          this._fontFamilyNumbering = value;
          this.FontFamilyNumberingModified = true;
        }
      }
    }

    public IXLStyle SetBold()
    {
      this.Bold = true;
      return this._container.Style;
    }

    public IXLStyle SetBold(bool value)
    {
      this.Bold = value;
      return this._container.Style;
    }

    public IXLStyle SetItalic()
    {
      this.Italic = true;
      return this._container.Style;
    }

    public IXLStyle SetItalic(bool value)
    {
      this.Italic = value;
      return this._container.Style;
    }

    public IXLStyle SetUnderline()
    {
      this.Underline = XLFontUnderlineValues.Single;
      return this._container.Style;
    }

    public IXLStyle SetUnderline(XLFontUnderlineValues value)
    {
      this.Underline = value;
      return this._container.Style;
    }

    public IXLStyle SetStrikethrough()
    {
      this.Strikethrough = true;
      return this._container.Style;
    }

    public IXLStyle SetStrikethrough(bool value)
    {
      this.Strikethrough = value;
      return this._container.Style;
    }

    public IXLStyle SetVerticalAlignment(XLFontVerticalTextAlignmentValues value)
    {
      this.VerticalAlignment = value;
      return this._container.Style;
    }

    public IXLStyle SetShadow()
    {
      this.Shadow = true;
      return this._container.Style;
    }

    public IXLStyle SetShadow(bool value)
    {
      this.Shadow = value;
      return this._container.Style;
    }

    public IXLStyle SetFontSize(double value)
    {
      this.FontSize = value;
      return this._container.Style;
    }

    public IXLStyle SetFontColor(XLColor value)
    {
      this.FontColor = value;
      return this._container.Style;
    }

    public IXLStyle SetFontName(string value)
    {
      this.FontName = value;
      return this._container.Style;
    }

    public IXLStyle SetFontFamilyNumbering(XLFontFamilyNumberingValues value)
    {
      this.FontFamilyNumbering = value;
      return this._container.Style;
    }

    public bool Equals(IXLFont other)
    {
      XLFont xlFont = other as XLFont;
      if (xlFont == null || this._bold != xlFont._bold || (this._italic != xlFont._italic || this._underline != xlFont._underline) || (this._strikethrough != xlFont._strikethrough || this._verticalAlignment != xlFont._verticalAlignment || (this._shadow != xlFont._shadow || this._fontSize != xlFont._fontSize)) || (!this._fontColor.Equals(xlFont._fontColor) || !(this._fontName == xlFont._fontName)))
        return false;
      return this._fontFamilyNumbering == xlFont._fontFamilyNumbering;
    }

    private void SetStyleChanged()
    {
      if (this._container == null)
        return;
      this._container.StyleChanged = true;
    }

    public override string ToString()
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append(this.Bold.ToString());
      stringBuilder.Append("-");
      stringBuilder.Append(this.Italic.ToString());
      stringBuilder.Append("-");
      stringBuilder.Append(this.Underline.ToString());
      stringBuilder.Append("-");
      stringBuilder.Append(this.Strikethrough.ToString());
      stringBuilder.Append("-");
      stringBuilder.Append(this.VerticalAlignment.ToString());
      stringBuilder.Append("-");
      stringBuilder.Append(this.Shadow.ToString());
      stringBuilder.Append("-");
      stringBuilder.Append(this.FontSize.ToString());
      stringBuilder.Append("-");
      stringBuilder.Append((object) this.FontColor);
      stringBuilder.Append("-");
      stringBuilder.Append(this.FontName);
      stringBuilder.Append("-");
      stringBuilder.Append(this.FontFamilyNumbering.ToString());
      return stringBuilder.ToString();
    }

    public override bool Equals(object obj)
    {
      return this.Equals((IXLFont) obj);
    }

    public override int GetHashCode()
    {
      return (int) ((XLFontFamilyNumberingValues) ((XLFontVerticalTextAlignmentValues) ((XLFontUnderlineValues) (this.Bold.GetHashCode() ^ this.Italic.GetHashCode()) ^ this.Underline ^ (XLFontUnderlineValues) this.Strikethrough.GetHashCode()) ^ this.VerticalAlignment ^ (XLFontVerticalTextAlignmentValues) this.Shadow.GetHashCode() ^ (XLFontVerticalTextAlignmentValues) this.FontSize.GetHashCode() ^ (XLFontVerticalTextAlignmentValues) this.FontColor.GetHashCode() ^ (XLFontVerticalTextAlignmentValues) this.FontName.GetHashCode()) ^ this.FontFamilyNumbering);
    }
  }
}

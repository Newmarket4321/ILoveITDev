// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLHFText
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Text;

namespace ClosedXML.Excel
{
  internal class XLHFText
  {
    private readonly XLWorksheet _worksheet;

    public XLHFText(XLRichString richText, XLWorksheet worksheet)
    {
      this.RichText = richText;
      this._worksheet = worksheet;
    }

    public XLRichString RichText { get; private set; }

    public string GetHFText(string prevText)
    {
      StringBuilder stringBuilder = new StringBuilder();
      IXLFont font = this._worksheet.Style.Font;
      if (this.RichText.FontName != null && this.RichText.FontName != font.FontName)
        stringBuilder.Append("&\"" + this.RichText.FontName);
      else
        stringBuilder.Append("&\"-");
      if (this.RichText.Bold && this.RichText.Italic)
        stringBuilder.Append(",Bold Italic\"");
      else if (this.RichText.Bold)
        stringBuilder.Append(",Bold\"");
      else if (this.RichText.Italic)
        stringBuilder.Append(",Italic\"");
      else
        stringBuilder.Append(",Regular\"");
      if (this.RichText.FontSize > 0.0 && Math.Abs(this.RichText.FontSize - font.FontSize) > 1E-10)
        stringBuilder.Append("&" + (object) this.RichText.FontSize);
      if (this.RichText.Strikethrough && !font.Strikethrough)
        stringBuilder.Append("&S");
      if (this.RichText.VerticalAlignment != font.VerticalAlignment)
      {
        if (this.RichText.VerticalAlignment == XLFontVerticalTextAlignmentValues.Subscript)
          stringBuilder.Append("&Y");
        else if (this.RichText.VerticalAlignment == XLFontVerticalTextAlignmentValues.Superscript)
          stringBuilder.Append("&X");
      }
      if (this.RichText.Underline != font.Underline)
      {
        if (this.RichText.Underline == XLFontUnderlineValues.Single)
          stringBuilder.Append("&U");
        else if (this.RichText.Underline == XLFontUnderlineValues.Double)
          stringBuilder.Append("&E");
      }
      int num = prevText.LastIndexOf("&K");
      if (num >= 0 && !this.RichText.FontColor.Equals(XLColor.FromHtml("#" + prevText.Substring(num + 2, 6))) || num == -1 && !this.RichText.FontColor.Equals(font.FontColor))
        stringBuilder.Append("&K" + this.RichText.FontColor.Color.ToHex().Substring(2));
      stringBuilder.Append(this.RichText.Text);
      if (this.RichText.Underline != font.Underline)
      {
        if (this.RichText.Underline == XLFontUnderlineValues.Single)
          stringBuilder.Append("&U");
        else if (this.RichText.Underline == XLFontUnderlineValues.Double)
          stringBuilder.Append("&E");
      }
      if (this.RichText.VerticalAlignment != font.VerticalAlignment)
      {
        if (this.RichText.VerticalAlignment == XLFontVerticalTextAlignmentValues.Subscript)
          stringBuilder.Append("&Y");
        else if (this.RichText.VerticalAlignment == XLFontVerticalTextAlignmentValues.Superscript)
          stringBuilder.Append("&X");
      }
      if (this.RichText.Strikethrough && !font.Strikethrough)
        stringBuilder.Append("&S");
      return stringBuilder.ToString();
    }
  }
}

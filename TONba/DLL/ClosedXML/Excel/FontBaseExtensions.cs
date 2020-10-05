// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.FontBaseExtensions
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using ClosedXML.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ClosedXML.Excel
{
  public static class FontBaseExtensions
  {
    private static Font GetCachedFont(IXLFontBase fontBase, Dictionary<IXLFontBase, Font> fontCache)
    {
      Font font;
      if (!fontCache.TryGetValue(fontBase, out font))
      {
        font = new Font(fontBase.FontName, (float) fontBase.FontSize, FontBaseExtensions.GetFontStyle(fontBase));
        fontCache.Add(fontBase, font);
      }
      return font;
    }

    public static double GetWidth(this IXLFontBase fontBase, string text, Dictionary<IXLFontBase, Font> fontCache)
    {
      if (XLHelper.IsNullOrWhiteSpace(text))
        return 0.0;
      Font cachedFont = FontBaseExtensions.GetCachedFont(fontBase, fontCache);
      return (double) Decimal.Round((Decimal) (((double) GraphicsUtils.MeasureString(text, cachedFont).Width / 7.0 * 256.0 - 18.0) / 256.0) + new Decimal(2, 0, 0, false, (byte) 1), 2);
    }

    private static FontStyle GetFontStyle(IXLFontBase font)
    {
      FontStyle fontStyle = FontStyle.Regular;
      if (font.Bold)
        fontStyle |= FontStyle.Bold;
      if (font.Italic)
        fontStyle |= FontStyle.Italic;
      if (font.Strikethrough)
        fontStyle |= FontStyle.Strikeout;
      if (font.Underline != XLFontUnderlineValues.None)
        fontStyle |= FontStyle.Underline;
      return fontStyle;
    }

    public static double GetHeight(this IXLFontBase fontBase, Dictionary<IXLFontBase, Font> fontCache)
    {
      return (double) GraphicsUtils.MeasureString("X", FontBaseExtensions.GetCachedFont(fontBase, fontCache)).Height * 0.85;
    }

    public static void CopyFont(this IXLFontBase font, IXLFontBase sourceFont)
    {
      font.Bold = sourceFont.Bold;
      font.Italic = sourceFont.Italic;
      font.Underline = sourceFont.Underline;
      font.Strikethrough = sourceFont.Strikethrough;
      font.VerticalAlignment = sourceFont.VerticalAlignment;
      font.Shadow = sourceFont.Shadow;
      font.FontSize = sourceFont.FontSize;
      font.FontColor = sourceFont.FontColor;
      font.FontName = sourceFont.FontName;
      font.FontFamilyNumbering = sourceFont.FontFamilyNumbering;
    }
  }
}

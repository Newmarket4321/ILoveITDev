// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLRichString
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;

namespace ClosedXML.Excel
{
  public interface IXLRichString : IXLFontBase, IEquatable<IXLRichString>, IXLWithRichString
  {
    string Text { get; set; }

    IXLRichString SetBold();

    IXLRichString SetBold(bool value);

    IXLRichString SetItalic();

    IXLRichString SetItalic(bool value);

    IXLRichString SetUnderline();

    IXLRichString SetUnderline(XLFontUnderlineValues value);

    IXLRichString SetStrikethrough();

    IXLRichString SetStrikethrough(bool value);

    IXLRichString SetVerticalAlignment(XLFontVerticalTextAlignmentValues value);

    IXLRichString SetShadow();

    IXLRichString SetShadow(bool value);

    IXLRichString SetFontSize(double value);

    IXLRichString SetFontColor(XLColor value);

    IXLRichString SetFontName(string value);

    IXLRichString SetFontFamilyNumbering(XLFontFamilyNumberingValues value);
  }
}

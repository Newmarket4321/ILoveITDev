// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLFont
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;

namespace ClosedXML.Excel
{
  public interface IXLFont : IXLFontBase, IEquatable<IXLFont>
  {
    IXLStyle SetBold();

    IXLStyle SetBold(bool value);

    IXLStyle SetItalic();

    IXLStyle SetItalic(bool value);

    IXLStyle SetUnderline();

    IXLStyle SetUnderline(XLFontUnderlineValues value);

    IXLStyle SetStrikethrough();

    IXLStyle SetStrikethrough(bool value);

    IXLStyle SetVerticalAlignment(XLFontVerticalTextAlignmentValues value);

    IXLStyle SetShadow();

    IXLStyle SetShadow(bool value);

    IXLStyle SetFontSize(double value);

    IXLStyle SetFontColor(XLColor value);

    IXLStyle SetFontName(string value);

    IXLStyle SetFontFamilyNumbering(XLFontFamilyNumberingValues value);
  }
}

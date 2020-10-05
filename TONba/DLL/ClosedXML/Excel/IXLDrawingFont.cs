// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLDrawingFont
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  public interface IXLDrawingFont : IXLFontBase
  {
    IXLDrawingStyle SetBold();

    IXLDrawingStyle SetBold(bool value);

    IXLDrawingStyle SetItalic();

    IXLDrawingStyle SetItalic(bool value);

    IXLDrawingStyle SetUnderline();

    IXLDrawingStyle SetUnderline(XLFontUnderlineValues value);

    IXLDrawingStyle SetStrikethrough();

    IXLDrawingStyle SetStrikethrough(bool value);

    IXLDrawingStyle SetVerticalAlignment(XLFontVerticalTextAlignmentValues value);

    IXLDrawingStyle SetShadow();

    IXLDrawingStyle SetShadow(bool value);

    IXLDrawingStyle SetFontSize(double value);

    IXLDrawingStyle SetFontColor(XLColor value);

    IXLDrawingStyle SetFontName(string value);

    IXLDrawingStyle SetFontFamilyNumbering(XLFontFamilyNumberingValues value);
  }
}

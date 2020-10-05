// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLFontBase
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  public interface IXLFontBase
  {
    bool Bold { get; set; }

    bool Italic { get; set; }

    XLFontUnderlineValues Underline { get; set; }

    bool Strikethrough { get; set; }

    XLFontVerticalTextAlignmentValues VerticalAlignment { get; set; }

    bool Shadow { get; set; }

    double FontSize { get; set; }

    XLColor FontColor { get; set; }

    string FontName { get; set; }

    XLFontFamilyNumberingValues FontFamilyNumbering { get; set; }
  }
}

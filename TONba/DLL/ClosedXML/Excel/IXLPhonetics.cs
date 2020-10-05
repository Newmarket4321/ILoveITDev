// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLPhonetics
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections;
using System.Collections.Generic;

namespace ClosedXML.Excel
{
  public interface IXLPhonetics : IXLFontBase, IEnumerable<IXLPhonetic>, IEnumerable, IEquatable<IXLPhonetics>
  {
    IXLPhonetics SetBold();

    IXLPhonetics SetBold(bool value);

    IXLPhonetics SetItalic();

    IXLPhonetics SetItalic(bool value);

    IXLPhonetics SetUnderline();

    IXLPhonetics SetUnderline(XLFontUnderlineValues value);

    IXLPhonetics SetStrikethrough();

    IXLPhonetics SetStrikethrough(bool value);

    IXLPhonetics SetVerticalAlignment(XLFontVerticalTextAlignmentValues value);

    IXLPhonetics SetShadow();

    IXLPhonetics SetShadow(bool value);

    IXLPhonetics SetFontSize(double value);

    IXLPhonetics SetFontColor(XLColor value);

    IXLPhonetics SetFontName(string value);

    IXLPhonetics SetFontFamilyNumbering(XLFontFamilyNumberingValues value);

    IXLPhonetics Add(string text, int start, int end);

    IXLPhonetics ClearText();

    IXLPhonetics ClearFont();

    int Count { get; }

    XLPhoneticAlignment Alignment { get; set; }

    XLPhoneticType Type { get; set; }

    IXLPhonetics SetAlignment(XLPhoneticAlignment phoneticAlignment);

    IXLPhonetics SetType(XLPhoneticType phoneticType);
  }
}

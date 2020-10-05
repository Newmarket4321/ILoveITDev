// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLRichText
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections;
using System.Collections.Generic;

namespace ClosedXML.Excel
{
  internal class XLRichText : XLFormattedText<IXLRichText>, IXLRichText, IXLFormattedText<IXLRichText>, IEnumerable<IXLRichString>, IEnumerable, IEquatable<IXLFormattedText<IXLRichText>>, IXLWithRichString
  {
    public XLRichText(IXLFontBase defaultFont)
      : base(defaultFont)
    {
      this.Container = (IXLRichText) this;
    }

    public XLRichText(XLFormattedText<IXLRichText> defaultRichText, IXLFontBase defaultFont)
      : base((IXLFormattedText<IXLRichText>) defaultRichText, defaultFont)
    {
      this.Container = (IXLRichText) this;
    }

    public XLRichText(string text, IXLFontBase defaultFont)
      : base(text, defaultFont)
    {
      this.Container = (IXLRichText) this;
    }
  }
}

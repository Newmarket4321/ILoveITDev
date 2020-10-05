// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLPhonetic
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;

namespace ClosedXML.Excel
{
  internal class XLPhonetic : IXLPhonetic, IEquatable<IXLPhonetic>
  {
    public XLPhonetic(string text, int start, int end)
    {
      this.Text = text;
      this.Start = start;
      this.End = end;
    }

    public string Text { get; set; }

    public int Start { get; set; }

    public int End { get; set; }

    public bool Equals(IXLPhonetic other)
    {
      if (other == null || !(this.Text == other.Text) || this.Start != other.Start)
        return false;
      return this.End == other.End;
    }
  }
}

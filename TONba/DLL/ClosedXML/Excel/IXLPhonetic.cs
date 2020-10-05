// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLPhonetic
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;

namespace ClosedXML.Excel
{
  public interface IXLPhonetic : IEquatable<IXLPhonetic>
  {
    string Text { get; set; }

    int Start { get; set; }

    int End { get; set; }
  }
}

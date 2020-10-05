// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLStylized
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System.Collections.Generic;

namespace ClosedXML.Excel
{
  internal interface IXLStylized
  {
    IXLStyle Style { get; set; }

    IEnumerable<IXLStyle> Styles { get; }

    bool UpdatingStyle { get; set; }

    IXLStyle InnerStyle { get; set; }

    IXLRanges RangesUsed { get; }

    bool StyleChanged { get; set; }
  }
}

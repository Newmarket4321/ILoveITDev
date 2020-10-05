// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLStylizedEmpty
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System.Collections.Generic;

namespace ClosedXML.Excel
{
  internal class XLStylizedEmpty : IXLStylized
  {
    public XLStylizedEmpty(IXLStyle defaultStyle)
    {
      this.Style = (IXLStyle) new XLStyle((IXLStylized) this, defaultStyle, true);
    }

    public IXLStyle Style { get; set; }

    public IEnumerable<IXLStyle> Styles
    {
      get
      {
        this.UpdatingStyle = true;
        yield return this.Style;
        this.UpdatingStyle = false;
      }
    }

    public bool UpdatingStyle { get; set; }

    public IXLStyle InnerStyle { get; set; }

    public IXLRanges RangesUsed
    {
      get
      {
        return (IXLRanges) new XLRanges();
      }
    }

    public bool StyleChanged { get; set; }
  }
}

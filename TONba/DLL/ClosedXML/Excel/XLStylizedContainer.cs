// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLStylizedContainer
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System.Collections.Generic;

namespace ClosedXML.Excel
{
  internal class XLStylizedContainer : IXLStylized
  {
    private readonly IXLStylized _container;

    public bool StyleChanged { get; set; }

    public XLStylizedContainer(IXLStyle style, IXLStylized container)
    {
      this.Style = style;
      this._container = container;
      this.RangesUsed = container.RangesUsed;
    }

    public IXLStyle Style { get; set; }

    public IEnumerable<IXLStyle> Styles
    {
      get
      {
        this._container.UpdatingStyle = true;
        yield return this.Style;
        this._container.UpdatingStyle = false;
      }
    }

    public bool UpdatingStyle { get; set; }

    public IXLStyle InnerStyle { get; set; }

    public IXLRanges RangesUsed { get; set; }
  }
}

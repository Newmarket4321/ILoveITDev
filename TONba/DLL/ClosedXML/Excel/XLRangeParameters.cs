// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLRangeParameters
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  internal class XLRangeParameters
  {
    private bool _ignoreEvents;

    public XLRangeParameters(XLRangeAddress rangeAddress, IXLStyle defaultStyle)
    {
      this.RangeAddress = rangeAddress;
      this._ignoreEvents = !rangeAddress.Worksheet.EventTrackingEnabled;
      this.DefaultStyle = defaultStyle;
    }

    public XLRangeAddress RangeAddress { get; private set; }

    public IXLStyle DefaultStyle { get; private set; }

    public bool IgnoreEvents
    {
      get
      {
        return this._ignoreEvents;
      }
      set
      {
        this._ignoreEvents = value;
      }
    }
  }
}

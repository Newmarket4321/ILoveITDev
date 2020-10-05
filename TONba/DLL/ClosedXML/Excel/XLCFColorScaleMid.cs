// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLCFColorScaleMid
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  internal class XLCFColorScaleMid : IXLCFColorScaleMid
  {
    private readonly XLConditionalFormat _conditionalFormat;

    public XLCFColorScaleMid(XLConditionalFormat conditionalFormat)
    {
      this._conditionalFormat = conditionalFormat;
    }

    public IXLCFColorScaleMax Midpoint(XLCFContentType type, string value, XLColor color)
    {
      this._conditionalFormat.Values.Add(new XLFormula()
      {
        Value = value
      });
      this._conditionalFormat.Colors.Add(color);
      this._conditionalFormat.ContentTypes.Add(type);
      return (IXLCFColorScaleMax) new XLCFColorScaleMax(this._conditionalFormat);
    }

    public IXLCFColorScaleMax Midpoint(XLCFContentType type, double value, XLColor color)
    {
      return this.Midpoint(type, value.ToInvariantString(), color);
    }

    public void Maximum(XLCFContentType type, string value, XLColor color)
    {
      this.Midpoint(type, value, color);
    }

    public void Maximum(XLCFContentType type, double value, XLColor color)
    {
      this.Maximum(type, value.ToInvariantString(), color);
    }

    public void HighestValue(XLColor color)
    {
      this.Midpoint(XLCFContentType.Maximum, "0", color);
    }
  }
}

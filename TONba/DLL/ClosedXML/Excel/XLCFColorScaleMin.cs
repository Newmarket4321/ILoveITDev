// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLCFColorScaleMin
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  internal class XLCFColorScaleMin : IXLCFColorScaleMin
  {
    private readonly XLConditionalFormat _conditionalFormat;

    public XLCFColorScaleMin(XLConditionalFormat conditionalFormat)
    {
      this._conditionalFormat = conditionalFormat;
    }

    public IXLCFColorScaleMid Minimum(XLCFContentType type, string value, XLColor color)
    {
      this._conditionalFormat.Values.Initialize(new XLFormula()
      {
        Value = value
      });
      this._conditionalFormat.Colors.Initialize(color);
      this._conditionalFormat.ContentTypes.Initialize(type);
      return (IXLCFColorScaleMid) new XLCFColorScaleMid(this._conditionalFormat);
    }

    public IXLCFColorScaleMid Minimum(XLCFContentType type, double value, XLColor color)
    {
      return this.Minimum(type, value.ToInvariantString(), color);
    }

    public IXLCFColorScaleMid LowestValue(XLColor color)
    {
      return this.Minimum(XLCFContentType.Minimum, "0", color);
    }
  }
}

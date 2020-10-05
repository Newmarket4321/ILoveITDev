// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLCFColorScaleMax
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  internal class XLCFColorScaleMax : IXLCFColorScaleMax
  {
    private readonly XLConditionalFormat _conditionalFormat;

    public XLCFColorScaleMax(XLConditionalFormat conditionalFormat)
    {
      this._conditionalFormat = conditionalFormat;
    }

    public void Maximum(XLCFContentType type, string value, XLColor color)
    {
      this._conditionalFormat.Values.Add(new XLFormula()
      {
        Value = value
      });
      this._conditionalFormat.Colors.Add(color);
      this._conditionalFormat.ContentTypes.Add(type);
    }

    public void Maximum(XLCFContentType type, double value, XLColor color)
    {
      this.Maximum(type, value.ToInvariantString(), color);
    }

    public void HighestValue(XLColor color)
    {
      this.Maximum(XLCFContentType.Maximum, "0", color);
    }
  }
}

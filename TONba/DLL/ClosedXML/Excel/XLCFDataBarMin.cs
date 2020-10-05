// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLCFDataBarMin
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  internal class XLCFDataBarMin : IXLCFDataBarMin
  {
    private readonly XLConditionalFormat _conditionalFormat;

    public XLCFDataBarMin(XLConditionalFormat conditionalFormat)
    {
      this._conditionalFormat = conditionalFormat;
    }

    public IXLCFDataBarMax Minimum(XLCFContentType type, string value)
    {
      this._conditionalFormat.ContentTypes.Initialize(type);
      this._conditionalFormat.Values.Initialize(new XLFormula()
      {
        Value = value
      });
      return (IXLCFDataBarMax) new XLCFDataBarMax(this._conditionalFormat);
    }

    public IXLCFDataBarMax Minimum(XLCFContentType type, double value)
    {
      return this.Minimum(type, value.ToInvariantString());
    }

    public IXLCFDataBarMax LowestValue()
    {
      return this.Minimum(XLCFContentType.Minimum, "0");
    }
  }
}

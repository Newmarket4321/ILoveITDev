// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLCFDataBarMax
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  internal class XLCFDataBarMax : IXLCFDataBarMax
  {
    private readonly XLConditionalFormat _conditionalFormat;

    public XLCFDataBarMax(XLConditionalFormat conditionalFormat)
    {
      this._conditionalFormat = conditionalFormat;
    }

    public void Maximum(XLCFContentType type, string value)
    {
      this._conditionalFormat.ContentTypes.Add(type);
      this._conditionalFormat.Values.Add(new XLFormula()
      {
        Value = value
      });
    }

    public void Maximum(XLCFContentType type, double value)
    {
      this.Maximum(type, value.ToInvariantString());
    }

    public void HighestValue()
    {
      this.Maximum(XLCFContentType.Maximum, "0");
    }
  }
}

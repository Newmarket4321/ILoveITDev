// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLCFIconSet
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  internal class XLCFIconSet : IXLCFIconSet
  {
    private readonly XLConditionalFormat _conditionalFormat;

    public XLCFIconSet(XLConditionalFormat conditionalFormat)
    {
      this._conditionalFormat = conditionalFormat;
    }

    public IXLCFIconSet AddValue(XLCFIconSetOperator setOperator, string value, XLCFContentType type)
    {
      this._conditionalFormat.IconSetOperators.Add(setOperator);
      this._conditionalFormat.Values.Add(new XLFormula()
      {
        Value = value
      });
      this._conditionalFormat.ContentTypes.Add(type);
      return (IXLCFIconSet) new XLCFIconSet(this._conditionalFormat);
    }

    public IXLCFIconSet AddValue(XLCFIconSetOperator setOperator, double value, XLCFContentType type)
    {
      return this.AddValue(setOperator, value.ToInvariantString(), type);
    }
  }
}

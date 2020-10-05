// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLPivotValueFormat
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  internal class XLPivotValueFormat : IXLPivotValueFormat, IXLNumberFormatBase
  {
    private int _numberFormatId = -1;
    private string _format = string.Empty;
    private readonly XLPivotValue _pivotValue;

    public XLPivotValueFormat(XLPivotValue pivotValue)
    {
      this._pivotValue = pivotValue;
      this._format = "General";
      this._numberFormatId = 0;
    }

    public int NumberFormatId
    {
      get
      {
        return this._numberFormatId;
      }
      set
      {
        this._numberFormatId = value;
        this._format = string.Empty;
      }
    }

    public string Format
    {
      get
      {
        return this._format;
      }
      set
      {
        this._format = value;
        this._numberFormatId = -1;
      }
    }

    public IXLPivotValue SetNumberFormatId(int value)
    {
      this.NumberFormatId = value;
      return (IXLPivotValue) this._pivotValue;
    }

    public IXLPivotValue SetFormat(string value)
    {
      this.Format = value;
      switch (value)
      {
        case "General":
          this._numberFormatId = 0;
          break;
        case "0":
          this._numberFormatId = 1;
          break;
        case "0.00":
          this._numberFormatId = 2;
          break;
        case "#,##0":
          this._numberFormatId = 3;
          break;
        case "#,##0.00":
          this._numberFormatId = 4;
          break;
        case "0%":
          this._numberFormatId = 9;
          break;
        case "0.00%":
          this._numberFormatId = 10;
          break;
        case "0.00E+00":
          this._numberFormatId = 11;
          break;
      }
      return (IXLPivotValue) this._pivotValue;
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLFormula
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  public class XLFormula
  {
    internal string _value;

    public XLFormula()
    {
    }

    public XLFormula(XLFormula defaultFormula)
    {
      this._value = defaultFormula._value;
      this.IsFormula = defaultFormula.IsFormula;
    }

    public XLFormula(string value)
    {
      this.Value = value;
    }

    public XLFormula(double value)
    {
      this.Value = value.ToInvariantString();
    }

    public XLFormula(int value)
    {
      this.Value = value.ToInvariantString();
    }

    public string Value
    {
      get
      {
        return this._value;
      }
      set
      {
        if (value == null)
        {
          this._value = string.Empty;
        }
        else
        {
          this._value = value.Trim();
          this.IsFormula = !XLHelper.IsNullOrWhiteSpace(this._value) && (int) this._value.TrimStart()[0] == 61;
          if (!this.IsFormula)
            return;
          this._value = this._value.Substring(1);
        }
      }
    }

    public bool IsFormula { get; internal set; }
  }
}

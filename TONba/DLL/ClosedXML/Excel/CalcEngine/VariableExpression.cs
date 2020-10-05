// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.CalcEngine.VariableExpression
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System.Collections.Generic;

namespace ClosedXML.Excel.CalcEngine
{
  internal class VariableExpression : Expression
  {
    private Dictionary<string, object> _dct;
    private string _name;

    public VariableExpression(Dictionary<string, object> dct, string name)
    {
      this._dct = dct;
      this._name = name;
    }

    public override object Evaluate()
    {
      return this._dct[this._name];
    }
  }
}

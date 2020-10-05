// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.CalcEngine.FunctionExpression
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System.Collections.Generic;

namespace ClosedXML.Excel.CalcEngine
{
  internal class FunctionExpression : Expression
  {
    private FunctionDefinition _fn;
    private List<Expression> _parms;

    internal FunctionExpression()
    {
    }

    public FunctionExpression(FunctionDefinition function, List<Expression> parms)
    {
      this._fn = function;
      this._parms = parms;
    }

    public override object Evaluate()
    {
      return this._fn.Function(this._parms);
    }

    public override Expression Optimize()
    {
      bool flag = true;
      if (this._parms != null)
      {
        for (int index = 0; index < this._parms.Count; ++index)
        {
          Expression expression = this._parms[index].Optimize();
          this._parms[index] = expression;
          if (expression._token.Type != TKTYPE.LITERAL)
            flag = false;
        }
      }
      if (!flag)
        return (Expression) this;
      return new Expression(this.Evaluate());
    }
  }
}

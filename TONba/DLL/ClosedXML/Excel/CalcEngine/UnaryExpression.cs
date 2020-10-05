// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.CalcEngine.UnaryExpression
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;

namespace ClosedXML.Excel.CalcEngine
{
  internal class UnaryExpression : Expression
  {
    private Expression _expr;

    public UnaryExpression(Token tk, Expression expr)
      : base(tk)
    {
      this._expr = expr;
    }

    public override object Evaluate()
    {
      switch (this._token.ID)
      {
        case TKID.ADD:
          return (object) (double) this._expr;
        case TKID.SUB:
          return (object) -(double) this._expr;
        default:
          throw new ArgumentException("Bad expression.");
      }
    }

    public override Expression Optimize()
    {
      this._expr = this._expr.Optimize();
      if (this._expr._token.Type != TKTYPE.LITERAL)
        return (Expression) this;
      return new Expression(this.Evaluate());
    }
  }
}

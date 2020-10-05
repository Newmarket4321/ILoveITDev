// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.CalcEngine.BinaryExpression
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;

namespace ClosedXML.Excel.CalcEngine
{
  internal class BinaryExpression : Expression
  {
    private Expression _lft;
    private Expression _rgt;

    public BinaryExpression(Token tk, Expression exprLeft, Expression exprRight)
      : base(tk)
    {
      this._lft = exprLeft;
      this._rgt = exprRight;
    }

    public override object Evaluate()
    {
      if (this._token.Type == TKTYPE.COMPARE)
      {
        int num = this._lft.CompareTo(this._rgt);
        switch (this._token.ID)
        {
          case TKID.GT:
            return (object) (num > 0);
          case TKID.LT:
            return (object) (num < 0);
          case TKID.GE:
            return (object) (num >= 0);
          case TKID.LE:
            return (object) (num <= 0);
          case TKID.EQ:
            return (object) (num == 0);
          case TKID.NE:
            return (object) (num != 0);
        }
      }
      switch (this._token.ID)
      {
        case TKID.ADD:
          return (object) ((double) this._lft + (double) this._rgt);
        case TKID.SUB:
          return (object) ((double) this._lft - (double) this._rgt);
        case TKID.MUL:
          return (object) ((double) this._lft * (double) this._rgt);
        case TKID.DIV:
          return (object) ((double) this._lft / (double) this._rgt);
        case TKID.DIVINT:
          return (object) (double) (int) ((double) this._lft / (double) this._rgt);
        case TKID.MOD:
          return (object) (double) (int) ((double) this._lft % (double) this._rgt);
        case TKID.POWER:
          double lft = (double) this._lft;
          double rgt = (double) this._rgt;
          if (rgt == 0.0)
            return (object) 1.0;
          if (rgt == 0.5)
            return (object) Math.Sqrt(lft);
          if (rgt == 1.0)
            return (object) lft;
          if (rgt == 2.0)
            return (object) (lft * lft);
          if (rgt == 3.0)
            return (object) (lft * lft * lft);
          if (rgt == 4.0)
            return (object) (lft * lft * lft * lft);
          return (object) Math.Pow((double) this._lft, (double) this._rgt);
        case TKID.CONCAT:
          return (object) ((string) this._lft + (string) this._rgt);
        default:
          throw new ArgumentException("Bad expression.");
      }
    }

    public override Expression Optimize()
    {
      this._lft = this._lft.Optimize();
      this._rgt = this._rgt.Optimize();
      if (this._lft._token.Type != TKTYPE.LITERAL || this._rgt._token.Type != TKTYPE.LITERAL)
        return (Expression) this;
      return new Expression(this.Evaluate());
    }
  }
}

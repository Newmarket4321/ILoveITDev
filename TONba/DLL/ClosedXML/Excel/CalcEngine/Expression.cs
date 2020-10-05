// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.CalcEngine.Expression
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Globalization;

namespace ClosedXML.Excel.CalcEngine
{
  internal class Expression : IComparable<Expression>
  {
    private static CultureInfo _ci = CultureInfo.InvariantCulture;
    internal Token _token;

    internal Expression()
    {
      this._token = new Token((object) null, TKID.ATOM, TKTYPE.IDENTIFIER);
    }

    internal Expression(object value)
    {
      this._token = new Token(value, TKID.ATOM, TKTYPE.LITERAL);
    }

    internal Expression(Token tk)
    {
      this._token = tk;
    }

    public virtual object Evaluate()
    {
      if (this._token.Type != TKTYPE.LITERAL)
        throw new ArgumentException("Bad expression.");
      return this._token.Value;
    }

    public virtual Expression Optimize()
    {
      return this;
    }

    public static implicit operator string(Expression x)
    {
      object obj = x.Evaluate();
      if (obj != null)
        return obj.ToString();
      return string.Empty;
    }

    public static implicit operator double(Expression x)
    {
      object obj = x.Evaluate();
      if (obj is double)
        return (double) obj;
      if (obj is bool)
        return (bool) obj ? 1.0 : 0.0;
      if (obj is DateTime)
        return ((DateTime) obj).ToOADate();
      if (obj == null || obj is string)
        return 0.0;
      return (double) Convert.ChangeType(obj, typeof (double), (IFormatProvider) Expression._ci);
    }

    public static implicit operator bool(Expression x)
    {
      object obj = x.Evaluate();
      if (obj is bool)
        return (bool) obj;
      if (obj == null)
        return false;
      if (obj is double)
        return (double) obj != 0.0;
      return (double) x != 0.0;
    }

    public static implicit operator DateTime(Expression x)
    {
      object obj = x.Evaluate();
      if (obj is DateTime)
        return (DateTime) obj;
      if (obj is double)
        return DateTime.FromOADate((double) x);
      return (DateTime) Convert.ChangeType(obj, typeof (DateTime), (IFormatProvider) Expression._ci);
    }

    public int CompareTo(Expression other)
    {
      IComparable comparable1 = this.Evaluate() as IComparable;
      IComparable comparable2 = other.Evaluate() as IComparable;
      if (comparable1 == null && comparable2 == null)
        return 0;
      if (comparable2 == null)
        return -1;
      if (comparable1 == null)
        return 1;
      if (comparable1.GetType() != comparable2.GetType())
        comparable2 = Convert.ChangeType((object) comparable2, comparable1.GetType()) as IComparable;
      return comparable1.CompareTo((object) comparable2);
    }
  }
}

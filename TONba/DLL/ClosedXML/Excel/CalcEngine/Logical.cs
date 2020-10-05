// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.CalcEngine.Logical
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System.Collections.Generic;

namespace ClosedXML.Excel.CalcEngine
{
  internal static class Logical
  {
    public static void Register(ClosedXML.Excel.CalcEngine.CalcEngine ce)
    {
      ce.RegisterFunction("AND", 1, int.MaxValue, new CalcEngineFunction(Logical.And));
      ce.RegisterFunction("OR", 1, int.MaxValue, new CalcEngineFunction(Logical.Or));
      ce.RegisterFunction("NOT", 1, new CalcEngineFunction(Logical.Not));
      ce.RegisterFunction("IF", 2, 3, new CalcEngineFunction(Logical.If));
      ce.RegisterFunction("TRUE", 0, new CalcEngineFunction(Logical.True));
      ce.RegisterFunction("FALSE", 0, new CalcEngineFunction(Logical.False));
    }

    private static object And(List<Expression> p)
    {
      bool flag = true;
      foreach (Expression expression in p)
        flag = flag && (bool) expression;
      return (object) flag;
    }

    private static object Or(List<Expression> p)
    {
      bool flag = false;
      foreach (Expression expression in p)
        flag = flag || (bool) expression;
      return (object) flag;
    }

    private static object Not(List<Expression> p)
    {
      return (object) !(bool) p[0];
    }

    private static object If(List<Expression> p)
    {
      if ((bool) p[0])
        return p[1].Evaluate();
      if (p.Count <= 2)
        return (object) false;
      return p[2].Evaluate();
    }

    private static object True(List<Expression> p)
    {
      return (object) true;
    }

    private static object False(List<Expression> p)
    {
      return (object) false;
    }
  }
}

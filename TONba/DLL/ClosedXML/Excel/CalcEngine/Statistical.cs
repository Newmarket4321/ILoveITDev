// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.CalcEngine.Statistical
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System.Collections;
using System.Collections.Generic;

namespace ClosedXML.Excel.CalcEngine
{
  internal static class Statistical
  {
    public static void Register(ClosedXML.Excel.CalcEngine.CalcEngine ce)
    {
      ce.RegisterFunction("AVERAGE", 1, int.MaxValue, new CalcEngineFunction(Statistical.Average));
      ce.RegisterFunction("AVERAGEA", 1, int.MaxValue, new CalcEngineFunction(Statistical.AverageA));
      ce.RegisterFunction("COUNT", 1, int.MaxValue, new CalcEngineFunction(Statistical.Count));
      ce.RegisterFunction("COUNTA", 1, int.MaxValue, new CalcEngineFunction(Statistical.CountA));
      ce.RegisterFunction("COUNTBLANK", 1, int.MaxValue, new CalcEngineFunction(Statistical.CountBlank));
      ce.RegisterFunction("COUNTIF", 2, new CalcEngineFunction(Statistical.CountIf));
      ce.RegisterFunction("MAX", 1, int.MaxValue, new CalcEngineFunction(Statistical.Max));
      ce.RegisterFunction("MAXA", 1, int.MaxValue, new CalcEngineFunction(Statistical.MaxA));
      ce.RegisterFunction("MIN", 1, int.MaxValue, new CalcEngineFunction(Statistical.Min));
      ce.RegisterFunction("MINA", 1, int.MaxValue, new CalcEngineFunction(Statistical.MinA));
      ce.RegisterFunction("STDEV", 1, int.MaxValue, new CalcEngineFunction(Statistical.StDev));
      ce.RegisterFunction("STDEVA", 1, int.MaxValue, new CalcEngineFunction(Statistical.StDevA));
      ce.RegisterFunction("STDEVP", 1, int.MaxValue, new CalcEngineFunction(Statistical.StDevP));
      ce.RegisterFunction("STDEVPA", 1, int.MaxValue, new CalcEngineFunction(Statistical.StDevPA));
      ce.RegisterFunction("VAR", 1, int.MaxValue, new CalcEngineFunction(Statistical.Var));
      ce.RegisterFunction("VARA", 1, int.MaxValue, new CalcEngineFunction(Statistical.VarA));
      ce.RegisterFunction("VARP", 1, int.MaxValue, new CalcEngineFunction(Statistical.VarP));
      ce.RegisterFunction("VARPA", 1, int.MaxValue, new CalcEngineFunction(Statistical.VarPA));
    }

    private static object Average(List<Expression> p)
    {
      return (object) Statistical.GetTally(p, true).Average();
    }

    private static object AverageA(List<Expression> p)
    {
      return (object) Statistical.GetTally(p, false).Average();
    }

    private static object Count(List<Expression> p)
    {
      return (object) Statistical.GetTally(p, true).Count();
    }

    private static object CountA(List<Expression> p)
    {
      return (object) Statistical.GetTally(p, false).Count();
    }

    private static object CountBlank(List<Expression> p)
    {
      double num = 0.0;
      foreach (Expression expression in p)
      {
        IEnumerable enumerable = expression as IEnumerable;
        if (enumerable != null)
        {
          foreach (object obj in enumerable)
          {
            if (Statistical.IsBlank(obj))
              ++num;
          }
        }
        else if (Statistical.IsBlank(expression.Evaluate()))
          ++num;
      }
      return (object) num;
    }

    private static bool IsBlank(object value)
    {
      if (value == null)
        return true;
      if (value is string)
        return ((string) value).Length == 0;
      return false;
    }

    private static object CountIf(List<Expression> p)
    {
      ClosedXML.Excel.CalcEngine.CalcEngine calcEngine = new ClosedXML.Excel.CalcEngine.CalcEngine();
      double num = 0.0;
      IEnumerable enumerable = p[0] as IEnumerable;
      if (enumerable != null)
      {
        string str = (string) p[1].Evaluate();
        foreach (object obj in enumerable)
        {
          if (!Statistical.IsBlank(obj))
          {
            string expression = string.Format("{0}{1}", obj, (object) str);
            if ((bool) calcEngine.Evaluate(expression))
              ++num;
          }
        }
      }
      return (object) num;
    }

    private static object Max(List<Expression> p)
    {
      return (object) Statistical.GetTally(p, true).Max();
    }

    private static object MaxA(List<Expression> p)
    {
      return (object) Statistical.GetTally(p, false).Max();
    }

    private static object Min(List<Expression> p)
    {
      return (object) Statistical.GetTally(p, true).Min();
    }

    private static object MinA(List<Expression> p)
    {
      return (object) Statistical.GetTally(p, false).Min();
    }

    private static object StDev(List<Expression> p)
    {
      return (object) Statistical.GetTally(p, true).Std();
    }

    private static object StDevA(List<Expression> p)
    {
      return (object) Statistical.GetTally(p, false).Std();
    }

    private static object StDevP(List<Expression> p)
    {
      return (object) Statistical.GetTally(p, true).StdP();
    }

    private static object StDevPA(List<Expression> p)
    {
      return (object) Statistical.GetTally(p, false).StdP();
    }

    private static object Var(List<Expression> p)
    {
      return (object) Statistical.GetTally(p, true).Var();
    }

    private static object VarA(List<Expression> p)
    {
      return (object) Statistical.GetTally(p, false).Var();
    }

    private static object VarP(List<Expression> p)
    {
      return (object) Statistical.GetTally(p, true).VarP();
    }

    private static object VarPA(List<Expression> p)
    {
      return (object) Statistical.GetTally(p, false).VarP();
    }

    private static Tally GetTally(List<Expression> p, bool numbersOnly)
    {
      return new Tally((IEnumerable<Expression>) p);
    }
  }
}

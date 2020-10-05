// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.CalcEngine.Functions.Database
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System.Collections.Generic;

namespace ClosedXML.Excel.CalcEngine.Functions
{
  internal static class Database
  {
    public static void Register(ClosedXML.Excel.CalcEngine.CalcEngine ce)
    {
    }

    private static object Daverage(List<Expression> p)
    {
      bool flag = true;
      foreach (Expression expression in p)
        flag = flag && (bool) expression;
      return (object) flag;
    }
  }
}

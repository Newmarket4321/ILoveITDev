// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.CalcEngine.Text
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ClosedXML.Excel.CalcEngine
{
  internal static class Text
  {
    public static void Register(ClosedXML.Excel.CalcEngine.CalcEngine ce)
    {
      ce.RegisterFunction("ASC", 1, new CalcEngineFunction(ClosedXML.Excel.CalcEngine.Text.Asc));
      ce.RegisterFunction("CHAR", 1, new CalcEngineFunction(ClosedXML.Excel.CalcEngine.Text._Char));
      ce.RegisterFunction("CLEAN", 1, new CalcEngineFunction(ClosedXML.Excel.CalcEngine.Text.Clean));
      ce.RegisterFunction("CODE", 1, new CalcEngineFunction(ClosedXML.Excel.CalcEngine.Text.Code));
      ce.RegisterFunction("CONCATENATE", 1, int.MaxValue, new CalcEngineFunction(ClosedXML.Excel.CalcEngine.Text.Concat));
      ce.RegisterFunction("DOLLAR", 1, 2, new CalcEngineFunction(ClosedXML.Excel.CalcEngine.Text.Dollar));
      ce.RegisterFunction("EXACT", 2, new CalcEngineFunction(ClosedXML.Excel.CalcEngine.Text.Exact));
      ce.RegisterFunction("FIND", 2, 3, new CalcEngineFunction(ClosedXML.Excel.CalcEngine.Text.Find));
      ce.RegisterFunction("FIXED", 1, 3, new CalcEngineFunction(ClosedXML.Excel.CalcEngine.Text.Fixed));
      ce.RegisterFunction("LEFT", 1, 2, new CalcEngineFunction(ClosedXML.Excel.CalcEngine.Text.Left));
      ce.RegisterFunction("LEN", 1, new CalcEngineFunction(ClosedXML.Excel.CalcEngine.Text.Len));
      ce.RegisterFunction("LOWER", 1, new CalcEngineFunction(ClosedXML.Excel.CalcEngine.Text.Lower));
      ce.RegisterFunction("MID", 3, new CalcEngineFunction(ClosedXML.Excel.CalcEngine.Text.Mid));
      ce.RegisterFunction("PROPER", 1, new CalcEngineFunction(ClosedXML.Excel.CalcEngine.Text.Proper));
      ce.RegisterFunction("REPLACE", 4, new CalcEngineFunction(ClosedXML.Excel.CalcEngine.Text.Replace));
      ce.RegisterFunction("REPT", 2, new CalcEngineFunction(ClosedXML.Excel.CalcEngine.Text.Rept));
      ce.RegisterFunction("RIGHT", 1, 2, new CalcEngineFunction(ClosedXML.Excel.CalcEngine.Text.Right));
      ce.RegisterFunction("SEARCH", 2, new CalcEngineFunction(ClosedXML.Excel.CalcEngine.Text.Search));
      ce.RegisterFunction("SUBSTITUTE", 3, 4, new CalcEngineFunction(ClosedXML.Excel.CalcEngine.Text.Substitute));
      ce.RegisterFunction("T", 1, new CalcEngineFunction(ClosedXML.Excel.CalcEngine.Text.T));
      ce.RegisterFunction("TEXT", 2, new CalcEngineFunction(ClosedXML.Excel.CalcEngine.Text._Text));
      ce.RegisterFunction("TRIM", 1, new CalcEngineFunction(ClosedXML.Excel.CalcEngine.Text.Trim));
      ce.RegisterFunction("UPPER", 1, new CalcEngineFunction(ClosedXML.Excel.CalcEngine.Text.Upper));
      ce.RegisterFunction("VALUE", 1, new CalcEngineFunction(ClosedXML.Excel.CalcEngine.Text.Value));
      ce.RegisterFunction("HYPERLINK", 1, new CalcEngineFunction(ClosedXML.Excel.CalcEngine.Text.Hyperlink));
    }

    private static object _Char(List<Expression> p)
    {
      return (object) ((char) (double) p[0]).ToString();
    }

    private static object Code(List<Expression> p)
    {
      return (object) (int) (string) p[0][0];
    }

    private static object Concat(List<Expression> p)
    {
      StringBuilder stringBuilder = new StringBuilder();
      foreach (Expression expression in p)
        stringBuilder.Append((string) expression);
      return (object) stringBuilder.ToString();
    }

    private static object Find(List<Expression> p)
    {
      return (object) ClosedXML.Excel.CalcEngine.Text.IndexOf(p, StringComparison.Ordinal);
    }

    private static int IndexOf(List<Expression> p, StringComparison cmp)
    {
      string str1 = (string) p[0];
      string str2 = (string) p[1];
      int startIndex = 0;
      if (p.Count > 2)
        startIndex = (int) (double) p[2] - 1;
      int num = str2.IndexOf(str1, startIndex, cmp);
      if (num <= -1)
        return num;
      return num + 1;
    }

    private static object Left(List<Expression> p)
    {
      string str = (string) p[0];
      int length = 1;
      if (p.Count > 1)
        length = (int) (double) p[1];
      if (length >= str.Length)
        return (object) str;
      return (object) str.Substring(0, length);
    }

    private static object Len(List<Expression> p)
    {
      return (object) (string) p[0].Length;
    }

    private static object Lower(List<Expression> p)
    {
      return (object) (string) p[0].ToLower();
    }

    private static object Mid(List<Expression> p)
    {
      string str = (string) p[0];
      int startIndex = (int) (double) p[1] - 1;
      int length = (int) (double) p[2];
      if (startIndex > str.Length - 1)
        return (object) string.Empty;
      if (startIndex + length > str.Length - 1)
        return (object) str.Substring(startIndex);
      return (object) str.Substring(startIndex, length);
    }

    private static object Proper(List<Expression> p)
    {
      string str = (string) p[0];
      return (object) (str.Substring(0, 1).ToUpper() + str.Substring(1).ToLower());
    }

    private static object Replace(List<Expression> p)
    {
      string str1 = (string) p[0];
      int length = (int) (double) p[1] - 1;
      int num = (int) (double) p[2];
      string str2 = (string) p[3];
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append(str1.Substring(0, length));
      stringBuilder.Append(str2);
      stringBuilder.Append(str1.Substring(length + num));
      return (object) stringBuilder.ToString();
    }

    private static object Rept(List<Expression> p)
    {
      StringBuilder stringBuilder = new StringBuilder();
      string str = (string) p[0];
      for (int index = 0; index < (int) (double) p[1]; ++index)
        stringBuilder.Append(str);
      return (object) stringBuilder.ToString();
    }

    private static object Right(List<Expression> p)
    {
      string str = (string) p[0];
      int num = 1;
      if (p.Count > 1)
        num = (int) (double) p[1];
      if (num >= str.Length)
        return (object) str;
      return (object) str.Substring(str.Length - num);
    }

    private static object Search(List<Expression> p)
    {
      return (object) ClosedXML.Excel.CalcEngine.Text.IndexOf(p, StringComparison.OrdinalIgnoreCase);
    }

    private static object Substitute(List<Expression> p)
    {
      string str = (string) p[0];
      string oldValue = (string) p[1];
      string newValue = (string) p[2];
      if (p.Count == 3)
        return (object) str.Replace(oldValue, newValue);
      int num = (int) (double) p[3];
      if (num < 1)
        throw new Exception("Invalid index in Substitute.");
      int length;
      for (length = str.IndexOf(oldValue); length > -1 && num > 1; --num)
        length = str.IndexOf(oldValue, length + 1);
      if (length <= -1)
        return (object) str;
      return (object) (str.Substring(0, length) + newValue + str.Substring(length + oldValue.Length));
    }

    private static object T(List<Expression> p)
    {
      return (object) (string) p[0];
    }

    private static object _Text(List<Expression> p)
    {
      return (object) (double) p[0].ToString((string) p[1], (IFormatProvider) CultureInfo.CurrentCulture);
    }

    private static object Trim(List<Expression> p)
    {
      return (object) (string) p[0].Trim(' ');
    }

    private static object Upper(List<Expression> p)
    {
      return (object) (string) p[0].ToUpper();
    }

    private static object Value(List<Expression> p)
    {
      return (object) double.Parse((string) p[0], NumberStyles.Any, (IFormatProvider) CultureInfo.InvariantCulture);
    }

    private static object Asc(List<Expression> p)
    {
      return (object) (string) p[0];
    }

    private static object Hyperlink(List<Expression> p)
    {
      return (object) new XLHyperlink((string) p[0], p.Count == 2 ? (string) p[1] : string.Empty);
    }

    private static object Clean(List<Expression> p)
    {
      string source = (string) p[0];
      StringBuilder stringBuilder = new StringBuilder();
      foreach (char ch in source.Select(c => new
      {
        c = c,
        b = (byte) c
      }).Where(_param0 => (int) _param0.b >= 32).Select(_param0 => _param0.c))
        stringBuilder.Append(ch);
      return (object) stringBuilder.ToString();
    }

    private static object Dollar(List<Expression> p)
    {
      return (object) (double) p[0].ToString("C" + (object) (p.Count == 2 ? (int) (double) p[1] : 2));
    }

    private static object Exact(List<Expression> p)
    {
      return (object) ((string) p[0] == (string) p[1]);
    }

    private static object Fixed(List<Expression> p)
    {
      double num1 = (double) p[0];
      int num2 = p.Count >= 2 ? (int) (double) p[1] : 2;
      bool flag = p.Count != 3 || (bool) p[2];
      string str = num1.ToString("N" + (object) num2);
      if (flag)
        return (object) str;
      return (object) str.Replace(",", string.Empty);
    }
  }
}

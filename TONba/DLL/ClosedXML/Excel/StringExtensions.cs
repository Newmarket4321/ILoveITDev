// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.StringExtensions
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Text.RegularExpressions;

namespace ClosedXML.Excel
{
  public static class StringExtensions
  {
    private static readonly Regex RegexNewLine = new Regex("((?<!\\r)\\n|\\r\\n)", RegexOptions.Compiled);

    public static string FixNewLines(this string value)
    {
      if (!value.Contains("\n"))
        return value;
      return StringExtensions.RegexNewLine.Replace(value, Environment.NewLine);
    }

    public static bool PreserveSpaces(this string value)
    {
      if (!value.StartsWith(" ") && !value.EndsWith(" "))
        return value.Contains(Environment.NewLine);
      return true;
    }

    public static string ToCamel(this string value)
    {
      if (value.Length == 0)
        return value;
      if (value.Length == 1)
        return value.ToLower();
      return value.Substring(0, 1).ToLower() + value.Substring(1);
    }

    public static string ToProper(this string value)
    {
      if (value.Length == 0)
        return value;
      if (value.Length == 1)
        return value.ToUpper();
      return value.Substring(0, 1).ToUpper() + value.Substring(1);
    }
  }
}

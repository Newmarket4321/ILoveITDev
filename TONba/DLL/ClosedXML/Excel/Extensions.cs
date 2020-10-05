// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.Extensions
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ClosedXML.Excel
{
  public static class Extensions
  {
    private static readonly char[] hexDigits = new char[16]
    {
      '0',
      '1',
      '2',
      '3',
      '4',
      '5',
      '6',
      '7',
      '8',
      '9',
      'A',
      'B',
      'C',
      'D',
      'E',
      'F'
    };

    public static string ToHex(this Color color)
    {
      byte[] numArray = new byte[4]
      {
        color.A,
        color.R,
        color.G,
        color.B
      };
      char[] chArray = new char[numArray.Length * 2];
      for (int index = 0; index < numArray.Length; ++index)
      {
        int num = (int) numArray[index];
        chArray[index * 2] = Extensions.hexDigits[num >> 4];
        chArray[index * 2 + 1] = Extensions.hexDigits[num & 15];
      }
      return new string(chArray);
    }

    public static string RemoveSpecialCharacters(this string str)
    {
      StringBuilder stringBuilder = new StringBuilder();
      foreach (char c in str)
      {
        if (char.IsLetterOrDigit(c) || (int) c == 46 || (int) c == 95)
          stringBuilder.Append(c);
      }
      return stringBuilder.ToString();
    }

    public static int CharCount(this string instance, char c)
    {
      return instance.Length - instance.Replace(c.ToString(), "").Length;
    }

    public static bool HasDuplicates<T>(this IEnumerable<T> source)
    {
      HashSet<T> objSet = new HashSet<T>();
      foreach (T obj in source)
      {
        if (objSet.Contains(obj))
          return true;
        objSet.Add(obj);
      }
      return false;
    }

    public static T CastTo<T>(this object o)
    {
      return (T) Convert.ChangeType(o, typeof (T));
    }
  }
}

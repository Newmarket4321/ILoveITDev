// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.EnumerableExtensions
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections.Generic;

namespace ClosedXML.Excel
{
  public static class EnumerableExtensions
  {
    public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
    {
      foreach (T obj in source)
        action(obj);
    }

    public static Type GetItemType<T>(this IEnumerable<T> source)
    {
      return typeof (T);
    }
  }
}

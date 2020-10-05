// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.DictionaryExtensions
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace ClosedXML.Excel
{
  public static class DictionaryExtensions
  {
    public static void RemoveAll<TKey, TValue>(this Dictionary<TKey, TValue> dic, Func<TValue, bool> predicate)
    {
      foreach (TKey key in dic.Keys.Where<TKey>((Func<TKey, bool>) (k => predicate(dic[k]))).ToList<TKey>())
        dic.Remove(key);
    }
  }
}

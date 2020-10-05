// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLDictionary`1
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections.Generic;

namespace ClosedXML.Excel
{
  public class XLDictionary<T> : Dictionary<int, T>
  {
    public XLDictionary()
    {
    }

    public XLDictionary(XLDictionary<T> other)
    {
      other.Values.ForEach<T>(new Action<T>(this.Add));
    }

    public void Initialize(T value)
    {
      if (this.Count > 0)
        this.Clear();
      this.Add(value);
    }

    public void Add(T value)
    {
      this.Add(this.Count + 1, value);
    }
  }
}

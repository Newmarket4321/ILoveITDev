// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLIdManager
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections.Generic;

namespace ClosedXML.Excel
{
  internal class XLIdManager
  {
    private HashSet<int> _hash = new HashSet<int>();

    public int GetNext()
    {
      if (this._hash.Count == 0)
      {
        this._hash.Add(1);
        return 1;
      }
      int num = 1;
      while (this._hash.Contains(num))
        ++num;
      this._hash.Add(num);
      return num;
    }

    public void Add(int value)
    {
      this._hash.Add(value);
    }

    public void Add(IEnumerable<int> values)
    {
      values.ForEach<int>((Action<int>) (v => this._hash.Add(v)));
    }
  }
}

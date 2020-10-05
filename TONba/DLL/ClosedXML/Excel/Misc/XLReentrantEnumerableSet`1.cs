// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.Misc.XLReentrantEnumerableSet`1
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ClosedXML.Excel.Misc
{
  internal class XLReentrantEnumerableSet<T> : IEnumerable<T>, IEnumerable
  {
    private HashSet<T> _hashSet;
    private List<T> _list;
    private int _activeEnumerators;

    public XLReentrantEnumerableSet()
    {
      this._list = new List<T>();
      this._hashSet = new HashSet<T>();
    }

    public void Add(T item)
    {
      if (this._hashSet.Contains(item))
        return;
      this._list.Add(item);
      this._hashSet.Add(item);
    }

    public void Remove(T item)
    {
      this._hashSet.Remove(item);
      this.fixup();
    }

    private void fixup()
    {
      if (this._activeEnumerators > 0 || this._list.Count < 1000 || (double) this._list.Count < (double) this._hashSet.Count * 1.5)
        return;
      this._list = this._list.Where<T>((Func<T, bool>) (item => this._hashSet.Contains(item))).ToList<T>();
    }

    public IEnumerator<T> GetEnumerator()
    {
      ++this._activeEnumerators;
      try
      {
        int idx = 0;
        for (int count = this._list.Count; idx < count; ++idx)
        {
          T item = this._list[idx];
          if (this._hashSet.Contains(item))
            yield return item;
        }
      }
      finally
      {
        --this._activeEnumerators;
        this.fixup();
      }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return (IEnumerator) this.GetEnumerator();
    }
  }
}

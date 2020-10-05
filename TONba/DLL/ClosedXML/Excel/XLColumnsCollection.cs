// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLColumnsCollection
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ClosedXML.Excel
{
  internal class XLColumnsCollection : IDictionary<int, XLColumn>, ICollection<KeyValuePair<int, XLColumn>>, IEnumerable<KeyValuePair<int, XLColumn>>, IEnumerable, IDisposable
  {
    private readonly Dictionary<int, XLColumn> _dictionary = new Dictionary<int, XLColumn>();

    public void ShiftColumnsRight(int startingColumn, int columnsToShift)
    {
      foreach (int key in (IEnumerable<int>) this._dictionary.Keys.Where<int>((Func<int, bool>) (k => k >= startingColumn)).OrderByDescending<int, int>((Func<int, int>) (k => k)))
      {
        XLColumn column = this._dictionary[key];
        int num = key + columnsToShift;
        if (num <= 16384)
        {
          XLColumn xlColumn1 = new XLColumn(column);
          xlColumn1.RangeAddress.FirstAddress = new XLAddress(1, num, false, false);
          xlColumn1.RangeAddress.LastAddress = new XLAddress(1048576, num, false, false);
          XLColumn xlColumn2 = xlColumn1;
          this._dictionary.Add(num, xlColumn2);
        }
        this._dictionary.Remove(key);
      }
    }

    public void Add(int key, XLColumn value)
    {
      this._dictionary.Add(key, value);
    }

    public bool ContainsKey(int key)
    {
      return this._dictionary.ContainsKey(key);
    }

    public ICollection<int> Keys
    {
      get
      {
        return (ICollection<int>) this._dictionary.Keys;
      }
    }

    public bool Remove(int key)
    {
      return this._dictionary.Remove(key);
    }

    public bool TryGetValue(int key, out XLColumn value)
    {
      return this._dictionary.TryGetValue(key, out value);
    }

    public ICollection<XLColumn> Values
    {
      get
      {
        return (ICollection<XLColumn>) this._dictionary.Values;
      }
    }

    public XLColumn this[int key]
    {
      get
      {
        return this._dictionary[key];
      }
      set
      {
        this._dictionary[key] = value;
      }
    }

    public void Add(KeyValuePair<int, XLColumn> item)
    {
      this._dictionary.Add(item.Key, item.Value);
    }

    public void Clear()
    {
      this._dictionary.Clear();
    }

    public bool Contains(KeyValuePair<int, XLColumn> item)
    {
      return this._dictionary.Contains<KeyValuePair<int, XLColumn>>(item);
    }

    public void CopyTo(KeyValuePair<int, XLColumn>[] array, int arrayIndex)
    {
      throw new NotImplementedException();
    }

    public int Count
    {
      get
      {
        return this._dictionary.Count;
      }
    }

    public bool IsReadOnly
    {
      get
      {
        return false;
      }
    }

    public bool Remove(KeyValuePair<int, XLColumn> item)
    {
      return this._dictionary.Remove(item.Key);
    }

    public IEnumerator<KeyValuePair<int, XLColumn>> GetEnumerator()
    {
      return (IEnumerator<KeyValuePair<int, XLColumn>>) this._dictionary.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return (IEnumerator) this._dictionary.GetEnumerator();
    }

    public void RemoveAll(Func<XLColumn, bool> predicate)
    {
      this._dictionary.RemoveAll<int, XLColumn>(predicate);
    }

    public void Dispose()
    {
      this._dictionary.Values.ForEach<XLColumn>((Action<XLColumn>) (c => c.Dispose()));
    }
  }
}

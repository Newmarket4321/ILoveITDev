// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLRowsCollection
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ClosedXML.Excel
{
  internal class XLRowsCollection : IDictionary<int, XLRow>, ICollection<KeyValuePair<int, XLRow>>, IEnumerable<KeyValuePair<int, XLRow>>, IEnumerable, IDisposable
  {
    private readonly Dictionary<int, XLRow> _deleted = new Dictionary<int, XLRow>();
    private readonly Dictionary<int, XLRow> _dictionary = new Dictionary<int, XLRow>();
    public int MaxRowUsed;

    public Dictionary<int, XLRow> Deleted
    {
      get
      {
        return this._deleted;
      }
    }

    public void Add(int key, XLRow value)
    {
      if (key > this.MaxRowUsed)
        this.MaxRowUsed = key;
      if (this._deleted.ContainsKey(key))
        this._deleted.Remove(key);
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
      if (!this._deleted.ContainsKey(key))
        this._deleted.Add(key, this._dictionary[key]);
      return this._dictionary.Remove(key);
    }

    public bool TryGetValue(int key, out XLRow value)
    {
      return this._dictionary.TryGetValue(key, out value);
    }

    public ICollection<XLRow> Values
    {
      get
      {
        return (ICollection<XLRow>) this._dictionary.Values;
      }
    }

    public XLRow this[int key]
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

    public void Add(KeyValuePair<int, XLRow> item)
    {
      if (item.Key > this.MaxRowUsed)
        this.MaxRowUsed = item.Key;
      if (this._deleted.ContainsKey(item.Key))
        this._deleted.Remove(item.Key);
      this._dictionary.Add(item.Key, item.Value);
    }

    public void Clear()
    {
      foreach (KeyValuePair<int, XLRow> keyValuePair in this._dictionary.Where<KeyValuePair<int, XLRow>>((Func<KeyValuePair<int, XLRow>, bool>) (kp => !this._deleted.ContainsKey(kp.Key))))
        this._deleted.Add(keyValuePair.Key, keyValuePair.Value);
      this._dictionary.Clear();
    }

    public bool Contains(KeyValuePair<int, XLRow> item)
    {
      return this._dictionary.Contains<KeyValuePair<int, XLRow>>(item);
    }

    public void CopyTo(KeyValuePair<int, XLRow>[] array, int arrayIndex)
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

    public bool Remove(KeyValuePair<int, XLRow> item)
    {
      if (!this._deleted.ContainsKey(item.Key))
        this._deleted.Add(item.Key, this._dictionary[item.Key]);
      return this._dictionary.Remove(item.Key);
    }

    public IEnumerator<KeyValuePair<int, XLRow>> GetEnumerator()
    {
      return (IEnumerator<KeyValuePair<int, XLRow>>) this._dictionary.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return (IEnumerator) this._dictionary.GetEnumerator();
    }

    public void ShiftRowsDown(int startingRow, int rowsToShift)
    {
      foreach (int key in (IEnumerable<int>) this._dictionary.Keys.Where<int>((Func<int, bool>) (k => k >= startingRow)).OrderByDescending<int, int>((Func<int, int>) (k => k)))
      {
        XLRow row = this._dictionary[key];
        int num = key + rowsToShift;
        if (num <= 1048576)
        {
          XLRow xlRow1 = new XLRow(row);
          xlRow1.RangeAddress.FirstAddress = new XLAddress(num, 1, false, false);
          xlRow1.RangeAddress.LastAddress = new XLAddress(num, 16384, false, false);
          XLRow xlRow2 = xlRow1;
          this._dictionary.Add(num, xlRow2);
        }
        this._dictionary.Remove(key);
      }
    }

    public void RemoveAll(Func<XLRow, bool> predicate)
    {
      foreach (XLRow xlRow in this._dictionary.Values.Where<XLRow>(predicate).Select<XLRow, XLRow>((Func<XLRow, XLRow>) (c => c)).Where<XLRow>((Func<XLRow, bool>) (kp => !this._deleted.ContainsKey(kp.RowNumber()))))
        this._deleted.Add(xlRow.RowNumber(), xlRow);
      this._dictionary.RemoveAll<int, XLRow>(predicate);
    }

    public void Dispose()
    {
      this._dictionary.Values.ForEach<XLRow>((Action<XLRow>) (r => r.Dispose()));
    }
  }
}

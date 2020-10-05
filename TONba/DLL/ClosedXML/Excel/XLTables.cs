// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLTables
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ClosedXML.Excel
{
  public class XLTables : IXLTables, IEnumerable<IXLTable>, IEnumerable
  {
    private readonly Dictionary<string, IXLTable> _tables = new Dictionary<string, IXLTable>();

    public IEnumerator<IXLTable> GetEnumerator()
    {
      return (IEnumerator<IXLTable>) this._tables.Values.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return (IEnumerator) this.GetEnumerator();
    }

    public void Add(IXLTable table)
    {
      this._tables.Add(table.Name, table);
    }

    public IXLTable Table(int index)
    {
      return this._tables.ElementAt<KeyValuePair<string, IXLTable>>(index).Value;
    }

    public IXLTable Table(string name)
    {
      return this._tables[name];
    }

    public IXLTables Clear(XLClearOptions clearOptions = XLClearOptions.ContentsAndFormats)
    {
      this._tables.Values.ForEach<IXLTable>((Action<IXLTable>) (t => t.Clear(clearOptions)));
      return (IXLTables) this;
    }

    public void Remove(int index)
    {
      this._tables.Remove(this._tables.ElementAt<KeyValuePair<string, IXLTable>>(index).Key);
    }

    public void Remove(string name)
    {
      this._tables.Remove(name);
    }
  }
}

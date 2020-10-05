// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLPivotTables
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ClosedXML.Excel
{
  internal class XLPivotTables : IXLPivotTables, IEnumerable<IXLPivotTable>, IEnumerable
  {
    private readonly Dictionary<string, XLPivotTable> _pivotTables = new Dictionary<string, XLPivotTable>();

    public IEnumerator<IXLPivotTable> GetEnumerator()
    {
      return this._pivotTables.Values.Cast<IXLPivotTable>().GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return (IEnumerator) this.GetEnumerator();
    }

    public XLPivotTable PivotTable(string name)
    {
      return this._pivotTables[name];
    }

    IXLPivotTable IXLPivotTables.PivotTable(string name)
    {
      return (IXLPivotTable) this.PivotTable(name);
    }

    public void Delete(string name)
    {
      this._pivotTables.Remove(name);
    }

    public void DeleteAll()
    {
      this._pivotTables.Clear();
    }

    public void Add(string name, IXLPivotTable pivotTable)
    {
      this._pivotTables.Add(name, (XLPivotTable) pivotTable);
    }

    public IXLPivotTable AddNew(string name, IXLCell target, IXLRange source)
    {
      XLPivotTable xlPivotTable = new XLPivotTable()
      {
        Name = name,
        TargetCell = target,
        SourceRange = source
      };
      this._pivotTables.Add(name, xlPivotTable);
      return (IXLPivotTable) xlPivotTable;
    }
  }
}

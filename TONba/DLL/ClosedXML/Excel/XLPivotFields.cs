// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLPivotFields
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ClosedXML.Excel
{
  public class XLPivotFields : IXLPivotFields, IEnumerable<IXLPivotField>, IEnumerable
  {
    private readonly Dictionary<string, IXLPivotField> _pivotFields = new Dictionary<string, IXLPivotField>();

    public IEnumerator<IXLPivotField> GetEnumerator()
    {
      return (IEnumerator<IXLPivotField>) this._pivotFields.Values.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return (IEnumerator) this.GetEnumerator();
    }

    public IXLPivotField Add(string sourceName)
    {
      return this.Add(sourceName, sourceName);
    }

    public IXLPivotField Add(string sourceName, string customName)
    {
      XLPivotField xlPivotField = new XLPivotField(sourceName)
      {
        CustomName = customName
      };
      this._pivotFields.Add(sourceName, (IXLPivotField) xlPivotField);
      return (IXLPivotField) xlPivotField;
    }

    public void Clear()
    {
      this._pivotFields.Clear();
    }

    public void Remove(string sourceName)
    {
      this._pivotFields.Remove(sourceName);
    }

    public int IndexOf(IXLPivotField pf)
    {
      var data = this._pivotFields.Select((item, index) => new
      {
        Item = item,
        Position = index
      }).FirstOrDefault(i => i.Item.Key == pf.SourceName);
      if (data == null)
        throw new IndexOutOfRangeException("Invalid field name.");
      return data.Position;
    }
  }
}

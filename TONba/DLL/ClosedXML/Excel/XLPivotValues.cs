// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLPivotValues
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System.Collections;
using System.Collections.Generic;

namespace ClosedXML.Excel
{
  internal class XLPivotValues : IXLPivotValues, IEnumerable<IXLPivotValue>, IEnumerable
  {
    private readonly Dictionary<string, IXLPivotValue> _pivotValues = new Dictionary<string, IXLPivotValue>();

    public IEnumerator<IXLPivotValue> GetEnumerator()
    {
      return (IEnumerator<IXLPivotValue>) this._pivotValues.Values.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return (IEnumerator) this.GetEnumerator();
    }

    public IXLPivotValue Add(string sourceName)
    {
      return this.Add(sourceName, sourceName);
    }

    public IXLPivotValue Add(string sourceName, string customName)
    {
      XLPivotValue xlPivotValue = new XLPivotValue(sourceName)
      {
        CustomName = customName
      };
      this._pivotValues.Add(sourceName, (IXLPivotValue) xlPivotValue);
      return (IXLPivotValue) xlPivotValue;
    }

    public void Clear()
    {
      this._pivotValues.Clear();
    }

    public void Remove(string sourceName)
    {
      this._pivotValues.Remove(sourceName);
    }
  }
}

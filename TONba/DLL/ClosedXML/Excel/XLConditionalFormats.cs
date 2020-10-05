// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLConditionalFormats
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections;
using System.Collections.Generic;

namespace ClosedXML.Excel
{
  internal class XLConditionalFormats : IXLConditionalFormats, IEnumerable<IXLConditionalFormat>, IEnumerable
  {
    private readonly List<IXLConditionalFormat> _conditionalFormats = new List<IXLConditionalFormat>();

    public void Add(IXLConditionalFormat conditionalFormat)
    {
      this._conditionalFormats.Add(conditionalFormat);
    }

    public IEnumerator<IXLConditionalFormat> GetEnumerator()
    {
      return (IEnumerator<IXLConditionalFormat>) this._conditionalFormats.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return (IEnumerator) this.GetEnumerator();
    }

    public void Remove(Predicate<IXLConditionalFormat> predicate)
    {
      this._conditionalFormats.RemoveAll(predicate);
    }

    public void RemoveAll()
    {
      this._conditionalFormats.Clear();
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLSortElements
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System.Collections;
using System.Collections.Generic;

namespace ClosedXML.Excel
{
  internal class XLSortElements : IXLSortElements, IEnumerable<IXLSortElement>, IEnumerable
  {
    private List<IXLSortElement> elements = new List<IXLSortElement>();

    public void Add(int elementNumber)
    {
      this.Add(elementNumber, XLSortOrder.Ascending);
    }

    public void Add(int elementNumber, XLSortOrder sortOrder)
    {
      this.Add(elementNumber, sortOrder, true);
    }

    public void Add(int elementNumber, XLSortOrder sortOrder, bool ignoreBlanks)
    {
      this.Add(elementNumber, sortOrder, ignoreBlanks, false);
    }

    public void Add(int elementNumber, XLSortOrder sortOrder, bool ignoreBlanks, bool matchCase)
    {
      this.elements.Add((IXLSortElement) new XLSortElement()
      {
        ElementNumber = elementNumber,
        SortOrder = sortOrder,
        IgnoreBlanks = ignoreBlanks,
        MatchCase = matchCase
      });
    }

    public void Add(string elementNumber)
    {
      this.Add(elementNumber, XLSortOrder.Ascending);
    }

    public void Add(string elementNumber, XLSortOrder sortOrder)
    {
      this.Add(elementNumber, sortOrder, true);
    }

    public void Add(string elementNumber, XLSortOrder sortOrder, bool ignoreBlanks)
    {
      this.Add(elementNumber, sortOrder, ignoreBlanks, false);
    }

    public void Add(string elementNumber, XLSortOrder sortOrder, bool ignoreBlanks, bool matchCase)
    {
      this.elements.Add((IXLSortElement) new XLSortElement()
      {
        ElementNumber = XLHelper.GetColumnNumberFromLetter(elementNumber),
        SortOrder = sortOrder,
        IgnoreBlanks = ignoreBlanks,
        MatchCase = matchCase
      });
    }

    public IEnumerator<IXLSortElement> GetEnumerator()
    {
      return (IEnumerator<IXLSortElement>) this.elements.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return (IEnumerator) this.GetEnumerator();
    }

    public void Clear()
    {
      this.elements.Clear();
    }

    public void Remove(int elementNumber)
    {
      this.elements.RemoveAt(elementNumber - 1);
    }
  }
}

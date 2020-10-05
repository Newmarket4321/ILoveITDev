// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLSortElements
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System.Collections;
using System.Collections.Generic;

namespace ClosedXML.Excel
{
  public interface IXLSortElements : IEnumerable<IXLSortElement>, IEnumerable
  {
    void Add(int elementNumber);

    void Add(int elementNumber, XLSortOrder sortOrder);

    void Add(int elementNumber, XLSortOrder sortOrder, bool ignoreBlanks);

    void Add(int elementNumber, XLSortOrder sortOrder, bool ignoreBlanks, bool matchCase);

    void Add(string elementNumber);

    void Add(string elementNumber, XLSortOrder sortOrder);

    void Add(string elementNumber, XLSortOrder sortOrder, bool ignoreBlanks);

    void Add(string elementNumber, XLSortOrder sortOrder, bool ignoreBlanks, bool matchCase);

    void Clear();

    void Remove(int elementNumber);
  }
}

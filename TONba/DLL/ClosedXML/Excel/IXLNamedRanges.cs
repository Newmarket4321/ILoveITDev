// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLNamedRanges
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System.Collections;
using System.Collections.Generic;

namespace ClosedXML.Excel
{
  public interface IXLNamedRanges : IEnumerable<IXLNamedRange>, IEnumerable
  {
    IXLNamedRange NamedRange(string rangeName);

    IXLNamedRange Add(string rangeName, string rangeAddress);

    IXLNamedRange Add(string rangeName, IXLRange range);

    IXLNamedRange Add(string rangeName, IXLRanges ranges);

    IXLNamedRange Add(string rangeName, string rangeAddress, string comment);

    IXLNamedRange Add(string rangeName, IXLRange range, string comment);

    IXLNamedRange Add(string rangeName, IXLRanges ranges, string comment);

    void Delete(string rangeName);

    void Delete(int rangeIndex);

    void DeleteAll();

    bool TryGetValue(string name, out IXLNamedRange range);

    bool Contains(string name);
  }
}

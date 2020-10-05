// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLNamedRanges
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ClosedXML.Excel
{
  internal class XLNamedRanges : IXLNamedRanges, IEnumerable<IXLNamedRange>, IEnumerable
  {
    private readonly Dictionary<string, IXLNamedRange> _namedRanges = new Dictionary<string, IXLNamedRange>();

    internal XLWorkbook Workbook { get; set; }

    public XLNamedRanges(XLWorkbook workbook)
    {
      this.Workbook = workbook;
    }

    public IXLNamedRange NamedRange(string rangeName)
    {
      IXLNamedRange xlNamedRange;
      if (this._namedRanges.TryGetValue(rangeName, out xlNamedRange))
        return xlNamedRange;
      return (IXLNamedRange) null;
    }

    public IXLNamedRange Add(string rangeName, string rangeAddress)
    {
      return this.Add(rangeName, rangeAddress, (string) null);
    }

    public IXLNamedRange Add(string rangeName, IXLRange range)
    {
      return this.Add(rangeName, range, (string) null);
    }

    public IXLNamedRange Add(string rangeName, IXLRanges ranges)
    {
      return this.Add(rangeName, ranges, (string) null);
    }

    public IXLNamedRange Add(string rangeName, string rangeAddress, string comment)
    {
      XLNamedRange xlNamedRange = new XLNamedRange(this, rangeName, rangeAddress, comment);
      this._namedRanges.Add(rangeName, (IXLNamedRange) xlNamedRange);
      return (IXLNamedRange) xlNamedRange;
    }

    public IXLNamedRange Add(string rangeName, IXLRange range, string comment)
    {
      XLRanges xlRanges = new XLRanges()
      {
        (IXLRangeBase) range
      };
      return this.Add(rangeName, (IXLRanges) xlRanges, comment);
    }

    public IXLNamedRange Add(string rangeName, IXLRanges ranges, string comment)
    {
      XLNamedRange xlNamedRange = new XLNamedRange(this, rangeName, ranges, comment);
      this._namedRanges.Add(rangeName, (IXLNamedRange) xlNamedRange);
      return (IXLNamedRange) xlNamedRange;
    }

    public void Delete(string rangeName)
    {
      this._namedRanges.Remove(rangeName);
    }

    public void Delete(int rangeIndex)
    {
      this._namedRanges.Remove(this._namedRanges.ElementAt<KeyValuePair<string, IXLNamedRange>>(rangeIndex).Key);
    }

    public void DeleteAll()
    {
      this._namedRanges.Clear();
    }

    public IEnumerator<IXLNamedRange> GetEnumerator()
    {
      return (IEnumerator<IXLNamedRange>) this._namedRanges.Values.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return (IEnumerator) this.GetEnumerator();
    }

    public bool TryGetValue(string name, out IXLNamedRange range)
    {
      if (this._namedRanges.TryGetValue(name, out range))
        return true;
      range = this.Workbook.NamedRange(name);
      return range != null;
    }

    public bool Contains(string name)
    {
      if (this._namedRanges.ContainsKey(name))
        return true;
      return this.Workbook.NamedRange(name) != null;
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLNamedRange
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace ClosedXML.Excel
{
  internal class XLNamedRange : IXLNamedRange
  {
    private List<string> _rangeList = new List<string>();
    private readonly XLNamedRanges _namedRanges;

    public XLNamedRange(XLNamedRanges namedRanges, string rangeName, string range, string comment = null)
    {
      this.Name = rangeName;
      this._rangeList.Add(range);
      this.Comment = comment;
      this._namedRanges = namedRanges;
    }

    public XLNamedRange(XLNamedRanges namedRanges, string rangeName, IXLRanges ranges, string comment = null)
    {
      this.Name = rangeName;
      ranges.ForEach<IXLRange>((Action<IXLRange>) (r => this._rangeList.Add(r.RangeAddress.ToStringFixed(XLReferenceStyle.A1, true))));
      this.Comment = comment;
      this._namedRanges = namedRanges;
    }

    public string Name { get; set; }

    public IXLRanges Ranges
    {
      get
      {
        XLRanges xlRanges = new XLRanges();
        foreach (IXLRangeBase range in this._rangeList.SelectMany<string, string>((Func<string, IEnumerable<string>>) (c => (IEnumerable<string>) c.Split(','))).Where<string>((Func<string, bool>) (s => (int) s[0] != 34)).Select(rangeAddress => new
        {
          rangeAddress = rangeAddress,
          match = XLHelper.NamedRangeReferenceRegex.Match(rangeAddress)
        }).Select(_param1 =>
        {
          if (!_param1.match.Groups["Sheet"].Success)
            return (IXLRangeBase) this._namedRanges.Workbook.Worksheets.SelectMany<IXLWorksheet, IXLTable>((Func<IXLWorksheet, IEnumerable<IXLTable>>) (sheet => (IEnumerable<IXLTable>) sheet.Tables)).Single<IXLTable>((Func<IXLTable, bool>) (table => table.Name == _param1.match.Groups["Table"].Value)).DataRange.Column(_param1.match.Groups["Column"].Value);
          return (IXLRangeBase) this._namedRanges.Workbook.WorksheetsInternal.Worksheet(_param1.match.Groups["Sheet"].Value).Range(_param1.match.Groups["Range"].Value);
        }))
          xlRanges.Add(range);
        return (IXLRanges) xlRanges;
      }
    }

    public string Comment { get; set; }

    public IXLRanges Add(XLWorkbook workbook, string rangeAddress)
    {
      XLRanges xlRanges = new XLRanges();
      string[] strArray = rangeAddress.Split('!');
      string sheetName = strArray[0].Replace("'", "");
      string rangeAddress1 = strArray[1];
      IXLRange xlRange = workbook.WorksheetsInternal.Worksheet(sheetName).Range(rangeAddress1);
      xlRanges.Add((IXLRangeBase) xlRange);
      return this.Add((IXLRanges) xlRanges);
    }

    public IXLRanges Add(IXLRange range)
    {
      return this.Add((IXLRanges) new XLRanges()
      {
        (IXLRangeBase) range
      });
    }

    public IXLRanges Add(IXLRanges ranges)
    {
      ranges.ForEach<IXLRange>((Action<IXLRange>) (r => this._rangeList.Add(r.ToString())));
      return ranges;
    }

    public void Delete()
    {
      this._namedRanges.Delete(this.Name);
    }

    public void Clear()
    {
      this._rangeList.Clear();
    }

    public void Remove(string rangeAddress)
    {
      this._rangeList.Remove(rangeAddress);
    }

    public void Remove(IXLRange range)
    {
      this._rangeList.Remove(range.ToString());
    }

    public void Remove(IXLRanges ranges)
    {
      ranges.ForEach<IXLRange>((Action<IXLRange>) (r => this._rangeList.Remove(r.ToString())));
    }

    public override string ToString()
    {
      string str = this._rangeList.Aggregate<string, string>(string.Empty, (Func<string, string, string>) ((agg, r) => agg + r + ","));
      if (str.Length > 0)
        str = str.Substring(0, str.Length - 1);
      return str;
    }

    public string RefersTo
    {
      get
      {
        return this.ToString();
      }
      set
      {
        this._rangeList.Clear();
        this._rangeList.Add(value);
      }
    }

    internal List<string> RangeList
    {
      get
      {
        return this._rangeList;
      }
      set
      {
        this._rangeList = value;
      }
    }

    public IXLNamedRange SetRefersTo(string range)
    {
      this.RefersTo = range;
      return (IXLNamedRange) this;
    }

    public IXLNamedRange SetRefersTo(IXLRangeBase range)
    {
      this._rangeList.Clear();
      this._rangeList.Add(range.RangeAddress.ToStringFixed(XLReferenceStyle.A1, true));
      return (IXLNamedRange) this;
    }

    public IXLNamedRange SetRefersTo(IXLRanges ranges)
    {
      this._rangeList.Clear();
      ranges.ForEach<IXLRange>((Action<IXLRange>) (r => this._rangeList.Add(r.RangeAddress.ToStringFixed(XLReferenceStyle.A1, true))));
      return (IXLNamedRange) this;
    }
  }
}

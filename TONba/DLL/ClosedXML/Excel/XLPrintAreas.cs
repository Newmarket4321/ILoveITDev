// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLPrintAreas
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ClosedXML.Excel
{
  internal class XLPrintAreas : IXLPrintAreas, IEnumerable<IXLRange>, IEnumerable
  {
    private List<IXLRange> ranges = new List<IXLRange>();
    private XLWorksheet worksheet;

    public XLPrintAreas(XLWorksheet worksheet)
    {
      this.worksheet = worksheet;
    }

    public XLPrintAreas(XLPrintAreas defaultPrintAreas, XLWorksheet worksheet)
    {
      this.ranges = defaultPrintAreas.ranges.ToList<IXLRange>();
      this.worksheet = worksheet;
    }

    public void Clear()
    {
      this.ranges.Clear();
    }

    public void Add(int firstCellRow, int firstCellColumn, int lastCellRow, int lastCellColumn)
    {
      this.ranges.Add((IXLRange) this.worksheet.Range(firstCellRow, firstCellColumn, lastCellRow, lastCellColumn));
    }

    public void Add(string rangeAddress)
    {
      this.ranges.Add((IXLRange) this.worksheet.Range(rangeAddress));
    }

    public void Add(string firstCellAddress, string lastCellAddress)
    {
      this.ranges.Add((IXLRange) this.worksheet.Range(firstCellAddress, lastCellAddress));
    }

    public void Add(IXLAddress firstCellAddress, IXLAddress lastCellAddress)
    {
      this.ranges.Add((IXLRange) this.worksheet.Range(firstCellAddress, lastCellAddress));
    }

    public IEnumerator<IXLRange> GetEnumerator()
    {
      return (IEnumerator<IXLRange>) this.ranges.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return (IEnumerator) this.GetEnumerator();
    }
  }
}

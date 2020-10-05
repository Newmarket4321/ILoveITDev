// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLCharts
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System.Collections;
using System.Collections.Generic;

namespace ClosedXML.Excel
{
  internal class XLCharts : IXLCharts, IEnumerable<IXLChart>, IEnumerable
  {
    private List<IXLChart> charts = new List<IXLChart>();

    public IEnumerator<IXLChart> GetEnumerator()
    {
      return (IEnumerator<IXLChart>) this.charts.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return (IEnumerator) this.GetEnumerator();
    }

    public void Add(IXLChart chart)
    {
      this.charts.Add(chart);
    }
  }
}

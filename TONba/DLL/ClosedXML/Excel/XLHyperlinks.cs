// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLHyperlinks
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System.Collections;
using System.Collections.Generic;

namespace ClosedXML.Excel
{
  internal class XLHyperlinks : IXLHyperlinks, IEnumerable<XLHyperlink>, IEnumerable
  {
    private Dictionary<IXLAddress, XLHyperlink> hyperlinks = new Dictionary<IXLAddress, XLHyperlink>();

    public IEnumerator<XLHyperlink> GetEnumerator()
    {
      return (IEnumerator<XLHyperlink>) this.hyperlinks.Values.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return (IEnumerator) this.GetEnumerator();
    }

    public void Add(XLHyperlink hyperlink)
    {
      this.hyperlinks.Add(hyperlink.Cell.Address, hyperlink);
    }

    public void Delete(XLHyperlink hyperlink)
    {
      this.hyperlinks.Remove(hyperlink.Cell.Address);
    }

    public void Delete(IXLAddress address)
    {
      this.hyperlinks.Remove(address);
    }
  }
}

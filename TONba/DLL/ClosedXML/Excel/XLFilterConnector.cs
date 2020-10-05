// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLFilterConnector
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  internal class XLFilterConnector : IXLFilterConnector
  {
    private readonly XLAutoFilter _autoFilter;
    private readonly int _column;

    public XLFilterConnector(XLAutoFilter autoFilter, int column)
    {
      this._autoFilter = autoFilter;
      this._column = column;
    }

    public IXLCustomFilteredColumn And
    {
      get
      {
        return (IXLCustomFilteredColumn) new XLCustomFilteredColumn(this._autoFilter, this._column, XLConnector.And);
      }
    }

    public IXLCustomFilteredColumn Or
    {
      get
      {
        return (IXLCustomFilteredColumn) new XLCustomFilteredColumn(this._autoFilter, this._column, XLConnector.Or);
      }
    }
  }
}

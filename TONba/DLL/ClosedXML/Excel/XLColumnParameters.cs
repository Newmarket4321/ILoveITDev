// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLColumnParameters
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  internal class XLColumnParameters
  {
    public XLColumnParameters(XLWorksheet worksheet, int defaultStyleId, bool isReference)
    {
      this.Worksheet = worksheet;
      this.DefaultStyleId = defaultStyleId;
      this.IsReference = isReference;
    }

    public int DefaultStyleId { get; set; }

    public XLWorksheet Worksheet { get; private set; }

    public bool IsReference { get; private set; }
  }
}

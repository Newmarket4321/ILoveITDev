// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLOutline
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  internal class XLOutline : IXLOutline
  {
    public XLOutline(IXLOutline outline)
    {
      if (outline == null)
        return;
      this.SummaryHLocation = outline.SummaryHLocation;
      this.SummaryVLocation = outline.SummaryVLocation;
    }

    public XLOutlineSummaryVLocation SummaryVLocation { get; set; }

    public XLOutlineSummaryHLocation SummaryHLocation { get; set; }
  }
}

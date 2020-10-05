// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLSheetView
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  internal class XLSheetView : IXLSheetView
  {
    public XLSheetView()
    {
      this.View = XLSheetViewOptions.Normal;
    }

    public XLSheetView(IXLSheetView sheetView)
      : this()
    {
      this.SplitRow = sheetView.SplitRow;
      this.SplitColumn = sheetView.SplitColumn;
      this.FreezePanes = ((XLSheetView) sheetView).FreezePanes;
    }

    public int SplitRow { get; set; }

    public int SplitColumn { get; set; }

    public bool FreezePanes { get; set; }

    public void FreezeRows(int rows)
    {
      this.SplitRow = rows;
      this.FreezePanes = true;
    }

    public void FreezeColumns(int columns)
    {
      this.SplitColumn = columns;
      this.FreezePanes = true;
    }

    public void Freeze(int rows, int columns)
    {
      this.SplitRow = rows;
      this.SplitColumn = columns;
      this.FreezePanes = true;
    }

    public XLSheetViewOptions View { get; set; }

    public IXLSheetView SetView(XLSheetViewOptions value)
    {
      this.View = value;
      return (IXLSheetView) this;
    }
  }
}

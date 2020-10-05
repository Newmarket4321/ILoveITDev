// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLSheetView
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  public interface IXLSheetView
  {
    int SplitRow { get; set; }

    int SplitColumn { get; set; }

    void FreezeRows(int rows);

    void FreezeColumns(int columns);

    void Freeze(int rows, int columns);

    XLSheetViewOptions View { get; set; }

    IXLSheetView SetView(XLSheetViewOptions value);
  }
}

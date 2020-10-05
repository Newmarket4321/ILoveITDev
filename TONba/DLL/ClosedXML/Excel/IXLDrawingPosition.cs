// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLDrawingPosition
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  public interface IXLDrawingPosition
  {
    int Column { get; set; }

    IXLDrawingPosition SetColumn(int column);

    double ColumnOffset { get; set; }

    IXLDrawingPosition SetColumnOffset(double columnOffset);

    int Row { get; set; }

    IXLDrawingPosition SetRow(int row);

    double RowOffset { get; set; }

    IXLDrawingPosition SetRowOffset(double rowOffset);
  }
}

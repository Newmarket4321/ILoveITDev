// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLDrawingPosition
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  internal class XLDrawingPosition : IXLDrawingPosition
  {
    public int Column { get; set; }

    public IXLDrawingPosition SetColumn(int column)
    {
      this.Column = column;
      return (IXLDrawingPosition) this;
    }

    public double ColumnOffset { get; set; }

    public IXLDrawingPosition SetColumnOffset(double columnOffset)
    {
      this.ColumnOffset = columnOffset;
      return (IXLDrawingPosition) this;
    }

    public int Row { get; set; }

    public IXLDrawingPosition SetRow(int row)
    {
      this.Row = row;
      return (IXLDrawingPosition) this;
    }

    public double RowOffset { get; set; }

    public IXLDrawingPosition SetRowOffset(double rowOffset)
    {
      this.RowOffset = rowOffset;
      return (IXLDrawingPosition) this;
    }
  }
}

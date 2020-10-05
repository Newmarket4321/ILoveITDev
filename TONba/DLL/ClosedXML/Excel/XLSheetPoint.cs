// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLSheetPoint
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;

namespace ClosedXML.Excel
{
  internal struct XLSheetPoint : IEquatable<XLSheetPoint>
  {
    public readonly int Row;
    public readonly int Column;

    public XLSheetPoint(int row, int column)
    {
      this.Row = row;
      this.Column = column;
    }

    public override bool Equals(object obj)
    {
      return this.Equals((XLSheetPoint) obj);
    }

    public bool Equals(XLSheetPoint other)
    {
      if (this.Row == other.Row)
        return this.Column == other.Column;
      return false;
    }

    public override int GetHashCode()
    {
      return this.Row * -1 ^ this.Column;
    }

    public static bool operator ==(XLSheetPoint a, XLSheetPoint b)
    {
      if (a.Row == b.Row)
        return a.Column == b.Column;
      return false;
    }

    public static bool operator !=(XLSheetPoint a, XLSheetPoint b)
    {
      if (a.Row == b.Row)
        return a.Column != b.Column;
      return true;
    }
  }
}

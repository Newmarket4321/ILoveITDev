// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLSheetRange
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;

namespace ClosedXML.Excel
{
  internal struct XLSheetRange : IEquatable<XLSheetRange>
  {
    public readonly XLSheetPoint FirstPoint;
    public readonly XLSheetPoint LastPoint;

    public XLSheetRange(XLSheetPoint firstPoint, XLSheetPoint lastPoint)
    {
      this.FirstPoint = firstPoint;
      this.LastPoint = lastPoint;
    }

    public bool Equals(XLSheetRange other)
    {
      if (this.FirstPoint.Equals(other.FirstPoint))
        return this.LastPoint.Equals(other.LastPoint);
      return false;
    }

    public override int GetHashCode()
    {
      return this.FirstPoint.GetHashCode() ^ this.LastPoint.GetHashCode();
    }
  }
}

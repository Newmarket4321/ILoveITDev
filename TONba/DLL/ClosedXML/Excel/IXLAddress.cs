// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLAddress
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections.Generic;

namespace ClosedXML.Excel
{
  public interface IXLAddress : IEqualityComparer<IXLAddress>, IEquatable<IXLAddress>
  {
    IXLWorksheet Worksheet { get; }

    int RowNumber { get; }

    int ColumnNumber { get; }

    string ColumnLetter { get; }

    bool FixedRow { get; }

    bool FixedColumn { get; }

    string ToStringRelative();

    string ToStringRelative(bool includeSheet);

    string ToStringFixed();

    string ToStringFixed(XLReferenceStyle referenceStyle);

    string ToStringFixed(XLReferenceStyle referenceStyle, bool includeSheet);

    string ToString(XLReferenceStyle referenceStyle);

    string UniqueId { get; }
  }
}

// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLCustomFilteredColumn
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;

namespace ClosedXML.Excel
{
  public interface IXLCustomFilteredColumn
  {
    void EqualTo<T>(T value) where T : IComparable<T>;

    void NotEqualTo<T>(T value) where T : IComparable<T>;

    void GreaterThan<T>(T value) where T : IComparable<T>;

    void LessThan<T>(T value) where T : IComparable<T>;

    void EqualOrGreaterThan<T>(T value) where T : IComparable<T>;

    void EqualOrLessThan<T>(T value) where T : IComparable<T>;

    void BeginsWith(string value);

    void NotBeginsWith(string value);

    void EndsWith(string value);

    void NotEndsWith(string value);

    void Contains(string value);

    void NotContains(string value);
  }
}

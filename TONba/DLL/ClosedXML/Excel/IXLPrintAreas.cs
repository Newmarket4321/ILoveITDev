// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLPrintAreas
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System.Collections;
using System.Collections.Generic;

namespace ClosedXML.Excel
{
  public interface IXLPrintAreas : IEnumerable<IXLRange>, IEnumerable
  {
    void Clear();

    void Add(int firstCellRow, int firstCellColumn, int lastCellRow, int lastCellColumn);

    void Add(string rangeAddress);

    void Add(string firstCellAddress, string lastCellAddress);

    void Add(IXLAddress firstCellAddress, IXLAddress lastCellAddress);
  }
}

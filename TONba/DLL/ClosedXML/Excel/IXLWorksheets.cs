// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLWorksheets
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace ClosedXML.Excel
{
  public interface IXLWorksheets : IEnumerable<IXLWorksheet>, IEnumerable
  {
    int Count { get; }

    bool TryGetWorksheet(string sheetName, out IXLWorksheet worksheet);

    IXLWorksheet Worksheet(string sheetName);

    IXLWorksheet Worksheet(int position);

    IXLWorksheet Add(string sheetName);

    IXLWorksheet Add(string sheetName, int position);

    IXLWorksheet Add(DataTable dataTable);

    IXLWorksheet Add(DataTable dataTable, string sheetName);

    void Add(DataSet dataSet);

    void Delete(string sheetName);

    void Delete(int position);
  }
}

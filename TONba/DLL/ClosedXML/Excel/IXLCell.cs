// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLCell
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace ClosedXML.Excel
{
  public interface IXLCell
  {
    object Value { get; set; }

    IXLAddress Address { get; }

    XLCellValues DataType { get; set; }

    IXLCell SetDataType(XLCellValues dataType);

    IXLCell SetValue<T>(T value);

    T GetValue<T>();

    string GetString();

    string GetFormattedString();

    double GetDouble();

    bool GetBoolean();

    DateTime GetDateTime();

    TimeSpan GetTimeSpan();

    XLHyperlink GetHyperlink();

    bool TryGetValue<T>(out T value);

    bool HasHyperlink { get; }

    IXLCell Clear(XLClearOptions clearOptions = XLClearOptions.ContentsAndFormats);

    void Delete(XLShiftDeletedCells shiftDeleteCells);

    string FormulaA1 { get; set; }

    IXLCell SetFormulaA1(string formula);

    string FormulaR1C1 { get; set; }

    IXLCell SetFormulaR1C1(string formula);

    IXLRange AsRange();

    IXLStyle Style { get; set; }

    bool ShareString { get; set; }

    IXLRange InsertData(IEnumerable data);

    IXLTable InsertTable<T>(IEnumerable<T> data);

    IXLTable InsertTable<T>(IEnumerable<T> data, bool createTable);

    IXLTable InsertTable<T>(IEnumerable<T> data, string tableName);

    IXLTable InsertTable<T>(IEnumerable<T> data, string tableName, bool createTable);

    IXLTable InsertTable(DataTable data);

    IXLTable InsertTable(DataTable data, bool createTable);

    IXLTable InsertTable(DataTable data, string tableName);

    IXLTable InsertTable(DataTable data, string tableName, bool createTable);

    XLHyperlink Hyperlink { get; set; }

    IXLWorksheet Worksheet { get; }

    IXLDataValidation DataValidation { get; }

    IXLDataValidation NewDataValidation { get; }

    IXLDataValidation SetDataValidation();

    IXLCells InsertCellsAbove(int numberOfRows);

    IXLCells InsertCellsBelow(int numberOfRows);

    IXLCells InsertCellsAfter(int numberOfColumns);

    IXLCells InsertCellsBefore(int numberOfColumns);

    IXLCell AddToNamed(string rangeName);

    IXLCell AddToNamed(string rangeName, XLScope scope);

    IXLCell AddToNamed(string rangeName, XLScope scope, string comment);

    IXLCell CopyFrom(IXLCell otherCell);

    IXLCell CopyFrom(string otherCell);

    IXLCell CopyTo(IXLCell target);

    IXLCell CopyTo(string target);

    string ValueCached { get; }

    IXLRichText RichText { get; }

    bool HasRichText { get; }

    IXLComment Comment { get; }

    bool HasComment { get; }

    bool IsMerged();

    bool IsEmpty();

    bool IsEmpty(bool includeFormats);

    IXLCell CellAbove();

    IXLCell CellAbove(int step);

    IXLCell CellBelow();

    IXLCell CellBelow(int step);

    IXLCell CellLeft();

    IXLCell CellLeft(int step);

    IXLCell CellRight();

    IXLCell CellRight(int step);

    IXLColumn WorksheetColumn();

    IXLRow WorksheetRow();

    bool HasDataValidation { get; }

    IXLConditionalFormat AddConditionalFormat();

    void Select();

    bool Active { get; set; }

    IXLCell SetActive(bool value = true);

    bool HasFormula { get; }

    IXLRangeAddress FormulaReference { get; set; }
  }
}

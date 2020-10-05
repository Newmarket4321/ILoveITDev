// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLSheetProtection
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  public interface IXLSheetProtection
  {
    bool Protected { get; set; }

    bool AutoFilter { get; set; }

    bool DeleteColumns { get; set; }

    bool DeleteRows { get; set; }

    bool FormatCells { get; set; }

    bool FormatColumns { get; set; }

    bool FormatRows { get; set; }

    bool InsertColumns { get; set; }

    bool InsertHyperlinks { get; set; }

    bool InsertRows { get; set; }

    bool Objects { get; set; }

    bool PivotTables { get; set; }

    bool Scenarios { get; set; }

    bool SelectLockedCells { get; set; }

    bool SelectUnlockedCells { get; set; }

    bool Sort { get; set; }

    IXLSheetProtection SetAutoFilter();

    IXLSheetProtection SetAutoFilter(bool value);

    IXLSheetProtection SetDeleteColumns();

    IXLSheetProtection SetDeleteColumns(bool value);

    IXLSheetProtection SetDeleteRows();

    IXLSheetProtection SetDeleteRows(bool value);

    IXLSheetProtection SetFormatCells();

    IXLSheetProtection SetFormatCells(bool value);

    IXLSheetProtection SetFormatColumns();

    IXLSheetProtection SetFormatColumns(bool value);

    IXLSheetProtection SetFormatRows();

    IXLSheetProtection SetFormatRows(bool value);

    IXLSheetProtection SetInsertColumns();

    IXLSheetProtection SetInsertColumns(bool value);

    IXLSheetProtection SetInsertHyperlinks();

    IXLSheetProtection SetInsertHyperlinks(bool value);

    IXLSheetProtection SetInsertRows();

    IXLSheetProtection SetInsertRows(bool value);

    IXLSheetProtection SetObjects();

    IXLSheetProtection SetObjects(bool value);

    IXLSheetProtection SetPivotTables();

    IXLSheetProtection SetPivotTables(bool value);

    IXLSheetProtection SetScenarios();

    IXLSheetProtection SetScenarios(bool value);

    IXLSheetProtection SetSelectLockedCells();

    IXLSheetProtection SetSelectLockedCells(bool value);

    IXLSheetProtection SetSelectUnlockedCells();

    IXLSheetProtection SetSelectUnlockedCells(bool value);

    IXLSheetProtection SetSort();

    IXLSheetProtection SetSort(bool value);

    IXLSheetProtection Protect();

    IXLSheetProtection Protect(string password);

    IXLSheetProtection Unprotect();

    IXLSheetProtection Unprotect(string password);
  }
}

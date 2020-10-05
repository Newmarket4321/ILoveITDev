// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLSheetProtection
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;

namespace ClosedXML.Excel
{
  internal class XLSheetProtection : IXLSheetProtection
  {
    public XLSheetProtection()
    {
      this.SelectLockedCells = true;
      this.SelectUnlockedCells = true;
    }

    public bool Protected { get; set; }

    internal string PasswordHash { get; set; }

    public string Password
    {
      set
      {
        this.PasswordHash = this.GetPasswordHash(value);
      }
    }

    public bool AutoFilter { get; set; }

    public bool DeleteColumns { get; set; }

    public bool DeleteRows { get; set; }

    public bool FormatCells { get; set; }

    public bool FormatColumns { get; set; }

    public bool FormatRows { get; set; }

    public bool InsertColumns { get; set; }

    public bool InsertHyperlinks { get; set; }

    public bool InsertRows { get; set; }

    public bool Objects { get; set; }

    public bool PivotTables { get; set; }

    public bool Scenarios { get; set; }

    public bool SelectLockedCells { get; set; }

    public bool SelectUnlockedCells { get; set; }

    public bool Sort { get; set; }

    public IXLSheetProtection SetAutoFilter()
    {
      this.AutoFilter = true;
      return (IXLSheetProtection) this;
    }

    public IXLSheetProtection SetAutoFilter(bool value)
    {
      this.AutoFilter = value;
      return (IXLSheetProtection) this;
    }

    public IXLSheetProtection SetDeleteColumns()
    {
      this.DeleteColumns = true;
      return (IXLSheetProtection) this;
    }

    public IXLSheetProtection SetDeleteColumns(bool value)
    {
      this.DeleteColumns = value;
      return (IXLSheetProtection) this;
    }

    public IXLSheetProtection SetDeleteRows()
    {
      this.DeleteRows = true;
      return (IXLSheetProtection) this;
    }

    public IXLSheetProtection SetDeleteRows(bool value)
    {
      this.DeleteRows = value;
      return (IXLSheetProtection) this;
    }

    public IXLSheetProtection SetFormatCells()
    {
      this.FormatCells = true;
      return (IXLSheetProtection) this;
    }

    public IXLSheetProtection SetFormatCells(bool value)
    {
      this.FormatCells = value;
      return (IXLSheetProtection) this;
    }

    public IXLSheetProtection SetFormatColumns()
    {
      this.FormatColumns = true;
      return (IXLSheetProtection) this;
    }

    public IXLSheetProtection SetFormatColumns(bool value)
    {
      this.FormatColumns = value;
      return (IXLSheetProtection) this;
    }

    public IXLSheetProtection SetFormatRows()
    {
      this.FormatRows = true;
      return (IXLSheetProtection) this;
    }

    public IXLSheetProtection SetFormatRows(bool value)
    {
      this.FormatRows = value;
      return (IXLSheetProtection) this;
    }

    public IXLSheetProtection SetInsertColumns()
    {
      this.InsertColumns = true;
      return (IXLSheetProtection) this;
    }

    public IXLSheetProtection SetInsertColumns(bool value)
    {
      this.InsertColumns = value;
      return (IXLSheetProtection) this;
    }

    public IXLSheetProtection SetInsertHyperlinks()
    {
      this.InsertHyperlinks = true;
      return (IXLSheetProtection) this;
    }

    public IXLSheetProtection SetInsertHyperlinks(bool value)
    {
      this.InsertHyperlinks = value;
      return (IXLSheetProtection) this;
    }

    public IXLSheetProtection SetInsertRows()
    {
      this.InsertRows = true;
      return (IXLSheetProtection) this;
    }

    public IXLSheetProtection SetInsertRows(bool value)
    {
      this.InsertRows = value;
      return (IXLSheetProtection) this;
    }

    public IXLSheetProtection SetObjects()
    {
      this.Objects = true;
      return (IXLSheetProtection) this;
    }

    public IXLSheetProtection SetObjects(bool value)
    {
      this.Objects = value;
      return (IXLSheetProtection) this;
    }

    public IXLSheetProtection SetPivotTables()
    {
      this.PivotTables = true;
      return (IXLSheetProtection) this;
    }

    public IXLSheetProtection SetPivotTables(bool value)
    {
      this.PivotTables = value;
      return (IXLSheetProtection) this;
    }

    public IXLSheetProtection SetScenarios()
    {
      this.Scenarios = true;
      return (IXLSheetProtection) this;
    }

    public IXLSheetProtection SetScenarios(bool value)
    {
      this.Scenarios = value;
      return (IXLSheetProtection) this;
    }

    public IXLSheetProtection SetSelectLockedCells()
    {
      this.SelectLockedCells = true;
      return (IXLSheetProtection) this;
    }

    public IXLSheetProtection SetSelectLockedCells(bool value)
    {
      this.SelectLockedCells = value;
      return (IXLSheetProtection) this;
    }

    public IXLSheetProtection SetSelectUnlockedCells()
    {
      this.SelectUnlockedCells = true;
      return (IXLSheetProtection) this;
    }

    public IXLSheetProtection SetSelectUnlockedCells(bool value)
    {
      this.SelectUnlockedCells = value;
      return (IXLSheetProtection) this;
    }

    public IXLSheetProtection SetSort()
    {
      this.Sort = true;
      return (IXLSheetProtection) this;
    }

    public IXLSheetProtection SetSort(bool value)
    {
      this.Sort = value;
      return (IXLSheetProtection) this;
    }

    public IXLSheetProtection Protect()
    {
      return this.Protect(string.Empty);
    }

    public IXLSheetProtection Protect(string password)
    {
      if (this.Protected)
        throw new InvalidOperationException("The worksheet is already protected");
      this.Protected = true;
      this.PasswordHash = this.GetPasswordHash(password);
      return (IXLSheetProtection) this;
    }

    public IXLSheetProtection Unprotect()
    {
      return this.Unprotect(string.Empty);
    }

    public IXLSheetProtection Unprotect(string password)
    {
      if (this.Protected)
      {
        if (this.GetPasswordHash(password) != this.PasswordHash)
          throw new ArgumentException("Invalid password");
        this.Protected = false;
        this.PasswordHash = string.Empty;
      }
      return (IXLSheetProtection) this;
    }

    private string GetPasswordHash(string password)
    {
      int length = password.Length;
      int num1 = 0;
      if (length == 0)
        return string.Empty;
      for (int index = length - 1; index >= 0; --index)
      {
        int num2 = num1 ^ (int) password[index];
        num1 = num2 >> 14 & 1 | num2 << 1 & (int) short.MaxValue;
      }
      return (num1 ^ 52811 ^ length).ToString("X");
    }
  }
}

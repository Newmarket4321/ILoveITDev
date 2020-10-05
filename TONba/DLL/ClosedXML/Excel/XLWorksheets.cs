// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLWorksheets
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;

namespace ClosedXML.Excel
{
  internal class XLWorksheets : IXLWorksheets, IEnumerable<IXLWorksheet>, IEnumerable<XLWorksheet>, IEnumerable
  {
    private readonly Dictionary<string, XLWorksheet> _worksheets = new Dictionary<string, XLWorksheet>();
    public HashSet<string> Deleted = new HashSet<string>();
    private readonly XLWorkbook _workbook;

    public XLWorksheets(XLWorkbook workbook)
    {
      this._workbook = workbook;
    }

    public IEnumerator<XLWorksheet> GetEnumerator()
    {
      return ((IEnumerable<XLWorksheet>) this._worksheets.Values).GetEnumerator();
    }

    public int Count
    {
      [DebuggerStepThrough] get
      {
        return this._worksheets.Count;
      }
    }

    public bool TryGetWorksheet(string sheetName, out IXLWorksheet worksheet)
    {
      XLWorksheet xlWorksheet;
      if (this._worksheets.TryGetValue(sheetName, out xlWorksheet))
      {
        worksheet = (IXLWorksheet) xlWorksheet;
        return true;
      }
      worksheet = (IXLWorksheet) null;
      return false;
    }

    public IXLWorksheet Worksheet(string sheetName)
    {
      XLWorksheet xlWorksheet;
      if (this._worksheets.TryGetValue(sheetName, out xlWorksheet))
        return (IXLWorksheet) xlWorksheet;
      IEnumerable<KeyValuePair<string, XLWorksheet>> source = this._worksheets.Where<KeyValuePair<string, XLWorksheet>>((Func<KeyValuePair<string, XLWorksheet>, bool>) (ws => ws.Key.ToLower().Equals(sheetName.ToLower())));
      if (source.Any<KeyValuePair<string, XLWorksheet>>())
        return (IXLWorksheet) source.First<KeyValuePair<string, XLWorksheet>>().Value;
      throw new Exception("There isn't a worksheet named '" + sheetName + "'.");
    }

    public IXLWorksheet Worksheet(int position)
    {
      int num = this._worksheets.Values.Count<XLWorksheet>((Func<XLWorksheet, bool>) (w => w.Position == position));
      if (num == 0)
        throw new Exception("There isn't a worksheet associated with that position.");
      if (num > 1)
        throw new Exception("Can't retrieve a worksheet because there are multiple worksheets associated with that position.");
      return (IXLWorksheet) this._worksheets.Values.Single<XLWorksheet>((Func<XLWorksheet, bool>) (w => w.Position == position));
    }

    public IXLWorksheet Add(string sheetName)
    {
      XLWorksheet xlWorksheet = new XLWorksheet(sheetName, this._workbook);
      this._worksheets.Add(sheetName, xlWorksheet);
      xlWorksheet._position = this._worksheets.Count + this._workbook.UnsupportedSheets.Count;
      return (IXLWorksheet) xlWorksheet;
    }

    public IXLWorksheet Add(string sheetName, int position)
    {
      this._worksheets.Values.Where<XLWorksheet>((Func<XLWorksheet, bool>) (w => w._position >= position)).ForEach<XLWorksheet>((Action<XLWorksheet>) (w => ++w._position));
      this._workbook.UnsupportedSheets.Where<XLWorkbook.UnsupportedSheet>((Func<XLWorkbook.UnsupportedSheet, bool>) (w => w.Position >= position)).ForEach<XLWorkbook.UnsupportedSheet>((Action<XLWorkbook.UnsupportedSheet>) (w => ++w.Position));
      XLWorksheet xlWorksheet = new XLWorksheet(sheetName, this._workbook);
      this._worksheets.Add(sheetName, xlWorksheet);
      xlWorksheet._position = position;
      return (IXLWorksheet) xlWorksheet;
    }

    public void Delete(string sheetName)
    {
      this.Delete(this._worksheets[sheetName].Position);
    }

    public void Delete(int position)
    {
      int num = this._worksheets.Values.Count<XLWorksheet>((Func<XLWorksheet, bool>) (w => w.Position == position));
      if (num == 0)
        throw new Exception("There isn't a worksheet associated with that index.");
      if (num > 1)
        throw new Exception("Can't delete the worksheet because there are multiple worksheets associated with that index.");
      XLWorksheet xlWorksheet = this._worksheets.Values.Single<XLWorksheet>((Func<XLWorksheet, bool>) (w => w.Position == position));
      if (!XLHelper.IsNullOrWhiteSpace(xlWorksheet.RelId) && !this.Deleted.Contains(xlWorksheet.RelId))
        this.Deleted.Add(xlWorksheet.RelId);
      this._worksheets.RemoveAll<string, XLWorksheet>((Func<XLWorksheet, bool>) (w => w.Position == position));
      this._worksheets.Values.Where<XLWorksheet>((Func<XLWorksheet, bool>) (w => w.Position > position)).ForEach<XLWorksheet>((Action<XLWorksheet>) (w => --w._position));
      this._workbook.UnsupportedSheets.Where<XLWorkbook.UnsupportedSheet>((Func<XLWorkbook.UnsupportedSheet, bool>) (w => w.Position > position)).ForEach<XLWorkbook.UnsupportedSheet>((Action<XLWorkbook.UnsupportedSheet>) (w => --w.Position));
    }

    IEnumerator<IXLWorksheet> IEnumerable<IXLWorksheet>.GetEnumerator()
    {
      return this._worksheets.Values.Cast<IXLWorksheet>().GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return (IEnumerator) this.GetEnumerator();
    }

    public IXLWorksheet Add(DataTable dataTable)
    {
      return this.Add(dataTable, dataTable.TableName);
    }

    public IXLWorksheet Add(DataTable dataTable, string sheetName)
    {
      IXLWorksheet xlWorksheet = this.Add(sheetName);
      xlWorksheet.Cell(1, 1).InsertTable(dataTable);
      xlWorksheet.Columns().AdjustToContents(1, 75);
      return xlWorksheet;
    }

    public void Add(DataSet dataSet)
    {
      foreach (DataTable table in (InternalDataCollectionBase) dataSet.Tables)
        this.Add(table);
    }

    public void Rename(string oldSheetName, string newSheetName)
    {
      if (XLHelper.IsNullOrWhiteSpace(oldSheetName) || !this._worksheets.ContainsKey(oldSheetName))
        return;
      XLWorksheet worksheet = this._worksheets[oldSheetName];
      this._worksheets.Remove(oldSheetName);
      this._worksheets.Add(newSheetName, worksheet);
    }
  }
}

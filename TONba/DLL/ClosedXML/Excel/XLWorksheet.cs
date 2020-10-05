// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLWorksheet
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using ClosedXML.Excel.CalcEngine;
using ClosedXML.Excel.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClosedXML.Excel
{
  internal class XLWorksheet : XLRangeBase, IXLWorksheet, IXLRangeBase, IDisposable
  {
    private readonly Dictionary<int, int> _columnOutlineCount = new Dictionary<int, int>();
    private readonly Dictionary<int, int> _rowOutlineCount = new Dictionary<int, int>();
    internal int ZOrder = 1;
    private const string InvalidNameChars = ":\\/?*[]";
    public XLReentrantEnumerableSet<XLCallbackAction> RangeShiftedRows;
    public XLReentrantEnumerableSet<XLCallbackAction> RangeShiftedColumns;
    private string _name;
    internal int _position;
    private double _rowHeight;
    private bool _tabActive;
    internal bool EventTrackingEnabled;
    public string LegacyDrawingId;
    public bool LegacyDrawingIsNew;
    private double _columnWidth;
    private XLWorksheetVisibility _visibility;
    private bool _eventTracking;
    private XLCalcEngine _calcEngine;

    public XLWorksheet(string sheetName, XLWorkbook workbook)
      : base(new XLRangeAddress(new XLAddress((XLWorksheet) null, 1, 1, false, false), new XLAddress((XLWorksheet) null, 1048576, 16384, false, false)))
    {
      this.EventTrackingEnabled = workbook.EventTracking == XLEventTracking.Enabled;
      this.RangeShiftedRows = new XLReentrantEnumerableSet<XLCallbackAction>();
      this.RangeShiftedColumns = new XLReentrantEnumerableSet<XLCallbackAction>();
      this.RangeAddress.Worksheet = this;
      this.RangeAddress.FirstAddress.Worksheet = this;
      this.RangeAddress.LastAddress.Worksheet = this;
      this.NamedRanges = (IXLNamedRanges) new XLNamedRanges(workbook);
      this.SheetView = (IXLSheetView) new XLSheetView();
      this.Tables = (IXLTables) new XLTables();
      this.Hyperlinks = (IXLHyperlinks) new XLHyperlinks();
      this.DataValidations = new XLDataValidations();
      this.PivotTables = (IXLPivotTables) new XLPivotTables();
      this.Protection = new XLSheetProtection();
      this.AutoFilter = new XLAutoFilter();
      this.ConditionalFormats = (IXLConditionalFormats) new XLConditionalFormats();
      this.Workbook = workbook;
      this.SetStyle(workbook.Style);
      this.Internals = new XLWorksheetInternals(new XLCellsCollection(), new XLColumnsCollection(), new XLRowsCollection(), new XLRanges());
      this.PageSetup = (IXLPageSetup) new XLPageSetup((XLPageSetup) workbook.PageOptions, this);
      this.Outline = (IXLOutline) new XLOutline(workbook.Outline);
      this._columnWidth = workbook.ColumnWidth;
      this._rowHeight = workbook.RowHeight;
      this.RowHeightChanged = Math.Abs(workbook.RowHeight - XLWorkbook.DefaultRowHeight) > 1E-10;
      this.Name = sheetName;
      this.SubscribeToShiftedRows((Action<XLRange, int>) ((range, rowsShifted) => this.WorksheetRangeShiftedRows(range, rowsShifted)));
      this.SubscribeToShiftedColumns((Action<XLRange, int>) ((range, columnsShifted) => this.WorksheetRangeShiftedColumns(range, columnsShifted)));
      this.Charts = (IXLCharts) new XLCharts();
      this.ShowFormulas = workbook.ShowFormulas;
      this.ShowGridLines = workbook.ShowGridLines;
      this.ShowOutlineSymbols = workbook.ShowOutlineSymbols;
      this.ShowRowColHeaders = workbook.ShowRowColHeaders;
      this.ShowRuler = workbook.ShowRuler;
      this.ShowWhiteSpace = workbook.ShowWhiteSpace;
      this.ShowZeros = workbook.ShowZeros;
      this.RightToLeft = workbook.RightToLeft;
      this.TabColor = XLColor.NoColor;
      this.SelectedRanges = (IXLRanges) new XLRanges();
      this.Author = workbook.Author;
    }

    public XLWorksheetInternals Internals { get; private set; }

    public override IEnumerable<IXLStyle> Styles
    {
      get
      {
        this.UpdatingStyle = true;
        yield return this.GetStyle();
        foreach (XLCell cell in this.Internals.CellsCollection.GetCells())
          yield return cell.Style;
        this.UpdatingStyle = false;
      }
    }

    public override bool UpdatingStyle { get; set; }

    public override IXLStyle InnerStyle
    {
      get
      {
        return this.GetStyle();
      }
      set
      {
        this.SetStyle(value);
      }
    }

    internal bool RowHeightChanged { get; set; }

    internal bool ColumnWidthChanged { get; set; }

    public int SheetId { get; set; }

    public string RelId { get; set; }

    public XLDataValidations DataValidations { get; private set; }

    public IXLCharts Charts { get; private set; }

    public XLSheetProtection Protection { get; private set; }

    public XLAutoFilter AutoFilter { get; private set; }

    public XLWorkbook Workbook { get; private set; }

    public override IXLStyle Style
    {
      get
      {
        return this.GetStyle();
      }
      set
      {
        this.SetStyle(value);
        foreach (XLCell cell in this.Internals.CellsCollection.GetCells())
          cell.Style = value;
      }
    }

    public double ColumnWidth
    {
      get
      {
        return this._columnWidth;
      }
      set
      {
        this.ColumnWidthChanged = true;
        this._columnWidth = value;
      }
    }

    public double RowHeight
    {
      get
      {
        return this._rowHeight;
      }
      set
      {
        this.RowHeightChanged = true;
        this._rowHeight = value;
      }
    }

    public string Name
    {
      get
      {
        return this._name;
      }
      set
      {
        if (value.IndexOfAny(":\\/?*[]".ToCharArray()) != -1)
          throw new ArgumentException("Worksheet names cannot contain any of the following characters: :\\/?*[]");
        if (XLHelper.IsNullOrWhiteSpace(value))
          throw new ArgumentException("Worksheet names cannot be empty");
        if (value.Length > 31)
          throw new ArgumentException("Worksheet names cannot be more than 31 characters");
        this.Workbook.WorksheetsInternal.Rename(this._name, value);
        this._name = value;
      }
    }

    public int Position
    {
      get
      {
        return this._position;
      }
      set
      {
        if (value > this.Workbook.WorksheetsInternal.Count + this.Workbook.UnsupportedSheets.Count + 1)
          throw new IndexOutOfRangeException("Index must be equal or less than the number of worksheets + 1.");
        if (value < this._position)
          this.Workbook.WorksheetsInternal.Where<XLWorksheet>((Func<XLWorksheet, bool>) (w =>
          {
            if (w.Position >= value)
              return w.Position < this._position;
            return false;
          })).ForEach<XLWorksheet>((Action<XLWorksheet>) (w => ++w._position));
        if (value > this._position)
          this.Workbook.WorksheetsInternal.Where<XLWorksheet>((Func<XLWorksheet, bool>) (w =>
          {
            if (w.Position <= value)
              return w.Position > this._position;
            return false;
          })).ForEach<XLWorksheet>((Action<XLWorksheet>) (w => --w._position));
        this._position = value;
      }
    }

    public IXLPageSetup PageSetup { get; private set; }

    public IXLOutline Outline { get; private set; }

    IXLRow IXLWorksheet.FirstRowUsed()
    {
      return (IXLRow) this.FirstRowUsed();
    }

    IXLRow IXLWorksheet.FirstRowUsed(bool includeFormats)
    {
      return (IXLRow) this.FirstRowUsed(includeFormats);
    }

    IXLRow IXLWorksheet.LastRowUsed()
    {
      return (IXLRow) this.LastRowUsed();
    }

    IXLRow IXLWorksheet.LastRowUsed(bool includeFormats)
    {
      return (IXLRow) this.LastRowUsed(includeFormats);
    }

    IXLColumn IXLWorksheet.LastColumn()
    {
      return (IXLColumn) this.LastColumn();
    }

    IXLColumn IXLWorksheet.FirstColumn()
    {
      return (IXLColumn) this.FirstColumn();
    }

    IXLRow IXLWorksheet.FirstRow()
    {
      return (IXLRow) this.FirstRow();
    }

    IXLRow IXLWorksheet.LastRow()
    {
      return (IXLRow) this.LastRow();
    }

    IXLColumn IXLWorksheet.FirstColumnUsed()
    {
      return (IXLColumn) this.FirstColumnUsed();
    }

    IXLColumn IXLWorksheet.FirstColumnUsed(bool includeFormats)
    {
      return (IXLColumn) this.FirstColumnUsed(includeFormats);
    }

    IXLColumn IXLWorksheet.LastColumnUsed()
    {
      return (IXLColumn) this.LastColumnUsed();
    }

    IXLColumn IXLWorksheet.LastColumnUsed(bool includeFormats)
    {
      return (IXLColumn) this.LastColumnUsed(includeFormats);
    }

    public IXLColumns Columns()
    {
      XLColumns xlColumns = new XLColumns(this);
      List<int> columnList = new List<int>();
      if (this.Internals.CellsCollection.Count > 0)
        columnList.AddRange((IEnumerable<int>) this.Internals.CellsCollection.ColumnsUsed.Keys);
      if (this.Internals.ColumnsCollection.Count > 0)
        columnList.AddRange(this.Internals.ColumnsCollection.Keys.Where<int>((Func<int, bool>) (c => !columnList.Contains(c))));
      foreach (int column in columnList)
        xlColumns.Add(this.Column(column));
      return (IXLColumns) xlColumns;
    }

    public IXLColumns Columns(string columns)
    {
      XLColumns xlColumns = new XLColumns((XLWorksheet) null);
      foreach (string str1 in ((IEnumerable<string>) columns.Split(',')).Select<string, string>((Func<string, string>) (pair => pair.Trim())))
      {
        string str2;
        string str3;
        if (str1.Contains<char>(':') || str1.Contains<char>('-'))
        {
          string[] strArray = XLHelper.SplitRange(str1);
          str2 = strArray[0];
          str3 = strArray[1];
        }
        else
        {
          str2 = str1;
          str3 = str1;
        }
        int result;
        if (int.TryParse(str2, out result))
        {
          foreach (IXLColumn column in (IEnumerable<IXLColumn>) this.Columns(int.Parse(str2), int.Parse(str3)))
            xlColumns.Add((XLColumn) column);
        }
        else
        {
          foreach (IXLColumn column in (IEnumerable<IXLColumn>) this.Columns(str2, str3))
            xlColumns.Add((XLColumn) column);
        }
      }
      return (IXLColumns) xlColumns;
    }

    public IXLColumns Columns(string firstColumn, string lastColumn)
    {
      return this.Columns(XLHelper.GetColumnNumberFromLetter(firstColumn), XLHelper.GetColumnNumberFromLetter(lastColumn));
    }

    public IXLColumns Columns(int firstColumn, int lastColumn)
    {
      XLColumns xlColumns = new XLColumns((XLWorksheet) null);
      for (int column = firstColumn; column <= lastColumn; ++column)
        xlColumns.Add(this.Column(column));
      return (IXLColumns) xlColumns;
    }

    public IXLRows Rows()
    {
      XLRows xlRows = new XLRows(this);
      List<int> rowList = new List<int>();
      if (this.Internals.CellsCollection.Count > 0)
        rowList.AddRange((IEnumerable<int>) this.Internals.CellsCollection.RowsUsed.Keys);
      if (this.Internals.RowsCollection.Count > 0)
        rowList.AddRange(this.Internals.RowsCollection.Keys.Where<int>((Func<int, bool>) (r => !rowList.Contains(r))));
      foreach (int row in rowList)
        xlRows.Add(this.Row(row));
      return (IXLRows) xlRows;
    }

    public IXLRows Rows(string rows)
    {
      XLRows xlRows = new XLRows((XLWorksheet) null);
      foreach (string str in ((IEnumerable<string>) rows.Split(',')).Select<string, string>((Func<string, string>) (pair => pair.Trim())))
      {
        string s1;
        string s2;
        if (str.Contains<char>(':') || str.Contains<char>('-'))
        {
          string[] strArray = XLHelper.SplitRange(str);
          s1 = strArray[0];
          s2 = strArray[1];
        }
        else
        {
          s1 = str;
          s2 = str;
        }
        foreach (IXLRow row in (IEnumerable<IXLRow>) this.Rows(int.Parse(s1), int.Parse(s2)))
          xlRows.Add((XLRow) row);
      }
      return (IXLRows) xlRows;
    }

    public IXLRows Rows(int firstRow, int lastRow)
    {
      XLRows xlRows = new XLRows((XLWorksheet) null);
      for (int row = firstRow; row <= lastRow; ++row)
        xlRows.Add(this.Row(row));
      return (IXLRows) xlRows;
    }

    IXLRow IXLWorksheet.Row(int row)
    {
      return (IXLRow) this.Row(row);
    }

    IXLColumn IXLWorksheet.Column(int column)
    {
      return (IXLColumn) this.Column(column);
    }

    IXLColumn IXLWorksheet.Column(string column)
    {
      return this.Column(column);
    }

    IXLCell IXLWorksheet.Cell(int row, int column)
    {
      return (IXLCell) this.Cell(row, column);
    }

    IXLCell IXLWorksheet.Cell(string cellAddressInRange)
    {
      return (IXLCell) this.Cell(cellAddressInRange);
    }

    IXLCell IXLWorksheet.Cell(int row, string column)
    {
      return (IXLCell) this.Cell(row, column);
    }

    IXLCell IXLWorksheet.Cell(IXLAddress cellAddressInRange)
    {
      return (IXLCell) this.Cell(cellAddressInRange);
    }

    IXLRange IXLWorksheet.Range(IXLRangeAddress rangeAddress)
    {
      return (IXLRange) this.Range(rangeAddress);
    }

    IXLRange IXLWorksheet.Range(string rangeAddress)
    {
      return (IXLRange) this.Range(rangeAddress);
    }

    IXLRange IXLWorksheet.Range(IXLCell firstCell, IXLCell lastCell)
    {
      return (IXLRange) this.Range(firstCell, lastCell);
    }

    IXLRange IXLWorksheet.Range(string firstCellAddress, string lastCellAddress)
    {
      return (IXLRange) this.Range(firstCellAddress, lastCellAddress);
    }

    IXLRange IXLWorksheet.Range(IXLAddress firstCellAddress, IXLAddress lastCellAddress)
    {
      return (IXLRange) this.Range(firstCellAddress, lastCellAddress);
    }

    IXLRange IXLWorksheet.Range(int firstCellRow, int firstCellColumn, int lastCellRow, int lastCellColumn)
    {
      return (IXLRange) this.Range(firstCellRow, firstCellColumn, lastCellRow, lastCellColumn);
    }

    public IXLWorksheet CollapseRows()
    {
      Enumerable.Range(1, 8).ForEach<int>((Action<int>) (i => this.CollapseRows(i)));
      return (IXLWorksheet) this;
    }

    public IXLWorksheet CollapseColumns()
    {
      Enumerable.Range(1, 8).ForEach<int>((Action<int>) (i => this.CollapseColumns(i)));
      return (IXLWorksheet) this;
    }

    public IXLWorksheet ExpandRows()
    {
      Enumerable.Range(1, 8).ForEach<int>((Action<int>) (i => this.ExpandRows(i)));
      return (IXLWorksheet) this;
    }

    public IXLWorksheet ExpandColumns()
    {
      Enumerable.Range(1, 8).ForEach<int>((Action<int>) (i => this.ExpandRows(i)));
      return (IXLWorksheet) this;
    }

    public IXLWorksheet CollapseRows(int outlineLevel)
    {
      if (outlineLevel < 1 || outlineLevel > 8)
        throw new ArgumentOutOfRangeException(nameof (outlineLevel), "Outline level must be between 1 and 8.");
      this.Internals.RowsCollection.Values.Where<XLRow>((Func<XLRow, bool>) (r => r.OutlineLevel == outlineLevel)).ForEach<XLRow>((Action<XLRow>) (r => r.Collapse()));
      return (IXLWorksheet) this;
    }

    public IXLWorksheet CollapseColumns(int outlineLevel)
    {
      if (outlineLevel < 1 || outlineLevel > 8)
        throw new ArgumentOutOfRangeException(nameof (outlineLevel), "Outline level must be between 1 and 8.");
      this.Internals.ColumnsCollection.Values.Where<XLColumn>((Func<XLColumn, bool>) (c => c.OutlineLevel == outlineLevel)).ForEach<XLColumn>((Action<XLColumn>) (c => c.Collapse()));
      return (IXLWorksheet) this;
    }

    public IXLWorksheet ExpandRows(int outlineLevel)
    {
      if (outlineLevel < 1 || outlineLevel > 8)
        throw new ArgumentOutOfRangeException(nameof (outlineLevel), "Outline level must be between 1 and 8.");
      this.Internals.RowsCollection.Values.Where<XLRow>((Func<XLRow, bool>) (r => r.OutlineLevel == outlineLevel)).ForEach<XLRow>((Action<XLRow>) (r => r.Expand()));
      return (IXLWorksheet) this;
    }

    public IXLWorksheet ExpandColumns(int outlineLevel)
    {
      if (outlineLevel < 1 || outlineLevel > 8)
        throw new ArgumentOutOfRangeException(nameof (outlineLevel), "Outline level must be between 1 and 8.");
      this.Internals.ColumnsCollection.Values.Where<XLColumn>((Func<XLColumn, bool>) (c => c.OutlineLevel == outlineLevel)).ForEach<XLColumn>((Action<XLColumn>) (c => c.Expand()));
      return (IXLWorksheet) this;
    }

    public void Delete()
    {
      this.Workbook.WorksheetsInternal.Delete(this.Name);
    }

    public IXLNamedRanges NamedRanges { get; private set; }

    public IXLNamedRange NamedRange(string rangeName)
    {
      return this.NamedRanges.NamedRange(rangeName);
    }

    public IXLSheetView SheetView { get; private set; }

    public IXLTables Tables { get; private set; }

    public IXLTable Table(int index)
    {
      return this.Tables.Table(index);
    }

    public IXLTable Table(string name)
    {
      return this.Tables.Table(name);
    }

    public IXLWorksheet CopyTo(string newSheetName)
    {
      return this.CopyTo(this.Workbook, newSheetName, this.Workbook.WorksheetsInternal.Count + 1);
    }

    public IXLWorksheet CopyTo(string newSheetName, int position)
    {
      return this.CopyTo(this.Workbook, newSheetName, position);
    }

    public IXLWorksheet CopyTo(XLWorkbook workbook, string newSheetName)
    {
      return this.CopyTo(workbook, newSheetName, workbook.WorksheetsInternal.Count + 1);
    }

    public IXLWorksheet CopyTo(XLWorkbook workbook, string newSheetName, int position)
    {
      XLWorksheet targetSheet = (XLWorksheet) workbook.WorksheetsInternal.Add(newSheetName, position);
      this.Internals.ColumnsCollection.ForEach<KeyValuePair<int, XLColumn>>((Action<KeyValuePair<int, XLColumn>>) (kp => targetSheet.Internals.ColumnsCollection.Add(kp.Key, new XLColumn(kp.Value))));
      this.Internals.RowsCollection.ForEach<KeyValuePair<int, XLRow>>((Action<KeyValuePair<int, XLRow>>) (kp => targetSheet.Internals.RowsCollection.Add(kp.Key, new XLRow(kp.Value))));
      this.Internals.CellsCollection.GetCells().ForEach<XLCell>((Action<XLCell>) (c => targetSheet.Cell(c.Address).CopyFrom(c, false)));
      this.DataValidations.ForEach<IXLDataValidation>((Action<IXLDataValidation>) (dv => targetSheet.DataValidations.Add((IXLDataValidation) new XLDataValidation(dv))));
      targetSheet.Visibility = this.Visibility;
      targetSheet.ColumnWidth = this.ColumnWidth;
      targetSheet.ColumnWidthChanged = this.ColumnWidthChanged;
      targetSheet.RowHeight = this.RowHeight;
      targetSheet.RowHeightChanged = this.RowHeightChanged;
      targetSheet.SetStyle(this.Style);
      targetSheet.PageSetup = (IXLPageSetup) new XLPageSetup((XLPageSetup) this.PageSetup, targetSheet);
      (targetSheet.PageSetup.Header as XLHeaderFooter).Changed = true;
      (targetSheet.PageSetup.Footer as XLHeaderFooter).Changed = true;
      targetSheet.Outline = (IXLOutline) new XLOutline(this.Outline);
      targetSheet.SheetView = (IXLSheetView) new XLSheetView(this.SheetView);
      this.Internals.MergedRanges.ForEach<IXLRange>((Action<IXLRange>) (kp => targetSheet.Internals.MergedRanges.Add(targetSheet.Range(kp.RangeAddress.ToString()))));
      foreach (IXLNamedRange namedRange in (IEnumerable<IXLNamedRange>) this.NamedRanges)
      {
        XLRanges xlRanges = new XLRanges();
        namedRange.Ranges.ForEach<IXLRange>(new Action<IXLRange>(xlRanges.Add));
        targetSheet.NamedRanges.Add(namedRange.Name, (IXLRanges) xlRanges);
      }
      foreach (XLTable xlTable in this.Tables.Cast<XLTable>())
      {
        string tableName = xlTable.Name;
        XLTable table = targetSheet.Tables.Any<IXLTable>((Func<IXLTable, bool>) (tt => tt.Name == tableName)) ? new XLTable(targetSheet.Range(xlTable.RangeAddress.ToString()), true, true) : new XLTable(targetSheet.Range(xlTable.RangeAddress.ToString()), tableName, true, true);
        table.RelId = xlTable.RelId;
        table.EmphasizeFirstColumn = xlTable.EmphasizeFirstColumn;
        table.EmphasizeLastColumn = xlTable.EmphasizeLastColumn;
        table.ShowRowStripes = xlTable.ShowRowStripes;
        table.ShowColumnStripes = xlTable.ShowColumnStripes;
        table.ShowAutoFilter = xlTable.ShowAutoFilter;
        table.Theme = xlTable.Theme;
        table._showTotalsRow = xlTable.ShowTotalsRow;
        table._uniqueNames.Clear();
        xlTable._uniqueNames.ForEach<string>((Action<string>) (n => table._uniqueNames.Add(n)));
        int num = xlTable.ColumnCount();
        for (int fieldIndex = 0; fieldIndex < num; ++fieldIndex)
        {
          XLTableField xlTableField1 = table.Field(fieldIndex) as XLTableField;
          XLTableField xlTableField2 = xlTable.Field(fieldIndex) as XLTableField;
          xlTableField1.Index = xlTableField2.Index;
          xlTableField1.Name = xlTableField2.Name;
          xlTableField1.totalsRowLabel = xlTableField2.totalsRowLabel;
          xlTableField1.totalsRowFunction = xlTableField2.totalsRowFunction;
        }
      }
      if (this.AutoFilter.Enabled)
        targetSheet.Range(this.AutoFilter.Range.RangeAddress).SetAutoFilter();
      return (IXLWorksheet) targetSheet;
    }

    private string ReplaceRelativeSheet(string newSheetName, string value)
    {
      if (XLHelper.IsNullOrWhiteSpace(value))
        return value;
      StringBuilder stringBuilder = new StringBuilder();
      string str1 = value;
      char[] chArray = new char[1]{ ',' };
      foreach (string str2 in str1.Split(chArray))
      {
        string[] strArray = str2.Split('!');
        if (strArray.Length == 2)
        {
          string str3 = strArray[0];
          if (str3.StartsWith("'"))
            str3 = str3.Substring(1, str3.Length - 2);
          string str4 = str3.ToLower().Equals(this.Name.ToLower()) ? newSheetName : str3;
          stringBuilder.Append(string.Format("'{0}'!{1}", (object) str4, (object) strArray[1]));
        }
        else
          stringBuilder.Append(str2);
      }
      return stringBuilder.ToString();
    }

    public new IXLHyperlinks Hyperlinks { get; private set; }

    IXLDataValidations IXLWorksheet.DataValidations
    {
      get
      {
        return (IXLDataValidations) this.DataValidations;
      }
    }

    public XLWorksheetVisibility Visibility
    {
      get
      {
        return this._visibility;
      }
      set
      {
        if (value != XLWorksheetVisibility.Visible)
          this.TabSelected = false;
        this._visibility = value;
      }
    }

    public IXLWorksheet Hide()
    {
      this.Visibility = XLWorksheetVisibility.Hidden;
      return (IXLWorksheet) this;
    }

    public IXLWorksheet Unhide()
    {
      this.Visibility = XLWorksheetVisibility.Visible;
      return (IXLWorksheet) this;
    }

    IXLSheetProtection IXLWorksheet.Protection
    {
      get
      {
        return (IXLSheetProtection) this.Protection;
      }
    }

    public IXLSheetProtection Protect()
    {
      return this.Protection.Protect();
    }

    public IXLSheetProtection Protect(string password)
    {
      return this.Protection.Protect(password);
    }

    public IXLSheetProtection Unprotect()
    {
      return this.Protection.Unprotect();
    }

    public IXLSheetProtection Unprotect(string password)
    {
      return this.Protection.Unprotect(password);
    }

    public IXLRange Sort()
    {
      return this.GetRangeForSort().Sort();
    }

    public IXLRange Sort(string columnsToSortBy, XLSortOrder sortOrder = XLSortOrder.Ascending, bool matchCase = false, bool ignoreBlanks = true)
    {
      return this.GetRangeForSort().Sort(columnsToSortBy, sortOrder, matchCase, ignoreBlanks);
    }

    public IXLRange Sort(int columnToSortBy, XLSortOrder sortOrder = XLSortOrder.Ascending, bool matchCase = false, bool ignoreBlanks = true)
    {
      return this.GetRangeForSort().Sort(columnToSortBy, sortOrder, matchCase, ignoreBlanks);
    }

    public IXLRange SortLeftToRight(XLSortOrder sortOrder = XLSortOrder.Ascending, bool matchCase = false, bool ignoreBlanks = true)
    {
      return this.GetRangeForSort().SortLeftToRight(sortOrder, matchCase, ignoreBlanks);
    }

    public bool ShowFormulas { get; set; }

    public bool ShowGridLines { get; set; }

    public bool ShowOutlineSymbols { get; set; }

    public bool ShowRowColHeaders { get; set; }

    public bool ShowRuler { get; set; }

    public bool ShowWhiteSpace { get; set; }

    public bool ShowZeros { get; set; }

    public IXLWorksheet SetShowFormulas()
    {
      this.ShowFormulas = true;
      return (IXLWorksheet) this;
    }

    public IXLWorksheet SetShowFormulas(bool value)
    {
      this.ShowFormulas = value;
      return (IXLWorksheet) this;
    }

    public IXLWorksheet SetShowGridLines()
    {
      this.ShowGridLines = true;
      return (IXLWorksheet) this;
    }

    public IXLWorksheet SetShowGridLines(bool value)
    {
      this.ShowGridLines = value;
      return (IXLWorksheet) this;
    }

    public IXLWorksheet SetShowOutlineSymbols()
    {
      this.ShowOutlineSymbols = true;
      return (IXLWorksheet) this;
    }

    public IXLWorksheet SetShowOutlineSymbols(bool value)
    {
      this.ShowOutlineSymbols = value;
      return (IXLWorksheet) this;
    }

    public IXLWorksheet SetShowRowColHeaders()
    {
      this.ShowRowColHeaders = true;
      return (IXLWorksheet) this;
    }

    public IXLWorksheet SetShowRowColHeaders(bool value)
    {
      this.ShowRowColHeaders = value;
      return (IXLWorksheet) this;
    }

    public IXLWorksheet SetShowRuler()
    {
      this.ShowRuler = true;
      return (IXLWorksheet) this;
    }

    public IXLWorksheet SetShowRuler(bool value)
    {
      this.ShowRuler = value;
      return (IXLWorksheet) this;
    }

    public IXLWorksheet SetShowWhiteSpace()
    {
      this.ShowWhiteSpace = true;
      return (IXLWorksheet) this;
    }

    public IXLWorksheet SetShowWhiteSpace(bool value)
    {
      this.ShowWhiteSpace = value;
      return (IXLWorksheet) this;
    }

    public IXLWorksheet SetShowZeros()
    {
      this.ShowZeros = true;
      return (IXLWorksheet) this;
    }

    public IXLWorksheet SetShowZeros(bool value)
    {
      this.ShowZeros = value;
      return (IXLWorksheet) this;
    }

    public XLColor TabColor { get; set; }

    public IXLWorksheet SetTabColor(XLColor color)
    {
      this.TabColor = color;
      return (IXLWorksheet) this;
    }

    public bool TabSelected { get; set; }

    public bool TabActive
    {
      get
      {
        return this._tabActive;
      }
      set
      {
        if (value && !this._tabActive)
        {
          foreach (XLWorksheet xlWorksheet in this.Worksheet.Workbook.WorksheetsInternal)
            xlWorksheet._tabActive = false;
        }
        this._tabActive = value;
      }
    }

    public IXLWorksheet SetTabSelected()
    {
      this.TabSelected = true;
      return (IXLWorksheet) this;
    }

    public IXLWorksheet SetTabSelected(bool value)
    {
      this.TabSelected = value;
      return (IXLWorksheet) this;
    }

    public IXLWorksheet SetTabActive()
    {
      this.TabActive = true;
      return (IXLWorksheet) this;
    }

    public IXLWorksheet SetTabActive(bool value)
    {
      this.TabActive = value;
      return (IXLWorksheet) this;
    }

    IXLPivotTable IXLWorksheet.PivotTable(string name)
    {
      return (IXLPivotTable) this.PivotTable(name);
    }

    public IXLPivotTables PivotTables { get; private set; }

    public bool RightToLeft { get; set; }

    public IXLWorksheet SetRightToLeft()
    {
      this.RightToLeft = true;
      return (IXLWorksheet) this;
    }

    public IXLWorksheet SetRightToLeft(bool value)
    {
      this.RightToLeft = value;
      return (IXLWorksheet) this;
    }

    public new IXLRanges Ranges(string ranges)
    {
      XLRanges xlRanges = new XLRanges();
      foreach (string str in ((IEnumerable<string>) ranges.Split(',')).Select<string, string>((Func<string, string>) (s => s.Trim())))
      {
        string rangeAddressStr = str;
        if (XLHelper.IsValidRangeAddress(rangeAddressStr))
          xlRanges.Add(this.Range((IXLRangeAddress) new XLRangeAddress(this.Worksheet, rangeAddressStr)));
        else if (this.NamedRanges.Any<IXLNamedRange>((Func<IXLNamedRange, bool>) (n => string.Compare(n.Name, rangeAddressStr, true) == 0)))
          this.NamedRange(rangeAddressStr).Ranges.ForEach<IXLRange>(new Action<IXLRange>(xlRanges.Add));
        else
          this.Workbook.NamedRanges.First<IXLNamedRange>((Func<IXLNamedRange, bool>) (n =>
          {
            if (string.Compare(n.Name, rangeAddressStr, true) == 0)
              return n.Ranges.First<IXLRange>().Worksheet == this;
            return false;
          })).Ranges.ForEach<IXLRange>(new Action<IXLRange>(xlRanges.Add));
      }
      return (IXLRanges) xlRanges;
    }

    IXLBaseAutoFilter IXLWorksheet.AutoFilter
    {
      get
      {
        return (IXLBaseAutoFilter) this.AutoFilter;
      }
    }

    public IXLRows RowsUsed(bool includeFormats = false, Func<IXLRow, bool> predicate = null)
    {
      XLRows xlRows = new XLRows(this.Worksheet);
      HashSet<int> rowsUsed = new HashSet<int>();
      this.Internals.RowsCollection.Keys.ForEach<int>((Action<int>) (r => rowsUsed.Add(r)));
      this.Internals.CellsCollection.RowsUsed.Keys.ForEach<int>((Action<int>) (r => rowsUsed.Add(r)));
      foreach (int row1 in rowsUsed)
      {
        XLRow row2 = this.Row(row1);
        if (!row2.IsEmpty(includeFormats) && (predicate == null || predicate((IXLRow) row2)))
          xlRows.Add(row2);
        else
          row2.Dispose();
      }
      return (IXLRows) xlRows;
    }

    public IXLRows RowsUsed(Func<IXLRow, bool> predicate = null)
    {
      return this.RowsUsed(false, predicate);
    }

    public IXLColumns ColumnsUsed(bool includeFormats = false, Func<IXLColumn, bool> predicate = null)
    {
      XLColumns xlColumns = new XLColumns(this.Worksheet);
      HashSet<int> columnsUsed = new HashSet<int>();
      this.Internals.ColumnsCollection.Keys.ForEach<int>((Action<int>) (r => columnsUsed.Add(r)));
      this.Internals.CellsCollection.ColumnsUsed.Keys.ForEach<int>((Action<int>) (r => columnsUsed.Add(r)));
      foreach (int column1 in columnsUsed)
      {
        XLColumn column2 = this.Column(column1);
        if (!column2.IsEmpty(includeFormats) && (predicate == null || predicate((IXLColumn) column2)))
          xlColumns.Add(column2);
        else
          column2.Dispose();
      }
      return (IXLColumns) xlColumns;
    }

    public IXLColumns ColumnsUsed(Func<IXLColumn, bool> predicate = null)
    {
      return this.ColumnsUsed(false, predicate);
    }

    public new void Dispose()
    {
      if (this.AutoFilter != null)
        this.AutoFilter.Dispose();
      this.Internals.Dispose();
      base.Dispose();
    }

    public void IncrementColumnOutline(int level)
    {
      if (level <= 0)
        return;
      if (!this._columnOutlineCount.ContainsKey(level))
        this._columnOutlineCount.Add(level, 0);
      Dictionary<int, int> columnOutlineCount;
      int index;
      (columnOutlineCount = this._columnOutlineCount)[index = level] = columnOutlineCount[index] + 1;
    }

    public void DecrementColumnOutline(int level)
    {
      if (level <= 0)
        return;
      if (!this._columnOutlineCount.ContainsKey(level))
        this._columnOutlineCount.Add(level, 0);
      if (this._columnOutlineCount[level] <= 0)
        return;
      Dictionary<int, int> columnOutlineCount;
      int index;
      (columnOutlineCount = this._columnOutlineCount)[index = level] = columnOutlineCount[index] - 1;
    }

    public int GetMaxColumnOutline()
    {
      List<KeyValuePair<int, int>> list = this._columnOutlineCount.Where<KeyValuePair<int, int>>((Func<KeyValuePair<int, int>, bool>) (kp => kp.Value > 0)).ToList<KeyValuePair<int, int>>();
      if (list.Count != 0)
        return list.Max<KeyValuePair<int, int>>((Func<KeyValuePair<int, int>, int>) (kp => kp.Key));
      return 0;
    }

    public void IncrementRowOutline(int level)
    {
      if (level <= 0)
        return;
      if (!this._rowOutlineCount.ContainsKey(level))
        this._rowOutlineCount.Add(level, 0);
      Dictionary<int, int> rowOutlineCount;
      int index;
      (rowOutlineCount = this._rowOutlineCount)[index = level] = rowOutlineCount[index] + 1;
    }

    public void DecrementRowOutline(int level)
    {
      if (level <= 0)
        return;
      if (!this._rowOutlineCount.ContainsKey(level))
        this._rowOutlineCount.Add(level, 0);
      if (this._rowOutlineCount[level] <= 0)
        return;
      Dictionary<int, int> rowOutlineCount;
      int index;
      (rowOutlineCount = this._rowOutlineCount)[index = level] = rowOutlineCount[index] - 1;
    }

    public int GetMaxRowOutline()
    {
      if (this._rowOutlineCount.Count != 0)
        return this._rowOutlineCount.Where<KeyValuePair<int, int>>((Func<KeyValuePair<int, int>, bool>) (kp => kp.Value > 0)).Max<KeyValuePair<int, int>>((Func<KeyValuePair<int, int>, int>) (kp => kp.Key));
      return 0;
    }

    public HashSet<int> GetStyleIds()
    {
      return this.Internals.CellsCollection.GetStyleIds(this.GetStyleId());
    }

    public XLRow FirstRowUsed()
    {
      return this.FirstRowUsed(false);
    }

    public XLRow FirstRowUsed(bool includeFormats)
    {
      using (XLRange xlRange = this.AsRange())
      {
        using (XLRangeRow xlRangeRow = xlRange.FirstRowUsed(includeFormats, (Func<IXLRangeRow, bool>) null))
          return xlRangeRow != null ? this.Row(xlRangeRow.RangeAddress.FirstAddress.RowNumber) : (XLRow) null;
      }
    }

    public XLRow LastRowUsed()
    {
      return this.LastRowUsed(false);
    }

    public XLRow LastRowUsed(bool includeFormats)
    {
      using (XLRange xlRange = this.AsRange())
      {
        using (XLRangeRow xlRangeRow = xlRange.LastRowUsed(includeFormats, (Func<IXLRangeRow, bool>) null))
          return xlRangeRow != null ? this.Row(xlRangeRow.RangeAddress.LastAddress.RowNumber) : (XLRow) null;
      }
    }

    public XLColumn LastColumn()
    {
      return this.Column(16384);
    }

    public XLColumn FirstColumn()
    {
      return this.Column(1);
    }

    public XLRow FirstRow()
    {
      return this.Row(1);
    }

    public XLRow LastRow()
    {
      return this.Row(1048576);
    }

    public XLColumn FirstColumnUsed()
    {
      return this.FirstColumnUsed(false);
    }

    public XLColumn FirstColumnUsed(bool includeFormats)
    {
      using (XLRange xlRange = this.AsRange())
      {
        using (XLRangeColumn xlRangeColumn = xlRange.FirstColumnUsed(includeFormats, (Func<IXLRangeColumn, bool>) null))
          return xlRangeColumn != null ? this.Column(xlRangeColumn.RangeAddress.FirstAddress.ColumnNumber) : (XLColumn) null;
      }
    }

    public XLColumn LastColumnUsed()
    {
      return this.LastColumnUsed(false);
    }

    public XLColumn LastColumnUsed(bool includeFormats)
    {
      using (XLRange xlRange = this.AsRange())
      {
        using (XLRangeColumn xlRangeColumn = xlRange.LastColumnUsed(includeFormats, (Func<IXLRangeColumn, bool>) null))
          return xlRangeColumn != null ? this.Column(xlRangeColumn.RangeAddress.LastAddress.ColumnNumber) : (XLColumn) null;
      }
    }

    public XLRow Row(int row)
    {
      return this.Row(row, true);
    }

    public XLColumn Column(int column)
    {
      if (column <= 0 || column > 16384)
        throw new IndexOutOfRangeException(string.Format("Column number must be between 1 and {0}", (object) 16384));
      int styleId = this.GetStyleId();
      if (!this.Internals.ColumnsCollection.ContainsKey(column))
      {
        this.Internals.RowsCollection.Keys.ForEach<int>((Action<int>) (r => this.Cell(r, column)));
        this.Internals.ColumnsCollection.Add(column, new XLColumn(column, new XLColumnParameters(this, styleId, false)));
      }
      return new XLColumn(column, new XLColumnParameters(this, styleId, true));
    }

    public IXLColumn Column(string column)
    {
      return (IXLColumn) this.Column(XLHelper.GetColumnNumberFromLetter(column));
    }

    public override XLRange AsRange()
    {
      return this.Range(1, 1, 1048576, 16384);
    }

    public void Clear()
    {
      this.Internals.CellsCollection.Clear();
      this.Internals.ColumnsCollection.Clear();
      this.Internals.MergedRanges.Clear(XLClearOptions.ContentsAndFormats);
      this.Internals.RowsCollection.Clear();
    }

    private void WorksheetRangeShiftedColumns(XLRange range, int columnsShifted)
    {
      XLRanges xlRanges = new XLRanges();
      foreach (IXLRange mergedRange in this.Internals.MergedRanges)
      {
        if (range.RangeAddress.FirstAddress.ColumnNumber <= mergedRange.RangeAddress.FirstAddress.ColumnNumber && mergedRange.RangeAddress.FirstAddress.RowNumber >= range.RangeAddress.FirstAddress.RowNumber && mergedRange.RangeAddress.LastAddress.RowNumber <= range.RangeAddress.LastAddress.RowNumber)
        {
          XLRange range1 = this.Range(mergedRange.RangeAddress.FirstAddress.RowNumber, mergedRange.RangeAddress.FirstAddress.ColumnNumber + columnsShifted, mergedRange.RangeAddress.LastAddress.RowNumber, mergedRange.RangeAddress.LastAddress.ColumnNumber + columnsShifted);
          xlRanges.Add(range1);
        }
        else if (range.RangeAddress.FirstAddress.ColumnNumber > mergedRange.RangeAddress.FirstAddress.ColumnNumber || range.RangeAddress.FirstAddress.RowNumber > mergedRange.RangeAddress.LastAddress.RowNumber)
          xlRanges.Add((IXLRangeBase) mergedRange);
      }
      this.Internals.MergedRanges = xlRanges;
      this.Workbook.Worksheets.ForEach<IXLWorksheet>((Action<IXLWorksheet>) (ws => this.MoveNamedRangesColumns(range, columnsShifted, ws.NamedRanges)));
      this.MoveNamedRangesColumns(range, columnsShifted, this.Workbook.NamedRanges);
      this.ShiftConditionalFormattingColumns(range, columnsShifted);
    }

    private void ShiftConditionalFormattingColumns(XLRange range, int columnsShifted)
    {
      int columnNumber = range.RangeAddress.FirstAddress.ColumnNumber;
      if (columnNumber == 1)
        return;
      int lastCellColumn = range.RangeAddress.FirstAddress.ColumnNumber + columnsShifted - 1;
      int rowNumber1 = range.RangeAddress.FirstAddress.RowNumber;
      int rowNumber2 = range.RangeAddress.LastAddress.RowNumber;
      XLRange xlRange = this.Range(rowNumber1, columnNumber, rowNumber2, lastCellColumn);
      XLRangeColumn xlRangeColumn = xlRange.FirstColumn((Func<IXLRangeColumn, bool>) null);
      XLRangeColumn model = xlRangeColumn.ColumnLeft();
      int rowNumber3 = model.RangeAddress.FirstAddress.RowNumber;
      if (this.ConditionalFormats.Any<IXLConditionalFormat>((Func<IXLConditionalFormat, bool>) (cf => cf.Range.Intersects((IXLRangeBase) model))))
      {
        for (int index = rowNumber1; index <= rowNumber2; ++index)
        {
          XLCell cellModel = model.Cell(index - rowNumber3 + 1);
          foreach (IXLConditionalFormat source in this.ConditionalFormats.Where<IXLConditionalFormat>((Func<IXLConditionalFormat, bool>) (cf => cf.Range.Intersects((IXLRangeBase) cellModel.AsRange()))).ToList<IXLConditionalFormat>())
            this.Range(index, columnNumber, index, lastCellColumn).AddConditionalFormat(source);
        }
      }
      xlRange.Dispose();
      model.Dispose();
      xlRangeColumn.Dispose();
    }

    private void WorksheetRangeShiftedRows(XLRange range, int rowsShifted)
    {
      XLRanges xlRanges = new XLRanges();
      foreach (IXLRange mergedRange in this.Internals.MergedRanges)
      {
        if (range.RangeAddress.FirstAddress.RowNumber <= mergedRange.RangeAddress.FirstAddress.RowNumber && mergedRange.RangeAddress.FirstAddress.ColumnNumber >= range.RangeAddress.FirstAddress.ColumnNumber && mergedRange.RangeAddress.LastAddress.ColumnNumber <= range.RangeAddress.LastAddress.ColumnNumber)
        {
          XLRange range1 = this.Range(mergedRange.RangeAddress.FirstAddress.RowNumber + rowsShifted, mergedRange.RangeAddress.FirstAddress.ColumnNumber, mergedRange.RangeAddress.LastAddress.RowNumber + rowsShifted, mergedRange.RangeAddress.LastAddress.ColumnNumber);
          xlRanges.Add(range1);
        }
        else if (range.RangeAddress.FirstAddress.RowNumber > mergedRange.RangeAddress.FirstAddress.RowNumber || range.RangeAddress.FirstAddress.ColumnNumber > mergedRange.RangeAddress.LastAddress.ColumnNumber)
          xlRanges.Add((IXLRangeBase) mergedRange);
      }
      this.Internals.MergedRanges = xlRanges;
      this.Workbook.Worksheets.ForEach<IXLWorksheet>((Action<IXLWorksheet>) (ws => this.MoveNamedRangesRows(range, rowsShifted, ws.NamedRanges)));
      this.MoveNamedRangesRows(range, rowsShifted, this.Workbook.NamedRanges);
      this.ShiftConditionalFormattingRows(range, rowsShifted);
    }

    private void ShiftConditionalFormattingRows(XLRange range, int rowsShifted)
    {
      int rowNumber = range.RangeAddress.FirstAddress.RowNumber;
      if (rowNumber == 1)
        return;
      this.SuspendEvents();
      IXLRange xlRange1 = range.Worksheet.RangeUsed(true);
      IXLRangeAddress xlRangeAddress = xlRange1 != null ? xlRange1.RangeAddress : (IXLRangeAddress) range.RangeAddress;
      this.ResumeEvents();
      if (rowNumber < xlRangeAddress.FirstAddress.RowNumber)
        rowNumber = xlRangeAddress.FirstAddress.RowNumber;
      int lastCellRow = range.RangeAddress.FirstAddress.RowNumber + rowsShifted - 1;
      if (lastCellRow > xlRangeAddress.LastAddress.RowNumber)
        lastCellRow = xlRangeAddress.LastAddress.RowNumber;
      int columnNumber1 = range.RangeAddress.FirstAddress.ColumnNumber;
      if (columnNumber1 < xlRangeAddress.FirstAddress.ColumnNumber)
        columnNumber1 = xlRangeAddress.FirstAddress.ColumnNumber;
      int columnNumber2 = range.RangeAddress.LastAddress.ColumnNumber;
      if (columnNumber2 > xlRangeAddress.LastAddress.ColumnNumber)
        columnNumber2 = xlRangeAddress.LastAddress.ColumnNumber;
      XLRange xlRange2 = this.Range(rowNumber, columnNumber1, lastCellRow, columnNumber2);
      XLRangeRow xlRangeRow = xlRange2.FirstRow((Func<IXLRangeRow, bool>) null);
      XLRangeRow model = xlRangeRow.RowAbove();
      int columnNumber3 = model.RangeAddress.FirstAddress.ColumnNumber;
      if (this.ConditionalFormats.Any<IXLConditionalFormat>((Func<IXLConditionalFormat, bool>) (cf => cf.Range.Intersects((IXLRangeBase) model))))
      {
        for (int index = columnNumber1; index <= columnNumber2; ++index)
        {
          IXLCell cellModel = model.Cell(index - columnNumber3 + 1);
          foreach (IXLConditionalFormat source in this.ConditionalFormats.Where<IXLConditionalFormat>((Func<IXLConditionalFormat, bool>) (cf => cf.Range.Intersects((IXLRangeBase) cellModel.AsRange()))).ToList<IXLConditionalFormat>())
            this.Range(rowNumber, index, lastCellRow, index).AddConditionalFormat(source);
        }
      }
      xlRange2.Dispose();
      model.Dispose();
      xlRangeRow.Dispose();
    }

    internal void BreakConditionalFormatsIntoCells(List<IXLAddress> addresses)
    {
      XLConditionalFormats conditionalFormats = new XLConditionalFormats();
      this.SuspendEvents();
      foreach (IXLConditionalFormat conditionalFormat1 in (IEnumerable<IXLConditionalFormat>) this.ConditionalFormats)
      {
        foreach (XLCell cell in (IEnumerable<IXLCell>) conditionalFormat1.Range.Cells((Func<IXLCell, bool>) (c => !addresses.Contains(c.Address))))
        {
          int row = cell.Address.RowNumber;
          string column = cell.Address.ColumnLetter;
          XLConditionalFormat conditionalFormat2 = new XLConditionalFormat(cell.AsRange(), true);
          conditionalFormat2.CopyFrom(conditionalFormat1);
          conditionalFormat2.Values.Values.Where<XLFormula>((Func<XLFormula, bool>) (f => f.IsFormula)).ForEach<XLFormula>((Action<XLFormula>) (f => f._value = XLHelper.ReplaceRelative(f.Value, row, column)));
          conditionalFormats.Add((IXLConditionalFormat) conditionalFormat2);
        }
        conditionalFormat1.Range.Dispose();
      }
      this.ResumeEvents();
      this.ConditionalFormats = (IXLConditionalFormats) conditionalFormats;
    }

    private void MoveNamedRangesRows(XLRange range, int rowsShifted, IXLNamedRanges namedRanges)
    {
      foreach (XLNamedRange namedRange in (IEnumerable<IXLNamedRange>) namedRanges)
      {
        List<string> list = namedRange.RangeList.Select<string, string>((Func<string, string>) (r => XLCell.ShiftFormulaRows(r, this, range, rowsShifted))).Where<string>((Func<string, bool>) (newReference => newReference.Length > 0)).ToList<string>();
        namedRange.RangeList = list;
      }
    }

    private void MoveNamedRangesColumns(XLRange range, int columnsShifted, IXLNamedRanges namedRanges)
    {
      foreach (XLNamedRange namedRange in (IEnumerable<IXLNamedRange>) namedRanges)
      {
        List<string> list = namedRange.RangeList.Select<string, string>((Func<string, string>) (r => XLCell.ShiftFormulaColumns(r, this, range, columnsShifted))).Where<string>((Func<string, bool>) (newReference => newReference.Length > 0)).ToList<string>();
        namedRange.RangeList = list;
      }
    }

    public void NotifyRangeShiftedRows(XLRange range, int rowsShifted)
    {
      if (this.RangeShiftedRows == null)
        return;
      foreach (XLCallbackAction rangeShiftedRow in this.RangeShiftedRows)
        rangeShiftedRow.Action(range, rowsShifted);
    }

    public void NotifyRangeShiftedColumns(XLRange range, int columnsShifted)
    {
      if (this.RangeShiftedColumns == null)
        return;
      foreach (XLCallbackAction rangeShiftedColumn in this.RangeShiftedColumns)
        rangeShiftedColumn.Action(range, columnsShifted);
    }

    public XLRow Row(int row, bool pingCells)
    {
      if (row <= 0 || row > 1048576)
        throw new IndexOutOfRangeException(string.Format("Row number must be between 1 and {0}", (object) 1048576));
      XLRow xlRow;
      int styleId;
      if (this.Internals.RowsCollection.TryGetValue(row, out xlRow))
      {
        styleId = xlRow.GetStyleId();
      }
      else
      {
        if (pingCells)
          this.Internals.ColumnsCollection.Join((IEnumerable<int>) this.Internals.CellsCollection.ColumnsUsed.Keys, (Func<KeyValuePair<int, XLColumn>, int>) (c => c.Key), (Func<int, int>) (dc => dc), (c, dc) => new
          {
            c = c,
            dc = dc
          }).Where(_param1 => !this.Internals.CellsCollection.Contains(row, _param1.dc)).Select(_param0 => _param0.dc).ForEach<int>((Action<int>) (c => this.Cell(row, c)));
        styleId = this.GetStyleId();
        this.Internals.RowsCollection.Add(row, new XLRow(row, new XLRowParameters(this, styleId, false)));
      }
      return new XLRow(row, new XLRowParameters(this, styleId, true));
    }

    private IXLRange GetRangeForSort()
    {
      IXLRange range = this.RangeUsed();
      this.SortColumns.ForEach<IXLSortElement>((Action<IXLSortElement>) (e => range.SortColumns.Add(e.ElementNumber, e.SortOrder, e.IgnoreBlanks, e.MatchCase)));
      this.SortRows.ForEach<IXLSortElement>((Action<IXLSortElement>) (e => range.SortRows.Add(e.ElementNumber, e.SortOrder, e.IgnoreBlanks, e.MatchCase)));
      return range;
    }

    public XLPivotTable PivotTable(string name)
    {
      return (XLPivotTable) this.PivotTables.PivotTable(name);
    }

    public XLCells Cells()
    {
      return this.CellsUsed(true);
    }

    public new XLCell Cell(string cellAddressInRange)
    {
      if (XLHelper.IsValidA1Address(cellAddressInRange))
        return this.Cell(XLAddress.Create(this, cellAddressInRange));
      if (this.NamedRanges.Any<IXLNamedRange>((Func<IXLNamedRange, bool>) (n => string.Compare(n.Name, cellAddressInRange, true) == 0)))
        return (XLCell) this.NamedRange(cellAddressInRange).Ranges.First<IXLRange>().FirstCell();
      IXLNamedRange xlNamedRange = this.Workbook.NamedRanges.FirstOrDefault<IXLNamedRange>((Func<IXLNamedRange, bool>) (n =>
      {
        if (string.Compare(n.Name, cellAddressInRange, true) == 0)
          return n.Ranges.Count == 1;
        return false;
      }));
      if (xlNamedRange == null || !xlNamedRange.Ranges.Any<IXLRange>())
        return (XLCell) null;
      return (XLCell) xlNamedRange.Ranges.First<IXLRange>().FirstCell();
    }

    public XLCell CellFast(string cellAddressInRange)
    {
      return this.Cell(XLAddress.Create(this, cellAddressInRange));
    }

    public override XLRange Range(string rangeAddressStr)
    {
      if (XLHelper.IsValidRangeAddress(rangeAddressStr))
        return this.Range((IXLRangeAddress) new XLRangeAddress(this.Worksheet, rangeAddressStr));
      if (rangeAddressStr.Contains("["))
        return this.Table(rangeAddressStr.Substring(0, rangeAddressStr.IndexOf("["))) as XLRange;
      if (this.NamedRanges.Any<IXLNamedRange>((Func<IXLNamedRange, bool>) (n => string.Compare(n.Name, rangeAddressStr, true) == 0)))
        return (XLRange) this.NamedRange(rangeAddressStr).Ranges.First<IXLRange>();
      IXLNamedRange xlNamedRange = this.Workbook.NamedRanges.FirstOrDefault<IXLNamedRange>((Func<IXLNamedRange, bool>) (n =>
      {
        if (string.Compare(n.Name, rangeAddressStr, true) == 0)
          return n.Ranges.Count == 1;
        return false;
      }));
      if (xlNamedRange == null || !xlNamedRange.Ranges.Any<IXLRange>())
        return (XLRange) null;
      return (XLRange) xlNamedRange.Ranges.First<IXLRange>();
    }

    public IXLRanges MergedRanges
    {
      get
      {
        return (IXLRanges) this.Internals.MergedRanges;
      }
    }

    public IXLConditionalFormats ConditionalFormats { get; private set; }

    public void SuspendEvents()
    {
      this._eventTracking = this.EventTrackingEnabled;
      this.EventTrackingEnabled = false;
    }

    public void ResumeEvents()
    {
      this.EventTrackingEnabled = this._eventTracking;
    }

    public IXLRanges SelectedRanges { get; internal set; }

    public IXLCell ActiveCell { get; set; }

    private XLCalcEngine CalcEngine
    {
      get
      {
        return this._calcEngine ?? (this._calcEngine = new XLCalcEngine((IXLWorksheet) this));
      }
    }

    public object Evaluate(string expression)
    {
      return this.CalcEngine.Evaluate(expression);
    }

    public string Author { get; set; }
  }
}

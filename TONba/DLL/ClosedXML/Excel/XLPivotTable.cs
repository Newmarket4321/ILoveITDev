// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLPivotTable
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;

namespace ClosedXML.Excel
{
  internal class XLPivotTable : IXLPivotTable
  {
    public XLPivotTable()
    {
      this.Fields = (IXLPivotFields) new XLPivotFields();
      this.ReportFilters = (IXLPivotFields) new XLPivotFields();
      this.ColumnLabels = (IXLPivotFields) new XLPivotFields();
      this.RowLabels = (IXLPivotFields) new XLPivotFields();
      this.Values = (IXLPivotValues) new XLPivotValues();
      this.Theme = XLPivotTableTheme.PivotStyleLight16;
      this.SetExcelDefaults();
    }

    public IXLCell TargetCell { get; set; }

    public IXLRange SourceRange { get; set; }

    public IXLPivotFields Fields { get; private set; }

    public IXLPivotFields ReportFilters { get; private set; }

    public IXLPivotFields ColumnLabels { get; private set; }

    public IXLPivotFields RowLabels { get; private set; }

    public IXLPivotValues Values { get; private set; }

    public XLPivotTableTheme Theme { get; set; }

    public IXLPivotTable SetTheme(XLPivotTableTheme value)
    {
      this.Theme = value;
      return (IXLPivotTable) this;
    }

    public string Name { get; set; }

    public IXLPivotTable SetName(string value)
    {
      this.Name = value;
      return (IXLPivotTable) this;
    }

    public string Title { get; set; }

    public IXLPivotTable SetTitle(string value)
    {
      this.Title = value;
      return (IXLPivotTable) this;
    }

    public string Description { get; set; }

    public IXLPivotTable SetDescription(string value)
    {
      this.Description = value;
      return (IXLPivotTable) this;
    }

    public bool MergeAndCenterWithLabels { get; set; }

    public IXLPivotTable SetMergeAndCenterWithLabels()
    {
      this.MergeAndCenterWithLabels = true;
      return (IXLPivotTable) this;
    }

    public IXLPivotTable SetMergeAndCenterWithLabels(bool value)
    {
      this.MergeAndCenterWithLabels = value;
      return (IXLPivotTable) this;
    }

    public int RowLabelIndent { get; set; }

    public IXLPivotTable SetRowLabelIndent(int value)
    {
      this.RowLabelIndent = value;
      return (IXLPivotTable) this;
    }

    public XLFilterAreaOrder FilterAreaOrder { get; set; }

    public IXLPivotTable SetFilterAreaOrder(XLFilterAreaOrder value)
    {
      this.FilterAreaOrder = value;
      return (IXLPivotTable) this;
    }

    public int FilterFieldsPageWrap { get; set; }

    public IXLPivotTable SetFilterFieldsPageWrap(int value)
    {
      this.FilterFieldsPageWrap = value;
      return (IXLPivotTable) this;
    }

    public string ErrorValueReplacement { get; set; }

    public IXLPivotTable SetErrorValueReplacement(string value)
    {
      this.ErrorValueReplacement = value;
      return (IXLPivotTable) this;
    }

    public string EmptyCellReplacement { get; set; }

    public IXLPivotTable SetEmptyCellReplacement(string value)
    {
      this.EmptyCellReplacement = value;
      return (IXLPivotTable) this;
    }

    public bool AutofitColumns { get; set; }

    public IXLPivotTable SetAutofitColumns()
    {
      this.AutofitColumns = true;
      return (IXLPivotTable) this;
    }

    public IXLPivotTable SetAutofitColumns(bool value)
    {
      this.AutofitColumns = value;
      return (IXLPivotTable) this;
    }

    public bool PreserveCellFormatting { get; set; }

    public IXLPivotTable SetPreserveCellFormatting()
    {
      this.PreserveCellFormatting = true;
      return (IXLPivotTable) this;
    }

    public IXLPivotTable SetPreserveCellFormatting(bool value)
    {
      this.PreserveCellFormatting = value;
      return (IXLPivotTable) this;
    }

    public bool ShowGrandTotalsRows { get; set; }

    public IXLPivotTable SetShowGrandTotalsRows()
    {
      this.ShowGrandTotalsRows = true;
      return (IXLPivotTable) this;
    }

    public IXLPivotTable SetShowGrandTotalsRows(bool value)
    {
      this.ShowGrandTotalsRows = value;
      return (IXLPivotTable) this;
    }

    public bool ShowGrandTotalsColumns { get; set; }

    public IXLPivotTable SetShowGrandTotalsColumns()
    {
      this.ShowGrandTotalsColumns = true;
      return (IXLPivotTable) this;
    }

    public IXLPivotTable SetShowGrandTotalsColumns(bool value)
    {
      this.ShowGrandTotalsColumns = value;
      return (IXLPivotTable) this;
    }

    public bool FilteredItemsInSubtotals { get; set; }

    public IXLPivotTable SetFilteredItemsInSubtotals()
    {
      this.FilteredItemsInSubtotals = true;
      return (IXLPivotTable) this;
    }

    public IXLPivotTable SetFilteredItemsInSubtotals(bool value)
    {
      this.FilteredItemsInSubtotals = value;
      return (IXLPivotTable) this;
    }

    public bool AllowMultipleFilters { get; set; }

    public IXLPivotTable SetAllowMultipleFilters()
    {
      this.AllowMultipleFilters = true;
      return (IXLPivotTable) this;
    }

    public IXLPivotTable SetAllowMultipleFilters(bool value)
    {
      this.AllowMultipleFilters = value;
      return (IXLPivotTable) this;
    }

    public bool UseCustomListsForSorting { get; set; }

    public IXLPivotTable SetUseCustomListsForSorting()
    {
      this.UseCustomListsForSorting = true;
      return (IXLPivotTable) this;
    }

    public IXLPivotTable SetUseCustomListsForSorting(bool value)
    {
      this.UseCustomListsForSorting = value;
      return (IXLPivotTable) this;
    }

    public bool ShowExpandCollapseButtons { get; set; }

    public IXLPivotTable SetShowExpandCollapseButtons()
    {
      this.ShowExpandCollapseButtons = true;
      return (IXLPivotTable) this;
    }

    public IXLPivotTable SetShowExpandCollapseButtons(bool value)
    {
      this.ShowExpandCollapseButtons = value;
      return (IXLPivotTable) this;
    }

    public bool ShowContextualTooltips { get; set; }

    public IXLPivotTable SetShowContextualTooltips()
    {
      this.ShowContextualTooltips = true;
      return (IXLPivotTable) this;
    }

    public IXLPivotTable SetShowContextualTooltips(bool value)
    {
      this.ShowContextualTooltips = value;
      return (IXLPivotTable) this;
    }

    public bool ShowPropertiesInTooltips { get; set; }

    public IXLPivotTable SetShowPropertiesInTooltips()
    {
      this.ShowPropertiesInTooltips = true;
      return (IXLPivotTable) this;
    }

    public IXLPivotTable SetShowPropertiesInTooltips(bool value)
    {
      this.ShowPropertiesInTooltips = value;
      return (IXLPivotTable) this;
    }

    public bool DisplayCaptionsAndDropdowns { get; set; }

    public IXLPivotTable SetDisplayCaptionsAndDropdowns()
    {
      this.DisplayCaptionsAndDropdowns = true;
      return (IXLPivotTable) this;
    }

    public IXLPivotTable SetDisplayCaptionsAndDropdowns(bool value)
    {
      this.DisplayCaptionsAndDropdowns = value;
      return (IXLPivotTable) this;
    }

    public bool ClassicPivotTableLayout { get; set; }

    public IXLPivotTable SetClassicPivotTableLayout()
    {
      this.ClassicPivotTableLayout = true;
      return (IXLPivotTable) this;
    }

    public IXLPivotTable SetClassicPivotTableLayout(bool value)
    {
      this.ClassicPivotTableLayout = value;
      return (IXLPivotTable) this;
    }

    public bool ShowValuesRow { get; set; }

    public IXLPivotTable SetShowValuesRow()
    {
      this.ShowValuesRow = true;
      return (IXLPivotTable) this;
    }

    public IXLPivotTable SetShowValuesRow(bool value)
    {
      this.ShowValuesRow = value;
      return (IXLPivotTable) this;
    }

    public bool ShowEmptyItemsOnRows { get; set; }

    public IXLPivotTable SetShowEmptyItemsOnRows()
    {
      this.ShowEmptyItemsOnRows = true;
      return (IXLPivotTable) this;
    }

    public IXLPivotTable SetShowEmptyItemsOnRows(bool value)
    {
      this.ShowEmptyItemsOnRows = value;
      return (IXLPivotTable) this;
    }

    public bool ShowEmptyItemsOnColumns { get; set; }

    public IXLPivotTable SetShowEmptyItemsOnColumns()
    {
      this.ShowEmptyItemsOnColumns = true;
      return (IXLPivotTable) this;
    }

    public IXLPivotTable SetShowEmptyItemsOnColumns(bool value)
    {
      this.ShowEmptyItemsOnColumns = value;
      return (IXLPivotTable) this;
    }

    public bool DisplayItemLabels { get; set; }

    public IXLPivotTable SetDisplayItemLabels()
    {
      this.DisplayItemLabels = true;
      return (IXLPivotTable) this;
    }

    public IXLPivotTable SetDisplayItemLabels(bool value)
    {
      this.DisplayItemLabels = value;
      return (IXLPivotTable) this;
    }

    public bool SortFieldsAtoZ { get; set; }

    public IXLPivotTable SetSortFieldsAtoZ()
    {
      this.SortFieldsAtoZ = true;
      return (IXLPivotTable) this;
    }

    public IXLPivotTable SetSortFieldsAtoZ(bool value)
    {
      this.SortFieldsAtoZ = value;
      return (IXLPivotTable) this;
    }

    public bool PrintExpandCollapsedButtons { get; set; }

    public IXLPivotTable SetPrintExpandCollapsedButtons()
    {
      this.PrintExpandCollapsedButtons = true;
      return (IXLPivotTable) this;
    }

    public IXLPivotTable SetPrintExpandCollapsedButtons(bool value)
    {
      this.PrintExpandCollapsedButtons = value;
      return (IXLPivotTable) this;
    }

    public bool RepeatRowLabels { get; set; }

    public IXLPivotTable SetRepeatRowLabels()
    {
      this.RepeatRowLabels = true;
      return (IXLPivotTable) this;
    }

    public IXLPivotTable SetRepeatRowLabels(bool value)
    {
      this.RepeatRowLabels = value;
      return (IXLPivotTable) this;
    }

    public bool PrintTitles { get; set; }

    public IXLPivotTable SetPrintTitles()
    {
      this.PrintTitles = true;
      return (IXLPivotTable) this;
    }

    public IXLPivotTable SetPrintTitles(bool value)
    {
      this.PrintTitles = value;
      return (IXLPivotTable) this;
    }

    public bool SaveSourceData { get; set; }

    public IXLPivotTable SetSaveSourceData()
    {
      this.SaveSourceData = true;
      return (IXLPivotTable) this;
    }

    public IXLPivotTable SetSaveSourceData(bool value)
    {
      this.SaveSourceData = value;
      return (IXLPivotTable) this;
    }

    public bool EnableShowDetails { get; set; }

    public IXLPivotTable SetEnableShowDetails()
    {
      this.EnableShowDetails = true;
      return (IXLPivotTable) this;
    }

    public IXLPivotTable SetEnableShowDetails(bool value)
    {
      this.EnableShowDetails = value;
      return (IXLPivotTable) this;
    }

    public bool RefreshDataOnOpen { get; set; }

    public IXLPivotTable SetRefreshDataOnOpen()
    {
      this.RefreshDataOnOpen = true;
      return (IXLPivotTable) this;
    }

    public IXLPivotTable SetRefreshDataOnOpen(bool value)
    {
      this.RefreshDataOnOpen = value;
      return (IXLPivotTable) this;
    }

    public XLItemsToRetain ItemsToRetainPerField { get; set; }

    public IXLPivotTable SetItemsToRetainPerField(XLItemsToRetain value)
    {
      this.ItemsToRetainPerField = value;
      return (IXLPivotTable) this;
    }

    public bool EnableCellEditing { get; set; }

    public IXLPivotTable SetEnableCellEditing()
    {
      this.EnableCellEditing = true;
      return (IXLPivotTable) this;
    }

    public IXLPivotTable SetEnableCellEditing(bool value)
    {
      this.EnableCellEditing = value;
      return (IXLPivotTable) this;
    }

    public bool ShowRowHeaders { get; set; }

    public IXLPivotTable SetShowRowHeaders()
    {
      this.ShowRowHeaders = true;
      return (IXLPivotTable) this;
    }

    public IXLPivotTable SetShowRowHeaders(bool value)
    {
      this.ShowRowHeaders = value;
      return (IXLPivotTable) this;
    }

    public bool ShowColumnHeaders { get; set; }

    public IXLPivotTable SetShowColumnHeaders()
    {
      this.ShowColumnHeaders = true;
      return (IXLPivotTable) this;
    }

    public IXLPivotTable SetShowColumnHeaders(bool value)
    {
      this.ShowColumnHeaders = value;
      return (IXLPivotTable) this;
    }

    public bool ShowRowStripes { get; set; }

    public IXLPivotTable SetShowRowStripes()
    {
      this.ShowRowStripes = true;
      return (IXLPivotTable) this;
    }

    public IXLPivotTable SetShowRowStripes(bool value)
    {
      this.ShowRowStripes = value;
      return (IXLPivotTable) this;
    }

    public bool ShowColumnStripes { get; set; }

    public IXLPivotTable SetShowColumnStripes()
    {
      this.ShowColumnStripes = true;
      return (IXLPivotTable) this;
    }

    public IXLPivotTable SetShowColumnStripes(bool value)
    {
      this.ShowColumnStripes = value;
      return (IXLPivotTable) this;
    }

    public XLPivotSubtotals Subtotals { get; set; }

    public IXLPivotTable SetSubtotals(XLPivotSubtotals value)
    {
      this.Subtotals = value;
      return (IXLPivotTable) this;
    }

    public XLPivotLayout Layout
    {
      set
      {
        this.Fields.ForEach<IXLPivotField>((Action<IXLPivotField>) (f => f.SetLayout(value)));
      }
    }

    public IXLPivotTable SetLayout(XLPivotLayout value)
    {
      this.Layout = value;
      return (IXLPivotTable) this;
    }

    public bool InsertBlankLines
    {
      set
      {
        this.Fields.ForEach<IXLPivotField>((Action<IXLPivotField>) (f => f.SetInsertBlankLines(value)));
      }
    }

    public IXLPivotTable SetInsertBlankLines()
    {
      this.InsertBlankLines = true;
      return (IXLPivotTable) this;
    }

    public IXLPivotTable SetInsertBlankLines(bool value)
    {
      this.InsertBlankLines = value;
      return (IXLPivotTable) this;
    }

    private void SetExcelDefaults()
    {
      this.EmptyCellReplacement = string.Empty;
      this.AutofitColumns = true;
      this.PreserveCellFormatting = true;
      this.ShowGrandTotalsColumns = true;
      this.ShowGrandTotalsRows = true;
      this.UseCustomListsForSorting = true;
      this.ShowExpandCollapseButtons = true;
      this.ShowContextualTooltips = true;
      this.DisplayCaptionsAndDropdowns = true;
      this.RepeatRowLabels = true;
      this.SaveSourceData = true;
      this.EnableShowDetails = true;
      this.ShowColumnHeaders = true;
      this.ShowRowHeaders = true;
    }
  }
}

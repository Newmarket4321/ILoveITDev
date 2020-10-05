// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.IXLPivotTable
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

namespace ClosedXML.Excel
{
  public interface IXLPivotTable
  {
    XLPivotTableTheme Theme { get; set; }

    IXLPivotFields Fields { get; }

    IXLPivotFields ReportFilters { get; }

    IXLPivotFields ColumnLabels { get; }

    IXLPivotFields RowLabels { get; }

    IXLPivotValues Values { get; }

    string Name { get; set; }

    string Title { get; set; }

    string Description { get; set; }

    IXLCell TargetCell { get; set; }

    IXLRange SourceRange { get; set; }

    bool MergeAndCenterWithLabels { get; set; }

    int RowLabelIndent { get; set; }

    XLFilterAreaOrder FilterAreaOrder { get; set; }

    int FilterFieldsPageWrap { get; set; }

    string ErrorValueReplacement { get; set; }

    string EmptyCellReplacement { get; set; }

    bool AutofitColumns { get; set; }

    bool PreserveCellFormatting { get; set; }

    bool ShowGrandTotalsRows { get; set; }

    bool ShowGrandTotalsColumns { get; set; }

    bool FilteredItemsInSubtotals { get; set; }

    bool AllowMultipleFilters { get; set; }

    bool UseCustomListsForSorting { get; set; }

    bool ShowExpandCollapseButtons { get; set; }

    bool ShowContextualTooltips { get; set; }

    bool ShowPropertiesInTooltips { get; set; }

    bool DisplayCaptionsAndDropdowns { get; set; }

    bool ClassicPivotTableLayout { get; set; }

    bool ShowValuesRow { get; set; }

    bool ShowEmptyItemsOnRows { get; set; }

    bool ShowEmptyItemsOnColumns { get; set; }

    bool DisplayItemLabels { get; set; }

    bool SortFieldsAtoZ { get; set; }

    bool PrintExpandCollapsedButtons { get; set; }

    bool RepeatRowLabels { get; set; }

    bool PrintTitles { get; set; }

    bool SaveSourceData { get; set; }

    bool EnableShowDetails { get; set; }

    bool RefreshDataOnOpen { get; set; }

    XLItemsToRetain ItemsToRetainPerField { get; set; }

    bool EnableCellEditing { get; set; }

    IXLPivotTable SetName(string value);

    IXLPivotTable SetTitle(string value);

    IXLPivotTable SetDescription(string value);

    IXLPivotTable SetMergeAndCenterWithLabels();

    IXLPivotTable SetMergeAndCenterWithLabels(bool value);

    IXLPivotTable SetRowLabelIndent(int value);

    IXLPivotTable SetFilterAreaOrder(XLFilterAreaOrder value);

    IXLPivotTable SetFilterFieldsPageWrap(int value);

    IXLPivotTable SetErrorValueReplacement(string value);

    IXLPivotTable SetEmptyCellReplacement(string value);

    IXLPivotTable SetAutofitColumns();

    IXLPivotTable SetAutofitColumns(bool value);

    IXLPivotTable SetPreserveCellFormatting();

    IXLPivotTable SetPreserveCellFormatting(bool value);

    IXLPivotTable SetShowGrandTotalsRows();

    IXLPivotTable SetShowGrandTotalsRows(bool value);

    IXLPivotTable SetShowGrandTotalsColumns();

    IXLPivotTable SetShowGrandTotalsColumns(bool value);

    IXLPivotTable SetFilteredItemsInSubtotals();

    IXLPivotTable SetFilteredItemsInSubtotals(bool value);

    IXLPivotTable SetAllowMultipleFilters();

    IXLPivotTable SetAllowMultipleFilters(bool value);

    IXLPivotTable SetUseCustomListsForSorting();

    IXLPivotTable SetUseCustomListsForSorting(bool value);

    IXLPivotTable SetShowExpandCollapseButtons();

    IXLPivotTable SetShowExpandCollapseButtons(bool value);

    IXLPivotTable SetShowContextualTooltips();

    IXLPivotTable SetShowContextualTooltips(bool value);

    IXLPivotTable SetShowPropertiesInTooltips();

    IXLPivotTable SetShowPropertiesInTooltips(bool value);

    IXLPivotTable SetDisplayCaptionsAndDropdowns();

    IXLPivotTable SetDisplayCaptionsAndDropdowns(bool value);

    IXLPivotTable SetClassicPivotTableLayout();

    IXLPivotTable SetClassicPivotTableLayout(bool value);

    IXLPivotTable SetShowValuesRow();

    IXLPivotTable SetShowValuesRow(bool value);

    IXLPivotTable SetShowEmptyItemsOnRows();

    IXLPivotTable SetShowEmptyItemsOnRows(bool value);

    IXLPivotTable SetShowEmptyItemsOnColumns();

    IXLPivotTable SetShowEmptyItemsOnColumns(bool value);

    IXLPivotTable SetDisplayItemLabels();

    IXLPivotTable SetDisplayItemLabels(bool value);

    IXLPivotTable SetSortFieldsAtoZ();

    IXLPivotTable SetSortFieldsAtoZ(bool value);

    IXLPivotTable SetPrintExpandCollapsedButtons();

    IXLPivotTable SetPrintExpandCollapsedButtons(bool value);

    IXLPivotTable SetRepeatRowLabels();

    IXLPivotTable SetRepeatRowLabels(bool value);

    IXLPivotTable SetPrintTitles();

    IXLPivotTable SetPrintTitles(bool value);

    IXLPivotTable SetSaveSourceData();

    IXLPivotTable SetSaveSourceData(bool value);

    IXLPivotTable SetEnableShowDetails();

    IXLPivotTable SetEnableShowDetails(bool value);

    IXLPivotTable SetRefreshDataOnOpen();

    IXLPivotTable SetRefreshDataOnOpen(bool value);

    IXLPivotTable SetItemsToRetainPerField(XLItemsToRetain value);

    IXLPivotTable SetEnableCellEditing();

    IXLPivotTable SetEnableCellEditing(bool value);

    bool ShowRowHeaders { get; set; }

    bool ShowColumnHeaders { get; set; }

    bool ShowRowStripes { get; set; }

    bool ShowColumnStripes { get; set; }

    XLPivotSubtotals Subtotals { get; set; }

    XLPivotLayout Layout { set; }

    bool InsertBlankLines { set; }

    IXLPivotTable SetShowRowHeaders();

    IXLPivotTable SetShowRowHeaders(bool value);

    IXLPivotTable SetShowColumnHeaders();

    IXLPivotTable SetShowColumnHeaders(bool value);

    IXLPivotTable SetShowRowStripes();

    IXLPivotTable SetShowRowStripes(bool value);

    IXLPivotTable SetShowColumnStripes();

    IXLPivotTable SetShowColumnStripes(bool value);

    IXLPivotTable SetSubtotals(XLPivotSubtotals value);

    IXLPivotTable SetLayout(XLPivotLayout value);

    IXLPivotTable SetInsertBlankLines();

    IXLPivotTable SetInsertBlankLines(bool value);
  }
}

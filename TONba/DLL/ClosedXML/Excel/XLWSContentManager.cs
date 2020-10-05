// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLWSContentManager
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClosedXML.Excel
{
  internal class XLWSContentManager
  {
    private Dictionary<XLWSContentManager.XLWSContents, OpenXmlElement> contents = new Dictionary<XLWSContentManager.XLWSContents, OpenXmlElement>();

    public XLWSContentManager(Worksheet opWorksheet)
    {
      this.contents.Add(XLWSContentManager.XLWSContents.SheetProperties, (OpenXmlElement) opWorksheet.Elements<SheetProperties>().LastOrDefault<SheetProperties>());
      this.contents.Add(XLWSContentManager.XLWSContents.SheetDimension, (OpenXmlElement) opWorksheet.Elements<SheetDimension>().LastOrDefault<SheetDimension>());
      this.contents.Add(XLWSContentManager.XLWSContents.SheetViews, (OpenXmlElement) opWorksheet.Elements<SheetViews>().LastOrDefault<SheetViews>());
      this.contents.Add(XLWSContentManager.XLWSContents.SheetFormatProperties, (OpenXmlElement) opWorksheet.Elements<SheetFormatProperties>().LastOrDefault<SheetFormatProperties>());
      this.contents.Add(XLWSContentManager.XLWSContents.Columns, (OpenXmlElement) opWorksheet.Elements<Columns>().LastOrDefault<Columns>());
      this.contents.Add(XLWSContentManager.XLWSContents.SheetData, (OpenXmlElement) opWorksheet.Elements<SheetData>().LastOrDefault<SheetData>());
      this.contents.Add(XLWSContentManager.XLWSContents.SheetCalculationProperties, (OpenXmlElement) opWorksheet.Elements<SheetCalculationProperties>().LastOrDefault<SheetCalculationProperties>());
      this.contents.Add(XLWSContentManager.XLWSContents.SheetProtection, (OpenXmlElement) opWorksheet.Elements<SheetProtection>().LastOrDefault<SheetProtection>());
      this.contents.Add(XLWSContentManager.XLWSContents.ProtectedRanges, (OpenXmlElement) opWorksheet.Elements<ProtectedRanges>().LastOrDefault<ProtectedRanges>());
      this.contents.Add(XLWSContentManager.XLWSContents.Scenarios, (OpenXmlElement) opWorksheet.Elements<Scenarios>().LastOrDefault<Scenarios>());
      this.contents.Add(XLWSContentManager.XLWSContents.AutoFilter, (OpenXmlElement) opWorksheet.Elements<AutoFilter>().LastOrDefault<AutoFilter>());
      this.contents.Add(XLWSContentManager.XLWSContents.SortState, (OpenXmlElement) opWorksheet.Elements<SortState>().LastOrDefault<SortState>());
      this.contents.Add(XLWSContentManager.XLWSContents.DataConsolidate, (OpenXmlElement) opWorksheet.Elements<DataConsolidate>().LastOrDefault<DataConsolidate>());
      this.contents.Add(XLWSContentManager.XLWSContents.CustomSheetViews, (OpenXmlElement) opWorksheet.Elements<CustomSheetViews>().LastOrDefault<CustomSheetViews>());
      this.contents.Add(XLWSContentManager.XLWSContents.MergeCells, (OpenXmlElement) opWorksheet.Elements<MergeCells>().LastOrDefault<MergeCells>());
      this.contents.Add(XLWSContentManager.XLWSContents.PhoneticProperties, (OpenXmlElement) opWorksheet.Elements<PhoneticProperties>().LastOrDefault<PhoneticProperties>());
      this.contents.Add(XLWSContentManager.XLWSContents.ConditionalFormatting, (OpenXmlElement) opWorksheet.Elements<ConditionalFormatting>().LastOrDefault<ConditionalFormatting>());
      this.contents.Add(XLWSContentManager.XLWSContents.DataValidations, (OpenXmlElement) opWorksheet.Elements<DataValidations>().LastOrDefault<DataValidations>());
      this.contents.Add(XLWSContentManager.XLWSContents.Hyperlinks, (OpenXmlElement) opWorksheet.Elements<Hyperlinks>().LastOrDefault<Hyperlinks>());
      this.contents.Add(XLWSContentManager.XLWSContents.PrintOptions, (OpenXmlElement) opWorksheet.Elements<PrintOptions>().LastOrDefault<PrintOptions>());
      this.contents.Add(XLWSContentManager.XLWSContents.PageMargins, (OpenXmlElement) opWorksheet.Elements<PageMargins>().LastOrDefault<PageMargins>());
      this.contents.Add(XLWSContentManager.XLWSContents.PageSetup, (OpenXmlElement) opWorksheet.Elements<PageSetup>().LastOrDefault<PageSetup>());
      this.contents.Add(XLWSContentManager.XLWSContents.HeaderFooter, (OpenXmlElement) opWorksheet.Elements<HeaderFooter>().LastOrDefault<HeaderFooter>());
      this.contents.Add(XLWSContentManager.XLWSContents.RowBreaks, (OpenXmlElement) opWorksheet.Elements<RowBreaks>().LastOrDefault<RowBreaks>());
      this.contents.Add(XLWSContentManager.XLWSContents.ColumnBreaks, (OpenXmlElement) opWorksheet.Elements<ColumnBreaks>().LastOrDefault<ColumnBreaks>());
      this.contents.Add(XLWSContentManager.XLWSContents.CustomProperties, (OpenXmlElement) opWorksheet.Elements<CustomProperties>().LastOrDefault<CustomProperties>());
      this.contents.Add(XLWSContentManager.XLWSContents.CellWatches, (OpenXmlElement) opWorksheet.Elements<CellWatches>().LastOrDefault<CellWatches>());
      this.contents.Add(XLWSContentManager.XLWSContents.IgnoredErrors, (OpenXmlElement) opWorksheet.Elements<IgnoredErrors>().LastOrDefault<IgnoredErrors>());
      this.contents.Add(XLWSContentManager.XLWSContents.Drawing, (OpenXmlElement) opWorksheet.Elements<Drawing>().LastOrDefault<Drawing>());
      this.contents.Add(XLWSContentManager.XLWSContents.LegacyDrawing, (OpenXmlElement) opWorksheet.Elements<LegacyDrawing>().LastOrDefault<LegacyDrawing>());
      this.contents.Add(XLWSContentManager.XLWSContents.LegacyDrawingHeaderFooter, (OpenXmlElement) opWorksheet.Elements<LegacyDrawingHeaderFooter>().LastOrDefault<LegacyDrawingHeaderFooter>());
      this.contents.Add(XLWSContentManager.XLWSContents.DrawingHeaderFooter, (OpenXmlElement) opWorksheet.Elements<DrawingHeaderFooter>().LastOrDefault<DrawingHeaderFooter>());
      this.contents.Add(XLWSContentManager.XLWSContents.Picture, (OpenXmlElement) opWorksheet.Elements<Picture>().LastOrDefault<Picture>());
      this.contents.Add(XLWSContentManager.XLWSContents.OleObjects, (OpenXmlElement) opWorksheet.Elements<OleObjects>().LastOrDefault<OleObjects>());
      this.contents.Add(XLWSContentManager.XLWSContents.Controls, (OpenXmlElement) opWorksheet.Elements<Controls>().LastOrDefault<Controls>());
      this.contents.Add(XLWSContentManager.XLWSContents.AlternateContent, (OpenXmlElement) opWorksheet.Elements<AlternateContent>().LastOrDefault<AlternateContent>());
      this.contents.Add(XLWSContentManager.XLWSContents.WebPublishItems, (OpenXmlElement) opWorksheet.Elements<WebPublishItems>().LastOrDefault<WebPublishItems>());
      this.contents.Add(XLWSContentManager.XLWSContents.TableParts, (OpenXmlElement) opWorksheet.Elements<TableParts>().LastOrDefault<TableParts>());
      this.contents.Add(XLWSContentManager.XLWSContents.WorksheetExtensionList, (OpenXmlElement) opWorksheet.Elements<WorksheetExtensionList>().LastOrDefault<WorksheetExtensionList>());
    }

    public void SetElement(XLWSContentManager.XLWSContents content, OpenXmlElement element)
    {
      this.contents[content] = element;
    }

    public OpenXmlElement GetPreviousElementFor(XLWSContentManager.XLWSContents content)
    {
      return this.contents[this.contents.Where<KeyValuePair<XLWSContentManager.XLWSContents, OpenXmlElement>>((Func<KeyValuePair<XLWSContentManager.XLWSContents, OpenXmlElement>, bool>) (kp =>
      {
        if (kp.Key < content)
          return kp.Value != null;
        return false;
      })).Max<KeyValuePair<XLWSContentManager.XLWSContents, OpenXmlElement>, XLWSContentManager.XLWSContents>((Func<KeyValuePair<XLWSContentManager.XLWSContents, OpenXmlElement>, XLWSContentManager.XLWSContents>) (kp => kp.Key))];
    }

    public enum XLWSContents
    {
      SheetProperties = 1,
      SheetDimension = 2,
      SheetViews = 3,
      SheetFormatProperties = 4,
      Columns = 5,
      SheetData = 6,
      SheetCalculationProperties = 7,
      SheetProtection = 8,
      ProtectedRanges = 9,
      Scenarios = 10, // 0x0000000A
      AutoFilter = 11, // 0x0000000B
      SortState = 12, // 0x0000000C
      DataConsolidate = 13, // 0x0000000D
      CustomSheetViews = 14, // 0x0000000E
      MergeCells = 15, // 0x0000000F
      PhoneticProperties = 16, // 0x00000010
      ConditionalFormatting = 17, // 0x00000011
      DataValidations = 18, // 0x00000012
      Hyperlinks = 19, // 0x00000013
      PrintOptions = 20, // 0x00000014
      PageMargins = 21, // 0x00000015
      PageSetup = 22, // 0x00000016
      HeaderFooter = 23, // 0x00000017
      RowBreaks = 24, // 0x00000018
      ColumnBreaks = 25, // 0x00000019
      CustomProperties = 26, // 0x0000001A
      CellWatches = 27, // 0x0000001B
      IgnoredErrors = 28, // 0x0000001C
      SmartTags = 29, // 0x0000001D
      Drawing = 30, // 0x0000001E
      LegacyDrawing = 31, // 0x0000001F
      LegacyDrawingHeaderFooter = 32, // 0x00000020
      DrawingHeaderFooter = 33, // 0x00000021
      Picture = 34, // 0x00000022
      OleObjects = 35, // 0x00000023
      Controls = 36, // 0x00000024
      AlternateContent = 37, // 0x00000025
      WebPublishItems = 38, // 0x00000026
      TableParts = 39, // 0x00000027
      WorksheetExtensionList = 40, // 0x00000028
    }
  }
}

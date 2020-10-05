// Decompiled with JetBrains decompiler
// Type: ClosedXML.Excel.XLWorkbook
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using ClosedXML.Excel.CalcEngine;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.CustomProperties;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.ExtendedProperties;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.VariantTypes;
using DocumentFormat.OpenXml.Vml;
using DocumentFormat.OpenXml.Vml.Office;
using DocumentFormat.OpenXml.Vml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace ClosedXML.Excel
{
  public class XLWorkbook : IDisposable
  {
    private static readonly EnumValue<CellValues> CvSharedString = new EnumValue<CellValues>(CellValues.SharedString);
    private static readonly EnumValue<CellValues> CvInlineString = new EnumValue<CellValues>(CellValues.InlineString);
    private static readonly EnumValue<CellValues> CvNumber = new EnumValue<CellValues>(CellValues.Number);
    private static readonly EnumValue<CellValues> CvDate = new EnumValue<CellValues>(CellValues.Date);
    private static readonly EnumValue<CellValues> CvBoolean = new EnumValue<CellValues>(CellValues.Boolean);
    private readonly Dictionary<string, System.Drawing.Color> _colorList = new Dictionary<string, System.Drawing.Color>();
    private readonly Dictionary<string, double> knownUnits = new Dictionary<string, double>()
    {
      {
        "pt",
        1.0
      },
      {
        "in",
        72.0
      },
      {
        "mm",
        360.0 / (double) sbyte.MaxValue
      }
    };
    internal readonly List<XLWorkbook.UnsupportedSheet> UnsupportedSheets = new List<XLWorkbook.UnsupportedSheet>();
    private readonly Dictionary<int, IXLStyle> _stylesById = new Dictionary<int, IXLStyle>();
    private readonly Dictionary<IXLStyle, int> _stylesByStyle = new Dictionary<IXLStyle, int>();
    private const double ColumnWidthOffset = 0.710625;
    private int lastCell;
    private int lastRow;
    private static IXLStyle _defaultStyle;
    private readonly XLWorkbook.XLLoadSource _loadSource;
    private readonly string _originalFile;
    private readonly Stream _originalStream;
    private XLCalcEngine _calcEngine;
    private static XLCalcEngine _calcEngineExpr;
    private SpreadsheetDocumentType _spreadsheetDocumentType;

    private void Load(string file)
    {
      this.LoadSheets(file);
    }

    private void Load(Stream stream)
    {
      this.LoadSheets(stream);
    }

    private void LoadSheets(string fileName)
    {
      using (SpreadsheetDocument dSpreadsheet = SpreadsheetDocument.Open(fileName, false))
        this.LoadSpreadsheetDocument(dSpreadsheet);
    }

    private void LoadSheets(Stream stream)
    {
      using (SpreadsheetDocument dSpreadsheet = SpreadsheetDocument.Open(stream, false))
        this.LoadSpreadsheetDocument(dSpreadsheet);
    }

    private void LoadSpreadsheetDocument(SpreadsheetDocument dSpreadsheet)
    {
      this.ShapeIdManager = new XLIdManager();
      this.SetProperties(dSpreadsheet);
      SharedStringItem[] sharedStrings = (SharedStringItem[]) null;
      if (dSpreadsheet.WorkbookPart.GetPartsOfType<SharedStringTablePart>().Count<SharedStringTablePart>() > 0)
        sharedStrings = dSpreadsheet.WorkbookPart.GetPartsOfType<SharedStringTablePart>().First<SharedStringTablePart>().SharedStringTable.Elements<SharedStringItem>().ToArray<SharedStringItem>();
      if (dSpreadsheet.CustomFilePropertiesPart != null)
      {
        foreach (CustomDocumentProperty element in dSpreadsheet.CustomFilePropertiesPart.Properties.Elements<CustomDocumentProperty>())
        {
          string name = element.Name.Value;
          if (element.VTLPWSTR != null)
            this.CustomProperties.Add<string>(name, element.VTLPWSTR.Text);
          else if (element.VTFileTime != null)
            this.CustomProperties.Add<DateTime>(name, DateTime.ParseExact(element.VTFileTime.Text, "yyyy'-'MM'-'dd'T'HH':'mm':'ss'Z'", (IFormatProvider) CultureInfo.InvariantCulture));
          else if (element.VTDouble != null)
            this.CustomProperties.Add<double>(name, double.Parse(element.VTDouble.Text, (IFormatProvider) CultureInfo.InvariantCulture));
          else if (element.VTBool != null)
            this.CustomProperties.Add<bool>(name, element.VTBool.Text == "true");
        }
      }
      DocumentFormat.OpenXml.Spreadsheet.WorkbookProperties workbookProperties = dSpreadsheet.WorkbookPart.Workbook.WorkbookProperties;
      this.Use1904DateSystem = workbookProperties != null && workbookProperties.Date1904 != null && workbookProperties.Date1904.Value;
      WorkbookProtection workbookProtection = dSpreadsheet.WorkbookPart.Workbook.WorkbookProtection;
      if (workbookProtection != null)
      {
        if (workbookProtection.LockStructure != null)
          this.LockStructure = workbookProtection.LockStructure.Value;
        if (workbookProtection.LockWindows != null)
          this.LockWindows = workbookProtection.LockWindows.Value;
      }
      CalculationProperties calculationProperties = dSpreadsheet.WorkbookPart.Workbook.CalculationProperties;
      if (calculationProperties != null)
      {
        EnumValue<ReferenceModeValues> referenceMode = calculationProperties.ReferenceMode;
        if (referenceMode != null)
          this.ReferenceStyle = referenceMode.Value.ToClosedXml();
        EnumValue<CalculateModeValues> calculationMode = calculationProperties.CalculationMode;
        if (calculationMode != null)
          this.CalculateMode = calculationMode.Value.ToClosedXml();
      }
      ExtendedFilePropertiesPart filePropertiesPart = dSpreadsheet.ExtendedFilePropertiesPart;
      if (filePropertiesPart != null && filePropertiesPart.Properties != null)
      {
        if (filePropertiesPart.Properties.Elements<Company>().Any<Company>())
          this.Properties.Company = filePropertiesPart.Properties.GetFirstChild<Company>().Text;
        if (filePropertiesPart.Properties.Elements<Manager>().Any<Manager>())
          this.Properties.Manager = filePropertiesPart.Properties.GetFirstChild<Manager>().Text;
      }
      Stylesheet s = (Stylesheet) null;
      if (dSpreadsheet.WorkbookPart.WorkbookStylesPart != null && dSpreadsheet.WorkbookPart.WorkbookStylesPart.Stylesheet != null)
        s = dSpreadsheet.WorkbookPart.WorkbookStylesPart.Stylesheet;
      NumberingFormats numberingFormats = s == null ? (NumberingFormats) null : s.NumberingFormats;
      Fills fills = s == null ? (Fills) null : s.Fills;
      Borders borders = s == null ? (Borders) null : s.Borders;
      DocumentFormat.OpenXml.Spreadsheet.Fonts fonts = s == null ? (DocumentFormat.OpenXml.Spreadsheet.Fonts) null : s.Fonts;
      int dfCount = 0;
      Dictionary<int, DifferentialFormat> differentialFormats = s == null || s.DifferentialFormats == null ? new Dictionary<int, DifferentialFormat>() : s.DifferentialFormats.Elements<DifferentialFormat>().ToDictionary<DifferentialFormat, int>((Func<DifferentialFormat, int>) (k => dfCount++));
      Sheets sheets = dSpreadsheet.WorkbookPart.Workbook.Sheets;
      int position = 0;
      foreach (Sheet sheet in sheets.OfType<Sheet>())
      {
        ++position;
        Dictionary<uint, string> sharedFormulasR1C1 = new Dictionary<uint, string>();
        WorksheetPart partById = dSpreadsheet.WorkbookPart.GetPartById((string) sheet.Id) as WorksheetPart;
        if (partById == null)
        {
          this.UnsupportedSheets.Add(new XLWorkbook.UnsupportedSheet()
          {
            SheetId = sheet.SheetId.Value,
            Position = position
          });
        }
        else
        {
          XLWorksheet ws = (XLWorksheet) this.WorksheetsInternal.Add((string) sheet.Name, position);
          ws.RelId = (string) sheet.Id;
          ws.SheetId = (int) sheet.SheetId.Value;
          if (sheet.State != null)
            ws.Visibility = sheet.State.Value.ToClosedXml();
          Dictionary<int, IXLStyle> styleList = new Dictionary<int, IXLStyle>();
          using (OpenXmlReader openXmlReader = OpenXmlReader.Create((OpenXmlPart) partById))
          {
            while (openXmlReader.Read())
            {
              if (openXmlReader.ElementType == typeof (SheetFormatProperties))
              {
                SheetFormatProperties formatProperties = (SheetFormatProperties) openXmlReader.LoadCurrentElement();
                if (formatProperties != null)
                {
                  if (formatProperties.DefaultRowHeight != null)
                    ws.RowHeight = (double) formatProperties.DefaultRowHeight;
                  ws.RowHeightChanged = formatProperties.CustomHeight != null && formatProperties.CustomHeight.Value;
                  if (formatProperties.DefaultColumnWidth != null)
                    ws.ColumnWidth = (double) formatProperties.DefaultColumnWidth;
                }
              }
              else if (openXmlReader.ElementType == typeof (SheetViews))
                XLWorkbook.LoadSheetViews((SheetViews) openXmlReader.LoadCurrentElement(), ws);
              else if (openXmlReader.ElementType == typeof (MergeCells))
              {
                MergeCells mergeCells = (MergeCells) openXmlReader.LoadCurrentElement();
                if (mergeCells != null)
                {
                  foreach (MergeCell element in mergeCells.Elements<MergeCell>())
                    ws.Range((string) element.Reference).Merge(false);
                }
              }
              else if (openXmlReader.ElementType == typeof (Columns))
                this.LoadColumns(s, numberingFormats, fills, borders, fonts, ws, (Columns) openXmlReader.LoadCurrentElement());
              else if (openXmlReader.ElementType == typeof (Row))
              {
                this.lastRow = 0;
                this.LoadRows(s, numberingFormats, fills, borders, fonts, ws, sharedStrings, sharedFormulasR1C1, styleList, (Row) openXmlReader.LoadCurrentElement());
              }
              else if (openXmlReader.ElementType == typeof (AutoFilter))
                XLWorkbook.LoadAutoFilter((AutoFilter) openXmlReader.LoadCurrentElement(), ws);
              else if (openXmlReader.ElementType == typeof (SheetProtection))
                XLWorkbook.LoadSheetProtection((SheetProtection) openXmlReader.LoadCurrentElement(), ws);
              else if (openXmlReader.ElementType == typeof (DocumentFormat.OpenXml.Spreadsheet.DataValidations))
                XLWorkbook.LoadDataValidations((DocumentFormat.OpenXml.Spreadsheet.DataValidations) openXmlReader.LoadCurrentElement(), ws);
              else if (openXmlReader.ElementType == typeof (DocumentFormat.OpenXml.Spreadsheet.ConditionalFormatting))
                this.LoadConditionalFormatting((DocumentFormat.OpenXml.Spreadsheet.ConditionalFormatting) openXmlReader.LoadCurrentElement(), ws, differentialFormats);
              else if (openXmlReader.ElementType == typeof (Hyperlinks))
                XLWorkbook.LoadHyperlinks((Hyperlinks) openXmlReader.LoadCurrentElement(), partById, ws);
              else if (openXmlReader.ElementType == typeof (PrintOptions))
                XLWorkbook.LoadPrintOptions((PrintOptions) openXmlReader.LoadCurrentElement(), ws);
              else if (openXmlReader.ElementType == typeof (PageMargins))
                XLWorkbook.LoadPageMargins((PageMargins) openXmlReader.LoadCurrentElement(), ws);
              else if (openXmlReader.ElementType == typeof (PageSetup))
                XLWorkbook.LoadPageSetup((PageSetup) openXmlReader.LoadCurrentElement(), ws);
              else if (openXmlReader.ElementType == typeof (HeaderFooter))
                XLWorkbook.LoadHeaderFooter((HeaderFooter) openXmlReader.LoadCurrentElement(), ws);
              else if (openXmlReader.ElementType == typeof (SheetProperties))
                this.LoadSheetProperties((SheetProperties) openXmlReader.LoadCurrentElement(), ws);
              else if (openXmlReader.ElementType == typeof (RowBreaks))
                XLWorkbook.LoadRowBreaks((RowBreaks) openXmlReader.LoadCurrentElement(), ws);
              else if (openXmlReader.ElementType == typeof (ColumnBreaks))
                XLWorkbook.LoadColumnBreaks((ColumnBreaks) openXmlReader.LoadCurrentElement(), ws);
              else if (openXmlReader.ElementType == typeof (LegacyDrawing))
                ws.LegacyDrawingId = (openXmlReader.LoadCurrentElement() as LegacyDrawing).Id.Value;
            }
            openXmlReader.Close();
          }
          foreach (TableDefinitionPart tableDefinitionPart in partById.TableDefinitionParts)
          {
            DocumentFormat.OpenXml.Spreadsheet.Table table1 = tableDefinitionPart.Table;
            string rangeAddressStr = table1.Reference.Value;
            XLTable table2 = ws.Range(rangeAddressStr).CreateTable((string) table1.Name, false) as XLTable;
            if (table1.HeaderRowCount != null && (int) (uint) table1.HeaderRowCount == 0)
            {
              table2._showHeaderRow = false;
              table2.AddFields(table1.TableColumns.Cast<TableColumn>().Select<TableColumn, string>((Func<TableColumn, string>) (t => this.GetTableColumnName(t.Name.Value))));
            }
            else
              table2.InitializeAutoFilter();
            if (table1.TotalsRowCount != null && table1.TotalsRowCount.Value > 0U)
              table2._showTotalsRow = true;
            if (table1.TableStyleInfo != null)
            {
              if (table1.TableStyleInfo.ShowFirstColumn != null)
                table2.EmphasizeFirstColumn = table1.TableStyleInfo.ShowFirstColumn.Value;
              if (table1.TableStyleInfo.ShowLastColumn != null)
                table2.EmphasizeLastColumn = table1.TableStyleInfo.ShowLastColumn.Value;
              if (table1.TableStyleInfo.ShowRowStripes != null)
                table2.ShowRowStripes = table1.TableStyleInfo.ShowRowStripes.Value;
              if (table1.TableStyleInfo.ShowColumnStripes != null)
                table2.ShowColumnStripes = table1.TableStyleInfo.ShowColumnStripes.Value;
              table2.Theme = table1.TableStyleInfo.Name == null ? XLTableTheme.None : (XLTableTheme) Enum.Parse(typeof (XLTableTheme), table1.TableStyleInfo.Name.Value);
            }
            if (table1.AutoFilter != null)
            {
              table2.ShowAutoFilter = true;
              XLWorkbook.LoadAutoFilterColumns(table1.AutoFilter, table2.AutoFilter);
            }
            else
              table2.ShowAutoFilter = false;
            if (table2.ShowTotalsRow)
            {
              foreach (TableColumn tableColumn in table1.TableColumns.Cast<TableColumn>())
              {
                string tableColumnName = this.GetTableColumnName(tableColumn.Name.Value);
                if (tableColumn.TotalsRowFunction != null)
                  table2.Field(tableColumnName).TotalsRowFunction = tableColumn.TotalsRowFunction.Value.ToClosedXml();
                if (tableColumn.TotalsRowFormula != null)
                  table2.Field(tableColumnName).TotalsRowFormulaA1 = tableColumn.TotalsRowFormula.Text;
                if (tableColumn.TotalsRowLabel != null)
                  table2.Field(tableColumnName).TotalsRowLabel = tableColumn.TotalsRowLabel.Value;
              }
              if (table2.AutoFilter != null)
                table2.AutoFilter.Range = (IXLRange) table2.Worksheet.Range(table2.RangeAddress.FirstAddress.RowNumber, table2.RangeAddress.FirstAddress.ColumnNumber, table2.RangeAddress.LastAddress.RowNumber - 1, table2.RangeAddress.LastAddress.ColumnNumber);
            }
            else if (table2.AutoFilter != null)
              table2.AutoFilter.Range = (IXLRange) table2.Worksheet.Range((IXLRangeAddress) table2.RangeAddress);
          }
          if (partById.WorksheetCommentsPart != null)
          {
            Comments comments = partById.WorksheetCommentsPart.Comments;
            OpenXmlElementList childElements1 = comments.GetFirstChild<Authors>().ChildElements;
            OpenXmlElementList childElements2 = comments.GetFirstChild<CommentList>().ChildElements;
            XDocument commentVmlFile = this.GetCommentVmlFile(partById);
            foreach (DocumentFormat.OpenXml.Spreadsheet.Comment comment1 in childElements2)
            {
              XLCell xlCell = ws.Cell((string) comment1.Reference);
              XLComment comment2 = xlCell.Comment;
              comment2.Author = childElements1[(int) comment1.AuthorId.Value].InnerText;
              foreach (DocumentFormat.OpenXml.Spreadsheet.Run element in comment1.GetFirstChild<CommentText>().Elements<DocumentFormat.OpenXml.Spreadsheet.Run>())
              {
                DocumentFormat.OpenXml.Spreadsheet.RunProperties runProperties = element.RunProperties;
                string text = element.Text.InnerText.FixNewLines();
                IXLRichString xlRichString = xlCell.Comment.AddText(text);
                this.LoadFont((OpenXmlElement) runProperties, (IXLFontBase) xlRichString);
              }
              XElement commentShape = XLWorkbook.GetCommentShape(commentVmlFile);
              this.LoadShapeProperties<IXLComment>((IXLDrawing<IXLComment>) comment2, commentShape);
              XElement clientData = commentShape.Elements().First<XElement>((Func<XElement, bool>) (e => e.Name.LocalName == "ClientData"));
              this.LoadClientData<IXLComment>((IXLDrawing<IXLComment>) comment2, clientData);
              XElement textBox = commentShape.Elements().First<XElement>((Func<XElement, bool>) (e => e.Name.LocalName == "textbox"));
              this.LoadTextBox<IXLComment>((IXLDrawing<IXLComment>) comment2, textBox);
              XAttribute xattribute = commentShape.Attribute((XName) "alt");
              if (xattribute != null)
                comment2.Style.Web.SetAlternateText(xattribute.Value);
              this.LoadColorsAndLines<IXLComment>((IXLDrawing<IXLComment>) comment2, commentShape);
              commentShape.Remove();
            }
          }
        }
      }
      Workbook workbook = dSpreadsheet.WorkbookPart.Workbook;
      BookViews bookViews = workbook.BookViews;
      if (bookViews != null && bookViews.Any<OpenXmlElement>())
      {
        WorkbookView workbookView = bookViews.First<OpenXmlElement>() as WorkbookView;
        if (workbookView != null && workbookView.ActiveTab != null)
        {
          XLWorkbook.UnsupportedSheet unsupportedSheet = this.UnsupportedSheets.FirstOrDefault<XLWorkbook.UnsupportedSheet>((Func<XLWorkbook.UnsupportedSheet, bool>) (us => us.Position == (int) workbookView.ActiveTab.Value + 1));
          if (unsupportedSheet != null)
            unsupportedSheet.IsActive = true;
          else
            this.Worksheet((int) workbookView.ActiveTab.Value + 1).SetTabActive();
        }
      }
      this.LoadDefinedNames(workbook);
    }

    private XDocument GetCommentVmlFile(WorksheetPart wsPart)
    {
      XDocument xdoc = (XDocument) null;
      foreach (OpenXmlPart vmlDrawingPart in wsPart.VmlDrawingParts)
      {
        xdoc = XDocumentExtensions.Load(vmlDrawingPart.GetStream(FileMode.Open));
        if (xdoc.Root != null)
        {
          if (XLWorkbook.GetCommentShape(xdoc) != null)
            break;
        }
      }
      if (xdoc == null)
        throw new Exception("Could not load comments file");
      return xdoc;
    }

    private static XElement GetCommentShape(XDocument xdoc)
    {
      XElement xelement = xdoc.Root.Element((XName) "xml");
      return xelement == null ? xdoc.Root.Elements().FirstOrDefault<XElement>((Func<XElement, bool>) (e =>
      {
        if (!((string) e.Attribute((XName) "type") == "#_x0000_t202"))
          return (string) e.Attribute((XName) "type") == "#_xssf_cell_comment";
        return true;
      })) : xelement.Elements().FirstOrDefault<XElement>((Func<XElement, bool>) (e => (string) e.Attribute((XName) "type") == "#_x0000_t202"));
    }

    private string GetTableColumnName(string name)
    {
      return name.Replace("_x000a_", Environment.NewLine).Replace("_x005f_x000a_", "_x000a_");
    }

    private XLColor ExtractColor(string color)
    {
      if (color.IndexOf("[") < 0)
        return XLColor.FromHtml(color);
      int startIndex = color.IndexOf("[") + 1;
      int num = color.IndexOf("]", startIndex);
      return XLColor.FromIndex(int.Parse(color.Substring(startIndex, num - startIndex)));
    }

    private void LoadColorsAndLines<T>(IXLDrawing<T> drawing, XElement shape)
    {
      XAttribute xattribute1 = shape.Attribute((XName) "strokecolor");
      if (xattribute1 != null)
        drawing.Style.ColorsAndLines.LineColor = this.ExtractColor(xattribute1.Value);
      XAttribute xattribute2 = shape.Attribute((XName) "strokeweight");
      if (xattribute2 != null)
        drawing.Style.ColorsAndLines.LineWeight = this.GetPtValue(xattribute2.Value);
      XAttribute xattribute3 = shape.Attribute((XName) "fillcolor");
      if (xattribute3 != null && !xattribute3.Value.ToLower().Contains("infobackground"))
        drawing.Style.ColorsAndLines.FillColor = this.ExtractColor(xattribute3.Value);
      XElement xelement1 = shape.Elements().FirstOrDefault<XElement>((Func<XElement, bool>) (e => e.Name.LocalName == "fill"));
      if (xelement1 != null)
      {
        XAttribute xattribute4 = xelement1.Attribute((XName) "opacity");
        if (xattribute4 != null)
        {
          string s = xattribute4.Value;
          drawing.Style.ColorsAndLines.FillTransparency = !s.EndsWith("f") ? double.Parse(s, (IFormatProvider) CultureInfo.InvariantCulture) : double.Parse(s.Substring(0, s.Length - 1), (IFormatProvider) CultureInfo.InvariantCulture) / 65536.0;
        }
      }
      XElement xelement2 = shape.Elements().FirstOrDefault<XElement>((Func<XElement, bool>) (e => e.Name.LocalName == "stroke"));
      if (xelement2 == null)
        return;
      XAttribute xattribute5 = xelement2.Attribute((XName) "opacity");
      if (xattribute5 != null)
      {
        string s = xattribute5.Value;
        drawing.Style.ColorsAndLines.LineTransparency = !s.EndsWith("f") ? double.Parse(s, (IFormatProvider) CultureInfo.InvariantCulture) : double.Parse(s.Substring(0, s.Length - 1), (IFormatProvider) CultureInfo.InvariantCulture) / 65536.0;
      }
      XAttribute xattribute6 = xelement2.Attribute((XName) "dashstyle");
      if (xattribute6 != null)
      {
        string lower = xattribute6.Value.ToLower();
        if (lower == "1 1" || lower == "shortdot")
        {
          XAttribute xattribute4 = xelement2.Attribute((XName) "endcap");
          drawing.Style.ColorsAndLines.LineDash = xattribute4 == null || !(xattribute4.Value == "round") ? XLDashStyle.SquareDot : XLDashStyle.RoundDot;
        }
        else
        {
          switch (lower)
          {
            case "dash":
              drawing.Style.ColorsAndLines.LineDash = XLDashStyle.Dash;
              break;
            case "dashdot":
              drawing.Style.ColorsAndLines.LineDash = XLDashStyle.DashDot;
              break;
            case "longdash":
              drawing.Style.ColorsAndLines.LineDash = XLDashStyle.LongDash;
              break;
            case "longdashdot":
              drawing.Style.ColorsAndLines.LineDash = XLDashStyle.LongDashDot;
              break;
            case "longdashdotdot":
              drawing.Style.ColorsAndLines.LineDash = XLDashStyle.LongDashDotDot;
              break;
          }
        }
      }
      XAttribute xattribute7 = xelement2.Attribute((XName) "linestyle");
      if (xattribute7 == null)
        return;
      switch (xattribute7.Value.ToLower())
      {
        case "single":
          drawing.Style.ColorsAndLines.LineStyle = XLLineStyle.Single;
          break;
        case "thickbetweenthin":
          drawing.Style.ColorsAndLines.LineStyle = XLLineStyle.ThickBetweenThin;
          break;
        case "thickthin":
          drawing.Style.ColorsAndLines.LineStyle = XLLineStyle.ThickThin;
          break;
        case "thinthick":
          drawing.Style.ColorsAndLines.LineStyle = XLLineStyle.ThinThick;
          break;
        case "thinthin":
          drawing.Style.ColorsAndLines.LineStyle = XLLineStyle.ThinThin;
          break;
      }
    }

    private void LoadTextBox<T>(IXLDrawing<T> xlDrawing, XElement textBox)
    {
      XAttribute attStyle = textBox.Attribute((XName) "style");
      if (attStyle != null)
        XLWorkbook.LoadTextBoxStyle<T>(xlDrawing, attStyle);
      XAttribute attInset = textBox.Attribute((XName) "inset");
      if (attInset == null)
        return;
      this.LoadTextBoxInset<T>(xlDrawing, attInset);
    }

    private void LoadTextBoxInset<T>(IXLDrawing<T> xlDrawing, XAttribute attInset)
    {
      string[] strArray = attInset.Value.Split(',');
      xlDrawing.Style.Margins.Left = this.GetInsetValue(strArray[0]);
      xlDrawing.Style.Margins.Top = this.GetInsetValue(strArray[1]);
      xlDrawing.Style.Margins.Right = this.GetInsetValue(strArray[2]);
      xlDrawing.Style.Margins.Bottom = this.GetInsetValue(strArray[3]);
    }

    private double GetInsetValue(string value)
    {
      string str = value.Trim();
      if (str.EndsWith("pt"))
        return double.Parse(str.Substring(0, str.Length - 2), (IFormatProvider) CultureInfo.InvariantCulture) / 72.0;
      return double.Parse(str.Substring(0, str.Length - 2), (IFormatProvider) CultureInfo.InvariantCulture);
    }

    private static void LoadTextBoxStyle<T>(IXLDrawing<T> xlDrawing, XAttribute attStyle)
    {
      string str1 = attStyle.Value;
      char[] chArray1 = new char[1]{ ';' };
      foreach (string str2 in str1.Split(chArray1))
      {
        char[] chArray2 = new char[1]{ ':' };
        string[] strArray = str2.Split(chArray2);
        if (strArray.Length == 2)
        {
          string lower = strArray[0].Trim().ToLower();
          string str3 = strArray[1].Trim();
          bool flag = false;
          switch (lower)
          {
            case "mso-fit-shape-to-text":
              xlDrawing.Style.Size.SetAutomaticSize(str3.Equals("t"));
              break;
            case "mso-layout-flow-alt":
              if (str3.Equals("bottom-to-top"))
              {
                xlDrawing.Style.Alignment.SetOrientation(XLDrawingTextOrientation.BottomToTop);
                break;
              }
              if (str3.Equals("top-to-bottom"))
              {
                xlDrawing.Style.Alignment.SetOrientation(XLDrawingTextOrientation.Vertical);
                break;
              }
              break;
            case "layout-flow":
              flag = str3.Equals("vertical");
              break;
            case "mso-direction-alt":
              if (str3 == "auto")
              {
                xlDrawing.Style.Alignment.Direction = XLDrawingTextDirection.Context;
                break;
              }
              break;
            case "direction":
              if (str3 == "RTL")
              {
                xlDrawing.Style.Alignment.Direction = XLDrawingTextDirection.RightToLeft;
                break;
              }
              break;
          }
          if (flag && xlDrawing.Style.Alignment.Orientation == XLDrawingTextOrientation.LeftToRight)
            xlDrawing.Style.Alignment.Orientation = XLDrawingTextOrientation.TopToBottom;
        }
      }
    }

    private void LoadClientData<T>(IXLDrawing<T> drawing, XElement clientData)
    {
      XElement anchor = clientData.Elements().FirstOrDefault<XElement>((Func<XElement, bool>) (e => e.Name.LocalName == "Anchor"));
      if (anchor != null)
        XLWorkbook.LoadClientDataAnchor<T>(drawing, anchor);
      XLWorkbook.LoadDrawingPositioning<T>(drawing, clientData);
      this.LoadDrawingProtection<T>(drawing, clientData);
      XElement xelement = clientData.Elements().FirstOrDefault<XElement>((Func<XElement, bool>) (e => e.Name.LocalName == "Visible"));
      drawing.Visible = xelement != null && xelement.Value.ToLower().StartsWith("t");
      this.LoadDrawingHAlignment<T>(drawing, clientData);
      this.LoadDrawingVAlignment<T>(drawing, clientData);
    }

    private void LoadDrawingHAlignment<T>(IXLDrawing<T> drawing, XElement clientData)
    {
      XElement xelement = clientData.Elements().FirstOrDefault<XElement>((Func<XElement, bool>) (e => e.Name.LocalName == "TextHAlign"));
      if (xelement == null)
        return;
      drawing.Style.Alignment.Horizontal = (XLDrawingHorizontalAlignment) Enum.Parse(typeof (XLDrawingHorizontalAlignment), xelement.Value.ToProper());
    }

    private void LoadDrawingVAlignment<T>(IXLDrawing<T> drawing, XElement clientData)
    {
      XElement xelement = clientData.Elements().FirstOrDefault<XElement>((Func<XElement, bool>) (e => e.Name.LocalName == "TextVAlign"));
      if (xelement == null)
        return;
      drawing.Style.Alignment.Vertical = (XLDrawingVerticalAlignment) Enum.Parse(typeof (XLDrawingVerticalAlignment), xelement.Value.ToProper());
    }

    private void LoadDrawingProtection<T>(IXLDrawing<T> drawing, XElement clientData)
    {
      XElement xelement1 = clientData.Elements().FirstOrDefault<XElement>((Func<XElement, bool>) (e => e.Name.LocalName == "Locked"));
      XElement xelement2 = clientData.Elements().FirstOrDefault<XElement>((Func<XElement, bool>) (e => e.Name.LocalName == "LockText"));
      bool flag1 = xelement1 != null && xelement1.Value.ToLower() == "true";
      bool flag2 = xelement2 != null && xelement2.Value.ToLower() == "true";
      drawing.Style.Protection.Locked = flag1;
      drawing.Style.Protection.LockText = flag2;
    }

    private static void LoadDrawingPositioning<T>(IXLDrawing<T> drawing, XElement clientData)
    {
      XElement xelement1 = clientData.Elements().FirstOrDefault<XElement>((Func<XElement, bool>) (e => e.Name.LocalName == "MoveWithCells"));
      XElement xelement2 = clientData.Elements().FirstOrDefault<XElement>((Func<XElement, bool>) (e => e.Name.LocalName == "SizeWithCells"));
      bool flag1 = xelement1 == null || !(xelement1.Value.ToLower() == "true");
      bool flag2 = xelement2 == null || !(xelement2.Value.ToLower() == "true");
      if (flag1 && !flag2)
        drawing.Style.Properties.Positioning = XLDrawingAnchor.MoveWithCells;
      else if (flag1 && flag2)
        drawing.Style.Properties.Positioning = XLDrawingAnchor.MoveAndSizeWithCells;
      else
        drawing.Style.Properties.Positioning = XLDrawingAnchor.Absolute;
    }

    private static void LoadClientDataAnchor<T>(IXLDrawing<T> drawing, XElement anchor)
    {
      string[] strArray = anchor.Value.Split(',');
      drawing.Position.Column = int.Parse(strArray[0]) + 1;
      drawing.Position.ColumnOffset = double.Parse(strArray[1], (IFormatProvider) CultureInfo.InvariantCulture) / 7.2;
      drawing.Position.Row = int.Parse(strArray[2]) + 1;
      drawing.Position.RowOffset = double.Parse(strArray[3], (IFormatProvider) CultureInfo.InvariantCulture);
    }

    private void LoadShapeProperties<T>(IXLDrawing<T> xlDrawing, XElement shape)
    {
      XAttribute xattribute = shape.Attribute((XName) "style");
      if (xattribute == null)
        return;
      string str1 = xattribute.Value;
      char[] chArray1 = new char[1]{ ';' };
      foreach (string str2 in str1.Split(chArray1))
      {
        char[] chArray2 = new char[1]{ ':' };
        string[] strArray = str2.Split(chArray2);
        if (strArray.Length == 2)
        {
          string lower = strArray[0].Trim().ToLower();
          string s = strArray[1].Trim();
          switch (lower)
          {
            case "visibility":
              xlDrawing.Visible = s.ToLower().Equals("visible");
              continue;
            case "width":
              xlDrawing.Style.Size.Width = this.GetPtValue(s) / 7.5;
              continue;
            case "height":
              xlDrawing.Style.Size.Height = this.GetPtValue(s);
              continue;
            case "z-index":
              xlDrawing.ZOrder = int.Parse(s);
              continue;
            default:
              continue;
          }
        }
      }
    }

    private double GetPtValue(string value)
    {
      KeyValuePair<string, double> keyValuePair = this.knownUnits.FirstOrDefault<KeyValuePair<string, double>>((Func<KeyValuePair<string, double>, bool>) (ku => value.Contains(ku.Key)));
      if (keyValuePair.Key == null)
        return double.Parse(value);
      return double.Parse(value.Replace(keyValuePair.Key, string.Empty), (IFormatProvider) CultureInfo.InvariantCulture) * keyValuePair.Value;
    }

    private void LoadDefinedNames(Workbook workbook)
    {
      if (workbook.DefinedNames == null)
        return;
      foreach (DocumentFormat.OpenXml.Spreadsheet.DefinedName definedName1 in (OpenXmlElement) workbook.DefinedNames)
      {
        DocumentFormat.OpenXml.Spreadsheet.DefinedName definedName = definedName1;
        StringValue name = definedName.Name;
        if ((string) name == "_xlnm.Print_Area")
        {
          string text = definedName.Text;
          char[] chArray = new char[1]{ ',' };
          foreach (string rangeAddress in text.Split(chArray))
          {
            if (rangeAddress.Contains("["))
            {
              rangeAddress.Substring(0, rangeAddress.IndexOf("["));
              this.Worksheets.First<IXLWorksheet>((Func<IXLWorksheet, bool>) (w => (long) (w as XLWorksheet).SheetId == (long) ((uint) definedName.LocalSheetId + 1U))).PageSetup.PrintAreas.Add(rangeAddress);
            }
            else
            {
              string sheetName;
              string sheetArea;
              XLWorkbook.ParseReference(rangeAddress, out sheetName, out sheetArea);
              if (!sheetArea.Equals("#REF") && !sheetArea.EndsWith("#REF!") && sheetArea.Length != 0)
                this.WorksheetsInternal.Worksheet(sheetName).PageSetup.PrintAreas.Add(sheetArea);
            }
          }
        }
        else if ((string) name == "_xlnm.Print_Titles")
        {
          this.LoadPrintTitles(definedName);
        }
        else
        {
          string text = definedName.Text;
          if (!text.Equals("#REF") && !text.EndsWith("#REF!"))
          {
            UInt32Value localSheetId = definedName.LocalSheetId;
            StringValue comment = definedName.Comment;
            if (localSheetId == null)
            {
              if (!this.NamedRanges.Any<IXLNamedRange>((Func<IXLNamedRange, bool>) (nr => nr.Name == (string) name)))
                this.NamedRanges.Add((string) name, text, (string) comment);
            }
            else if (!this.Worksheet(int.Parse((string) ((OpenXmlSimpleType) localSheetId)) + 1).NamedRanges.Any<IXLNamedRange>((Func<IXLNamedRange, bool>) (nr => nr.Name == (string) name)))
              this.Worksheet(int.Parse((string) ((OpenXmlSimpleType) localSheetId)) + 1).NamedRanges.Add((string) name, text, (string) comment);
          }
        }
      }
    }

    private void LoadPrintTitles(DocumentFormat.OpenXml.Spreadsheet.DefinedName definedName)
    {
      string[] strArray = definedName.Text.Split(',');
      if (strArray.Length > 0)
      {
        foreach (string area in strArray)
          this.SetColumnsOrRowsToRepeat(area);
      }
      else
        this.SetColumnsOrRowsToRepeat(definedName.Text);
    }

    private void SetColumnsOrRowsToRepeat(string area)
    {
      string sheetName;
      string sheetArea;
      XLWorkbook.ParseReference(area, out sheetName, out sheetArea);
      if (sheetArea.Equals("#REF"))
        return;
      if (XLWorkbook.IsColReference(sheetArea))
        this.WorksheetsInternal.Worksheet(sheetName).PageSetup.SetColumnsToRepeatAtLeft(sheetArea);
      if (!XLWorkbook.IsRowReference(sheetArea))
        return;
      this.WorksheetsInternal.Worksheet(sheetName).PageSetup.SetRowsToRepeatAtTop(sheetArea);
    }

    private static bool IsColReference(string sheetArea)
    {
      return char.IsLetter((int) sheetArea[0] == 36 ? sheetArea[1] : sheetArea[0]);
    }

    private static bool IsRowReference(string sheetArea)
    {
      return char.IsNumber((int) sheetArea[0] == 36 ? sheetArea[1] : sheetArea[0]);
    }

    private static void ParseReference(string item, out string sheetName, out string sheetArea)
    {
      string[] strArray = item.Trim().Split('!');
      sheetName = strArray[0].Replace("'", "");
      sheetArea = strArray[1];
    }

    private void LoadCells(SharedStringItem[] sharedStrings, Stylesheet s, NumberingFormats numberingFormats, Fills fills, Borders borders, DocumentFormat.OpenXml.Spreadsheet.Fonts fonts, Dictionary<uint, string> sharedFormulasR1C1, XLWorksheet ws, Dictionary<int, IXLStyle> styleList, Cell cell, int rowIndex)
    {
      int index = cell.StyleIndex != null ? int.Parse(cell.StyleIndex.InnerText) : 0;
      string cellAddressInRange = cell.CellReference == null ? XLHelper.GetColumnLetterFromNumber(++this.lastCell) + (object) rowIndex : cell.CellReference.Value;
      XLCell xlCell = ws.CellFast(cellAddressInRange);
      if (styleList.ContainsKey(index))
      {
        xlCell.Style = styleList[index];
      }
      else
      {
        this.ApplyStyle((IXLStylized) xlCell, index, s, fills, borders, fonts, numberingFormats);
        styleList.Add(index, xlCell.Style);
      }
      if (cell.CellFormula != null && cell.CellFormula.SharedIndex != null && cell.CellFormula.Reference != null)
      {
        string str = cell.CellFormula.FormulaType == null || (CellFormulaValues) cell.CellFormula.FormulaType != CellFormulaValues.Array ? cell.CellFormula.Text : "{" + cell.CellFormula.Text + "}";
        if (cell.CellFormula.Reference != null)
          xlCell.FormulaReference = (IXLRangeAddress) ws.Range(cell.CellFormula.Reference.Value).RangeAddress;
        xlCell.FormulaA1 = str;
        sharedFormulasR1C1.Add(cell.CellFormula.SharedIndex.Value, xlCell.FormulaR1C1);
        if (cell.CellValue == null)
          return;
        xlCell.ValueCached = cell.CellValue.Text;
      }
      else if (cell.CellFormula != null)
      {
        if (cell.CellFormula.SharedIndex != null)
        {
          xlCell.FormulaR1C1 = sharedFormulasR1C1[cell.CellFormula.SharedIndex.Value];
        }
        else
        {
          string str = cell.CellFormula.FormulaType == null || (CellFormulaValues) cell.CellFormula.FormulaType != CellFormulaValues.Array ? cell.CellFormula.Text : "{" + cell.CellFormula.Text + "}";
          xlCell.FormulaA1 = str;
        }
        if (cell.CellFormula.Reference != null)
          xlCell.FormulaReference = (IXLRangeAddress) ws.Range(cell.CellFormula.Reference.Value).RangeAddress;
        if (cell.CellValue == null)
          return;
        xlCell.ValueCached = cell.CellValue.Text;
      }
      else if (cell.DataType != null)
      {
        if ((CellValues) cell.DataType == CellValues.InlineString)
        {
          xlCell._cellValue = cell.InlineString != null ? cell.InlineString.Text.Text.FixNewLines() : string.Empty;
          xlCell._dataType = XLCellValues.Text;
          xlCell.ShareString = false;
        }
        else if ((CellValues) cell.DataType == CellValues.SharedString)
        {
          if (cell.CellValue != null)
          {
            if (!XLHelper.IsNullOrWhiteSpace(cell.CellValue.Text))
            {
              SharedStringItem sharedString = sharedStrings[int.Parse(cell.CellValue.Text)];
              IEnumerable<DocumentFormat.OpenXml.Spreadsheet.Run> runs = sharedString.Elements<DocumentFormat.OpenXml.Spreadsheet.Run>();
              IEnumerable<PhoneticRun> phoneticRuns = sharedString.Elements<PhoneticRun>();
              IEnumerable<PhoneticProperties> source = sharedString.Elements<PhoneticProperties>();
              bool flag = false;
              foreach (DocumentFormat.OpenXml.Spreadsheet.Run run in runs)
              {
                DocumentFormat.OpenXml.Spreadsheet.RunProperties runProperties = run.RunProperties;
                string text = run.Text.InnerText.FixNewLines();
                if (runProperties == null)
                {
                  xlCell.RichText.AddText(text, (IXLFontBase) xlCell.Style.Font);
                }
                else
                {
                  IXLRichString xlRichString = xlCell.RichText.AddText(text);
                  this.LoadFont((OpenXmlElement) runProperties, (IXLFontBase) xlRichString);
                }
                if (!flag)
                  flag = true;
              }
              if (!flag)
                xlCell._cellValue = sharedString.Text.InnerText;
              PhoneticProperties phoneticProperties = source.FirstOrDefault<PhoneticProperties>();
              if (phoneticProperties != null)
              {
                if (phoneticProperties.Alignment != null)
                  xlCell.RichText.Phonetics.Alignment = phoneticProperties.Alignment.Value.ToClosedXml();
                if (phoneticProperties.Type != null)
                  xlCell.RichText.Phonetics.Type = phoneticProperties.Type.Value.ToClosedXml();
                this.LoadFont((OpenXmlElement) phoneticProperties, (IXLFontBase) xlCell.RichText.Phonetics);
              }
              foreach (PhoneticRun phoneticRun in phoneticRuns)
                xlCell.RichText.Phonetics.Add(phoneticRun.Text.InnerText.FixNewLines(), (int) phoneticRun.BaseTextStartIndex.Value, (int) phoneticRun.EndingBaseIndex.Value);
            }
            else
              xlCell._cellValue = cell.CellValue.Text.FixNewLines();
          }
          else
            xlCell._cellValue = string.Empty;
          xlCell._dataType = XLCellValues.Text;
        }
        else if ((CellValues) cell.DataType == CellValues.Date)
        {
          if (!XLHelper.IsNullOrWhiteSpace(cell.CellValue.Text))
            xlCell._cellValue = double.Parse(cell.CellValue.Text, (IFormatProvider) CultureInfo.InvariantCulture).ToString();
          xlCell._dataType = XLCellValues.DateTime;
        }
        else if ((CellValues) cell.DataType == CellValues.Boolean)
        {
          xlCell._cellValue = cell.CellValue.Text;
          xlCell._dataType = XLCellValues.Boolean;
        }
        else
        {
          if ((CellValues) cell.DataType != CellValues.Number)
            return;
          if (!XLHelper.IsNullOrWhiteSpace(cell.CellValue.Text))
            xlCell._cellValue = double.Parse(cell.CellValue.Text, (IFormatProvider) CultureInfo.InvariantCulture).ToString();
          if (s == null)
            xlCell._dataType = XLCellValues.Number;
          else if ((int) (uint) ((CellFormat) s.CellFormats.ElementAt<OpenXmlElement>(index)).NumberFormatId == 46)
            xlCell.DataType = XLCellValues.TimeSpan;
          else
            xlCell._dataType = XLCellValues.Number;
        }
      }
      else
      {
        if (cell.CellValue == null)
          return;
        if (s == null)
        {
          xlCell._dataType = XLCellValues.Number;
        }
        else
        {
          UInt32Value numberFormatId = ((CellFormat) s.CellFormats.ElementAt<OpenXmlElement>(index)).NumberFormatId;
          if (!XLHelper.IsNullOrWhiteSpace(cell.CellValue.Text))
            xlCell._cellValue = double.Parse(cell.CellValue.Text, (IFormatProvider) CultureInfo.InvariantCulture).ToString();
          if (s.NumberingFormats != null && s.NumberingFormats.Any<OpenXmlElement>((Func<OpenXmlElement, bool>) (nf => (int) ((NumberingFormat) nf).NumberFormatId.Value == (int) (uint) numberFormatId)))
            xlCell.Style.NumberFormat.Format = ((NumberingFormat) s.NumberingFormats.First<OpenXmlElement>((Func<OpenXmlElement, bool>) (nf => (int) ((NumberingFormat) nf).NumberFormatId.Value == (int) (uint) numberFormatId))).FormatCode.Value;
          else
            xlCell.Style.NumberFormat.NumberFormatId = int.Parse((string) ((OpenXmlSimpleType) numberFormatId));
          if (!XLHelper.IsNullOrWhiteSpace(xlCell.Style.NumberFormat.Format))
            xlCell._dataType = XLWorkbook.GetDataTypeFromFormat(xlCell.Style.NumberFormat.Format);
          else if ((uint) numberFormatId >= 14U && (uint) numberFormatId <= 22U || (uint) numberFormatId >= 45U && (uint) numberFormatId <= 47U)
            xlCell._dataType = XLCellValues.DateTime;
          else if ((int) (uint) numberFormatId == 49)
            xlCell._dataType = XLCellValues.Text;
          else
            xlCell._dataType = XLCellValues.Number;
        }
      }
    }

    private void LoadNumberFormat(NumberingFormat nfSource, IXLNumberFormat nf)
    {
      if (nfSource == null || nfSource.FormatCode == null)
        return;
      nf.Format = nfSource.FormatCode.Value;
    }

    private void LoadBorder(Border borderSource, IXLBorder border)
    {
      if (borderSource == null)
        return;
      this.LoadBorderValues((BorderPropertiesType) borderSource.DiagonalBorder, new Func<XLBorderStyleValues, IXLStyle>(border.SetDiagonalBorder), new Func<XLColor, IXLStyle>(border.SetDiagonalBorderColor));
      if (borderSource.DiagonalUp != null)
        border.DiagonalUp = borderSource.DiagonalUp.Value;
      if (borderSource.DiagonalDown != null)
        border.DiagonalDown = borderSource.DiagonalDown.Value;
      this.LoadBorderValues((BorderPropertiesType) borderSource.LeftBorder, new Func<XLBorderStyleValues, IXLStyle>(border.SetLeftBorder), new Func<XLColor, IXLStyle>(border.SetLeftBorderColor));
      this.LoadBorderValues((BorderPropertiesType) borderSource.RightBorder, new Func<XLBorderStyleValues, IXLStyle>(border.SetRightBorder), new Func<XLColor, IXLStyle>(border.SetRightBorderColor));
      this.LoadBorderValues((BorderPropertiesType) borderSource.TopBorder, new Func<XLBorderStyleValues, IXLStyle>(border.SetTopBorder), new Func<XLColor, IXLStyle>(border.SetTopBorderColor));
      this.LoadBorderValues((BorderPropertiesType) borderSource.BottomBorder, new Func<XLBorderStyleValues, IXLStyle>(border.SetBottomBorder), new Func<XLColor, IXLStyle>(border.SetBottomBorderColor));
    }

    private void LoadBorderValues(BorderPropertiesType source, Func<XLBorderStyleValues, IXLStyle> setBorder, Func<XLColor, IXLStyle> setColor)
    {
      if (source == null)
        return;
      if (source.Style != null)
      {
        IXLStyle xlStyle1 = setBorder(source.Style.Value.ToClosedXml());
      }
      if (source.Color == null)
        return;
      IXLStyle xlStyle2 = setColor(this.GetColor((DocumentFormat.OpenXml.Spreadsheet.ColorType) source.Color));
    }

    private void LoadFill(DocumentFormat.OpenXml.Spreadsheet.Fill fillSource, IXLFill fill)
    {
      if (fillSource == null || fillSource.PatternFill == null)
        return;
      fill.PatternType = fillSource.PatternFill.PatternType == null ? XLFillPatternValues.Solid : fillSource.PatternFill.PatternType.Value.ToClosedXml();
      if (fillSource.PatternFill.ForegroundColor != null)
        fill.PatternColor = this.GetColor((DocumentFormat.OpenXml.Spreadsheet.ColorType) fillSource.PatternFill.ForegroundColor);
      if (fillSource.PatternFill.BackgroundColor == null)
        return;
      fill.PatternBackgroundColor = this.GetColor((DocumentFormat.OpenXml.Spreadsheet.ColorType) fillSource.PatternFill.BackgroundColor);
    }

    private void LoadFont(OpenXmlElement fontSource, IXLFontBase fontBase)
    {
      if (fontSource == null)
        return;
      fontBase.Bold = XLWorkbook.GetBoolean((BooleanPropertyType) fontSource.Elements<Bold>().FirstOrDefault<Bold>());
      XLColor color = this.GetColor((DocumentFormat.OpenXml.Spreadsheet.ColorType) fontSource.Elements<DocumentFormat.OpenXml.Spreadsheet.Color>().FirstOrDefault<DocumentFormat.OpenXml.Spreadsheet.Color>());
      if (color.HasValue)
        fontBase.FontColor = color;
      DocumentFormat.OpenXml.Spreadsheet.FontFamily fontFamily = fontSource.Elements<DocumentFormat.OpenXml.Spreadsheet.FontFamily>().FirstOrDefault<DocumentFormat.OpenXml.Spreadsheet.FontFamily>();
      if (fontFamily != null && fontFamily.Val != null)
        fontBase.FontFamilyNumbering = (XLFontFamilyNumberingValues) int.Parse(fontFamily.Val.ToString());
      RunFont runFont = fontSource.Elements<RunFont>().FirstOrDefault<RunFont>();
      if (runFont != null && runFont.Val != null)
        fontBase.FontName = (string) runFont.Val;
      FontSize fontSize = fontSource.Elements<FontSize>().FirstOrDefault<FontSize>();
      if (fontSize != null && fontSize.Val != null)
        fontBase.FontSize = (double) fontSize.Val;
      fontBase.Italic = XLWorkbook.GetBoolean((BooleanPropertyType) fontSource.Elements<Italic>().FirstOrDefault<Italic>());
      fontBase.Shadow = XLWorkbook.GetBoolean((BooleanPropertyType) fontSource.Elements<DocumentFormat.OpenXml.Spreadsheet.Shadow>().FirstOrDefault<DocumentFormat.OpenXml.Spreadsheet.Shadow>());
      fontBase.Strikethrough = XLWorkbook.GetBoolean((BooleanPropertyType) fontSource.Elements<Strike>().FirstOrDefault<Strike>());
      DocumentFormat.OpenXml.Spreadsheet.Underline underline = fontSource.Elements<DocumentFormat.OpenXml.Spreadsheet.Underline>().FirstOrDefault<DocumentFormat.OpenXml.Spreadsheet.Underline>();
      if (underline != null)
        fontBase.Underline = underline.Val != null ? underline.Val.Value.ToClosedXml() : XLFontUnderlineValues.Single;
      DocumentFormat.OpenXml.Spreadsheet.VerticalTextAlignment verticalTextAlignment = fontSource.Elements<DocumentFormat.OpenXml.Spreadsheet.VerticalTextAlignment>().FirstOrDefault<DocumentFormat.OpenXml.Spreadsheet.VerticalTextAlignment>();
      if (verticalTextAlignment == null)
        return;
      fontBase.VerticalAlignment = verticalTextAlignment.Val != null ? verticalTextAlignment.Val.Value.ToClosedXml() : XLFontVerticalTextAlignmentValues.Baseline;
    }

    private void LoadRows(Stylesheet s, NumberingFormats numberingFormats, Fills fills, Borders borders, DocumentFormat.OpenXml.Spreadsheet.Fonts fonts, XLWorksheet ws, SharedStringItem[] sharedStrings, Dictionary<uint, string> sharedFormulasR1C1, Dictionary<int, IXLStyle> styleList, Row row)
    {
      int num = row.RowIndex == null ? ++this.lastRow : (int) row.RowIndex.Value;
      XLRow xlRow = ws.Row(num, false);
      if (row.Height != null)
      {
        xlRow.Height = (double) row.Height;
      }
      else
      {
        xlRow.Loading = true;
        xlRow.Height = ws.RowHeight;
        xlRow.Loading = false;
      }
      if (row.Hidden != null && (bool) row.Hidden)
        xlRow.Hide();
      if (row.Collapsed != null && (bool) row.Collapsed)
        xlRow.Collapsed = true;
      if (row.OutlineLevel != null && (int) (byte) row.OutlineLevel > 0)
        xlRow.OutlineLevel = (int) (byte) row.OutlineLevel;
      if (row.CustomFormat != null)
      {
        int styleIndex = row.StyleIndex != null ? int.Parse(row.StyleIndex.InnerText) : -1;
        if (styleIndex > 0)
          this.ApplyStyle((IXLStylized) xlRow, styleIndex, s, fills, borders, fonts, numberingFormats);
        else
          xlRow.Style = XLWorkbook.DefaultStyle;
      }
      this.lastCell = 0;
      foreach (Cell element in row.Elements<Cell>())
        this.LoadCells(sharedStrings, s, numberingFormats, fills, borders, fonts, sharedFormulasR1C1, ws, styleList, element, num);
    }

    private void LoadColumns(Stylesheet s, NumberingFormats numberingFormats, Fills fills, Borders borders, DocumentFormat.OpenXml.Spreadsheet.Fonts fonts, XLWorksheet ws, Columns columns)
    {
      if (columns == null)
        return;
      Column column = columns.Elements<Column>().Where<Column>((Func<Column, bool>) (c => (int) (uint) c.Max == 16384)).FirstOrDefault<Column>();
      if (column != null && column.Width != null)
        ws.ColumnWidth = (double) column.Width - 0.710625;
      int styleIndex1 = column == null || column.Style == null ? -1 : int.Parse(column.Style.InnerText);
      if (styleIndex1 >= 0)
        this.ApplyStyle((IXLStylized) ws, styleIndex1, s, fills, borders, fonts, numberingFormats);
      foreach (Column element in columns.Elements<Column>())
      {
        if ((int) (uint) element.Max != 16384)
        {
          XLColumns source = (XLColumns) ws.Columns((string) ((OpenXmlSimpleType) element.Min), (string) ((OpenXmlSimpleType) element.Max));
          if (element.Width != null)
          {
            double num = (double) element.Width - 0.710625;
            source.Width = num;
          }
          else
            source.Width = ws.ColumnWidth;
          if (element.Hidden != null && (bool) element.Hidden)
            source.Hide();
          if (element.Collapsed != null && (bool) element.Collapsed)
            source.CollapseOnly();
          if (element.OutlineLevel != null)
          {
            ByteValue outlineLevel = element.OutlineLevel;
            source.ForEach<IXLColumn>((Action<IXLColumn>) (c => c.OutlineLevel = (int) (byte) outlineLevel));
          }
          int styleIndex2 = element.Style != null ? int.Parse(element.Style.InnerText) : -1;
          if (styleIndex2 > 0)
            this.ApplyStyle((IXLStylized) source, styleIndex2, s, fills, borders, fonts, numberingFormats);
          else
            source.Style = XLWorkbook.DefaultStyle;
        }
      }
    }

    private static XLCellValues GetDataTypeFromFormat(string format)
    {
      int length = format.Length;
      string lower = format.ToLower();
      for (int index = 0; index < length; ++index)
      {
        switch (lower[index])
        {
          case '"':
            index = lower.IndexOf('"', index + 1);
            break;
          case '#':
          case '0':
          case '?':
            return XLCellValues.Number;
          case 'd':
          case 'h':
          case 'm':
          case 's':
          case 'y':
            return XLCellValues.DateTime;
        }
      }
      return XLCellValues.Text;
    }

    private static void LoadAutoFilter(AutoFilter af, XLWorksheet ws)
    {
      if (af == null)
        return;
      ws.Range(af.Reference.Value).SetAutoFilter();
      XLAutoFilter autoFilter = ws.AutoFilter;
      XLWorkbook.LoadAutoFilterSort(af, ws, (IXLBaseAutoFilter) autoFilter);
      XLWorkbook.LoadAutoFilterColumns(af, autoFilter);
    }

    private static void LoadAutoFilterColumns(AutoFilter af, XLAutoFilter autoFilter)
    {
      foreach (FilterColumn element in af.Elements<FilterColumn>())
      {
        int num = (int) element.ColumnId.Value + 1;
        if (element.CustomFilters != null)
        {
          List<XLFilter> xlFilterList = new List<XLFilter>();
          autoFilter.Column(num).FilterType = XLFilterType.Custom;
          autoFilter.Filters.Add(num, xlFilterList);
          XLConnector xlConnector = element.CustomFilters.And == null || !element.CustomFilters.And.Value ? XLConnector.Or : XLConnector.And;
          bool flag = false;
          foreach (DocumentFormat.OpenXml.Spreadsheet.CustomFilter customFilter in (OpenXmlElement) element.CustomFilters)
          {
            double result;
            if (!double.TryParse(customFilter.Val.Value, out result))
            {
              flag = true;
              break;
            }
          }
          foreach (DocumentFormat.OpenXml.Spreadsheet.CustomFilter customFilter in (OpenXmlElement) element.CustomFilters)
          {
            XLFilter xlFilter = new XLFilter(XLFilterOperator.Equal)
            {
              Value = (object) customFilter.Val.Value,
              Connector = xlConnector
            };
            xlFilter.Value = !flag ? (object) double.Parse(customFilter.Val.Value, (IFormatProvider) CultureInfo.InvariantCulture) : (object) customFilter.Val.Value;
            xlFilter.Operator = customFilter.Operator == null ? XLFilterOperator.Equal : customFilter.Operator.Value.ToClosedXml();
            Func<object, bool> func = (Func<object, bool>) null;
            switch (xlFilter.Operator)
            {
              case XLFilterOperator.Equal:
                func = !flag ? (Func<object, bool>) (o => (o as IComparable).CompareTo(xlFilter.Value) == 0) : (Func<object, bool>) (o => o.ToString().Equals(xlFilter.Value.ToString(), StringComparison.InvariantCultureIgnoreCase));
                break;
              case XLFilterOperator.NotEqual:
                func = !flag ? (Func<object, bool>) (o => (o as IComparable).CompareTo(xlFilter.Value) != 0) : (Func<object, bool>) (o => !o.ToString().Equals(xlFilter.Value.ToString(), StringComparison.InvariantCultureIgnoreCase));
                break;
              case XLFilterOperator.GreaterThan:
                func = (Func<object, bool>) (o => (o as IComparable).CompareTo(xlFilter.Value) > 0);
                break;
              case XLFilterOperator.LessThan:
                func = (Func<object, bool>) (o => (o as IComparable).CompareTo(xlFilter.Value) < 0);
                break;
              case XLFilterOperator.EqualOrGreaterThan:
                func = (Func<object, bool>) (o => (o as IComparable).CompareTo(xlFilter.Value) >= 0);
                break;
              case XLFilterOperator.EqualOrLessThan:
                func = (Func<object, bool>) (o => (o as IComparable).CompareTo(xlFilter.Value) <= 0);
                break;
            }
            xlFilter.Condition = func;
            xlFilterList.Add(xlFilter);
          }
        }
        else if (element.Filters != null)
        {
          List<XLFilter> xlFilterList = new List<XLFilter>();
          autoFilter.Column(num).FilterType = XLFilterType.Regular;
          autoFilter.Filters.Add((int) element.ColumnId.Value + 1, xlFilterList);
          bool flag = false;
          foreach (DocumentFormat.OpenXml.Spreadsheet.Filter filter in element.Filters.OfType<DocumentFormat.OpenXml.Spreadsheet.Filter>())
          {
            double result;
            if (!double.TryParse(filter.Val.Value, out result))
            {
              flag = true;
              break;
            }
          }
          foreach (DocumentFormat.OpenXml.Spreadsheet.Filter filter in element.Filters.OfType<DocumentFormat.OpenXml.Spreadsheet.Filter>())
          {
            XLFilter xlFilter = new XLFilter(XLFilterOperator.Equal)
            {
              Connector = XLConnector.Or,
              Operator = XLFilterOperator.Equal
            };
            Func<object, bool> func;
            if (flag)
            {
              xlFilter.Value = (object) filter.Val.Value;
              func = (Func<object, bool>) (o => o.ToString().Equals(xlFilter.Value.ToString(), StringComparison.InvariantCultureIgnoreCase));
            }
            else
            {
              xlFilter.Value = (object) double.Parse(filter.Val.Value, (IFormatProvider) CultureInfo.InvariantCulture);
              func = (Func<object, bool>) (o => (o as IComparable).CompareTo(xlFilter.Value) == 0);
            }
            xlFilter.Condition = func;
            xlFilterList.Add(xlFilter);
          }
        }
        else if (element.Top10 != null)
        {
          IXLFilterColumn xlFilterColumn = autoFilter.Column(num);
          autoFilter.Filters.Add(num, (List<XLFilter>) null);
          xlFilterColumn.FilterType = XLFilterType.TopBottom;
          xlFilterColumn.TopBottomType = element.Top10.Percent == null || !element.Top10.Percent.Value ? XLTopBottomType.Items : XLTopBottomType.Percent;
          xlFilterColumn.TopBottomPart = element.Top10.Top == null || element.Top10.Top.Value ? XLTopBottomPart.Top : XLTopBottomPart.Bottom;
          xlFilterColumn.TopBottomValue = (int) element.Top10.Val.Value;
        }
        else if (element.DynamicFilter != null)
        {
          autoFilter.Filters.Add(num, (List<XLFilter>) null);
          IXLFilterColumn xlFilterColumn = autoFilter.Column(num);
          xlFilterColumn.FilterType = XLFilterType.Dynamic;
          xlFilterColumn.DynamicType = element.DynamicFilter.Type == null ? XLFilterDynamicType.AboveAverage : element.DynamicFilter.Type.Value.ToClosedXml();
          xlFilterColumn.DynamicValue = element.DynamicFilter.Val.Value;
        }
      }
    }

    private static void LoadAutoFilterSort(AutoFilter af, XLWorksheet ws, IXLBaseAutoFilter autoFilter)
    {
      SortState sortState = af.Elements<SortState>().FirstOrDefault<SortState>();
      if (sortState == null)
        return;
      DocumentFormat.OpenXml.Spreadsheet.SortCondition sortCondition = sortState.Elements<DocumentFormat.OpenXml.Spreadsheet.SortCondition>().FirstOrDefault<DocumentFormat.OpenXml.Spreadsheet.SortCondition>();
      if (sortCondition == null)
        return;
      int num = ws.Range(sortCondition.Reference.Value).FirstCell().Address.ColumnNumber - autoFilter.Range.FirstCell().Address.ColumnNumber + 1;
      autoFilter.SortColumn = num;
      autoFilter.Sorted = true;
      autoFilter.SortOrder = sortCondition.Descending == null || !sortCondition.Descending.Value ? XLSortOrder.Ascending : XLSortOrder.Descending;
    }

    private static void LoadSheetProtection(SheetProtection sp, XLWorksheet ws)
    {
      if (sp == null)
        return;
      if (sp.Sheet != null)
        ws.Protection.Protected = sp.Sheet.Value;
      if (sp.Password != null)
        ws.Protection.PasswordHash = sp.Password.Value;
      if (sp.FormatCells != null)
        ws.Protection.FormatCells = !sp.FormatCells.Value;
      if (sp.FormatColumns != null)
        ws.Protection.FormatColumns = !sp.FormatColumns.Value;
      if (sp.FormatRows != null)
        ws.Protection.FormatRows = !sp.FormatRows.Value;
      if (sp.InsertColumns != null)
        ws.Protection.InsertColumns = !sp.InsertColumns.Value;
      if (sp.InsertHyperlinks != null)
        ws.Protection.InsertHyperlinks = !sp.InsertHyperlinks.Value;
      if (sp.InsertRows != null)
        ws.Protection.InsertRows = !sp.InsertRows.Value;
      if (sp.DeleteColumns != null)
        ws.Protection.DeleteColumns = !sp.DeleteColumns.Value;
      if (sp.DeleteRows != null)
        ws.Protection.DeleteRows = !sp.DeleteRows.Value;
      if (sp.AutoFilter != null)
        ws.Protection.AutoFilter = !sp.AutoFilter.Value;
      if (sp.PivotTables != null)
        ws.Protection.PivotTables = !sp.PivotTables.Value;
      if (sp.Sort != null)
        ws.Protection.Sort = !sp.Sort.Value;
      if (sp.SelectLockedCells != null)
        ws.Protection.SelectLockedCells = sp.SelectLockedCells.Value;
      if (sp.SelectUnlockedCells == null)
        return;
      ws.Protection.SelectUnlockedCells = sp.SelectUnlockedCells.Value;
    }

    private static void LoadDataValidations(DocumentFormat.OpenXml.Spreadsheet.DataValidations dataValidations, XLWorksheet ws)
    {
      if (dataValidations == null)
        return;
      foreach (DocumentFormat.OpenXml.Spreadsheet.DataValidation element in dataValidations.Elements<DocumentFormat.OpenXml.Spreadsheet.DataValidation>())
      {
        string innerText = element.SequenceOfReferences.InnerText;
        if (!XLHelper.IsNullOrWhiteSpace(innerText))
        {
          foreach (XLDataValidation xlDataValidation in ((IEnumerable<string>) innerText.Split(' ')).Select<string, XLDataValidation>((Func<string, XLDataValidation>) (rangeAddress => ws.Range(rangeAddress).DataValidation)))
          {
            if (element.AllowBlank != null)
              xlDataValidation.IgnoreBlanks = (bool) element.AllowBlank;
            if (element.ShowDropDown != null)
              xlDataValidation.InCellDropdown = !element.ShowDropDown.Value;
            if (element.ShowErrorMessage != null)
              xlDataValidation.ShowErrorMessage = (bool) element.ShowErrorMessage;
            if (element.ShowInputMessage != null)
              xlDataValidation.ShowInputMessage = (bool) element.ShowInputMessage;
            if (element.PromptTitle != null)
              xlDataValidation.InputTitle = (string) element.PromptTitle;
            if (element.Prompt != null)
              xlDataValidation.InputMessage = (string) element.Prompt;
            if (element.ErrorTitle != null)
              xlDataValidation.ErrorTitle = (string) element.ErrorTitle;
            if (element.Error != null)
              xlDataValidation.ErrorMessage = (string) element.Error;
            if (element.ErrorStyle != null)
              xlDataValidation.ErrorStyle = element.ErrorStyle.Value.ToClosedXml();
            if (element.Type != null)
              xlDataValidation.AllowedValues = element.Type.Value.ToClosedXml();
            if (element.Operator != null)
              xlDataValidation.Operator = element.Operator.Value.ToClosedXml();
            if (element.Formula1 != null)
              xlDataValidation.MinValue = element.Formula1.Text;
            if (element.Formula2 != null)
              xlDataValidation.MaxValue = element.Formula2.Text;
          }
        }
      }
    }

    private void LoadConditionalFormatting(DocumentFormat.OpenXml.Spreadsheet.ConditionalFormatting conditionalFormatting, XLWorksheet ws, Dictionary<int, DifferentialFormat> differentialFormats)
    {
      if (conditionalFormatting == null)
        return;
      foreach (StringValue stringValue in (IEnumerable<StringValue>) conditionalFormatting.SequenceOfReferences.Items)
      {
        foreach (DocumentFormat.OpenXml.Spreadsheet.ConditionalFormattingRule element1 in conditionalFormatting.Elements<DocumentFormat.OpenXml.Spreadsheet.ConditionalFormattingRule>())
        {
          XLConditionalFormat conditionalFormat = new XLConditionalFormat(ws.Range(stringValue.Value), false);
          if (element1.FormatId != null)
          {
            this.LoadFont((OpenXmlElement) differentialFormats[(int) element1.FormatId.Value].Font, (IXLFontBase) conditionalFormat.Style.Font);
            this.LoadFill(differentialFormats[(int) element1.FormatId.Value].Fill, conditionalFormat.Style.Fill);
            this.LoadBorder(differentialFormats[(int) element1.FormatId.Value].Border, conditionalFormat.Style.Border);
            this.LoadNumberFormat(differentialFormats[(int) element1.FormatId.Value].NumberingFormat, conditionalFormat.Style.NumberFormat);
          }
          if (element1.Operator != null)
            conditionalFormat.Operator = element1.Operator.Value.ToClosedXml();
          if (element1.Type != null)
            conditionalFormat.ConditionalFormatType = element1.Type.Value.ToClosedXml();
          if (element1.Text != null)
            conditionalFormat.Values.Add(XLWorkbook.GetFormula(element1.Text.Value));
          if (element1.Percent != null)
            conditionalFormat.Percent = element1.Percent.Value;
          if (element1.Bottom != null)
            conditionalFormat.Bottom = element1.Bottom.Value;
          if (element1.Rank != null)
            conditionalFormat.Values.Add(XLWorkbook.GetFormula(element1.Rank.Value.ToString()));
          if (element1.Elements<DocumentFormat.OpenXml.Spreadsheet.ColorScale>().Any<DocumentFormat.OpenXml.Spreadsheet.ColorScale>())
          {
            DocumentFormat.OpenXml.Spreadsheet.ColorScale colorScale = element1.Elements<DocumentFormat.OpenXml.Spreadsheet.ColorScale>().First<DocumentFormat.OpenXml.Spreadsheet.ColorScale>();
            this.ExtractConditionalFormatValueObjects(conditionalFormat, (OpenXmlElement) colorScale);
          }
          else if (element1.Elements<DocumentFormat.OpenXml.Spreadsheet.DataBar>().Any<DocumentFormat.OpenXml.Spreadsheet.DataBar>())
          {
            DocumentFormat.OpenXml.Spreadsheet.DataBar dataBar = element1.Elements<DocumentFormat.OpenXml.Spreadsheet.DataBar>().First<DocumentFormat.OpenXml.Spreadsheet.DataBar>();
            if (dataBar.ShowValue != null)
              conditionalFormat.ShowBarOnly = !dataBar.ShowValue.Value;
            this.ExtractConditionalFormatValueObjects(conditionalFormat, (OpenXmlElement) dataBar);
          }
          else if (element1.Elements<DocumentFormat.OpenXml.Spreadsheet.IconSet>().Any<DocumentFormat.OpenXml.Spreadsheet.IconSet>())
          {
            DocumentFormat.OpenXml.Spreadsheet.IconSet iconSet = element1.Elements<DocumentFormat.OpenXml.Spreadsheet.IconSet>().First<DocumentFormat.OpenXml.Spreadsheet.IconSet>();
            if (iconSet.ShowValue != null)
              conditionalFormat.ShowIconOnly = !iconSet.ShowValue.Value;
            if (iconSet.Reverse != null)
              conditionalFormat.ReverseIconOrder = iconSet.Reverse.Value;
            conditionalFormat.IconSetStyle = iconSet.IconSetValue == null ? XLIconSetStyle.ThreeTrafficLights1 : iconSet.IconSetValue.Value.ToClosedXml();
            this.ExtractConditionalFormatValueObjects(conditionalFormat, (OpenXmlElement) iconSet);
          }
          else
          {
            foreach (DocumentFormat.OpenXml.Spreadsheet.Formula element2 in element1.Elements<DocumentFormat.OpenXml.Spreadsheet.Formula>())
            {
              if (element2.Text != null && (conditionalFormat.ConditionalFormatType == XLConditionalFormatType.CellIs || conditionalFormat.ConditionalFormatType == XLConditionalFormatType.Expression))
                conditionalFormat.Values.Add(XLWorkbook.GetFormula(element2.Text));
            }
          }
          ws.ConditionalFormats.Add((IXLConditionalFormat) conditionalFormat);
        }
      }
    }

    private static XLFormula GetFormula(string value)
    {
      return new XLFormula()
      {
        _value = value,
        IsFormula = (int) value[0] != 34 || !value.EndsWith("\"")
      };
    }

    private void ExtractConditionalFormatValueObjects(XLConditionalFormat conditionalFormat, OpenXmlElement element)
    {
      foreach (ConditionalFormatValueObject element1 in element.Elements<ConditionalFormatValueObject>())
      {
        if (element1.Type != null)
          conditionalFormat.ContentTypes.Add(element1.Type.Value.ToClosedXml());
        if (element1.Val != null)
          conditionalFormat.Values.Add(new XLFormula()
          {
            Value = element1.Val.Value
          });
        if (element1.GreaterThanOrEqual != null)
          conditionalFormat.IconSetOperators.Add(element1.GreaterThanOrEqual.Value ? XLCFIconSetOperator.EqualOrGreaterThan : XLCFIconSetOperator.GreaterThan);
        else
          conditionalFormat.IconSetOperators.Add(XLCFIconSetOperator.EqualOrGreaterThan);
      }
      foreach (DocumentFormat.OpenXml.Spreadsheet.Color element1 in element.Elements<DocumentFormat.OpenXml.Spreadsheet.Color>())
        conditionalFormat.Colors.Add(this.GetColor((DocumentFormat.OpenXml.Spreadsheet.ColorType) element1));
    }

    private static void LoadHyperlinks(Hyperlinks hyperlinks, WorksheetPart worksheetPart, XLWorksheet ws)
    {
      Dictionary<string, Uri> dictionary = new Dictionary<string, Uri>();
      if (worksheetPart.HyperlinkRelationships != null)
        dictionary = worksheetPart.HyperlinkRelationships.ToDictionary<HyperlinkRelationship, string, Uri>((Func<HyperlinkRelationship, string>) (hr => hr.Id), (Func<HyperlinkRelationship, Uri>) (hr => hr.Uri));
      if (hyperlinks == null)
        return;
      foreach (DocumentFormat.OpenXml.Spreadsheet.Hyperlink element in hyperlinks.Elements<DocumentFormat.OpenXml.Spreadsheet.Hyperlink>())
      {
        if (!element.Reference.Value.Equals("#REF"))
        {
          string tooltip = element.Tooltip != null ? element.Tooltip.Value : string.Empty;
          foreach (XLCell cell in (IEnumerable<IXLCell>) ws.Range(element.Reference.Value).Cells())
          {
            cell.SettingHyperlink = true;
            cell.Hyperlink = element.Id == null ? (element.Location == null ? new XLHyperlink(element.Reference.Value, tooltip) : new XLHyperlink(element.Location.Value, tooltip)) : new XLHyperlink(dictionary[(string) element.Id], tooltip);
            cell.SettingHyperlink = false;
          }
        }
      }
    }

    private static void LoadColumnBreaks(ColumnBreaks columnBreaks, XLWorksheet ws)
    {
      if (columnBreaks == null)
        return;
      foreach (DocumentFormat.OpenXml.Spreadsheet.Break @break in columnBreaks.Elements<DocumentFormat.OpenXml.Spreadsheet.Break>().Where<DocumentFormat.OpenXml.Spreadsheet.Break>((Func<DocumentFormat.OpenXml.Spreadsheet.Break, bool>) (columnBreak => columnBreak.Id != null)))
        ws.PageSetup.ColumnBreaks.Add(int.Parse(@break.Id.InnerText));
    }

    private static void LoadRowBreaks(RowBreaks rowBreaks, XLWorksheet ws)
    {
      if (rowBreaks == null)
        return;
      foreach (DocumentFormat.OpenXml.Spreadsheet.Break element in rowBreaks.Elements<DocumentFormat.OpenXml.Spreadsheet.Break>())
        ws.PageSetup.RowBreaks.Add(int.Parse(element.Id.InnerText));
    }

    private void LoadSheetProperties(SheetProperties sheetProperty, XLWorksheet ws)
    {
      if (sheetProperty == null)
        return;
      if (sheetProperty.TabColor != null)
        ws.TabColor = this.GetColor((DocumentFormat.OpenXml.Spreadsheet.ColorType) sheetProperty.TabColor);
      if (sheetProperty.OutlineProperties == null)
        return;
      if (sheetProperty.OutlineProperties.SummaryBelow != null)
        ws.Outline.SummaryVLocation = (bool) sheetProperty.OutlineProperties.SummaryBelow ? XLOutlineSummaryVLocation.Bottom : XLOutlineSummaryVLocation.Top;
      if (sheetProperty.OutlineProperties.SummaryRight == null)
        return;
      ws.Outline.SummaryHLocation = (bool) sheetProperty.OutlineProperties.SummaryRight ? XLOutlineSummaryHLocation.Right : XLOutlineSummaryHLocation.Left;
    }

    private static void LoadHeaderFooter(HeaderFooter headerFooter, XLWorksheet ws)
    {
      if (headerFooter == null)
        return;
      if (headerFooter.AlignWithMargins != null)
        ws.PageSetup.AlignHFWithMargins = (bool) headerFooter.AlignWithMargins;
      if (headerFooter.ScaleWithDoc != null)
        ws.PageSetup.ScaleHFWithDocument = (bool) headerFooter.ScaleWithDoc;
      if (headerFooter.DifferentFirst != null)
        ws.PageSetup.DifferentFirstPageOnHF = (bool) headerFooter.DifferentFirst;
      if (headerFooter.DifferentOddEven != null)
        ws.PageSetup.DifferentOddEvenPagesOnHF = (bool) headerFooter.DifferentOddEven;
      XLHeaderFooter footer = (XLHeaderFooter) ws.PageSetup.Footer;
      EvenFooter evenFooter = headerFooter.EvenFooter;
      if (evenFooter != null)
        footer.SetInnerText(XLHFOccurrence.EvenPages, evenFooter.Text);
      OddFooter oddFooter = headerFooter.OddFooter;
      if (oddFooter != null)
        footer.SetInnerText(XLHFOccurrence.OddPages, oddFooter.Text);
      FirstFooter firstFooter = headerFooter.FirstFooter;
      if (firstFooter != null)
        footer.SetInnerText(XLHFOccurrence.FirstPage, firstFooter.Text);
      XLHeaderFooter header = (XLHeaderFooter) ws.PageSetup.Header;
      EvenHeader evenHeader = headerFooter.EvenHeader;
      if (evenHeader != null)
        header.SetInnerText(XLHFOccurrence.EvenPages, evenHeader.Text);
      OddHeader oddHeader = headerFooter.OddHeader;
      if (oddHeader != null)
        header.SetInnerText(XLHFOccurrence.OddPages, oddHeader.Text);
      FirstHeader firstHeader = headerFooter.FirstHeader;
      if (firstHeader != null)
        header.SetInnerText(XLHFOccurrence.FirstPage, firstHeader.Text);
      ((XLHeaderFooter) ws.PageSetup.Header).SetAsInitial();
      ((XLHeaderFooter) ws.PageSetup.Footer).SetAsInitial();
    }

    private static void LoadPageSetup(PageSetup pageSetup, XLWorksheet ws)
    {
      if (pageSetup == null)
        return;
      if (pageSetup.PaperSize != null)
        ws.PageSetup.PaperSize = (XLPaperSize) int.Parse(pageSetup.PaperSize.InnerText);
      if (pageSetup.Scale != null)
      {
        ws.PageSetup.Scale = int.Parse(pageSetup.Scale.InnerText);
      }
      else
      {
        if (pageSetup.FitToWidth != null)
          ws.PageSetup.PagesWide = int.Parse(pageSetup.FitToWidth.InnerText);
        if (pageSetup.FitToHeight != null)
          ws.PageSetup.PagesTall = int.Parse(pageSetup.FitToHeight.InnerText);
      }
      if (pageSetup.PageOrder != null)
        ws.PageSetup.PageOrder = pageSetup.PageOrder.Value.ToClosedXml();
      if (pageSetup.Orientation != null)
        ws.PageSetup.PageOrientation = pageSetup.Orientation.Value.ToClosedXml();
      if (pageSetup.BlackAndWhite != null)
        ws.PageSetup.BlackAndWhite = (bool) pageSetup.BlackAndWhite;
      if (pageSetup.Draft != null)
        ws.PageSetup.DraftQuality = (bool) pageSetup.Draft;
      if (pageSetup.CellComments != null)
        ws.PageSetup.ShowComments = pageSetup.CellComments.Value.ToClosedXml();
      if (pageSetup.Errors != null)
        ws.PageSetup.PrintErrorValue = pageSetup.Errors.Value.ToClosedXml();
      if (pageSetup.HorizontalDpi != null)
        ws.PageSetup.HorizontalDpi = (int) pageSetup.HorizontalDpi.Value;
      if (pageSetup.VerticalDpi != null)
        ws.PageSetup.VerticalDpi = (int) pageSetup.VerticalDpi.Value;
      if (pageSetup.FirstPageNumber == null)
        return;
      ws.PageSetup.FirstPageNumber = (long) uint.Parse(pageSetup.FirstPageNumber.InnerText);
    }

    private static void LoadPageMargins(PageMargins pageMargins, XLWorksheet ws)
    {
      if (pageMargins == null)
        return;
      if (pageMargins.Bottom != null)
        ws.PageSetup.Margins.Bottom = (double) pageMargins.Bottom;
      if (pageMargins.Footer != null)
        ws.PageSetup.Margins.Footer = (double) pageMargins.Footer;
      if (pageMargins.Header != null)
        ws.PageSetup.Margins.Header = (double) pageMargins.Header;
      if (pageMargins.Left != null)
        ws.PageSetup.Margins.Left = (double) pageMargins.Left;
      if (pageMargins.Right != null)
        ws.PageSetup.Margins.Right = (double) pageMargins.Right;
      if (pageMargins.Top == null)
        return;
      ws.PageSetup.Margins.Top = (double) pageMargins.Top;
    }

    private static void LoadPrintOptions(PrintOptions printOptions, XLWorksheet ws)
    {
      if (printOptions == null)
        return;
      if (printOptions.GridLines != null)
        ws.PageSetup.ShowGridlines = (bool) printOptions.GridLines;
      if (printOptions.HorizontalCentered != null)
        ws.PageSetup.CenterHorizontally = (bool) printOptions.HorizontalCentered;
      if (printOptions.VerticalCentered != null)
        ws.PageSetup.CenterVertically = (bool) printOptions.VerticalCentered;
      if (printOptions.Headings == null)
        return;
      ws.PageSetup.ShowRowAndColumnHeadings = (bool) printOptions.Headings;
    }

    private static void LoadSheetViews(SheetViews sheetViews, XLWorksheet ws)
    {
      if (sheetViews == null)
        return;
      SheetView sheetView = sheetViews.Elements<SheetView>().FirstOrDefault<SheetView>();
      if (sheetView == null)
        return;
      if (sheetView.ShowFormulas != null)
        ws.ShowFormulas = sheetView.ShowFormulas.Value;
      if (sheetView.ShowGridLines != null)
        ws.ShowGridLines = sheetView.ShowGridLines.Value;
      if (sheetView.ShowOutlineSymbols != null)
        ws.ShowOutlineSymbols = sheetView.ShowOutlineSymbols.Value;
      if (sheetView.ShowRowColHeaders != null)
        ws.ShowRowColHeaders = sheetView.ShowRowColHeaders.Value;
      if (sheetView.ShowRuler != null)
        ws.ShowRuler = sheetView.ShowRuler.Value;
      if (sheetView.ShowWhiteSpace != null)
        ws.ShowWhiteSpace = sheetView.ShowWhiteSpace.Value;
      if (sheetView.ShowZeros != null)
        ws.ShowZeros = sheetView.ShowZeros.Value;
      if (sheetView.TabSelected != null)
        ws.TabSelected = sheetView.TabSelected.Value;
      Selection selection = sheetView.Elements<Selection>().FirstOrDefault<Selection>();
      if (selection != null)
      {
        if (selection.SequenceOfReferences != null)
          ws.Ranges(selection.SequenceOfReferences.InnerText.Replace(" ", ",")).Select();
        if (selection.ActiveCell != null)
          ws.Cell((string) selection.ActiveCell).SetActive(true);
      }
      Pane pane = sheetView.Elements<Pane>().FirstOrDefault<Pane>();
      if (pane == null || pane.State == null || (PaneStateValues) pane.State != PaneStateValues.FrozenSplit && (PaneStateValues) pane.State != PaneStateValues.Frozen)
        return;
      if (pane.HorizontalSplit != null)
        ws.SheetView.SplitColumn = (int) pane.HorizontalSplit.Value;
      if (pane.VerticalSplit == null)
        return;
      ws.SheetView.SplitRow = (int) pane.VerticalSplit.Value;
    }

    private void SetProperties(SpreadsheetDocument dSpreadsheet)
    {
      PackageProperties packageProperties = dSpreadsheet.PackageProperties;
      this.Properties.Author = packageProperties.Creator;
      this.Properties.Category = packageProperties.Category;
      this.Properties.Comments = packageProperties.Description;
      if (packageProperties.Created.HasValue)
        this.Properties.Created = packageProperties.Created.Value;
      this.Properties.Keywords = packageProperties.Keywords;
      this.Properties.LastModifiedBy = packageProperties.LastModifiedBy;
      this.Properties.Status = packageProperties.ContentStatus;
      this.Properties.Subject = packageProperties.Subject;
      this.Properties.Title = packageProperties.Title;
    }

    private XLColor GetColor(DocumentFormat.OpenXml.Spreadsheet.ColorType color)
    {
      XLColor xlColor1 = (XLColor) null;
      if (color != null)
      {
        if (color.Rgb != null)
        {
          string index = "#" + color.Rgb.Value;
          System.Drawing.Color color1;
          if (!this._colorList.ContainsKey(index))
          {
            color1 = ColorTranslator.FromHtml(index);
            this._colorList.Add(index, color1);
          }
          else
            color1 = this._colorList[index];
          xlColor1 = XLColor.FromColor(color1);
        }
        else if (color.Indexed != null && (uint) color.Indexed < 64U)
          xlColor1 = XLColor.FromIndex((int) color.Indexed.Value);
        else if (color.Theme != null)
          xlColor1 = color.Tint != null ? XLColor.FromTheme((XLThemeColor) color.Theme.Value, color.Tint.Value) : XLColor.FromTheme((XLThemeColor) color.Theme.Value);
      }
      XLColor xlColor2 = xlColor1;
      if ((object) xlColor2 != null)
        return xlColor2;
      return XLColor.NoColor;
    }

    private void ApplyStyle(IXLStylized xlStylized, int styleIndex, Stylesheet s, Fills fills, Borders borders, DocumentFormat.OpenXml.Spreadsheet.Fonts fonts, NumberingFormats numberingFormats)
    {
      if (s == null)
        return;
      CellFormat cellFormat = (CellFormat) s.CellFormats.ElementAt<OpenXmlElement>(styleIndex);
      if (cellFormat.ApplyProtection != null)
      {
        Protection protection = cellFormat.Protection;
        if (protection == null)
        {
          xlStylized.InnerStyle.Protection = (IXLProtection) new XLProtection((IXLStylized) null, XLWorkbook.DefaultStyle.Protection);
        }
        else
        {
          xlStylized.InnerStyle.Protection.Hidden = protection.Hidden != null && protection.Hidden.HasValue && protection.Hidden.Value;
          xlStylized.InnerStyle.Protection.Locked = protection.Locked == null || protection.Locked.HasValue && protection.Locked.Value;
        }
      }
      if (XLWorkbook.UInt32HasValue(cellFormat.FillId))
      {
        DocumentFormat.OpenXml.Spreadsheet.Fill fill = (DocumentFormat.OpenXml.Spreadsheet.Fill) fills.ElementAt<OpenXmlElement>((int) cellFormat.FillId.Value);
        if (fill.PatternFill != null)
        {
          if (fill.PatternFill.PatternType != null)
            xlStylized.InnerStyle.Fill.PatternType = fill.PatternFill.PatternType.Value.ToClosedXml();
          XLColor color1 = this.GetColor((DocumentFormat.OpenXml.Spreadsheet.ColorType) fill.PatternFill.ForegroundColor);
          if (color1.HasValue)
            xlStylized.InnerStyle.Fill.PatternColor = color1;
          XLColor color2 = this.GetColor((DocumentFormat.OpenXml.Spreadsheet.ColorType) fill.PatternFill.BackgroundColor);
          if (color2.HasValue)
            xlStylized.InnerStyle.Fill.PatternBackgroundColor = color2;
        }
      }
      Alignment alignment = cellFormat.Alignment;
      if (alignment != null)
      {
        if (alignment.Horizontal != null)
          xlStylized.InnerStyle.Alignment.Horizontal = alignment.Horizontal.Value.ToClosedXml();
        if (alignment.Indent != null && (int) (uint) alignment.Indent != 0)
          xlStylized.InnerStyle.Alignment.Indent = int.Parse(alignment.Indent.ToString());
        if (alignment.JustifyLastLine != null)
          xlStylized.InnerStyle.Alignment.JustifyLastLine = (bool) alignment.JustifyLastLine;
        if (alignment.ReadingOrder != null)
          xlStylized.InnerStyle.Alignment.ReadingOrder = (XLAlignmentReadingOrderValues) int.Parse(alignment.ReadingOrder.ToString());
        if (alignment.RelativeIndent != null)
          xlStylized.InnerStyle.Alignment.RelativeIndent = (int) alignment.RelativeIndent;
        if (alignment.ShrinkToFit != null)
          xlStylized.InnerStyle.Alignment.ShrinkToFit = (bool) alignment.ShrinkToFit;
        if (alignment.TextRotation != null)
          xlStylized.InnerStyle.Alignment.TextRotation = (int) alignment.TextRotation.Value;
        if (alignment.Vertical != null)
          xlStylized.InnerStyle.Alignment.Vertical = alignment.Vertical.Value.ToClosedXml();
        if (alignment.WrapText != null)
          xlStylized.InnerStyle.Alignment.WrapText = (bool) alignment.WrapText;
      }
      if (XLWorkbook.UInt32HasValue(cellFormat.BorderId))
      {
        uint num = cellFormat.BorderId.Value;
        Border border = (Border) borders.ElementAt<OpenXmlElement>((int) num);
        if (border != null)
        {
          DocumentFormat.OpenXml.Spreadsheet.BottomBorder bottomBorder = border.BottomBorder;
          if (bottomBorder != null)
          {
            if (bottomBorder.Style != null)
              xlStylized.InnerStyle.Border.BottomBorder = bottomBorder.Style.Value.ToClosedXml();
            XLColor color = this.GetColor((DocumentFormat.OpenXml.Spreadsheet.ColorType) bottomBorder.Color);
            if (color.HasValue)
              xlStylized.InnerStyle.Border.BottomBorderColor = color;
          }
          DocumentFormat.OpenXml.Spreadsheet.TopBorder topBorder = border.TopBorder;
          if (topBorder != null)
          {
            if (topBorder.Style != null)
              xlStylized.InnerStyle.Border.TopBorder = topBorder.Style.Value.ToClosedXml();
            XLColor color = this.GetColor((DocumentFormat.OpenXml.Spreadsheet.ColorType) topBorder.Color);
            if (color.HasValue)
              xlStylized.InnerStyle.Border.TopBorderColor = color;
          }
          DocumentFormat.OpenXml.Spreadsheet.LeftBorder leftBorder = border.LeftBorder;
          if (leftBorder != null)
          {
            if (leftBorder.Style != null)
              xlStylized.InnerStyle.Border.LeftBorder = leftBorder.Style.Value.ToClosedXml();
            XLColor color = this.GetColor((DocumentFormat.OpenXml.Spreadsheet.ColorType) leftBorder.Color);
            if (color.HasValue)
              xlStylized.InnerStyle.Border.LeftBorderColor = color;
          }
          DocumentFormat.OpenXml.Spreadsheet.RightBorder rightBorder = border.RightBorder;
          if (rightBorder != null)
          {
            if (rightBorder.Style != null)
              xlStylized.InnerStyle.Border.RightBorder = rightBorder.Style.Value.ToClosedXml();
            XLColor color = this.GetColor((DocumentFormat.OpenXml.Spreadsheet.ColorType) rightBorder.Color);
            if (color.HasValue)
              xlStylized.InnerStyle.Border.RightBorderColor = color;
          }
          DiagonalBorder diagonalBorder = border.DiagonalBorder;
          if (diagonalBorder != null)
          {
            if (diagonalBorder.Style != null)
              xlStylized.InnerStyle.Border.DiagonalBorder = diagonalBorder.Style.Value.ToClosedXml();
            XLColor color = this.GetColor((DocumentFormat.OpenXml.Spreadsheet.ColorType) diagonalBorder.Color);
            if (color.HasValue)
              xlStylized.InnerStyle.Border.DiagonalBorderColor = color;
            if (border.DiagonalDown != null)
              xlStylized.InnerStyle.Border.DiagonalDown = (bool) border.DiagonalDown;
            if (border.DiagonalUp != null)
              xlStylized.InnerStyle.Border.DiagonalUp = (bool) border.DiagonalUp;
          }
        }
      }
      if (XLWorkbook.UInt32HasValue(cellFormat.FontId))
      {
        UInt32Value fontId = cellFormat.FontId;
        DocumentFormat.OpenXml.Spreadsheet.Font font = (DocumentFormat.OpenXml.Spreadsheet.Font) fonts.ElementAt<OpenXmlElement>((int) fontId.Value);
        if (font != null)
        {
          xlStylized.InnerStyle.Font.Bold = XLWorkbook.GetBoolean((BooleanPropertyType) font.Bold);
          XLColor color = this.GetColor((DocumentFormat.OpenXml.Spreadsheet.ColorType) font.Color);
          if (color.HasValue)
            xlStylized.InnerStyle.Font.FontColor = color;
          if (font.FontFamilyNumbering != null && font.FontFamilyNumbering.Val != null)
            xlStylized.InnerStyle.Font.FontFamilyNumbering = (XLFontFamilyNumberingValues) int.Parse(font.FontFamilyNumbering.Val.ToString());
          if (font.FontName != null && font.FontName.Val != null)
            xlStylized.InnerStyle.Font.FontName = (string) font.FontName.Val;
          if (font.FontSize != null && font.FontSize.Val != null)
            xlStylized.InnerStyle.Font.FontSize = (double) font.FontSize.Val;
          xlStylized.InnerStyle.Font.Italic = XLWorkbook.GetBoolean((BooleanPropertyType) font.Italic);
          xlStylized.InnerStyle.Font.Shadow = XLWorkbook.GetBoolean((BooleanPropertyType) font.Shadow);
          xlStylized.InnerStyle.Font.Strikethrough = XLWorkbook.GetBoolean((BooleanPropertyType) font.Strike);
          if (font.Underline != null)
            xlStylized.InnerStyle.Font.Underline = font.Underline.Val != null ? font.Underline.Val.Value.ToClosedXml() : XLFontUnderlineValues.Single;
          if (font.VerticalTextAlignment != null)
            xlStylized.InnerStyle.Font.VerticalAlignment = font.VerticalTextAlignment.Val != null ? font.VerticalTextAlignment.Val.Value.ToClosedXml() : XLFontVerticalTextAlignmentValues.Baseline;
        }
      }
      if (!XLWorkbook.UInt32HasValue(cellFormat.NumberFormatId))
        return;
      UInt32Value numberFormatId = cellFormat.NumberFormatId;
      string empty = string.Empty;
      if (numberingFormats != null)
      {
        NumberingFormat numberingFormat = numberingFormats.FirstOrDefault<OpenXmlElement>((Func<OpenXmlElement, bool>) (nf =>
        {
          if (((NumberingFormat) nf).NumberFormatId != null)
            return (int) ((NumberingFormat) nf).NumberFormatId.Value == (int) (uint) numberFormatId;
          return false;
        })) as NumberingFormat;
        if (numberingFormat != null && numberingFormat.FormatCode != null)
          empty = numberingFormat.FormatCode.Value;
      }
      if (empty.Length > 0)
        xlStylized.InnerStyle.NumberFormat.Format = empty;
      else
        xlStylized.InnerStyle.NumberFormat.NumberFormatId = (int) numberFormatId.Value;
    }

    private static bool UInt32HasValue(UInt32Value value)
    {
      if (value != null)
        return value.HasValue;
      return false;
    }

    private static bool GetBoolean(BooleanPropertyType property)
    {
      if (property == null)
        return false;
      if (property.Val != null)
        return (bool) property.Val;
      return true;
    }

    private static EnumValue<CellValues> GetCellValue(XLCell xlCell)
    {
      switch (xlCell.DataType)
      {
        case XLCellValues.Text:
          if (!xlCell.ShareString)
            return XLWorkbook.CvInlineString;
          return XLWorkbook.CvSharedString;
        case XLCellValues.Number:
          return XLWorkbook.CvNumber;
        case XLCellValues.Boolean:
          return XLWorkbook.CvBoolean;
        case XLCellValues.DateTime:
          return XLWorkbook.CvDate;
        case XLCellValues.TimeSpan:
          return XLWorkbook.CvNumber;
        default:
          throw new NotImplementedException();
      }
    }

    private void CreatePackage(string filePath, SpreadsheetDocumentType spreadsheetDocumentType)
    {
      ClosedXML.PathHelper.CreateDirectory(System.IO.Path.GetDirectoryName(filePath));
      SpreadsheetDocument document = File.Exists(filePath) ? SpreadsheetDocument.Open(filePath, true) : SpreadsheetDocument.Create(filePath, spreadsheetDocumentType);
      using (document)
        this.CreateParts(document);
    }

    private void CreatePackage(Stream stream, bool newStream, SpreadsheetDocumentType spreadsheetDocumentType)
    {
      SpreadsheetDocument document = newStream ? SpreadsheetDocument.Create(stream, spreadsheetDocumentType) : SpreadsheetDocument.Open(stream, true);
      using (document)
        this.CreateParts(document);
    }

    private void CreateParts(SpreadsheetDocument document)
    {
      XLWorkbook.SaveContext context = new XLWorkbook.SaveContext();
      WorkbookPart workbookPart = document.WorkbookPart ?? document.AddWorkbookPart();
      XLWorksheets worksheets = this.WorksheetsInternal;
      workbookPart.Parts.Where<IdPartPair>((Func<IdPartPair, bool>) (s => worksheets.Deleted.Contains(s.RelationshipId))).ToList<IdPartPair>().ForEach((Action<IdPartPair>) (s => workbookPart.DeletePart(s.OpenXmlPart)));
      context.RelIdGenerator.AddValues(workbookPart.Parts.Select<IdPartPair, string>((Func<IdPartPair, string>) (p => p.RelationshipId)).ToList<string>(), XLWorkbook.RelType.Workbook);
      this.GenerateExtendedFilePropertiesPartContent(document.ExtendedFilePropertiesPart ?? document.AddNewPart<ExtendedFilePropertiesPart>(context.RelIdGenerator.GetNext(XLWorkbook.RelType.Workbook)));
      this.GenerateWorkbookPartContent(workbookPart, context);
      this.GenerateSharedStringTablePartContent(workbookPart.SharedStringTablePart ?? workbookPart.AddNewPart<SharedStringTablePart>(context.RelIdGenerator.GetNext(XLWorkbook.RelType.Workbook)), context);
      this.GenerateWorkbookStylesPartContent(workbookPart.WorkbookStylesPart ?? workbookPart.AddNewPart<WorkbookStylesPart>(context.RelIdGenerator.GetNext(XLWorkbook.RelType.Workbook)), context);
      foreach (XLWorksheet xlWorksheet in (IEnumerable<XLWorksheet>) this.WorksheetsInternal.Cast<XLWorksheet>().OrderBy<XLWorksheet, int>((Func<XLWorksheet, int>) (w => w.Position)))
      {
        string wsRelId = xlWorksheet.RelId;
        WorksheetPart worksheetPart;
        if (workbookPart.Parts.Any<IdPartPair>((Func<IdPartPair, bool>) (p => p.RelationshipId == wsRelId)))
        {
          worksheetPart = (WorksheetPart) workbookPart.GetPartById(wsRelId);
          worksheetPart.TableDefinitionParts.ToList<TableDefinitionPart>().ForEach((Action<TableDefinitionPart>) (tdp => worksheetPart.DeletePart((OpenXmlPart) tdp)));
        }
        else
          worksheetPart = workbookPart.AddNewPart<WorksheetPart>(wsRelId);
        context.RelIdGenerator.AddValues(worksheetPart.HyperlinkRelationships.Select<HyperlinkRelationship, string>((Func<HyperlinkRelationship, string>) (hr => hr.Id)).ToList<string>(), XLWorkbook.RelType.Workbook);
        context.RelIdGenerator.AddValues(worksheetPart.Parts.Select<IdPartPair, string>((Func<IdPartPair, string>) (p => p.RelationshipId)).ToList<string>(), XLWorkbook.RelType.Workbook);
        if (worksheetPart.DrawingsPart != null)
          context.RelIdGenerator.AddValues(worksheetPart.DrawingsPart.Parts.Select<IdPartPair, string>((Func<IdPartPair, string>) (p => p.RelationshipId)).ToList<string>(), XLWorkbook.RelType.Workbook);
        this.DeleteComments(worksheetPart, xlWorksheet, context);
        if (xlWorksheet.Internals.CellsCollection.GetCells((Func<IXLCell, bool>) (c => c.HasComment)).Any<XLCell>())
        {
          XLWorkbook.GenerateWorksheetCommentsPartContent(worksheetPart.AddNewPart<WorksheetCommentsPart>(context.RelIdGenerator.GetNext(XLWorkbook.RelType.Workbook)), xlWorksheet);
          VmlDrawingPart vmlDrawingPart = worksheetPart.VmlDrawingParts.FirstOrDefault<VmlDrawingPart>();
          if (vmlDrawingPart == null)
          {
            if (XLHelper.IsNullOrWhiteSpace(xlWorksheet.LegacyDrawingId))
            {
              xlWorksheet.LegacyDrawingId = context.RelIdGenerator.GetNext(XLWorkbook.RelType.Workbook);
              xlWorksheet.LegacyDrawingIsNew = true;
            }
            vmlDrawingPart = worksheetPart.AddNewPart<VmlDrawingPart>(xlWorksheet.LegacyDrawingId);
          }
          XLWorkbook.GenerateVmlDrawingPartContent(vmlDrawingPart, xlWorksheet, context);
        }
        XLWorkbook.GenerateWorksheetPartContent(worksheetPart, xlWorksheet, context);
        if (xlWorksheet.PivotTables.Any<IXLPivotTable>())
          XLWorkbook.GeneratePivotTables(workbookPart, worksheetPart, xlWorksheet, context);
      }
      this.GenerateCalculationChainPartContent(workbookPart, context);
      if (workbookPart.ThemePart == null)
        this.GenerateThemePartContent(workbookPart.AddNewPart<ThemePart>(context.RelIdGenerator.GetNext(XLWorkbook.RelType.Workbook)));
      if (this.CustomProperties.Any<IXLCustomProperty>())
      {
        document.GetPartsOfType<CustomFilePropertiesPart>().ToList<CustomFilePropertiesPart>().ForEach((Action<CustomFilePropertiesPart>) (p => document.DeletePart((OpenXmlPart) p)));
        this.GenerateCustomFilePropertiesPartContent(document.AddNewPart<CustomFilePropertiesPart>(context.RelIdGenerator.GetNext(XLWorkbook.RelType.Workbook)));
      }
      this.SetPackageProperties((OpenXmlPackage) document);
    }

    private void DeleteComments(WorksheetPart worksheetPart, XLWorksheet worksheet, XLWorkbook.SaveContext context)
    {
      worksheetPart.DeletePart((OpenXmlPart) worksheetPart.WorksheetCommentsPart);
      VmlDrawingPart vmlDrawingPart = worksheetPart.VmlDrawingParts.FirstOrDefault<VmlDrawingPart>();
      if (vmlDrawingPart == null)
        return;
      XDocument xdocument = XDocumentExtensions.Load(vmlDrawingPart.GetStream(FileMode.Open));
      xdocument.Root.Elements().Where<XElement>((Func<XElement, bool>) (e =>
      {
        if (e.Name.LocalName == "shapetype")
          return (string) e.Attribute((XName) "id") == "_x0000_t202";
        return false;
      })).Remove<XElement>();
      xdocument.Root.Elements().Where<XElement>((Func<XElement, bool>) (e =>
      {
        if (e.Name.LocalName == "shape")
          return (string) e.Attribute((XName) "type") == "#_x0000_t202";
        return false;
      })).Remove<XElement>();
      List<ImagePart> list1 = vmlDrawingPart.ImageParts.ToList<ImagePart>();
      List<LegacyDiagramTextPart> list2 = vmlDrawingPart.LegacyDiagramTextParts.ToList<LegacyDiagramTextPart>();
      string idOfPart = worksheetPart.GetIdOfPart((OpenXmlPart) vmlDrawingPart);
      worksheet.LegacyDrawingId = idOfPart;
      worksheetPart.ChangeIdOfPart((OpenXmlPart) vmlDrawingPart, "xxRRxx");
      bool flag1 = xdocument.Root.Elements().Any<XElement>((Func<XElement, bool>) (e =>
      {
        if (!(e.Name.LocalName == "shape"))
          return e.Name.LocalName == "group";
        return true;
      }));
      VmlDrawingPart vmlDrawingPartNew = (VmlDrawingPart) null;
      bool flag2 = list1.Count > 0 || list2.Count > 0 || flag1;
      if (flag2)
      {
        vmlDrawingPartNew = worksheetPart.AddNewPart<VmlDrawingPart>(idOfPart);
        using (XmlTextWriter xmlTextWriter = new XmlTextWriter(vmlDrawingPartNew.GetStream(FileMode.Create), Encoding.UTF8))
          xmlTextWriter.WriteRaw(xdocument.ToString());
        list1.ForEach((Action<ImagePart>) (p => vmlDrawingPartNew.AddPart<ImagePart>(p, vmlDrawingPart.GetIdOfPart((OpenXmlPart) p))));
        list2.ForEach((Action<LegacyDiagramTextPart>) (p => vmlDrawingPartNew.AddPart<LegacyDiagramTextPart>(p, vmlDrawingPart.GetIdOfPart((OpenXmlPart) p))));
      }
      worksheetPart.DeletePart((OpenXmlPart) vmlDrawingPart);
      if (!flag2 || !(idOfPart != worksheetPart.GetIdOfPart((OpenXmlPart) vmlDrawingPartNew)))
        return;
      worksheetPart.ChangeIdOfPart((OpenXmlPart) vmlDrawingPartNew, idOfPart);
    }

    private static void GenerateTables(XLWorksheet worksheet, WorksheetPart worksheetPart, XLWorkbook.SaveContext context)
    {
      worksheetPart.Worksheet.RemoveAllChildren<TablePart>();
      if (!worksheet.Tables.Any<IXLTable>())
        return;
      foreach (IXLTable table in (IEnumerable<IXLTable>) worksheet.Tables)
      {
        string next = context.RelIdGenerator.GetNext(XLWorkbook.RelType.Workbook);
        XLTable xlTable = (XLTable) table;
        xlTable.RelId = next;
        XLWorkbook.GenerateTableDefinitionPartContent(worksheetPart.AddNewPart<TableDefinitionPart>(next), xlTable, context);
      }
    }

    private void GenerateExtendedFilePropertiesPartContent(ExtendedFilePropertiesPart extendedFilePropertiesPart)
    {
      if (extendedFilePropertiesPart.Properties == null)
        extendedFilePropertiesPart.Properties = new DocumentFormat.OpenXml.ExtendedProperties.Properties();
      DocumentFormat.OpenXml.ExtendedProperties.Properties properties1 = extendedFilePropertiesPart.Properties;
      if (!properties1.NamespaceDeclarations.Contains<KeyValuePair<string, string>>(new KeyValuePair<string, string>("vt", "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")))
        properties1.AddNamespaceDeclaration("vt", "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes");
      if (properties1.Application == null)
      {
        DocumentFormat.OpenXml.ExtendedProperties.Properties properties2 = properties1;
        Application application = new Application();
        application.Text = "Microsoft Excel";
        Application newChild = application;
        properties2.AppendChild<Application>(newChild);
      }
      if (properties1.DocumentSecurity == null)
      {
        DocumentFormat.OpenXml.ExtendedProperties.Properties properties2 = properties1;
        DocumentSecurity documentSecurity = new DocumentSecurity();
        documentSecurity.Text = "0";
        DocumentSecurity newChild = documentSecurity;
        properties2.AppendChild<DocumentSecurity>(newChild);
      }
      if (properties1.ScaleCrop == null)
      {
        DocumentFormat.OpenXml.ExtendedProperties.Properties properties2 = properties1;
        ScaleCrop scaleCrop = new ScaleCrop();
        scaleCrop.Text = "false";
        ScaleCrop newChild = scaleCrop;
        properties2.AppendChild<ScaleCrop>(newChild);
      }
      if (properties1.HeadingPairs == null)
        properties1.HeadingPairs = new HeadingPairs();
      if (properties1.TitlesOfParts == null)
        properties1.TitlesOfParts = new TitlesOfParts();
      properties1.HeadingPairs.VTVector = new VTVector()
      {
        BaseType = (EnumValue<VectorBaseValues>) VectorBaseValues.Variant
      };
      properties1.TitlesOfParts.VTVector = new VTVector()
      {
        BaseType = (EnumValue<VectorBaseValues>) VectorBaseValues.Lpstr
      };
      VTVector vtVector1 = properties1.HeadingPairs.VTVector;
      VTVector vtVector2 = properties1.TitlesOfParts.VTVector;
      List<\u003C\u003Ef__AnonymousType2<string, int>> list = this.WorksheetsInternal.Select(w => new
      {
        Name = w.Name,
        Order = w.Position
      }).ToList();
      List<string> modifiedNamedRanges = this.GetModifiedNamedRanges();
      int count1 = list.Count;
      int count2 = modifiedNamedRanges.Count;
      XLWorkbook.InsertOnVtVector(vtVector1, "Worksheets", 0, count1.ToString());
      XLWorkbook.InsertOnVtVector(vtVector1, "Named Ranges", 2, count2.ToString());
      vtVector2.Size = (UInt32Value) ((uint) (count2 + count1));
      foreach (VTLPSTR newChild in list.OrderBy(w => w.Order).Select(w =>
      {
        return new VTLPSTR() { Text = w.Name };
      }))
        vtVector2.AppendChild<VTLPSTR>(newChild);
      foreach (VTLPSTR newChild in modifiedNamedRanges.Select<string, VTLPSTR>((Func<string, VTLPSTR>) (nr =>
      {
        return new VTLPSTR() { Text = nr };
      })))
        vtVector2.AppendChild<VTLPSTR>(newChild);
      if (this.Properties.Manager != null)
      {
        if (!XLHelper.IsNullOrWhiteSpace(this.Properties.Manager))
        {
          if (properties1.Manager == null)
            properties1.Manager = new Manager();
          properties1.Manager.Text = this.Properties.Manager;
        }
        else
          properties1.Manager = (Manager) null;
      }
      if (this.Properties.Company == null)
        return;
      if (!XLHelper.IsNullOrWhiteSpace(this.Properties.Company))
      {
        if (properties1.Company == null)
          properties1.Company = new Company();
        properties1.Company.Text = this.Properties.Company;
      }
      else
        properties1.Company = (Company) null;
    }

    private static void InsertOnVtVector(VTVector vTVector, string property, int index, string text)
    {
      if (!vTVector.Elements<DocumentFormat.OpenXml.VariantTypes.Variant>().Where<DocumentFormat.OpenXml.VariantTypes.Variant>((Func<DocumentFormat.OpenXml.VariantTypes.Variant, bool>) (e1 => e1.Elements<VTLPSTR>().Any<VTLPSTR>((Func<VTLPSTR, bool>) (e2 => e2.Text == property)))).Any<DocumentFormat.OpenXml.VariantTypes.Variant>())
      {
        if (vTVector.Size == null)
          vTVector.Size = new UInt32Value(0U);
        VTVector vtVector = vTVector;
        vtVector.Size = (UInt32Value) ((uint) vtVector.Size + 2U);
        DocumentFormat.OpenXml.VariantTypes.Variant newChild1 = new DocumentFormat.OpenXml.VariantTypes.Variant();
        VTLPSTR vtlpstr = new VTLPSTR();
        vtlpstr.Text = property;
        VTLPSTR newChild2 = vtlpstr;
        newChild1.AppendChild<VTLPSTR>(newChild2);
        vTVector.InsertAt<DocumentFormat.OpenXml.VariantTypes.Variant>(newChild1, index);
        DocumentFormat.OpenXml.VariantTypes.Variant newChild3 = new DocumentFormat.OpenXml.VariantTypes.Variant();
        VTInt32 newChild4 = new VTInt32();
        newChild3.AppendChild<VTInt32>(newChild4);
        vTVector.InsertAt<DocumentFormat.OpenXml.VariantTypes.Variant>(newChild3, index + 1);
      }
      int num = 0;
      foreach (OpenXmlElement element in vTVector.Elements<DocumentFormat.OpenXml.VariantTypes.Variant>())
      {
        if (element.Elements<VTLPSTR>().Any<VTLPSTR>((Func<VTLPSTR, bool>) (e2 => e2.Text == property)))
        {
          vTVector.ElementAt<OpenXmlElement>(num + 1).GetFirstChild<VTInt32>().Text = text;
          break;
        }
        ++num;
      }
    }

    private List<string> GetModifiedNamedRanges()
    {
      List<string> stringList = new List<string>();
      foreach (XLWorksheet xlWorksheet in this.WorksheetsInternal)
      {
        string wName = xlWorksheet.Name;
        stringList.AddRange(xlWorksheet.NamedRanges.Select<IXLNamedRange, string>((Func<IXLNamedRange, string>) (n => wName + "!" + n.Name)));
        stringList.Add(xlWorksheet.Name + "!Print_Area");
        stringList.Add(xlWorksheet.Name + "!Print_Titles");
      }
      stringList.AddRange(this.NamedRanges.Select<IXLNamedRange, string>((Func<IXLNamedRange, string>) (n => n.Name)));
      return stringList;
    }

    private void GenerateWorkbookPartContent(WorkbookPart workbookPart, XLWorkbook.SaveContext context)
    {
      if (workbookPart.Workbook == null)
        workbookPart.Workbook = new Workbook();
      Workbook workbook = workbookPart.Workbook;
      if (!workbook.NamespaceDeclarations.Contains<KeyValuePair<string, string>>(new KeyValuePair<string, string>("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships")))
        workbook.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
      if (workbook.WorkbookProperties == null)
        workbook.WorkbookProperties = new DocumentFormat.OpenXml.Spreadsheet.WorkbookProperties();
      if (workbook.WorkbookProperties.CodeName == null)
        workbook.WorkbookProperties.CodeName = (StringValue) "ThisWorkbook";
      if (this.Use1904DateSystem)
        workbook.WorkbookProperties.Date1904 = (BooleanValue) true;
      if (this.LockStructure || this.LockWindows)
      {
        if (workbook.WorkbookProtection == null)
          workbook.WorkbookProtection = new WorkbookProtection();
        workbook.WorkbookProtection.LockStructure = (BooleanValue) this.LockStructure;
        workbook.WorkbookProtection.LockWindows = (BooleanValue) this.LockWindows;
      }
      else
        workbook.WorkbookProtection = (WorkbookProtection) null;
      if (workbook.BookViews == null)
        workbook.BookViews = new BookViews();
      if (workbook.Sheets == null)
        workbook.Sheets = new Sheets();
      XLWorksheets worksheets = this.WorksheetsInternal;
      workbook.Sheets.Elements<Sheet>().Where<Sheet>((Func<Sheet, bool>) (s => worksheets.Deleted.Contains((string) s.Id))).ToList<Sheet>().ForEach((Action<Sheet>) (s => s.Remove()));
      foreach (Sheet element in workbook.Sheets.Elements<Sheet>())
      {
        int sheetId = (int) element.SheetId.Value;
        if (!this.WorksheetsInternal.All<XLWorksheet>((Func<XLWorksheet, bool>) (w => w.SheetId != sheetId)))
        {
          XLWorksheet xlWorksheet = this.WorksheetsInternal.Single<XLWorksheet>((Func<XLWorksheet, bool>) (w => w.SheetId == sheetId));
          xlWorksheet.RelId = (string) element.Id;
          element.Name = (StringValue) xlWorksheet.Name;
        }
      }
      foreach (XLWorksheet xlWorksheet in (IEnumerable<XLWorksheet>) this.WorksheetsInternal.Cast<XLWorksheet>().Where<XLWorksheet>((Func<XLWorksheet, bool>) (s => s.SheetId == 0)).OrderBy<XLWorksheet, int>((Func<XLWorksheet, int>) (w => w.Position)))
      {
        string rId = context.RelIdGenerator.GetNext(XLWorkbook.RelType.Workbook);
        while (this.WorksheetsInternal.Cast<XLWorksheet>().Any<XLWorksheet>((Func<XLWorksheet, bool>) (w => w.SheetId == int.Parse(rId.Substring(3)))))
          rId = context.RelIdGenerator.GetNext(XLWorkbook.RelType.Workbook);
        xlWorksheet.SheetId = int.Parse(rId.Substring(3));
        xlWorksheet.RelId = rId;
        Sheet newChild = new Sheet()
        {
          Name = (StringValue) xlWorksheet.Name,
          Id = (StringValue) rId,
          SheetId = (UInt32Value) ((uint) xlWorksheet.SheetId)
        };
        workbook.Sheets.AppendChild<Sheet>(newChild);
      }
      IEnumerable<Sheet> source = workbook.Sheets.Elements<Sheet>().Join((IEnumerable<XLWorksheet>) this.WorksheetsInternal, (Func<Sheet, string>) (sheet => sheet.Id.Value), (Func<XLWorksheet, string>) (worksheet => worksheet.RelId), (sheet, worksheet) => new
      {
        sheet = sheet,
        worksheet = worksheet
      }).OrderBy(_param0 => _param0.worksheet.Position).Select(_param0 => _param0.sheet);
      uint num1 = 0;
      uint num2 = this.UnsupportedSheets.Where<XLWorkbook.UnsupportedSheet>((Func<XLWorkbook.UnsupportedSheet, bool>) (us => us.IsActive)).Select<XLWorkbook.UnsupportedSheet, uint>((Func<XLWorkbook.UnsupportedSheet, uint>) (us => (uint) (us.Position - 1))).FirstOrDefault<uint>();
      bool flag = false;
      int num3 = source.Count<Sheet>() + this.UnsupportedSheets.Count;
      for (int p = 1; p <= num3; ++p)
      {
        if (this.UnsupportedSheets.All<XLWorkbook.UnsupportedSheet>((Func<XLWorkbook.UnsupportedSheet, bool>) (us => us.Position != p)))
        {
          Sheet sheet = source.ElementAt<Sheet>(p - this.UnsupportedSheets.Count<XLWorkbook.UnsupportedSheet>((Func<XLWorkbook.UnsupportedSheet, bool>) (us => us.Position <= p)) - 1);
          workbook.Sheets.RemoveChild<Sheet>(sheet);
          workbook.Sheets.AppendChild<Sheet>(sheet);
          IXLWorksheet xlWorksheet = this.Worksheet((string) sheet.Name);
          if (xlWorksheet.Visibility != XLWorksheetVisibility.Visible)
            sheet.State = (EnumValue<SheetStateValues>) xlWorksheet.Visibility.ToOpenXml();
          if (!flag)
          {
            if (sheet.State == null || (SheetStateValues) sheet.State == SheetStateValues.Visible)
              flag = true;
            else
              ++num1;
          }
        }
        else
        {
          uint sheetId = this.UnsupportedSheets.First<XLWorkbook.UnsupportedSheet>((Func<XLWorkbook.UnsupportedSheet, bool>) (us => us.Position == p)).SheetId;
          Sheet sheet = workbook.Sheets.Elements<Sheet>().First<Sheet>((Func<Sheet, bool>) (s => (int) (uint) s.SheetId == (int) sheetId));
          workbook.Sheets.RemoveChild<Sheet>(sheet);
          workbook.Sheets.AppendChild<Sheet>(sheet);
        }
      }
      WorkbookView workbookView = workbook.BookViews.Elements<WorkbookView>().FirstOrDefault<WorkbookView>();
      if ((int) num2 == 0)
      {
        num2 = num1;
        foreach (XLWorksheet xlWorksheet in worksheets)
        {
          if (xlWorksheet.TabActive)
          {
            num2 = (uint) (xlWorksheet.Position - 1);
            break;
          }
        }
      }
      if (workbookView == null)
      {
        WorkbookView newChild = new WorkbookView()
        {
          ActiveTab = (UInt32Value) num2,
          FirstSheet = (UInt32Value) num1
        };
        workbook.BookViews.AppendChild<WorkbookView>(newChild);
      }
      else
      {
        workbookView.ActiveTab = (UInt32Value) num2;
        workbookView.FirstSheet = (UInt32Value) num1;
      }
      DocumentFormat.OpenXml.Spreadsheet.DefinedNames definedNames = new DocumentFormat.OpenXml.Spreadsheet.DefinedNames();
      foreach (XLWorksheet xlWorksheet in this.WorksheetsInternal)
      {
        uint wsSheetId = (uint) xlWorksheet.SheetId;
        uint num4 = 0;
        foreach (Sheet sheet in workbook.Sheets.Elements<Sheet>().TakeWhile<Sheet>((Func<Sheet, bool>) (s => (int) (uint) s.SheetId != (int) wsSheetId)))
          ++num4;
        if (xlWorksheet.PageSetup.PrintAreas.Any<IXLRange>())
        {
          DocumentFormat.OpenXml.Spreadsheet.DefinedName newChild = new DocumentFormat.OpenXml.Spreadsheet.DefinedName()
          {
            Name = (StringValue) "_xlnm.Print_Area",
            LocalSheetId = (UInt32Value) num4
          };
          string worksheetName = xlWorksheet.Name;
          string str = xlWorksheet.PageSetup.PrintAreas.Aggregate<IXLRange, string>(string.Empty, (Func<string, IXLRange, string>) ((current, printArea) => current + "'" + worksheetName + "'!" + printArea.RangeAddress.FirstAddress.ToStringFixed(XLReferenceStyle.A1) + ":" + printArea.RangeAddress.LastAddress.ToStringFixed(XLReferenceStyle.A1) + ","));
          newChild.Text = str.Substring(0, str.Length - 1);
          definedNames.AppendChild<DocumentFormat.OpenXml.Spreadsheet.DefinedName>(newChild);
        }
        if (xlWorksheet.AutoFilter.Enabled)
        {
          DocumentFormat.OpenXml.Spreadsheet.DefinedName definedName = new DocumentFormat.OpenXml.Spreadsheet.DefinedName();
          definedName.Name = (StringValue) "_xlnm._FilterDatabase";
          definedName.LocalSheetId = (UInt32Value) num4;
          definedName.Text = "'" + xlWorksheet.Name + "'!" + xlWorksheet.AutoFilter.Range.RangeAddress.FirstAddress.ToStringFixed(XLReferenceStyle.A1) + ":" + xlWorksheet.AutoFilter.Range.RangeAddress.LastAddress.ToStringFixed(XLReferenceStyle.A1);
          definedName.Hidden = BooleanValue.FromBoolean(true);
          DocumentFormat.OpenXml.Spreadsheet.DefinedName newChild = definedName;
          definedNames.AppendChild<DocumentFormat.OpenXml.Spreadsheet.DefinedName>(newChild);
        }
        foreach (IXLNamedRange xlNamedRange in xlWorksheet.NamedRanges.Where<IXLNamedRange>((Func<IXLNamedRange, bool>) (n => n.Name != "_xlnm._FilterDatabase")))
        {
          DocumentFormat.OpenXml.Spreadsheet.DefinedName definedName = new DocumentFormat.OpenXml.Spreadsheet.DefinedName();
          definedName.Name = (StringValue) xlNamedRange.Name;
          definedName.LocalSheetId = (UInt32Value) num4;
          definedName.Text = xlNamedRange.ToString();
          DocumentFormat.OpenXml.Spreadsheet.DefinedName newChild = definedName;
          if (!XLHelper.IsNullOrWhiteSpace(xlNamedRange.Comment))
            newChild.Comment = (StringValue) xlNamedRange.Comment;
          definedNames.AppendChild<DocumentFormat.OpenXml.Spreadsheet.DefinedName>(newChild);
        }
        string str1 = string.Empty;
        string str2 = string.Empty;
        if (xlWorksheet.PageSetup.FirstRowToRepeatAtTop > 0)
          str1 = "'" + xlWorksheet.Name + "'!" + (object) xlWorksheet.PageSetup.FirstRowToRepeatAtTop + ":" + (object) xlWorksheet.PageSetup.LastRowToRepeatAtTop;
        if (xlWorksheet.PageSetup.FirstColumnToRepeatAtLeft > 0)
        {
          int columnToRepeatAtLeft1 = xlWorksheet.PageSetup.FirstColumnToRepeatAtLeft;
          int columnToRepeatAtLeft2 = xlWorksheet.PageSetup.LastColumnToRepeatAtLeft;
          str2 = "'" + xlWorksheet.Name + "'!" + XLHelper.GetColumnLetterFromNumber(columnToRepeatAtLeft1) + ":" + XLHelper.GetColumnLetterFromNumber(columnToRepeatAtLeft2);
        }
        string str3;
        if (str2.Length > 0)
        {
          str3 = str2;
          if (str1.Length > 0)
            str3 = str3 + "," + str1;
        }
        else
          str3 = str1;
        if (str3.Length > 0)
        {
          DocumentFormat.OpenXml.Spreadsheet.DefinedName definedName = new DocumentFormat.OpenXml.Spreadsheet.DefinedName();
          definedName.Name = (StringValue) "_xlnm.Print_Titles";
          definedName.LocalSheetId = (UInt32Value) num4;
          definedName.Text = str3;
          DocumentFormat.OpenXml.Spreadsheet.DefinedName newChild = definedName;
          definedNames.AppendChild<DocumentFormat.OpenXml.Spreadsheet.DefinedName>(newChild);
        }
      }
      foreach (IXLNamedRange namedRange in (IEnumerable<IXLNamedRange>) this.NamedRanges)
      {
        DocumentFormat.OpenXml.Spreadsheet.DefinedName definedName = new DocumentFormat.OpenXml.Spreadsheet.DefinedName();
        definedName.Name = (StringValue) namedRange.Name;
        definedName.Text = namedRange.ToString();
        DocumentFormat.OpenXml.Spreadsheet.DefinedName newChild = definedName;
        if (!XLHelper.IsNullOrWhiteSpace(namedRange.Comment))
          newChild.Comment = (StringValue) namedRange.Comment;
        definedNames.AppendChild<DocumentFormat.OpenXml.Spreadsheet.DefinedName>(newChild);
      }
      workbook.DefinedNames = definedNames;
      if (workbook.CalculationProperties == null)
        workbook.CalculationProperties = new CalculationProperties()
        {
          CalculationId = (UInt32Value) 125725U
        };
      workbook.CalculationProperties.CalculationMode = this.CalculateMode != XLCalculateMode.Default ? (EnumValue<CalculateModeValues>) this.CalculateMode.ToOpenXml() : (EnumValue<CalculateModeValues>) null;
      if (this.ReferenceStyle == XLReferenceStyle.Default)
        workbook.CalculationProperties.ReferenceMode = (EnumValue<ReferenceModeValues>) null;
      else
        workbook.CalculationProperties.ReferenceMode = (EnumValue<ReferenceModeValues>) this.ReferenceStyle.ToOpenXml();
    }

    private void GenerateSharedStringTablePartContent(SharedStringTablePart sharedStringTablePart, XLWorkbook.SaveContext context)
    {
      int x = 0;
      this.Worksheets.ForEach<IXLWorksheet>((Action<IXLWorksheet>) (w => w.Tables.ForEach<IXLTable>((Action<IXLTable>) (t => x = (t as XLTable).FieldNames.Count))));
      sharedStringTablePart.SharedStringTable = new SharedStringTable()
      {
        Count = (UInt32Value) 0U,
        UniqueCount = (UInt32Value) 0U
      };
      int num = 0;
      Dictionary<string, int> dictionary1 = new Dictionary<string, int>();
      Dictionary<IXLRichText, int> dictionary2 = new Dictionary<IXLRichText, int>();
      foreach (XLCell xlCell in this.Worksheets.Cast<XLWorksheet>().SelectMany<XLWorksheet, XLCell>((Func<XLWorksheet, IEnumerable<XLCell>>) (w => w.Internals.CellsCollection.GetCells((Func<IXLCell, bool>) (c =>
      {
        if ((c.DataType == XLCellValues.Text && c.ShareString || c.HasRichText) && (c as XLCell).InnerText.Length > 0)
          return XLHelper.IsNullOrWhiteSpace(c.FormulaA1);
        return false;
      })))))
      {
        xlCell.DataType = XLCellValues.Text;
        if (xlCell.HasRichText)
        {
          if (dictionary2.ContainsKey(xlCell.RichText))
          {
            xlCell.SharedStringId = dictionary2[xlCell.RichText];
          }
          else
          {
            SharedStringItem sharedStringItem = new SharedStringItem();
            foreach (IXLRichString rt in xlCell.RichText.Where<IXLRichString>((Func<IXLRichString, bool>) (r => !string.IsNullOrEmpty(r.Text))))
              sharedStringItem.Append(new OpenXmlElement[1]
              {
                (OpenXmlElement) XLWorkbook.GetRun(rt)
              });
            if (xlCell.RichText.HasPhonetics)
            {
              foreach (IXLPhonetic phonetic in (IEnumerable<IXLPhonetic>) xlCell.RichText.Phonetics)
              {
                PhoneticRun phoneticRun = new PhoneticRun()
                {
                  BaseTextStartIndex = (UInt32Value) ((uint) phonetic.Start),
                  EndingBaseIndex = (UInt32Value) ((uint) phonetic.End)
                };
                DocumentFormat.OpenXml.Spreadsheet.Text text1 = new DocumentFormat.OpenXml.Spreadsheet.Text();
                text1.Text = phonetic.Text;
                DocumentFormat.OpenXml.Spreadsheet.Text text2 = text1;
                if (phonetic.Text.PreserveSpaces())
                  text2.Space = (EnumValue<SpaceProcessingModeValues>) SpaceProcessingModeValues.Preserve;
                phoneticRun.Append(new OpenXmlElement[1]
                {
                  (OpenXmlElement) text2
                });
                sharedStringItem.Append(new OpenXmlElement[1]
                {
                  (OpenXmlElement) phoneticRun
                });
              }
              XLFont xlFont = new XLFont((IXLStylized) null, (IXLFontBase) xlCell.RichText.Phonetics, true);
              if (!context.SharedFonts.ContainsKey((IXLFont) xlFont))
                context.SharedFonts.Add((IXLFont) xlFont, new XLWorkbook.FontInfo()
                {
                  Font = xlFont
                });
              PhoneticProperties phoneticProperties = new PhoneticProperties()
              {
                FontId = (UInt32Value) context.SharedFonts[(IXLFont) new XLFont((IXLStylized) null, (IXLFontBase) xlCell.RichText.Phonetics, true)].FontId
              };
              if (xlCell.RichText.Phonetics.Alignment != XLPhoneticAlignment.Left)
                phoneticProperties.Alignment = (EnumValue<PhoneticAlignmentValues>) xlCell.RichText.Phonetics.Alignment.ToOpenXml();
              if (xlCell.RichText.Phonetics.Type != XLPhoneticType.FullWidthKatakana)
                phoneticProperties.Type = (EnumValue<PhoneticValues>) xlCell.RichText.Phonetics.Type.ToOpenXml();
              sharedStringItem.Append(new OpenXmlElement[1]
              {
                (OpenXmlElement) phoneticProperties
              });
            }
            sharedStringTablePart.SharedStringTable.Append(new OpenXmlElement[1]
            {
              (OpenXmlElement) sharedStringItem
            });
            SharedStringTable sharedStringTable1 = sharedStringTablePart.SharedStringTable;
            sharedStringTable1.Count = (UInt32Value) ((uint) sharedStringTable1.Count + 1U);
            SharedStringTable sharedStringTable2 = sharedStringTablePart.SharedStringTable;
            sharedStringTable2.UniqueCount = (UInt32Value) ((uint) sharedStringTable2.UniqueCount + 1U);
            dictionary2.Add(xlCell.RichText, num);
            xlCell.SharedStringId = num;
            ++num;
          }
        }
        else if (dictionary1.ContainsKey(xlCell.Value.ToString()))
        {
          xlCell.SharedStringId = dictionary1[xlCell.Value.ToString()];
        }
        else
        {
          string str = xlCell.Value.ToString();
          SharedStringItem sharedStringItem = new SharedStringItem();
          DocumentFormat.OpenXml.Spreadsheet.Text text1 = new DocumentFormat.OpenXml.Spreadsheet.Text();
          text1.Text = str;
          DocumentFormat.OpenXml.Spreadsheet.Text text2 = text1;
          if (!str.Trim().Equals(str))
            text2.Space = (EnumValue<SpaceProcessingModeValues>) SpaceProcessingModeValues.Preserve;
          sharedStringItem.Append(new OpenXmlElement[1]
          {
            (OpenXmlElement) text2
          });
          sharedStringTablePart.SharedStringTable.Append(new OpenXmlElement[1]
          {
            (OpenXmlElement) sharedStringItem
          });
          SharedStringTable sharedStringTable1 = sharedStringTablePart.SharedStringTable;
          sharedStringTable1.Count = (UInt32Value) ((uint) sharedStringTable1.Count + 1U);
          SharedStringTable sharedStringTable2 = sharedStringTablePart.SharedStringTable;
          sharedStringTable2.UniqueCount = (UInt32Value) ((uint) sharedStringTable2.UniqueCount + 1U);
          dictionary1.Add(xlCell.Value.ToString(), num);
          xlCell.SharedStringId = num;
          ++num;
        }
      }
    }

    private static DocumentFormat.OpenXml.Spreadsheet.Run GetRun(IXLRichString rt)
    {
      DocumentFormat.OpenXml.Spreadsheet.Run run = new DocumentFormat.OpenXml.Spreadsheet.Run();
      DocumentFormat.OpenXml.Spreadsheet.RunProperties runProperties = new DocumentFormat.OpenXml.Spreadsheet.RunProperties();
      Bold bold = rt.Bold ? new Bold() : (Bold) null;
      Italic italic = rt.Italic ? new Italic() : (Italic) null;
      DocumentFormat.OpenXml.Spreadsheet.Underline underline1;
      if (rt.Underline == XLFontUnderlineValues.None)
        underline1 = (DocumentFormat.OpenXml.Spreadsheet.Underline) null;
      else
        underline1 = new DocumentFormat.OpenXml.Spreadsheet.Underline()
        {
          Val = (EnumValue<UnderlineValues>) rt.Underline.ToOpenXml()
        };
      DocumentFormat.OpenXml.Spreadsheet.Underline underline2 = underline1;
      Strike strike = rt.Strikethrough ? new Strike() : (Strike) null;
      DocumentFormat.OpenXml.Spreadsheet.VerticalTextAlignment verticalTextAlignment = new DocumentFormat.OpenXml.Spreadsheet.VerticalTextAlignment()
      {
        Val = (EnumValue<VerticalAlignmentRunValues>) rt.VerticalAlignment.ToOpenXml()
      };
      DocumentFormat.OpenXml.Spreadsheet.Shadow shadow = rt.Shadow ? new DocumentFormat.OpenXml.Spreadsheet.Shadow() : (DocumentFormat.OpenXml.Spreadsheet.Shadow) null;
      FontSize fontSize = new FontSize()
      {
        Val = (DoubleValue) rt.FontSize
      };
      DocumentFormat.OpenXml.Spreadsheet.Color newColor = XLWorkbook.GetNewColor(rt.FontColor);
      RunFont runFont = new RunFont()
      {
        Val = (StringValue) rt.FontName
      };
      DocumentFormat.OpenXml.Spreadsheet.FontFamily fontFamily1 = new DocumentFormat.OpenXml.Spreadsheet.FontFamily();
      fontFamily1.Val = (Int32Value) ((int) rt.FontFamilyNumbering);
      DocumentFormat.OpenXml.Spreadsheet.FontFamily fontFamily2 = fontFamily1;
      if (bold != null)
        runProperties.Append(new OpenXmlElement[1]
        {
          (OpenXmlElement) bold
        });
      if (italic != null)
        runProperties.Append(new OpenXmlElement[1]
        {
          (OpenXmlElement) italic
        });
      if (strike != null)
        runProperties.Append(new OpenXmlElement[1]
        {
          (OpenXmlElement) strike
        });
      if (shadow != null)
        runProperties.Append(new OpenXmlElement[1]
        {
          (OpenXmlElement) shadow
        });
      if (underline2 != null)
        runProperties.Append(new OpenXmlElement[1]
        {
          (OpenXmlElement) underline2
        });
      runProperties.Append(new OpenXmlElement[1]
      {
        (OpenXmlElement) verticalTextAlignment
      });
      runProperties.Append(new OpenXmlElement[1]
      {
        (OpenXmlElement) fontSize
      });
      runProperties.Append(new OpenXmlElement[1]
      {
        (OpenXmlElement) newColor
      });
      runProperties.Append(new OpenXmlElement[1]
      {
        (OpenXmlElement) runFont
      });
      runProperties.Append(new OpenXmlElement[1]
      {
        (OpenXmlElement) fontFamily2
      });
      DocumentFormat.OpenXml.Spreadsheet.Text text1 = new DocumentFormat.OpenXml.Spreadsheet.Text();
      text1.Text = rt.Text;
      DocumentFormat.OpenXml.Spreadsheet.Text text2 = text1;
      if (rt.Text.PreserveSpaces())
        text2.Space = (EnumValue<SpaceProcessingModeValues>) SpaceProcessingModeValues.Preserve;
      run.Append(new OpenXmlElement[1]
      {
        (OpenXmlElement) runProperties
      });
      run.Append(new OpenXmlElement[1]
      {
        (OpenXmlElement) text2
      });
      return run;
    }

    private void GenerateCalculationChainPartContent(WorkbookPart workbookPart, XLWorkbook.SaveContext context)
    {
      string next = context.RelIdGenerator.GetNext(XLWorkbook.RelType.Workbook);
      if (workbookPart.CalculationChainPart == null)
        workbookPart.AddNewPart<CalculationChainPart>(next);
      if (workbookPart.CalculationChainPart.CalculationChain == null)
        workbookPart.CalculationChainPart.CalculationChain = new CalculationChain();
      CalculationChain calculationChain = workbookPart.CalculationChainPart.CalculationChain;
      calculationChain.RemoveAllChildren<CalculationCell>();
      foreach (XLWorksheet xlWorksheet in this.WorksheetsInternal)
      {
        HashSet<string> cellsWithoutFormulas = new HashSet<string>();
        foreach (XLCell cell in xlWorksheet.Internals.CellsCollection.GetCells())
        {
          if (XLHelper.IsNullOrWhiteSpace(cell.FormulaA1))
            cellsWithoutFormulas.Add(cell.Address.ToStringRelative());
          else if (cell.FormulaA1.StartsWith("{"))
          {
            CalculationCell newChild = new CalculationCell()
            {
              CellReference = (StringValue) cell.Address.ToString(),
              SheetId = (Int32Value) xlWorksheet.SheetId
            };
            if (cell.FormulaReference == null)
              cell.FormulaReference = (IXLRangeAddress) cell.AsRange().RangeAddress;
            if (cell.FormulaReference.FirstAddress.Equals((IXLAddress) cell.Address))
            {
              newChild.Array = (BooleanValue) true;
              calculationChain.AppendChild<CalculationCell>(newChild);
              calculationChain.AppendChild<CalculationCell>(new CalculationCell()
              {
                CellReference = (StringValue) cell.Address.ToString(),
                InChildChain = (BooleanValue) true
              });
            }
            else
              calculationChain.AppendChild<CalculationCell>(newChild);
          }
          else
            calculationChain.AppendChild<CalculationCell>(new CalculationCell()
            {
              CellReference = (StringValue) cell.Address.ToString(),
              SheetId = (Int32Value) xlWorksheet.SheetId
            });
        }
        calculationChain.Elements<CalculationCell>().Where<CalculationCell>((Func<CalculationCell, bool>) (cc =>
        {
          if (cc.SheetId != null || cc.InChildChain != null || !calculationChain.Elements<CalculationCell>().Where<CalculationCell>((Func<CalculationCell, bool>) (c1 => c1.SheetId != null)).Select<CalculationCell, string>((Func<CalculationCell, string>) (c1 => c1.CellReference.Value)).Contains<string>(cc.CellReference.Value))
            return cellsWithoutFormulas.Contains(cc.CellReference.Value);
          return true;
        })).ToList<CalculationCell>().ForEach((Action<CalculationCell>) (cc => calculationChain.RemoveChild<CalculationCell>(cc)));
      }
      if (calculationChain.Any<OpenXmlElement>())
        return;
      workbookPart.DeletePart((OpenXmlPart) workbookPart.CalculationChainPart);
    }

    private void GenerateThemePartContent(ThemePart themePart)
    {
      DocumentFormat.OpenXml.Drawing.Theme theme = new DocumentFormat.OpenXml.Drawing.Theme()
      {
        Name = (StringValue) "Office Theme"
      };
      theme.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
      ThemeElements newChild1 = new ThemeElements();
      ColorScheme newChild2 = new ColorScheme()
      {
        Name = (StringValue) "Office"
      };
      Dark1Color newChild3 = new Dark1Color();
      SystemColor newChild4 = new SystemColor()
      {
        Val = (EnumValue<SystemColorValues>) SystemColorValues.WindowText,
        LastColor = (HexBinaryValue) this.Theme.Text1.Color.ToHex().Substring(2)
      };
      newChild3.AppendChild<SystemColor>(newChild4);
      Light1Color newChild5 = new Light1Color();
      SystemColor newChild6 = new SystemColor()
      {
        Val = (EnumValue<SystemColorValues>) SystemColorValues.Window,
        LastColor = (HexBinaryValue) this.Theme.Background1.Color.ToHex().Substring(2)
      };
      newChild5.AppendChild<SystemColor>(newChild6);
      Dark2Color newChild7 = new Dark2Color();
      RgbColorModelHex newChild8 = new RgbColorModelHex()
      {
        Val = (HexBinaryValue) this.Theme.Text2.Color.ToHex().Substring(2)
      };
      newChild7.AppendChild<RgbColorModelHex>(newChild8);
      Light2Color newChild9 = new Light2Color();
      RgbColorModelHex newChild10 = new RgbColorModelHex()
      {
        Val = (HexBinaryValue) this.Theme.Background2.Color.ToHex().Substring(2)
      };
      newChild9.AppendChild<RgbColorModelHex>(newChild10);
      Accent1Color newChild11 = new Accent1Color();
      RgbColorModelHex newChild12 = new RgbColorModelHex()
      {
        Val = (HexBinaryValue) this.Theme.Accent1.Color.ToHex().Substring(2)
      };
      newChild11.AppendChild<RgbColorModelHex>(newChild12);
      Accent2Color newChild13 = new Accent2Color();
      RgbColorModelHex newChild14 = new RgbColorModelHex()
      {
        Val = (HexBinaryValue) this.Theme.Accent2.Color.ToHex().Substring(2)
      };
      newChild13.AppendChild<RgbColorModelHex>(newChild14);
      Accent3Color newChild15 = new Accent3Color();
      RgbColorModelHex newChild16 = new RgbColorModelHex()
      {
        Val = (HexBinaryValue) this.Theme.Accent3.Color.ToHex().Substring(2)
      };
      newChild15.AppendChild<RgbColorModelHex>(newChild16);
      Accent4Color newChild17 = new Accent4Color();
      RgbColorModelHex newChild18 = new RgbColorModelHex()
      {
        Val = (HexBinaryValue) this.Theme.Accent4.Color.ToHex().Substring(2)
      };
      newChild17.AppendChild<RgbColorModelHex>(newChild18);
      Accent5Color newChild19 = new Accent5Color();
      RgbColorModelHex newChild20 = new RgbColorModelHex()
      {
        Val = (HexBinaryValue) this.Theme.Accent5.Color.ToHex().Substring(2)
      };
      newChild19.AppendChild<RgbColorModelHex>(newChild20);
      Accent6Color newChild21 = new Accent6Color();
      RgbColorModelHex newChild22 = new RgbColorModelHex()
      {
        Val = (HexBinaryValue) this.Theme.Accent6.Color.ToHex().Substring(2)
      };
      newChild21.AppendChild<RgbColorModelHex>(newChild22);
      DocumentFormat.OpenXml.Drawing.Hyperlink newChild23 = new DocumentFormat.OpenXml.Drawing.Hyperlink();
      RgbColorModelHex newChild24 = new RgbColorModelHex()
      {
        Val = (HexBinaryValue) this.Theme.Hyperlink.Color.ToHex().Substring(2)
      };
      newChild23.AppendChild<RgbColorModelHex>(newChild24);
      FollowedHyperlinkColor newChild25 = new FollowedHyperlinkColor();
      RgbColorModelHex newChild26 = new RgbColorModelHex()
      {
        Val = (HexBinaryValue) this.Theme.FollowedHyperlink.Color.ToHex().Substring(2)
      };
      newChild25.AppendChild<RgbColorModelHex>(newChild26);
      newChild2.AppendChild<Dark1Color>(newChild3);
      newChild2.AppendChild<Light1Color>(newChild5);
      newChild2.AppendChild<Dark2Color>(newChild7);
      newChild2.AppendChild<Light2Color>(newChild9);
      newChild2.AppendChild<Accent1Color>(newChild11);
      newChild2.AppendChild<Accent2Color>(newChild13);
      newChild2.AppendChild<Accent3Color>(newChild15);
      newChild2.AppendChild<Accent4Color>(newChild17);
      newChild2.AppendChild<Accent5Color>(newChild19);
      newChild2.AppendChild<Accent6Color>(newChild21);
      newChild2.AppendChild<DocumentFormat.OpenXml.Drawing.Hyperlink>(newChild23);
      newChild2.AppendChild<FollowedHyperlinkColor>(newChild25);
      DocumentFormat.OpenXml.Drawing.FontScheme newChild27 = new DocumentFormat.OpenXml.Drawing.FontScheme()
      {
        Name = (StringValue) "Office"
      };
      MajorFont newChild28 = new MajorFont();
      LatinFont latinFont1 = new LatinFont();
      latinFont1.Typeface = (StringValue) "Cambria";
      LatinFont newChild29 = latinFont1;
      EastAsianFont eastAsianFont1 = new EastAsianFont();
      eastAsianFont1.Typeface = (StringValue) "";
      EastAsianFont newChild30 = eastAsianFont1;
      ComplexScriptFont complexScriptFont1 = new ComplexScriptFont();
      complexScriptFont1.Typeface = (StringValue) "";
      ComplexScriptFont newChild31 = complexScriptFont1;
      SupplementalFont newChild32 = new SupplementalFont()
      {
        Script = (StringValue) "Jpan",
        Typeface = (StringValue) "ＭＳ Ｐゴシック"
      };
      SupplementalFont newChild33 = new SupplementalFont()
      {
        Script = (StringValue) "Hang",
        Typeface = (StringValue) "맑은 고딕"
      };
      SupplementalFont newChild34 = new SupplementalFont()
      {
        Script = (StringValue) "Hans",
        Typeface = (StringValue) "宋体"
      };
      SupplementalFont newChild35 = new SupplementalFont()
      {
        Script = (StringValue) "Hant",
        Typeface = (StringValue) "新細明體"
      };
      SupplementalFont newChild36 = new SupplementalFont()
      {
        Script = (StringValue) "Arab",
        Typeface = (StringValue) "Times New Roman"
      };
      SupplementalFont newChild37 = new SupplementalFont()
      {
        Script = (StringValue) "Hebr",
        Typeface = (StringValue) "Times New Roman"
      };
      SupplementalFont newChild38 = new SupplementalFont()
      {
        Script = (StringValue) "Thai",
        Typeface = (StringValue) "Tahoma"
      };
      SupplementalFont newChild39 = new SupplementalFont()
      {
        Script = (StringValue) "Ethi",
        Typeface = (StringValue) "Nyala"
      };
      SupplementalFont newChild40 = new SupplementalFont()
      {
        Script = (StringValue) "Beng",
        Typeface = (StringValue) "Vrinda"
      };
      SupplementalFont newChild41 = new SupplementalFont()
      {
        Script = (StringValue) "Gujr",
        Typeface = (StringValue) "Shruti"
      };
      SupplementalFont newChild42 = new SupplementalFont()
      {
        Script = (StringValue) "Khmr",
        Typeface = (StringValue) "MoolBoran"
      };
      SupplementalFont newChild43 = new SupplementalFont()
      {
        Script = (StringValue) "Knda",
        Typeface = (StringValue) "Tunga"
      };
      SupplementalFont newChild44 = new SupplementalFont()
      {
        Script = (StringValue) "Guru",
        Typeface = (StringValue) "Raavi"
      };
      SupplementalFont newChild45 = new SupplementalFont()
      {
        Script = (StringValue) "Cans",
        Typeface = (StringValue) "Euphemia"
      };
      SupplementalFont newChild46 = new SupplementalFont()
      {
        Script = (StringValue) "Cher",
        Typeface = (StringValue) "Plantagenet Cherokee"
      };
      SupplementalFont newChild47 = new SupplementalFont()
      {
        Script = (StringValue) "Yiii",
        Typeface = (StringValue) "Microsoft Yi Baiti"
      };
      SupplementalFont newChild48 = new SupplementalFont()
      {
        Script = (StringValue) "Tibt",
        Typeface = (StringValue) "Microsoft Himalaya"
      };
      SupplementalFont newChild49 = new SupplementalFont()
      {
        Script = (StringValue) "Thaa",
        Typeface = (StringValue) "MV Boli"
      };
      SupplementalFont newChild50 = new SupplementalFont()
      {
        Script = (StringValue) "Deva",
        Typeface = (StringValue) "Mangal"
      };
      SupplementalFont newChild51 = new SupplementalFont()
      {
        Script = (StringValue) "Telu",
        Typeface = (StringValue) "Gautami"
      };
      SupplementalFont newChild52 = new SupplementalFont()
      {
        Script = (StringValue) "Taml",
        Typeface = (StringValue) "Latha"
      };
      SupplementalFont newChild53 = new SupplementalFont()
      {
        Script = (StringValue) "Syrc",
        Typeface = (StringValue) "Estrangelo Edessa"
      };
      SupplementalFont newChild54 = new SupplementalFont()
      {
        Script = (StringValue) "Orya",
        Typeface = (StringValue) "Kalinga"
      };
      SupplementalFont newChild55 = new SupplementalFont()
      {
        Script = (StringValue) "Mlym",
        Typeface = (StringValue) "Kartika"
      };
      SupplementalFont newChild56 = new SupplementalFont()
      {
        Script = (StringValue) "Laoo",
        Typeface = (StringValue) "DokChampa"
      };
      SupplementalFont newChild57 = new SupplementalFont()
      {
        Script = (StringValue) "Sinh",
        Typeface = (StringValue) "Iskoola Pota"
      };
      SupplementalFont newChild58 = new SupplementalFont()
      {
        Script = (StringValue) "Mong",
        Typeface = (StringValue) "Mongolian Baiti"
      };
      SupplementalFont newChild59 = new SupplementalFont()
      {
        Script = (StringValue) "Viet",
        Typeface = (StringValue) "Times New Roman"
      };
      SupplementalFont newChild60 = new SupplementalFont()
      {
        Script = (StringValue) "Uigh",
        Typeface = (StringValue) "Microsoft Uighur"
      };
      newChild28.AppendChild<LatinFont>(newChild29);
      newChild28.AppendChild<EastAsianFont>(newChild30);
      newChild28.AppendChild<ComplexScriptFont>(newChild31);
      newChild28.AppendChild<SupplementalFont>(newChild32);
      newChild28.AppendChild<SupplementalFont>(newChild33);
      newChild28.AppendChild<SupplementalFont>(newChild34);
      newChild28.AppendChild<SupplementalFont>(newChild35);
      newChild28.AppendChild<SupplementalFont>(newChild36);
      newChild28.AppendChild<SupplementalFont>(newChild37);
      newChild28.AppendChild<SupplementalFont>(newChild38);
      newChild28.AppendChild<SupplementalFont>(newChild39);
      newChild28.AppendChild<SupplementalFont>(newChild40);
      newChild28.AppendChild<SupplementalFont>(newChild41);
      newChild28.AppendChild<SupplementalFont>(newChild42);
      newChild28.AppendChild<SupplementalFont>(newChild43);
      newChild28.AppendChild<SupplementalFont>(newChild44);
      newChild28.AppendChild<SupplementalFont>(newChild45);
      newChild28.AppendChild<SupplementalFont>(newChild46);
      newChild28.AppendChild<SupplementalFont>(newChild47);
      newChild28.AppendChild<SupplementalFont>(newChild48);
      newChild28.AppendChild<SupplementalFont>(newChild49);
      newChild28.AppendChild<SupplementalFont>(newChild50);
      newChild28.AppendChild<SupplementalFont>(newChild51);
      newChild28.AppendChild<SupplementalFont>(newChild52);
      newChild28.AppendChild<SupplementalFont>(newChild53);
      newChild28.AppendChild<SupplementalFont>(newChild54);
      newChild28.AppendChild<SupplementalFont>(newChild55);
      newChild28.AppendChild<SupplementalFont>(newChild56);
      newChild28.AppendChild<SupplementalFont>(newChild57);
      newChild28.AppendChild<SupplementalFont>(newChild58);
      newChild28.AppendChild<SupplementalFont>(newChild59);
      newChild28.AppendChild<SupplementalFont>(newChild60);
      MinorFont newChild61 = new MinorFont();
      LatinFont latinFont2 = new LatinFont();
      latinFont2.Typeface = (StringValue) "Calibri";
      LatinFont newChild62 = latinFont2;
      EastAsianFont eastAsianFont2 = new EastAsianFont();
      eastAsianFont2.Typeface = (StringValue) "";
      EastAsianFont newChild63 = eastAsianFont2;
      ComplexScriptFont complexScriptFont2 = new ComplexScriptFont();
      complexScriptFont2.Typeface = (StringValue) "";
      ComplexScriptFont newChild64 = complexScriptFont2;
      SupplementalFont newChild65 = new SupplementalFont()
      {
        Script = (StringValue) "Jpan",
        Typeface = (StringValue) "ＭＳ Ｐゴシック"
      };
      SupplementalFont newChild66 = new SupplementalFont()
      {
        Script = (StringValue) "Hang",
        Typeface = (StringValue) "맑은 고딕"
      };
      SupplementalFont newChild67 = new SupplementalFont()
      {
        Script = (StringValue) "Hans",
        Typeface = (StringValue) "宋体"
      };
      SupplementalFont newChild68 = new SupplementalFont()
      {
        Script = (StringValue) "Hant",
        Typeface = (StringValue) "新細明體"
      };
      SupplementalFont newChild69 = new SupplementalFont()
      {
        Script = (StringValue) "Arab",
        Typeface = (StringValue) "Arial"
      };
      SupplementalFont newChild70 = new SupplementalFont()
      {
        Script = (StringValue) "Hebr",
        Typeface = (StringValue) "Arial"
      };
      SupplementalFont newChild71 = new SupplementalFont()
      {
        Script = (StringValue) "Thai",
        Typeface = (StringValue) "Tahoma"
      };
      SupplementalFont newChild72 = new SupplementalFont()
      {
        Script = (StringValue) "Ethi",
        Typeface = (StringValue) "Nyala"
      };
      SupplementalFont newChild73 = new SupplementalFont()
      {
        Script = (StringValue) "Beng",
        Typeface = (StringValue) "Vrinda"
      };
      SupplementalFont newChild74 = new SupplementalFont()
      {
        Script = (StringValue) "Gujr",
        Typeface = (StringValue) "Shruti"
      };
      SupplementalFont newChild75 = new SupplementalFont()
      {
        Script = (StringValue) "Khmr",
        Typeface = (StringValue) "DaunPenh"
      };
      SupplementalFont newChild76 = new SupplementalFont()
      {
        Script = (StringValue) "Knda",
        Typeface = (StringValue) "Tunga"
      };
      SupplementalFont newChild77 = new SupplementalFont()
      {
        Script = (StringValue) "Guru",
        Typeface = (StringValue) "Raavi"
      };
      SupplementalFont newChild78 = new SupplementalFont()
      {
        Script = (StringValue) "Cans",
        Typeface = (StringValue) "Euphemia"
      };
      SupplementalFont newChild79 = new SupplementalFont()
      {
        Script = (StringValue) "Cher",
        Typeface = (StringValue) "Plantagenet Cherokee"
      };
      SupplementalFont newChild80 = new SupplementalFont()
      {
        Script = (StringValue) "Yiii",
        Typeface = (StringValue) "Microsoft Yi Baiti"
      };
      SupplementalFont newChild81 = new SupplementalFont()
      {
        Script = (StringValue) "Tibt",
        Typeface = (StringValue) "Microsoft Himalaya"
      };
      SupplementalFont newChild82 = new SupplementalFont()
      {
        Script = (StringValue) "Thaa",
        Typeface = (StringValue) "MV Boli"
      };
      SupplementalFont newChild83 = new SupplementalFont()
      {
        Script = (StringValue) "Deva",
        Typeface = (StringValue) "Mangal"
      };
      SupplementalFont newChild84 = new SupplementalFont()
      {
        Script = (StringValue) "Telu",
        Typeface = (StringValue) "Gautami"
      };
      SupplementalFont newChild85 = new SupplementalFont()
      {
        Script = (StringValue) "Taml",
        Typeface = (StringValue) "Latha"
      };
      SupplementalFont newChild86 = new SupplementalFont()
      {
        Script = (StringValue) "Syrc",
        Typeface = (StringValue) "Estrangelo Edessa"
      };
      SupplementalFont newChild87 = new SupplementalFont()
      {
        Script = (StringValue) "Orya",
        Typeface = (StringValue) "Kalinga"
      };
      SupplementalFont newChild88 = new SupplementalFont()
      {
        Script = (StringValue) "Mlym",
        Typeface = (StringValue) "Kartika"
      };
      SupplementalFont newChild89 = new SupplementalFont()
      {
        Script = (StringValue) "Laoo",
        Typeface = (StringValue) "DokChampa"
      };
      SupplementalFont newChild90 = new SupplementalFont()
      {
        Script = (StringValue) "Sinh",
        Typeface = (StringValue) "Iskoola Pota"
      };
      SupplementalFont newChild91 = new SupplementalFont()
      {
        Script = (StringValue) "Mong",
        Typeface = (StringValue) "Mongolian Baiti"
      };
      SupplementalFont newChild92 = new SupplementalFont()
      {
        Script = (StringValue) "Viet",
        Typeface = (StringValue) "Arial"
      };
      SupplementalFont newChild93 = new SupplementalFont()
      {
        Script = (StringValue) "Uigh",
        Typeface = (StringValue) "Microsoft Uighur"
      };
      newChild61.AppendChild<LatinFont>(newChild62);
      newChild61.AppendChild<EastAsianFont>(newChild63);
      newChild61.AppendChild<ComplexScriptFont>(newChild64);
      newChild61.AppendChild<SupplementalFont>(newChild65);
      newChild61.AppendChild<SupplementalFont>(newChild66);
      newChild61.AppendChild<SupplementalFont>(newChild67);
      newChild61.AppendChild<SupplementalFont>(newChild68);
      newChild61.AppendChild<SupplementalFont>(newChild69);
      newChild61.AppendChild<SupplementalFont>(newChild70);
      newChild61.AppendChild<SupplementalFont>(newChild71);
      newChild61.AppendChild<SupplementalFont>(newChild72);
      newChild61.AppendChild<SupplementalFont>(newChild73);
      newChild61.AppendChild<SupplementalFont>(newChild74);
      newChild61.AppendChild<SupplementalFont>(newChild75);
      newChild61.AppendChild<SupplementalFont>(newChild76);
      newChild61.AppendChild<SupplementalFont>(newChild77);
      newChild61.AppendChild<SupplementalFont>(newChild78);
      newChild61.AppendChild<SupplementalFont>(newChild79);
      newChild61.AppendChild<SupplementalFont>(newChild80);
      newChild61.AppendChild<SupplementalFont>(newChild81);
      newChild61.AppendChild<SupplementalFont>(newChild82);
      newChild61.AppendChild<SupplementalFont>(newChild83);
      newChild61.AppendChild<SupplementalFont>(newChild84);
      newChild61.AppendChild<SupplementalFont>(newChild85);
      newChild61.AppendChild<SupplementalFont>(newChild86);
      newChild61.AppendChild<SupplementalFont>(newChild87);
      newChild61.AppendChild<SupplementalFont>(newChild88);
      newChild61.AppendChild<SupplementalFont>(newChild89);
      newChild61.AppendChild<SupplementalFont>(newChild90);
      newChild61.AppendChild<SupplementalFont>(newChild91);
      newChild61.AppendChild<SupplementalFont>(newChild92);
      newChild61.AppendChild<SupplementalFont>(newChild93);
      newChild27.AppendChild<MajorFont>(newChild28);
      newChild27.AppendChild<MinorFont>(newChild61);
      FormatScheme newChild94 = new FormatScheme()
      {
        Name = (StringValue) "Office"
      };
      FillStyleList newChild95 = new FillStyleList();
      SolidFill newChild96 = new SolidFill();
      SchemeColor newChild97 = new SchemeColor()
      {
        Val = (EnumValue<SchemeColorValues>) SchemeColorValues.PhColor
      };
      newChild96.AppendChild<SchemeColor>(newChild97);
      DocumentFormat.OpenXml.Drawing.GradientFill newChild98 = new DocumentFormat.OpenXml.Drawing.GradientFill()
      {
        RotateWithShape = (BooleanValue) true
      };
      GradientStopList newChild99 = new GradientStopList();
      DocumentFormat.OpenXml.Drawing.GradientStop newChild100 = new DocumentFormat.OpenXml.Drawing.GradientStop()
      {
        Position = (Int32Value) 0
      };
      SchemeColor newChild101 = new SchemeColor()
      {
        Val = (EnumValue<SchemeColorValues>) SchemeColorValues.PhColor
      };
      Tint tint1 = new Tint();
      tint1.Val = (Int32Value) 50000;
      Tint newChild102 = tint1;
      SaturationModulation saturationModulation1 = new SaturationModulation();
      saturationModulation1.Val = (Int32Value) 300000;
      SaturationModulation newChild103 = saturationModulation1;
      newChild101.AppendChild<Tint>(newChild102);
      newChild101.AppendChild<SaturationModulation>(newChild103);
      newChild100.AppendChild<SchemeColor>(newChild101);
      DocumentFormat.OpenXml.Drawing.GradientStop newChild104 = new DocumentFormat.OpenXml.Drawing.GradientStop()
      {
        Position = (Int32Value) 35000
      };
      SchemeColor newChild105 = new SchemeColor()
      {
        Val = (EnumValue<SchemeColorValues>) SchemeColorValues.PhColor
      };
      Tint tint2 = new Tint();
      tint2.Val = (Int32Value) 37000;
      Tint newChild106 = tint2;
      SaturationModulation saturationModulation2 = new SaturationModulation();
      saturationModulation2.Val = (Int32Value) 300000;
      SaturationModulation newChild107 = saturationModulation2;
      newChild105.AppendChild<Tint>(newChild106);
      newChild105.AppendChild<SaturationModulation>(newChild107);
      newChild104.AppendChild<SchemeColor>(newChild105);
      DocumentFormat.OpenXml.Drawing.GradientStop newChild108 = new DocumentFormat.OpenXml.Drawing.GradientStop()
      {
        Position = (Int32Value) 100000
      };
      SchemeColor newChild109 = new SchemeColor()
      {
        Val = (EnumValue<SchemeColorValues>) SchemeColorValues.PhColor
      };
      Tint tint3 = new Tint();
      tint3.Val = (Int32Value) 15000;
      Tint newChild110 = tint3;
      SaturationModulation saturationModulation3 = new SaturationModulation();
      saturationModulation3.Val = (Int32Value) 350000;
      SaturationModulation newChild111 = saturationModulation3;
      newChild109.AppendChild<Tint>(newChild110);
      newChild109.AppendChild<SaturationModulation>(newChild111);
      newChild108.AppendChild<SchemeColor>(newChild109);
      newChild99.AppendChild<DocumentFormat.OpenXml.Drawing.GradientStop>(newChild100);
      newChild99.AppendChild<DocumentFormat.OpenXml.Drawing.GradientStop>(newChild104);
      newChild99.AppendChild<DocumentFormat.OpenXml.Drawing.GradientStop>(newChild108);
      LinearGradientFill newChild112 = new LinearGradientFill()
      {
        Angle = (Int32Value) 16200000,
        Scaled = (BooleanValue) true
      };
      newChild98.AppendChild<GradientStopList>(newChild99);
      newChild98.AppendChild<LinearGradientFill>(newChild112);
      DocumentFormat.OpenXml.Drawing.GradientFill newChild113 = new DocumentFormat.OpenXml.Drawing.GradientFill()
      {
        RotateWithShape = (BooleanValue) true
      };
      GradientStopList newChild114 = new GradientStopList();
      DocumentFormat.OpenXml.Drawing.GradientStop newChild115 = new DocumentFormat.OpenXml.Drawing.GradientStop()
      {
        Position = (Int32Value) 0
      };
      SchemeColor newChild116 = new SchemeColor()
      {
        Val = (EnumValue<SchemeColorValues>) SchemeColorValues.PhColor
      };
      Shade shade1 = new Shade();
      shade1.Val = (Int32Value) 51000;
      Shade newChild117 = shade1;
      SaturationModulation saturationModulation4 = new SaturationModulation();
      saturationModulation4.Val = (Int32Value) 130000;
      SaturationModulation newChild118 = saturationModulation4;
      newChild116.AppendChild<Shade>(newChild117);
      newChild116.AppendChild<SaturationModulation>(newChild118);
      newChild115.AppendChild<SchemeColor>(newChild116);
      DocumentFormat.OpenXml.Drawing.GradientStop newChild119 = new DocumentFormat.OpenXml.Drawing.GradientStop()
      {
        Position = (Int32Value) 80000
      };
      SchemeColor newChild120 = new SchemeColor()
      {
        Val = (EnumValue<SchemeColorValues>) SchemeColorValues.PhColor
      };
      Shade shade2 = new Shade();
      shade2.Val = (Int32Value) 93000;
      Shade newChild121 = shade2;
      SaturationModulation saturationModulation5 = new SaturationModulation();
      saturationModulation5.Val = (Int32Value) 130000;
      SaturationModulation newChild122 = saturationModulation5;
      newChild120.AppendChild<Shade>(newChild121);
      newChild120.AppendChild<SaturationModulation>(newChild122);
      newChild119.AppendChild<SchemeColor>(newChild120);
      DocumentFormat.OpenXml.Drawing.GradientStop newChild123 = new DocumentFormat.OpenXml.Drawing.GradientStop()
      {
        Position = (Int32Value) 100000
      };
      SchemeColor newChild124 = new SchemeColor()
      {
        Val = (EnumValue<SchemeColorValues>) SchemeColorValues.PhColor
      };
      Shade shade3 = new Shade();
      shade3.Val = (Int32Value) 94000;
      Shade newChild125 = shade3;
      SaturationModulation saturationModulation6 = new SaturationModulation();
      saturationModulation6.Val = (Int32Value) 135000;
      SaturationModulation newChild126 = saturationModulation6;
      newChild124.AppendChild<Shade>(newChild125);
      newChild124.AppendChild<SaturationModulation>(newChild126);
      newChild123.AppendChild<SchemeColor>(newChild124);
      newChild114.AppendChild<DocumentFormat.OpenXml.Drawing.GradientStop>(newChild115);
      newChild114.AppendChild<DocumentFormat.OpenXml.Drawing.GradientStop>(newChild119);
      newChild114.AppendChild<DocumentFormat.OpenXml.Drawing.GradientStop>(newChild123);
      LinearGradientFill newChild127 = new LinearGradientFill()
      {
        Angle = (Int32Value) 16200000,
        Scaled = (BooleanValue) false
      };
      newChild113.AppendChild<GradientStopList>(newChild114);
      newChild113.AppendChild<LinearGradientFill>(newChild127);
      newChild95.AppendChild<SolidFill>(newChild96);
      newChild95.AppendChild<DocumentFormat.OpenXml.Drawing.GradientFill>(newChild98);
      newChild95.AppendChild<DocumentFormat.OpenXml.Drawing.GradientFill>(newChild113);
      LineStyleList newChild128 = new LineStyleList();
      DocumentFormat.OpenXml.Drawing.Outline outline1 = new DocumentFormat.OpenXml.Drawing.Outline();
      outline1.Width = (Int32Value) 9525;
      outline1.CapType = (EnumValue<LineCapValues>) LineCapValues.Flat;
      outline1.CompoundLineType = (EnumValue<CompoundLineValues>) CompoundLineValues.Single;
      outline1.Alignment = (EnumValue<PenAlignmentValues>) PenAlignmentValues.Center;
      DocumentFormat.OpenXml.Drawing.Outline newChild129 = outline1;
      SolidFill newChild130 = new SolidFill();
      SchemeColor newChild131 = new SchemeColor()
      {
        Val = (EnumValue<SchemeColorValues>) SchemeColorValues.PhColor
      };
      Shade shade4 = new Shade();
      shade4.Val = (Int32Value) 95000;
      Shade newChild132 = shade4;
      SaturationModulation saturationModulation7 = new SaturationModulation();
      saturationModulation7.Val = (Int32Value) 105000;
      SaturationModulation newChild133 = saturationModulation7;
      newChild131.AppendChild<Shade>(newChild132);
      newChild131.AppendChild<SaturationModulation>(newChild133);
      newChild130.AppendChild<SchemeColor>(newChild131);
      PresetDash newChild134 = new PresetDash()
      {
        Val = (EnumValue<PresetLineDashValues>) PresetLineDashValues.Solid
      };
      newChild129.AppendChild<SolidFill>(newChild130);
      newChild129.AppendChild<PresetDash>(newChild134);
      DocumentFormat.OpenXml.Drawing.Outline outline2 = new DocumentFormat.OpenXml.Drawing.Outline();
      outline2.Width = (Int32Value) 25400;
      outline2.CapType = (EnumValue<LineCapValues>) LineCapValues.Flat;
      outline2.CompoundLineType = (EnumValue<CompoundLineValues>) CompoundLineValues.Single;
      outline2.Alignment = (EnumValue<PenAlignmentValues>) PenAlignmentValues.Center;
      DocumentFormat.OpenXml.Drawing.Outline newChild135 = outline2;
      SolidFill newChild136 = new SolidFill();
      SchemeColor newChild137 = new SchemeColor()
      {
        Val = (EnumValue<SchemeColorValues>) SchemeColorValues.PhColor
      };
      newChild136.AppendChild<SchemeColor>(newChild137);
      PresetDash newChild138 = new PresetDash()
      {
        Val = (EnumValue<PresetLineDashValues>) PresetLineDashValues.Solid
      };
      newChild135.AppendChild<SolidFill>(newChild136);
      newChild135.AppendChild<PresetDash>(newChild138);
      DocumentFormat.OpenXml.Drawing.Outline outline3 = new DocumentFormat.OpenXml.Drawing.Outline();
      outline3.Width = (Int32Value) 38100;
      outline3.CapType = (EnumValue<LineCapValues>) LineCapValues.Flat;
      outline3.CompoundLineType = (EnumValue<CompoundLineValues>) CompoundLineValues.Single;
      outline3.Alignment = (EnumValue<PenAlignmentValues>) PenAlignmentValues.Center;
      DocumentFormat.OpenXml.Drawing.Outline newChild139 = outline3;
      SolidFill newChild140 = new SolidFill();
      SchemeColor newChild141 = new SchemeColor()
      {
        Val = (EnumValue<SchemeColorValues>) SchemeColorValues.PhColor
      };
      newChild140.AppendChild<SchemeColor>(newChild141);
      PresetDash newChild142 = new PresetDash()
      {
        Val = (EnumValue<PresetLineDashValues>) PresetLineDashValues.Solid
      };
      newChild139.AppendChild<SolidFill>(newChild140);
      newChild139.AppendChild<PresetDash>(newChild142);
      newChild128.AppendChild<DocumentFormat.OpenXml.Drawing.Outline>(newChild129);
      newChild128.AppendChild<DocumentFormat.OpenXml.Drawing.Outline>(newChild135);
      newChild128.AppendChild<DocumentFormat.OpenXml.Drawing.Outline>(newChild139);
      EffectStyleList newChild143 = new EffectStyleList();
      EffectStyle newChild144 = new EffectStyle();
      EffectList newChild145 = new EffectList();
      OuterShadow newChild146 = new OuterShadow()
      {
        BlurRadius = (Int64Value) 40000L,
        Distance = (Int64Value) 20000L,
        Direction = (Int32Value) 5400000,
        RotateWithShape = (BooleanValue) false
      };
      RgbColorModelHex newChild147 = new RgbColorModelHex()
      {
        Val = (HexBinaryValue) "000000"
      };
      Alpha alpha1 = new Alpha();
      alpha1.Val = (Int32Value) 38000;
      Alpha newChild148 = alpha1;
      newChild147.AppendChild<Alpha>(newChild148);
      newChild146.AppendChild<RgbColorModelHex>(newChild147);
      newChild145.AppendChild<OuterShadow>(newChild146);
      newChild144.AppendChild<EffectList>(newChild145);
      EffectStyle newChild149 = new EffectStyle();
      EffectList newChild150 = new EffectList();
      OuterShadow newChild151 = new OuterShadow()
      {
        BlurRadius = (Int64Value) 40000L,
        Distance = (Int64Value) 23000L,
        Direction = (Int32Value) 5400000,
        RotateWithShape = (BooleanValue) false
      };
      RgbColorModelHex newChild152 = new RgbColorModelHex()
      {
        Val = (HexBinaryValue) "000000"
      };
      Alpha alpha2 = new Alpha();
      alpha2.Val = (Int32Value) 35000;
      Alpha newChild153 = alpha2;
      newChild152.AppendChild<Alpha>(newChild153);
      newChild151.AppendChild<RgbColorModelHex>(newChild152);
      newChild150.AppendChild<OuterShadow>(newChild151);
      newChild149.AppendChild<EffectList>(newChild150);
      EffectStyle newChild154 = new EffectStyle();
      EffectList newChild155 = new EffectList();
      OuterShadow newChild156 = new OuterShadow()
      {
        BlurRadius = (Int64Value) 40000L,
        Distance = (Int64Value) 23000L,
        Direction = (Int32Value) 5400000,
        RotateWithShape = (BooleanValue) false
      };
      RgbColorModelHex newChild157 = new RgbColorModelHex()
      {
        Val = (HexBinaryValue) "000000"
      };
      Alpha alpha3 = new Alpha();
      alpha3.Val = (Int32Value) 35000;
      Alpha newChild158 = alpha3;
      newChild157.AppendChild<Alpha>(newChild158);
      newChild156.AppendChild<RgbColorModelHex>(newChild157);
      newChild155.AppendChild<OuterShadow>(newChild156);
      Scene3DType newChild159 = new Scene3DType();
      Camera newChild160 = new Camera()
      {
        Preset = (EnumValue<PresetCameraValues>) PresetCameraValues.OrthographicFront
      };
      Rotation newChild161 = new Rotation()
      {
        Latitude = (Int32Value) 0,
        Longitude = (Int32Value) 0,
        Revolution = (Int32Value) 0
      };
      newChild160.AppendChild<Rotation>(newChild161);
      LightRig newChild162 = new LightRig()
      {
        Rig = (EnumValue<LightRigValues>) LightRigValues.ThreePoints,
        Direction = (EnumValue<LightRigDirectionValues>) LightRigDirectionValues.Top
      };
      Rotation newChild163 = new Rotation()
      {
        Latitude = (Int32Value) 0,
        Longitude = (Int32Value) 0,
        Revolution = (Int32Value) 1200000
      };
      newChild162.AppendChild<Rotation>(newChild163);
      newChild159.AppendChild<Camera>(newChild160);
      newChild159.AppendChild<LightRig>(newChild162);
      Shape3DType newChild164 = new Shape3DType();
      BevelTop bevelTop = new BevelTop();
      bevelTop.Width = (Int64Value) 63500L;
      bevelTop.Height = (Int64Value) 25400L;
      BevelTop newChild165 = bevelTop;
      newChild164.AppendChild<BevelTop>(newChild165);
      newChild154.AppendChild<EffectList>(newChild155);
      newChild154.AppendChild<Scene3DType>(newChild159);
      newChild154.AppendChild<Shape3DType>(newChild164);
      newChild143.AppendChild<EffectStyle>(newChild144);
      newChild143.AppendChild<EffectStyle>(newChild149);
      newChild143.AppendChild<EffectStyle>(newChild154);
      BackgroundFillStyleList newChild166 = new BackgroundFillStyleList();
      SolidFill newChild167 = new SolidFill();
      SchemeColor newChild168 = new SchemeColor()
      {
        Val = (EnumValue<SchemeColorValues>) SchemeColorValues.PhColor
      };
      newChild167.AppendChild<SchemeColor>(newChild168);
      DocumentFormat.OpenXml.Drawing.GradientFill newChild169 = new DocumentFormat.OpenXml.Drawing.GradientFill()
      {
        RotateWithShape = (BooleanValue) true
      };
      GradientStopList newChild170 = new GradientStopList();
      DocumentFormat.OpenXml.Drawing.GradientStop newChild171 = new DocumentFormat.OpenXml.Drawing.GradientStop()
      {
        Position = (Int32Value) 0
      };
      SchemeColor newChild172 = new SchemeColor()
      {
        Val = (EnumValue<SchemeColorValues>) SchemeColorValues.PhColor
      };
      Tint tint4 = new Tint();
      tint4.Val = (Int32Value) 40000;
      Tint newChild173 = tint4;
      SaturationModulation saturationModulation8 = new SaturationModulation();
      saturationModulation8.Val = (Int32Value) 350000;
      SaturationModulation newChild174 = saturationModulation8;
      newChild172.AppendChild<Tint>(newChild173);
      newChild172.AppendChild<SaturationModulation>(newChild174);
      newChild171.AppendChild<SchemeColor>(newChild172);
      DocumentFormat.OpenXml.Drawing.GradientStop newChild175 = new DocumentFormat.OpenXml.Drawing.GradientStop()
      {
        Position = (Int32Value) 40000
      };
      SchemeColor newChild176 = new SchemeColor()
      {
        Val = (EnumValue<SchemeColorValues>) SchemeColorValues.PhColor
      };
      Tint tint5 = new Tint();
      tint5.Val = (Int32Value) 45000;
      Tint newChild177 = tint5;
      Shade shade5 = new Shade();
      shade5.Val = (Int32Value) 99000;
      Shade newChild178 = shade5;
      SaturationModulation saturationModulation9 = new SaturationModulation();
      saturationModulation9.Val = (Int32Value) 350000;
      SaturationModulation newChild179 = saturationModulation9;
      newChild176.AppendChild<Tint>(newChild177);
      newChild176.AppendChild<Shade>(newChild178);
      newChild176.AppendChild<SaturationModulation>(newChild179);
      newChild175.AppendChild<SchemeColor>(newChild176);
      DocumentFormat.OpenXml.Drawing.GradientStop newChild180 = new DocumentFormat.OpenXml.Drawing.GradientStop()
      {
        Position = (Int32Value) 100000
      };
      SchemeColor newChild181 = new SchemeColor()
      {
        Val = (EnumValue<SchemeColorValues>) SchemeColorValues.PhColor
      };
      Shade shade6 = new Shade();
      shade6.Val = (Int32Value) 20000;
      Shade newChild182 = shade6;
      SaturationModulation saturationModulation10 = new SaturationModulation();
      saturationModulation10.Val = (Int32Value) 255000;
      SaturationModulation newChild183 = saturationModulation10;
      newChild181.AppendChild<Shade>(newChild182);
      newChild181.AppendChild<SaturationModulation>(newChild183);
      newChild180.AppendChild<SchemeColor>(newChild181);
      newChild170.AppendChild<DocumentFormat.OpenXml.Drawing.GradientStop>(newChild171);
      newChild170.AppendChild<DocumentFormat.OpenXml.Drawing.GradientStop>(newChild175);
      newChild170.AppendChild<DocumentFormat.OpenXml.Drawing.GradientStop>(newChild180);
      PathGradientFill newChild184 = new PathGradientFill()
      {
        Path = (EnumValue<PathShadeValues>) PathShadeValues.Circle
      };
      FillToRectangle fillToRectangle1 = new FillToRectangle();
      fillToRectangle1.Left = (Int32Value) 50000;
      fillToRectangle1.Top = (Int32Value) -80000;
      fillToRectangle1.Right = (Int32Value) 50000;
      fillToRectangle1.Bottom = (Int32Value) 180000;
      FillToRectangle newChild185 = fillToRectangle1;
      newChild184.AppendChild<FillToRectangle>(newChild185);
      newChild169.AppendChild<GradientStopList>(newChild170);
      newChild169.AppendChild<PathGradientFill>(newChild184);
      DocumentFormat.OpenXml.Drawing.GradientFill newChild186 = new DocumentFormat.OpenXml.Drawing.GradientFill()
      {
        RotateWithShape = (BooleanValue) true
      };
      GradientStopList newChild187 = new GradientStopList();
      DocumentFormat.OpenXml.Drawing.GradientStop newChild188 = new DocumentFormat.OpenXml.Drawing.GradientStop()
      {
        Position = (Int32Value) 0
      };
      SchemeColor newChild189 = new SchemeColor()
      {
        Val = (EnumValue<SchemeColorValues>) SchemeColorValues.PhColor
      };
      Tint tint6 = new Tint();
      tint6.Val = (Int32Value) 80000;
      Tint newChild190 = tint6;
      SaturationModulation saturationModulation11 = new SaturationModulation();
      saturationModulation11.Val = (Int32Value) 300000;
      SaturationModulation newChild191 = saturationModulation11;
      newChild189.AppendChild<Tint>(newChild190);
      newChild189.AppendChild<SaturationModulation>(newChild191);
      newChild188.AppendChild<SchemeColor>(newChild189);
      DocumentFormat.OpenXml.Drawing.GradientStop newChild192 = new DocumentFormat.OpenXml.Drawing.GradientStop()
      {
        Position = (Int32Value) 100000
      };
      SchemeColor newChild193 = new SchemeColor()
      {
        Val = (EnumValue<SchemeColorValues>) SchemeColorValues.PhColor
      };
      Shade shade7 = new Shade();
      shade7.Val = (Int32Value) 30000;
      Shade newChild194 = shade7;
      SaturationModulation saturationModulation12 = new SaturationModulation();
      saturationModulation12.Val = (Int32Value) 200000;
      SaturationModulation newChild195 = saturationModulation12;
      newChild193.AppendChild<Shade>(newChild194);
      newChild193.AppendChild<SaturationModulation>(newChild195);
      newChild192.AppendChild<SchemeColor>(newChild193);
      newChild187.AppendChild<DocumentFormat.OpenXml.Drawing.GradientStop>(newChild188);
      newChild187.AppendChild<DocumentFormat.OpenXml.Drawing.GradientStop>(newChild192);
      PathGradientFill newChild196 = new PathGradientFill()
      {
        Path = (EnumValue<PathShadeValues>) PathShadeValues.Circle
      };
      FillToRectangle fillToRectangle2 = new FillToRectangle();
      fillToRectangle2.Left = (Int32Value) 50000;
      fillToRectangle2.Top = (Int32Value) 50000;
      fillToRectangle2.Right = (Int32Value) 50000;
      fillToRectangle2.Bottom = (Int32Value) 50000;
      FillToRectangle newChild197 = fillToRectangle2;
      newChild196.AppendChild<FillToRectangle>(newChild197);
      newChild186.AppendChild<GradientStopList>(newChild187);
      newChild186.AppendChild<PathGradientFill>(newChild196);
      newChild166.AppendChild<SolidFill>(newChild167);
      newChild166.AppendChild<DocumentFormat.OpenXml.Drawing.GradientFill>(newChild169);
      newChild166.AppendChild<DocumentFormat.OpenXml.Drawing.GradientFill>(newChild186);
      newChild94.AppendChild<FillStyleList>(newChild95);
      newChild94.AppendChild<LineStyleList>(newChild128);
      newChild94.AppendChild<EffectStyleList>(newChild143);
      newChild94.AppendChild<BackgroundFillStyleList>(newChild166);
      newChild1.AppendChild<ColorScheme>(newChild2);
      newChild1.AppendChild<DocumentFormat.OpenXml.Drawing.FontScheme>(newChild27);
      newChild1.AppendChild<FormatScheme>(newChild94);
      ObjectDefaults newChild198 = new ObjectDefaults();
      ExtraColorSchemeList newChild199 = new ExtraColorSchemeList();
      theme.AppendChild<ThemeElements>(newChild1);
      theme.AppendChild<ObjectDefaults>(newChild198);
      theme.AppendChild<ExtraColorSchemeList>(newChild199);
      themePart.Theme = theme;
    }

    private void GenerateCustomFilePropertiesPartContent(CustomFilePropertiesPart customFilePropertiesPart1)
    {
      DocumentFormat.OpenXml.CustomProperties.Properties properties = new DocumentFormat.OpenXml.CustomProperties.Properties();
      properties.AddNamespaceDeclaration("vt", "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes");
      int num = 1;
      foreach (IXLCustomProperty customProperty in (IEnumerable<IXLCustomProperty>) this.CustomProperties)
      {
        ++num;
        CustomDocumentProperty newChild1 = new CustomDocumentProperty()
        {
          FormatId = (StringValue) "{D5CDD505-2E9C-101B-9397-08002B2CF9AE}",
          PropertyId = (Int32Value) num,
          Name = (StringValue) customProperty.Name
        };
        if (customProperty.Type == XLCustomPropertyType.Text)
        {
          VTLPWSTR vtlpwstr = new VTLPWSTR();
          vtlpwstr.Text = customProperty.GetValue<string>();
          VTLPWSTR newChild2 = vtlpwstr;
          newChild1.AppendChild<VTLPWSTR>(newChild2);
        }
        else if (customProperty.Type == XLCustomPropertyType.Date)
        {
          VTFileTime vtFileTime = new VTFileTime();
          vtFileTime.Text = customProperty.GetValue<DateTime>().ToUniversalTime().ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'Z'");
          VTFileTime newChild2 = vtFileTime;
          newChild1.AppendChild<VTFileTime>(newChild2);
        }
        else if (customProperty.Type == XLCustomPropertyType.Number)
        {
          VTDouble vtDouble = new VTDouble();
          vtDouble.Text = customProperty.GetValue<double>().ToString((IFormatProvider) CultureInfo.InvariantCulture);
          VTDouble newChild2 = vtDouble;
          newChild1.AppendChild<VTDouble>(newChild2);
        }
        else
        {
          VTBool vtBool = new VTBool();
          vtBool.Text = customProperty.GetValue<bool>().ToString().ToLower();
          VTBool newChild2 = vtBool;
          newChild1.AppendChild<VTBool>(newChild2);
        }
        properties.AppendChild<CustomDocumentProperty>(newChild1);
      }
      customFilePropertiesPart1.Properties = properties;
    }

    private void SetPackageProperties(OpenXmlPackage document)
    {
      DateTime dateTime1 = this.Properties.Created == DateTime.MinValue ? DateTime.Now : this.Properties.Created;
      DateTime dateTime2 = this.Properties.Modified == DateTime.MinValue ? DateTime.Now : this.Properties.Modified;
      document.PackageProperties.Created = new DateTime?(dateTime1);
      document.PackageProperties.Modified = new DateTime?(dateTime2);
      document.PackageProperties.LastModifiedBy = this.Properties.LastModifiedBy;
      document.PackageProperties.Creator = this.Properties.Author;
      document.PackageProperties.Title = this.Properties.Title;
      document.PackageProperties.Subject = this.Properties.Subject;
      document.PackageProperties.Category = this.Properties.Category;
      document.PackageProperties.Keywords = this.Properties.Keywords;
      document.PackageProperties.Description = this.Properties.Comments;
      document.PackageProperties.ContentStatus = this.Properties.Status;
    }

    private static string GetTableName(string originalTableName, XLWorkbook.SaveContext context)
    {
      string str1 = originalTableName.RemoveSpecialCharacters();
      string str2 = str1;
      if (context.TableNames.Contains(str2))
      {
        int num = 1;
        for (str2 = str1 + num.ToInvariantString(); context.TableNames.Contains(str2); str2 = str1 + num.ToInvariantString())
          ++num;
      }
      context.TableNames.Add(str2);
      return str2;
    }

    private static void GenerateTableDefinitionPartContent(TableDefinitionPart tableDefinitionPart, XLTable xlTable, XLWorkbook.SaveContext context)
    {
      ++context.TableId;
      string str = xlTable.RangeAddress.FirstAddress.ToString() + ":" + (object) xlTable.RangeAddress.LastAddress;
      string tableName = XLWorkbook.GetTableName(xlTable.Name, context);
      DocumentFormat.OpenXml.Spreadsheet.Table table = new DocumentFormat.OpenXml.Spreadsheet.Table()
      {
        Id = (UInt32Value) context.TableId,
        Name = (StringValue) tableName,
        DisplayName = (StringValue) tableName,
        Reference = (StringValue) str
      };
      if (!xlTable.ShowHeaderRow)
        table.HeaderRowCount = (UInt32Value) 0U;
      if (xlTable.ShowTotalsRow)
        table.TotalsRowCount = (UInt32Value) 1U;
      else
        table.TotalsRowShown = (BooleanValue) false;
      TableColumns newChild1 = new TableColumns()
      {
        Count = (UInt32Value) ((uint) xlTable.ColumnCount())
      };
      uint num = 0;
      foreach (IXLTableField field in xlTable.Fields)
      {
        ++num;
        string name = field.Name;
        TableColumn newChild2 = new TableColumn()
        {
          Id = (UInt32Value) num,
          Name = (StringValue) name.Replace("_x000a_", "_x005f_x000a_").Replace(Environment.NewLine, "_x000a_")
        };
        if (xlTable.ShowTotalsRow)
        {
          if (field.TotalsRowFunction != XLTotalsRowFunction.None)
          {
            newChild2.TotalsRowFunction = (EnumValue<TotalsRowFunctionValues>) field.TotalsRowFunction.ToOpenXml();
            if (field.TotalsRowFunction == XLTotalsRowFunction.Custom)
              newChild2.TotalsRowFormula = new TotalsRowFormula(field.TotalsRowFormulaA1);
          }
          if (!XLHelper.IsNullOrWhiteSpace(field.TotalsRowLabel))
            newChild2.TotalsRowLabel = (StringValue) field.TotalsRowLabel;
        }
        newChild1.AppendChild<TableColumn>(newChild2);
      }
      TableStyleInfo newChild3 = new TableStyleInfo()
      {
        ShowFirstColumn = (BooleanValue) xlTable.EmphasizeFirstColumn,
        ShowLastColumn = (BooleanValue) xlTable.EmphasizeLastColumn,
        ShowRowStripes = (BooleanValue) xlTable.ShowRowStripes,
        ShowColumnStripes = (BooleanValue) xlTable.ShowColumnStripes
      };
      if (xlTable.Theme != XLTableTheme.None)
        newChild3.Name = (StringValue) Enum.GetName(typeof (XLTableTheme), (object) xlTable.Theme);
      if (xlTable.ShowAutoFilter)
      {
        AutoFilter autoFilter = new AutoFilter();
        xlTable.AutoFilter.Range = !xlTable.ShowTotalsRow ? (IXLRange) xlTable.Worksheet.Range((IXLRangeAddress) xlTable.RangeAddress) : (IXLRange) xlTable.Worksheet.Range(xlTable.RangeAddress.FirstAddress.RowNumber, xlTable.RangeAddress.FirstAddress.ColumnNumber, xlTable.RangeAddress.LastAddress.RowNumber - 1, xlTable.RangeAddress.LastAddress.ColumnNumber);
        XLWorkbook.PopulateAutoFilter(xlTable.AutoFilter, autoFilter);
        table.AppendChild<AutoFilter>(autoFilter);
      }
      table.AppendChild<TableColumns>(newChild1);
      table.AppendChild<TableStyleInfo>(newChild3);
      tableDefinitionPart.Table = table;
    }

    private static void GeneratePivotTables(WorkbookPart workbookPart, WorksheetPart worksheetPart, XLWorksheet xlWorksheet, XLWorkbook.SaveContext context)
    {
      foreach (IXLPivotTable pivotTable in (IEnumerable<IXLPivotTable>) xlWorksheet.PivotTables)
      {
        string next = context.RelIdGenerator.GetNext(XLWorkbook.RelType.Workbook);
        PivotTableCacheDefinitionPart cacheDefinitionPart = workbookPart.AddNewPart<PivotTableCacheDefinitionPart>(next);
        XLWorkbook.GeneratePivotTableCacheDefinitionPartContent(cacheDefinitionPart, pivotTable);
        DocumentFormat.OpenXml.Spreadsheet.PivotCaches newChild1 = new DocumentFormat.OpenXml.Spreadsheet.PivotCaches();
        PivotCache newChild2 = new PivotCache()
        {
          CacheId = (UInt32Value) 0U,
          Id = (StringValue) next
        };
        newChild1.AppendChild<PivotCache>(newChild2);
        workbookPart.Workbook.AppendChild<DocumentFormat.OpenXml.Spreadsheet.PivotCaches>(newChild1);
        PivotTablePart pivotTablePart1 = worksheetPart.AddNewPart<PivotTablePart>(context.RelIdGenerator.GetNext(XLWorkbook.RelType.Workbook));
        XLWorkbook.GeneratePivotTablePartContent(pivotTablePart1, pivotTable);
        pivotTablePart1.AddPart<PivotTableCacheDefinitionPart>(cacheDefinitionPart, context.RelIdGenerator.GetNext(XLWorkbook.RelType.Workbook));
      }
    }

    private static void GeneratePivotTableCacheDefinitionPartContent(PivotTableCacheDefinitionPart pivotTableCacheDefinitionPart, IXLPivotTable pt)
    {
      IXLRange source = pt.SourceRange;
      DocumentFormat.OpenXml.Spreadsheet.PivotCacheDefinition pivotCacheDefinition = new DocumentFormat.OpenXml.Spreadsheet.PivotCacheDefinition()
      {
        Id = (StringValue) "rId1",
        SaveData = (BooleanValue) pt.SaveSourceData,
        RefreshOnLoad = (BooleanValue) true
      };
      if (pt.ItemsToRetainPerField == XLItemsToRetain.None)
        pivotCacheDefinition.MissingItemsLimit = (UInt32Value) 0U;
      else if (pt.ItemsToRetainPerField == XLItemsToRetain.Max)
        pivotCacheDefinition.MissingItemsLimit = (UInt32Value) 1048576U;
      pivotCacheDefinition.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
      CacheSource newChild1 = new CacheSource()
      {
        Type = (EnumValue<SourceValues>) SourceValues.Worksheet
      };
      newChild1.AppendChild<WorksheetSource>(new WorksheetSource()
      {
        Name = (StringValue) source.ToString()
      });
      CacheFields newChild2 = new CacheFields();
      foreach (IXLRangeColumn column in (IEnumerable<IXLRangeColumn>) source.Columns((Func<IXLRangeColumn, bool>) null))
      {
        int columnNumber = column.ColumnNumber();
        string columnName = column.FirstCell().Value.ToString();
        IXLPivotField xlpf = pt.Fields.Add(columnName);
        IXLPivotField xlPivotField = pt.RowLabels.Union<IXLPivotField>((IEnumerable<IXLPivotField>) pt.ColumnLabels).Union<IXLPivotField>((IEnumerable<IXLPivotField>) pt.ReportFilters).FirstOrDefault<IXLPivotField>((Func<IXLPivotField, bool>) (f => f.SourceName == columnName));
        if (xlPivotField != null)
        {
          xlpf.CustomName = xlPivotField.CustomName;
          xlpf.Subtotals.AddRange((IEnumerable<XLSubtotalFunction>) xlPivotField.Subtotals);
        }
        SharedItems newChild3 = new SharedItems();
        if (!source.Cells().Any<IXLCell>((Func<IXLCell, bool>) (cell =>
        {
          if (cell.Address.ColumnNumber == columnNumber && cell.Address.RowNumber > source.FirstRow((Func<IXLRangeRow, bool>) null).RowNumber())
            return cell.DataType != XLCellValues.Number;
          return false;
        })))
        {
          newChild3 = new SharedItems()
          {
            ContainsSemiMixedTypes = (BooleanValue) false,
            ContainsString = (BooleanValue) false,
            ContainsNumber = (BooleanValue) true
          };
        }
        else
        {
          foreach (string str in source.Cells().Where<IXLCell>((Func<IXLCell, bool>) (cell =>
          {
            if (cell.Address.ColumnNumber == columnNumber)
              return cell.Address.RowNumber > source.FirstRow((Func<IXLRangeRow, bool>) null).RowNumber();
            return false;
          })).Select<IXLCell, string>((Func<IXLCell, string>) (cell => cell.Value.ToString())).Where<string>((Func<string, bool>) (cellValue => !xlpf.SharedStrings.Contains(cellValue))))
            xlpf.SharedStrings.Add(str);
          foreach (string sharedString in xlpf.SharedStrings)
            newChild3.AppendChild<StringItem>(new StringItem()
            {
              Val = (StringValue) sharedString
            });
        }
        DocumentFormat.OpenXml.Spreadsheet.CacheField newChild4 = new DocumentFormat.OpenXml.Spreadsheet.CacheField()
        {
          Name = (StringValue) xlpf.SourceName
        };
        newChild4.AppendChild<SharedItems>(newChild3);
        newChild2.AppendChild<DocumentFormat.OpenXml.Spreadsheet.CacheField>(newChild4);
      }
      pivotCacheDefinition.AppendChild<CacheSource>(newChild1);
      pivotCacheDefinition.AppendChild<CacheFields>(newChild2);
      pivotTableCacheDefinitionPart.PivotCacheDefinition = pivotCacheDefinition;
      PivotTableCacheRecordsPart cacheRecordsPart = pivotTableCacheDefinitionPart.AddNewPart<PivotTableCacheRecordsPart>("rId1");
      PivotCacheRecords pivotCacheRecords = new PivotCacheRecords();
      pivotCacheRecords.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
      cacheRecordsPart.PivotCacheRecords = pivotCacheRecords;
    }

    private static void GeneratePivotTablePartContent(PivotTablePart pivotTablePart1, IXLPivotTable pt)
    {
      DocumentFormat.OpenXml.Spreadsheet.PivotTableDefinition pivotTableDefinition = new DocumentFormat.OpenXml.Spreadsheet.PivotTableDefinition()
      {
        Name = (StringValue) pt.Name,
        CacheId = (UInt32Value) 0U,
        DataCaption = (StringValue) "Values",
        MergeItem = XLWorkbook.GetBooleanValue(pt.MergeAndCenterWithLabels, true),
        Indent = (UInt32Value) Convert.ToUInt32(pt.RowLabelIndent),
        PageOverThenDown = (BooleanValue) (pt.FilterAreaOrder == XLFilterAreaOrder.OverThenDown),
        PageWrap = (UInt32Value) Convert.ToUInt32(pt.FilterFieldsPageWrap),
        ShowError = (BooleanValue) string.IsNullOrEmpty(pt.ErrorValueReplacement),
        UseAutoFormatting = XLWorkbook.GetBooleanValue(pt.AutofitColumns, true),
        PreserveFormatting = XLWorkbook.GetBooleanValue(pt.PreserveCellFormatting, true),
        RowGrandTotals = XLWorkbook.GetBooleanValue(pt.ShowGrandTotalsRows, true),
        ColumnGrandTotals = XLWorkbook.GetBooleanValue(pt.ShowGrandTotalsColumns, true),
        SubtotalHiddenItems = XLWorkbook.GetBooleanValue(pt.FilteredItemsInSubtotals, true),
        MultipleFieldFilters = XLWorkbook.GetBooleanValue(pt.AllowMultipleFilters, true),
        CustomListSort = XLWorkbook.GetBooleanValue(pt.UseCustomListsForSorting, true),
        ShowDrill = XLWorkbook.GetBooleanValue(pt.ShowExpandCollapseButtons, true),
        ShowDataTips = XLWorkbook.GetBooleanValue(pt.ShowContextualTooltips, true),
        ShowMemberPropertyTips = XLWorkbook.GetBooleanValue(pt.ShowPropertiesInTooltips, true),
        ShowHeaders = XLWorkbook.GetBooleanValue(pt.DisplayCaptionsAndDropdowns, true),
        GridDropZones = XLWorkbook.GetBooleanValue(pt.ClassicPivotTableLayout, true),
        ShowEmptyRow = XLWorkbook.GetBooleanValue(pt.ShowEmptyItemsOnRows, true),
        ShowEmptyColumn = XLWorkbook.GetBooleanValue(pt.ShowEmptyItemsOnColumns, true),
        ShowItems = XLWorkbook.GetBooleanValue(pt.DisplayItemLabels, true),
        FieldListSortAscending = XLWorkbook.GetBooleanValue(pt.SortFieldsAtoZ, true),
        PrintDrill = XLWorkbook.GetBooleanValue(pt.PrintExpandCollapsedButtons, true),
        ItemPrintTitles = XLWorkbook.GetBooleanValue(pt.RepeatRowLabels, true),
        FieldPrintTitles = XLWorkbook.GetBooleanValue(pt.PrintTitles, true),
        EnableDrill = XLWorkbook.GetBooleanValue(pt.EnableShowDetails, true)
      };
      if (pt.EmptyCellReplacement != null)
      {
        pivotTableDefinition.ShowMissing = (BooleanValue) true;
        pivotTableDefinition.MissingCaption = (StringValue) pt.EmptyCellReplacement;
      }
      else
        pivotTableDefinition.ShowMissing = (BooleanValue) false;
      if (pt.ErrorValueReplacement != null)
      {
        pivotTableDefinition.ShowError = (BooleanValue) true;
        pivotTableDefinition.ErrorCaption = (StringValue) pt.ErrorValueReplacement;
      }
      else
        pivotTableDefinition.ShowError = (BooleanValue) false;
      Location newChild1 = new Location()
      {
        Reference = (StringValue) pt.TargetCell.Address.ToString(),
        FirstHeaderRow = (UInt32Value) 1U,
        FirstDataRow = (UInt32Value) 1U,
        FirstDataColumn = (UInt32Value) 1U
      };
      RowFields newChild2 = new RowFields();
      ColumnFields newChild3 = new ColumnFields();
      RowItems newChild4 = new RowItems();
      ColumnItems newChild5 = new ColumnItems();
      PageFields newChild6 = new PageFields()
      {
        Count = (UInt32Value) ((uint) pt.ReportFilters.Count<IXLPivotField>())
      };
      PivotFields newChild7 = new PivotFields()
      {
        Count = (UInt32Value) Convert.ToUInt32(pt.SourceRange.ColumnCount())
      };
      foreach (IXLPivotField xlPivotField in (IEnumerable<IXLPivotField>) pt.Fields.OrderBy<IXLPivotField, int>((Func<IXLPivotField, int>) (f =>
      {
        if (!pt.RowLabels.Any<IXLPivotField>((Func<IXLPivotField, bool>) (p => p.SourceName == f.SourceName)))
          return int.MaxValue;
        return pt.RowLabels.IndexOf(f);
      })))
      {
        IXLPivotField xlpf = xlPivotField;
        if (pt.RowLabels.FirstOrDefault<IXLPivotField>((Func<IXLPivotField, bool>) (p => p.SourceName == xlpf.SourceName)) != null)
        {
          DocumentFormat.OpenXml.Spreadsheet.Field newChild8 = new DocumentFormat.OpenXml.Spreadsheet.Field()
          {
            Index = (Int32Value) pt.Fields.IndexOf(xlpf)
          };
          newChild2.AppendChild<DocumentFormat.OpenXml.Spreadsheet.Field>(newChild8);
          for (int index = 0; index < xlpf.SharedStrings.Count; ++index)
          {
            RowItem newChild9 = new RowItem();
            RowItem rowItem = newChild9;
            MemberPropertyIndex memberPropertyIndex = new MemberPropertyIndex();
            memberPropertyIndex.Val = (Int32Value) index;
            MemberPropertyIndex newChild10 = memberPropertyIndex;
            rowItem.AppendChild<MemberPropertyIndex>(newChild10);
            newChild4.AppendChild<RowItem>(newChild9);
          }
          RowItem newChild11 = new RowItem()
          {
            ItemType = (EnumValue<ItemValues>) ItemValues.Grand
          };
          newChild11.AppendChild<MemberPropertyIndex>(new MemberPropertyIndex());
          newChild4.AppendChild<RowItem>(newChild11);
        }
        else if (pt.ColumnLabels.FirstOrDefault<IXLPivotField>((Func<IXLPivotField, bool>) (p => p.SourceName == xlpf.SourceName)) != null)
        {
          DocumentFormat.OpenXml.Spreadsheet.Field newChild8 = new DocumentFormat.OpenXml.Spreadsheet.Field()
          {
            Index = (Int32Value) pt.Fields.IndexOf(xlpf)
          };
          newChild3.AppendChild<DocumentFormat.OpenXml.Spreadsheet.Field>(newChild8);
          for (int index = 0; index < xlpf.SharedStrings.Count; ++index)
          {
            RowItem newChild9 = new RowItem();
            RowItem rowItem = newChild9;
            MemberPropertyIndex memberPropertyIndex = new MemberPropertyIndex();
            memberPropertyIndex.Val = (Int32Value) index;
            MemberPropertyIndex newChild10 = memberPropertyIndex;
            rowItem.AppendChild<MemberPropertyIndex>(newChild10);
            newChild5.AppendChild<RowItem>(newChild9);
          }
          RowItem newChild11 = new RowItem()
          {
            ItemType = (EnumValue<ItemValues>) ItemValues.Grand
          };
          newChild11.AppendChild<MemberPropertyIndex>(new MemberPropertyIndex());
          newChild5.AppendChild<RowItem>(newChild11);
        }
      }
      foreach (IXLPivotField field in (IEnumerable<IXLPivotField>) pt.Fields)
      {
        IXLPivotField xlpf = field;
        DocumentFormat.OpenXml.Spreadsheet.PivotField newChild8 = new DocumentFormat.OpenXml.Spreadsheet.PivotField()
        {
          ShowAll = (BooleanValue) false,
          Name = (StringValue) xlpf.CustomName
        };
        if (pt.RowLabels.FirstOrDefault<IXLPivotField>((Func<IXLPivotField, bool>) (p => p.SourceName == xlpf.SourceName)) != null)
          newChild8.Axis = (EnumValue<PivotTableAxisValues>) PivotTableAxisValues.AxisRow;
        else if (pt.ColumnLabels.FirstOrDefault<IXLPivotField>((Func<IXLPivotField, bool>) (p => p.SourceName == xlpf.SourceName)) != null)
          newChild8.Axis = (EnumValue<PivotTableAxisValues>) PivotTableAxisValues.AxisColumn;
        else if (pt.ReportFilters.FirstOrDefault<IXLPivotField>((Func<IXLPivotField, bool>) (p => p.SourceName == xlpf.SourceName)) != null)
        {
          newChild1.ColumnsPerPage = (UInt32Value) 1U;
          newChild1.RowPageCount = (UInt32Value) 1U;
          newChild8.Axis = (EnumValue<PivotTableAxisValues>) PivotTableAxisValues.AxisPage;
          newChild6.AppendChild<PageField>(new PageField()
          {
            Hierarchy = (Int32Value) -1,
            Field = (Int32Value) pt.Fields.IndexOf(xlpf)
          });
        }
        else if (pt.Values.FirstOrDefault<IXLPivotValue>((Func<IXLPivotValue, bool>) (p => p.CustomName == xlpf.SourceName)) != null)
          newChild8.DataField = (BooleanValue) true;
        Items newChild9 = new Items();
        if (xlpf.SharedStrings.Count > 0)
        {
          for (uint index = 0; (long) index < (long) xlpf.SharedStrings.Count; ++index)
            newChild9.AppendChild<Item>(new Item()
            {
              Index = (UInt32Value) index
            });
        }
        if (xlpf.Subtotals.Count > 0)
        {
          foreach (XLSubtotalFunction subtotal in xlpf.Subtotals)
          {
            Item newChild10 = new Item();
            switch (subtotal)
            {
              case XLSubtotalFunction.Sum:
                newChild8.SumSubtotal = (BooleanValue) true;
                newChild10.ItemType = (EnumValue<ItemValues>) ItemValues.Sum;
                break;
              case XLSubtotalFunction.Count:
                newChild8.CountASubtotal = (BooleanValue) true;
                newChild10.ItemType = (EnumValue<ItemValues>) ItemValues.CountA;
                break;
              case XLSubtotalFunction.Average:
                newChild8.AverageSubTotal = (BooleanValue) true;
                newChild10.ItemType = (EnumValue<ItemValues>) ItemValues.Average;
                break;
              case XLSubtotalFunction.Minimum:
                newChild8.MinSubtotal = (BooleanValue) true;
                newChild10.ItemType = (EnumValue<ItemValues>) ItemValues.Minimum;
                break;
              case XLSubtotalFunction.Maximum:
                newChild8.MaxSubtotal = (BooleanValue) true;
                newChild10.ItemType = (EnumValue<ItemValues>) ItemValues.Maximum;
                break;
              case XLSubtotalFunction.Product:
                newChild8.ApplyProductInSubtotal = (BooleanValue) true;
                newChild10.ItemType = (EnumValue<ItemValues>) ItemValues.Product;
                break;
              case XLSubtotalFunction.CountNumbers:
                newChild8.CountSubtotal = (BooleanValue) true;
                newChild10.ItemType = (EnumValue<ItemValues>) ItemValues.Count;
                break;
              case XLSubtotalFunction.StandardDeviation:
                newChild8.ApplyStandardDeviationInSubtotal = (BooleanValue) true;
                newChild10.ItemType = (EnumValue<ItemValues>) ItemValues.StandardDeviation;
                break;
              case XLSubtotalFunction.PopulationStandardDeviation:
                newChild8.ApplyStandardDeviationPInSubtotal = (BooleanValue) true;
                newChild10.ItemType = (EnumValue<ItemValues>) ItemValues.StandardDeviationP;
                break;
              case XLSubtotalFunction.Variance:
                newChild8.ApplyVarianceInSubtotal = (BooleanValue) true;
                newChild10.ItemType = (EnumValue<ItemValues>) ItemValues.Variance;
                break;
              case XLSubtotalFunction.PopulationVariance:
                newChild8.ApplyVariancePInSubtotal = (BooleanValue) true;
                newChild10.ItemType = (EnumValue<ItemValues>) ItemValues.VarianceP;
                break;
            }
            newChild9.AppendChild<Item>(newChild10);
          }
        }
        else
          newChild9.AppendChild<Item>(new Item()
          {
            ItemType = (EnumValue<ItemValues>) ItemValues.Default
          });
        newChild8.AppendChild<Items>(newChild9);
        newChild7.AppendChild<DocumentFormat.OpenXml.Spreadsheet.PivotField>(newChild8);
      }
      pivotTableDefinition.AppendChild<Location>(newChild1);
      pivotTableDefinition.AppendChild<PivotFields>(newChild7);
      if (pt.RowLabels.Any<IXLPivotField>())
        pivotTableDefinition.AppendChild<RowFields>(newChild2);
      else
        newChild4.AppendChild<RowItem>(new RowItem());
      pivotTableDefinition.AppendChild<RowItems>(newChild4);
      if (!pt.ColumnLabels.Any<IXLPivotField>())
      {
        newChild5.AppendChild<RowItem>(new RowItem());
        pivotTableDefinition.AppendChild<ColumnItems>(newChild5);
      }
      else
      {
        pivotTableDefinition.AppendChild<ColumnFields>(newChild3);
        pivotTableDefinition.AppendChild<ColumnItems>(newChild5);
      }
      if (pt.ReportFilters.Any<IXLPivotField>())
        pivotTableDefinition.AppendChild<PageFields>(newChild6);
      DataFields newChild12 = new DataFields();
      foreach (IXLPivotValue xlPivotValue in (IEnumerable<IXLPivotValue>) pt.Values)
      {
        IXLPivotValue value = xlPivotValue;
        IXLRangeColumn xlRangeColumn1 = pt.SourceRange.Columns((Func<IXLRangeColumn, bool>) null).FirstOrDefault<IXLRangeColumn>((Func<IXLRangeColumn, bool>) (c => c.Cell(1).Value.ToString() == value.SourceName));
        if (xlRangeColumn1 != null)
        {
          DocumentFormat.OpenXml.Spreadsheet.DataField newChild8 = new DocumentFormat.OpenXml.Spreadsheet.DataField()
          {
            Name = (StringValue) value.SourceName,
            Field = (UInt32Value) ((uint) (xlRangeColumn1.ColumnNumber() - 1)),
            Subtotal = (EnumValue<DataConsolidateFunctionValues>) value.SummaryFormula.ToOpenXml(),
            ShowDataAs = (EnumValue<ShowDataAsValues>) value.Calculation.ToOpenXml(),
            NumberFormatId = (UInt32Value) ((uint) value.NumberFormat.NumberFormatId)
          };
          if (!string.IsNullOrEmpty(value.BaseField))
          {
            IXLRangeColumn xlRangeColumn2 = pt.SourceRange.Columns((Func<IXLRangeColumn, bool>) null).FirstOrDefault<IXLRangeColumn>((Func<IXLRangeColumn, bool>) (c => c.Cell(1).Value.ToString() == value.BaseField));
            if (xlRangeColumn2 != null)
              newChild8.BaseField = (Int32Value) (xlRangeColumn2.ColumnNumber() - 1);
          }
          else
            newChild8.BaseField = (Int32Value) 0;
          newChild8.BaseItem = value.CalculationItem != XLPivotCalculationItem.Previous ? (value.CalculationItem != XLPivotCalculationItem.Next ? (UInt32Value) 0U : (UInt32Value) 1048829U) : (UInt32Value) 1048828U;
          newChild12.AppendChild<DocumentFormat.OpenXml.Spreadsheet.DataField>(newChild8);
        }
      }
      pivotTableDefinition.AppendChild<DataFields>(newChild12);
      pivotTableDefinition.AppendChild<PivotTableStyle>(new PivotTableStyle()
      {
        Name = (StringValue) Enum.GetName(typeof (XLPivotTableTheme), (object) pt.Theme),
        ShowRowHeaders = (BooleanValue) pt.ShowRowHeaders,
        ShowColumnHeaders = (BooleanValue) pt.ShowColumnHeaders,
        ShowRowStripes = (BooleanValue) pt.ShowRowStripes,
        ShowColumnStripes = (BooleanValue) pt.ShowColumnStripes
      });
      PivotTableDefinitionExtensionList newChild13 = new PivotTableDefinitionExtensionList();
      PivotTableDefinitionExtension newChild14 = new PivotTableDefinitionExtension()
      {
        Uri = (StringValue) "{962EF5D1-5CA2-4c93-8EF4-DBF5C05439D2}"
      };
      newChild14.AddNamespaceDeclaration("x14", "http://schemas.microsoft.com/office/spreadsheetml/2009/9/main");
      DocumentFormat.OpenXml.Office2010.Excel.PivotTableDefinition newChild15 = new DocumentFormat.OpenXml.Office2010.Excel.PivotTableDefinition()
      {
        EnableEdit = (BooleanValue) pt.EnableCellEditing,
        HideValuesRow = (BooleanValue) (!pt.ShowValuesRow)
      };
      newChild15.AddNamespaceDeclaration("xm", "http://schemas.microsoft.com/office/excel/2006/main");
      newChild14.AppendChild<DocumentFormat.OpenXml.Office2010.Excel.PivotTableDefinition>(newChild15);
      newChild13.AppendChild<PivotTableDefinitionExtension>(newChild14);
      pivotTableDefinition.AppendChild<PivotTableDefinitionExtensionList>(newChild13);
      pivotTablePart1.PivotTableDefinition = pivotTableDefinition;
    }

    private static void GenerateWorksheetCommentsPartContent(WorksheetCommentsPart worksheetCommentsPart, XLWorksheet xlWorksheet)
    {
      Comments comments = new Comments();
      CommentList commentList = new CommentList();
      Dictionary<string, int> source = new Dictionary<string, int>();
      foreach (XLCell cell in xlWorksheet.Internals.CellsCollection.GetCells((Func<IXLCell, bool>) (c => c.HasComment)))
      {
        DocumentFormat.OpenXml.Spreadsheet.Comment comment = new DocumentFormat.OpenXml.Spreadsheet.Comment()
        {
          Reference = (StringValue) cell.Address.ToStringRelative()
        };
        string author = cell.Comment.Author;
        int count;
        if (!source.TryGetValue(author, out count))
        {
          count = source.Count;
          source.Add(author, count);
        }
        comment.AuthorId = (UInt32Value) ((uint) count);
        CommentText commentText = new CommentText();
        foreach (IXLRichString rt in (XLFormattedText<IXLComment>) cell.Comment)
          commentText.Append(new OpenXmlElement[1]
          {
            (OpenXmlElement) XLWorkbook.GetRun(rt)
          });
        comment.Append(new OpenXmlElement[1]
        {
          (OpenXmlElement) commentText
        });
        commentList.Append(new OpenXmlElement[1]
        {
          (OpenXmlElement) comment
        });
      }
      Authors authors = new Authors();
      foreach (DocumentFormat.OpenXml.Spreadsheet.Author author in source.Select<KeyValuePair<string, int>, DocumentFormat.OpenXml.Spreadsheet.Author>((Func<KeyValuePair<string, int>, DocumentFormat.OpenXml.Spreadsheet.Author>) (a =>
      {
        return new DocumentFormat.OpenXml.Spreadsheet.Author() { Text = a.Key };
      })))
        authors.Append(new OpenXmlElement[1]
        {
          (OpenXmlElement) author
        });
      comments.Append(new OpenXmlElement[1]
      {
        (OpenXmlElement) authors
      });
      comments.Append(new OpenXmlElement[1]
      {
        (OpenXmlElement) commentList
      });
      worksheetCommentsPart.Comments = comments;
    }

    private static void GenerateVmlDrawingPartContent(VmlDrawingPart vmlDrawingPart, XLWorksheet xlWorksheet, XLWorkbook.SaveContext context)
    {
      MemoryStream memoryStream = new MemoryStream();
      XLWorkbook.CopyStream(vmlDrawingPart.GetStream(FileMode.OpenOrCreate), (Stream) memoryStream);
      memoryStream.Position = 0L;
      XmlTextWriter writer = new XmlTextWriter(vmlDrawingPart.GetStream(FileMode.Create), Encoding.UTF8);
      writer.WriteStartElement("xml");
      new Shapetype(new OpenXmlElement[2]
      {
        (OpenXmlElement) new Stroke()
        {
          JoinStyle = (EnumValue<StrokeJoinStyleValues>) StrokeJoinStyleValues.Miter
        },
        (OpenXmlElement) new DocumentFormat.OpenXml.Vml.Path()
        {
          AllowGradientShape = (TrueFalseValue) true,
          ConnectionPointType = (EnumValue<ConnectValues>) ConnectValues.Rectangle
        }
      })
      {
        Id = (StringValue) "_x0000_t202",
        CoordinateSize = (StringValue) "21600,21600",
        OptionalNumber = (Int32Value) 202,
        EdgePath = (StringValue) "m,l,21600r21600,l21600,xe"
      }.WriteTo((XmlWriter) writer);
      foreach (XLCell c in xlWorksheet.Internals.CellsCollection.GetCells().Where<XLCell>((Func<XLCell, bool>) (c => c.HasComment)))
        XLWorkbook.GenerateShape(c, "_x0000_t202").WriteTo((XmlWriter) writer);
      if (memoryStream.Length > 0L)
      {
        memoryStream.Position = 0L;
        XDocumentExtensions.Load((Stream) memoryStream).Root.Elements().ForEach<XElement>((Action<XElement>) (e => writer.WriteRaw(e.ToString())));
      }
      writer.WriteEndElement();
      writer.Flush();
      writer.Close();
    }

    private static DocumentFormat.OpenXml.Vml.Shape GenerateShape(XLCell c, string shapeTypeId)
    {
      int rowNumber = c.Address.RowNumber;
      int columnNumber = c.Address.ColumnNumber;
      string str = string.Format("_x0000_s{0}", (object) c.Comment.ShapeId);
      DocumentFormat.OpenXml.Vml.Spreadsheet.Anchor anchor = XLWorkbook.GetAnchor(c);
      TextBox textBox = XLWorkbook.GetTextBox(c.Comment.Style);
      DocumentFormat.OpenXml.Vml.Fill fill = new DocumentFormat.OpenXml.Vml.Fill()
      {
        Color2 = (StringValue) ("#" + c.Comment.Style.ColorsAndLines.FillColor.Color.ToHex().Substring(2))
      };
      if (c.Comment.Style.ColorsAndLines.FillTransparency < 1.0)
        fill.Opacity = (StringValue) Math.Round(Convert.ToDouble(c.Comment.Style.ColorsAndLines.FillTransparency), 2).ToString((IFormatProvider) CultureInfo.InvariantCulture);
      Stroke stroke = XLWorkbook.GetStroke(c);
      OpenXmlElement[] openXmlElementArray1 = new OpenXmlElement[6]
      {
        (OpenXmlElement) fill,
        (OpenXmlElement) stroke,
        (OpenXmlElement) new DocumentFormat.OpenXml.Vml.Shadow()
        {
          On = (TrueFalseValue) true,
          Color = (StringValue) "black",
          Obscured = (TrueFalseValue) true
        },
        (OpenXmlElement) new DocumentFormat.OpenXml.Vml.Path()
        {
          ConnectionPointType = (EnumValue<ConnectValues>) ConnectValues.None
        },
        (OpenXmlElement) textBox,
        null
      };
      OpenXmlElement[] openXmlElementArray2 = openXmlElementArray1;
      int index1 = 5;
      OpenXmlElement[] openXmlElementArray3 = new OpenXmlElement[11]
      {
        (OpenXmlElement) new MoveWithCells(c.Comment.Style.Properties.Positioning == XLDrawingAnchor.Absolute ? "True" : "False"),
        (OpenXmlElement) new ResizeWithCells(c.Comment.Style.Properties.Positioning == XLDrawingAnchor.MoveAndSizeWithCells ? "False" : "True"),
        (OpenXmlElement) anchor,
        (OpenXmlElement) new HorizontalTextAlignment(c.Comment.Style.Alignment.Horizontal.ToString().ToCamel()),
        (OpenXmlElement) new DocumentFormat.OpenXml.Vml.Spreadsheet.VerticalTextAlignment(c.Comment.Style.Alignment.Vertical.ToString().ToCamel()),
        (OpenXmlElement) new AutoFill("False"),
        null,
        null,
        null,
        null,
        null
      };
      OpenXmlElement[] openXmlElementArray4 = openXmlElementArray3;
      int index2 = 6;
      CommentRowTarget commentRowTarget1 = new CommentRowTarget();
      commentRowTarget1.Text = (rowNumber - 1).ToString();
      CommentRowTarget commentRowTarget2 = commentRowTarget1;
      openXmlElementArray4[index2] = (OpenXmlElement) commentRowTarget2;
      OpenXmlElement[] openXmlElementArray5 = openXmlElementArray3;
      int index3 = 7;
      CommentColumnTarget commentColumnTarget1 = new CommentColumnTarget();
      commentColumnTarget1.Text = (columnNumber - 1).ToString();
      CommentColumnTarget commentColumnTarget2 = commentColumnTarget1;
      openXmlElementArray5[index3] = (OpenXmlElement) commentColumnTarget2;
      openXmlElementArray3[8] = (OpenXmlElement) new Locked(c.Comment.Style.Protection.Locked ? "True" : "False");
      openXmlElementArray3[9] = (OpenXmlElement) new LockText(c.Comment.Style.Protection.LockText ? "True" : "False");
      openXmlElementArray3[10] = (OpenXmlElement) new Visible(c.Comment.Visible ? "True" : "False");
      ClientData clientData = new ClientData(openXmlElementArray3)
      {
        ObjectType = (EnumValue<ObjectValues>) ObjectValues.Note
      };
      openXmlElementArray2[index1] = (OpenXmlElement) clientData;
      DocumentFormat.OpenXml.Vml.Shape shape = new DocumentFormat.OpenXml.Vml.Shape(openXmlElementArray1)
      {
        Id = (StringValue) str,
        Type = (StringValue) ("#" + shapeTypeId),
        Style = XLWorkbook.GetCommentStyle(c),
        FillColor = (StringValue) ("#" + c.Comment.Style.ColorsAndLines.FillColor.Color.ToHex().Substring(2)),
        StrokeColor = (StringValue) ("#" + c.Comment.Style.ColorsAndLines.LineColor.Color.ToHex().Substring(2)),
        StrokeWeight = (StringValue) string.Format((IFormatProvider) CultureInfo.InvariantCulture, "{0}pt", new object[1]
        {
          (object) c.Comment.Style.ColorsAndLines.LineWeight
        }),
        InsetMode = (EnumValue<InsetMarginValues>) (c.Comment.Style.Margins.Automatic ? InsetMarginValues.Auto : InsetMarginValues.Custom)
      };
      if (!XLHelper.IsNullOrWhiteSpace(c.Comment.Style.Web.AlternateText))
        shape.Alternate = (StringValue) c.Comment.Style.Web.AlternateText;
      return shape;
    }

    private static Stroke GetStroke(XLCell c)
    {
      XLDashStyle lineDash = c.Comment.Style.ColorsAndLines.LineDash;
      Stroke stroke = new Stroke()
      {
        LineStyle = (EnumValue<StrokeLineStyleValues>) c.Comment.Style.ColorsAndLines.LineStyle.ToOpenXml(),
        DashStyle = (StringValue) (lineDash == XLDashStyle.RoundDot || lineDash == XLDashStyle.SquareDot ? "shortDot" : lineDash.ToString().ToCamel())
      };
      if (lineDash == XLDashStyle.RoundDot)
        stroke.EndCap = (EnumValue<StrokeEndCapValues>) StrokeEndCapValues.Round;
      if (c.Comment.Style.ColorsAndLines.LineTransparency < 1.0)
        stroke.Opacity = (StringValue) Math.Round(Convert.ToDouble(c.Comment.Style.ColorsAndLines.LineTransparency), 2).ToString((IFormatProvider) CultureInfo.InvariantCulture);
      return stroke;
    }

    private static TextBox GetTextBox(IXLDrawingStyle ds)
    {
      StringBuilder stringBuilder = new StringBuilder();
      IXLDrawingAlignment alignment = ds.Alignment;
      if (alignment.Direction == XLDrawingTextDirection.Context)
        stringBuilder.Append("mso-direction-alt:auto;");
      else if (alignment.Direction == XLDrawingTextDirection.RightToLeft)
        stringBuilder.Append("direction:RTL;");
      if (alignment.Orientation != XLDrawingTextOrientation.LeftToRight)
      {
        stringBuilder.Append("layout-flow:vertical;");
        if (alignment.Orientation == XLDrawingTextOrientation.BottomToTop)
          stringBuilder.Append("mso-layout-flow-alt:bottom-to-top;");
        else if (alignment.Orientation == XLDrawingTextOrientation.Vertical)
          stringBuilder.Append("mso-layout-flow-alt:top-to-bottom;");
      }
      if (alignment.AutomaticSize)
        stringBuilder.Append("mso-fit-shape-to-text:t;");
      TextBox textBox = new TextBox()
      {
        Style = (StringValue) stringBuilder.ToString()
      };
      IXLDrawingMargins margins = ds.Margins;
      if (!margins.Automatic)
        textBox.Inset = (StringValue) string.Format("{0}in,{1}in,{2}in,{3}in", (object) margins.Left.ToString((IFormatProvider) CultureInfo.InvariantCulture), (object) margins.Top.ToString((IFormatProvider) CultureInfo.InvariantCulture), (object) margins.Right.ToString((IFormatProvider) CultureInfo.InvariantCulture), (object) margins.Bottom.ToString((IFormatProvider) CultureInfo.InvariantCulture));
      return textBox;
    }

    private static DocumentFormat.OpenXml.Vml.Spreadsheet.Anchor GetAnchor(XLCell cell)
    {
      XLComment comment = cell.Comment;
      double width = comment.Style.Size.Width;
      int num1 = comment.Position.Column - 1;
      int int32_1 = Convert.ToInt32(comment.Position.ColumnOffset * 7.5);
      double num2 = cell.Worksheet.Column(comment.Position.Column).Width - comment.Position.ColumnOffset;
      XLCell xlCell1 = cell.CellRight(comment.Position.Column - cell.Address.ColumnNumber);
      while (num2 <= width)
      {
        xlCell1 = xlCell1.CellRight();
        num2 += xlCell1.WorksheetColumn().Width;
      }
      int num3 = xlCell1.WorksheetColumn().ColumnNumber() - 1;
      int int32_2 = Convert.ToInt32((xlCell1.WorksheetColumn().Width - (num2 - width)) * 7.5);
      double height = comment.Style.Size.Height;
      int num4 = comment.Position.Row - 1;
      int int32_3 = Convert.ToInt32(comment.Position.RowOffset);
      double num5 = cell.Worksheet.Row(comment.Position.Row).Height - comment.Position.RowOffset;
      XLCell xlCell2 = cell.CellBelow(comment.Position.Row - cell.Address.RowNumber);
      while (num5 <= height)
      {
        xlCell2 = xlCell2.CellBelow();
        num5 += xlCell2.WorksheetRow().Height;
      }
      int num6 = xlCell2.WorksheetRow().RowNumber() - 1;
      int int32_4 = Convert.ToInt32(xlCell2.WorksheetRow().Height - (num5 - height));
      DocumentFormat.OpenXml.Vml.Spreadsheet.Anchor anchor = new DocumentFormat.OpenXml.Vml.Spreadsheet.Anchor();
      anchor.Text = string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", (object) num1, (object) int32_1, (object) num4, (object) int32_3, (object) num3, (object) int32_2, (object) num6, (object) int32_4);
      return anchor;
    }

    private static StringValue GetCommentStyle(XLCell cell)
    {
      XLComment comment = cell.Comment;
      StringBuilder stringBuilder = new StringBuilder("position:absolute; ");
      stringBuilder.Append("visibility:");
      stringBuilder.Append(comment.Visible ? "visible" : "hidden");
      stringBuilder.Append(";");
      stringBuilder.Append("width:");
      stringBuilder.Append(Math.Round(comment.Style.Size.Width * 7.5, 2).ToString((IFormatProvider) CultureInfo.InvariantCulture));
      stringBuilder.Append("pt;");
      stringBuilder.Append("height:");
      stringBuilder.Append(Math.Round(comment.Style.Size.Height, 2).ToString((IFormatProvider) CultureInfo.InvariantCulture));
      stringBuilder.Append("pt;");
      stringBuilder.Append("z-index:");
      stringBuilder.Append(comment.ZOrder.ToString());
      return (StringValue) stringBuilder.ToString();
    }

    private void GenerateWorkbookStylesPartContent(WorkbookStylesPart workbookStylesPart, XLWorkbook.SaveContext context)
    {
      XLStyle xlStyle1 = new XLStyle((IXLStylized) null, XLWorkbook.DefaultStyle, true);
      int styleId = this.GetStyleId((IXLStyle) xlStyle1);
      if (!context.SharedFonts.ContainsKey(xlStyle1.Font))
        context.SharedFonts.Add(xlStyle1.Font, new XLWorkbook.FontInfo()
        {
          FontId = 0U,
          Font = xlStyle1.Font as XLFont
        });
      Dictionary<IXLFill, XLWorkbook.FillInfo> sharedFills = new Dictionary<IXLFill, XLWorkbook.FillInfo>()
      {
        {
          xlStyle1.Fill,
          new XLWorkbook.FillInfo()
          {
            FillId = 2U,
            Fill = xlStyle1.Fill as XLFill
          }
        }
      };
      Dictionary<IXLBorder, XLWorkbook.BorderInfo> sharedBorders = new Dictionary<IXLBorder, XLWorkbook.BorderInfo>()
      {
        {
          xlStyle1.Border,
          new XLWorkbook.BorderInfo()
          {
            BorderId = 0U,
            Border = xlStyle1.Border as XLBorder
          }
        }
      };
      Dictionary<IXLNumberFormat, XLWorkbook.NumberFormatInfo> sharedNumberFormats = new Dictionary<IXLNumberFormat, XLWorkbook.NumberFormatInfo>()
      {
        {
          xlStyle1.NumberFormat,
          new XLWorkbook.NumberFormatInfo()
          {
            NumberFormatId = 0,
            NumberFormat = xlStyle1.NumberFormat
          }
        }
      };
      if (workbookStylesPart.Stylesheet == null)
        workbookStylesPart.Stylesheet = new Stylesheet();
      if (workbookStylesPart.Stylesheet.CellStyles == null)
        workbookStylesPart.Stylesheet.CellStyles = new CellStyles();
      uint num1 = !workbookStylesPart.Stylesheet.CellStyles.Elements<CellStyle>().Any<CellStyle>((Func<CellStyle, bool>) (c => (string) c.Name == "Normal")) ? (!workbookStylesPart.Stylesheet.CellStyles.Elements<CellStyle>().Any<CellStyle>() ? 0U : workbookStylesPart.Stylesheet.CellStyles.Elements<CellStyle>().Max<CellStyle, uint>((Func<CellStyle, uint>) (c => c.FormatId.Value)) + 1U) : workbookStylesPart.Stylesheet.CellStyles.Elements<CellStyle>().Single<CellStyle>((Func<CellStyle, bool>) (c => (string) c.Name == "Normal")).FormatId.Value;
      context.SharedStyles.Add(styleId, new XLWorkbook.StyleInfo()
      {
        StyleId = num1,
        Style = (IXLStyle) xlStyle1,
        FontId = 0U,
        FillId = 0U,
        BorderId = 0U,
        NumberFormatId = 0
      });
      uint num2 = 1;
      uint num3 = 1;
      uint num4 = 3;
      uint num5 = 1;
      int num6 = 1;
      HashSet<int> xlStyles = new HashSet<int>();
      foreach (XLWorksheet xlWorksheet in this.WorksheetsInternal)
      {
        foreach (int num7 in xlWorksheet.GetStyleIds().Where<int>((Func<int, bool>) (s => !xlStyles.Contains(s))))
          xlStyles.Add(num7);
        foreach (int num7 in xlWorksheet.Internals.ColumnsCollection.Select<KeyValuePair<int, XLColumn>, int>((Func<KeyValuePair<int, XLColumn>, int>) (kp => kp.Value.GetStyleId())).Where<int>((Func<int, bool>) (s => !xlStyles.Contains(s))))
          xlStyles.Add(num7);
        foreach (int num7 in xlWorksheet.Internals.RowsCollection.Select<KeyValuePair<int, XLRow>, int>((Func<KeyValuePair<int, XLRow>, int>) (kp => kp.Value.GetStyleId())).Where<int>((Func<int, bool>) (s => !xlStyles.Contains(s))))
          xlStyles.Add(num7);
      }
      foreach (IXLStyle xlStyle2 in xlStyles.Select<int, IXLStyle>(new Func<int, IXLStyle>(this.GetStyleById)))
      {
        if (!context.SharedFonts.ContainsKey(xlStyle2.Font))
          context.SharedFonts.Add(xlStyle2.Font, new XLWorkbook.FontInfo()
          {
            FontId = num3++,
            Font = xlStyle2.Font as XLFont
          });
        if (!sharedFills.ContainsKey(xlStyle2.Fill))
          sharedFills.Add(xlStyle2.Fill, new XLWorkbook.FillInfo()
          {
            FillId = num4++,
            Fill = xlStyle2.Fill as XLFill
          });
        if (!sharedBorders.ContainsKey(xlStyle2.Border))
          sharedBorders.Add(xlStyle2.Border, new XLWorkbook.BorderInfo()
          {
            BorderId = num5++,
            Border = xlStyle2.Border as XLBorder
          });
        if (xlStyle2.NumberFormat.NumberFormatId == -1 && !sharedNumberFormats.ContainsKey(xlStyle2.NumberFormat))
        {
          sharedNumberFormats.Add(xlStyle2.NumberFormat, new XLWorkbook.NumberFormatInfo()
          {
            NumberFormatId = num6 + 164,
            NumberFormat = xlStyle2.NumberFormat
          });
          ++num6;
        }
      }
      Dictionary<IXLNumberFormat, XLWorkbook.NumberFormatInfo> dictionary1 = XLWorkbook.ResolveNumberFormats(workbookStylesPart, sharedNumberFormats);
      this.ResolveFonts(workbookStylesPart, context);
      Dictionary<IXLFill, XLWorkbook.FillInfo> dictionary2 = this.ResolveFills(workbookStylesPart, sharedFills);
      Dictionary<IXLBorder, XLWorkbook.BorderInfo> dictionary3 = this.ResolveBorders(workbookStylesPart, sharedBorders);
      foreach (int num7 in xlStyles)
      {
        IXLStyle styleById = this.GetStyleById(num7);
        if (!context.SharedStyles.ContainsKey(num7))
        {
          int num8 = styleById.NumberFormat.NumberFormatId >= 0 ? styleById.NumberFormat.NumberFormatId : dictionary1[styleById.NumberFormat].NumberFormatId;
          context.SharedStyles.Add(num7, new XLWorkbook.StyleInfo()
          {
            StyleId = num2++,
            Style = styleById,
            FontId = context.SharedFonts[styleById.Font].FontId,
            FillId = dictionary2[styleById.Fill].FillId,
            BorderId = dictionary3[styleById.Border].BorderId,
            NumberFormatId = num8
          });
        }
      }
      XLWorkbook.ResolveCellStyleFormats(workbookStylesPart, context);
      XLWorkbook.ResolveRest(workbookStylesPart, context);
      if (workbookStylesPart.Stylesheet.CellStyles.Elements<CellStyle>().All<CellStyle>((Func<CellStyle, bool>) (c => (string) c.Name != "Normal")))
      {
        CellStyle newChild = new CellStyle()
        {
          Name = (StringValue) "Normal",
          FormatId = (UInt32Value) num1,
          BuiltinId = (UInt32Value) 0U
        };
        workbookStylesPart.Stylesheet.CellStyles.AppendChild<CellStyle>(newChild);
      }
      workbookStylesPart.Stylesheet.CellStyles.Count = (UInt32Value) ((uint) workbookStylesPart.Stylesheet.CellStyles.Count<OpenXmlElement>());
      Dictionary<int, XLWorkbook.StyleInfo> source = new Dictionary<int, XLWorkbook.StyleInfo>();
      foreach (KeyValuePair<int, XLWorkbook.StyleInfo> sharedStyle in context.SharedStyles)
      {
        int num7 = -1;
        foreach (CellFormat cellFormat in (OpenXmlElement) workbookStylesPart.Stylesheet.CellFormats)
        {
          ++num7;
          if (XLWorkbook.CellFormatsAreEqual(cellFormat, sharedStyle.Value))
            break;
        }
        if (num7 == -1)
          num7 = 0;
        XLWorkbook.StyleInfo styleInfo = sharedStyle.Value;
        styleInfo.StyleId = (uint) num7;
        source.Add(sharedStyle.Key, styleInfo);
      }
      context.SharedStyles.Clear();
      source.ForEach<KeyValuePair<int, XLWorkbook.StyleInfo>>((Action<KeyValuePair<int, XLWorkbook.StyleInfo>>) (kp => context.SharedStyles.Add(kp.Key, kp.Value)));
      this.AddDifferentialFormats(workbookStylesPart, context);
    }

    private void AddDifferentialFormats(WorkbookStylesPart workbookStylesPart, XLWorkbook.SaveContext context)
    {
      if (workbookStylesPart.Stylesheet.DifferentialFormats == null)
        workbookStylesPart.Stylesheet.DifferentialFormats = new DocumentFormat.OpenXml.Spreadsheet.DifferentialFormats();
      DocumentFormat.OpenXml.Spreadsheet.DifferentialFormats differentialFormats = workbookStylesPart.Stylesheet.DifferentialFormats;
      this.FillDifferentialFormatsCollection(differentialFormats, context.DifferentialFormats);
      foreach (IXLWorksheet worksheet in (IEnumerable<IXLWorksheet>) this.Worksheets)
      {
        foreach (IXLConditionalFormat conditionalFormat in (IEnumerable<IXLConditionalFormat>) worksheet.ConditionalFormats)
        {
          if (!context.DifferentialFormats.ContainsKey(conditionalFormat.Style))
            XLWorkbook.AddDifferentialFormat(workbookStylesPart.Stylesheet.DifferentialFormats, conditionalFormat, context);
        }
      }
      differentialFormats.Count = (UInt32Value) ((uint) differentialFormats.Count<OpenXmlElement>());
      if ((int) (uint) differentialFormats.Count != 0)
        return;
      workbookStylesPart.Stylesheet.DifferentialFormats = (DocumentFormat.OpenXml.Spreadsheet.DifferentialFormats) null;
    }

    private void FillDifferentialFormatsCollection(DocumentFormat.OpenXml.Spreadsheet.DifferentialFormats differentialFormats, Dictionary<IXLStyle, int> dictionary)
    {
      dictionary.Clear();
      int num = 0;
      foreach (DifferentialFormat element in differentialFormats.Elements<DifferentialFormat>())
      {
        XLStyle xlStyle = new XLStyle((IXLStylized) new XLStylizedEmpty(XLWorkbook.DefaultStyle), XLWorkbook.DefaultStyle, true);
        this.LoadFont((OpenXmlElement) element.Font, (IXLFontBase) xlStyle.Font);
        this.LoadBorder(element.Border, xlStyle.Border);
        this.LoadNumberFormat(element.NumberingFormat, xlStyle.NumberFormat);
        this.LoadFill(element.Fill, xlStyle.Fill);
        if (!dictionary.ContainsKey((IXLStyle) xlStyle))
          dictionary.Add((IXLStyle) xlStyle, ++num);
      }
    }

    private static void AddDifferentialFormat(DocumentFormat.OpenXml.Spreadsheet.DifferentialFormats differentialFormats, IXLConditionalFormat cf, XLWorkbook.SaveContext context)
    {
      DifferentialFormat differentialFormat = new DifferentialFormat();
      differentialFormat.Append(new OpenXmlElement[1]
      {
        (OpenXmlElement) XLWorkbook.GetNewFont(new XLWorkbook.FontInfo()
        {
          Font = cf.Style.Font as XLFont
        }, false)
      });
      if (!XLHelper.IsNullOrWhiteSpace(cf.Style.NumberFormat.Format))
      {
        NumberingFormat numberingFormat = new NumberingFormat()
        {
          NumberFormatId = (UInt32Value) ((uint) (differentialFormats.Count<OpenXmlElement>() + 164)),
          FormatCode = (StringValue) cf.Style.NumberFormat.Format
        };
        differentialFormat.Append(new OpenXmlElement[1]
        {
          (OpenXmlElement) numberingFormat
        });
      }
      differentialFormat.Append(new OpenXmlElement[1]
      {
        (OpenXmlElement) XLWorkbook.GetNewFill(new XLWorkbook.FillInfo()
        {
          Fill = cf.Style.Fill as XLFill
        }, false)
      });
      differentialFormat.Append(new OpenXmlElement[1]
      {
        (OpenXmlElement) XLWorkbook.GetNewBorder(new XLWorkbook.BorderInfo()
        {
          Border = cf.Style.Border as XLBorder
        }, false)
      });
      differentialFormats.Append(new OpenXmlElement[1]
      {
        (OpenXmlElement) differentialFormat
      });
      context.DifferentialFormats.Add(cf.Style, differentialFormats.Count<OpenXmlElement>() - 1);
    }

    private static void ResolveRest(WorkbookStylesPart workbookStylesPart, XLWorkbook.SaveContext context)
    {
      if (workbookStylesPart.Stylesheet.CellFormats == null)
        workbookStylesPart.Stylesheet.CellFormats = new CellFormats();
      foreach (XLWorkbook.StyleInfo styleInfo in context.SharedStyles.Values)
      {
        XLWorkbook.StyleInfo info = styleInfo;
        if (!workbookStylesPart.Stylesheet.CellFormats.Cast<CellFormat>().Any<CellFormat>((Func<CellFormat, bool>) (f => XLWorkbook.CellFormatsAreEqual(f, info))))
        {
          CellFormat cellFormat = XLWorkbook.GetCellFormat(styleInfo);
          cellFormat.FormatId = (UInt32Value) 0U;
          Alignment newChild = new Alignment()
          {
            Horizontal = (EnumValue<HorizontalAlignmentValues>) styleInfo.Style.Alignment.Horizontal.ToOpenXml(),
            Vertical = (EnumValue<VerticalAlignmentValues>) styleInfo.Style.Alignment.Vertical.ToOpenXml(),
            Indent = (UInt32Value) ((uint) styleInfo.Style.Alignment.Indent),
            ReadingOrder = (UInt32Value) ((uint) styleInfo.Style.Alignment.ReadingOrder),
            WrapText = (BooleanValue) styleInfo.Style.Alignment.WrapText,
            TextRotation = (UInt32Value) ((uint) styleInfo.Style.Alignment.TextRotation),
            ShrinkToFit = (BooleanValue) styleInfo.Style.Alignment.ShrinkToFit,
            RelativeIndent = (Int32Value) styleInfo.Style.Alignment.RelativeIndent,
            JustifyLastLine = (BooleanValue) styleInfo.Style.Alignment.JustifyLastLine
          };
          cellFormat.AppendChild<Alignment>(newChild);
          if (cellFormat.ApplyProtection.Value)
            cellFormat.AppendChild<Protection>(XLWorkbook.GetProtection(styleInfo));
          workbookStylesPart.Stylesheet.CellFormats.AppendChild<CellFormat>(cellFormat);
        }
      }
      workbookStylesPart.Stylesheet.CellFormats.Count = (UInt32Value) ((uint) workbookStylesPart.Stylesheet.CellFormats.Count<OpenXmlElement>());
    }

    private static void ResolveCellStyleFormats(WorkbookStylesPart workbookStylesPart, XLWorkbook.SaveContext context)
    {
      if (workbookStylesPart.Stylesheet.CellStyleFormats == null)
        workbookStylesPart.Stylesheet.CellStyleFormats = new CellStyleFormats();
      foreach (XLWorkbook.StyleInfo styleInfo in context.SharedStyles.Values)
      {
        XLWorkbook.StyleInfo info = styleInfo;
        if (!workbookStylesPart.Stylesheet.CellStyleFormats.Cast<CellFormat>().Any<CellFormat>((Func<CellFormat, bool>) (f => XLWorkbook.CellFormatsAreEqual(f, info))))
        {
          CellFormat cellFormat = XLWorkbook.GetCellFormat(styleInfo);
          if (cellFormat.ApplyProtection.Value)
            cellFormat.AppendChild<Protection>(XLWorkbook.GetProtection(styleInfo));
          workbookStylesPart.Stylesheet.CellStyleFormats.AppendChild<CellFormat>(cellFormat);
        }
      }
      workbookStylesPart.Stylesheet.CellStyleFormats.Count = (UInt32Value) ((uint) workbookStylesPart.Stylesheet.CellStyleFormats.Count<OpenXmlElement>());
    }

    private static bool ApplyFill(XLWorkbook.StyleInfo styleInfo)
    {
      return styleInfo.Style.Fill.PatternType.ToOpenXml() == PatternValues.None;
    }

    private static bool ApplyBorder(XLWorkbook.StyleInfo styleInfo)
    {
      IXLBorder border = styleInfo.Style.Border;
      if (border.BottomBorder.ToOpenXml() == BorderStyleValues.None && border.DiagonalBorder.ToOpenXml() == BorderStyleValues.None && (border.RightBorder.ToOpenXml() == BorderStyleValues.None && border.LeftBorder.ToOpenXml() == BorderStyleValues.None))
        return border.TopBorder.ToOpenXml() != BorderStyleValues.None;
      return true;
    }

    private static bool ApplyProtection(XLWorkbook.StyleInfo styleInfo)
    {
      return styleInfo.Style.Protection != null;
    }

    private static CellFormat GetCellFormat(XLWorkbook.StyleInfo styleInfo)
    {
      return new CellFormat()
      {
        NumberFormatId = (UInt32Value) ((uint) styleInfo.NumberFormatId),
        FontId = (UInt32Value) styleInfo.FontId,
        FillId = (UInt32Value) styleInfo.FillId,
        BorderId = (UInt32Value) styleInfo.BorderId,
        ApplyNumberFormat = (BooleanValue) true,
        ApplyAlignment = (BooleanValue) true,
        ApplyFill = (BooleanValue) XLWorkbook.ApplyFill(styleInfo),
        ApplyBorder = (BooleanValue) XLWorkbook.ApplyBorder(styleInfo),
        ApplyProtection = (BooleanValue) XLWorkbook.ApplyProtection(styleInfo)
      };
    }

    private static Protection GetProtection(XLWorkbook.StyleInfo styleInfo)
    {
      return new Protection()
      {
        Locked = (BooleanValue) styleInfo.Style.Protection.Locked,
        Hidden = (BooleanValue) styleInfo.Style.Protection.Hidden
      };
    }

    private static bool CellFormatsAreEqual(CellFormat f, XLWorkbook.StyleInfo styleInfo)
    {
      if (f.BorderId != null && (int) styleInfo.BorderId == (int) (uint) f.BorderId && (f.FillId != null && (int) styleInfo.FillId == (int) (uint) f.FillId) && (f.FontId != null && (int) styleInfo.FontId == (int) (uint) f.FontId && (f.NumberFormatId != null && (long) styleInfo.NumberFormatId == (long) (uint) f.NumberFormatId)) && (f.ApplyFill != null && (bool) f.ApplyFill == XLWorkbook.ApplyFill(styleInfo) && (f.ApplyBorder != null && (bool) f.ApplyBorder == XLWorkbook.ApplyBorder(styleInfo)) && XLWorkbook.AlignmentsAreEqual(f.Alignment, styleInfo.Style.Alignment)))
        return XLWorkbook.ProtectionsAreEqual(f.Protection, styleInfo.Style.Protection);
      return false;
    }

    private static bool ProtectionsAreEqual(Protection protection, IXLProtection xlProtection)
    {
      XLProtection xlProtection1 = new XLProtection();
      if (protection != null)
      {
        if (protection.Locked != null)
          xlProtection1.Locked = protection.Locked.Value;
        if (protection.Hidden != null)
          xlProtection1.Hidden = protection.Hidden.Value;
      }
      return xlProtection1.Equals(xlProtection);
    }

    private static bool AlignmentsAreEqual(Alignment alignment, IXLAlignment xlAlignment)
    {
      XLAlignment xlAlignment1 = new XLAlignment();
      if (alignment != null)
      {
        if (alignment.Indent != null)
          xlAlignment1.Indent = (int) alignment.Indent.Value;
        if (alignment.Horizontal != null)
          xlAlignment1.Horizontal = alignment.Horizontal.Value.ToClosedXml();
        if (alignment.Vertical != null)
          xlAlignment1.Vertical = alignment.Vertical.Value.ToClosedXml();
        if (alignment.ReadingOrder != null)
          xlAlignment1.ReadingOrder = alignment.ReadingOrder.Value.ToClosedXml();
        if (alignment.WrapText != null)
          xlAlignment1.WrapText = alignment.WrapText.Value;
        if (alignment.TextRotation != null)
          xlAlignment1.TextRotation = (int) alignment.TextRotation.Value;
        if (alignment.ShrinkToFit != null)
          xlAlignment1.ShrinkToFit = alignment.ShrinkToFit.Value;
        if (alignment.RelativeIndent != null)
          xlAlignment1.RelativeIndent = alignment.RelativeIndent.Value;
        if (alignment.JustifyLastLine != null)
          xlAlignment1.JustifyLastLine = alignment.JustifyLastLine.Value;
      }
      return xlAlignment1.Equals(xlAlignment);
    }

    private Dictionary<IXLBorder, XLWorkbook.BorderInfo> ResolveBorders(WorkbookStylesPart workbookStylesPart, Dictionary<IXLBorder, XLWorkbook.BorderInfo> sharedBorders)
    {
      if (workbookStylesPart.Stylesheet.Borders == null)
        workbookStylesPart.Stylesheet.Borders = new Borders();
      Dictionary<IXLBorder, XLWorkbook.BorderInfo> dictionary = new Dictionary<IXLBorder, XLWorkbook.BorderInfo>();
      foreach (XLWorkbook.BorderInfo borderInfo in sharedBorders.Values)
      {
        int num = 0;
        bool flag = false;
        foreach (Border border in (OpenXmlElement) workbookStylesPart.Stylesheet.Borders)
        {
          if (this.BordersAreEqual(border, (IXLBorder) borderInfo.Border))
          {
            flag = true;
            break;
          }
          ++num;
        }
        if (!flag)
        {
          Border newBorder = XLWorkbook.GetNewBorder(borderInfo, true);
          workbookStylesPart.Stylesheet.Borders.AppendChild<Border>(newBorder);
        }
        dictionary.Add((IXLBorder) borderInfo.Border, new XLWorkbook.BorderInfo()
        {
          Border = borderInfo.Border,
          BorderId = (uint) num
        });
      }
      workbookStylesPart.Stylesheet.Borders.Count = (UInt32Value) ((uint) workbookStylesPart.Stylesheet.Borders.Count<OpenXmlElement>());
      return dictionary;
    }

    private static Border GetNewBorder(XLWorkbook.BorderInfo borderInfo, bool ignoreMod = true)
    {
      Border border = new Border();
      if (borderInfo.Border.DiagonalUpModified || ignoreMod)
        border.DiagonalUp = (BooleanValue) borderInfo.Border.DiagonalUp;
      if (borderInfo.Border.DiagonalDownModified || ignoreMod)
        border.DiagonalDown = (BooleanValue) borderInfo.Border.DiagonalDown;
      if (borderInfo.Border.LeftBorderModified || borderInfo.Border.LeftBorderColorModified || ignoreMod)
      {
        DocumentFormat.OpenXml.Spreadsheet.LeftBorder leftBorder = new DocumentFormat.OpenXml.Spreadsheet.LeftBorder();
        leftBorder.Style = (EnumValue<BorderStyleValues>) borderInfo.Border.LeftBorder.ToOpenXml();
        DocumentFormat.OpenXml.Spreadsheet.LeftBorder newChild = leftBorder;
        if (borderInfo.Border.LeftBorderColorModified || ignoreMod)
        {
          DocumentFormat.OpenXml.Spreadsheet.Color newColor = XLWorkbook.GetNewColor(borderInfo.Border.LeftBorderColor);
          newChild.AppendChild<DocumentFormat.OpenXml.Spreadsheet.Color>(newColor);
        }
        border.AppendChild<DocumentFormat.OpenXml.Spreadsheet.LeftBorder>(newChild);
      }
      if (borderInfo.Border.RightBorderModified || borderInfo.Border.RightBorderColorModified || ignoreMod)
      {
        DocumentFormat.OpenXml.Spreadsheet.RightBorder rightBorder = new DocumentFormat.OpenXml.Spreadsheet.RightBorder();
        rightBorder.Style = (EnumValue<BorderStyleValues>) borderInfo.Border.RightBorder.ToOpenXml();
        DocumentFormat.OpenXml.Spreadsheet.RightBorder newChild = rightBorder;
        if (borderInfo.Border.RightBorderColorModified || ignoreMod)
        {
          DocumentFormat.OpenXml.Spreadsheet.Color newColor = XLWorkbook.GetNewColor(borderInfo.Border.RightBorderColor);
          newChild.AppendChild<DocumentFormat.OpenXml.Spreadsheet.Color>(newColor);
        }
        border.AppendChild<DocumentFormat.OpenXml.Spreadsheet.RightBorder>(newChild);
      }
      if (borderInfo.Border.TopBorderModified || borderInfo.Border.TopBorderColorModified || ignoreMod)
      {
        DocumentFormat.OpenXml.Spreadsheet.TopBorder topBorder = new DocumentFormat.OpenXml.Spreadsheet.TopBorder();
        topBorder.Style = (EnumValue<BorderStyleValues>) borderInfo.Border.TopBorder.ToOpenXml();
        DocumentFormat.OpenXml.Spreadsheet.TopBorder newChild = topBorder;
        if (borderInfo.Border.TopBorderColorModified || ignoreMod)
        {
          DocumentFormat.OpenXml.Spreadsheet.Color newColor = XLWorkbook.GetNewColor(borderInfo.Border.TopBorderColor);
          newChild.AppendChild<DocumentFormat.OpenXml.Spreadsheet.Color>(newColor);
        }
        border.AppendChild<DocumentFormat.OpenXml.Spreadsheet.TopBorder>(newChild);
      }
      if (borderInfo.Border.BottomBorderModified || borderInfo.Border.BottomBorderColorModified || ignoreMod)
      {
        DocumentFormat.OpenXml.Spreadsheet.BottomBorder bottomBorder = new DocumentFormat.OpenXml.Spreadsheet.BottomBorder();
        bottomBorder.Style = (EnumValue<BorderStyleValues>) borderInfo.Border.BottomBorder.ToOpenXml();
        DocumentFormat.OpenXml.Spreadsheet.BottomBorder newChild = bottomBorder;
        if (borderInfo.Border.BottomBorderColorModified || ignoreMod)
        {
          DocumentFormat.OpenXml.Spreadsheet.Color newColor = XLWorkbook.GetNewColor(borderInfo.Border.BottomBorderColor);
          newChild.AppendChild<DocumentFormat.OpenXml.Spreadsheet.Color>(newColor);
        }
        border.AppendChild<DocumentFormat.OpenXml.Spreadsheet.BottomBorder>(newChild);
      }
      if (borderInfo.Border.DiagonalBorderModified || borderInfo.Border.DiagonalBorderColorModified || ignoreMod)
      {
        DiagonalBorder diagonalBorder = new DiagonalBorder();
        diagonalBorder.Style = (EnumValue<BorderStyleValues>) borderInfo.Border.DiagonalBorder.ToOpenXml();
        DiagonalBorder newChild = diagonalBorder;
        if (borderInfo.Border.DiagonalBorderColorModified || ignoreMod)
        {
          DocumentFormat.OpenXml.Spreadsheet.Color newColor = XLWorkbook.GetNewColor(borderInfo.Border.DiagonalBorderColor);
          newChild.AppendChild<DocumentFormat.OpenXml.Spreadsheet.Color>(newColor);
        }
        border.AppendChild<DiagonalBorder>(newChild);
      }
      return border;
    }

    private bool BordersAreEqual(Border b, IXLBorder xlBorder)
    {
      XLBorder xlBorder1 = new XLBorder();
      if (b.DiagonalUp != null)
        xlBorder1.DiagonalUp = b.DiagonalUp.Value;
      if (b.DiagonalDown != null)
        xlBorder1.DiagonalDown = b.DiagonalDown.Value;
      if (b.LeftBorder != null)
      {
        if (b.LeftBorder.Style != null)
          xlBorder1.LeftBorder = b.LeftBorder.Style.Value.ToClosedXml();
        XLColor color = this.GetColor((DocumentFormat.OpenXml.Spreadsheet.ColorType) b.LeftBorder.Color);
        if (color.HasValue)
          xlBorder1.LeftBorderColor = color;
      }
      if (b.RightBorder != null)
      {
        if (b.RightBorder.Style != null)
          xlBorder1.RightBorder = b.RightBorder.Style.Value.ToClosedXml();
        XLColor color = this.GetColor((DocumentFormat.OpenXml.Spreadsheet.ColorType) b.RightBorder.Color);
        if (color.HasValue)
          xlBorder1.RightBorderColor = color;
      }
      if (b.TopBorder != null)
      {
        if (b.TopBorder.Style != null)
          xlBorder1.TopBorder = b.TopBorder.Style.Value.ToClosedXml();
        XLColor color = this.GetColor((DocumentFormat.OpenXml.Spreadsheet.ColorType) b.TopBorder.Color);
        if (color.HasValue)
          xlBorder1.TopBorderColor = color;
      }
      if (b.BottomBorder != null)
      {
        if (b.BottomBorder.Style != null)
          xlBorder1.BottomBorder = b.BottomBorder.Style.Value.ToClosedXml();
        XLColor color = this.GetColor((DocumentFormat.OpenXml.Spreadsheet.ColorType) b.BottomBorder.Color);
        if (color.HasValue)
          xlBorder1.BottomBorderColor = color;
      }
      return xlBorder1.Equals(xlBorder);
    }

    private Dictionary<IXLFill, XLWorkbook.FillInfo> ResolveFills(WorkbookStylesPart workbookStylesPart, Dictionary<IXLFill, XLWorkbook.FillInfo> sharedFills)
    {
      if (workbookStylesPart.Stylesheet.Fills == null)
        workbookStylesPart.Stylesheet.Fills = new Fills();
      XLWorkbook.ResolveFillWithPattern(workbookStylesPart.Stylesheet.Fills, PatternValues.None);
      XLWorkbook.ResolveFillWithPattern(workbookStylesPart.Stylesheet.Fills, PatternValues.Gray125);
      Dictionary<IXLFill, XLWorkbook.FillInfo> dictionary = new Dictionary<IXLFill, XLWorkbook.FillInfo>();
      foreach (XLWorkbook.FillInfo fillInfo in sharedFills.Values)
      {
        int num = 0;
        bool flag = false;
        foreach (DocumentFormat.OpenXml.Spreadsheet.Fill fill in (OpenXmlElement) workbookStylesPart.Stylesheet.Fills)
        {
          if (this.FillsAreEqual(fill, (IXLFill) fillInfo.Fill))
          {
            flag = true;
            break;
          }
          ++num;
        }
        if (!flag)
        {
          DocumentFormat.OpenXml.Spreadsheet.Fill newFill = XLWorkbook.GetNewFill(fillInfo, true);
          workbookStylesPart.Stylesheet.Fills.AppendChild<DocumentFormat.OpenXml.Spreadsheet.Fill>(newFill);
        }
        dictionary.Add((IXLFill) fillInfo.Fill, new XLWorkbook.FillInfo()
        {
          Fill = fillInfo.Fill,
          FillId = (uint) num
        });
      }
      workbookStylesPart.Stylesheet.Fills.Count = (UInt32Value) ((uint) workbookStylesPart.Stylesheet.Fills.Count<OpenXmlElement>());
      return dictionary;
    }

    private static void ResolveFillWithPattern(Fills fills, PatternValues patternValues)
    {
      if (fills.Elements<DocumentFormat.OpenXml.Spreadsheet.Fill>().Any<DocumentFormat.OpenXml.Spreadsheet.Fill>((Func<DocumentFormat.OpenXml.Spreadsheet.Fill, bool>) (f =>
      {
        if ((PatternValues) f.PatternFill.PatternType == patternValues && f.PatternFill.ForegroundColor == null)
          return f.PatternFill.BackgroundColor == null;
        return false;
      })))
        return;
      DocumentFormat.OpenXml.Spreadsheet.Fill newChild1 = new DocumentFormat.OpenXml.Spreadsheet.Fill();
      DocumentFormat.OpenXml.Spreadsheet.PatternFill newChild2 = new DocumentFormat.OpenXml.Spreadsheet.PatternFill()
      {
        PatternType = (EnumValue<PatternValues>) patternValues
      };
      newChild1.AppendChild<DocumentFormat.OpenXml.Spreadsheet.PatternFill>(newChild2);
      fills.AppendChild<DocumentFormat.OpenXml.Spreadsheet.Fill>(newChild1);
    }

    private static DocumentFormat.OpenXml.Spreadsheet.Fill GetNewFill(XLWorkbook.FillInfo fillInfo, bool ignoreMod = true)
    {
      DocumentFormat.OpenXml.Spreadsheet.Fill fill = new DocumentFormat.OpenXml.Spreadsheet.Fill();
      DocumentFormat.OpenXml.Spreadsheet.PatternFill newChild1 = new DocumentFormat.OpenXml.Spreadsheet.PatternFill();
      if (fillInfo.Fill.PatternTypeModified || ignoreMod)
        newChild1.PatternType = (EnumValue<PatternValues>) fillInfo.Fill.PatternType.ToOpenXml();
      if (fillInfo.Fill.PatternColorModified || ignoreMod)
      {
        DocumentFormat.OpenXml.Spreadsheet.ForegroundColor newChild2 = new DocumentFormat.OpenXml.Spreadsheet.ForegroundColor();
        if (fillInfo.Fill.PatternColor.ColorType == XLColorType.Color)
          newChild2.Rgb = (HexBinaryValue) fillInfo.Fill.PatternColor.Color.ToHex();
        else if (fillInfo.Fill.PatternColor.ColorType == XLColorType.Indexed)
        {
          newChild2.Indexed = (UInt32Value) ((uint) fillInfo.Fill.PatternColor.Indexed);
        }
        else
        {
          newChild2.Theme = (UInt32Value) ((uint) fillInfo.Fill.PatternColor.ThemeColor);
          if (fillInfo.Fill.PatternColor.ThemeTint != 0.0)
            newChild2.Tint = (DoubleValue) fillInfo.Fill.PatternColor.ThemeTint;
        }
        newChild1.AppendChild<DocumentFormat.OpenXml.Spreadsheet.ForegroundColor>(newChild2);
      }
      if (fillInfo.Fill.PatternBackgroundColorModified || ignoreMod)
      {
        DocumentFormat.OpenXml.Spreadsheet.BackgroundColor newChild2 = new DocumentFormat.OpenXml.Spreadsheet.BackgroundColor();
        if (fillInfo.Fill.PatternBackgroundColor.ColorType == XLColorType.Color)
          newChild2.Rgb = (HexBinaryValue) fillInfo.Fill.PatternBackgroundColor.Color.ToHex();
        else if (fillInfo.Fill.PatternBackgroundColor.ColorType == XLColorType.Indexed)
        {
          newChild2.Indexed = (UInt32Value) ((uint) fillInfo.Fill.PatternBackgroundColor.Indexed);
        }
        else
        {
          newChild2.Theme = (UInt32Value) ((uint) fillInfo.Fill.PatternBackgroundColor.ThemeColor);
          if (fillInfo.Fill.PatternBackgroundColor.ThemeTint != 0.0)
            newChild2.Tint = (DoubleValue) fillInfo.Fill.PatternBackgroundColor.ThemeTint;
        }
        newChild1.AppendChild<DocumentFormat.OpenXml.Spreadsheet.BackgroundColor>(newChild2);
      }
      fill.AppendChild<DocumentFormat.OpenXml.Spreadsheet.PatternFill>(newChild1);
      return fill;
    }

    private bool FillsAreEqual(DocumentFormat.OpenXml.Spreadsheet.Fill f, IXLFill xlFill)
    {
      XLFill xlFill1 = new XLFill();
      if (f.PatternFill != null)
      {
        if (f.PatternFill.PatternType != null)
          xlFill1.PatternType = f.PatternFill.PatternType.Value.ToClosedXml();
        XLColor color1 = this.GetColor((DocumentFormat.OpenXml.Spreadsheet.ColorType) f.PatternFill.ForegroundColor);
        if (color1.HasValue)
          xlFill1.PatternColor = color1;
        XLColor color2 = this.GetColor((DocumentFormat.OpenXml.Spreadsheet.ColorType) f.PatternFill.BackgroundColor);
        if (color2.HasValue)
          xlFill1.PatternBackgroundColor = color2;
      }
      return xlFill1.Equals(xlFill);
    }

    private void ResolveFonts(WorkbookStylesPart workbookStylesPart, XLWorkbook.SaveContext context)
    {
      if (workbookStylesPart.Stylesheet.Fonts == null)
        workbookStylesPart.Stylesheet.Fonts = new DocumentFormat.OpenXml.Spreadsheet.Fonts();
      Dictionary<IXLFont, XLWorkbook.FontInfo> dictionary = new Dictionary<IXLFont, XLWorkbook.FontInfo>();
      foreach (XLWorkbook.FontInfo fontInfo in context.SharedFonts.Values)
      {
        int num = 0;
        bool flag = false;
        foreach (DocumentFormat.OpenXml.Spreadsheet.Font font in (OpenXmlElement) workbookStylesPart.Stylesheet.Fonts)
        {
          if (this.FontsAreEqual(font, (IXLFont) fontInfo.Font))
          {
            flag = true;
            break;
          }
          ++num;
        }
        if (!flag)
        {
          DocumentFormat.OpenXml.Spreadsheet.Font newFont = XLWorkbook.GetNewFont(fontInfo, true);
          workbookStylesPart.Stylesheet.Fonts.AppendChild<DocumentFormat.OpenXml.Spreadsheet.Font>(newFont);
        }
        dictionary.Add((IXLFont) fontInfo.Font, new XLWorkbook.FontInfo()
        {
          Font = fontInfo.Font,
          FontId = (uint) num
        });
      }
      context.SharedFonts.Clear();
      foreach (KeyValuePair<IXLFont, XLWorkbook.FontInfo> keyValuePair in dictionary)
        context.SharedFonts.Add(keyValuePair.Key, keyValuePair.Value);
      workbookStylesPart.Stylesheet.Fonts.Count = (UInt32Value) ((uint) workbookStylesPart.Stylesheet.Fonts.Count<OpenXmlElement>());
    }

    private static DocumentFormat.OpenXml.Spreadsheet.Font GetNewFont(XLWorkbook.FontInfo fontInfo, bool ignoreMod = true)
    {
      DocumentFormat.OpenXml.Spreadsheet.Font font = new DocumentFormat.OpenXml.Spreadsheet.Font();
      Bold newChild1 = !fontInfo.Font.BoldModified && !ignoreMod || !fontInfo.Font.Bold ? (Bold) null : new Bold();
      Italic newChild2 = !fontInfo.Font.ItalicModified && !ignoreMod || !fontInfo.Font.Italic ? (Italic) null : new Italic();
      DocumentFormat.OpenXml.Spreadsheet.Underline underline;
      if (!fontInfo.Font.UnderlineModified && !ignoreMod || fontInfo.Font.Underline == XLFontUnderlineValues.None)
        underline = (DocumentFormat.OpenXml.Spreadsheet.Underline) null;
      else
        underline = new DocumentFormat.OpenXml.Spreadsheet.Underline()
        {
          Val = (EnumValue<UnderlineValues>) fontInfo.Font.Underline.ToOpenXml()
        };
      DocumentFormat.OpenXml.Spreadsheet.Underline newChild3 = underline;
      Strike newChild4 = !fontInfo.Font.StrikethroughModified && !ignoreMod || !fontInfo.Font.Strikethrough ? (Strike) null : new Strike();
      DocumentFormat.OpenXml.Spreadsheet.VerticalTextAlignment verticalTextAlignment;
      if (!fontInfo.Font.VerticalAlignmentModified && !ignoreMod)
        verticalTextAlignment = (DocumentFormat.OpenXml.Spreadsheet.VerticalTextAlignment) null;
      else
        verticalTextAlignment = new DocumentFormat.OpenXml.Spreadsheet.VerticalTextAlignment()
        {
          Val = (EnumValue<VerticalAlignmentRunValues>) fontInfo.Font.VerticalAlignment.ToOpenXml()
        };
      DocumentFormat.OpenXml.Spreadsheet.VerticalTextAlignment newChild5 = verticalTextAlignment;
      DocumentFormat.OpenXml.Spreadsheet.Shadow newChild6 = !fontInfo.Font.ShadowModified && !ignoreMod || !fontInfo.Font.Shadow ? (DocumentFormat.OpenXml.Spreadsheet.Shadow) null : new DocumentFormat.OpenXml.Spreadsheet.Shadow();
      FontSize fontSize;
      if (!fontInfo.Font.FontSizeModified && !ignoreMod)
        fontSize = (FontSize) null;
      else
        fontSize = new FontSize()
        {
          Val = (DoubleValue) fontInfo.Font.FontSize
        };
      FontSize newChild7 = fontSize;
      DocumentFormat.OpenXml.Spreadsheet.Color newChild8 = fontInfo.Font.FontColorModified || ignoreMod ? XLWorkbook.GetNewColor(fontInfo.Font.FontColor) : (DocumentFormat.OpenXml.Spreadsheet.Color) null;
      FontName fontName;
      if (!fontInfo.Font.FontNameModified && !ignoreMod)
        fontName = (FontName) null;
      else
        fontName = new FontName()
        {
          Val = (StringValue) fontInfo.Font.FontName
        };
      FontName newChild9 = fontName;
      FontFamilyNumbering fontFamilyNumbering;
      if (!fontInfo.Font.FontFamilyNumberingModified && !ignoreMod)
        fontFamilyNumbering = (FontFamilyNumbering) null;
      else
        fontFamilyNumbering = new FontFamilyNumbering()
        {
          Val = (Int32Value) ((int) fontInfo.Font.FontFamilyNumbering)
        };
      FontFamilyNumbering newChild10 = fontFamilyNumbering;
      if (newChild1 != null)
        font.AppendChild<Bold>(newChild1);
      if (newChild2 != null)
        font.AppendChild<Italic>(newChild2);
      if (newChild3 != null)
        font.AppendChild<DocumentFormat.OpenXml.Spreadsheet.Underline>(newChild3);
      if (newChild4 != null)
        font.AppendChild<Strike>(newChild4);
      if (newChild5 != null)
        font.AppendChild<DocumentFormat.OpenXml.Spreadsheet.VerticalTextAlignment>(newChild5);
      if (newChild6 != null)
        font.AppendChild<DocumentFormat.OpenXml.Spreadsheet.Shadow>(newChild6);
      if (newChild7 != null)
        font.AppendChild<FontSize>(newChild7);
      if (newChild8 != null)
        font.AppendChild<DocumentFormat.OpenXml.Spreadsheet.Color>(newChild8);
      if (newChild9 != null)
        font.AppendChild<FontName>(newChild9);
      if (newChild10 != null)
        font.AppendChild<FontFamilyNumbering>(newChild10);
      return font;
    }

    private static DocumentFormat.OpenXml.Spreadsheet.Color GetNewColor(XLColor xlColor)
    {
      DocumentFormat.OpenXml.Spreadsheet.Color color = new DocumentFormat.OpenXml.Spreadsheet.Color();
      if (xlColor.ColorType == XLColorType.Color)
        color.Rgb = (HexBinaryValue) xlColor.Color.ToHex();
      else if (xlColor.ColorType == XLColorType.Indexed)
      {
        color.Indexed = (UInt32Value) ((uint) xlColor.Indexed);
      }
      else
      {
        color.Theme = (UInt32Value) ((uint) xlColor.ThemeColor);
        if (xlColor.ThemeTint != 0.0)
          color.Tint = (DoubleValue) xlColor.ThemeTint;
      }
      return color;
    }

    private static TabColor GetTabColor(XLColor xlColor)
    {
      TabColor tabColor = new TabColor();
      if (xlColor.ColorType == XLColorType.Color)
        tabColor.Rgb = (HexBinaryValue) xlColor.Color.ToHex();
      else if (xlColor.ColorType == XLColorType.Indexed)
      {
        tabColor.Indexed = (UInt32Value) ((uint) xlColor.Indexed);
      }
      else
      {
        tabColor.Theme = (UInt32Value) ((uint) xlColor.ThemeColor);
        if (xlColor.ThemeTint != 0.0)
          tabColor.Tint = (DoubleValue) xlColor.ThemeTint;
      }
      return tabColor;
    }

    private bool FontsAreEqual(DocumentFormat.OpenXml.Spreadsheet.Font f, IXLFont xlFont)
    {
      XLFont xlFont1 = new XLFont()
      {
        Bold = f.Bold != null,
        Italic = f.Italic != null
      };
      if (f.Underline != null)
        xlFont1.Underline = f.Underline.Val != null ? f.Underline.Val.Value.ToClosedXml() : XLFontUnderlineValues.Single;
      xlFont1.Strikethrough = f.Strike != null;
      if (f.VerticalTextAlignment != null)
        xlFont1.VerticalAlignment = f.VerticalTextAlignment.Val != null ? f.VerticalTextAlignment.Val.Value.ToClosedXml() : XLFontVerticalTextAlignmentValues.Baseline;
      xlFont1.Shadow = f.Shadow != null;
      if (f.FontSize != null)
        xlFont1.FontSize = (double) f.FontSize.Val;
      XLColor color = this.GetColor((DocumentFormat.OpenXml.Spreadsheet.ColorType) f.Color);
      if (color.HasValue)
        xlFont1.FontColor = color;
      if (f.FontName != null)
        xlFont1.FontName = (string) f.FontName.Val;
      if (f.FontFamilyNumbering != null)
        xlFont1.FontFamilyNumbering = (XLFontFamilyNumberingValues) f.FontFamilyNumbering.Val.Value;
      return xlFont1.Equals(xlFont);
    }

    private static Dictionary<IXLNumberFormat, XLWorkbook.NumberFormatInfo> ResolveNumberFormats(WorkbookStylesPart workbookStylesPart, Dictionary<IXLNumberFormat, XLWorkbook.NumberFormatInfo> sharedNumberFormats)
    {
      if (workbookStylesPart.Stylesheet.NumberingFormats == null)
        workbookStylesPart.Stylesheet.NumberingFormats = new NumberingFormats();
      Dictionary<IXLNumberFormat, XLWorkbook.NumberFormatInfo> dictionary = new Dictionary<IXLNumberFormat, XLWorkbook.NumberFormatInfo>();
      foreach (XLWorkbook.NumberFormatInfo numberFormatInfo in sharedNumberFormats.Values)
      {
        int num = 0;
        bool flag = false;
        foreach (NumberingFormat numberingFormat in (OpenXmlElement) workbookStylesPart.Stylesheet.NumberingFormats)
        {
          if (XLWorkbook.NumberFormatsAreEqual(numberingFormat, numberFormatInfo.NumberFormat))
          {
            flag = true;
            num = (int) numberingFormat.NumberFormatId.Value;
            break;
          }
          ++num;
        }
        if (!flag)
        {
          NumberingFormat newChild = new NumberingFormat()
          {
            NumberFormatId = (UInt32Value) ((uint) num),
            FormatCode = (StringValue) numberFormatInfo.NumberFormat.Format
          };
          workbookStylesPart.Stylesheet.NumberingFormats.AppendChild<NumberingFormat>(newChild);
        }
        dictionary.Add(numberFormatInfo.NumberFormat, new XLWorkbook.NumberFormatInfo()
        {
          NumberFormat = numberFormatInfo.NumberFormat,
          NumberFormatId = num
        });
      }
      workbookStylesPart.Stylesheet.NumberingFormats.Count = (UInt32Value) ((uint) workbookStylesPart.Stylesheet.NumberingFormats.Count<OpenXmlElement>());
      return dictionary;
    }

    private static bool NumberFormatsAreEqual(NumberingFormat nf, IXLNumberFormat xlNumberFormat)
    {
      XLNumberFormat xlNumberFormat1 = new XLNumberFormat();
      if (nf.FormatCode != null && !XLHelper.IsNullOrWhiteSpace(nf.FormatCode.Value))
        xlNumberFormat1.Format = nf.FormatCode.Value;
      else if (nf.NumberFormatId != null)
        xlNumberFormat1.NumberFormatId = (int) nf.NumberFormatId.Value;
      return xlNumberFormat1.Equals(xlNumberFormat);
    }

    private static void GenerateWorksheetPartContent(WorksheetPart worksheetPart, XLWorksheet xlWorksheet, XLWorkbook.SaveContext context)
    {
      if (worksheetPart.Worksheet == null)
        worksheetPart.Worksheet = new Worksheet();
      XLWorkbook.GenerateTables(xlWorksheet, worksheetPart, context);
      if (!worksheetPart.Worksheet.NamespaceDeclarations.Contains<KeyValuePair<string, string>>(new KeyValuePair<string, string>("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships")))
        worksheetPart.Worksheet.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
      XLWSContentManager xlwsContentManager = new XLWSContentManager(worksheetPart.Worksheet);
      if (worksheetPart.Worksheet.SheetProperties == null)
        worksheetPart.Worksheet.SheetProperties = new SheetProperties();
      worksheetPart.Worksheet.SheetProperties.TabColor = xlWorksheet.TabColor.HasValue ? XLWorkbook.GetTabColor(xlWorksheet.TabColor) : (TabColor) null;
      xlwsContentManager.SetElement(XLWSContentManager.XLWSContents.SheetProperties, (OpenXmlElement) worksheetPart.Worksheet.SheetProperties);
      if (worksheetPart.Worksheet.SheetProperties.OutlineProperties == null)
        worksheetPart.Worksheet.SheetProperties.OutlineProperties = new OutlineProperties();
      worksheetPart.Worksheet.SheetProperties.OutlineProperties.SummaryBelow = (BooleanValue) (xlWorksheet.Outline.SummaryVLocation == XLOutlineSummaryVLocation.Bottom);
      worksheetPart.Worksheet.SheetProperties.OutlineProperties.SummaryRight = (BooleanValue) (xlWorksheet.Outline.SummaryHLocation == XLOutlineSummaryHLocation.Right);
      if (worksheetPart.Worksheet.SheetProperties.PageSetupProperties == null && (xlWorksheet.PageSetup.PagesTall > 0 || xlWorksheet.PageSetup.PagesWide > 0))
        worksheetPart.Worksheet.SheetProperties.PageSetupProperties = new PageSetupProperties()
        {
          FitToPage = (BooleanValue) true
        };
      int columnNumber1 = 0;
      string str1 = "A1";
      if (xlWorksheet.Internals.CellsCollection.Count > 0)
      {
        columnNumber1 = xlWorksheet.Internals.CellsCollection.MaxColumnUsed;
        int maxRowUsed = xlWorksheet.Internals.CellsCollection.MaxRowUsed;
        str1 = "A1:" + XLHelper.GetColumnLetterFromNumber(columnNumber1) + maxRowUsed.ToInvariantString();
      }
      if (xlWorksheet.Internals.ColumnsCollection.Count > 0)
      {
        int num = xlWorksheet.Internals.ColumnsCollection.Keys.Max();
        if (num > columnNumber1)
          columnNumber1 = num;
      }
      if (worksheetPart.Worksheet.SheetDimension == null)
        worksheetPart.Worksheet.SheetDimension = new SheetDimension()
        {
          Reference = (StringValue) str1
        };
      xlwsContentManager.SetElement(XLWSContentManager.XLWSContents.SheetDimension, (OpenXmlElement) worksheetPart.Worksheet.SheetDimension);
      if (worksheetPart.Worksheet.SheetViews == null)
        worksheetPart.Worksheet.SheetViews = new SheetViews();
      xlwsContentManager.SetElement(XLWSContentManager.XLWSContents.SheetViews, (OpenXmlElement) worksheetPart.Worksheet.SheetViews);
      SheetView newChild1 = (SheetView) worksheetPart.Worksheet.SheetViews.FirstOrDefault<OpenXmlElement>();
      if (newChild1 == null)
      {
        newChild1 = new SheetView()
        {
          WorkbookViewId = (UInt32Value) 0U
        };
        worksheetPart.Worksheet.SheetViews.AppendChild<SheetView>(newChild1);
      }
      newChild1.TabSelected = !xlWorksheet.TabSelected ? (BooleanValue) null : (BooleanValue) true;
      newChild1.ShowFormulas = !xlWorksheet.ShowFormulas ? (BooleanValue) null : (BooleanValue) true;
      newChild1.ShowGridLines = !xlWorksheet.ShowGridLines ? (BooleanValue) false : (BooleanValue) null;
      newChild1.ShowOutlineSymbols = !xlWorksheet.ShowOutlineSymbols ? (BooleanValue) false : (BooleanValue) null;
      newChild1.ShowRowColHeaders = !xlWorksheet.ShowRowColHeaders ? (BooleanValue) false : (BooleanValue) null;
      newChild1.ShowRuler = !xlWorksheet.ShowRuler ? (BooleanValue) false : (BooleanValue) null;
      newChild1.ShowWhiteSpace = !xlWorksheet.ShowWhiteSpace ? (BooleanValue) false : (BooleanValue) null;
      newChild1.ShowZeros = !xlWorksheet.ShowZeros ? (BooleanValue) false : (BooleanValue) null;
      newChild1.RightToLeft = !xlWorksheet.RightToLeft ? (BooleanValue) null : (BooleanValue) true;
      newChild1.View = xlWorksheet.SheetView.View != XLSheetViewOptions.Normal ? (EnumValue<SheetViewValues>) xlWorksheet.SheetView.View.ToOpenXml() : (EnumValue<SheetViewValues>) null;
      Pane newChild2 = newChild1.Elements<Pane>().FirstOrDefault<Pane>();
      if (newChild2 == null)
      {
        newChild2 = new Pane();
        newChild1.AppendChild<Pane>(newChild2);
      }
      newChild2.State = (EnumValue<PaneStateValues>) PaneStateValues.FrozenSplit;
      double splitColumn = (double) xlWorksheet.SheetView.SplitColumn;
      double splitRow = (double) xlWorksheet.SheetView.SplitRow;
      newChild2.HorizontalSplit = (DoubleValue) splitColumn;
      newChild2.VerticalSplit = (DoubleValue) splitRow;
      newChild2.TopLeftCell = (StringValue) (XLHelper.GetColumnLetterFromNumber(xlWorksheet.SheetView.SplitColumn + 1) + (object) (xlWorksheet.SheetView.SplitRow + 1));
      if (splitColumn == 0.0 && splitRow == 0.0)
        newChild1.RemoveAllChildren<Pane>();
      if (xlWorksheet.SelectedRanges.Any<IXLRange>() || xlWorksheet.ActiveCell != null)
      {
        newChild1.RemoveAllChildren<Selection>();
        IXLRange xlRange = xlWorksheet.SelectedRanges.FirstOrDefault<IXLRange>();
        Selection selection1 = new Selection();
        if (xlWorksheet.ActiveCell != null)
          selection1.ActiveCell = (StringValue) xlWorksheet.ActiveCell.Address.ToStringRelative(false);
        else if (xlRange != null)
          selection1.ActiveCell = (StringValue) xlRange.RangeAddress.FirstAddress.ToStringRelative(false);
        List<string> source = new List<string>()
        {
          selection1.ActiveCell.Value
        };
        source.AddRange(xlWorksheet.SelectedRanges.Select<IXLRange, string>((Func<IXLRange, string>) (range => range.RangeAddress.ToStringRelative(false))));
        Selection selection2 = selection1;
        ListValue<StringValue> listValue1 = new ListValue<StringValue>();
        listValue1.InnerText = string.Join(" ", source.Distinct<string>().ToArray<string>());
        ListValue<StringValue> listValue2 = listValue1;
        selection2.SequenceOfReferences = listValue2;
        newChild1.Append(new OpenXmlElement[1]
        {
          (OpenXmlElement) selection1
        });
      }
      int num1 = 0;
      if (xlWorksheet.ColumnCount() > 0)
        num1 = xlWorksheet.GetMaxColumnOutline();
      int num2 = 0;
      if (xlWorksheet.RowCount() > 0)
        num2 = xlWorksheet.GetMaxRowOutline();
      if (worksheetPart.Worksheet.SheetFormatProperties == null)
        worksheetPart.Worksheet.SheetFormatProperties = new SheetFormatProperties();
      xlwsContentManager.SetElement(XLWSContentManager.XLWSContents.SheetFormatProperties, (OpenXmlElement) worksheetPart.Worksheet.SheetFormatProperties);
      worksheetPart.Worksheet.SheetFormatProperties.DefaultRowHeight = (DoubleValue) xlWorksheet.RowHeight;
      worksheetPart.Worksheet.SheetFormatProperties.CustomHeight = !xlWorksheet.RowHeightChanged ? (BooleanValue) null : (BooleanValue) true;
      double columnWidth = XLWorkbook.GetColumnWidth(xlWorksheet.ColumnWidth);
      worksheetPart.Worksheet.SheetFormatProperties.DefaultColumnWidth = !xlWorksheet.ColumnWidthChanged ? (DoubleValue) null : (DoubleValue) columnWidth;
      worksheetPart.Worksheet.SheetFormatProperties.OutlineLevelColumn = num1 <= 0 ? (ByteValue) null : (ByteValue) ((byte) num1);
      worksheetPart.Worksheet.SheetFormatProperties.OutlineLevelRow = num2 <= 0 ? (ByteValue) null : (ByteValue) ((byte) num2);
      if (xlWorksheet.Internals.CellsCollection.Count == 0 && xlWorksheet.Internals.ColumnsCollection.Count == 0 && xlWorksheet.Style.Equals(XLWorkbook.DefaultStyle))
      {
        worksheetPart.Worksheet.RemoveAllChildren<Columns>();
      }
      else
      {
        if (!worksheetPart.Worksheet.Elements<Columns>().Any<Columns>())
        {
          OpenXmlElement previousElementFor = xlwsContentManager.GetPreviousElementFor(XLWSContentManager.XLWSContents.Columns);
          worksheetPart.Worksheet.InsertAfter<Columns>(new Columns(), previousElementFor);
        }
        Columns columns = worksheetPart.Worksheet.Elements<Columns>().First<Columns>();
        xlwsContentManager.SetElement(XLWSContentManager.XLWSContents.Columns, (OpenXmlElement) columns);
        Dictionary<uint, Column> dictionary = columns.Elements<Column>().ToDictionary<Column, uint, Column>((Func<Column, uint>) (c => c.Min.Value), (Func<Column, Column>) (c => c));
        int num3;
        int num4;
        if (xlWorksheet.Internals.ColumnsCollection.Count > 0)
        {
          num3 = xlWorksheet.Internals.ColumnsCollection.Keys.Min();
          num4 = xlWorksheet.Internals.ColumnsCollection.Keys.Max();
        }
        else
        {
          num3 = 1;
          num4 = 0;
        }
        uint styleId1 = context.SharedStyles[xlWorksheet.GetStyleId()].StyleId;
        if (num3 > 1)
        {
          UInt32Value uint32Value1 = (UInt32Value) 1U;
          UInt32Value uint32Value2 = (UInt32Value) ((uint) (num3 - 1));
          for (UInt32Value uint32Value3 = uint32Value1; (uint) uint32Value3 <= (uint) uint32Value2; uint32Value3 = (UInt32Value) ((uint) uint32Value3 + 1U))
            XLWorkbook.UpdateColumn(new Column()
            {
              Min = uint32Value3,
              Max = uint32Value3,
              Style = (UInt32Value) styleId1,
              Width = (DoubleValue) columnWidth,
              CustomWidth = (BooleanValue) true
            }, columns, dictionary);
        }
        for (int key = num3; key <= num4; ++key)
        {
          bool flag1 = false;
          bool flag2 = false;
          int num5 = 0;
          uint styleId2;
          double num6;
          if (xlWorksheet.Internals.ColumnsCollection.ContainsKey(key))
          {
            styleId2 = context.SharedStyles[xlWorksheet.Internals.ColumnsCollection[key].GetStyleId()].StyleId;
            num6 = XLWorkbook.GetColumnWidth(xlWorksheet.Internals.ColumnsCollection[key].Width);
            flag1 = xlWorksheet.Internals.ColumnsCollection[key].IsHidden;
            flag2 = xlWorksheet.Internals.ColumnsCollection[key].Collapsed;
            num5 = xlWorksheet.Internals.ColumnsCollection[key].OutlineLevel;
          }
          else
          {
            styleId2 = context.SharedStyles[xlWorksheet.GetStyleId()].StyleId;
            num6 = columnWidth;
          }
          Column column = new Column()
          {
            Min = (UInt32Value) ((uint) key),
            Max = (UInt32Value) ((uint) key),
            Style = (UInt32Value) styleId2,
            Width = (DoubleValue) num6,
            CustomWidth = (BooleanValue) true
          };
          if (flag1)
            column.Hidden = (BooleanValue) true;
          if (flag2)
            column.Collapsed = (BooleanValue) true;
          if (num5 > 0)
            column.OutlineLevel = (ByteValue) ((byte) num5);
          XLWorkbook.UpdateColumn(column, columns, dictionary);
        }
        int collection = num4;
        foreach (Column column in (IEnumerable<Column>) columns.Elements<Column>().Where<Column>((Func<Column, bool>) (c => (uint) c.Min > (uint) collection)).OrderBy<Column, uint>((Func<Column, uint>) (c => c.Min.Value)))
        {
          column.Style = (UInt32Value) styleId1;
          column.Width = (DoubleValue) columnWidth;
          column.CustomWidth = (BooleanValue) true;
          if ((int) column.Max.Value > num4)
            num4 = (int) column.Max.Value;
        }
        if (num4 < 16384 && !xlWorksheet.Style.Equals(XLWorkbook.DefaultStyle))
        {
          Column newChild3 = new Column()
          {
            Min = (UInt32Value) ((uint) (num4 + 1)),
            Max = (UInt32Value) 16384U,
            Style = (UInt32Value) styleId1,
            Width = (DoubleValue) columnWidth,
            CustomWidth = (BooleanValue) true
          };
          columns.AppendChild<Column>(newChild3);
        }
        XLWorkbook.CollapseColumns(columns, dictionary);
        if (!columns.Any<OpenXmlElement>())
        {
          worksheetPart.Worksheet.RemoveAllChildren<Columns>();
          xlwsContentManager.SetElement(XLWSContentManager.XLWSContents.Columns, (OpenXmlElement) null);
        }
      }
      if (!worksheetPart.Worksheet.Elements<SheetData>().Any<SheetData>())
      {
        OpenXmlElement previousElementFor = xlwsContentManager.GetPreviousElementFor(XLWSContentManager.XLWSContents.SheetData);
        worksheetPart.Worksheet.InsertAfter<SheetData>(new SheetData(), previousElementFor);
      }
      SheetData sheetData = worksheetPart.Worksheet.Elements<SheetData>().First<SheetData>();
      xlwsContentManager.SetElement(XLWSContentManager.XLWSContents.SheetData, (OpenXmlElement) sheetData);
      int lastRow = 0;
      Dictionary<int, Row> sheetDataRows = sheetData.Elements<Row>().ToDictionary<Row, int, Row>((Func<Row, int>) (r =>
      {
        if (r.RowIndex != null)
          return (int) r.RowIndex.Value;
        return ++lastRow;
      }), (Func<Row, Row>) (r => r));
      foreach (KeyValuePair<int, XLRow> keyValuePair in xlWorksheet.Internals.RowsCollection.Deleted.Where<KeyValuePair<int, XLRow>>((Func<KeyValuePair<int, XLRow>, bool>) (r => sheetDataRows.ContainsKey(r.Key))))
      {
        sheetData.RemoveChild<Row>(sheetDataRows[keyValuePair.Key]);
        sheetDataRows.Remove(keyValuePair.Key);
        xlWorksheet.Internals.CellsCollection.deleted.Remove(keyValuePair.Key);
      }
      IEnumerable<int> source1 = xlWorksheet.Internals.CellsCollection.RowsCollection.Keys.Union<int>((IEnumerable<int>) xlWorksheet.Internals.RowsCollection.Keys);
      bool flag3 = sheetData.Elements<Row>().FirstOrDefault<Row>() == null;
      foreach (int num3 in (IEnumerable<int>) source1.OrderBy<int, int>((Func<int, int>) (r => r)))
      {
        int distinctRow = num3;
        Row row;
        if (sheetDataRows.ContainsKey(distinctRow))
        {
          row = sheetDataRows[distinctRow];
        }
        else
        {
          row = new Row()
          {
            RowIndex = (UInt32Value) ((uint) distinctRow)
          };
          if (flag3)
          {
            sheetData.AppendChild<Row>(row);
            flag3 = false;
          }
          else if (sheetDataRows.Any<KeyValuePair<int, Row>>((Func<KeyValuePair<int, Row>, bool>) (r => (long) r.Key > (long) row.RowIndex.Value)))
          {
            int index = sheetDataRows.Where<KeyValuePair<int, Row>>((Func<KeyValuePair<int, Row>, bool>) (r => r.Key > (int) row.RowIndex.Value)).Min<KeyValuePair<int, Row>>((Func<KeyValuePair<int, Row>, int>) (r => r.Key));
            Row row1 = sheetDataRows[index];
            sheetData.InsertBefore<Row>(row, (OpenXmlElement) row1);
          }
          else
            sheetData.AppendChild<Row>(row);
        }
        if (columnNumber1 > 0)
        {
          Row row1 = row;
          ListValue<StringValue> listValue1 = new ListValue<StringValue>();
          listValue1.InnerText = "1:" + columnNumber1.ToInvariantString();
          ListValue<StringValue> listValue2 = listValue1;
          row1.Spans = listValue2;
        }
        row.Height = (DoubleValue) null;
        row.CustomHeight = (BooleanValue) null;
        row.Hidden = (BooleanValue) null;
        row.StyleIndex = (UInt32Value) null;
        row.CustomFormat = (BooleanValue) null;
        row.Collapsed = (BooleanValue) null;
        if (xlWorksheet.Internals.RowsCollection.ContainsKey(distinctRow))
        {
          XLRow rows = xlWorksheet.Internals.RowsCollection[distinctRow];
          if (rows.HeightChanged)
          {
            row.Height = (DoubleValue) rows.Height;
            row.CustomHeight = (BooleanValue) true;
            row.CustomFormat = (BooleanValue) true;
          }
          if (rows.GetStyleId() != xlWorksheet.GetStyleId())
          {
            row.StyleIndex = (UInt32Value) context.SharedStyles[rows.GetStyleId()].StyleId;
            row.CustomFormat = (BooleanValue) true;
          }
          if (rows.IsHidden)
            row.Hidden = (BooleanValue) true;
          if (rows.Collapsed)
            row.Collapsed = (BooleanValue) true;
          if (rows.OutlineLevel > 0)
            row.OutlineLevel = (ByteValue) ((byte) rows.OutlineLevel);
        }
        int lastCell = 0;
        Dictionary<string, Cell> dictionary1 = row.Elements<Cell>().ToDictionary<Cell, string, Cell>((Func<Cell, string>) (c =>
        {
          if (c.CellReference != null)
            return c.CellReference.Value;
          return XLHelper.GetColumnLetterFromNumber(++lastCell) + (object) distinctRow;
        }), (Func<Cell, Cell>) (c => c));
        foreach (KeyValuePair<int, HashSet<int>> keyValuePair in xlWorksheet.Internals.CellsCollection.deleted.ToList<KeyValuePair<int, HashSet<int>>>())
        {
          foreach (int columnNumber2 in keyValuePair.Value.ToList<int>())
          {
            string key = XLHelper.GetColumnLetterFromNumber(columnNumber2) + keyValuePair.Key.ToInvariantString();
            if (dictionary1.ContainsKey(key))
            {
              row.RemoveChild<Cell>(dictionary1[key]);
              keyValuePair.Value.Remove(columnNumber2);
            }
          }
          if (keyValuePair.Value.Count == 0)
            xlWorksheet.Internals.CellsCollection.deleted.Remove(keyValuePair.Key);
        }
        if (xlWorksheet.Internals.CellsCollection.RowsCollection.ContainsKey(distinctRow))
        {
          bool flag1 = !row.Elements<Cell>().Any<Cell>();
          lastCell = 0;
          Dictionary<int, Cell> dictionary2 = row.Elements<Cell>().ToDictionary<Cell, int, Cell>((Func<Cell, int>) (c => XLHelper.GetColumnNumberFromAddress(c.CellReference == null ? XLHelper.GetColumnLetterFromNumber(++lastCell) + (object) distinctRow : c.CellReference.Value)), (Func<Cell, Cell>) (c => c));
          foreach (XLCell xlCell in xlWorksheet.Internals.CellsCollection.RowsCollection[distinctRow].Values.OrderBy<XLCell, int>((Func<XLCell, int>) (c => c.Address.ColumnNumber)).Select<XLCell, XLCell>((Func<XLCell, XLCell>) (c => c)))
          {
            uint styleId = context.SharedStyles[xlCell.GetStyleId()].StyleId;
            XLCellValues dataType = xlCell.DataType;
            string trimmedAddress = xlCell.Address.GetTrimmedAddress();
            Cell newChild3;
            if (dictionary1.ContainsKey(trimmedAddress))
            {
              newChild3 = dictionary1[trimmedAddress];
            }
            else
            {
              newChild3 = new Cell();
              newChild3.CellReference = new StringValue(trimmedAddress);
              if (flag1)
              {
                row.AppendChild<Cell>(newChild3);
              }
              else
              {
                int newColumn = XLHelper.GetColumnNumberFromAddress(trimmedAddress);
                Cell cell = (Cell) null;
                int[] lastCo = new int[1]{ int.MaxValue };
                foreach (KeyValuePair<int, Cell> keyValuePair in dictionary2.Where<KeyValuePair<int, Cell>>((Func<KeyValuePair<int, Cell>, bool>) (kp => kp.Key > newColumn)).Where<KeyValuePair<int, Cell>>((Func<KeyValuePair<int, Cell>, bool>) (c => lastCo[0] > c.Key)))
                {
                  cell = keyValuePair.Value;
                  lastCo[0] = keyValuePair.Key;
                }
                if (cell == null)
                  row.AppendChild<Cell>(newChild3);
                else
                  row.InsertBefore<Cell>(newChild3, (OpenXmlElement) cell);
              }
            }
            newChild3.StyleIndex = (UInt32Value) styleId;
            string formulaA1 = xlCell.FormulaA1;
            if (xlCell.HasFormula)
            {
              if (formulaA1.StartsWith("{"))
              {
                string str2 = formulaA1.Substring(1, formulaA1.Length - 2);
                CellFormula cellFormula = new CellFormula()
                {
                  FormulaType = (EnumValue<CellFormulaValues>) CellFormulaValues.Array
                };
                if (xlCell.FormulaReference == null)
                  xlCell.FormulaReference = (IXLRangeAddress) xlCell.AsRange().RangeAddress;
                if (xlCell.FormulaReference.FirstAddress.Equals((IXLAddress) xlCell.Address))
                {
                  cellFormula.Text = str2;
                  cellFormula.Reference = (StringValue) xlCell.FormulaReference.ToStringRelative();
                }
                newChild3.CellFormula = cellFormula;
              }
              else
              {
                newChild3.CellFormula = new CellFormula();
                newChild3.CellFormula.Text = formulaA1;
              }
              newChild3.CellValue = (CellValue) null;
            }
            else
            {
              newChild3.CellFormula = (CellFormula) null;
              newChild3.DataType = xlCell.DataType == XLCellValues.DateTime ? (EnumValue<CellValues>) null : XLWorkbook.GetCellValue(xlCell);
              CellValue cellValue = new CellValue();
              switch (dataType)
              {
                case XLCellValues.Text:
                  if (xlCell.InnerText.Length == 0)
                  {
                    newChild3.CellValue = (CellValue) null;
                    continue;
                  }
                  if (xlCell.ShareString)
                  {
                    cellValue.Text = xlCell.SharedStringId.ToString();
                    newChild3.CellValue = cellValue;
                    continue;
                  }
                  string text1 = xlCell.GetString();
                  DocumentFormat.OpenXml.Spreadsheet.Text text2 = new DocumentFormat.OpenXml.Spreadsheet.Text(text1);
                  if (text1.PreserveSpaces())
                    text2.Space = (EnumValue<SpaceProcessingModeValues>) SpaceProcessingModeValues.Preserve;
                  Cell cell = newChild3;
                  InlineString inlineString1 = new InlineString();
                  inlineString1.Text = text2;
                  InlineString inlineString2 = inlineString1;
                  cell.InlineString = inlineString2;
                  continue;
                case XLCellValues.Number:
                case XLCellValues.DateTime:
                  if (!XLHelper.IsNullOrWhiteSpace(xlCell.InnerText))
                    cellValue.Text = double.Parse(xlCell.InnerText).ToString((IFormatProvider) CultureInfo.InvariantCulture);
                  newChild3.CellValue = cellValue;
                  continue;
                case XLCellValues.TimeSpan:
                  TimeSpan timeSpan = xlCell.GetTimeSpan();
                  cellValue.Text = XLCell.BaseDate.Add(timeSpan).ToOADate().ToString((IFormatProvider) CultureInfo.InvariantCulture);
                  newChild3.CellValue = cellValue;
                  continue;
                default:
                  cellValue.Text = xlCell.InnerText;
                  newChild3.CellValue = cellValue;
                  continue;
              }
            }
          }
          xlWorksheet.Internals.CellsCollection.deleted.Remove(distinctRow);
        }
      }
      foreach (int key in xlWorksheet.Internals.CellsCollection.deleted.Keys.Where<int>(new Func<int, bool>(sheetDataRows.ContainsKey)))
      {
        sheetData.RemoveChild<Row>(sheetDataRows[key]);
        sheetDataRows.Remove(key);
      }
      if (xlWorksheet.Protection.Protected)
      {
        if (!worksheetPart.Worksheet.Elements<SheetProtection>().Any<SheetProtection>())
        {
          OpenXmlElement previousElementFor = xlwsContentManager.GetPreviousElementFor(XLWSContentManager.XLWSContents.SheetProtection);
          worksheetPart.Worksheet.InsertAfter<SheetProtection>(new SheetProtection(), previousElementFor);
        }
        SheetProtection sheetProtection = worksheetPart.Worksheet.Elements<SheetProtection>().First<SheetProtection>();
        xlwsContentManager.SetElement(XLWSContentManager.XLWSContents.SheetProtection, (OpenXmlElement) sheetProtection);
        XLSheetProtection protection = xlWorksheet.Protection;
        sheetProtection.Sheet = (BooleanValue) protection.Protected;
        if (!XLHelper.IsNullOrWhiteSpace(protection.PasswordHash))
          sheetProtection.Password = (HexBinaryValue) protection.PasswordHash;
        sheetProtection.FormatCells = XLWorkbook.GetBooleanValue(!protection.FormatCells, true);
        sheetProtection.FormatColumns = XLWorkbook.GetBooleanValue(!protection.FormatColumns, true);
        sheetProtection.FormatRows = XLWorkbook.GetBooleanValue(!protection.FormatRows, true);
        sheetProtection.InsertColumns = XLWorkbook.GetBooleanValue(!protection.InsertColumns, true);
        sheetProtection.InsertHyperlinks = XLWorkbook.GetBooleanValue(!protection.InsertHyperlinks, true);
        sheetProtection.InsertRows = XLWorkbook.GetBooleanValue(!protection.InsertRows, true);
        sheetProtection.DeleteColumns = XLWorkbook.GetBooleanValue(!protection.DeleteColumns, true);
        sheetProtection.DeleteRows = XLWorkbook.GetBooleanValue(!protection.DeleteRows, true);
        sheetProtection.AutoFilter = XLWorkbook.GetBooleanValue(!protection.AutoFilter, true);
        sheetProtection.PivotTables = XLWorkbook.GetBooleanValue(!protection.PivotTables, true);
        sheetProtection.Sort = XLWorkbook.GetBooleanValue(!protection.Sort, true);
        sheetProtection.SelectLockedCells = XLWorkbook.GetBooleanValue(!protection.SelectLockedCells, false);
        sheetProtection.SelectUnlockedCells = XLWorkbook.GetBooleanValue(!protection.SelectUnlockedCells, false);
      }
      else
      {
        worksheetPart.Worksheet.RemoveAllChildren<SheetProtection>();
        xlwsContentManager.SetElement(XLWSContentManager.XLWSContents.SheetProtection, (OpenXmlElement) null);
      }
      worksheetPart.Worksheet.RemoveAllChildren<AutoFilter>();
      if (xlWorksheet.AutoFilter.Enabled)
      {
        OpenXmlElement previousElementFor = xlwsContentManager.GetPreviousElementFor(XLWSContentManager.XLWSContents.AutoFilter);
        worksheetPart.Worksheet.InsertAfter<AutoFilter>(new AutoFilter(), previousElementFor);
        AutoFilter autoFilter = worksheetPart.Worksheet.Elements<AutoFilter>().First<AutoFilter>();
        xlwsContentManager.SetElement(XLWSContentManager.XLWSContents.AutoFilter, (OpenXmlElement) autoFilter);
        XLWorkbook.PopulateAutoFilter(xlWorksheet.AutoFilter, autoFilter);
      }
      else
        xlwsContentManager.SetElement(XLWSContentManager.XLWSContents.AutoFilter, (OpenXmlElement) null);
      if (xlWorksheet.Internals.MergedRanges.Any<IXLRange>())
      {
        if (!worksheetPart.Worksheet.Elements<MergeCells>().Any<MergeCells>())
        {
          OpenXmlElement previousElementFor = xlwsContentManager.GetPreviousElementFor(XLWSContentManager.XLWSContents.MergeCells);
          worksheetPart.Worksheet.InsertAfter<MergeCells>(new MergeCells(), previousElementFor);
        }
        MergeCells source2 = worksheetPart.Worksheet.Elements<MergeCells>().First<MergeCells>();
        xlwsContentManager.SetElement(XLWSContentManager.XLWSContents.MergeCells, (OpenXmlElement) source2);
        source2.RemoveAllChildren<MergeCell>();
        foreach (MergeCell newChild3 in xlWorksheet.Internals.MergedRanges.Select<IXLRange, string>((Func<IXLRange, string>) (m => m.RangeAddress.FirstAddress.ToString() + ":" + m.RangeAddress.LastAddress.ToString())).Select<string, MergeCell>((Func<string, MergeCell>) (merged => new MergeCell()
        {
          Reference = (StringValue) merged
        })))
          source2.AppendChild<MergeCell>(newChild3);
        source2.Count = (UInt32Value) ((uint) source2.Count<OpenXmlElement>());
      }
      else
      {
        worksheetPart.Worksheet.RemoveAllChildren<MergeCells>();
        xlwsContentManager.SetElement(XLWSContentManager.XLWSContents.MergeCells, (OpenXmlElement) null);
      }
      if (!xlWorksheet.ConditionalFormats.Any<IXLConditionalFormat>())
      {
        worksheetPart.Worksheet.RemoveAllChildren<DocumentFormat.OpenXml.Spreadsheet.ConditionalFormatting>();
        xlwsContentManager.SetElement(XLWSContentManager.XLWSContents.ConditionalFormatting, (OpenXmlElement) null);
      }
      else
      {
        worksheetPart.Worksheet.RemoveAllChildren<DocumentFormat.OpenXml.Spreadsheet.ConditionalFormatting>();
        OpenXmlElement refChild = xlwsContentManager.GetPreviousElementFor(XLWSContentManager.XLWSContents.ConditionalFormatting);
        int priority = 0;
        foreach (var data in xlWorksheet.ConditionalFormats.GroupBy((Func<IXLConditionalFormat, string>) (c => c.Range.RangeAddress.ToStringRelative(false)), (Func<IXLConditionalFormat, IXLConditionalFormat>) (c => c), (key, g) => new
        {
          RangeId = key,
          CfList = g.ToList<IXLConditionalFormat>()
        }))
        {
          ++priority;
          DocumentFormat.OpenXml.Spreadsheet.ConditionalFormatting conditionalFormatting1 = new DocumentFormat.OpenXml.Spreadsheet.ConditionalFormatting();
          DocumentFormat.OpenXml.Spreadsheet.ConditionalFormatting conditionalFormatting2 = conditionalFormatting1;
          ListValue<StringValue> listValue1 = new ListValue<StringValue>();
          listValue1.InnerText = data.RangeId;
          ListValue<StringValue> listValue2 = listValue1;
          conditionalFormatting2.SequenceOfReferences = listValue2;
          DocumentFormat.OpenXml.Spreadsheet.ConditionalFormatting newChild3 = conditionalFormatting1;
          foreach (IXLConditionalFormat cf in data.CfList)
            newChild3.Append(new OpenXmlElement[1]
            {
              (OpenXmlElement) XLCFConverters.Convert(cf, priority, context)
            });
          worksheetPart.Worksheet.InsertAfter<DocumentFormat.OpenXml.Spreadsheet.ConditionalFormatting>(newChild3, refChild);
          refChild = (OpenXmlElement) newChild3;
          xlwsContentManager.SetElement(XLWSContentManager.XLWSContents.ConditionalFormatting, (OpenXmlElement) newChild3);
        }
      }
      if (!xlWorksheet.DataValidations.Any<IXLDataValidation>((Func<IXLDataValidation, bool>) (d => d.IsDirty())))
      {
        worksheetPart.Worksheet.RemoveAllChildren<DocumentFormat.OpenXml.Spreadsheet.DataValidations>();
        xlwsContentManager.SetElement(XLWSContentManager.XLWSContents.DataValidations, (OpenXmlElement) null);
      }
      else
      {
        if (!worksheetPart.Worksheet.Elements<DocumentFormat.OpenXml.Spreadsheet.DataValidations>().Any<DocumentFormat.OpenXml.Spreadsheet.DataValidations>())
        {
          OpenXmlElement previousElementFor = xlwsContentManager.GetPreviousElementFor(XLWSContentManager.XLWSContents.DataValidations);
          worksheetPart.Worksheet.InsertAfter<DocumentFormat.OpenXml.Spreadsheet.DataValidations>(new DocumentFormat.OpenXml.Spreadsheet.DataValidations(), previousElementFor);
        }
        DocumentFormat.OpenXml.Spreadsheet.DataValidations dataValidations = worksheetPart.Worksheet.Elements<DocumentFormat.OpenXml.Spreadsheet.DataValidations>().First<DocumentFormat.OpenXml.Spreadsheet.DataValidations>();
        xlwsContentManager.SetElement(XLWSContentManager.XLWSContents.DataValidations, (OpenXmlElement) dataValidations);
        dataValidations.RemoveAllChildren<DocumentFormat.OpenXml.Spreadsheet.DataValidation>();
        foreach (IXLDataValidation dataValidation1 in xlWorksheet.DataValidations)
        {
          string str2 = dataValidation1.Ranges.Aggregate<IXLRange, string>(string.Empty, (Func<string, IXLRange, string>) ((current, r) => current + (object) r.RangeAddress + " "));
          if (str2.Length > 0)
            str2 = str2.Substring(0, str2.Length - 1);
          DocumentFormat.OpenXml.Spreadsheet.DataValidation dataValidation2 = new DocumentFormat.OpenXml.Spreadsheet.DataValidation();
          dataValidation2.AllowBlank = (BooleanValue) dataValidation1.IgnoreBlanks;
          dataValidation2.Formula1 = new Formula1(dataValidation1.MinValue);
          dataValidation2.Formula2 = new Formula2(dataValidation1.MaxValue);
          dataValidation2.Type = (EnumValue<DataValidationValues>) dataValidation1.AllowedValues.ToOpenXml();
          dataValidation2.ShowErrorMessage = (BooleanValue) dataValidation1.ShowErrorMessage;
          dataValidation2.Prompt = (StringValue) dataValidation1.InputMessage;
          dataValidation2.PromptTitle = (StringValue) dataValidation1.InputTitle;
          dataValidation2.ErrorTitle = (StringValue) dataValidation1.ErrorTitle;
          dataValidation2.Error = (StringValue) dataValidation1.ErrorMessage;
          dataValidation2.ShowDropDown = (BooleanValue) (!dataValidation1.InCellDropdown);
          dataValidation2.ShowInputMessage = (BooleanValue) dataValidation1.ShowInputMessage;
          dataValidation2.ErrorStyle = (EnumValue<DataValidationErrorStyleValues>) dataValidation1.ErrorStyle.ToOpenXml();
          dataValidation2.Operator = (EnumValue<DataValidationOperatorValues>) dataValidation1.Operator.ToOpenXml();
          DocumentFormat.OpenXml.Spreadsheet.DataValidation dataValidation3 = dataValidation2;
          ListValue<StringValue> listValue1 = new ListValue<StringValue>();
          listValue1.InnerText = str2;
          ListValue<StringValue> listValue2 = listValue1;
          dataValidation3.SequenceOfReferences = listValue2;
          DocumentFormat.OpenXml.Spreadsheet.DataValidation newChild3 = dataValidation2;
          dataValidations.AppendChild<DocumentFormat.OpenXml.Spreadsheet.DataValidation>(newChild3);
        }
        dataValidations.Count = (UInt32Value) ((uint) xlWorksheet.DataValidations.Count<IXLDataValidation>());
      }
      worksheetPart.HyperlinkRelationships.ToList<HyperlinkRelationship>().ForEach(new Action<HyperlinkRelationship>(((OpenXmlPartContainer) worksheetPart).DeleteReferenceRelationship));
      if (!xlWorksheet.Hyperlinks.Any<XLHyperlink>())
      {
        worksheetPart.Worksheet.RemoveAllChildren<Hyperlinks>();
        xlwsContentManager.SetElement(XLWSContentManager.XLWSContents.Hyperlinks, (OpenXmlElement) null);
      }
      else
      {
        if (!worksheetPart.Worksheet.Elements<Hyperlinks>().Any<Hyperlinks>())
        {
          OpenXmlElement previousElementFor = xlwsContentManager.GetPreviousElementFor(XLWSContentManager.XLWSContents.Hyperlinks);
          worksheetPart.Worksheet.InsertAfter<Hyperlinks>(new Hyperlinks(), previousElementFor);
        }
        Hyperlinks hyperlinks = worksheetPart.Worksheet.Elements<Hyperlinks>().First<Hyperlinks>();
        xlwsContentManager.SetElement(XLWSContentManager.XLWSContents.Hyperlinks, (OpenXmlElement) hyperlinks);
        hyperlinks.RemoveAllChildren<DocumentFormat.OpenXml.Spreadsheet.Hyperlink>();
        foreach (XLHyperlink hyperlink in (IEnumerable<XLHyperlink>) xlWorksheet.Hyperlinks)
        {
          DocumentFormat.OpenXml.Spreadsheet.Hyperlink newChild3;
          if (hyperlink.IsExternal)
          {
            string next = context.RelIdGenerator.GetNext(XLWorkbook.RelType.Workbook);
            newChild3 = new DocumentFormat.OpenXml.Spreadsheet.Hyperlink()
            {
              Reference = (StringValue) hyperlink.Cell.Address.ToString(),
              Id = (StringValue) next
            };
            worksheetPart.AddHyperlinkRelationship(hyperlink.ExternalAddress, true, next);
          }
          else
            newChild3 = new DocumentFormat.OpenXml.Spreadsheet.Hyperlink()
            {
              Reference = (StringValue) hyperlink.Cell.Address.ToString(),
              Location = (StringValue) hyperlink.InternalAddress,
              Display = (StringValue) hyperlink.Cell.GetFormattedString()
            };
          if (!XLHelper.IsNullOrWhiteSpace(hyperlink.Tooltip))
            newChild3.Tooltip = (StringValue) hyperlink.Tooltip;
          hyperlinks.AppendChild<DocumentFormat.OpenXml.Spreadsheet.Hyperlink>(newChild3);
        }
      }
      if (!worksheetPart.Worksheet.Elements<PrintOptions>().Any<PrintOptions>())
      {
        OpenXmlElement previousElementFor = xlwsContentManager.GetPreviousElementFor(XLWSContentManager.XLWSContents.PrintOptions);
        worksheetPart.Worksheet.InsertAfter<PrintOptions>(new PrintOptions(), previousElementFor);
      }
      PrintOptions printOptions = worksheetPart.Worksheet.Elements<PrintOptions>().First<PrintOptions>();
      xlwsContentManager.SetElement(XLWSContentManager.XLWSContents.PrintOptions, (OpenXmlElement) printOptions);
      printOptions.HorizontalCentered = (BooleanValue) xlWorksheet.PageSetup.CenterHorizontally;
      printOptions.VerticalCentered = (BooleanValue) xlWorksheet.PageSetup.CenterVertically;
      printOptions.Headings = (BooleanValue) xlWorksheet.PageSetup.ShowRowAndColumnHeadings;
      printOptions.GridLines = (BooleanValue) xlWorksheet.PageSetup.ShowGridlines;
      if (!worksheetPart.Worksheet.Elements<PageMargins>().Any<PageMargins>())
      {
        OpenXmlElement previousElementFor = xlwsContentManager.GetPreviousElementFor(XLWSContentManager.XLWSContents.PageMargins);
        worksheetPart.Worksheet.InsertAfter<PageMargins>(new PageMargins(), previousElementFor);
      }
      PageMargins pageMargins = worksheetPart.Worksheet.Elements<PageMargins>().First<PageMargins>();
      xlwsContentManager.SetElement(XLWSContentManager.XLWSContents.PageMargins, (OpenXmlElement) pageMargins);
      pageMargins.Left = (DoubleValue) xlWorksheet.PageSetup.Margins.Left;
      pageMargins.Right = (DoubleValue) xlWorksheet.PageSetup.Margins.Right;
      pageMargins.Top = (DoubleValue) xlWorksheet.PageSetup.Margins.Top;
      pageMargins.Bottom = (DoubleValue) xlWorksheet.PageSetup.Margins.Bottom;
      pageMargins.Header = (DoubleValue) xlWorksheet.PageSetup.Margins.Header;
      pageMargins.Footer = (DoubleValue) xlWorksheet.PageSetup.Margins.Footer;
      if (!worksheetPart.Worksheet.Elements<PageSetup>().Any<PageSetup>())
      {
        OpenXmlElement previousElementFor = xlwsContentManager.GetPreviousElementFor(XLWSContentManager.XLWSContents.PageSetup);
        worksheetPart.Worksheet.InsertAfter<PageSetup>(new PageSetup(), previousElementFor);
      }
      PageSetup pageSetup = worksheetPart.Worksheet.Elements<PageSetup>().First<PageSetup>();
      xlwsContentManager.SetElement(XLWSContentManager.XLWSContents.PageSetup, (OpenXmlElement) pageSetup);
      pageSetup.Orientation = (EnumValue<OrientationValues>) xlWorksheet.PageSetup.PageOrientation.ToOpenXml();
      pageSetup.PaperSize = (UInt32Value) ((uint) xlWorksheet.PageSetup.PaperSize);
      pageSetup.BlackAndWhite = (BooleanValue) xlWorksheet.PageSetup.BlackAndWhite;
      pageSetup.Draft = (BooleanValue) xlWorksheet.PageSetup.DraftQuality;
      pageSetup.PageOrder = (EnumValue<PageOrderValues>) xlWorksheet.PageSetup.PageOrder.ToOpenXml();
      pageSetup.CellComments = (EnumValue<CellCommentsValues>) xlWorksheet.PageSetup.ShowComments.ToOpenXml();
      pageSetup.Errors = (EnumValue<PrintErrorValues>) xlWorksheet.PageSetup.PrintErrorValue.ToOpenXml();
      if (xlWorksheet.PageSetup.FirstPageNumber > 0L)
      {
        pageSetup.FirstPageNumber = (UInt32Value) ((uint) xlWorksheet.PageSetup.FirstPageNumber);
        pageSetup.UseFirstPageNumber = (BooleanValue) true;
      }
      else
      {
        pageSetup.FirstPageNumber = (UInt32Value) null;
        pageSetup.UseFirstPageNumber = (BooleanValue) null;
      }
      pageSetup.HorizontalDpi = xlWorksheet.PageSetup.HorizontalDpi <= 0 ? (UInt32Value) null : (UInt32Value) ((uint) xlWorksheet.PageSetup.HorizontalDpi);
      pageSetup.VerticalDpi = xlWorksheet.PageSetup.VerticalDpi <= 0 ? (UInt32Value) null : (UInt32Value) ((uint) xlWorksheet.PageSetup.VerticalDpi);
      if (xlWorksheet.PageSetup.Scale > 0)
      {
        pageSetup.Scale = (UInt32Value) ((uint) xlWorksheet.PageSetup.Scale);
        pageSetup.FitToWidth = (UInt32Value) null;
        pageSetup.FitToHeight = (UInt32Value) null;
      }
      else
      {
        pageSetup.Scale = (UInt32Value) null;
        pageSetup.FitToWidth = xlWorksheet.PageSetup.PagesWide <= 0 ? (UInt32Value) 0U : (UInt32Value) ((uint) xlWorksheet.PageSetup.PagesWide);
        pageSetup.FitToHeight = xlWorksheet.PageSetup.PagesTall <= 0 ? (UInt32Value) 0U : (UInt32Value) ((uint) xlWorksheet.PageSetup.PagesTall);
      }
      HeaderFooter newChild4 = worksheetPart.Worksheet.Elements<HeaderFooter>().FirstOrDefault<HeaderFooter>();
      if (newChild4 == null)
        newChild4 = new HeaderFooter();
      else
        worksheetPart.Worksheet.RemoveAllChildren<HeaderFooter>();
      OpenXmlElement previousElementFor1 = xlwsContentManager.GetPreviousElementFor(XLWSContentManager.XLWSContents.HeaderFooter);
      worksheetPart.Worksheet.InsertAfter<HeaderFooter>(newChild4, previousElementFor1);
      xlwsContentManager.SetElement(XLWSContentManager.XLWSContents.HeaderFooter, (OpenXmlElement) newChild4);
      if (((XLHeaderFooter) xlWorksheet.PageSetup.Header).Changed || ((XLHeaderFooter) xlWorksheet.PageSetup.Footer).Changed)
      {
        newChild4.RemoveAllChildren();
        newChild4.ScaleWithDoc = (BooleanValue) xlWorksheet.PageSetup.ScaleHFWithDocument;
        newChild4.AlignWithMargins = (BooleanValue) xlWorksheet.PageSetup.AlignHFWithMargins;
        newChild4.DifferentFirst = (BooleanValue) xlWorksheet.PageSetup.DifferentFirstPageOnHF;
        newChild4.DifferentOddEven = (BooleanValue) xlWorksheet.PageSetup.DifferentOddEvenPagesOnHF;
        OddHeader newChild3 = new OddHeader(xlWorksheet.PageSetup.Header.GetText(XLHFOccurrence.OddPages));
        newChild4.AppendChild<OddHeader>(newChild3);
        OddFooter newChild5 = new OddFooter(xlWorksheet.PageSetup.Footer.GetText(XLHFOccurrence.OddPages));
        newChild4.AppendChild<OddFooter>(newChild5);
        EvenHeader newChild6 = new EvenHeader(xlWorksheet.PageSetup.Header.GetText(XLHFOccurrence.EvenPages));
        newChild4.AppendChild<EvenHeader>(newChild6);
        EvenFooter newChild7 = new EvenFooter(xlWorksheet.PageSetup.Footer.GetText(XLHFOccurrence.EvenPages));
        newChild4.AppendChild<EvenFooter>(newChild7);
        FirstHeader newChild8 = new FirstHeader(xlWorksheet.PageSetup.Header.GetText(XLHFOccurrence.FirstPage));
        newChild4.AppendChild<FirstHeader>(newChild8);
        FirstFooter newChild9 = new FirstFooter(xlWorksheet.PageSetup.Footer.GetText(XLHFOccurrence.FirstPage));
        newChild4.AppendChild<FirstFooter>(newChild9);
      }
      if (!worksheetPart.Worksheet.Elements<RowBreaks>().Any<RowBreaks>())
      {
        OpenXmlElement previousElementFor2 = xlwsContentManager.GetPreviousElementFor(XLWSContentManager.XLWSContents.RowBreaks);
        worksheetPart.Worksheet.InsertAfter<RowBreaks>(new RowBreaks(), previousElementFor2);
      }
      RowBreaks rowBreaks = worksheetPart.Worksheet.Elements<RowBreaks>().First<RowBreaks>();
      int count1 = xlWorksheet.PageSetup.RowBreaks.Count;
      if (count1 > 0)
      {
        rowBreaks.Count = (UInt32Value) ((uint) count1);
        rowBreaks.ManualBreakCount = (UInt32Value) ((uint) count1);
        uint lastRowNum = (uint) xlWorksheet.RangeAddress.LastAddress.RowNumber;
        foreach (DocumentFormat.OpenXml.Spreadsheet.Break newChild3 in xlWorksheet.PageSetup.RowBreaks.Select<int, DocumentFormat.OpenXml.Spreadsheet.Break>((Func<int, DocumentFormat.OpenXml.Spreadsheet.Break>) (rb => new DocumentFormat.OpenXml.Spreadsheet.Break()
        {
          Id = (UInt32Value) ((uint) rb),
          Max = (UInt32Value) lastRowNum,
          ManualPageBreak = (BooleanValue) true
        })))
          rowBreaks.AppendChild<DocumentFormat.OpenXml.Spreadsheet.Break>(newChild3);
        xlwsContentManager.SetElement(XLWSContentManager.XLWSContents.RowBreaks, (OpenXmlElement) rowBreaks);
      }
      else
      {
        worksheetPart.Worksheet.RemoveAllChildren<RowBreaks>();
        xlwsContentManager.SetElement(XLWSContentManager.XLWSContents.RowBreaks, (OpenXmlElement) null);
      }
      if (!worksheetPart.Worksheet.Elements<ColumnBreaks>().Any<ColumnBreaks>())
      {
        OpenXmlElement previousElementFor2 = xlwsContentManager.GetPreviousElementFor(XLWSContentManager.XLWSContents.ColumnBreaks);
        worksheetPart.Worksheet.InsertAfter<ColumnBreaks>(new ColumnBreaks(), previousElementFor2);
      }
      ColumnBreaks columnBreaks = worksheetPart.Worksheet.Elements<ColumnBreaks>().First<ColumnBreaks>();
      int count2 = xlWorksheet.PageSetup.ColumnBreaks.Count;
      if (count2 > 0)
      {
        columnBreaks.Count = (UInt32Value) ((uint) count2);
        columnBreaks.ManualBreakCount = (UInt32Value) ((uint) count2);
        uint maxColumnNumber = (uint) xlWorksheet.RangeAddress.LastAddress.ColumnNumber;
        foreach (DocumentFormat.OpenXml.Spreadsheet.Break newChild3 in xlWorksheet.PageSetup.ColumnBreaks.Select<int, DocumentFormat.OpenXml.Spreadsheet.Break>((Func<int, DocumentFormat.OpenXml.Spreadsheet.Break>) (cb => new DocumentFormat.OpenXml.Spreadsheet.Break()
        {
          Id = (UInt32Value) ((uint) cb),
          Max = (UInt32Value) maxColumnNumber,
          ManualPageBreak = (BooleanValue) true
        })))
          columnBreaks.AppendChild<DocumentFormat.OpenXml.Spreadsheet.Break>(newChild3);
        xlwsContentManager.SetElement(XLWSContentManager.XLWSContents.ColumnBreaks, (OpenXmlElement) columnBreaks);
      }
      else
      {
        worksheetPart.Worksheet.RemoveAllChildren<ColumnBreaks>();
        xlwsContentManager.SetElement(XLWSContentManager.XLWSContents.ColumnBreaks, (OpenXmlElement) null);
      }
      worksheetPart.Worksheet.RemoveAllChildren<TableParts>();
      OpenXmlElement previousElementFor3 = xlwsContentManager.GetPreviousElementFor(XLWSContentManager.XLWSContents.TableParts);
      worksheetPart.Worksheet.InsertAfter<TableParts>(new TableParts(), previousElementFor3);
      TableParts tableParts = worksheetPart.Worksheet.Elements<TableParts>().First<TableParts>();
      xlwsContentManager.SetElement(XLWSContentManager.XLWSContents.TableParts, (OpenXmlElement) tableParts);
      tableParts.Count = (UInt32Value) ((uint) xlWorksheet.Tables.Count<IXLTable>());
      foreach (TablePart newChild3 in xlWorksheet.Tables.Cast<XLTable>().Select<XLTable, TablePart>((Func<XLTable, TablePart>) (xlTable => new TablePart()
      {
        Id = (StringValue) xlTable.RelId
      })))
        tableParts.AppendChild<TablePart>(newChild3);
      if (!xlWorksheet.LegacyDrawingIsNew)
        return;
      worksheetPart.Worksheet.RemoveAllChildren<LegacyDrawing>();
      if (XLHelper.IsNullOrWhiteSpace(xlWorksheet.LegacyDrawingId))
        return;
      OpenXmlElement previousElementFor4 = xlwsContentManager.GetPreviousElementFor(XLWSContentManager.XLWSContents.LegacyDrawing);
      Worksheet worksheet = worksheetPart.Worksheet;
      LegacyDrawing legacyDrawing = new LegacyDrawing();
      legacyDrawing.Id = (StringValue) xlWorksheet.LegacyDrawingId;
      LegacyDrawing newChild10 = legacyDrawing;
      OpenXmlElement refChild1 = previousElementFor4;
      worksheet.InsertAfter<LegacyDrawing>(newChild10, refChild1);
    }

    private static void PopulateAutoFilter(XLAutoFilter xlAutoFilter, AutoFilter autoFilter)
    {
      IXLRange range = xlAutoFilter.Range;
      autoFilter.Reference = (StringValue) range.RangeAddress.ToString();
      foreach (KeyValuePair<int, List<XLFilter>> filter in xlAutoFilter.Filters)
      {
        FilterColumn filterColumn = new FilterColumn()
        {
          ColumnId = (UInt32Value) ((uint) (filter.Key - 1))
        };
        IXLFilterColumn xlFilterColumn = xlAutoFilter.Column(filter.Key);
        switch (xlFilterColumn.FilterType)
        {
          case XLFilterType.Custom:
            DocumentFormat.OpenXml.Spreadsheet.CustomFilters customFilters = new DocumentFormat.OpenXml.Spreadsheet.CustomFilters();
            foreach (XLFilter xlFilter in filter.Value)
            {
              DocumentFormat.OpenXml.Spreadsheet.CustomFilter customFilter = new DocumentFormat.OpenXml.Spreadsheet.CustomFilter()
              {
                Val = (StringValue) xlFilter.Value.ToString()
              };
              if (xlFilter.Operator != XLFilterOperator.Equal)
                customFilter.Operator = (EnumValue<FilterOperatorValues>) xlFilter.Operator.ToOpenXml();
              if (xlFilter.Connector == XLConnector.And)
                customFilters.And = (BooleanValue) true;
              customFilters.Append(new OpenXmlElement[1]
              {
                (OpenXmlElement) customFilter
              });
            }
            filterColumn.Append(new OpenXmlElement[1]
            {
              (OpenXmlElement) customFilters
            });
            break;
          case XLFilterType.TopBottom:
            Top10 top10 = new Top10()
            {
              Val = (DoubleValue) ((double) xlFilterColumn.TopBottomValue)
            };
            if (xlFilterColumn.TopBottomType == XLTopBottomType.Percent)
              top10.Percent = (BooleanValue) true;
            if (xlFilterColumn.TopBottomPart == XLTopBottomPart.Bottom)
              top10.Top = (BooleanValue) false;
            filterColumn.Append(new OpenXmlElement[1]
            {
              (OpenXmlElement) top10
            });
            break;
          case XLFilterType.Dynamic:
            DynamicFilter dynamicFilter = new DynamicFilter()
            {
              Type = (EnumValue<DynamicFilterValues>) xlFilterColumn.DynamicType.ToOpenXml(),
              Val = (DoubleValue) xlFilterColumn.DynamicValue
            };
            filterColumn.Append(new OpenXmlElement[1]
            {
              (OpenXmlElement) dynamicFilter
            });
            break;
          default:
            Filters filters = new Filters();
            foreach (XLFilter xlFilter in filter.Value)
              filters.Append(new OpenXmlElement[1]
              {
                (OpenXmlElement) new DocumentFormat.OpenXml.Spreadsheet.Filter()
                {
                  Val = (StringValue) xlFilter.Value.ToString()
                }
              });
            filterColumn.Append(new OpenXmlElement[1]
            {
              (OpenXmlElement) filters
            });
            break;
        }
        autoFilter.Append(new OpenXmlElement[1]
        {
          (OpenXmlElement) filterColumn
        });
      }
      if (!xlAutoFilter.Sorted)
        return;
      SortState sortState = new SortState()
      {
        Reference = (StringValue) range.Range(range.FirstCell().CellBelow(), range.LastCell()).RangeAddress.ToString()
      };
      DocumentFormat.OpenXml.Spreadsheet.SortCondition sortCondition = new DocumentFormat.OpenXml.Spreadsheet.SortCondition()
      {
        Reference = (StringValue) range.Range(1, xlAutoFilter.SortColumn, range.RowCount(), xlAutoFilter.SortColumn).RangeAddress.ToString()
      };
      if (xlAutoFilter.SortOrder == XLSortOrder.Descending)
        sortCondition.Descending = (BooleanValue) true;
      sortState.Append(new OpenXmlElement[1]
      {
        (OpenXmlElement) sortCondition
      });
      autoFilter.Append(new OpenXmlElement[1]
      {
        (OpenXmlElement) sortState
      });
    }

    private static BooleanValue GetBooleanValue(bool value, bool defaultValue)
    {
      if (value != defaultValue)
        return new BooleanValue(value);
      return (BooleanValue) null;
    }

    private static void CollapseColumns(Columns columns, Dictionary<uint, Column> sheetColumns)
    {
      uint lastMin = 1;
      int count = sheetColumns.Count;
      KeyValuePair<uint, Column>[] array = sheetColumns.OrderBy<KeyValuePair<uint, Column>, uint>((Func<KeyValuePair<uint, Column>, uint>) (kp => kp.Key)).ToArray<KeyValuePair<uint, Column>>();
      for (int index = 0; index < count; ++index)
      {
        KeyValuePair<uint, Column> keyValuePair = array[index];
        if (index + 1 == count || !XLWorkbook.ColumnsAreEqual(keyValuePair.Value, array[index + 1].Value))
        {
          Column newChild = (Column) keyValuePair.Value.CloneNode(true);
          newChild.Min = (UInt32Value) lastMin;
          uint newColumnMax = newChild.Max.Value;
          columns.Elements<Column>().Where<Column>((Func<Column, bool>) (co =>
          {
            if ((uint) co.Min >= lastMin)
              return (uint) co.Max <= newColumnMax;
            return false;
          })).Select<Column, Column>((Func<Column, Column>) (co => co)).ToList<Column>().ForEach((Action<Column>) (c => columns.RemoveChild<Column>(c)));
          columns.AppendChild<Column>(newChild);
          lastMin = keyValuePair.Key + 1U;
        }
      }
    }

    private static double GetColumnWidth(double columnWidth)
    {
      double num = columnWidth + 0.710625;
      if (num <= 0.0)
        return 0.0;
      return num;
    }

    private static void UpdateColumn(Column column, Columns columns, Dictionary<uint, Column> sheetColumnsByMin)
    {
      uint key = column.Min.Value;
      if (!sheetColumnsByMin.ContainsKey(key))
      {
        Column newChild = (Column) column.CloneNode(true);
        columns.AppendChild<Column>(newChild);
        sheetColumnsByMin.Add(key, newChild);
      }
      else
      {
        Column oldChild = sheetColumnsByMin[column.Min.Value];
        Column newChild = (Column) oldChild.CloneNode(true);
        newChild.Min = column.Min;
        newChild.Max = column.Max;
        newChild.Style = column.Style;
        newChild.Width = column.Width;
        newChild.CustomWidth = column.CustomWidth;
        newChild.Hidden = column.Hidden == null ? (BooleanValue) null : (BooleanValue) true;
        newChild.Collapsed = column.Collapsed == null ? (BooleanValue) null : (BooleanValue) true;
        newChild.OutlineLevel = column.OutlineLevel == null || (int) (byte) column.OutlineLevel <= 0 ? (ByteValue) null : (ByteValue) (byte) column.OutlineLevel;
        sheetColumnsByMin.Remove(column.Min.Value);
        if ((uint) oldChild.Min + 1U > (uint) oldChild.Max)
        {
          columns.RemoveChild<Column>(oldChild);
          columns.AppendChild<Column>(newChild);
          sheetColumnsByMin.Add(newChild.Min.Value, newChild);
        }
        else
        {
          columns.AppendChild<Column>(newChild);
          sheetColumnsByMin.Add(newChild.Min.Value, newChild);
          oldChild.Min = (UInt32Value) ((uint) oldChild.Min + 1U);
          sheetColumnsByMin.Add(oldChild.Min.Value, oldChild);
        }
      }
    }

    private static bool ColumnsAreEqual(Column left, Column right)
    {
      if ((left.Style != null || right.Style != null) && (left.Style == null || right.Style == null || (int) left.Style.Value != (int) right.Style.Value) || (left.Width != null || right.Width != null) && (left.Width == null || right.Width == null || left.Width.Value != right.Width.Value) || ((left.Hidden != null || right.Hidden != null) && (left.Hidden == null || right.Hidden == null || left.Hidden.Value != right.Hidden.Value) || (left.Collapsed != null || right.Collapsed != null) && (left.Collapsed == null || right.Collapsed == null || left.Collapsed.Value != right.Collapsed.Value)))
        return false;
      if (left.OutlineLevel == null && right.OutlineLevel == null)
        return true;
      if (left.OutlineLevel != null && right.OutlineLevel != null)
        return (int) left.OutlineLevel.Value == (int) right.OutlineLevel.Value;
      return false;
    }

    public static IXLStyle DefaultStyle
    {
      get
      {
        IXLStyle defaultStyle = XLWorkbook._defaultStyle;
        if (defaultStyle != null)
          return defaultStyle;
        return XLWorkbook._defaultStyle = (IXLStyle) new XLStyle((IXLStylized) null, (IXLStyle) null, true)
        {
          Font = (IXLFont) new XLFont((IXLStylized) null, (IXLFontBase) null, true)
          {
            Bold = false,
            Italic = false,
            Underline = XLFontUnderlineValues.None,
            Strikethrough = false,
            VerticalAlignment = XLFontVerticalTextAlignmentValues.Baseline,
            FontSize = 11.0,
            FontColor = XLColor.FromArgb(0, 0, 0),
            FontName = "Calibri",
            FontFamilyNumbering = XLFontFamilyNumberingValues.Swiss
          },
          Fill = (IXLFill) new XLFill((IXLStylized) null, (IXLFill) null, true)
          {
            BackgroundColor = XLColor.FromIndex(64),
            PatternType = XLFillPatternValues.None,
            PatternColor = XLColor.FromIndex(64)
          },
          Border = (IXLBorder) new XLBorder((IXLStylized) null, (IXLBorder) null, true)
          {
            BottomBorder = XLBorderStyleValues.None,
            DiagonalBorder = XLBorderStyleValues.None,
            DiagonalDown = false,
            DiagonalUp = false,
            LeftBorder = XLBorderStyleValues.None,
            RightBorder = XLBorderStyleValues.None,
            TopBorder = XLBorderStyleValues.None,
            BottomBorderColor = XLColor.Black,
            DiagonalBorderColor = XLColor.Black,
            LeftBorderColor = XLColor.Black,
            RightBorderColor = XLColor.Black,
            TopBorderColor = XLColor.Black
          },
          NumberFormat = (IXLNumberFormat) new XLNumberFormat((IXLStylized) null, (IXLNumberFormat) null)
          {
            NumberFormatId = 0
          },
          Alignment = (IXLAlignment) new XLAlignment((IXLStylized) null, (IXLAlignment) null)
          {
            Indent = 0,
            Horizontal = XLAlignmentHorizontalValues.General,
            JustifyLastLine = false,
            ReadingOrder = XLAlignmentReadingOrderValues.ContextDependent,
            RelativeIndent = 0,
            ShrinkToFit = false,
            TextRotation = 0,
            Vertical = XLAlignmentVerticalValues.Bottom,
            WrapText = false
          },
          Protection = (IXLProtection) new XLProtection((IXLStylized) null, (IXLProtection) null)
          {
            Locked = true,
            Hidden = false
          }
        };
      }
    }

    public static double DefaultRowHeight { get; private set; }

    public static double DefaultColumnWidth { get; private set; }

    public static IXLPageSetup DefaultPageOptions
    {
      get
      {
        return (IXLPageSetup) new XLPageSetup((XLPageSetup) null, (XLWorksheet) null)
        {
          PageOrientation = XLPageOrientation.Default,
          Scale = 100,
          PaperSize = XLPaperSize.LetterPaper,
          Margins = (IXLMargins) new XLMargins()
          {
            Top = 0.75,
            Bottom = 0.5,
            Left = 0.75,
            Right = 0.75,
            Header = 0.5,
            Footer = 0.75
          },
          ScaleHFWithDocument = true,
          AlignHFWithMargins = true,
          PrintErrorValue = XLPrintErrorValues.Displayed,
          ShowComments = XLShowCommentsValues.None
        };
      }
    }

    public static IXLOutline DefaultOutline
    {
      get
      {
        return (IXLOutline) new XLOutline((IXLOutline) null)
        {
          SummaryHLocation = XLOutlineSummaryHLocation.Right,
          SummaryVLocation = XLOutlineSummaryVLocation.Bottom
        };
      }
    }

    public static XLCellSetValueBehavior CellSetValueBehavior { get; set; }

    public XLEventTracking EventTracking { get; set; }

    internal int GetStyleId(IXLStyle style)
    {
      int num;
      if (this._stylesByStyle.TryGetValue(style, out num))
        return num;
      int count = this._stylesByStyle.Count;
      XLStyle xlStyle = new XLStyle((IXLStylized) null, style, true);
      this._stylesByStyle.Add((IXLStyle) xlStyle, count);
      this._stylesById.Add(count, (IXLStyle) xlStyle);
      return count;
    }

    internal IXLStyle GetStyleById(int id)
    {
      return this._stylesById[id];
    }

    internal XLWorksheets WorksheetsInternal { get; private set; }

    public IXLWorksheets Worksheets
    {
      get
      {
        return (IXLWorksheets) this.WorksheetsInternal;
      }
    }

    public IXLNamedRanges NamedRanges { get; private set; }

    public IXLTheme Theme { get; private set; }

    public IXLStyle Style { get; set; }

    public double RowHeight { get; set; }

    public double ColumnWidth { get; set; }

    public IXLPageSetup PageOptions { get; set; }

    public IXLOutline Outline { get; set; }

    public XLWorkbookProperties Properties { get; set; }

    public XLCalculateMode CalculateMode { get; set; }

    public XLReferenceStyle ReferenceStyle { get; set; }

    public IXLCustomProperties CustomProperties { get; private set; }

    public bool ShowFormulas { get; set; }

    public bool ShowGridLines { get; set; }

    public bool ShowOutlineSymbols { get; set; }

    public bool ShowRowColHeaders { get; set; }

    public bool ShowRuler { get; set; }

    public bool ShowWhiteSpace { get; set; }

    public bool ShowZeros { get; set; }

    public bool RightToLeft { get; set; }

    public bool DefaultShowFormulas
    {
      get
      {
        return false;
      }
    }

    public bool DefaultShowGridLines
    {
      get
      {
        return true;
      }
    }

    public bool DefaultShowOutlineSymbols
    {
      get
      {
        return true;
      }
    }

    public bool DefaultShowRowColHeaders
    {
      get
      {
        return true;
      }
    }

    public bool DefaultShowRuler
    {
      get
      {
        return true;
      }
    }

    public bool DefaultShowWhiteSpace
    {
      get
      {
        return true;
      }
    }

    public bool DefaultShowZeros
    {
      get
      {
        return true;
      }
    }

    public bool DefaultRightToLeft
    {
      get
      {
        return false;
      }
    }

    private void InitializeTheme()
    {
      this.Theme = (IXLTheme) new XLTheme()
      {
        Text1 = XLColor.FromHtml("#FF000000"),
        Background1 = XLColor.FromHtml("#FFFFFFFF"),
        Text2 = XLColor.FromHtml("#FF1F497D"),
        Background2 = XLColor.FromHtml("#FFEEECE1"),
        Accent1 = XLColor.FromHtml("#FF4F81BD"),
        Accent2 = XLColor.FromHtml("#FFC0504D"),
        Accent3 = XLColor.FromHtml("#FF9BBB59"),
        Accent4 = XLColor.FromHtml("#FF8064A2"),
        Accent5 = XLColor.FromHtml("#FF4BACC6"),
        Accent6 = XLColor.FromHtml("#FFF79646"),
        Hyperlink = XLColor.FromHtml("#FF0000FF"),
        FollowedHyperlink = XLColor.FromHtml("#FF800080")
      };
    }

    internal XLColor GetXLColor(XLThemeColor themeColor)
    {
      switch (themeColor)
      {
        case XLThemeColor.Background1:
          return this.Theme.Background1;
        case XLThemeColor.Text1:
          return this.Theme.Text1;
        case XLThemeColor.Background2:
          return this.Theme.Background2;
        case XLThemeColor.Text2:
          return this.Theme.Text2;
        case XLThemeColor.Accent1:
          return this.Theme.Accent1;
        case XLThemeColor.Accent2:
          return this.Theme.Accent2;
        case XLThemeColor.Accent3:
          return this.Theme.Accent3;
        case XLThemeColor.Accent4:
          return this.Theme.Accent4;
        case XLThemeColor.Accent5:
          return this.Theme.Accent5;
        case XLThemeColor.Accent6:
          return this.Theme.Accent6;
        default:
          throw new ArgumentException("Invalid theme color");
      }
    }

    public IXLNamedRange NamedRange(string rangeName)
    {
      if (!rangeName.Contains("!"))
        return this.NamedRanges.NamedRange(rangeName);
      string[] strArray = rangeName.Split('!');
      string str = strArray[0];
      string name = str.StartsWith("'") ? str.Substring(1, str.Length - 2) : str;
      string rangeName1 = strArray[1];
      IXLWorksheet worksheet;
      if (this.TryGetWorksheet(name, out worksheet))
        return worksheet.NamedRange(rangeName1) ?? this.NamedRange(rangeName1);
      return (IXLNamedRange) null;
    }

    public bool TryGetWorksheet(string name, out IXLWorksheet worksheet)
    {
      if (this.Worksheets.Any<IXLWorksheet>((Func<IXLWorksheet, bool>) (w => w.Name.ToLower().Equals(name.ToLower()))))
      {
        worksheet = this.Worksheet(name);
        return true;
      }
      worksheet = (IXLWorksheet) null;
      return false;
    }

    public void Save()
    {
      this.checkForWorksheetsPresent();
      if (this._loadSource == XLWorkbook.XLLoadSource.New)
        throw new Exception("This is a new file, please use one of the SaveAs methods.");
      if (this._loadSource == XLWorkbook.XLLoadSource.Stream)
        this.CreatePackage(this._originalStream, false, this._spreadsheetDocumentType);
      else
        this.CreatePackage(this._originalFile, this._spreadsheetDocumentType);
    }

    public void SaveAs(string file)
    {
      this.checkForWorksheetsPresent();
      ClosedXML.PathHelper.CreateDirectory(System.IO.Path.GetDirectoryName(file));
      if (this._loadSource == XLWorkbook.XLLoadSource.New)
      {
        if (File.Exists(file))
          File.Delete(file);
        this.CreatePackage(file, XLWorkbook.GetSpreadsheetDocumentType(file));
      }
      else if (this._loadSource == XLWorkbook.XLLoadSource.File)
      {
        if (string.Compare(this._originalFile.Trim(), file.Trim(), true) != 0)
          File.Copy(this._originalFile, file, true);
        this.CreatePackage(file, XLWorkbook.GetSpreadsheetDocumentType(file));
      }
      else
      {
        if (this._loadSource != XLWorkbook.XLLoadSource.Stream)
          return;
        this._originalStream.Position = 0L;
        using (FileStream fileStream = File.Create(file))
        {
          XLWorkbook.CopyStream(this._originalStream, (Stream) fileStream);
          this.CreatePackage((Stream) fileStream, false, this._spreadsheetDocumentType);
          fileStream.Close();
        }
      }
    }

    private static SpreadsheetDocumentType GetSpreadsheetDocumentType(string filePath)
    {
      string extension = System.IO.Path.GetExtension(filePath);
      if (extension == null)
        throw new Exception("Empty extension is not supported.");
      if (extension.ToLowerInvariant().Equals(".xlsm"))
        return SpreadsheetDocumentType.MacroEnabledWorkbook;
      if (extension.ToLowerInvariant().Equals(".xlsx"))
        return SpreadsheetDocumentType.Workbook;
      throw new Exception(string.Format("Extension '{0}' is not supported. Supported extensions are '.xlsx' and '.xslm'.", (object) extension));
    }

    private void checkForWorksheetsPresent()
    {
      if (this.Worksheets.Count<IXLWorksheet>() == 0)
        throw new Exception("Workbooks need at least one worksheet.");
    }

    public void SaveAs(Stream stream)
    {
      this.checkForWorksheetsPresent();
      if (this._loadSource == XLWorkbook.XLLoadSource.New)
      {
        if (stream.CanRead && stream.CanSeek && stream.CanWrite)
        {
          this.CreatePackage(stream, true, this._spreadsheetDocumentType);
        }
        else
        {
          MemoryStream memoryStream = new MemoryStream();
          this.CreatePackage((Stream) memoryStream, true, this._spreadsheetDocumentType);
          memoryStream.Position = 0L;
          XLWorkbook.CopyStream((Stream) memoryStream, stream);
        }
      }
      else if (this._loadSource == XLWorkbook.XLLoadSource.File)
      {
        using (FileStream fileStream = new FileStream(this._originalFile, FileMode.Open, FileAccess.Read))
        {
          XLWorkbook.CopyStream((Stream) fileStream, stream);
          fileStream.Close();
        }
        this.CreatePackage(stream, false, this._spreadsheetDocumentType);
      }
      else
      {
        if (this._loadSource != XLWorkbook.XLLoadSource.Stream)
          return;
        this._originalStream.Position = 0L;
        if (this._originalStream != stream)
          XLWorkbook.CopyStream(this._originalStream, stream);
        this.CreatePackage(stream, false, this._spreadsheetDocumentType);
      }
    }

    internal static void CopyStream(Stream input, Stream output)
    {
      byte[] buffer = new byte[8192];
      if (input.CanSeek)
        input.Seek(0L, SeekOrigin.Begin);
      int count;
      while ((count = input.Read(buffer, 0, buffer.Length)) > 0)
        output.Write(buffer, 0, count);
      output.Flush();
    }

    public IXLWorksheet Worksheet(string name)
    {
      return this.WorksheetsInternal.Worksheet(name);
    }

    public IXLWorksheet Worksheet(int position)
    {
      return this.WorksheetsInternal.Worksheet(position);
    }

    public IXLCustomProperty CustomProperty(string name)
    {
      return this.CustomProperties.CustomProperty(name);
    }

    public IXLCells FindCells(Func<IXLCell, bool> predicate)
    {
      XLCells xlCells = new XLCells(false, false, (Func<IXLCell, bool>) null);
      foreach (XLRangeBase xlRangeBase in this.WorksheetsInternal)
      {
        foreach (XLCell cell in xlRangeBase.CellsUsed(true))
        {
          if (predicate((IXLCell) cell))
            xlCells.Add(cell);
        }
      }
      return (IXLCells) xlCells;
    }

    public IXLRows FindRows(Func<IXLRow, bool> predicate)
    {
      XLRows xlRows = new XLRows((XLWorksheet) null);
      foreach (XLWorksheet xlWorksheet in this.WorksheetsInternal)
      {
        foreach (IXLRow xlRow in xlWorksheet.Rows().Where<IXLRow>(predicate))
          xlRows.Add(xlRow as XLRow);
      }
      return (IXLRows) xlRows;
    }

    public IXLColumns FindColumns(Func<IXLColumn, bool> predicate)
    {
      XLColumns xlColumns = new XLColumns((XLWorksheet) null);
      foreach (XLWorksheet xlWorksheet in this.WorksheetsInternal)
      {
        foreach (IXLColumn xlColumn in xlWorksheet.Columns().Where<IXLColumn>(predicate))
          xlColumns.Add(xlColumn as XLColumn);
      }
      return (IXLColumns) xlColumns;
    }

    public XLWorkbook()
      : this(XLEventTracking.Enabled)
    {
    }

    public XLWorkbook(XLEventTracking eventTracking)
    {
      this.EventTracking = eventTracking;
      XLWorkbook.DefaultRowHeight = 15.0;
      XLWorkbook.DefaultColumnWidth = 8.43;
      this.Style = (IXLStyle) new XLStyle((IXLStylized) null, XLWorkbook.DefaultStyle, true);
      this.RowHeight = XLWorkbook.DefaultRowHeight;
      this.ColumnWidth = XLWorkbook.DefaultColumnWidth;
      this.PageOptions = XLWorkbook.DefaultPageOptions;
      this.Outline = XLWorkbook.DefaultOutline;
      this.Properties = new XLWorkbookProperties();
      this.CalculateMode = XLCalculateMode.Default;
      this.ReferenceStyle = XLReferenceStyle.Default;
      this.InitializeTheme();
      this.ShowFormulas = this.DefaultShowFormulas;
      this.ShowGridLines = this.DefaultShowGridLines;
      this.ShowOutlineSymbols = this.DefaultShowOutlineSymbols;
      this.ShowRowColHeaders = this.DefaultShowRowColHeaders;
      this.ShowRuler = this.DefaultShowRuler;
      this.ShowWhiteSpace = this.DefaultShowWhiteSpace;
      this.ShowZeros = this.DefaultShowZeros;
      this.RightToLeft = this.DefaultRightToLeft;
      this.WorksheetsInternal = new XLWorksheets(this);
      this.NamedRanges = (IXLNamedRanges) new XLNamedRanges(this);
      this.CustomProperties = (IXLCustomProperties) new XLCustomProperties(this);
      this.ShapeIdManager = new XLIdManager();
      this.Author = Environment.UserName;
    }

    public XLWorkbook(string file)
      : this(file, XLEventTracking.Enabled)
    {
    }

    public XLWorkbook(string file, XLEventTracking eventTracking)
      : this(eventTracking)
    {
      this._loadSource = XLWorkbook.XLLoadSource.File;
      this._originalFile = file;
      this._spreadsheetDocumentType = XLWorkbook.GetSpreadsheetDocumentType(this._originalFile);
      this.Load(file);
    }

    public XLWorkbook(Stream stream)
      : this(stream, XLEventTracking.Enabled)
    {
    }

    public XLWorkbook(Stream stream, XLEventTracking eventTracking)
      : this(eventTracking)
    {
      this._loadSource = XLWorkbook.XLLoadSource.Stream;
      this._originalStream = stream;
      this.Load(stream);
    }

    public IXLCell Cell(string namedCell)
    {
      IXLNamedRange xlNamedRange = this.NamedRange(namedCell);
      if (xlNamedRange == null)
        return (IXLCell) null;
      IXLRange xlRange = xlNamedRange.Ranges.FirstOrDefault<IXLRange>();
      if (xlRange == null)
        return (IXLCell) null;
      return xlRange.FirstCell();
    }

    public IXLCells Cells(string namedCells)
    {
      return this.Ranges(namedCells).Cells();
    }

    public IXLRange Range(string namedRange)
    {
      IXLNamedRange xlNamedRange = this.NamedRange(namedRange);
      if (xlNamedRange == null)
        return (IXLRange) null;
      return xlNamedRange.Ranges.FirstOrDefault<IXLRange>();
    }

    public IXLRanges Ranges(string namedRanges)
    {
      XLRanges xlRanges = new XLRanges();
      foreach (IXLRange xlRange in ((IEnumerable<string>) namedRanges.Split(',')).Select<string, IXLRange>((Func<string, IXLRange>) (r => this.Range(r.Trim()))).Where<IXLRange>((Func<IXLRange, bool>) (range => range != null)))
        xlRanges.Add((IXLRangeBase) xlRange);
      return (IXLRanges) xlRanges;
    }

    internal XLIdManager ShapeIdManager { get; private set; }

    public void Dispose()
    {
      this.Worksheets.ForEach<IXLWorksheet>((Action<IXLWorksheet>) (w => w.Dispose()));
    }

    public bool Use1904DateSystem { get; set; }

    public XLWorkbook SetUse1904DateSystem()
    {
      return this.SetUse1904DateSystem(true);
    }

    public XLWorkbook SetUse1904DateSystem(bool value)
    {
      this.Use1904DateSystem = value;
      return this;
    }

    public IXLWorksheet AddWorksheet(string sheetName)
    {
      return this.Worksheets.Add(sheetName);
    }

    public IXLWorksheet AddWorksheet(string sheetName, int position)
    {
      return this.Worksheets.Add(sheetName, position);
    }

    public IXLWorksheet AddWorksheet(DataTable dataTable)
    {
      return this.Worksheets.Add(dataTable);
    }

    public void AddWorksheet(DataSet dataSet)
    {
      this.Worksheets.Add(dataSet);
    }

    public void AddWorksheet(IXLWorksheet worksheet)
    {
      worksheet.CopyTo(this, worksheet.Name);
    }

    public IXLWorksheet AddWorksheet(DataTable dataTable, string sheetName)
    {
      return this.Worksheets.Add(dataTable, sheetName);
    }

    private XLCalcEngine CalcEngine
    {
      get
      {
        return this._calcEngine ?? (this._calcEngine = new XLCalcEngine(this));
      }
    }

    public object Evaluate(string expression)
    {
      return this.CalcEngine.Evaluate(expression);
    }

    private static XLCalcEngine CalcEngineExpr
    {
      get
      {
        return XLWorkbook._calcEngineExpr ?? (XLWorkbook._calcEngineExpr = new XLCalcEngine());
      }
    }

    public static object EvaluateExpr(string expression)
    {
      return XLWorkbook.CalcEngineExpr.Evaluate(expression);
    }

    public string Author { get; set; }

    public bool LockStructure { get; set; }

    public XLWorkbook SetLockStructure(bool value)
    {
      this.LockStructure = value;
      return this;
    }

    public bool LockWindows { get; set; }

    public XLWorkbook SetLockWindows(bool value)
    {
      this.LockWindows = value;
      return this;
    }

    public void Protect()
    {
      this.Protect(true);
    }

    public void Protect(bool lockStructure)
    {
      this.Protect(lockStructure, false);
    }

    public void Protect(bool lockStructure, bool lockWindows)
    {
      this.LockStructure = lockStructure;
      this.LockWindows = this.LockWindows;
    }

    internal sealed class SaveContext
    {
      public Dictionary<IXLStyle, int> DifferentialFormats = new Dictionary<IXLStyle, int>();
      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      private readonly XLWorkbook.RelIdGenerator _relIdGenerator;
      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      private readonly Dictionary<int, XLWorkbook.StyleInfo> _sharedStyles;
      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      private readonly Dictionary<IXLFont, XLWorkbook.FontInfo> _sharedFonts;
      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      private readonly HashSet<string> _tableNames;
      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      private uint _tableId;

      public SaveContext()
      {
        this._relIdGenerator = new XLWorkbook.RelIdGenerator();
        this._sharedStyles = new Dictionary<int, XLWorkbook.StyleInfo>();
        this._sharedFonts = new Dictionary<IXLFont, XLWorkbook.FontInfo>();
        this._tableNames = new HashSet<string>();
        this._tableId = 0U;
      }

      public XLWorkbook.RelIdGenerator RelIdGenerator
      {
        [DebuggerStepThrough] get
        {
          return this._relIdGenerator;
        }
      }

      public Dictionary<int, XLWorkbook.StyleInfo> SharedStyles
      {
        [DebuggerStepThrough] get
        {
          return this._sharedStyles;
        }
      }

      public Dictionary<IXLFont, XLWorkbook.FontInfo> SharedFonts
      {
        [DebuggerStepThrough] get
        {
          return this._sharedFonts;
        }
      }

      public HashSet<string> TableNames
      {
        [DebuggerStepThrough] get
        {
          return this._tableNames;
        }
      }

      public uint TableId
      {
        [DebuggerStepThrough] get
        {
          return this._tableId;
        }
        [DebuggerStepThrough] set
        {
          this._tableId = value;
        }
      }
    }

    internal enum RelType
    {
      Workbook,
    }

    internal sealed class RelIdGenerator
    {
      private readonly Dictionary<XLWorkbook.RelType, List<string>> _relIds = new Dictionary<XLWorkbook.RelType, List<string>>();

      public string GetNext(XLWorkbook.RelType relType)
      {
        if (!this._relIds.ContainsKey(relType))
          this._relIds.Add(relType, new List<string>());
        int num = this._relIds[relType].Count + 1;
        string str;
        while (true)
        {
          str = string.Format("rId{0}", (object) num);
          if (this._relIds[relType].Contains(str))
            ++num;
          else
            break;
        }
        this._relIds[relType].Add(str);
        return str;
      }

      public void AddValues(List<string> values, XLWorkbook.RelType relType)
      {
        if (!this._relIds.ContainsKey(relType))
          this._relIds.Add(relType, new List<string>());
        this._relIds[relType].AddRange((IEnumerable<string>) values);
      }

      public void Reset(XLWorkbook.RelType relType)
      {
        if (!this._relIds.ContainsKey(relType))
          return;
        this._relIds.Remove(relType);
      }
    }

    internal struct FontInfo
    {
      public uint FontId;
      public XLFont Font;
    }

    internal struct FillInfo
    {
      public uint FillId;
      public XLFill Fill;
    }

    internal struct BorderInfo
    {
      public uint BorderId;
      public XLBorder Border;
    }

    internal struct NumberFormatInfo
    {
      public int NumberFormatId;
      public IXLNumberFormat NumberFormat;
    }

    internal struct StyleInfo
    {
      public uint StyleId;
      public uint FontId;
      public uint FillId;
      public uint BorderId;
      public int NumberFormatId;
      public IXLStyle Style;
    }

    private enum XLLoadSource
    {
      New,
      File,
      Stream,
    }

    internal sealed class UnsupportedSheet
    {
      public bool IsActive;
      public uint SheetId;
      public int Position;
    }
  }
}

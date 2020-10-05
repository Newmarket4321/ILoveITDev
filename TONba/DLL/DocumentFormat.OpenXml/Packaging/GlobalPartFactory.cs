// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.GlobalPartFactory
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;

namespace DocumentFormat.OpenXml.Packaging
{
  internal static class GlobalPartFactory
  {
    internal static OpenXmlPart CreateOpenXmlPart(OpenXmlPackage openXmlPackage, string relationshipType)
    {
      if (relationshipType == null)
        throw new ArgumentNullException(nameof (relationshipType));
      OpenXmlPart openXmlPart = (OpenXmlPart) null;
      GlobalPartFactory.CreatePartCore(openXmlPackage, relationshipType, ref openXmlPart);
      if (openXmlPart == null)
        openXmlPart = (OpenXmlPart) new ExtendedPart(relationshipType);
      return openXmlPart;
    }

    private static void CreatePartCore(OpenXmlPackage openXmlPackage, string relationshipType, ref OpenXmlPart openXmlPart)
    {
      if (openXmlPackage == null)
        throw new ArgumentNullException(nameof (openXmlPackage));
      if (relationshipType == null)
        throw new ArgumentNullException(nameof (relationshipType));
      if (openXmlPackage is WordprocessingDocument)
      {
        switch (relationshipType)
        {
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument":
            openXmlPart = (OpenXmlPart) new MainDocumentPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml":
            openXmlPart = (OpenXmlPart) new CustomXmlPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXmlProps":
            openXmlPart = (OpenXmlPart) new CustomXmlPropertiesPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/glossaryDocument":
            openXmlPart = (OpenXmlPart) new GlossaryDocumentPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments":
            openXmlPart = (OpenXmlPart) new WordprocessingCommentsPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/aFChunk":
            openXmlPart = (OpenXmlPart) new AlternativeFormatImportPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart":
            openXmlPart = (OpenXmlPart) new ChartPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chartUserShapes":
            openXmlPart = (OpenXmlPart) new ChartDrawingPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image":
            openXmlPart = (OpenXmlPart) new ImagePart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/package":
            openXmlPart = (OpenXmlPart) new EmbeddedPackagePart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/themeOverride":
            openXmlPart = (OpenXmlPart) new ThemeOverridePart();
            break;
          case "http://schemas.microsoft.com/office/2011/relationships/chartStyle":
            openXmlPart = (OpenXmlPart) new ChartStylePart();
            break;
          case "http://schemas.microsoft.com/office/2011/relationships/chartColorStyle":
            openXmlPart = (OpenXmlPart) new ChartColorStylePart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors":
            openXmlPart = (OpenXmlPart) new DiagramColorsPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData":
            openXmlPart = (OpenXmlPart) new DiagramDataPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slide":
            openXmlPart = (OpenXmlPart) new SlidePart();
            break;
          case "http://schemas.microsoft.com/office/2007/relationships/diagramDrawing":
            openXmlPart = (OpenXmlPart) new DiagramPersistLayoutPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout":
            openXmlPart = (OpenXmlPart) new DiagramLayoutDefinitionPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle":
            openXmlPart = (OpenXmlPart) new DiagramStylePart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject":
            openXmlPart = (OpenXmlPart) new EmbeddedObjectPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/vmlDrawing":
            openXmlPart = (OpenXmlPart) new VmlDrawingPart();
            break;
          case "http://schemas.microsoft.com/office/2006/relationships/legacyDiagramText":
            openXmlPart = (OpenXmlPart) new LegacyDiagramTextPart();
            break;
          case "http://schemas.microsoft.com/office/2006/relationships/activeXControlBinary":
            openXmlPart = (OpenXmlPart) new EmbeddedControlPersistenceBinaryDataPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/notesSlide":
            openXmlPart = (OpenXmlPart) new NotesSlidePart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/notesMaster":
            openXmlPart = (OpenXmlPart) new NotesMasterPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme":
            openXmlPart = (OpenXmlPart) new ThemePart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tags":
            openXmlPart = (OpenXmlPart) new UserDefinedTagsPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideLayout":
            openXmlPart = (OpenXmlPart) new SlideLayoutPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideMaster":
            openXmlPart = (OpenXmlPart) new SlideMasterPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/control":
            openXmlPart = (OpenXmlPart) new EmbeddedControlPersistencePart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideUpdateInfo":
            openXmlPart = (OpenXmlPart) new SlideSyncDataPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/worksheet":
            openXmlPart = (OpenXmlPart) new WorksheetPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/drawing":
            openXmlPart = (OpenXmlPart) new DrawingsPart();
            break;
          case "http://schemas.microsoft.com/office/2011/relationships/webextension":
            openXmlPart = (OpenXmlPart) new WebExtensionPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotTable":
            openXmlPart = (OpenXmlPart) new PivotTablePart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheDefinition":
            openXmlPart = (OpenXmlPart) new PivotTableCacheDefinitionPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheRecords":
            openXmlPart = (OpenXmlPart) new PivotTableCacheRecordsPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tableSingleCells":
            openXmlPart = (OpenXmlPart) new SingleCellTablePart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/table":
            openXmlPart = (OpenXmlPart) new TableDefinitionPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/queryTable":
            openXmlPart = (OpenXmlPart) new QueryTablePart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/ctrlProp":
            openXmlPart = (OpenXmlPart) new ControlPropertiesPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customProperty":
            openXmlPart = (OpenXmlPart) new CustomPropertyPart();
            break;
          case "http://schemas.microsoft.com/office/2006/relationships/wsSortMap":
            openXmlPart = (OpenXmlPart) new WorksheetSortMapPart();
            break;
          case "http://schemas.microsoft.com/office/2007/relationships/slicer":
            openXmlPart = (OpenXmlPart) new SlicersPart();
            break;
          case "http://schemas.microsoft.com/office/2011/relationships/timeline":
            openXmlPart = (OpenXmlPart) new TimeLinePart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/settings":
            openXmlPart = (OpenXmlPart) new DocumentSettingsPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/recipientData":
            openXmlPart = (OpenXmlPart) new MailMergeRecipientDataPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/endnotes":
            openXmlPart = (OpenXmlPart) new EndnotesPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/fontTable":
            openXmlPart = (OpenXmlPart) new FontTablePart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/font":
            openXmlPart = (OpenXmlPart) new FontPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/footnotes":
            openXmlPart = (OpenXmlPart) new FootnotesPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/numbering":
            openXmlPart = (OpenXmlPart) new NumberingDefinitionsPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles":
            openXmlPart = (OpenXmlPart) new StyleDefinitionsPart();
            break;
          case "http://schemas.microsoft.com/office/2007/relationships/stylesWithEffects":
            openXmlPart = (OpenXmlPart) new StylesWithEffectsPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/webSettings":
            openXmlPart = (OpenXmlPart) new WebSettingsPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/footer":
            openXmlPart = (OpenXmlPart) new FooterPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/header":
            openXmlPart = (OpenXmlPart) new HeaderPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/printerSettings":
            openXmlPart = (OpenXmlPart) new WordprocessingPrinterSettingsPart();
            break;
          case "http://schemas.microsoft.com/office/2006/relationships/keyMapCustomizations":
            openXmlPart = (OpenXmlPart) new CustomizationPart();
            break;
          case "http://schemas.microsoft.com/office/2006/relationships/attachedToolbars":
            openXmlPart = (OpenXmlPart) new WordAttachedToolbarsPart();
            break;
          case "http://schemas.microsoft.com/office/2006/relationships/vbaProject":
            openXmlPart = (OpenXmlPart) new VbaProjectPart();
            break;
          case "http://schemas.microsoft.com/office/2006/relationships/wordVbaData":
            openXmlPart = (OpenXmlPart) new VbaDataPart();
            break;
          case "http://schemas.microsoft.com/office/2011/relationships/commentsExtended":
            openXmlPart = (OpenXmlPart) new WordprocessingCommentsExPart();
            break;
          case "http://schemas.microsoft.com/office/2011/relationships/people":
            openXmlPart = (OpenXmlPart) new WordprocessingPeoplePart();
            break;
          case "http://schemas.openxmlformats.org/package/2006/relationships/metadata/thumbnail":
            openXmlPart = (OpenXmlPart) new ThumbnailPart();
            break;
          case "http://schemas.openxmlformats.org/package/2006/relationships/metadata/core-properties":
            openXmlPart = (OpenXmlPart) new CoreFilePropertiesPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/extended-properties":
            openXmlPart = (OpenXmlPart) new ExtendedFilePropertiesPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/custom-properties":
            openXmlPart = (OpenXmlPart) new CustomFilePropertiesPart();
            break;
          case "http://schemas.openxmlformats.org/package/2006/relationships/digital-signature/origin":
            openXmlPart = (OpenXmlPart) new DigitalSignatureOriginPart();
            break;
          case "http://schemas.openxmlformats.org/package/2006/relationships/digital-signature/signature":
            openXmlPart = (OpenXmlPart) new XmlSignaturePart();
            break;
          case "http://schemas.microsoft.com/office/2006/relationships/ui/userCustomization":
            openXmlPart = (OpenXmlPart) new QuickAccessToolbarCustomizationsPart();
            break;
          case "http://schemas.microsoft.com/office/2006/relationships/ui/extensibility":
            openXmlPart = (OpenXmlPart) new RibbonExtensibilityPart();
            break;
          case "http://schemas.microsoft.com/office/2007/relationships/ui/extensibility":
            openXmlPart = (OpenXmlPart) new RibbonAndBackstageCustomizationsPart();
            break;
          case "http://schemas.microsoft.com/office/2011/relationships/webextensiontaskpanes":
            openXmlPart = (OpenXmlPart) new WebExTaskpanesPart();
            break;
        }
      }
      else if (openXmlPackage is SpreadsheetDocument)
      {
        switch (relationshipType)
        {
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument":
            openXmlPart = (OpenXmlPart) new WorkbookPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml":
            openXmlPart = (OpenXmlPart) new CustomXmlPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXmlProps":
            openXmlPart = (OpenXmlPart) new CustomXmlPropertiesPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/calcChain":
            openXmlPart = (OpenXmlPart) new CalculationChainPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/sheetMetadata":
            openXmlPart = (OpenXmlPart) new CellMetadataPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/connections":
            openXmlPart = (OpenXmlPart) new ConnectionsPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/xmlMaps":
            openXmlPart = (OpenXmlPart) new CustomXmlMappingsPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/sharedStrings":
            openXmlPart = (OpenXmlPart) new SharedStringTablePart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/revisionHeaders":
            openXmlPart = (OpenXmlPart) new WorkbookRevisionHeaderPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/revisionLog":
            openXmlPart = (OpenXmlPart) new WorkbookRevisionLogPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/usernames":
            openXmlPart = (OpenXmlPart) new WorkbookUserDataPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles":
            openXmlPart = (OpenXmlPart) new WorkbookStylesPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme":
            openXmlPart = (OpenXmlPart) new ThemePart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image":
            openXmlPart = (OpenXmlPart) new ImagePart();
            break;
          case "http://schemas.openxmlformats.org/package/2006/relationships/metadata/thumbnail":
            openXmlPart = (OpenXmlPart) new ThumbnailPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/volatileDependencies":
            openXmlPart = (OpenXmlPart) new VolatileDependenciesPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chartsheet":
            openXmlPart = (OpenXmlPart) new ChartsheetPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/printerSettings":
            openXmlPart = (OpenXmlPart) new SpreadsheetPrinterSettingsPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/drawing":
            openXmlPart = (OpenXmlPart) new DrawingsPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart":
            openXmlPart = (OpenXmlPart) new ChartPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chartUserShapes":
            openXmlPart = (OpenXmlPart) new ChartDrawingPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/package":
            openXmlPart = (OpenXmlPart) new EmbeddedPackagePart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/themeOverride":
            openXmlPart = (OpenXmlPart) new ThemeOverridePart();
            break;
          case "http://schemas.microsoft.com/office/2011/relationships/chartStyle":
            openXmlPart = (OpenXmlPart) new ChartStylePart();
            break;
          case "http://schemas.microsoft.com/office/2011/relationships/chartColorStyle":
            openXmlPart = (OpenXmlPart) new ChartColorStylePart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors":
            openXmlPart = (OpenXmlPart) new DiagramColorsPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData":
            openXmlPart = (OpenXmlPart) new DiagramDataPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slide":
            openXmlPart = (OpenXmlPart) new SlidePart();
            break;
          case "http://schemas.microsoft.com/office/2007/relationships/diagramDrawing":
            openXmlPart = (OpenXmlPart) new DiagramPersistLayoutPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout":
            openXmlPart = (OpenXmlPart) new DiagramLayoutDefinitionPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle":
            openXmlPart = (OpenXmlPart) new DiagramStylePart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject":
            openXmlPart = (OpenXmlPart) new EmbeddedObjectPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/vmlDrawing":
            openXmlPart = (OpenXmlPart) new VmlDrawingPart();
            break;
          case "http://schemas.microsoft.com/office/2006/relationships/legacyDiagramText":
            openXmlPart = (OpenXmlPart) new LegacyDiagramTextPart();
            break;
          case "http://schemas.microsoft.com/office/2006/relationships/activeXControlBinary":
            openXmlPart = (OpenXmlPart) new EmbeddedControlPersistenceBinaryDataPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/notesSlide":
            openXmlPart = (OpenXmlPart) new NotesSlidePart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/notesMaster":
            openXmlPart = (OpenXmlPart) new NotesMasterPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tags":
            openXmlPart = (OpenXmlPart) new UserDefinedTagsPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideLayout":
            openXmlPart = (OpenXmlPart) new SlideLayoutPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideMaster":
            openXmlPart = (OpenXmlPart) new SlideMasterPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/control":
            openXmlPart = (OpenXmlPart) new EmbeddedControlPersistencePart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideUpdateInfo":
            openXmlPart = (OpenXmlPart) new SlideSyncDataPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/worksheet":
            openXmlPart = (OpenXmlPart) new WorksheetPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments":
            openXmlPart = (OpenXmlPart) new WorksheetCommentsPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotTable":
            openXmlPart = (OpenXmlPart) new PivotTablePart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheDefinition":
            openXmlPart = (OpenXmlPart) new PivotTableCacheDefinitionPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheRecords":
            openXmlPart = (OpenXmlPart) new PivotTableCacheRecordsPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tableSingleCells":
            openXmlPart = (OpenXmlPart) new SingleCellTablePart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/table":
            openXmlPart = (OpenXmlPart) new TableDefinitionPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/queryTable":
            openXmlPart = (OpenXmlPart) new QueryTablePart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/ctrlProp":
            openXmlPart = (OpenXmlPart) new ControlPropertiesPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customProperty":
            openXmlPart = (OpenXmlPart) new CustomPropertyPart();
            break;
          case "http://schemas.microsoft.com/office/2006/relationships/wsSortMap":
            openXmlPart = (OpenXmlPart) new WorksheetSortMapPart();
            break;
          case "http://schemas.microsoft.com/office/2007/relationships/slicer":
            openXmlPart = (OpenXmlPart) new SlicersPart();
            break;
          case "http://schemas.microsoft.com/office/2011/relationships/timeline":
            openXmlPart = (OpenXmlPart) new TimeLinePart();
            break;
          case "http://schemas.microsoft.com/office/2011/relationships/webextension":
            openXmlPart = (OpenXmlPart) new WebExtensionPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/dialogsheet":
            openXmlPart = (OpenXmlPart) new DialogsheetPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/externalLink":
            openXmlPart = (OpenXmlPart) new ExternalWorkbookPart();
            break;
          case "http://schemas.microsoft.com/office/2006/relationships/attachedToolbars":
            openXmlPart = (OpenXmlPart) new ExcelAttachedToolbarsPart();
            break;
          case "http://schemas.microsoft.com/office/2006/relationships/vbaProject":
            openXmlPart = (OpenXmlPart) new VbaProjectPart();
            break;
          case "http://schemas.microsoft.com/office/2006/relationships/wordVbaData":
            openXmlPart = (OpenXmlPart) new VbaDataPart();
            break;
          case "http://schemas.microsoft.com/office/2006/relationships/xlMacrosheet":
            openXmlPart = (OpenXmlPart) new MacroSheetPart();
            break;
          case "http://schemas.microsoft.com/office/2006/relationships/xlIntlMacrosheet":
            openXmlPart = (OpenXmlPart) new InternationalMacroSheetPart();
            break;
          case "http://schemas.microsoft.com/office/2007/relationships/customDataProps":
            openXmlPart = (OpenXmlPart) new CustomDataPropertiesPart();
            break;
          case "http://schemas.microsoft.com/office/2007/relationships/customData":
            openXmlPart = (OpenXmlPart) new CustomDataPart();
            break;
          case "http://schemas.microsoft.com/office/2007/relationships/slicerCache":
            openXmlPart = (OpenXmlPart) new SlicerCachePart();
            break;
          case "http://schemas.microsoft.com/office/2011/relationships/timelineCache":
            openXmlPart = (OpenXmlPart) new TimeLineCachePart();
            break;
          case "http://schemas.openxmlformats.org/package/2006/relationships/metadata/core-properties":
            openXmlPart = (OpenXmlPart) new CoreFilePropertiesPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/extended-properties":
            openXmlPart = (OpenXmlPart) new ExtendedFilePropertiesPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/custom-properties":
            openXmlPart = (OpenXmlPart) new CustomFilePropertiesPart();
            break;
          case "http://schemas.openxmlformats.org/package/2006/relationships/digital-signature/origin":
            openXmlPart = (OpenXmlPart) new DigitalSignatureOriginPart();
            break;
          case "http://schemas.openxmlformats.org/package/2006/relationships/digital-signature/signature":
            openXmlPart = (OpenXmlPart) new XmlSignaturePart();
            break;
          case "http://schemas.microsoft.com/office/2006/relationships/ui/userCustomization":
            openXmlPart = (OpenXmlPart) new QuickAccessToolbarCustomizationsPart();
            break;
          case "http://schemas.microsoft.com/office/2006/relationships/ui/extensibility":
            openXmlPart = (OpenXmlPart) new RibbonExtensibilityPart();
            break;
          case "http://schemas.microsoft.com/office/2007/relationships/ui/extensibility":
            openXmlPart = (OpenXmlPart) new RibbonAndBackstageCustomizationsPart();
            break;
          case "http://schemas.microsoft.com/office/2011/relationships/webextensiontaskpanes":
            openXmlPart = (OpenXmlPart) new WebExTaskpanesPart();
            break;
        }
      }
      else
      {
        if (!(openXmlPackage is PresentationDocument))
          return;
        switch (relationshipType)
        {
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument":
            openXmlPart = (OpenXmlPart) new PresentationPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml":
            openXmlPart = (OpenXmlPart) new CustomXmlPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXmlProps":
            openXmlPart = (OpenXmlPart) new CustomXmlPropertiesPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/font":
            openXmlPart = (OpenXmlPart) new FontPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/presProps":
            openXmlPart = (OpenXmlPart) new PresentationPropertiesPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tableStyles":
            openXmlPart = (OpenXmlPart) new TableStylesPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme":
            openXmlPart = (OpenXmlPart) new ThemePart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image":
            openXmlPart = (OpenXmlPart) new ImagePart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/viewProps":
            openXmlPart = (OpenXmlPart) new ViewPropertiesPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slide":
            openXmlPart = (OpenXmlPart) new SlidePart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart":
            openXmlPart = (OpenXmlPart) new ChartPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chartUserShapes":
            openXmlPart = (OpenXmlPart) new ChartDrawingPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/package":
            openXmlPart = (OpenXmlPart) new EmbeddedPackagePart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/themeOverride":
            openXmlPart = (OpenXmlPart) new ThemeOverridePart();
            break;
          case "http://schemas.microsoft.com/office/2011/relationships/chartStyle":
            openXmlPart = (OpenXmlPart) new ChartStylePart();
            break;
          case "http://schemas.microsoft.com/office/2011/relationships/chartColorStyle":
            openXmlPart = (OpenXmlPart) new ChartColorStylePart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors":
            openXmlPart = (OpenXmlPart) new DiagramColorsPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData":
            openXmlPart = (OpenXmlPart) new DiagramDataPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/worksheet":
            openXmlPart = (OpenXmlPart) new WorksheetPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/drawing":
            openXmlPart = (OpenXmlPart) new DrawingsPart();
            break;
          case "http://schemas.microsoft.com/office/2007/relationships/diagramDrawing":
            openXmlPart = (OpenXmlPart) new DiagramPersistLayoutPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout":
            openXmlPart = (OpenXmlPart) new DiagramLayoutDefinitionPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle":
            openXmlPart = (OpenXmlPart) new DiagramStylePart();
            break;
          case "http://schemas.microsoft.com/office/2011/relationships/webextension":
            openXmlPart = (OpenXmlPart) new WebExtensionPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/vmlDrawing":
            openXmlPart = (OpenXmlPart) new VmlDrawingPart();
            break;
          case "http://schemas.microsoft.com/office/2006/relationships/legacyDiagramText":
            openXmlPart = (OpenXmlPart) new LegacyDiagramTextPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotTable":
            openXmlPart = (OpenXmlPart) new PivotTablePart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheDefinition":
            openXmlPart = (OpenXmlPart) new PivotTableCacheDefinitionPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheRecords":
            openXmlPart = (OpenXmlPart) new PivotTableCacheRecordsPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tableSingleCells":
            openXmlPart = (OpenXmlPart) new SingleCellTablePart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/table":
            openXmlPart = (OpenXmlPart) new TableDefinitionPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/queryTable":
            openXmlPart = (OpenXmlPart) new QueryTablePart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/control":
            openXmlPart = (OpenXmlPart) new EmbeddedControlPersistencePart();
            break;
          case "http://schemas.microsoft.com/office/2006/relationships/activeXControlBinary":
            openXmlPart = (OpenXmlPart) new EmbeddedControlPersistenceBinaryDataPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/ctrlProp":
            openXmlPart = (OpenXmlPart) new ControlPropertiesPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject":
            openXmlPart = (OpenXmlPart) new EmbeddedObjectPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customProperty":
            openXmlPart = (OpenXmlPart) new CustomPropertyPart();
            break;
          case "http://schemas.microsoft.com/office/2006/relationships/wsSortMap":
            openXmlPart = (OpenXmlPart) new WorksheetSortMapPart();
            break;
          case "http://schemas.microsoft.com/office/2007/relationships/slicer":
            openXmlPart = (OpenXmlPart) new SlicersPart();
            break;
          case "http://schemas.microsoft.com/office/2011/relationships/timeline":
            openXmlPart = (OpenXmlPart) new TimeLinePart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments":
            openXmlPart = (OpenXmlPart) new SlideCommentsPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/notesSlide":
            openXmlPart = (OpenXmlPart) new NotesSlidePart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/notesMaster":
            openXmlPart = (OpenXmlPart) new NotesMasterPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tags":
            openXmlPart = (OpenXmlPart) new UserDefinedTagsPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideLayout":
            openXmlPart = (OpenXmlPart) new SlideLayoutPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideMaster":
            openXmlPart = (OpenXmlPart) new SlideMasterPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideUpdateInfo":
            openXmlPart = (OpenXmlPart) new SlideSyncDataPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/commentAuthors":
            openXmlPart = (OpenXmlPart) new CommentAuthorsPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/handoutMaster":
            openXmlPart = (OpenXmlPart) new HandoutMasterPart();
            break;
          case "http://schemas.microsoft.com/office/2006/relationships/legacyDocTextInfo":
            openXmlPart = (OpenXmlPart) new LegacyDiagramTextInfoPart();
            break;
          case "http://schemas.microsoft.com/office/2006/relationships/vbaProject":
            openXmlPart = (OpenXmlPart) new VbaProjectPart();
            break;
          case "http://schemas.microsoft.com/office/2006/relationships/wordVbaData":
            openXmlPart = (OpenXmlPart) new VbaDataPart();
            break;
          case "http://schemas.openxmlformats.org/package/2006/relationships/metadata/core-properties":
            openXmlPart = (OpenXmlPart) new CoreFilePropertiesPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/extended-properties":
            openXmlPart = (OpenXmlPart) new ExtendedFilePropertiesPart();
            break;
          case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/custom-properties":
            openXmlPart = (OpenXmlPart) new CustomFilePropertiesPart();
            break;
          case "http://schemas.openxmlformats.org/package/2006/relationships/metadata/thumbnail":
            openXmlPart = (OpenXmlPart) new ThumbnailPart();
            break;
          case "http://schemas.openxmlformats.org/package/2006/relationships/digital-signature/origin":
            openXmlPart = (OpenXmlPart) new DigitalSignatureOriginPart();
            break;
          case "http://schemas.openxmlformats.org/package/2006/relationships/digital-signature/signature":
            openXmlPart = (OpenXmlPart) new XmlSignaturePart();
            break;
          case "http://schemas.microsoft.com/office/2006/relationships/ui/userCustomization":
            openXmlPart = (OpenXmlPart) new QuickAccessToolbarCustomizationsPart();
            break;
          case "http://schemas.microsoft.com/office/2006/relationships/ui/extensibility":
            openXmlPart = (OpenXmlPart) new RibbonExtensibilityPart();
            break;
          case "http://schemas.microsoft.com/office/2007/relationships/ui/extensibility":
            openXmlPart = (OpenXmlPart) new RibbonAndBackstageCustomizationsPart();
            break;
          case "http://schemas.microsoft.com/office/2011/relationships/webextensiontaskpanes":
            openXmlPart = (OpenXmlPart) new WebExTaskpanesPart();
            break;
        }
      }
    }
  }
}

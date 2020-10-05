// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.RootElementFactory
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.AdditionalCharacteristics;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.CustomXmlDataProperties;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Office.Excel;
using DocumentFormat.OpenXml.Office.Word;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
using DocumentFormat.OpenXml.Office2013.Excel;
using DocumentFormat.OpenXml.Office2013.WebExtentionPane;
using DocumentFormat.OpenXml.Office2013.Word;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentFormat.OpenXml
{
  internal static class RootElementFactory
  {
    internal static OpenXmlElement CreateElement(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "theme" == name)
        return (OpenXmlElement) new Theme();
      if (10 == (int) namespaceId && "themeOverride" == name)
        return (OpenXmlElement) new ThemeOverride();
      if (10 == (int) namespaceId && "tblStyleLst" == name)
        return (OpenXmlElement) new TableStyleList();
      if (11 == (int) namespaceId && "chartSpace" == name)
        return (OpenXmlElement) new ChartSpace();
      if (11 == (int) namespaceId && "userShapes" == name)
        return (OpenXmlElement) new UserShapes();
      if (14 == (int) namespaceId && "colorsDef" == name)
        return (OpenXmlElement) new ColorsDefinition();
      if (14 == (int) namespaceId && "dataModel" == name)
        return (OpenXmlElement) new DataModelRoot();
      if (14 == (int) namespaceId && "layoutDef" == name)
        return (OpenXmlElement) new LayoutDefinition();
      if (14 == (int) namespaceId && "styleDef" == name)
        return (OpenXmlElement) new StyleDefinition();
      if (18 == (int) namespaceId && "wsDr" == name)
        return (OpenXmlElement) new WorksheetDrawing();
      if (8 == (int) namespaceId && "additionalCharacteristics" == name)
        return (OpenXmlElement) new AdditionalCharacteristicsInfo();
      if (9 == (int) namespaceId && "Sources" == name)
        return (OpenXmlElement) new Sources();
      if (20 == (int) namespaceId && "datastoreItem" == name)
        return (OpenXmlElement) new DataStoreItem();
      if (4 == (int) namespaceId && "Properties" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.CustomProperties.Properties();
      if (3 == (int) namespaceId && "Properties" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.ExtendedProperties.Properties();
      if (22 == (int) namespaceId && "calcChain" == name)
        return (OpenXmlElement) new CalculationChain();
      if (22 == (int) namespaceId && "comments" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Spreadsheet.Comments();
      if (22 == (int) namespaceId && "MapInfo" == name)
        return (OpenXmlElement) new MapInfo();
      if (22 == (int) namespaceId && "connections" == name)
        return (OpenXmlElement) new Connections();
      if (22 == (int) namespaceId && "pivotCacheDefinition" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Spreadsheet.PivotCacheDefinition();
      if (22 == (int) namespaceId && "pivotCacheRecords" == name)
        return (OpenXmlElement) new PivotCacheRecords();
      if (22 == (int) namespaceId && "pivotTableDefinition" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Spreadsheet.PivotTableDefinition();
      if (22 == (int) namespaceId && "queryTable" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Spreadsheet.QueryTable();
      if (22 == (int) namespaceId && "sst" == name)
        return (OpenXmlElement) new SharedStringTable();
      if (22 == (int) namespaceId && "headers" == name)
        return (OpenXmlElement) new Headers();
      if (22 == (int) namespaceId && "revisions" == name)
        return (OpenXmlElement) new Revisions();
      if (22 == (int) namespaceId && "users" == name)
        return (OpenXmlElement) new Users();
      if (22 == (int) namespaceId && "worksheet" == name)
        return (OpenXmlElement) new Worksheet();
      if (22 == (int) namespaceId && "chartsheet" == name)
        return (OpenXmlElement) new Chartsheet();
      if (22 == (int) namespaceId && "dialogsheet" == name)
        return (OpenXmlElement) new DialogSheet();
      if (22 == (int) namespaceId && "metadata" == name)
        return (OpenXmlElement) new Metadata();
      if (22 == (int) namespaceId && "singleXmlCells" == name)
        return (OpenXmlElement) new SingleXmlCells();
      if (22 == (int) namespaceId && "styleSheet" == name)
        return (OpenXmlElement) new Stylesheet();
      if (22 == (int) namespaceId && "externalLink" == name)
        return (OpenXmlElement) new ExternalLink();
      if (22 == (int) namespaceId && "table" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Spreadsheet.Table();
      if (22 == (int) namespaceId && "volTypes" == name)
        return (OpenXmlElement) new VolatileTypes();
      if (22 == (int) namespaceId && "workbook" == name)
        return (OpenXmlElement) new Workbook();
      if (23 == (int) namespaceId && "recipients" == name)
        return (OpenXmlElement) new Recipients();
      if (23 == (int) namespaceId && "comments" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Wordprocessing.Comments();
      if (23 == (int) namespaceId && "footnotes" == name)
        return (OpenXmlElement) new Footnotes();
      if (23 == (int) namespaceId && "endnotes" == name)
        return (OpenXmlElement) new Endnotes();
      if (23 == (int) namespaceId && "hdr" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Wordprocessing.Header();
      if (23 == (int) namespaceId && "ftr" == name)
        return (OpenXmlElement) new Footer();
      if (23 == (int) namespaceId && "settings" == name)
        return (OpenXmlElement) new Settings();
      if (23 == (int) namespaceId && "webSettings" == name)
        return (OpenXmlElement) new WebSettings();
      if (23 == (int) namespaceId && "fonts" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Wordprocessing.Fonts();
      if (23 == (int) namespaceId && "numbering" == name)
        return (OpenXmlElement) new Numbering();
      if (23 == (int) namespaceId && "styles" == name)
        return (OpenXmlElement) new Styles();
      if (23 == (int) namespaceId && "document" == name)
        return (OpenXmlElement) new Document();
      if (23 == (int) namespaceId && "glossaryDocument" == name)
        return (OpenXmlElement) new GlossaryDocument();
      if (24 == (int) namespaceId && "cmAuthorLst" == name)
        return (OpenXmlElement) new CommentAuthorList();
      if (24 == (int) namespaceId && "cmLst" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Presentation.CommentList();
      if (24 == (int) namespaceId && "presentation" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Presentation.Presentation();
      if (24 == (int) namespaceId && "presentationPr" == name)
        return (OpenXmlElement) new PresentationProperties();
      if (24 == (int) namespaceId && "sld" == name)
        return (OpenXmlElement) new Slide();
      if (24 == (int) namespaceId && "sldLayout" == name)
        return (OpenXmlElement) new SlideLayout();
      if (24 == (int) namespaceId && "sldMaster" == name)
        return (OpenXmlElement) new SlideMaster();
      if (24 == (int) namespaceId && "handoutMaster" == name)
        return (OpenXmlElement) new HandoutMaster();
      if (24 == (int) namespaceId && "notesMaster" == name)
        return (OpenXmlElement) new NotesMaster();
      if (24 == (int) namespaceId && "notes" == name)
        return (OpenXmlElement) new NotesSlide();
      if (24 == (int) namespaceId && "sldSyncPr" == name)
        return (OpenXmlElement) new SlideSyncProperties();
      if (24 == (int) namespaceId && "tagLst" == name)
        return (OpenXmlElement) new TagList();
      if (24 == (int) namespaceId && "viewPr" == name)
        return (OpenXmlElement) new ViewProperties();
      if (32 == (int) namespaceId && "macrosheet" == name)
        return (OpenXmlElement) new Macrosheet();
      if (32 == (int) namespaceId && "worksheetSortMap" == name)
        return (OpenXmlElement) new WorksheetSortMap();
      if (33 == (int) namespaceId && "tcg" == name)
        return (OpenXmlElement) new TemplateCommandGroup();
      if (33 == (int) namespaceId && "vbaSuppData" == name)
        return (OpenXmlElement) new VbaSuppData();
      if (33 == (int) namespaceId && "recipients" == name)
        return (OpenXmlElement) new MailMergeRecipients();
      if (34 == (int) namespaceId && "customUI" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office.CustomUI.CustomUI();
      if (43 == (int) namespaceId && "ink" == name)
        return (OpenXmlElement) new Ink();
      if (53 == (int) namespaceId && "datastoreItem" == name)
        return (OpenXmlElement) new DatastoreItem();
      if (53 == (int) namespaceId && "formControlPr" == name)
        return (OpenXmlElement) new FormControlProperties();
      if (53 == (int) namespaceId && "slicers" == name)
        return (OpenXmlElement) new Slicers();
      if (53 == (int) namespaceId && "slicerCacheDefinition" == name)
        return (OpenXmlElement) new SlicerCacheDefinition();
      if (56 == (int) namespaceId && "drawing" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office.Drawing.Drawing();
      if (57 == (int) namespaceId && "customUI" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI();
      if (65 == (int) namespaceId && "colorStyle" == name)
        return (OpenXmlElement) new ColorStyle();
      if (65 == (int) namespaceId && "chartStyle" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle();
      if (66 == (int) namespaceId && "webextension" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension();
      if (69 == (int) namespaceId && "commentsEx" == name)
        return (OpenXmlElement) new CommentsEx();
      if (69 == (int) namespaceId && "people" == name)
        return (OpenXmlElement) new People();
      if (70 == (int) namespaceId && "taskpanes" == name)
        return (OpenXmlElement) new Taskpanes();
      if (71 == (int) namespaceId && "timelines" == name)
        return (OpenXmlElement) new Timelines();
      if (71 == (int) namespaceId && "timelineCacheDefinition" == name)
        return (OpenXmlElement) new TimelineCacheDefinition();
      return (OpenXmlElement) null;
    }

    internal static OpenXmlElement CreateElement(string namespaceUri, string name)
    {
      OpenXmlElement openXmlElement = (OpenXmlElement) null;
      byte id;
      if (namespaceUri != null && NamespaceIdMap.TryGetNamespaceId(namespaceUri, out id))
        openXmlElement = RootElementFactory.CreateElement(id, name);
      if (openXmlElement == null)
        openXmlElement = (OpenXmlElement) new OpenXmlUnknownElement();
      return openXmlElement;
    }
  }
}

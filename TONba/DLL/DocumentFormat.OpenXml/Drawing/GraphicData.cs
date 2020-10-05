// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.GraphicData
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.CustomXmlSchemaReferences;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Drawing.LegacyCompatibility;
using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Office.Drawing;
using DocumentFormat.OpenXml.Office2010.Drawing;
using DocumentFormat.OpenXml.Office2010.Drawing.Charts;
using DocumentFormat.OpenXml.Office2010.Drawing.Diagram;
using DocumentFormat.OpenXml.Office2010.PowerPoint;
using DocumentFormat.OpenXml.Office2010.Word;
using DocumentFormat.OpenXml.Office2010.Word.Drawing;
using DocumentFormat.OpenXml.Office2010.Word.DrawingCanvas;
using DocumentFormat.OpenXml.Office2010.Word.DrawingGroup;
using DocumentFormat.OpenXml.Office2010.Word.DrawingShape;
using DocumentFormat.OpenXml.Office2013.Drawing;
using DocumentFormat.OpenXml.Office2013.Drawing.Chart;
using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
using DocumentFormat.OpenXml.Office2013.PowerPoint;
using DocumentFormat.OpenXml.Office2013.Theme;
using DocumentFormat.OpenXml.Office2013.WebExtension;
using DocumentFormat.OpenXml.Office2013.Word;
using DocumentFormat.OpenXml.Office2013.Word.Drawing;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Vml;
using DocumentFormat.OpenXml.Vml.Office;
using DocumentFormat.OpenXml.Vml.Presentation;
using DocumentFormat.OpenXml.Vml.Wordprocessing;
using DocumentFormat.OpenXml.Wordprocessing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (LayoutDefinitionHeaderList))]
  [ChildElementInfo(typeof (RevealTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (FerrisTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Blip))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Drawing.Theme))]
  [ChildElementInfo(typeof (ThemeOverride))]
  [ChildElementInfo(typeof (ThemeManager))]
  [ChildElementInfo(typeof (Table))]
  [ChildElementInfo(typeof (TableStyleList))]
  [ChildElementInfo(typeof (WebVideoProperty), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ThemeFamily), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2013.Drawing.BackgroundProperties), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (NonVisualGroupProperties), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ObjectProperties), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (CameraTool), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (CompatExtension), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (IsCanvas), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (GvmlContentPart), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ShadowObscured), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (HiddenFillProperties), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (HiddenLineProperties), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (HiddenEffectsProperties), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (HiddenScene3D), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (HiddenShape3D), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ImageProperties), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (UseLocalDpi), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (TextMath), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.Drawing.Diagram.NonVisualDrawingProperties), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (RecolorImages), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office.Drawing.Drawing))]
  [ChildElementInfo(typeof (DataModelExtensionBlock))]
  [ChildElementInfo(typeof (ColorsDefinition))]
  [ChildElementInfo(typeof (ColorsDefinitionHeader))]
  [ChildElementInfo(typeof (ColorsDefinitionHeaderList))]
  [ChildElementInfo(typeof (DataModelRoot))]
  [ChildElementInfo(typeof (LayoutDefinition))]
  [ChildElementInfo(typeof (LayoutDefinitionHeader))]
  [ChildElementInfo(typeof (RelationshipIds))]
  [ChildElementInfo(typeof (StyleDefinition))]
  [ChildElementInfo(typeof (StyleDefinitionHeader))]
  [ChildElementInfo(typeof (StyleDefinitionHeaderList))]
  [ChildElementInfo(typeof (ChartSpace))]
  [ChildElementInfo(typeof (UserShapes))]
  [ChildElementInfo(typeof (ChartReference))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2013.Drawing.Chart.PivotSource), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShapeProperties), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2013.Drawing.Chart.Layout), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (FullReference), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (LevelReference), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (FormulaReference), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (FilteredSeriesTitle), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (FilteredCategoryTitle), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (FilteredAreaSeries), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (FilteredBarSeries), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (FilteredBubbleSeries), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (FilteredLineSeriesExtension), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (FilteredPieSeries), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (FilteredRadarSeries), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (FilteredScatterSeries), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (FilteredSurfaceSeries), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DataLabelsRange), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (CategoryFilterExceptions), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DataLabelFieldTable), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ExceptionForSave), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ShowDataLabelsRange), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShowLeaderLines), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2013.Drawing.Chart.LeaderLines), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (AutoGeneneratedCategories), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (PivotOptions), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (SketchOptions), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (InvertSolidFillFormat), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.Drawing.Charts.Style), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (LegacyDrawing))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Drawing.LockedCanvas.LockedCanvas))]
  [ChildElementInfo(typeof (Inline))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor))]
  [ChildElementInfo(typeof (PercentagePositionHeightOffset), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (PercentagePositionVerticalOffset), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (RelativeWidth), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (RelativeHeight), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Drawing.Pictures.Picture))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.Drawing.Pictures.ShapeStyle), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.Drawing.Pictures.OfficeArtExtensionList), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (WorksheetDrawing))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Drawing.Spreadsheet.ContentPart), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.Excel.Drawing.ContentPart), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (CommentAuthorList))]
  [ChildElementInfo(typeof (CommentList))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Presentation.OleObject))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Presentation.Presentation))]
  [ChildElementInfo(typeof (PresentationProperties))]
  [ChildElementInfo(typeof (Slide))]
  [ChildElementInfo(typeof (SlideLayout))]
  [ChildElementInfo(typeof (SlideMaster))]
  [ChildElementInfo(typeof (HandoutMaster))]
  [ChildElementInfo(typeof (NotesMaster))]
  [ChildElementInfo(typeof (NotesSlide))]
  [ChildElementInfo(typeof (SlideSyncProperties))]
  [ChildElementInfo(typeof (TagList))]
  [ChildElementInfo(typeof (ViewProperties))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Presentation.ContentPart), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (PresetTransition), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2013.PowerPoint.PresenceInfo), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ThreadingInfo), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (SlideGuideList), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (NotesGuideList), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ChartTrackingReferenceBased), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.PowerPoint.NonVisualContentPartProperties), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.PowerPoint.Transform2D), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ExtensionListModify), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Media), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (VortexTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (SwitchTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (FlipTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (RippleTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (HoneycombTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (PrismTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DoorsTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (WindowTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Graphic))]
  [ChildElementInfo(typeof (GalleryTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ConveyorTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (PanTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (GlitterTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (WarpTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (FlythroughTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (FlashTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ShredTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (WheelReverseTransition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (BookmarkTarget), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.PowerPoint.SectionProperties), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (SectionList), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (BrowseMode), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (LaserColor), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.PowerPoint.DefaultImageDpi), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DiscardImageEditData), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ShowMediaControls), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (LaserTraceList), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (CreationId), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ModificationId), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ShowEventRecordList), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (SchemaLibrary))]
  [ChildElementInfo(typeof (MathProperties))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Math.Paragraph))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Math.OfficeMath))]
  [ChildElementInfo(typeof (Recipients))]
  [ChildElementInfo(typeof (TextBoxContent))]
  [ChildElementInfo(typeof (Comments))]
  [ChildElementInfo(typeof (Footnotes))]
  [ChildElementInfo(typeof (Endnotes))]
  [ChildElementInfo(typeof (Header))]
  [ChildElementInfo(typeof (Footer))]
  [ChildElementInfo(typeof (Settings))]
  [ChildElementInfo(typeof (WebSettings))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Wordprocessing.Fonts))]
  [ChildElementInfo(typeof (Numbering))]
  [ChildElementInfo(typeof (Styles))]
  [ChildElementInfo(typeof (Document))]
  [ChildElementInfo(typeof (GlossaryDocument))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2013.Word.Color), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2013.Word.DataBinding), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Appearance), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (CommentsEx), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (People), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (SdtRepeatedSection), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (SdtRepeatedSectionItem), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ChartTrackingRefBased), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DefaultCollapsed), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (PersistentDocumentId), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (FootnoteColumns), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (WebExtensionLinked), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (WebExtensionCreated), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.Word.ContentPart), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentId), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ConflictMode), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (CustomXmlConflictInsertionRangeStart), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (CustomXmlConflictInsertionRangeEnd), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (CustomXmlConflictDeletionRangeStart), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (CustomXmlConflictDeletionRangeEnd), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DiscardImageEditingData), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.Word.DefaultImageDpi), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (EntityPickerEmpty), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (SdtContentCheckBox), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Vml.Shape))]
  [ChildElementInfo(typeof (Shapetype))]
  [ChildElementInfo(typeof (Group))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Vml.Background))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Vml.Fill))]
  [ChildElementInfo(typeof (Formulas))]
  [ChildElementInfo(typeof (ShapeHandles))]
  [ChildElementInfo(typeof (ImageData))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Vml.Path))]
  [ChildElementInfo(typeof (TextBox))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Vml.Shadow))]
  [ChildElementInfo(typeof (Stroke))]
  [ChildElementInfo(typeof (TextPath))]
  [ChildElementInfo(typeof (Arc))]
  [ChildElementInfo(typeof (Curve))]
  [ChildElementInfo(typeof (ImageFile))]
  [ChildElementInfo(typeof (Line))]
  [ChildElementInfo(typeof (Oval))]
  [ChildElementInfo(typeof (PolyLine))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Vml.Rectangle))]
  [ChildElementInfo(typeof (RoundRectangle))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Vml.Office.ShapeDefaults))]
  [ChildElementInfo(typeof (ShapeLayout))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Vml.Office.SignatureLine))]
  [ChildElementInfo(typeof (Ink))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Vml.Office.Diagram))]
  [ChildElementInfo(typeof (Skew))]
  [ChildElementInfo(typeof (Extrusion))]
  [ChildElementInfo(typeof (Callout))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Vml.Office.Lock))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Vml.Office.OleObject))]
  [ChildElementInfo(typeof (Complex))]
  [ChildElementInfo(typeof (LeftStroke))]
  [ChildElementInfo(typeof (TopStroke))]
  [ChildElementInfo(typeof (RightStroke))]
  [ChildElementInfo(typeof (BottomStroke))]
  [ChildElementInfo(typeof (ColumnStroke))]
  [ChildElementInfo(typeof (ClipPath))]
  [ChildElementInfo(typeof (FillExtendedProperties))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder))]
  [ChildElementInfo(typeof (TextWrap))]
  [ChildElementInfo(typeof (AnchorLock))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData))]
  [ChildElementInfo(typeof (InkAnnotationFlag))]
  [ChildElementInfo(typeof (TextData))]
  [ChildElementInfo(typeof (WordprocessingCanvas), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (WordprocessingGroup), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (WordprocessingShape), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.Drawing.Slicer.Slicer), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ColorStyle), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (WebExtensionReference), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (WebExtentionId), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2013.Drawing.TimeSlicer.TimeSlicer), FileFormatVersions.Office2013)]
  public class GraphicData : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "uri"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "graphicData";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10171;

    public override string LocalName
    {
      get
      {
        return "graphicData";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 10;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10171;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return GraphicData.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return GraphicData.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
      get
      {
        return (StringValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    public GraphicData()
    {
    }

    public GraphicData(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public GraphicData(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public GraphicData(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "graphic" == name)
        return (OpenXmlElement) new Graphic();
      if (10 == (int) namespaceId && "blip" == name)
        return (OpenXmlElement) new Blip();
      if (10 == (int) namespaceId && "theme" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Drawing.Theme();
      if (10 == (int) namespaceId && "themeOverride" == name)
        return (OpenXmlElement) new ThemeOverride();
      if (10 == (int) namespaceId && "themeManager" == name)
        return (OpenXmlElement) new ThemeManager();
      if (10 == (int) namespaceId && "tbl" == name)
        return (OpenXmlElement) new Table();
      if (10 == (int) namespaceId && "tblStyleLst" == name)
        return (OpenXmlElement) new TableStyleList();
      if (75 == (int) namespaceId && "webVideoPr" == name)
        return (OpenXmlElement) new WebVideoProperty();
      if (73 == (int) namespaceId && "themeFamily" == name)
        return (OpenXmlElement) new ThemeFamily();
      if (67 == (int) namespaceId && "backgroundPr" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2013.Drawing.BackgroundProperties();
      if (67 == (int) namespaceId && "nonVisualGroupProps" == name)
        return (OpenXmlElement) new NonVisualGroupProperties();
      if (67 == (int) namespaceId && "objectPr" == name)
        return (OpenXmlElement) new ObjectProperties();
      if (67 == (int) namespaceId && "signatureLine" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine();
      if (48 == (int) namespaceId && "cameraTool" == name)
        return (OpenXmlElement) new CameraTool();
      if (48 == (int) namespaceId && "compatExt" == name)
        return (OpenXmlElement) new CompatExtension();
      if (48 == (int) namespaceId && "isCanvas" == name)
        return (OpenXmlElement) new IsCanvas();
      if (48 == (int) namespaceId && "contentPart" == name)
        return (OpenXmlElement) new GvmlContentPart();
      if (48 == (int) namespaceId && "shadowObscured" == name)
        return (OpenXmlElement) new ShadowObscured();
      if (48 == (int) namespaceId && "hiddenFill" == name)
        return (OpenXmlElement) new HiddenFillProperties();
      if (48 == (int) namespaceId && "hiddenLine" == name)
        return (OpenXmlElement) new HiddenLineProperties();
      if (48 == (int) namespaceId && "hiddenEffects" == name)
        return (OpenXmlElement) new HiddenEffectsProperties();
      if (48 == (int) namespaceId && "hiddenScene3d" == name)
        return (OpenXmlElement) new HiddenScene3D();
      if (48 == (int) namespaceId && "hiddenSp3d" == name)
        return (OpenXmlElement) new HiddenShape3D();
      if (48 == (int) namespaceId && "imgProps" == name)
        return (OpenXmlElement) new ImageProperties();
      if (48 == (int) namespaceId && "useLocalDpi" == name)
        return (OpenXmlElement) new UseLocalDpi();
      if (48 == (int) namespaceId && "m" == name)
        return (OpenXmlElement) new TextMath();
      if (58 == (int) namespaceId && "cNvPr" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.Drawing.Diagram.NonVisualDrawingProperties();
      if (58 == (int) namespaceId && "recolorImg" == name)
        return (OpenXmlElement) new RecolorImages();
      if (56 == (int) namespaceId && "drawing" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office.Drawing.Drawing();
      if (56 == (int) namespaceId && "dataModelExt" == name)
        return (OpenXmlElement) new DataModelExtensionBlock();
      if (14 == (int) namespaceId && "colorsDef" == name)
        return (OpenXmlElement) new ColorsDefinition();
      if (14 == (int) namespaceId && "colorsDefHdr" == name)
        return (OpenXmlElement) new ColorsDefinitionHeader();
      if (14 == (int) namespaceId && "colorsDefHdrLst" == name)
        return (OpenXmlElement) new ColorsDefinitionHeaderList();
      if (14 == (int) namespaceId && "dataModel" == name)
        return (OpenXmlElement) new DataModelRoot();
      if (14 == (int) namespaceId && "layoutDef" == name)
        return (OpenXmlElement) new LayoutDefinition();
      if (14 == (int) namespaceId && "layoutDefHdr" == name)
        return (OpenXmlElement) new LayoutDefinitionHeader();
      if (14 == (int) namespaceId && "layoutDefHdrLst" == name)
        return (OpenXmlElement) new LayoutDefinitionHeaderList();
      if (14 == (int) namespaceId && "relIds" == name)
        return (OpenXmlElement) new RelationshipIds();
      if (14 == (int) namespaceId && "styleDef" == name)
        return (OpenXmlElement) new StyleDefinition();
      if (14 == (int) namespaceId && "styleDefHdr" == name)
        return (OpenXmlElement) new StyleDefinitionHeader();
      if (14 == (int) namespaceId && "styleDefHdrLst" == name)
        return (OpenXmlElement) new StyleDefinitionHeaderList();
      if (11 == (int) namespaceId && "chartSpace" == name)
        return (OpenXmlElement) new ChartSpace();
      if (11 == (int) namespaceId && "userShapes" == name)
        return (OpenXmlElement) new UserShapes();
      if (11 == (int) namespaceId && "chart" == name)
        return (OpenXmlElement) new ChartReference();
      if (64 == (int) namespaceId && "pivotSource" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2013.Drawing.Chart.PivotSource();
      if (64 == (int) namespaceId && "numFmt" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat();
      if (64 == (int) namespaceId && "spPr" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShapeProperties();
      if (64 == (int) namespaceId && "layout" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2013.Drawing.Chart.Layout();
      if (64 == (int) namespaceId && "fullRef" == name)
        return (OpenXmlElement) new FullReference();
      if (64 == (int) namespaceId && "levelRef" == name)
        return (OpenXmlElement) new LevelReference();
      if (64 == (int) namespaceId && "formulaRef" == name)
        return (OpenXmlElement) new FormulaReference();
      if (64 == (int) namespaceId && "filteredSeriesTitle" == name)
        return (OpenXmlElement) new FilteredSeriesTitle();
      if (64 == (int) namespaceId && "filteredCategoryTitle" == name)
        return (OpenXmlElement) new FilteredCategoryTitle();
      if (64 == (int) namespaceId && "filteredAreaSeries" == name)
        return (OpenXmlElement) new FilteredAreaSeries();
      if (64 == (int) namespaceId && "filteredBarSeries" == name)
        return (OpenXmlElement) new FilteredBarSeries();
      if (64 == (int) namespaceId && "filteredBubbleSeries" == name)
        return (OpenXmlElement) new FilteredBubbleSeries();
      if (64 == (int) namespaceId && "filteredLineSeries" == name)
        return (OpenXmlElement) new FilteredLineSeriesExtension();
      if (64 == (int) namespaceId && "filteredPieSeries" == name)
        return (OpenXmlElement) new FilteredPieSeries();
      if (64 == (int) namespaceId && "filteredRadarSeries" == name)
        return (OpenXmlElement) new FilteredRadarSeries();
      if (64 == (int) namespaceId && "filteredScatterSeries" == name)
        return (OpenXmlElement) new FilteredScatterSeries();
      if (64 == (int) namespaceId && "filteredSurfaceSeries" == name)
        return (OpenXmlElement) new FilteredSurfaceSeries();
      if (64 == (int) namespaceId && "datalabelsRange" == name)
        return (OpenXmlElement) new DataLabelsRange();
      if (64 == (int) namespaceId && "categoryFilterExceptions" == name)
        return (OpenXmlElement) new CategoryFilterExceptions();
      if (64 == (int) namespaceId && "dlblFieldTable" == name)
        return (OpenXmlElement) new DataLabelFieldTable();
      if (64 == (int) namespaceId && "xForSave" == name)
        return (OpenXmlElement) new ExceptionForSave();
      if (64 == (int) namespaceId && "showDataLabelsRange" == name)
        return (OpenXmlElement) new ShowDataLabelsRange();
      if (64 == (int) namespaceId && "tx" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText();
      if (64 == (int) namespaceId && "showLeaderLines" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShowLeaderLines();
      if (64 == (int) namespaceId && "leaderLines" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2013.Drawing.Chart.LeaderLines();
      if (64 == (int) namespaceId && "autoCat" == name)
        return (OpenXmlElement) new AutoGeneneratedCategories();
      if (46 == (int) namespaceId && "pivotOptions" == name)
        return (OpenXmlElement) new PivotOptions();
      if (46 == (int) namespaceId && "sketchOptions" == name)
        return (OpenXmlElement) new SketchOptions();
      if (46 == (int) namespaceId && "invertSolidFillFmt" == name)
        return (OpenXmlElement) new InvertSolidFillFormat();
      if (46 == (int) namespaceId && "style" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.Drawing.Charts.Style();
      if (47 == (int) namespaceId && "contentPart" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart();
      if (13 == (int) namespaceId && "legacyDrawing" == name)
        return (OpenXmlElement) new LegacyDrawing();
      if (15 == (int) namespaceId && "lockedCanvas" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Drawing.LockedCanvas.LockedCanvas();
      if (16 == (int) namespaceId && "inline" == name)
        return (OpenXmlElement) new Inline();
      if (16 == (int) namespaceId && "anchor" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Drawing.Wordprocessing.Anchor();
      if (51 == (int) namespaceId && "pctPosHOffset" == name)
        return (OpenXmlElement) new PercentagePositionHeightOffset();
      if (51 == (int) namespaceId && "pctPosVOffset" == name)
        return (OpenXmlElement) new PercentagePositionVerticalOffset();
      if (51 == (int) namespaceId && "sizeRelH" == name)
        return (OpenXmlElement) new RelativeWidth();
      if (51 == (int) namespaceId && "sizeRelV" == name)
        return (OpenXmlElement) new RelativeHeight();
      if (17 == (int) namespaceId && "pic" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Drawing.Pictures.Picture();
      if (50 == (int) namespaceId && "style" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.Drawing.Pictures.ShapeStyle();
      if (50 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.Drawing.Pictures.OfficeArtExtensionList();
      if (18 == (int) namespaceId && "wsDr" == name)
        return (OpenXmlElement) new WorksheetDrawing();
      if (18 == (int) namespaceId && "contentPart" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Drawing.Spreadsheet.ContentPart();
      if (54 == (int) namespaceId && "contentPart" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.Excel.Drawing.ContentPart();
      if (24 == (int) namespaceId && "cmAuthorLst" == name)
        return (OpenXmlElement) new CommentAuthorList();
      if (24 == (int) namespaceId && "cmLst" == name)
        return (OpenXmlElement) new CommentList();
      if (24 == (int) namespaceId && "oleObj" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Presentation.OleObject();
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
      if (24 == (int) namespaceId && "contentPart" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Presentation.ContentPart();
      if (68 == (int) namespaceId && "prstTrans" == name)
        return (OpenXmlElement) new PresetTransition();
      if (68 == (int) namespaceId && "presenceInfo" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2013.PowerPoint.PresenceInfo();
      if (68 == (int) namespaceId && "threadingInfo" == name)
        return (OpenXmlElement) new ThreadingInfo();
      if (68 == (int) namespaceId && "sldGuideLst" == name)
        return (OpenXmlElement) new SlideGuideList();
      if (68 == (int) namespaceId && "notesGuideLst" == name)
        return (OpenXmlElement) new NotesGuideList();
      if (68 == (int) namespaceId && "chartTrackingRefBased" == name)
        return (OpenXmlElement) new ChartTrackingReferenceBased();
      if (49 == (int) namespaceId && "nvContentPartPr" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.PowerPoint.NonVisualContentPartProperties();
      if (49 == (int) namespaceId && "xfrm" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.PowerPoint.Transform2D();
      if (49 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionListModify();
      if (49 == (int) namespaceId && "media" == name)
        return (OpenXmlElement) new Media();
      if (49 == (int) namespaceId && "vortex" == name)
        return (OpenXmlElement) new VortexTransition();
      if (49 == (int) namespaceId && "switch" == name)
        return (OpenXmlElement) new SwitchTransition();
      if (49 == (int) namespaceId && "flip" == name)
        return (OpenXmlElement) new FlipTransition();
      if (49 == (int) namespaceId && "ripple" == name)
        return (OpenXmlElement) new RippleTransition();
      if (49 == (int) namespaceId && "honeycomb" == name)
        return (OpenXmlElement) new HoneycombTransition();
      if (49 == (int) namespaceId && "prism" == name)
        return (OpenXmlElement) new PrismTransition();
      if (49 == (int) namespaceId && "doors" == name)
        return (OpenXmlElement) new DoorsTransition();
      if (49 == (int) namespaceId && "window" == name)
        return (OpenXmlElement) new WindowTransition();
      if (49 == (int) namespaceId && "ferris" == name)
        return (OpenXmlElement) new FerrisTransition();
      if (49 == (int) namespaceId && "gallery" == name)
        return (OpenXmlElement) new GalleryTransition();
      if (49 == (int) namespaceId && "conveyor" == name)
        return (OpenXmlElement) new ConveyorTransition();
      if (49 == (int) namespaceId && "pan" == name)
        return (OpenXmlElement) new PanTransition();
      if (49 == (int) namespaceId && "glitter" == name)
        return (OpenXmlElement) new GlitterTransition();
      if (49 == (int) namespaceId && "warp" == name)
        return (OpenXmlElement) new WarpTransition();
      if (49 == (int) namespaceId && "flythrough" == name)
        return (OpenXmlElement) new FlythroughTransition();
      if (49 == (int) namespaceId && "flash" == name)
        return (OpenXmlElement) new FlashTransition();
      if (49 == (int) namespaceId && "shred" == name)
        return (OpenXmlElement) new ShredTransition();
      if (49 == (int) namespaceId && "reveal" == name)
        return (OpenXmlElement) new RevealTransition();
      if (49 == (int) namespaceId && "wheelReverse" == name)
        return (OpenXmlElement) new WheelReverseTransition();
      if (49 == (int) namespaceId && "bmkTgt" == name)
        return (OpenXmlElement) new BookmarkTarget();
      if (49 == (int) namespaceId && "sectionPr" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.PowerPoint.SectionProperties();
      if (49 == (int) namespaceId && "sectionLst" == name)
        return (OpenXmlElement) new SectionList();
      if (49 == (int) namespaceId && "browseMode" == name)
        return (OpenXmlElement) new BrowseMode();
      if (49 == (int) namespaceId && "laserClr" == name)
        return (OpenXmlElement) new LaserColor();
      if (49 == (int) namespaceId && "defaultImageDpi" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.PowerPoint.DefaultImageDpi();
      if (49 == (int) namespaceId && "discardImageEditData" == name)
        return (OpenXmlElement) new DiscardImageEditData();
      if (49 == (int) namespaceId && "showMediaCtrls" == name)
        return (OpenXmlElement) new ShowMediaControls();
      if (49 == (int) namespaceId && "laserTraceLst" == name)
        return (OpenXmlElement) new LaserTraceList();
      if (49 == (int) namespaceId && "creationId" == name)
        return (OpenXmlElement) new CreationId();
      if (49 == (int) namespaceId && "modId" == name)
        return (OpenXmlElement) new ModificationId();
      if (49 == (int) namespaceId && "showEvtLst" == name)
        return (OpenXmlElement) new ShowEventRecordList();
      if (25 == (int) namespaceId && "schemaLibrary" == name)
        return (OpenXmlElement) new SchemaLibrary();
      if (21 == (int) namespaceId && "mathPr" == name)
        return (OpenXmlElement) new MathProperties();
      if (21 == (int) namespaceId && "oMathPara" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Math.Paragraph();
      if (21 == (int) namespaceId && "oMath" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Math.OfficeMath();
      if (23 == (int) namespaceId && "recipients" == name)
        return (OpenXmlElement) new Recipients();
      if (23 == (int) namespaceId && "txbxContent" == name)
        return (OpenXmlElement) new TextBoxContent();
      if (23 == (int) namespaceId && "comments" == name)
        return (OpenXmlElement) new Comments();
      if (23 == (int) namespaceId && "footnotes" == name)
        return (OpenXmlElement) new Footnotes();
      if (23 == (int) namespaceId && "endnotes" == name)
        return (OpenXmlElement) new Endnotes();
      if (23 == (int) namespaceId && "hdr" == name)
        return (OpenXmlElement) new Header();
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
      if (69 == (int) namespaceId && "color" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2013.Word.Color();
      if (69 == (int) namespaceId && "dataBinding" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2013.Word.DataBinding();
      if (69 == (int) namespaceId && "appearance" == name)
        return (OpenXmlElement) new Appearance();
      if (69 == (int) namespaceId && "commentsEx" == name)
        return (OpenXmlElement) new CommentsEx();
      if (69 == (int) namespaceId && "people" == name)
        return (OpenXmlElement) new People();
      if (69 == (int) namespaceId && "repeatingSection" == name)
        return (OpenXmlElement) new SdtRepeatedSection();
      if (69 == (int) namespaceId && "repeatingSectionItem" == name)
        return (OpenXmlElement) new SdtRepeatedSectionItem();
      if (69 == (int) namespaceId && "chartTrackingRefBased" == name)
        return (OpenXmlElement) new ChartTrackingRefBased();
      if (69 == (int) namespaceId && "collapsed" == name)
        return (OpenXmlElement) new DefaultCollapsed();
      if (69 == (int) namespaceId && "docId" == name)
        return (OpenXmlElement) new PersistentDocumentId();
      if (69 == (int) namespaceId && "footnoteColumns" == name)
        return (OpenXmlElement) new FootnoteColumns();
      if (69 == (int) namespaceId && "webExtensionLinked" == name)
        return (OpenXmlElement) new WebExtensionLinked();
      if (69 == (int) namespaceId && "webExtensionCreated" == name)
        return (OpenXmlElement) new WebExtensionCreated();
      if (52 == (int) namespaceId && "contentPart" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.Word.ContentPart();
      if (52 == (int) namespaceId && "docId" == name)
        return (OpenXmlElement) new DocumentId();
      if (52 == (int) namespaceId && "conflictMode" == name)
        return (OpenXmlElement) new ConflictMode();
      if (52 == (int) namespaceId && "customXmlConflictInsRangeStart" == name)
        return (OpenXmlElement) new CustomXmlConflictInsertionRangeStart();
      if (52 == (int) namespaceId && "customXmlConflictInsRangeEnd" == name)
        return (OpenXmlElement) new CustomXmlConflictInsertionRangeEnd();
      if (52 == (int) namespaceId && "customXmlConflictDelRangeStart" == name)
        return (OpenXmlElement) new CustomXmlConflictDeletionRangeStart();
      if (52 == (int) namespaceId && "customXmlConflictDelRangeEnd" == name)
        return (OpenXmlElement) new CustomXmlConflictDeletionRangeEnd();
      if (52 == (int) namespaceId && "discardImageEditingData" == name)
        return (OpenXmlElement) new DiscardImageEditingData();
      if (52 == (int) namespaceId && "defaultImageDpi" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.Word.DefaultImageDpi();
      if (52 == (int) namespaceId && "entityPicker" == name)
        return (OpenXmlElement) new EntityPickerEmpty();
      if (52 == (int) namespaceId && "checkbox" == name)
        return (OpenXmlElement) new SdtContentCheckBox();
      if (26 == (int) namespaceId && "shape" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Vml.Shape();
      if (26 == (int) namespaceId && "shapetype" == name)
        return (OpenXmlElement) new Shapetype();
      if (26 == (int) namespaceId && "group" == name)
        return (OpenXmlElement) new Group();
      if (26 == (int) namespaceId && "background" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Vml.Background();
      if (26 == (int) namespaceId && "fill" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Vml.Fill();
      if (26 == (int) namespaceId && "formulas" == name)
        return (OpenXmlElement) new Formulas();
      if (26 == (int) namespaceId && "handles" == name)
        return (OpenXmlElement) new ShapeHandles();
      if (26 == (int) namespaceId && "imagedata" == name)
        return (OpenXmlElement) new ImageData();
      if (26 == (int) namespaceId && "path" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Vml.Path();
      if (26 == (int) namespaceId && "textbox" == name)
        return (OpenXmlElement) new TextBox();
      if (26 == (int) namespaceId && "shadow" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Vml.Shadow();
      if (26 == (int) namespaceId && "stroke" == name)
        return (OpenXmlElement) new Stroke();
      if (26 == (int) namespaceId && "textpath" == name)
        return (OpenXmlElement) new TextPath();
      if (26 == (int) namespaceId && "arc" == name)
        return (OpenXmlElement) new Arc();
      if (26 == (int) namespaceId && "curve" == name)
        return (OpenXmlElement) new Curve();
      if (26 == (int) namespaceId && "image" == name)
        return (OpenXmlElement) new ImageFile();
      if (26 == (int) namespaceId && "line" == name)
        return (OpenXmlElement) new Line();
      if (26 == (int) namespaceId && "oval" == name)
        return (OpenXmlElement) new Oval();
      if (26 == (int) namespaceId && "polyline" == name)
        return (OpenXmlElement) new PolyLine();
      if (26 == (int) namespaceId && "rect" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Vml.Rectangle();
      if (26 == (int) namespaceId && "roundrect" == name)
        return (OpenXmlElement) new RoundRectangle();
      if (27 == (int) namespaceId && "shapedefaults" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Vml.Office.ShapeDefaults();
      if (27 == (int) namespaceId && "shapelayout" == name)
        return (OpenXmlElement) new ShapeLayout();
      if (27 == (int) namespaceId && "signatureline" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Vml.Office.SignatureLine();
      if (27 == (int) namespaceId && "ink" == name)
        return (OpenXmlElement) new Ink();
      if (27 == (int) namespaceId && "diagram" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Vml.Office.Diagram();
      if (27 == (int) namespaceId && "skew" == name)
        return (OpenXmlElement) new Skew();
      if (27 == (int) namespaceId && "extrusion" == name)
        return (OpenXmlElement) new Extrusion();
      if (27 == (int) namespaceId && "callout" == name)
        return (OpenXmlElement) new Callout();
      if (27 == (int) namespaceId && "lock" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Vml.Office.Lock();
      if (27 == (int) namespaceId && "OLEObject" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Vml.Office.OleObject();
      if (27 == (int) namespaceId && "complex" == name)
        return (OpenXmlElement) new Complex();
      if (27 == (int) namespaceId && "left" == name)
        return (OpenXmlElement) new LeftStroke();
      if (27 == (int) namespaceId && "top" == name)
        return (OpenXmlElement) new TopStroke();
      if (27 == (int) namespaceId && "right" == name)
        return (OpenXmlElement) new RightStroke();
      if (27 == (int) namespaceId && "bottom" == name)
        return (OpenXmlElement) new BottomStroke();
      if (27 == (int) namespaceId && "column" == name)
        return (OpenXmlElement) new ColumnStroke();
      if (27 == (int) namespaceId && "clippath" == name)
        return (OpenXmlElement) new ClipPath();
      if (27 == (int) namespaceId && "fill" == name)
        return (OpenXmlElement) new FillExtendedProperties();
      if (28 == (int) namespaceId && "bordertop" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder();
      if (28 == (int) namespaceId && "borderleft" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder();
      if (28 == (int) namespaceId && "borderright" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder();
      if (28 == (int) namespaceId && "borderbottom" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder();
      if (28 == (int) namespaceId && "wrap" == name)
        return (OpenXmlElement) new TextWrap();
      if (28 == (int) namespaceId && "anchorlock" == name)
        return (OpenXmlElement) new AnchorLock();
      if (29 == (int) namespaceId && "ClientData" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData();
      if (30 == (int) namespaceId && "iscomment" == name)
        return (OpenXmlElement) new InkAnnotationFlag();
      if (30 == (int) namespaceId && "textdata" == name)
        return (OpenXmlElement) new TextData();
      if (59 == (int) namespaceId && "wpc" == name)
        return (OpenXmlElement) new WordprocessingCanvas();
      if (60 == (int) namespaceId && "wgp" == name)
        return (OpenXmlElement) new WordprocessingGroup();
      if (61 == (int) namespaceId && "wsp" == name)
        return (OpenXmlElement) new WordprocessingShape();
      if (62 == (int) namespaceId && "slicer" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.Drawing.Slicer.Slicer();
      if (65 == (int) namespaceId && "colorStyle" == name)
        return (OpenXmlElement) new ColorStyle();
      if (65 == (int) namespaceId && "chartStyle" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle();
      if (66 == (int) namespaceId && "webextension" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension();
      if (66 == (int) namespaceId && "webextensionref" == name)
        return (OpenXmlElement) new WebExtensionReference();
      if (66 == (int) namespaceId && "web-extension" == name)
        return (OpenXmlElement) new WebExtentionId();
      if (77 == (int) namespaceId && "timeslicer" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2013.Drawing.TimeSlicer.TimeSlicer();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "uri" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<GraphicData>(deep);
    }
  }
}

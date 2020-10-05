// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.GlossaryDocumentPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Packaging
{
  public class GlossaryDocumentPart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/glossaryDocument";
    internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.wordprocessingml.document.glossary+xml";
    internal const string TargetPathConstant = "glossary";
    internal const string TargetNameConstant = "document";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private GlossaryDocument _rootEle;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (GlossaryDocumentPart._partConstraint == null)
        GlossaryDocumentPart._partConstraint = new Dictionary<string, PartConstraintRule>()
        {
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments",
            new PartConstraintRule("WordprocessingCommentsPart", "application/vnd.openxmlformats-officedocument.wordprocessingml.comments+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/settings",
            new PartConstraintRule("DocumentSettingsPart", "application/vnd.openxmlformats-officedocument.wordprocessingml.settings+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/endnotes",
            new PartConstraintRule("EndnotesPart", "application/vnd.openxmlformats-officedocument.wordprocessingml.endnotes+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/fontTable",
            new PartConstraintRule("FontTablePart", "application/vnd.openxmlformats-officedocument.wordprocessingml.fontTable+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/footnotes",
            new PartConstraintRule("FootnotesPart", "application/vnd.openxmlformats-officedocument.wordprocessingml.footnotes+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/numbering",
            new PartConstraintRule("NumberingDefinitionsPart", "application/vnd.openxmlformats-officedocument.wordprocessingml.numbering+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles",
            new PartConstraintRule("StyleDefinitionsPart", "application/vnd.openxmlformats-officedocument.wordprocessingml.styles+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.microsoft.com/office/2007/relationships/stylesWithEffects",
            new PartConstraintRule("StylesWithEffectsPart", "application/vnd.ms-word.stylesWithEffects+xml", false, false, FileFormatVersions.Office2010)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/webSettings",
            new PartConstraintRule("WebSettingsPart", "application/vnd.openxmlformats-officedocument.wordprocessingml.webSettings+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/footer",
            new PartConstraintRule("FooterPart", "application/vnd.openxmlformats-officedocument.wordprocessingml.footer+xml", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/header",
            new PartConstraintRule("HeaderPart", "application/vnd.openxmlformats-officedocument.wordprocessingml.header+xml", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/printerSettings",
            new PartConstraintRule("WordprocessingPrinterSettingsPart", "application/vnd.openxmlformats-officedocument.wordprocessingml.printerSettings", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.microsoft.com/office/2006/relationships/keyMapCustomizations",
            new PartConstraintRule("CustomizationPart", "application/vnd.ms-word.keyMapCustomizations+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.microsoft.com/office/2006/relationships/vbaProject",
            new PartConstraintRule("VbaProjectPart", "application/vnd.ms-office.vbaProject", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.microsoft.com/office/2011/relationships/commentsExtended",
            new PartConstraintRule("WordprocessingCommentsExPart", "application/vnd.openxmlformats-officedocument.wordprocessingml.commentsExtended+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.microsoft.com/office/2011/relationships/people",
            new PartConstraintRule("WordprocessingPeoplePart", "application/vnd.openxmlformats-officedocument.wordprocessingml.people+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/aFChunk",
            new PartConstraintRule("AlternativeFormatImportPart", (string) null, false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart",
            new PartConstraintRule("ChartPart", "application/vnd.openxmlformats-officedocument.drawingml.chart+xml", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors",
            new PartConstraintRule("DiagramColorsPart", "application/vnd.openxmlformats-officedocument.drawingml.diagramColors+xml", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData",
            new PartConstraintRule("DiagramDataPart", "application/vnd.openxmlformats-officedocument.drawingml.diagramData+xml", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.microsoft.com/office/2007/relationships/diagramDrawing",
            new PartConstraintRule("DiagramPersistLayoutPart", "application/vnd.ms-office.drawingml.diagramDrawing+xml", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout",
            new PartConstraintRule("DiagramLayoutDefinitionPart", "application/vnd.openxmlformats-officedocument.drawingml.diagramLayout+xml", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle",
            new PartConstraintRule("DiagramStylePart", "application/vnd.openxmlformats-officedocument.drawingml.diagramStyle+xml", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/control",
            new PartConstraintRule("EmbeddedControlPersistencePart", (string) null, false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject",
            new PartConstraintRule("EmbeddedObjectPart", (string) null, false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/package",
            new PartConstraintRule("EmbeddedPackagePart", (string) null, false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image",
            new PartConstraintRule("ImagePart", (string) null, false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          }
        };
      return (IDictionary<string, PartConstraintRule>) GlossaryDocumentPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (GlossaryDocumentPart._dataPartReferenceConstraint == null)
        GlossaryDocumentPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>()
        {
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/video",
            new PartConstraintRule("VideoReferenceRelationship", (string) null, false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          }
        };
      return (IDictionary<string, PartConstraintRule>) GlossaryDocumentPart._dataPartReferenceConstraint;
    }

    protected internal GlossaryDocumentPart()
    {
    }

    internal override sealed OpenXmlPart CreatePartCore(string relationshipType)
    {
      this.ThrowIfObjectDisposed();
      if (relationshipType == null)
        throw new ArgumentNullException(nameof (relationshipType));
      switch (relationshipType)
      {
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments":
          return (OpenXmlPart) new WordprocessingCommentsPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/settings":
          return (OpenXmlPart) new DocumentSettingsPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/endnotes":
          return (OpenXmlPart) new EndnotesPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/fontTable":
          return (OpenXmlPart) new FontTablePart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/footnotes":
          return (OpenXmlPart) new FootnotesPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/numbering":
          return (OpenXmlPart) new NumberingDefinitionsPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles":
          return (OpenXmlPart) new StyleDefinitionsPart();
        case "http://schemas.microsoft.com/office/2007/relationships/stylesWithEffects":
          return (OpenXmlPart) new StylesWithEffectsPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/webSettings":
          return (OpenXmlPart) new WebSettingsPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/footer":
          return (OpenXmlPart) new FooterPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/header":
          return (OpenXmlPart) new HeaderPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/printerSettings":
          return (OpenXmlPart) new WordprocessingPrinterSettingsPart();
        case "http://schemas.microsoft.com/office/2006/relationships/keyMapCustomizations":
          return (OpenXmlPart) new CustomizationPart();
        case "http://schemas.microsoft.com/office/2006/relationships/vbaProject":
          return (OpenXmlPart) new VbaProjectPart();
        case "http://schemas.microsoft.com/office/2011/relationships/commentsExtended":
          return (OpenXmlPart) new WordprocessingCommentsExPart();
        case "http://schemas.microsoft.com/office/2011/relationships/people":
          return (OpenXmlPart) new WordprocessingPeoplePart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/aFChunk":
          return (OpenXmlPart) new AlternativeFormatImportPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart":
          return (OpenXmlPart) new ChartPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors":
          return (OpenXmlPart) new DiagramColorsPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData":
          return (OpenXmlPart) new DiagramDataPart();
        case "http://schemas.microsoft.com/office/2007/relationships/diagramDrawing":
          return (OpenXmlPart) new DiagramPersistLayoutPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout":
          return (OpenXmlPart) new DiagramLayoutDefinitionPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle":
          return (OpenXmlPart) new DiagramStylePart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/control":
          return (OpenXmlPart) new EmbeddedControlPersistencePart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject":
          return (OpenXmlPart) new EmbeddedObjectPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/package":
          return (OpenXmlPart) new EmbeddedPackagePart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image":
          return (OpenXmlPart) new ImagePart();
        default:
          throw new ArgumentOutOfRangeException(nameof (relationshipType));
      }
    }

    public AlternativeFormatImportPart AddAlternativeFormatImportPart(string contentType)
    {
      AlternativeFormatImportPart newPart = new AlternativeFormatImportPart();
      this.InitPart<AlternativeFormatImportPart>(newPart, contentType);
      return newPart;
    }

    public AlternativeFormatImportPart AddAlternativeFormatImportPart(AlternativeFormatImportPartType partType)
    {
      string contentType = AlternativeFormatImportPartTypeInfo.GetContentType(partType);
      string targetExtension = AlternativeFormatImportPartTypeInfo.GetTargetExtension(partType);
      this.OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetExtension);
      return this.AddAlternativeFormatImportPart(contentType);
    }

    public AlternativeFormatImportPart AddAlternativeFormatImportPart(string contentType, string id)
    {
      AlternativeFormatImportPart newPart = new AlternativeFormatImportPart();
      this.InitPart<AlternativeFormatImportPart>(newPart, contentType, id);
      return newPart;
    }

    public AlternativeFormatImportPart AddAlternativeFormatImportPart(AlternativeFormatImportPartType partType, string id)
    {
      string contentType = AlternativeFormatImportPartTypeInfo.GetContentType(partType);
      string targetExtension = AlternativeFormatImportPartTypeInfo.GetTargetExtension(partType);
      this.OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetExtension);
      return this.AddAlternativeFormatImportPart(contentType, id);
    }

    public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType)
    {
      EmbeddedControlPersistencePart newPart = new EmbeddedControlPersistencePart();
      this.InitPart<EmbeddedControlPersistencePart>(newPart, contentType);
      return newPart;
    }

    public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType)
    {
      string contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
      string targetExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
      this.OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetExtension);
      return this.AddEmbeddedControlPersistencePart(contentType);
    }

    public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType, string id)
    {
      EmbeddedControlPersistencePart newPart = new EmbeddedControlPersistencePart();
      this.InitPart<EmbeddedControlPersistencePart>(newPart, contentType, id);
      return newPart;
    }

    public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType, string id)
    {
      string contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
      string targetExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
      this.OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetExtension);
      return this.AddEmbeddedControlPersistencePart(contentType, id);
    }

    public EmbeddedObjectPart AddEmbeddedObjectPart(string contentType)
    {
      EmbeddedObjectPart newPart = new EmbeddedObjectPart();
      this.InitPart<EmbeddedObjectPart>(newPart, contentType);
      return newPart;
    }

    public EmbeddedPackagePart AddEmbeddedPackagePart(string contentType)
    {
      EmbeddedPackagePart newPart = new EmbeddedPackagePart();
      this.InitPart<EmbeddedPackagePart>(newPart, contentType);
      return newPart;
    }

    public ImagePart AddImagePart(string contentType)
    {
      ImagePart newPart = new ImagePart();
      this.InitPart<ImagePart>(newPart, contentType);
      return newPart;
    }

    public ImagePart AddImagePart(ImagePartType partType)
    {
      string contentType = ImagePartTypeInfo.GetContentType(partType);
      string targetExtension = ImagePartTypeInfo.GetTargetExtension(partType);
      this.OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetExtension);
      return this.AddImagePart(contentType);
    }

    public ImagePart AddImagePart(string contentType, string id)
    {
      ImagePart newPart = new ImagePart();
      this.InitPart<ImagePart>(newPart, contentType, id);
      return newPart;
    }

    public ImagePart AddImagePart(ImagePartType partType, string id)
    {
      string contentType = ImagePartTypeInfo.GetContentType(partType);
      string targetExtension = ImagePartTypeInfo.GetTargetExtension(partType);
      this.OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetExtension);
      return this.AddImagePart(contentType, id);
    }

    public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart)
    {
      return this.AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart);
    }

    public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart, string id)
    {
      return this.AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart, id);
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.openxmlformats.org/officeDocument/2006/relationships/glossaryDocument";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.openxmlformats-officedocument.wordprocessingml.document.glossary+xml";
      }
    }

    internal override sealed string TargetPath
    {
      get
      {
        return "glossary";
      }
    }

    internal override sealed string TargetName
    {
      get
      {
        return "document";
      }
    }

    public WordprocessingCommentsPart WordprocessingCommentsPart
    {
      get
      {
        return this.GetSubPartOfType<WordprocessingCommentsPart>();
      }
    }

    public DocumentSettingsPart DocumentSettingsPart
    {
      get
      {
        return this.GetSubPartOfType<DocumentSettingsPart>();
      }
    }

    public EndnotesPart EndnotesPart
    {
      get
      {
        return this.GetSubPartOfType<EndnotesPart>();
      }
    }

    public FontTablePart FontTablePart
    {
      get
      {
        return this.GetSubPartOfType<FontTablePart>();
      }
    }

    public FootnotesPart FootnotesPart
    {
      get
      {
        return this.GetSubPartOfType<FootnotesPart>();
      }
    }

    public NumberingDefinitionsPart NumberingDefinitionsPart
    {
      get
      {
        return this.GetSubPartOfType<NumberingDefinitionsPart>();
      }
    }

    public StyleDefinitionsPart StyleDefinitionsPart
    {
      get
      {
        return this.GetSubPartOfType<StyleDefinitionsPart>();
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    public StylesWithEffectsPart StylesWithEffectsPart
    {
      get
      {
        return this.GetSubPartOfType<StylesWithEffectsPart>();
      }
    }

    public WebSettingsPart WebSettingsPart
    {
      get
      {
        return this.GetSubPartOfType<WebSettingsPart>();
      }
    }

    public IEnumerable<FooterPart> FooterParts
    {
      get
      {
        return this.GetPartsOfType<FooterPart>();
      }
    }

    public IEnumerable<HeaderPart> HeaderParts
    {
      get
      {
        return this.GetPartsOfType<HeaderPart>();
      }
    }

    public IEnumerable<WordprocessingPrinterSettingsPart> WordprocessingPrinterSettingsParts
    {
      get
      {
        return this.GetPartsOfType<WordprocessingPrinterSettingsPart>();
      }
    }

    public CustomizationPart CustomizationPart
    {
      get
      {
        return this.GetSubPartOfType<CustomizationPart>();
      }
    }

    public VbaProjectPart VbaProjectPart
    {
      get
      {
        return this.GetSubPartOfType<VbaProjectPart>();
      }
    }

    public WordprocessingCommentsExPart WordprocessingCommentsExPart
    {
      get
      {
        return this.GetSubPartOfType<WordprocessingCommentsExPart>();
      }
    }

    public WordprocessingPeoplePart WordprocessingPeoplePart
    {
      get
      {
        return this.GetSubPartOfType<WordprocessingPeoplePart>();
      }
    }

    public IEnumerable<AlternativeFormatImportPart> AlternativeFormatImportParts
    {
      get
      {
        return this.GetPartsOfType<AlternativeFormatImportPart>();
      }
    }

    public IEnumerable<ChartPart> ChartParts
    {
      get
      {
        return this.GetPartsOfType<ChartPart>();
      }
    }

    public IEnumerable<DiagramColorsPart> DiagramColorsParts
    {
      get
      {
        return this.GetPartsOfType<DiagramColorsPart>();
      }
    }

    public IEnumerable<DiagramDataPart> DiagramDataParts
    {
      get
      {
        return this.GetPartsOfType<DiagramDataPart>();
      }
    }

    public IEnumerable<DiagramPersistLayoutPart> DiagramPersistLayoutParts
    {
      get
      {
        return this.GetPartsOfType<DiagramPersistLayoutPart>();
      }
    }

    public IEnumerable<DiagramLayoutDefinitionPart> DiagramLayoutDefinitionParts
    {
      get
      {
        return this.GetPartsOfType<DiagramLayoutDefinitionPart>();
      }
    }

    public IEnumerable<DiagramStylePart> DiagramStyleParts
    {
      get
      {
        return this.GetPartsOfType<DiagramStylePart>();
      }
    }

    public IEnumerable<EmbeddedControlPersistencePart> EmbeddedControlPersistenceParts
    {
      get
      {
        return this.GetPartsOfType<EmbeddedControlPersistencePart>();
      }
    }

    public IEnumerable<EmbeddedObjectPart> EmbeddedObjectParts
    {
      get
      {
        return this.GetPartsOfType<EmbeddedObjectPart>();
      }
    }

    public IEnumerable<EmbeddedPackagePart> EmbeddedPackageParts
    {
      get
      {
        return this.GetPartsOfType<EmbeddedPackagePart>();
      }
    }

    public IEnumerable<ImagePart> ImageParts
    {
      get
      {
        return this.GetPartsOfType<ImagePart>();
      }
    }

    internal override sealed bool IsContentTypeFixed
    {
      get
      {
        return true;
      }
    }

    internal override OpenXmlPartRootElement _rootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this._rootEle;
      }
      set
      {
        this._rootEle = value as GlossaryDocument;
      }
    }

    internal override OpenXmlPartRootElement PartRootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this.GlossaryDocument;
      }
    }

    public GlossaryDocument GlossaryDocument
    {
      get
      {
        if (this._rootEle == null)
          this.LoadDomTree<GlossaryDocument>();
        return this._rootEle;
      }
      set
      {
        if (value == null)
          throw new ArgumentNullException(nameof (value));
        this.SetDomTree((OpenXmlPartRootElement) value);
      }
    }
  }
}

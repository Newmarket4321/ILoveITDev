// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.SlidePart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Presentation;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Packaging
{
  public class SlidePart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slide";
    internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.presentationml.slide+xml";
    internal const string TargetPathConstant = "slides";
    internal const string TargetNameConstant = "slide";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private Slide _rootEle;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (SlidePart._partConstraint == null)
        SlidePart._partConstraint = new Dictionary<string, PartConstraintRule>()
        {
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml",
            new PartConstraintRule("CustomXmlPart", (string) null, false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
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
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/vmlDrawing",
            new PartConstraintRule("VmlDrawingPart", "application/vnd.openxmlformats-officedocument.vmlDrawing", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.microsoft.com/office/2006/relationships/activeXControlBinary",
            new PartConstraintRule("EmbeddedControlPersistenceBinaryDataPart", (string) null, false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments",
            new PartConstraintRule("SlideCommentsPart", "application/vnd.openxmlformats-officedocument.presentationml.comments+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/notesSlide",
            new PartConstraintRule("NotesSlidePart", "application/vnd.openxmlformats-officedocument.presentationml.notesSlide+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/themeOverride",
            new PartConstraintRule("ThemeOverridePart", "application/vnd.openxmlformats-officedocument.themeOverride+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideLayout",
            new PartConstraintRule("SlideLayoutPart", "application/vnd.openxmlformats-officedocument.presentationml.slideLayout+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideUpdateInfo",
            new PartConstraintRule("SlideSyncDataPart", "application/vnd.openxmlformats-officedocument.presentationml.slideUpdateInfo+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tags",
            new PartConstraintRule("UserDefinedTagsPart", "application/vnd.openxmlformats-officedocument.presentationml.tags+xml", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slide",
            new PartConstraintRule(nameof (SlidePart), "application/vnd.openxmlformats-officedocument.presentationml.slide+xml", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/control",
            new PartConstraintRule("EmbeddedControlPersistencePart", (string) null, false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          }
        };
      return (IDictionary<string, PartConstraintRule>) SlidePart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (SlidePart._dataPartReferenceConstraint == null)
        SlidePart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>()
        {
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/audio",
            new PartConstraintRule("AudioReferenceRelationship", (string) null, false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/video",
            new PartConstraintRule("VideoReferenceRelationship", (string) null, false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.microsoft.com/office/2007/relationships/media",
            new PartConstraintRule("MediaReferenceRelationship", (string) null, false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          }
        };
      return (IDictionary<string, PartConstraintRule>) SlidePart._dataPartReferenceConstraint;
    }

    protected internal SlidePart()
    {
    }

    internal override sealed OpenXmlPart CreatePartCore(string relationshipType)
    {
      this.ThrowIfObjectDisposed();
      if (relationshipType == null)
        throw new ArgumentNullException(nameof (relationshipType));
      switch (relationshipType)
      {
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml":
          return (OpenXmlPart) new CustomXmlPart();
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
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject":
          return (OpenXmlPart) new EmbeddedObjectPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/package":
          return (OpenXmlPart) new EmbeddedPackagePart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image":
          return (OpenXmlPart) new ImagePart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/vmlDrawing":
          return (OpenXmlPart) new VmlDrawingPart();
        case "http://schemas.microsoft.com/office/2006/relationships/activeXControlBinary":
          return (OpenXmlPart) new EmbeddedControlPersistenceBinaryDataPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments":
          return (OpenXmlPart) new SlideCommentsPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/notesSlide":
          return (OpenXmlPart) new NotesSlidePart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/themeOverride":
          return (OpenXmlPart) new ThemeOverridePart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideLayout":
          return (OpenXmlPart) new SlideLayoutPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideUpdateInfo":
          return (OpenXmlPart) new SlideSyncDataPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tags":
          return (OpenXmlPart) new UserDefinedTagsPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slide":
          return (OpenXmlPart) new SlidePart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/control":
          return (OpenXmlPart) new EmbeddedControlPersistencePart();
        default:
          throw new ArgumentOutOfRangeException(nameof (relationshipType));
      }
    }

    public CustomXmlPart AddCustomXmlPart(string contentType)
    {
      CustomXmlPart newPart = new CustomXmlPart();
      this.InitPart<CustomXmlPart>(newPart, contentType);
      return newPart;
    }

    public CustomXmlPart AddCustomXmlPart(CustomXmlPartType partType)
    {
      string contentType = CustomXmlPartTypeInfo.GetContentType(partType);
      string targetExtension = CustomXmlPartTypeInfo.GetTargetExtension(partType);
      this.OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetExtension);
      return this.AddCustomXmlPart(contentType);
    }

    public CustomXmlPart AddCustomXmlPart(string contentType, string id)
    {
      CustomXmlPart newPart = new CustomXmlPart();
      this.InitPart<CustomXmlPart>(newPart, contentType, id);
      return newPart;
    }

    public CustomXmlPart AddCustomXmlPart(CustomXmlPartType partType, string id)
    {
      string contentType = CustomXmlPartTypeInfo.GetContentType(partType);
      string targetExtension = CustomXmlPartTypeInfo.GetTargetExtension(partType);
      this.OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetExtension);
      return this.AddCustomXmlPart(contentType, id);
    }

    public AudioReferenceRelationship AddAudioReferenceRelationship(MediaDataPart mediaDataPart)
    {
      return this.AddDataPartReferenceRelationship<AudioReferenceRelationship>(mediaDataPart);
    }

    public AudioReferenceRelationship AddAudioReferenceRelationship(MediaDataPart mediaDataPart, string id)
    {
      return this.AddDataPartReferenceRelationship<AudioReferenceRelationship>(mediaDataPart, id);
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

    public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(string contentType)
    {
      EmbeddedControlPersistenceBinaryDataPart newPart = new EmbeddedControlPersistenceBinaryDataPart();
      this.InitPart<EmbeddedControlPersistenceBinaryDataPart>(newPart, contentType);
      return newPart;
    }

    public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(EmbeddedControlPersistenceBinaryDataPartType partType)
    {
      string contentType = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetContentType(partType);
      string targetExtension = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetTargetExtension(partType);
      this.OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetExtension);
      return this.AddEmbeddedControlPersistenceBinaryDataPart(contentType);
    }

    public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(string contentType, string id)
    {
      EmbeddedControlPersistenceBinaryDataPart newPart = new EmbeddedControlPersistenceBinaryDataPart();
      this.InitPart<EmbeddedControlPersistenceBinaryDataPart>(newPart, contentType, id);
      return newPart;
    }

    public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(EmbeddedControlPersistenceBinaryDataPartType partType, string id)
    {
      string contentType = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetContentType(partType);
      string targetExtension = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetTargetExtension(partType);
      this.OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetExtension);
      return this.AddEmbeddedControlPersistenceBinaryDataPart(contentType, id);
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

    public MediaReferenceRelationship AddMediaReferenceRelationship(MediaDataPart mediaDataPart)
    {
      return this.AddDataPartReferenceRelationship<MediaReferenceRelationship>(mediaDataPart);
    }

    public MediaReferenceRelationship AddMediaReferenceRelationship(MediaDataPart mediaDataPart, string id)
    {
      return this.AddDataPartReferenceRelationship<MediaReferenceRelationship>(mediaDataPart, id);
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slide";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.openxmlformats-officedocument.presentationml.slide+xml";
      }
    }

    internal override sealed string TargetPath
    {
      get
      {
        return "slides";
      }
    }

    internal override sealed string TargetName
    {
      get
      {
        return "slide";
      }
    }

    public IEnumerable<CustomXmlPart> CustomXmlParts
    {
      get
      {
        return this.GetPartsOfType<CustomXmlPart>();
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

    public IEnumerable<VmlDrawingPart> VmlDrawingParts
    {
      get
      {
        return this.GetPartsOfType<VmlDrawingPart>();
      }
    }

    public IEnumerable<EmbeddedControlPersistenceBinaryDataPart> EmbeddedControlPersistenceBinaryDataParts
    {
      get
      {
        return this.GetPartsOfType<EmbeddedControlPersistenceBinaryDataPart>();
      }
    }

    public SlideCommentsPart SlideCommentsPart
    {
      get
      {
        return this.GetSubPartOfType<SlideCommentsPart>();
      }
    }

    public NotesSlidePart NotesSlidePart
    {
      get
      {
        return this.GetSubPartOfType<NotesSlidePart>();
      }
    }

    public ThemeOverridePart ThemeOverridePart
    {
      get
      {
        return this.GetSubPartOfType<ThemeOverridePart>();
      }
    }

    public SlideLayoutPart SlideLayoutPart
    {
      get
      {
        return this.GetSubPartOfType<SlideLayoutPart>();
      }
    }

    public SlideSyncDataPart SlideSyncDataPart
    {
      get
      {
        return this.GetSubPartOfType<SlideSyncDataPart>();
      }
    }

    public IEnumerable<UserDefinedTagsPart> UserDefinedTagsParts
    {
      get
      {
        return this.GetPartsOfType<UserDefinedTagsPart>();
      }
    }

    public IEnumerable<SlidePart> SlideParts
    {
      get
      {
        return this.GetPartsOfType<SlidePart>();
      }
    }

    public IEnumerable<EmbeddedControlPersistencePart> EmbeddedControlPersistenceParts
    {
      get
      {
        return this.GetPartsOfType<EmbeddedControlPersistencePart>();
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
        this._rootEle = value as Slide;
      }
    }

    internal override OpenXmlPartRootElement PartRootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this.Slide;
      }
    }

    public Slide Slide
    {
      get
      {
        if (this._rootEle == null)
          this.LoadDomTree<Slide>();
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

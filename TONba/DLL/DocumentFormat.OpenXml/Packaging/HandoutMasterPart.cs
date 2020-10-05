// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.HandoutMasterPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Presentation;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Packaging
{
  public class HandoutMasterPart : OpenXmlPart, IFixedContentTypePart
  {
    internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/handoutMaster";
    internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.presentationml.handoutMaster+xml";
    internal const string TargetPathConstant = "handoutMasters";
    internal const string TargetNameConstant = "handoutMaster";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private HandoutMaster _rootEle;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (HandoutMasterPart._partConstraint == null)
        HandoutMasterPart._partConstraint = new Dictionary<string, PartConstraintRule>()
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
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme",
            new PartConstraintRule("ThemePart", "application/vnd.openxmlformats-officedocument.theme+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tags",
            new PartConstraintRule("UserDefinedTagsPart", "application/vnd.openxmlformats-officedocument.presentationml.tags+xml", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slide",
            new PartConstraintRule("SlidePart", "application/vnd.openxmlformats-officedocument.presentationml.slide+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          }
        };
      return (IDictionary<string, PartConstraintRule>) HandoutMasterPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (HandoutMasterPart._dataPartReferenceConstraint == null)
        HandoutMasterPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>()
        {
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/audio",
            new PartConstraintRule("AudioReferenceRelationship", (string) null, false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/video",
            new PartConstraintRule("VideoReferenceRelationship", (string) null, false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          }
        };
      return (IDictionary<string, PartConstraintRule>) HandoutMasterPart._dataPartReferenceConstraint;
    }

    protected internal HandoutMasterPart()
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
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme":
          return (OpenXmlPart) new ThemePart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tags":
          return (OpenXmlPart) new UserDefinedTagsPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slide":
          return (OpenXmlPart) new SlidePart();
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

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.openxmlformats.org/officeDocument/2006/relationships/handoutMaster";
      }
    }

    public override sealed string ContentType
    {
      get
      {
        return "application/vnd.openxmlformats-officedocument.presentationml.handoutMaster+xml";
      }
    }

    internal override sealed string TargetPath
    {
      get
      {
        return "handoutMasters";
      }
    }

    internal override sealed string TargetName
    {
      get
      {
        return "handoutMaster";
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

    public ThemePart ThemePart
    {
      get
      {
        return this.GetSubPartOfType<ThemePart>();
      }
    }

    public IEnumerable<UserDefinedTagsPart> UserDefinedTagsParts
    {
      get
      {
        return this.GetPartsOfType<UserDefinedTagsPart>();
      }
    }

    public SlidePart SlidePart
    {
      get
      {
        return this.GetSubPartOfType<SlidePart>();
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
        this._rootEle = value as HandoutMaster;
      }
    }

    internal override OpenXmlPartRootElement PartRootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this.HandoutMaster;
      }
    }

    public HandoutMaster HandoutMaster
    {
      get
      {
        if (this._rootEle == null)
          this.LoadDomTree<HandoutMaster>();
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

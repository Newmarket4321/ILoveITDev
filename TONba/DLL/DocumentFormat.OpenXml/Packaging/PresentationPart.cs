// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.PresentationPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Packaging
{
  public class PresentationPart : OpenXmlPart
  {
    internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument";
    internal const string TargetPathConstant = "ppt";
    internal const string TargetNameConstant = "presentation";
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private DocumentFormat.OpenXml.Presentation.Presentation _rootEle;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (PresentationPart._partConstraint == null)
        PresentationPart._partConstraint = new Dictionary<string, PartConstraintRule>()
        {
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml",
            new PartConstraintRule("CustomXmlPart", (string) null, false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/font",
            new PartConstraintRule("FontPart", (string) null, false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/presProps",
            new PartConstraintRule("PresentationPropertiesPart", "application/vnd.openxmlformats-officedocument.presentationml.presProps+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tableStyles",
            new PartConstraintRule("TableStylesPart", "application/vnd.openxmlformats-officedocument.presentationml.tableStyles+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme",
            new PartConstraintRule("ThemePart", "application/vnd.openxmlformats-officedocument.theme+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/viewProps",
            new PartConstraintRule("ViewPropertiesPart", "application/vnd.openxmlformats-officedocument.presentationml.viewProps+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/notesMaster",
            new PartConstraintRule("NotesMasterPart", "application/vnd.openxmlformats-officedocument.presentationml.notesMaster+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slide",
            new PartConstraintRule("SlidePart", "application/vnd.openxmlformats-officedocument.presentationml.slide+xml", false, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideMaster",
            new PartConstraintRule("SlideMasterPart", "application/vnd.openxmlformats-officedocument.presentationml.slideMaster+xml", true, true, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tags",
            new PartConstraintRule("UserDefinedTagsPart", "application/vnd.openxmlformats-officedocument.presentationml.tags+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/commentAuthors",
            new PartConstraintRule("CommentAuthorsPart", "application/vnd.openxmlformats-officedocument.presentationml.commentAuthors+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/handoutMaster",
            new PartConstraintRule("HandoutMasterPart", "application/vnd.openxmlformats-officedocument.presentationml.handoutMaster+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.microsoft.com/office/2006/relationships/legacyDocTextInfo",
            new PartConstraintRule("LegacyDiagramTextInfoPart", "application/vnd.ms-office.legacyDocTextInfo", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.microsoft.com/office/2006/relationships/vbaProject",
            new PartConstraintRule("VbaProjectPart", "application/vnd.ms-office.vbaProject", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          }
        };
      return (IDictionary<string, PartConstraintRule>) PresentationPart._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (PresentationPart._dataPartReferenceConstraint == null)
        PresentationPart._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) PresentationPart._dataPartReferenceConstraint;
    }

    protected internal PresentationPart()
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
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/font":
          return (OpenXmlPart) new FontPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/presProps":
          return (OpenXmlPart) new PresentationPropertiesPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tableStyles":
          return (OpenXmlPart) new TableStylesPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme":
          return (OpenXmlPart) new ThemePart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/viewProps":
          return (OpenXmlPart) new ViewPropertiesPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/notesMaster":
          return (OpenXmlPart) new NotesMasterPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slide":
          return (OpenXmlPart) new SlidePart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideMaster":
          return (OpenXmlPart) new SlideMasterPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tags":
          return (OpenXmlPart) new UserDefinedTagsPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/commentAuthors":
          return (OpenXmlPart) new CommentAuthorsPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/handoutMaster":
          return (OpenXmlPart) new HandoutMasterPart();
        case "http://schemas.microsoft.com/office/2006/relationships/legacyDocTextInfo":
          return (OpenXmlPart) new LegacyDiagramTextInfoPart();
        case "http://schemas.microsoft.com/office/2006/relationships/vbaProject":
          return (OpenXmlPart) new VbaProjectPart();
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

    public FontPart AddFontPart(string contentType)
    {
      FontPart newPart = new FontPart();
      this.InitPart<FontPart>(newPart, contentType);
      return newPart;
    }

    public FontPart AddFontPart(FontPartType partType)
    {
      string contentType = FontPartTypeInfo.GetContentType(partType);
      string targetExtension = FontPartTypeInfo.GetTargetExtension(partType);
      this.OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetExtension);
      return this.AddFontPart(contentType);
    }

    public FontPart AddFontPart(string contentType, string id)
    {
      FontPart newPart = new FontPart();
      this.InitPart<FontPart>(newPart, contentType, id);
      return newPart;
    }

    public FontPart AddFontPart(FontPartType partType, string id)
    {
      string contentType = FontPartTypeInfo.GetContentType(partType);
      string targetExtension = FontPartTypeInfo.GetTargetExtension(partType);
      this.OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetExtension);
      return this.AddFontPart(contentType, id);
    }

    public override sealed string RelationshipType
    {
      get
      {
        return "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument";
      }
    }

    internal override sealed string TargetPath
    {
      get
      {
        return "ppt";
      }
    }

    internal override sealed string TargetName
    {
      get
      {
        return "presentation";
      }
    }

    public IEnumerable<CustomXmlPart> CustomXmlParts
    {
      get
      {
        return this.GetPartsOfType<CustomXmlPart>();
      }
    }

    public IEnumerable<FontPart> FontParts
    {
      get
      {
        return this.GetPartsOfType<FontPart>();
      }
    }

    public PresentationPropertiesPart PresentationPropertiesPart
    {
      get
      {
        return this.GetSubPartOfType<PresentationPropertiesPart>();
      }
    }

    public TableStylesPart TableStylesPart
    {
      get
      {
        return this.GetSubPartOfType<TableStylesPart>();
      }
    }

    public ThemePart ThemePart
    {
      get
      {
        return this.GetSubPartOfType<ThemePart>();
      }
    }

    public ViewPropertiesPart ViewPropertiesPart
    {
      get
      {
        return this.GetSubPartOfType<ViewPropertiesPart>();
      }
    }

    public NotesMasterPart NotesMasterPart
    {
      get
      {
        return this.GetSubPartOfType<NotesMasterPart>();
      }
    }

    public IEnumerable<SlidePart> SlideParts
    {
      get
      {
        return this.GetPartsOfType<SlidePart>();
      }
    }

    public IEnumerable<SlideMasterPart> SlideMasterParts
    {
      get
      {
        return this.GetPartsOfType<SlideMasterPart>();
      }
    }

    public UserDefinedTagsPart UserDefinedTagsPart
    {
      get
      {
        return this.GetSubPartOfType<UserDefinedTagsPart>();
      }
    }

    public CommentAuthorsPart CommentAuthorsPart
    {
      get
      {
        return this.GetSubPartOfType<CommentAuthorsPart>();
      }
    }

    public HandoutMasterPart HandoutMasterPart
    {
      get
      {
        return this.GetSubPartOfType<HandoutMasterPart>();
      }
    }

    public LegacyDiagramTextInfoPart LegacyDiagramTextInfoPart
    {
      get
      {
        return this.GetSubPartOfType<LegacyDiagramTextInfoPart>();
      }
    }

    public VbaProjectPart VbaProjectPart
    {
      get
      {
        return this.GetSubPartOfType<VbaProjectPart>();
      }
    }

    internal override sealed bool IsContentTypeFixed
    {
      get
      {
        return false;
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
        this._rootEle = value as DocumentFormat.OpenXml.Presentation.Presentation;
      }
    }

    internal override OpenXmlPartRootElement PartRootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this.Presentation;
      }
    }

    public DocumentFormat.OpenXml.Presentation.Presentation Presentation
    {
      get
      {
        if (this._rootEle == null)
          this.LoadDomTree<DocumentFormat.OpenXml.Presentation.Presentation>();
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

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.PresentationDocument
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging
{
  public class PresentationDocument : OpenXmlPackage
  {
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    private static Dictionary<PresentationDocumentType, string> _validMainPartContentType;
    private PresentationDocumentType _documentType;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (PresentationDocument._partConstraint == null)
        PresentationDocument._partConstraint = new Dictionary<string, PartConstraintRule>()
        {
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument",
            new PartConstraintRule("PresentationPart", (string) null, true, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/package/2006/relationships/metadata/core-properties",
            new PartConstraintRule("CoreFilePropertiesPart", "application/vnd.openxmlformats-package.core-properties+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/extended-properties",
            new PartConstraintRule("ExtendedFilePropertiesPart", "application/vnd.openxmlformats-officedocument.extended-properties+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/custom-properties",
            new PartConstraintRule("CustomFilePropertiesPart", "application/vnd.openxmlformats-officedocument.custom-properties+xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/package/2006/relationships/metadata/thumbnail",
            new PartConstraintRule("ThumbnailPart", (string) null, false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.openxmlformats.org/package/2006/relationships/digital-signature/origin",
            new PartConstraintRule("DigitalSignatureOriginPart", "application/vnd.openxmlformats-package.digital-signature-origin", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.microsoft.com/office/2006/relationships/ui/userCustomization",
            new PartConstraintRule("QuickAccessToolbarCustomizationsPart", "application/xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.microsoft.com/office/2006/relationships/ui/extensibility",
            new PartConstraintRule("RibbonExtensibilityPart", "application/xml", false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.microsoft.com/office/2007/relationships/ui/extensibility",
            new PartConstraintRule("RibbonAndBackstageCustomizationsPart", "application/xml", false, false, FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
          },
          {
            "http://schemas.microsoft.com/office/2011/relationships/webextensiontaskpanes",
            new PartConstraintRule("WebExTaskpanesPart", "application/vnd.ms-office.webextensiontaskpanes+xml", false, false, FileFormatVersions.Office2013)
          }
        };
      return (IDictionary<string, PartConstraintRule>) PresentationDocument._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (PresentationDocument._dataPartReferenceConstraint == null)
        PresentationDocument._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) PresentationDocument._dataPartReferenceConstraint;
    }

    internal override sealed string MainPartRelationshipType
    {
      get
      {
        return "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument";
      }
    }

    private static Dictionary<PresentationDocumentType, string> MainPartContentTypes
    {
      get
      {
        if (PresentationDocument._validMainPartContentType == null)
          PresentationDocument._validMainPartContentType = new Dictionary<PresentationDocumentType, string>()
          {
            {
              PresentationDocumentType.Presentation,
              "application/vnd.openxmlformats-officedocument.presentationml.presentation.main+xml"
            },
            {
              PresentationDocumentType.Template,
              "application/vnd.openxmlformats-officedocument.presentationml.template.main+xml"
            },
            {
              PresentationDocumentType.Slideshow,
              "application/vnd.openxmlformats-officedocument.presentationml.slideshow.main+xml"
            },
            {
              PresentationDocumentType.MacroEnabledPresentation,
              "application/vnd.ms-powerpoint.presentation.macroEnabled.main+xml"
            },
            {
              PresentationDocumentType.MacroEnabledTemplate,
              "application/vnd.ms-powerpoint.template.macroEnabled.main+xml"
            },
            {
              PresentationDocumentType.MacroEnabledSlideshow,
              "application/vnd.ms-powerpoint.slideshow.macroEnabled.main+xml"
            },
            {
              PresentationDocumentType.AddIn,
              "application/vnd.ms-powerpoint.addin.macroEnabled.main+xml"
            }
          };
        return PresentationDocument._validMainPartContentType;
      }
    }

    internal override sealed ICollection<string> ValidMainPartContentTypes
    {
      get
      {
        return (ICollection<string>) PresentationDocument.MainPartContentTypes.Values;
      }
    }

    protected PresentationDocument()
    {
    }

    public PresentationDocumentType DocumentType
    {
      get
      {
        this.ThrowIfObjectDisposed();
        return this._documentType;
      }
      private set
      {
        this.ThrowIfObjectDisposed();
        this._documentType = value;
      }
    }

    private void UpdateDocumentTypeFromContentType()
    {
      if (this.MainPartContentType == null)
        throw new InvalidOperationException();
      foreach (KeyValuePair<PresentationDocumentType, string> mainPartContentType in PresentationDocument.MainPartContentTypes)
      {
        if (mainPartContentType.Value == this.MainPartContentType)
          this.DocumentType = mainPartContentType.Key;
      }
    }

    public static PresentationDocument Create(string path, PresentationDocumentType type)
    {
      return PresentationDocument.Create(path, type, true);
    }

    public static PresentationDocument Create(Stream stream, PresentationDocumentType type)
    {
      return PresentationDocument.Create(stream, type, true);
    }

    public static PresentationDocument Create(Package package, PresentationDocumentType type)
    {
      return PresentationDocument.Create(package, type, true);
    }

    public static PresentationDocument Create(string path, PresentationDocumentType type, bool autoSave)
    {
      if (string.IsNullOrEmpty(path))
        throw new ArgumentNullException(path);
      PresentationDocument presentationDocument = new PresentationDocument();
      presentationDocument.DocumentType = type;
      presentationDocument.OpenSettings = new OpenSettings();
      presentationDocument.OpenSettings.AutoSave = autoSave;
      presentationDocument.MainPartContentType = PresentationDocument.MainPartContentTypes[type];
      presentationDocument.CreateCore(path);
      return presentationDocument;
    }

    public static PresentationDocument Create(Stream stream, PresentationDocumentType type, bool autoSave)
    {
      PresentationDocument presentationDocument = new PresentationDocument();
      presentationDocument.DocumentType = type;
      presentationDocument.OpenSettings = new OpenSettings();
      presentationDocument.OpenSettings.AutoSave = autoSave;
      presentationDocument.MainPartContentType = PresentationDocument.MainPartContentTypes[type];
      presentationDocument.CreateCore(stream);
      return presentationDocument;
    }

    public static PresentationDocument Create(Package package, PresentationDocumentType type, bool autoSave)
    {
      PresentationDocument presentationDocument = new PresentationDocument();
      presentationDocument.DocumentType = type;
      presentationDocument.OpenSettings = new OpenSettings();
      presentationDocument.OpenSettings.AutoSave = autoSave;
      presentationDocument.MainPartContentType = PresentationDocument.MainPartContentTypes[type];
      presentationDocument.CreateCore(package);
      return presentationDocument;
    }

    public static PresentationDocument Open(string path, bool isEditable)
    {
      return PresentationDocument.Open(path, isEditable, new OpenSettings());
    }

    public static PresentationDocument Open(Stream stream, bool isEditable)
    {
      return PresentationDocument.Open(stream, isEditable, new OpenSettings());
    }

    public static PresentationDocument Open(Package package)
    {
      return PresentationDocument.Open(package, new OpenSettings());
    }

    public static PresentationDocument Open(string path, bool isEditable, OpenSettings openSettings)
    {
      if (openSettings.MarkupCompatibilityProcessSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess && openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2007 && (openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2010 && openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2013))
        throw new ArgumentException(ExceptionMessages.InvalidMCMode);
      PresentationDocument presentationDocument = new PresentationDocument();
      presentationDocument.OpenSettings = new OpenSettings();
      presentationDocument.OpenSettings.AutoSave = openSettings.AutoSave;
      presentationDocument.OpenSettings.MarkupCompatibilityProcessSettings.ProcessMode = openSettings.MarkupCompatibilityProcessSettings.ProcessMode;
      presentationDocument.OpenSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions = openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions;
      presentationDocument.MaxCharactersInPart = openSettings.MaxCharactersInPart;
      presentationDocument.OpenCore(path, isEditable);
      if (PresentationDocument.MainPartContentTypes[presentationDocument.DocumentType] != presentationDocument.MainPartContentType)
        presentationDocument.UpdateDocumentTypeFromContentType();
      return presentationDocument;
    }

    public static PresentationDocument Open(Stream stream, bool isEditable, OpenSettings openSettings)
    {
      if (openSettings.MarkupCompatibilityProcessSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess && openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2007 && (openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2010 && openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2013))
        throw new ArgumentException(ExceptionMessages.InvalidMCMode);
      PresentationDocument presentationDocument = new PresentationDocument();
      presentationDocument.OpenSettings = new OpenSettings();
      presentationDocument.OpenSettings.AutoSave = openSettings.AutoSave;
      presentationDocument.OpenSettings.MarkupCompatibilityProcessSettings.ProcessMode = openSettings.MarkupCompatibilityProcessSettings.ProcessMode;
      presentationDocument.OpenSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions = openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions;
      presentationDocument.MaxCharactersInPart = openSettings.MaxCharactersInPart;
      presentationDocument.OpenCore(stream, isEditable);
      if (PresentationDocument.MainPartContentTypes[presentationDocument.DocumentType] != presentationDocument.MainPartContentType)
        presentationDocument.UpdateDocumentTypeFromContentType();
      return presentationDocument;
    }

    public static PresentationDocument Open(Package package, OpenSettings openSettings)
    {
      if (openSettings.MarkupCompatibilityProcessSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess && openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2007 && (openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2010 && openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2013))
        throw new ArgumentException(ExceptionMessages.InvalidMCMode);
      PresentationDocument presentationDocument = new PresentationDocument();
      presentationDocument.OpenSettings = new OpenSettings();
      presentationDocument.OpenSettings.AutoSave = openSettings.AutoSave;
      presentationDocument.OpenSettings.MarkupCompatibilityProcessSettings.ProcessMode = openSettings.MarkupCompatibilityProcessSettings.ProcessMode;
      presentationDocument.OpenSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions = openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions;
      presentationDocument.MaxCharactersInPart = openSettings.MaxCharactersInPart;
      presentationDocument.OpenCore(package);
      if (PresentationDocument.MainPartContentTypes[presentationDocument.DocumentType] != presentationDocument.MainPartContentType)
        presentationDocument.UpdateDocumentTypeFromContentType();
      return presentationDocument;
    }

    public void ChangeDocumentType(PresentationDocumentType newType)
    {
      this.ThrowIfObjectDisposed();
      if (newType == this.DocumentType)
        return;
      if (this.FileOpenAccess == FileAccess.Read)
        throw new IOException(ExceptionMessages.PackageAccessModeIsReadonly);
      PresentationDocumentType documentType = this.DocumentType;
      this.DocumentType = newType;
      this.MainPartContentType = PresentationDocument.MainPartContentTypes[newType];
      if (this.PresentationPart == null)
        return;
      try
      {
        this.ChangeDocumentTypeInternal<PresentationPart>();
      }
      catch (OpenXmlPackageException ex)
      {
        if (ex.Message == ExceptionMessages.CannotChangeDocumentType)
        {
          this.DocumentType = documentType;
          this.MainPartContentType = PresentationDocument.MainPartContentTypes[documentType];
        }
        throw;
      }
    }

    internal override sealed OpenXmlPart CreatePartCore(string relationshipType)
    {
      this.ThrowIfObjectDisposed();
      if (relationshipType == null)
        throw new ArgumentNullException(nameof (relationshipType));
      switch (relationshipType)
      {
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument":
          return (OpenXmlPart) new PresentationPart();
        case "http://schemas.openxmlformats.org/package/2006/relationships/metadata/core-properties":
          return (OpenXmlPart) new CoreFilePropertiesPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/extended-properties":
          return (OpenXmlPart) new ExtendedFilePropertiesPart();
        case "http://schemas.openxmlformats.org/officeDocument/2006/relationships/custom-properties":
          return (OpenXmlPart) new CustomFilePropertiesPart();
        case "http://schemas.openxmlformats.org/package/2006/relationships/metadata/thumbnail":
          return (OpenXmlPart) new ThumbnailPart();
        case "http://schemas.openxmlformats.org/package/2006/relationships/digital-signature/origin":
          return (OpenXmlPart) new DigitalSignatureOriginPart();
        case "http://schemas.microsoft.com/office/2006/relationships/ui/userCustomization":
          return (OpenXmlPart) new QuickAccessToolbarCustomizationsPart();
        case "http://schemas.microsoft.com/office/2006/relationships/ui/extensibility":
          return (OpenXmlPart) new RibbonExtensibilityPart();
        case "http://schemas.microsoft.com/office/2007/relationships/ui/extensibility":
          return (OpenXmlPart) new RibbonAndBackstageCustomizationsPart();
        case "http://schemas.microsoft.com/office/2011/relationships/webextensiontaskpanes":
          return (OpenXmlPart) new WebExTaskpanesPart();
        default:
          throw new ArgumentOutOfRangeException(nameof (relationshipType));
      }
    }

    public PresentationPart AddPresentationPart()
    {
      PresentationPart newPart = new PresentationPart();
      this.InitPart<PresentationPart>(newPart, this.MainPartContentType);
      return newPart;
    }

    public CoreFilePropertiesPart AddCoreFilePropertiesPart()
    {
      CoreFilePropertiesPart newPart = new CoreFilePropertiesPart();
      this.InitPart<CoreFilePropertiesPart>(newPart, "application/vnd.openxmlformats-package.core-properties+xml");
      return newPart;
    }

    public ExtendedFilePropertiesPart AddExtendedFilePropertiesPart()
    {
      ExtendedFilePropertiesPart newPart = new ExtendedFilePropertiesPart();
      this.InitPart<ExtendedFilePropertiesPart>(newPart, "application/vnd.openxmlformats-officedocument.extended-properties+xml");
      return newPart;
    }

    public CustomFilePropertiesPart AddCustomFilePropertiesPart()
    {
      CustomFilePropertiesPart newPart = new CustomFilePropertiesPart();
      this.InitPart<CustomFilePropertiesPart>(newPart, "application/vnd.openxmlformats-officedocument.custom-properties+xml");
      return newPart;
    }

    public DigitalSignatureOriginPart AddDigitalSignatureOriginPart()
    {
      DigitalSignatureOriginPart newPart = new DigitalSignatureOriginPart();
      this.InitPart<DigitalSignatureOriginPart>(newPart, "application/vnd.openxmlformats-package.digital-signature-origin");
      return newPart;
    }

    public ThumbnailPart AddThumbnailPart(string contentType)
    {
      ThumbnailPart newPart = new ThumbnailPart();
      this.InitPart<ThumbnailPart>(newPart, contentType);
      return newPart;
    }

    public ThumbnailPart AddThumbnailPart(ThumbnailPartType partType)
    {
      string contentType = ThumbnailPartTypeInfo.GetContentType(partType);
      string targetExtension = ThumbnailPartTypeInfo.GetTargetExtension(partType);
      this.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetExtension);
      return this.AddThumbnailPart(contentType);
    }

    public override T AddNewPart<T>(string contentType, string id)
    {
      if (contentType == null)
        throw new ArgumentNullException(nameof (contentType));
      if (typeof (PresentationPart).IsAssignableFrom(typeof (T)) && contentType != PresentationDocument.MainPartContentTypes[this._documentType])
        throw new OpenXmlPackageException(ExceptionMessages.ErrorContentType);
      return base.AddNewPart<T>(contentType, id);
    }

    public QuickAccessToolbarCustomizationsPart AddQuickAccessToolbarCustomizationsPart()
    {
      QuickAccessToolbarCustomizationsPart newPart = new QuickAccessToolbarCustomizationsPart();
      this.InitPart<QuickAccessToolbarCustomizationsPart>(newPart, "application/xml");
      return newPart;
    }

    public RibbonExtensibilityPart AddRibbonExtensibilityPart()
    {
      RibbonExtensibilityPart newPart = new RibbonExtensibilityPart();
      this.InitPart<RibbonExtensibilityPart>(newPart, "application/xml");
      return newPart;
    }

    public RibbonAndBackstageCustomizationsPart AddRibbonAndBackstageCustomizationsPart()
    {
      RibbonAndBackstageCustomizationsPart newPart = new RibbonAndBackstageCustomizationsPart();
      this.InitPart<RibbonAndBackstageCustomizationsPart>(newPart, "application/xml");
      return newPart;
    }

    public WebExTaskpanesPart AddWebExTaskpanesPart()
    {
      WebExTaskpanesPart newPart = new WebExTaskpanesPart();
      this.InitPart<WebExTaskpanesPart>(newPart, "application/vnd.ms-office.webextensiontaskpanes+xml");
      return newPart;
    }

    public PresentationPart PresentationPart
    {
      get
      {
        return this.GetSubPartOfType<PresentationPart>();
      }
    }

    public CoreFilePropertiesPart CoreFilePropertiesPart
    {
      get
      {
        return this.GetSubPartOfType<CoreFilePropertiesPart>();
      }
    }

    public ExtendedFilePropertiesPart ExtendedFilePropertiesPart
    {
      get
      {
        return this.GetSubPartOfType<ExtendedFilePropertiesPart>();
      }
    }

    public CustomFilePropertiesPart CustomFilePropertiesPart
    {
      get
      {
        return this.GetSubPartOfType<CustomFilePropertiesPart>();
      }
    }

    public ThumbnailPart ThumbnailPart
    {
      get
      {
        return this.GetSubPartOfType<ThumbnailPart>();
      }
    }

    public DigitalSignatureOriginPart DigitalSignatureOriginPart
    {
      get
      {
        return this.GetSubPartOfType<DigitalSignatureOriginPart>();
      }
    }

    public RibbonExtensibilityPart RibbonExtensibilityPart
    {
      get
      {
        return this.GetSubPartOfType<RibbonExtensibilityPart>();
      }
    }

    public QuickAccessToolbarCustomizationsPart QuickAccessToolbarCustomizationsPart
    {
      get
      {
        return this.GetSubPartOfType<QuickAccessToolbarCustomizationsPart>();
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    public RibbonAndBackstageCustomizationsPart RibbonAndBackstageCustomizationsPart
    {
      get
      {
        return this.GetSubPartOfType<RibbonAndBackstageCustomizationsPart>();
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2013)]
    public WebExTaskpanesPart WebExTaskpanesPart
    {
      get
      {
        return this.GetSubPartOfType<WebExTaskpanesPart>();
      }
    }
  }
}

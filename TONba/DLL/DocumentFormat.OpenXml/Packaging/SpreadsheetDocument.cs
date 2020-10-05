﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.SpreadsheetDocument
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging
{
  public class SpreadsheetDocument : OpenXmlPackage
  {
    private static Dictionary<string, PartConstraintRule> _partConstraint;
    private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
    private static Dictionary<SpreadsheetDocumentType, string> _validMainPartContentType;
    private SpreadsheetDocumentType _documentType;

    internal override sealed IDictionary<string, PartConstraintRule> GetPartConstraint()
    {
      if (SpreadsheetDocument._partConstraint == null)
        SpreadsheetDocument._partConstraint = new Dictionary<string, PartConstraintRule>()
        {
          {
            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument",
            new PartConstraintRule("WorkbookPart", (string) null, true, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013)
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
      return (IDictionary<string, PartConstraintRule>) SpreadsheetDocument._partConstraint;
    }

    internal override sealed IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
    {
      if (SpreadsheetDocument._dataPartReferenceConstraint == null)
        SpreadsheetDocument._dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>();
      return (IDictionary<string, PartConstraintRule>) SpreadsheetDocument._dataPartReferenceConstraint;
    }

    internal override sealed string MainPartRelationshipType
    {
      get
      {
        return "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument";
      }
    }

    private static Dictionary<SpreadsheetDocumentType, string> MainPartContentTypes
    {
      get
      {
        if (SpreadsheetDocument._validMainPartContentType == null)
          SpreadsheetDocument._validMainPartContentType = new Dictionary<SpreadsheetDocumentType, string>()
          {
            {
              SpreadsheetDocumentType.Workbook,
              "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet.main+xml"
            },
            {
              SpreadsheetDocumentType.Template,
              "application/vnd.openxmlformats-officedocument.spreadsheetml.template.main+xml"
            },
            {
              SpreadsheetDocumentType.MacroEnabledWorkbook,
              "application/vnd.ms-excel.sheet.macroEnabled.main+xml"
            },
            {
              SpreadsheetDocumentType.MacroEnabledTemplate,
              "application/vnd.ms-excel.template.macroEnabled.main+xml"
            },
            {
              SpreadsheetDocumentType.AddIn,
              "application/vnd.ms-excel.addin.macroEnabled.main+xml"
            }
          };
        return SpreadsheetDocument._validMainPartContentType;
      }
    }

    internal override sealed ICollection<string> ValidMainPartContentTypes
    {
      get
      {
        return (ICollection<string>) SpreadsheetDocument.MainPartContentTypes.Values;
      }
    }

    protected SpreadsheetDocument()
    {
    }

    public SpreadsheetDocumentType DocumentType
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
      foreach (KeyValuePair<SpreadsheetDocumentType, string> mainPartContentType in SpreadsheetDocument.MainPartContentTypes)
      {
        if (mainPartContentType.Value == this.MainPartContentType)
          this.DocumentType = mainPartContentType.Key;
      }
    }

    public static SpreadsheetDocument Create(string path, SpreadsheetDocumentType type)
    {
      return SpreadsheetDocument.Create(path, type, true);
    }

    public static SpreadsheetDocument Create(Stream stream, SpreadsheetDocumentType type)
    {
      return SpreadsheetDocument.Create(stream, type, true);
    }

    public static SpreadsheetDocument Create(Package package, SpreadsheetDocumentType type)
    {
      return SpreadsheetDocument.Create(package, type, true);
    }

    public static SpreadsheetDocument Create(string path, SpreadsheetDocumentType type, bool autoSave)
    {
      if (string.IsNullOrEmpty(path))
        throw new ArgumentNullException(nameof (path));
      SpreadsheetDocument spreadsheetDocument = new SpreadsheetDocument();
      spreadsheetDocument.DocumentType = type;
      spreadsheetDocument.OpenSettings = new OpenSettings();
      spreadsheetDocument.OpenSettings.AutoSave = autoSave;
      spreadsheetDocument.MainPartContentType = SpreadsheetDocument.MainPartContentTypes[type];
      spreadsheetDocument.CreateCore(path);
      return spreadsheetDocument;
    }

    public static SpreadsheetDocument Create(Stream stream, SpreadsheetDocumentType type, bool autoSave)
    {
      SpreadsheetDocument spreadsheetDocument = new SpreadsheetDocument();
      spreadsheetDocument.DocumentType = type;
      spreadsheetDocument.OpenSettings = new OpenSettings();
      spreadsheetDocument.OpenSettings.AutoSave = autoSave;
      spreadsheetDocument.MainPartContentType = SpreadsheetDocument.MainPartContentTypes[type];
      spreadsheetDocument.CreateCore(stream);
      return spreadsheetDocument;
    }

    public static SpreadsheetDocument Create(Package package, SpreadsheetDocumentType type, bool autoSave)
    {
      SpreadsheetDocument spreadsheetDocument = new SpreadsheetDocument();
      spreadsheetDocument.DocumentType = type;
      spreadsheetDocument.OpenSettings = new OpenSettings();
      spreadsheetDocument.OpenSettings.AutoSave = autoSave;
      spreadsheetDocument.MainPartContentType = SpreadsheetDocument.MainPartContentTypes[type];
      spreadsheetDocument.CreateCore(package);
      return spreadsheetDocument;
    }

    public static SpreadsheetDocument Open(string path, bool isEditable, OpenSettings openSettings)
    {
      if (openSettings.MarkupCompatibilityProcessSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess && openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2007 && (openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2010 && openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2013))
        throw new ArgumentException(ExceptionMessages.InvalidMCMode);
      SpreadsheetDocument spreadsheetDocument = new SpreadsheetDocument();
      spreadsheetDocument.OpenSettings = new OpenSettings();
      spreadsheetDocument.OpenSettings.AutoSave = openSettings.AutoSave;
      spreadsheetDocument.OpenSettings.MarkupCompatibilityProcessSettings.ProcessMode = openSettings.MarkupCompatibilityProcessSettings.ProcessMode;
      spreadsheetDocument.OpenSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions = openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions;
      spreadsheetDocument.MaxCharactersInPart = openSettings.MaxCharactersInPart;
      spreadsheetDocument.OpenCore(path, isEditable);
      if (SpreadsheetDocument.MainPartContentTypes[spreadsheetDocument.DocumentType] != spreadsheetDocument.MainPartContentType)
        spreadsheetDocument.UpdateDocumentTypeFromContentType();
      return spreadsheetDocument;
    }

    public static SpreadsheetDocument Open(Stream stream, bool isEditable, OpenSettings openSettings)
    {
      if (openSettings.MarkupCompatibilityProcessSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess && openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2007 && (openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2010 && openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2013))
        throw new ArgumentException(ExceptionMessages.InvalidMCMode);
      SpreadsheetDocument spreadsheetDocument = new SpreadsheetDocument();
      spreadsheetDocument.OpenSettings = new OpenSettings();
      spreadsheetDocument.OpenSettings.AutoSave = openSettings.AutoSave;
      spreadsheetDocument.OpenSettings.MarkupCompatibilityProcessSettings.ProcessMode = openSettings.MarkupCompatibilityProcessSettings.ProcessMode;
      spreadsheetDocument.OpenSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions = openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions;
      spreadsheetDocument.MaxCharactersInPart = openSettings.MaxCharactersInPart;
      spreadsheetDocument.OpenCore(stream, isEditable);
      if (SpreadsheetDocument.MainPartContentTypes[spreadsheetDocument.DocumentType] != spreadsheetDocument.MainPartContentType)
        spreadsheetDocument.UpdateDocumentTypeFromContentType();
      return spreadsheetDocument;
    }

    public static SpreadsheetDocument Open(Package package, OpenSettings openSettings)
    {
      if (openSettings.MarkupCompatibilityProcessSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess && openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2007 && (openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2010 && openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2013))
        throw new ArgumentException(ExceptionMessages.InvalidMCMode);
      SpreadsheetDocument spreadsheetDocument = new SpreadsheetDocument();
      spreadsheetDocument.OpenSettings = new OpenSettings();
      spreadsheetDocument.OpenSettings.AutoSave = openSettings.AutoSave;
      spreadsheetDocument.OpenSettings.MarkupCompatibilityProcessSettings.ProcessMode = openSettings.MarkupCompatibilityProcessSettings.ProcessMode;
      spreadsheetDocument.OpenSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions = openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions;
      spreadsheetDocument.MaxCharactersInPart = openSettings.MaxCharactersInPart;
      spreadsheetDocument.OpenCore(package);
      if (SpreadsheetDocument.MainPartContentTypes[spreadsheetDocument.DocumentType] != spreadsheetDocument.MainPartContentType)
        spreadsheetDocument.UpdateDocumentTypeFromContentType();
      return spreadsheetDocument;
    }

    public static SpreadsheetDocument Open(string path, bool isEditable)
    {
      return SpreadsheetDocument.Open(path, isEditable, new OpenSettings());
    }

    public static SpreadsheetDocument Open(Stream stream, bool isEditable)
    {
      return SpreadsheetDocument.Open(stream, isEditable, new OpenSettings());
    }

    public static SpreadsheetDocument Open(Package package)
    {
      return SpreadsheetDocument.Open(package, new OpenSettings());
    }

    public void ChangeDocumentType(SpreadsheetDocumentType newType)
    {
      this.ThrowIfObjectDisposed();
      if (newType == this.DocumentType)
        return;
      if (this.FileOpenAccess == FileAccess.Read)
        throw new IOException(ExceptionMessages.PackageAccessModeIsReadonly);
      SpreadsheetDocumentType documentType = this.DocumentType;
      this.DocumentType = newType;
      this.MainPartContentType = SpreadsheetDocument.MainPartContentTypes[newType];
      if (this.WorkbookPart == null)
        return;
      try
      {
        this.ChangeDocumentTypeInternal<WorkbookPart>();
      }
      catch (OpenXmlPackageException ex)
      {
        if (ex.Message == ExceptionMessages.CannotChangeDocumentType)
        {
          this.DocumentType = documentType;
          this.MainPartContentType = SpreadsheetDocument.MainPartContentTypes[documentType];
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
          return (OpenXmlPart) new WorkbookPart();
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

    public override T AddNewPart<T>(string contentType, string id)
    {
      if (contentType == null)
        throw new ArgumentNullException(nameof (contentType));
      if (typeof (WorkbookPart).IsAssignableFrom(typeof (T)) && contentType != SpreadsheetDocument.MainPartContentTypes[this._documentType])
        throw new OpenXmlPackageException(ExceptionMessages.ErrorContentType);
      return base.AddNewPart<T>(contentType, id);
    }

    public WorkbookPart AddWorkbookPart()
    {
      WorkbookPart newPart = new WorkbookPart();
      this.InitPart<WorkbookPart>(newPart, this.MainPartContentType);
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

    public WorkbookPart WorkbookPart
    {
      get
      {
        return this.GetSubPartOfType<WorkbookPart>();
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

    public DigitalSignatureOriginPart DigitalSignatureOriginPart
    {
      get
      {
        return this.GetSubPartOfType<DigitalSignatureOriginPart>();
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

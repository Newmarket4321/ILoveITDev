// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Validation.OpenXmlValidator
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Internal.SchemaValidation;
using DocumentFormat.OpenXml.Internal.SemanticValidation;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;

namespace DocumentFormat.OpenXml.Validation
{
  public class OpenXmlValidator
  {
    private ValidationSettings _settings;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private SchemaValidator _schemaValidator;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private SemanticValidator _docSmenaticValidator;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private SemanticValidator _xlsSemanticValidator;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private SemanticValidator _pptSemanticValidator;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private SemanticValidator _fullSemanticValidator;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private SpreadsheetDocumentValidator _spreadsheetDocumentValidator;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private WordprocessingDocumentValidator _wordprocessingDocumentValidator;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private PresentationDocumentValidator _presentationDocumentValidator;

    private SchemaValidator SchemaValidator
    {
      get
      {
        if (this._schemaValidator == null)
          this._schemaValidator = new SchemaValidator(this._settings.FileFormat);
        return this._schemaValidator;
      }
    }

    private SemanticValidator DocSmenaticValidator
    {
      get
      {
        if (this._docSmenaticValidator == null)
          this._docSmenaticValidator = new SemanticValidator(this._settings.FileFormat, ApplicationType.Word);
        return this._docSmenaticValidator;
      }
    }

    private SemanticValidator XlsSemanticValidator
    {
      get
      {
        if (this._xlsSemanticValidator == null)
          this._xlsSemanticValidator = new SemanticValidator(this._settings.FileFormat, ApplicationType.Excel);
        return this._xlsSemanticValidator;
      }
    }

    private SemanticValidator PptSemanticValidator
    {
      get
      {
        if (this._pptSemanticValidator == null)
          this._pptSemanticValidator = new SemanticValidator(this._settings.FileFormat, ApplicationType.PowerPoint);
        return this._pptSemanticValidator;
      }
    }

    private SemanticValidator FullSemanticValidator
    {
      get
      {
        if (this._fullSemanticValidator == null)
          this._fullSemanticValidator = new SemanticValidator(this._settings.FileFormat, ApplicationType.All);
        return this._fullSemanticValidator;
      }
    }

    private SpreadsheetDocumentValidator SpreadsheetDocumentValidator
    {
      get
      {
        if (this._spreadsheetDocumentValidator == null)
          this._spreadsheetDocumentValidator = new SpreadsheetDocumentValidator(this._settings, this.SchemaValidator, this.XlsSemanticValidator);
        return this._spreadsheetDocumentValidator;
      }
    }

    private WordprocessingDocumentValidator WordprocessingDocumentValidator
    {
      get
      {
        if (this._wordprocessingDocumentValidator == null)
          this._wordprocessingDocumentValidator = new WordprocessingDocumentValidator(this._settings, this.SchemaValidator, this.DocSmenaticValidator);
        return this._wordprocessingDocumentValidator;
      }
    }

    private PresentationDocumentValidator PresentationDocumentValidator
    {
      get
      {
        if (this._presentationDocumentValidator == null)
          this._presentationDocumentValidator = new PresentationDocumentValidator(this._settings, this.SchemaValidator, this.PptSemanticValidator);
        return this._presentationDocumentValidator;
      }
    }

    public OpenXmlValidator()
      : this(FileFormatVersions.Office2007)
    {
    }

    public OpenXmlValidator(FileFormatVersions fileFormat)
    {
      fileFormat.ThrowExceptionIfFileFormatNotSupported(nameof (fileFormat));
      this._settings = new ValidationSettings(fileFormat);
    }

    public FileFormatVersions FileFormat
    {
      get
      {
        return this._settings.FileFormat;
      }
    }

    public int MaxNumberOfErrors
    {
      get
      {
        return this._settings.MaxNumberOfErrors;
      }
      set
      {
        if (value < 0)
          throw new ArgumentOutOfRangeException(nameof (value));
        this._settings.MaxNumberOfErrors = value;
      }
    }

    public IEnumerable<ValidationErrorInfo> Validate(OpenXmlPackage openXmlPackage)
    {
      if (openXmlPackage == null)
        throw new ArgumentNullException(nameof (openXmlPackage));
      if (openXmlPackage.OpenSettings.MarkupCompatibilityProcessSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess && openXmlPackage.OpenSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != this.FileFormat)
        throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ExceptionMessages.DocumentFileFormatVersionMismatch, new object[2]
        {
          (object) openXmlPackage.OpenSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions,
          (object) this.FileFormat
        }));
      ValidationResult validationResult;
      switch (DocumentTypeDetector.GetDocumentType(openXmlPackage))
      {
        case OpenXmlDocumentType.Wordprocessing:
          validationResult = this.WordprocessingDocumentValidator.Validate((OpenXmlPackage) (openXmlPackage as WordprocessingDocument));
          break;
        case OpenXmlDocumentType.Spreadsheet:
          validationResult = this.SpreadsheetDocumentValidator.Validate((OpenXmlPackage) (openXmlPackage as SpreadsheetDocument));
          break;
        case OpenXmlDocumentType.Presentation:
          validationResult = this.PresentationDocumentValidator.Validate((OpenXmlPackage) (openXmlPackage as PresentationDocument));
          break;
        default:
          throw new InvalidDataException(ExceptionMessages.UnknownPackage);
      }
      return this.YieldResult(validationResult);
    }

    public IEnumerable<ValidationErrorInfo> Validate(OpenXmlPart openXmlPart)
    {
      if (openXmlPart == null)
        throw new ArgumentNullException(nameof (openXmlPart));
      OpenXmlPackage openXmlPackage = openXmlPart.OpenXmlPackage;
      if (openXmlPackage.OpenSettings.MarkupCompatibilityProcessSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess && openXmlPackage.OpenSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != this.FileFormat)
        throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ExceptionMessages.DocumentFileFormatVersionMismatch, new object[2]
        {
          (object) openXmlPackage.OpenSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions,
          (object) this.FileFormat
        }));
      if (!openXmlPart.IsInVersion(this.FileFormat))
      {
        if (openXmlPart is ExtendedPart)
          throw new InvalidOperationException(ExceptionMessages.PartNotInVersion);
        string message;
        switch (this.FileFormat)
        {
          case FileFormatVersions.Office2007:
            message = ExceptionMessages.PartIsNotInOffice2007;
            break;
          case FileFormatVersions.Office2010:
            message = ExceptionMessages.PartIsNotInOffice2010;
            break;
          default:
            message = ExceptionMessages.PartIsNotInOffice2013;
            break;
        }
        throw new InvalidOperationException(message);
      }
      ValidationResult validationResult;
      switch (DocumentTypeDetector.GetDocumentType(openXmlPart.OpenXmlPackage))
      {
        case OpenXmlDocumentType.Wordprocessing:
          validationResult = this.WordprocessingDocumentValidator.Validate(openXmlPart);
          break;
        case OpenXmlDocumentType.Spreadsheet:
          validationResult = this.SpreadsheetDocumentValidator.Validate(openXmlPart);
          break;
        case OpenXmlDocumentType.Presentation:
          validationResult = this.PresentationDocumentValidator.Validate(openXmlPart);
          break;
        default:
          throw new InvalidDataException(ExceptionMessages.UnknownPackage);
      }
      return this.YieldResult(validationResult);
    }

    public IEnumerable<ValidationErrorInfo> Validate(OpenXmlElement openXmlElement)
    {
      if (openXmlElement == null)
        throw new ArgumentNullException(nameof (openXmlElement));
      if (openXmlElement is OpenXmlUnknownElement)
        throw new ArgumentOutOfRangeException(nameof (openXmlElement), ExceptionMessages.CannotValidateUnknownElement);
      if (openXmlElement is OpenXmlMiscNode)
        throw new ArgumentOutOfRangeException(nameof (openXmlElement), ExceptionMessages.CannotValidateMiscNode);
      if (openXmlElement is AlternateContent || openXmlElement is AlternateContentChoice || openXmlElement is AlternateContentFallback)
        throw new ArgumentOutOfRangeException(nameof (openXmlElement), ExceptionMessages.CannotValidateAcbElement);
      if (!openXmlElement.IsInVersion(this.FileFormat))
      {
        switch (this.FileFormat)
        {
          case FileFormatVersions.Office2007:
            throw new InvalidOperationException(ExceptionMessages.ElementIsNotInOffice2007);
          case FileFormatVersions.Office2010:
            throw new InvalidOperationException(ExceptionMessages.ElementIsNotInOffice2010);
          case FileFormatVersions.Office2013:
            throw new InvalidOperationException(ExceptionMessages.ElementIsNotInOffice2013);
        }
      }
      ValidationResult validationResult = new ValidationResult();
      validationResult.Valid = true;
      validationResult.MaxNumberOfErrors = this._settings.MaxNumberOfErrors;
      validationResult.MaxNumberOfErrorsEventHandler += new EventHandler<EventArgs>(this.SchemaValidator.OnCancel);
      ValidationContext validationContext = new ValidationContext();
      validationContext.FileFormat = this.FileFormat;
      validationContext.ValidationErrorEventHandler += new EventHandler<ValidationErrorEventArgs>(validationResult.OnValidationError);
      validationContext.Element = openXmlElement;
      this.SchemaValidator.Validate(validationContext);
      validationContext.Element = openXmlElement;
      this.FullSemanticValidator.Validate(validationContext);
      return this.YieldResult(validationResult);
    }

    private IEnumerable<ValidationErrorInfo> YieldResult(ValidationResult validationResult)
    {
      if (validationResult != null && !validationResult.Valid)
      {
        foreach (ValidationErrorInfo error in validationResult.Errors)
          yield return error;
      }
    }
  }
}

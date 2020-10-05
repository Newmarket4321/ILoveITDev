// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Validation.DocumentValidator
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Internal.SchemaValidation;
using DocumentFormat.OpenXml.Internal.SemanticValidation;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;

namespace DocumentFormat.OpenXml.Validation
{
  internal abstract class DocumentValidator
  {
    internal SchemaValidator SchemaValidator { get; private set; }

    internal SemanticValidator SemanticValidator { get; private set; }

    protected ValidationSettings ValidationSettings { get; private set; }

    internal DocumentValidator(ValidationSettings settings, SchemaValidator schemaValidator, SemanticValidator semanticValidator)
    {
      this.SchemaValidator = schemaValidator;
      this.SemanticValidator = semanticValidator;
      this.ValidationSettings = settings;
    }

    internal ValidationResult Validate(OpenXmlPackage document)
    {
      this.TargetDocument = document;
      this.PrepareValidation();
      this.ValidationContext.Package = document;
      this.ValidatePackageStructure(document);
      foreach (OpenXmlPart part in this.PartsToBeValidated)
        this.ValidatePart(part);
      this.FinishValidation();
      return this.ValidationResult;
    }

    internal ValidationResult Validate(OpenXmlPart part)
    {
      this.PrepareValidation();
      this.ValidatePart(part);
      return this.ValidationResult;
    }

    internal void ValidatePart(OpenXmlPart part)
    {
      if (!part.IsInVersion(this.ValidationSettings.FileFormat))
        return;
      try
      {
        bool rootElementLoaded = part.IsRootElementLoaded;
        this.ValidationContext.Part = part;
        this.ValidationContext.Element = (OpenXmlElement) part.PartRootElement;
        int count = this.ValidationResult.Errors.Count;
        if (part.PartRootElement != null)
        {
          this.SchemaValidator.Validate(this.ValidationContext);
          this.ValidationContext.Element = (OpenXmlElement) part.PartRootElement;
          this.SemanticValidator.ClearConstraintState(SemanticValidationLevel.PartOnly);
          this.SemanticValidator.Validate(this.ValidationContext);
        }
        if (rootElementLoaded || this.ValidationResult.Errors.Count != count)
          return;
        part.SetPartRootElementToNull();
      }
      catch (XmlException ex)
      {
        this.ValidationResult.AddError(new ValidationErrorInfo()
        {
          ErrorType = ValidationErrorType.Schema,
          Id = "ExceptionError",
          Part = part,
          Path = new XmlPath(part),
          Description = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.ExceptionError, new object[1]
          {
            (object) ex.Message
          })
        });
      }
    }

    protected ValidationContext ValidationContext { get; set; }

    protected ValidationResult ValidationResult { get; set; }

    protected abstract OpenXmlPackage TargetDocument { get; set; }

    protected abstract IEnumerable<OpenXmlPart> PartsToBeValidated { get; }

    protected virtual bool PrepareValidation()
    {
      this.InitValidationContext();
      this.SemanticValidator.ClearConstraintState(SemanticValidationLevel.PackageOnly);
      return true;
    }

    protected void InitValidationContext()
    {
      this.ValidationResult = new ValidationResult();
      this.ValidationResult.Valid = true;
      this.ValidationResult.MaxNumberOfErrors = this.ValidationSettings.MaxNumberOfErrors;
      this.ValidationResult.MaxNumberOfErrorsEventHandler += new EventHandler<EventArgs>(this.SchemaValidator.OnCancel);
      this.ValidationResult.MaxNumberOfErrorsEventHandler += new EventHandler<EventArgs>(this.SemanticValidator.OnCancel);
      this.ValidationContext = new ValidationContext();
      this.ValidationContext.FileFormat = this.ValidationSettings.FileFormat;
      this.ValidationContext.ValidationErrorEventHandler += new EventHandler<ValidationErrorEventArgs>(this.ValidationResult.OnValidationError);
    }

    protected virtual bool FinishValidation()
    {
      return true;
    }

    private void ValidatePackageStructure(OpenXmlPackage document)
    {
      OpenXmlPackageValidationSettings validationSettings = new OpenXmlPackageValidationSettings();
      validationSettings.EventHandler += new EventHandler<OpenXmlPackageValidationEventArgs>(this.OnPackageValidationError);
      document.Validate(validationSettings, this.ValidationSettings.FileFormat);
    }

    private void OnPackageValidationError(object sender, OpenXmlPackageValidationEventArgs e)
    {
      ValidationErrorInfo error = new ValidationErrorInfo();
      error.ErrorType = ValidationErrorType.Package;
      error.Id = "Pkg_" + e.MessageId;
      switch (error.Id)
      {
        case "Pkg_PartIsNotAllowed":
          string str1 = e.Part != null ? DocumentValidator.GetPartNameAndUri(e.Part) : DocumentValidator.GetDocumentName(this.TargetDocument);
          error.Description = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Pkg_PartIsNotAllowed, new object[2]
          {
            (object) str1,
            (object) DocumentValidator.GetPartNameAndUri(e.SubPart)
          });
          break;
        case "Pkg_RequiredPartDoNotExist":
          error.Description = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Pkg_RequiredPartDoNotExist, new object[1]
          {
            (object) e.PartClassName
          });
          break;
        case "Pkg_OnlyOnePartAllowed":
          string str2 = e.Part != null ? DocumentValidator.GetPartNameAndUri(e.Part) : DocumentValidator.GetDocumentName(this.TargetDocument);
          error.Description = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Pkg_OnlyOnePartAllowed, new object[2]
          {
            (object) str2,
            (object) e.PartClassName
          });
          break;
        case "Pkg_ExtendedPartIsOpenXmlPart":
          error.Description = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Pkg_ExtendedPartIsOpenXmlPart, new object[1]
          {
            (object) DocumentValidator.GetPartUri(e.SubPart)
          });
          break;
        case "Pkg_DataPartReferenceIsNotAllowed":
          string str3 = e.Part != null ? DocumentValidator.GetPartNameAndUri(e.Part) : DocumentValidator.GetDocumentName(this.TargetDocument);
          error.Description = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Pkg_PartIsNotAllowed, new object[2]
          {
            (object) str3,
            (object) e.DataPartReferenceRelationship.Uri
          });
          break;
      }
      if (e.Part != null)
      {
        error.Part = e.Part;
        error.Path = new XmlPath(e.Part);
      }
      error.RelatedPart = e.SubPart;
      this.ValidationResult.AddError(error);
    }

    private static string GetPartNameAndUri(OpenXmlPart part)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentUICulture, "{0}{1}{2}{3}", (object) part.GetType().Name, (object) '{', (object) part.Uri, (object) '}');
    }

    private static string GetPartUri(OpenXmlPart part)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentUICulture, "{0}{1}{2}", (object) '{', (object) part.Uri, (object) '}');
    }

    private static string GetDocumentName(OpenXmlPackage document)
    {
      return document.GetType().Name;
    }
  }
}

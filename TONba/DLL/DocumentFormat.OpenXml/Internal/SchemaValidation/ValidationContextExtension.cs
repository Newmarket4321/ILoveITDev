// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.ValidationContextExtension
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Validation;
using System;
using System.Globalization;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  internal static class ValidationContextExtension
  {
    internal static ValidationErrorInfo ComposeSchemaValidationError(this ValidationContext validationContext, OpenXmlElement element, OpenXmlElement child, string messageId, params string[] args)
    {
      return validationContext.ComposeValidationError(ValidationErrorType.Schema, element, child, messageId, args);
    }

    internal static ValidationErrorInfo ComposeMcValidationError(this ValidationContext validationContext, OpenXmlElement element, string messageId, params string[] args)
    {
      return validationContext.ComposeValidationError(ValidationErrorType.MarkupCompatibility, element, (OpenXmlElement) null, messageId, args);
    }

    internal static ValidationErrorInfo ComposeValidationError(this ValidationContext validationContext, ValidationErrorType errorType, OpenXmlElement element, OpenXmlElement child, string messageId, params string[] args)
    {
      return new ValidationErrorInfo()
      {
        ErrorType = errorType,
        Part = validationContext.Part,
        Node = element,
        Id = messageId,
        RelatedNode = child,
        Description = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.ResourceManager.GetString(messageId), (object[]) args)
      };
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SemanticValidation.AttributeMutualExclusive
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Validation;
using System;
using System.Globalization;

namespace DocumentFormat.OpenXml.Internal.SemanticValidation
{
  internal class AttributeMutualExclusive : SemanticConstraint
  {
    private byte[] _attributes;

    public AttributeMutualExclusive(params byte[] attributes)
      : base(SemanticValidationLevel.Element)
    {
      this._attributes = attributes;
    }

    public override ValidationErrorInfo Validate(ValidationContext context)
    {
      string str1 = string.Empty;
      string str2 = string.Empty;
      string empty = string.Empty;
      foreach (byte attribute in this._attributes)
      {
        str1 = str1 + "," + (object) SemanticConstraint.GetAttributeQualifiedName(context.Element, attribute);
        if (context.Element.Attributes[(int) attribute] != null)
        {
          if (!string.IsNullOrEmpty(empty))
            str2 = str2 + "," + empty;
          empty = SemanticConstraint.GetAttributeQualifiedName(context.Element, attribute).ToString();
        }
      }
      if (string.IsNullOrEmpty(str2))
        return (ValidationErrorInfo) null;
      return new ValidationErrorInfo()
      {
        Id = "Sem_AttributeMutualExclusive",
        ErrorType = ValidationErrorType.Semantic,
        Node = context.Element,
        Description = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Sem_AttributeMutualExclusive, (object) str2.Substring(1), (object) empty, (object) str1.Substring(1))
      };
    }
  }
}

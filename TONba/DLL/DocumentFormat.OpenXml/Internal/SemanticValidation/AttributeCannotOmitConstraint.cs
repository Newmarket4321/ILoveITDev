// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SemanticValidation.AttributeCannotOmitConstraint
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Validation;
using System;
using System.Globalization;

namespace DocumentFormat.OpenXml.Internal.SemanticValidation
{
  internal class AttributeCannotOmitConstraint : SemanticConstraint
  {
    private byte _attribute;

    public AttributeCannotOmitConstraint(byte attribute)
      : base(SemanticValidationLevel.Element)
    {
      this._attribute = attribute;
    }

    public override ValidationErrorInfo Validate(ValidationContext context)
    {
      if (context.Element.Attributes[(int) this._attribute] != null)
        return (ValidationErrorInfo) null;
      return new ValidationErrorInfo()
      {
        Id = "Sem_MissRequiredAttribute",
        ErrorType = ValidationErrorType.Schema,
        Node = context.Element,
        Description = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Sch_MissRequiredAttribute, new object[1]
        {
          (object) SemanticConstraint.GetAttributeQualifiedName(context.Element, this._attribute)
        })
      };
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SemanticValidation.RelationshipExistConstraint
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Validation;
using System;
using System.Globalization;

namespace DocumentFormat.OpenXml.Internal.SemanticValidation
{
  internal class RelationshipExistConstraint : SemanticConstraint
  {
    private byte _rIdAttribute;

    public RelationshipExistConstraint(byte rIdAttribute)
      : base(SemanticValidationLevel.Part)
    {
      this._rIdAttribute = rIdAttribute;
    }

    public override ValidationErrorInfo Validate(ValidationContext context)
    {
      OpenXmlSimpleType attribute = context.Element.Attributes[(int) this._rIdAttribute];
      if (attribute == null || string.IsNullOrEmpty(attribute.InnerText))
        return (ValidationErrorInfo) null;
      if (context.Part.PackagePart.RelationshipExists(attribute.InnerText))
        return (ValidationErrorInfo) null;
      string str = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Sem_InvalidRelationshipId, new object[2]
      {
        (object) attribute,
        (object) SemanticConstraint.GetAttributeQualifiedName(context.Element, this._rIdAttribute)
      });
      return new ValidationErrorInfo()
      {
        Id = "Sem_InvalidRelationshipId",
        ErrorType = ValidationErrorType.Semantic,
        Node = context.Element,
        Description = str
      };
    }
  }
}

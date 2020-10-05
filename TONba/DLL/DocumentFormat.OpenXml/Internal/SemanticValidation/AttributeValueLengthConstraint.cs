// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SemanticValidation.AttributeValueLengthConstraint
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Validation;
using System;
using System.Globalization;

namespace DocumentFormat.OpenXml.Internal.SemanticValidation
{
  internal class AttributeValueLengthConstraint : SemanticConstraint
  {
    private byte _attribute;
    private int _minLength;
    private int _maxLength;

    public AttributeValueLengthConstraint(byte attribute, int minLength, int maxLength)
      : base(SemanticValidationLevel.Element)
    {
      this._attribute = attribute;
      this._maxLength = maxLength;
      this._minLength = minLength;
    }

    public override ValidationErrorInfo Validate(ValidationContext context)
    {
      OpenXmlSimpleType attribute = context.Element.Attributes[(int) this._attribute];
      if (attribute == null)
        return (ValidationErrorInfo) null;
      string str1 = attribute.InnerText == null ? string.Empty : attribute.InnerText;
      string str2 = (string) null;
      if (str1.Length < this._minLength)
        str2 = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Sem_MinLengthConstraintFailed, new object[1]
        {
          (object) this._minLength
        });
      else if (str1.Length > this._maxLength)
        str2 = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Sem_MaxLengthConstraintFailed, new object[1]
        {
          (object) this._maxLength
        });
      if (str2 == null)
        return (ValidationErrorInfo) null;
      return new ValidationErrorInfo()
      {
        Id = "Sem_AttributeValueDataTypeDetailed",
        ErrorType = ValidationErrorType.Schema,
        Node = context.Element,
        Description = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Sem_AttributeValueDataTypeDetailed, (object) SemanticConstraint.GetAttributeQualifiedName(context.Element, this._attribute), (object) str1, (object) str2)
      };
    }
  }
}

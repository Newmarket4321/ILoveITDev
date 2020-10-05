// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SemanticValidation.AttributeValueSetConstraint
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Validation;
using System;
using System.Globalization;

namespace DocumentFormat.OpenXml.Internal.SemanticValidation
{
  internal class AttributeValueSetConstraint : SemanticConstraint
  {
    private byte _attribute;
    private bool _isValidValueSet;
    private string[] _valueSet;

    public AttributeValueSetConstraint(byte attribute, bool isValid, string[] valueSet)
      : base(SemanticValidationLevel.Element)
    {
      this._attribute = attribute;
      this._isValidValueSet = isValid;
      this._valueSet = valueSet;
    }

    public override ValidationErrorInfo Validate(ValidationContext context)
    {
      OpenXmlSimpleType attribute = context.Element.Attributes[(int) this._attribute];
      if (attribute == null || string.IsNullOrEmpty(attribute.InnerText))
        return (ValidationErrorInfo) null;
      bool flag = false;
      foreach (string str in this._valueSet)
      {
        if (SemanticConstraint.AttributeValueEquals(attribute, str, false))
          flag = true;
      }
      if (!this._isValidValueSet ^ flag)
        return (ValidationErrorInfo) null;
      string constraintFailed = ValidationResources.Sch_EnumerationConstraintFailed;
      string str1 = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Sem_AttributeValueDataTypeDetailed, (object) SemanticConstraint.GetAttributeQualifiedName(context.Element, this._attribute), (object) attribute, (object) constraintFailed);
      return new ValidationErrorInfo()
      {
        Id = "Sem_AttributeValueDataTypeDetailed",
        ErrorType = ValidationErrorType.Schema,
        Node = context.Element,
        Description = str1
      };
    }
  }
}

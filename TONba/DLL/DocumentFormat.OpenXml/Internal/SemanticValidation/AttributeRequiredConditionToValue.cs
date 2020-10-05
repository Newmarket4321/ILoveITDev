// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SemanticValidation.AttributeRequiredConditionToValue
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Validation;
using System;
using System.Globalization;

namespace DocumentFormat.OpenXml.Internal.SemanticValidation
{
  internal class AttributeRequiredConditionToValue : SemanticConstraint
  {
    private string[] _values;
    private byte _requiredAttribute;
    private byte _conditionAttribute;

    public AttributeRequiredConditionToValue(byte requiredAttribute, byte conditionAttribute, params string[] values)
      : base(SemanticValidationLevel.Element)
    {
      this._requiredAttribute = requiredAttribute;
      this._conditionAttribute = conditionAttribute;
      this._values = values;
    }

    public override ValidationErrorInfo Validate(ValidationContext context)
    {
      if (context.Element.Attributes[(int) this._requiredAttribute] != null)
        return (ValidationErrorInfo) null;
      OpenXmlSimpleType attribute = context.Element.Attributes[(int) this._conditionAttribute];
      if (attribute == null)
        return (ValidationErrorInfo) null;
      foreach (string str1 in this._values)
      {
        if (SemanticConstraint.AttributeValueEquals(attribute, str1, false))
        {
          string str2 = "'" + this._values[0] + "'";
          if (this._values.Length > 1)
          {
            for (int index = 1; index < this._values.Length - 1; ++index)
              str2 = str2 + ", '" + this._values[index] + "'";
            str2 = str2 + " or '" + this._values[this._values.Length - 1] + "'";
          }
          return new ValidationErrorInfo()
          {
            Id = "Sem_AttributeRequiredConditionToValue",
            ErrorType = ValidationErrorType.Semantic,
            Node = context.Element,
            Description = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Sem_AttributeRequiredConditionToValue, (object) SemanticConstraint.GetAttributeQualifiedName(context.Element, this._requiredAttribute), (object) SemanticConstraint.GetAttributeQualifiedName(context.Element, this._conditionAttribute), (object) str2)
          };
        }
      }
      return (ValidationErrorInfo) null;
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SemanticValidation.AttributeValueConditionToAnother
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Validation;
using System;
using System.Globalization;

namespace DocumentFormat.OpenXml.Internal.SemanticValidation
{
  internal class AttributeValueConditionToAnother : SemanticConstraint
  {
    private byte _attribute;
    private byte _conditionAttribute;
    private string[] _values;
    private string[] _otherValues;

    public AttributeValueConditionToAnother(byte attribute, byte conditionAttribute, string[] values, string[] otherValues)
      : base(SemanticValidationLevel.Element)
    {
      this._attribute = attribute;
      this._conditionAttribute = conditionAttribute;
      this._values = values;
      this._otherValues = otherValues;
    }

    public override ValidationErrorInfo Validate(ValidationContext context)
    {
      OpenXmlSimpleType attribute1 = context.Element.Attributes[(int) this._attribute];
      if (attribute1 == null)
        return (ValidationErrorInfo) null;
      foreach (string str in this._values)
      {
        if (SemanticConstraint.AttributeValueEquals(attribute1, str, false))
          return (ValidationErrorInfo) null;
      }
      OpenXmlSimpleType attribute2 = context.Element.Attributes[(int) this._conditionAttribute];
      if (attribute2 == null)
        return (ValidationErrorInfo) null;
      foreach (string otherValue in this._otherValues)
      {
        if (SemanticConstraint.AttributeValueEquals(attribute2, otherValue, false))
        {
          string str1 = "'" + this._values[0] + "'";
          if (this._values.Length > 1)
          {
            for (int index = 1; index < this._values.Length - 1; ++index)
              str1 = str1 + ", '" + this._values[index] + "'";
            str1 = str1 + " or '" + this._values[this._values.Length - 1] + "'";
          }
          string str2 = "'" + this._otherValues[0] + "'";
          if (this._otherValues.Length > 1)
          {
            for (int index = 1; index < this._otherValues.Length - 1; ++index)
              str2 = str2 + ", '" + this._otherValues[index] + "'";
            str2 = str2 + " or '" + this._otherValues[this._otherValues.Length - 1] + "'";
          }
          return new ValidationErrorInfo()
          {
            Id = "Sem_AttributeValueConditionToAnother",
            ErrorType = ValidationErrorType.Semantic,
            Node = context.Element,
            Description = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Sem_AttributeValueConditionToAnother, (object) SemanticConstraint.GetAttributeQualifiedName(context.Element, this._attribute), (object) str1, (object) SemanticConstraint.GetAttributeQualifiedName(context.Element, this._conditionAttribute), (object) str2, (object) SemanticConstraint.GetAttributeQualifiedName(context.Element, this._attribute), (object) attribute1)
          };
        }
      }
      return (ValidationErrorInfo) null;
    }
  }
}

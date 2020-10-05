// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SemanticValidation.AttributeAbsentConditionToNonValue
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Validation;
using System;
using System.Globalization;

namespace DocumentFormat.OpenXml.Internal.SemanticValidation
{
  internal class AttributeAbsentConditionToNonValue : SemanticConstraint
  {
    private byte _absentAttribute;
    private byte _conditionAttribute;
    private string[] _values;

    public AttributeAbsentConditionToNonValue(byte absentAttribute, byte conditionAttribute, params string[] values)
      : base(SemanticValidationLevel.Element)
    {
      this._absentAttribute = absentAttribute;
      this._conditionAttribute = conditionAttribute;
      this._values = values;
    }

    public override ValidationErrorInfo Validate(ValidationContext context)
    {
      if (context.Element.Attributes[(int) this._absentAttribute] == null)
        return (ValidationErrorInfo) null;
      OpenXmlSimpleType attribute = context.Element.Attributes[(int) this._conditionAttribute];
      if (attribute == null)
        return (ValidationErrorInfo) null;
      foreach (string str in this._values)
      {
        if (SemanticConstraint.AttributeValueEquals(attribute, str, false))
          return (ValidationErrorInfo) null;
      }
      string str1 = "'" + this._values[0] + "'";
      if (this._values.Length > 1)
      {
        for (int index = 1; index < this._values.Length - 1; ++index)
          str1 = str1 + ", '" + this._values[index] + "'";
        str1 = str1 + " and '" + this._values[this._values.Length - 1] + "'";
      }
      return new ValidationErrorInfo()
      {
        Id = "Sem_AttributeAbsentConditionToNonValue",
        ErrorType = ValidationErrorType.Semantic,
        Node = context.Element,
        Description = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Sem_AttributeAbsentConditionToNonValue, (object) SemanticConstraint.GetAttributeQualifiedName(context.Element, this._absentAttribute), (object) SemanticConstraint.GetAttributeQualifiedName(context.Element, this._conditionAttribute), (object) str1)
      };
    }
  }
}

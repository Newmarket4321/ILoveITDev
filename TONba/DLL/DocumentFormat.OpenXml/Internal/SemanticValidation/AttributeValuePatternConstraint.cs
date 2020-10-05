// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SemanticValidation.AttributeValuePatternConstraint
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Validation;
using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace DocumentFormat.OpenXml.Internal.SemanticValidation
{
  internal class AttributeValuePatternConstraint : SemanticConstraint
  {
    private byte _attribute;
    private string _pattern;

    public AttributeValuePatternConstraint(byte attribute, string pattern)
      : base(SemanticValidationLevel.Element)
    {
      this._attribute = attribute;
      if (pattern.StartsWith("^", StringComparison.Ordinal) && pattern.EndsWith("$", StringComparison.Ordinal))
        this._pattern = pattern;
      else
        this._pattern = "^" + pattern + "$";
    }

    public override ValidationErrorInfo Validate(ValidationContext context)
    {
      OpenXmlSimpleType attribute = context.Element.Attributes[(int) this._attribute];
      if (attribute == null || string.IsNullOrEmpty(attribute.InnerText))
        return (ValidationErrorInfo) null;
      if (new Regex(this._pattern).IsMatch(attribute.InnerText))
        return (ValidationErrorInfo) null;
      string str = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Sch_PatternConstraintFailed, new object[1]
      {
        (object) this._pattern
      });
      return new ValidationErrorInfo()
      {
        Id = "Sem_AttributeValueDataTypeDetailed",
        ErrorType = ValidationErrorType.Schema,
        Node = context.Element,
        Description = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Sem_AttributeValueDataTypeDetailed, (object) SemanticConstraint.GetAttributeQualifiedName(context.Element, this._attribute), (object) attribute.InnerText, (object) str)
      };
    }
  }
}

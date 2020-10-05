// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SemanticValidation.AttributeValueLessEqualToAnother
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Validation;
using System;
using System.Globalization;

namespace DocumentFormat.OpenXml.Internal.SemanticValidation
{
  internal class AttributeValueLessEqualToAnother : SemanticConstraint
  {
    private byte _attribute;
    private byte _otherAttribute;
    private bool _canEqual;

    public AttributeValueLessEqualToAnother(byte attribute, byte otherAttribute, bool canEqual)
      : base(SemanticValidationLevel.Element)
    {
      this._attribute = attribute;
      this._otherAttribute = otherAttribute;
      this._canEqual = canEqual;
    }

    public override ValidationErrorInfo Validate(ValidationContext context)
    {
      OpenXmlSimpleType attribute1 = context.Element.Attributes[(int) this._attribute];
      if (attribute1 == null)
        return (ValidationErrorInfo) null;
      double num1;
      if (!SemanticConstraint.GetAttrNumVal(attribute1, out num1))
        return (ValidationErrorInfo) null;
      OpenXmlSimpleType attribute2 = context.Element.Attributes[(int) this._otherAttribute];
      if (attribute2 == null)
        return (ValidationErrorInfo) null;
      double num2;
      if (!SemanticConstraint.GetAttrNumVal(attribute2, out num2))
        return (ValidationErrorInfo) null;
      if (num1 < num2 && !this._canEqual || num1 <= num2 && this._canEqual)
        return (ValidationErrorInfo) null;
      string format = this._canEqual ? ValidationResources.Sem_AttributeValueLessEqualToAnother : ValidationResources.Sem_AttributeValueLessEqualToAnotherEx;
      return new ValidationErrorInfo()
      {
        Id = "Sem_AttributeValueLessEqualToAnother",
        ErrorType = ValidationErrorType.Semantic,
        Node = context.Element,
        Description = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, format, (object) SemanticConstraint.GetAttributeQualifiedName(context.Element, this._attribute), (object) attribute1.InnerText, (object) SemanticConstraint.GetAttributeQualifiedName(context.Element, this._otherAttribute), (object) attribute2.InnerText)
      };
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SemanticValidation.AttributeValueRangeConstraint
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Validation;
using System;
using System.Globalization;

namespace DocumentFormat.OpenXml.Internal.SemanticValidation
{
  internal class AttributeValueRangeConstraint : SemanticConstraint
  {
    public byte _attribute;
    public bool _isValidRange;
    public double _minValue;
    public double _maxValue;
    private bool _minInclusive;
    private bool _maxInclusive;

    public AttributeValueRangeConstraint(byte attribute, bool isValid, double minValue, bool minInclusive, double maxValue, bool maxInclusive)
      : base(SemanticValidationLevel.Element)
    {
      this._attribute = attribute;
      this._isValidRange = isValid;
      this._minValue = minValue;
      this._maxValue = maxValue;
      this._minInclusive = minInclusive;
      this._maxInclusive = maxInclusive;
    }

    public override ValidationErrorInfo Validate(ValidationContext context)
    {
      OpenXmlSimpleType attribute = context.Element.Attributes[(int) this._attribute];
      if (attribute == null || !attribute.HasValue || string.IsNullOrEmpty(attribute.InnerText))
        return (ValidationErrorInfo) null;
      double num;
      if (!SemanticConstraint.GetAttrNumVal(attribute, out num))
        return (ValidationErrorInfo) null;
      string str1;
      string str2;
      if (attribute is HexBinaryValue)
      {
        str1 = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, "{0:X}", new object[1]
        {
          (object) (long) this._minValue
        });
        str2 = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, "{0:X}", new object[1]
        {
          (object) (long) this._maxValue
        });
      }
      else
      {
        str1 = this._minValue.ToString((IFormatProvider) CultureInfo.CurrentUICulture);
        str2 = this._maxValue.ToString((IFormatProvider) CultureInfo.CurrentUICulture);
      }
      string str3 = (string) null;
      if (this._minInclusive)
      {
        if (this._minValue > num)
          str3 = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Sch_MinInclusiveConstraintFailed, new object[1]
          {
            (object) str1
          });
      }
      else if (this._minValue >= num)
        str3 = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Sch_MinExclusiveConstraintFailed, new object[1]
        {
          (object) str1
        });
      if (this._maxInclusive)
      {
        if (num > this._maxValue)
          str3 = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Sch_MaxInclusiveConstraintFailed, new object[1]
          {
            (object) str2
          });
      }
      else if (num >= this._maxValue)
        str3 = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Sch_MaxExclusiveConstraintFailed, new object[1]
        {
          (object) str2
        });
      if (str3 == null)
        return (ValidationErrorInfo) null;
      return new ValidationErrorInfo()
      {
        Id = "Sem_AttributeValueDataTypeDetailed",
        ErrorType = ValidationErrorType.Schema,
        Node = context.Element,
        Description = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Sem_AttributeValueDataTypeDetailed, (object) SemanticConstraint.GetAttributeQualifiedName(context.Element, this._attribute), (object) attribute, (object) str3)
      };
    }
  }
}

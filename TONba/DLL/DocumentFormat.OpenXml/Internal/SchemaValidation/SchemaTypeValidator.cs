// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.SchemaTypeValidator
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Validation;
using System;
using System.Globalization;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  internal class SchemaTypeValidator
  {
    private SdbSchemaDatas _sdbSchemaDatas;

    internal SchemaTypeValidator(SdbSchemaDatas sdbSchemaDatas)
    {
      this._sdbSchemaDatas = sdbSchemaDatas;
    }

    internal void Validate(ValidationContext validationContext)
    {
      OpenXmlElement element = validationContext.Element;
      if (element.ElementTypeId < 10000)
      {
        if (element.ElementTypeId != 9003)
          return;
        AlternateContentValidator.Validate(validationContext);
      }
      else
      {
        CompatibilityRuleAttributesValidator.ValidateMcAttributes(validationContext);
        SchemaTypeData schemaTypeData = this._sdbSchemaDatas.GetSchemaTypeData(element);
        SchemaTypeValidator.ValidateAttributes(validationContext, schemaTypeData);
        if (element is OpenXmlLeafTextElement)
          SchemaTypeValidator.SimpleContentComplexTypeValidator.Validate(validationContext, schemaTypeData.SimpleTypeConstraint);
        else if (element is OpenXmlLeafElement)
          SchemaTypeValidator.EmptyComplexTypeValidator.Validate(validationContext);
        else if (schemaTypeData.ParticleConstraint != null)
          SchemaTypeValidator.CompositeComplexTypeValidator.Validate(validationContext, schemaTypeData.ParticleConstraint);
        else
          SchemaTypeValidator.EmptyRootComplexTypeValidator.Validate(validationContext);
      }
    }

    private static void ValidateAttributes(ValidationContext validationContext, SchemaTypeData schemaTypeData)
    {
      OpenXmlElement element = validationContext.Element;
      for (int attriuteIndex = 0; attriuteIndex < schemaTypeData.AttributeConstraintsCount; ++attriuteIndex)
      {
        AttributeConstraint attributeConstraint = schemaTypeData.AttributeConstraints[attriuteIndex];
        if (attributeConstraint.SupportedVersion.Includes(validationContext.FileFormat))
        {
          switch (attributeConstraint.XsdAttributeUse)
          {
            case XsdAttributeUse.Required:
              if (element.Attributes[attriuteIndex] == null)
              {
                string str = element.GetFixedAttributeQname(attriuteIndex).ToString();
                ValidationErrorInfo error = validationContext.ComposeSchemaValidationError(element, (OpenXmlElement) null, "Sch_MissRequiredAttribute", str);
                validationContext.EmitError(error);
                break;
              }
              break;
          }
          if (element.Attributes[attriuteIndex] != null)
          {
            OpenXmlSimpleType attribute = element.Attributes[attriuteIndex];
            string qname = element.GetFixedAttributeQname(attriuteIndex).ToString();
            SchemaTypeValidator.ValidateValue(validationContext, attributeConstraint.SimpleTypeConstraint, attribute, qname, true);
          }
        }
        else if (element.Attributes[attriuteIndex] != null && !validationContext.McContext.IsIgnorableNs(element.AttributeNamespaceIds[attriuteIndex]))
        {
          string str = element.GetFixedAttributeQname(attriuteIndex).ToString();
          ValidationErrorInfo error = validationContext.ComposeSchemaValidationError(element, (OpenXmlElement) null, "Sch_UndeclaredAttribute", str);
          validationContext.EmitError(error);
        }
      }
      foreach (OpenXmlAttribute extendedAttribute in element.ExtendedAttributes)
      {
        if (!validationContext.McContext.IsIgnorableNs(extendedAttribute.NamespaceUri) && !("http://www.w3.org/XML/1998/namespace" == extendedAttribute.NamespaceUri))
        {
          string str = extendedAttribute.XmlQualifiedName.ToString();
          ValidationErrorInfo error = validationContext.ComposeSchemaValidationError(element, (OpenXmlElement) null, "Sch_UndeclaredAttribute", str);
          validationContext.EmitError(error);
        }
      }
    }

    internal static void ValidateValue(ValidationContext validationContext, SimpleTypeRestriction simpleTypeConstraint, OpenXmlSimpleType value, string qname, bool isAttribute)
    {
      OpenXmlElement element = validationContext.Element;
      RedirectedRestriction redirectedRestriction = simpleTypeConstraint as RedirectedRestriction;
      if (redirectedRestriction != null)
      {
        OpenXmlSimpleType openXmlSimpleType = redirectedRestriction.ConvertValue(value);
        SchemaTypeValidator.ValidateValue(validationContext, redirectedRestriction.TargetRestriction, openXmlSimpleType, qname, isAttribute);
      }
      else
      {
        string messageId = !isAttribute ? "Sch_ElementValueDataTypeDetailed" : "Sch_AttributeValueDataTypeDetailed";
        if (!simpleTypeConstraint.ValidateValueType(value))
        {
          ValidationErrorInfo error;
          if (simpleTypeConstraint.IsEnum)
            error = validationContext.ComposeSchemaValidationError(element, (OpenXmlElement) null, messageId, qname, value.InnerText, ValidationResources.Sch_EnumerationConstraintFailed);
          else if (simpleTypeConstraint.XsdType == XsdType.Union)
            error = validationContext.ComposeSchemaValidationError(element, (OpenXmlElement) null, isAttribute ? "Sch_AttributeUnionFailedEx" : "Sch_ElementUnionFailedEx", qname, value.InnerText);
          else if (string.IsNullOrEmpty(value.InnerText))
            error = validationContext.ComposeSchemaValidationError(element, (OpenXmlElement) null, messageId, qname, value.InnerText, isAttribute ? ValidationResources.Sch_EmptyAttributeValue : ValidationResources.Sch_EmptyElementValue);
          else if (simpleTypeConstraint.XsdType == XsdType.SpecialBoolean)
            error = validationContext.ComposeSchemaValidationError(element, (OpenXmlElement) null, messageId, qname, value.InnerText, ValidationResources.Sch_EnumerationConstraintFailed);
          else if (simpleTypeConstraint.IsList)
          {
            error = validationContext.ComposeSchemaValidationError(element, (OpenXmlElement) null, messageId, qname, value.InnerText, string.Empty);
          }
          else
          {
            string str = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Sch_StringIsNotValidValue, new object[2]
            {
              (object) value.InnerText,
              (object) simpleTypeConstraint.ClrTypeName
            });
            error = validationContext.ComposeSchemaValidationError(element, (OpenXmlElement) null, messageId, qname, value.InnerText, str);
          }
          validationContext.EmitError(error);
        }
        else
        {
          bool flag = true;
          switch (simpleTypeConstraint.XsdType)
          {
            case XsdType.Boolean:
            case XsdType.DateTime:
            case XsdType.Enum:
            case XsdType.SpecialBoolean:
              flag = false;
              break;
            case XsdType.List:
              flag = false;
              break;
            case XsdType.Union:
              flag = false;
              break;
          }
          if (!flag)
            return;
          RestrictionField restrictionField = simpleTypeConstraint.Validate(value);
          if (restrictionField == RestrictionField.None)
            return;
          if ((restrictionField & RestrictionField.MinInclusive) == RestrictionField.MinInclusive)
          {
            string str = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Sch_MinInclusiveConstraintFailed, new object[1]
            {
              (object) simpleTypeConstraint.GetRestrictionValue(RestrictionField.MinInclusive)
            });
            ValidationErrorInfo error = validationContext.ComposeSchemaValidationError(element, (OpenXmlElement) null, messageId, qname, value.InnerText, str);
            validationContext.EmitError(error);
          }
          if ((restrictionField & RestrictionField.MinExclusive) == RestrictionField.MinExclusive)
          {
            string str = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Sch_MinExclusiveConstraintFailed, new object[1]
            {
              (object) simpleTypeConstraint.GetRestrictionValue(RestrictionField.MinExclusive)
            });
            ValidationErrorInfo error = validationContext.ComposeSchemaValidationError(element, (OpenXmlElement) null, messageId, qname, value.InnerText, str);
            validationContext.EmitError(error);
          }
          if ((restrictionField & RestrictionField.MaxInclusive) == RestrictionField.MaxInclusive)
          {
            string str = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Sch_MaxInclusiveConstraintFailed, new object[1]
            {
              (object) simpleTypeConstraint.GetRestrictionValue(RestrictionField.MaxInclusive)
            });
            ValidationErrorInfo error = validationContext.ComposeSchemaValidationError(element, (OpenXmlElement) null, messageId, qname, value.InnerText, str);
            validationContext.EmitError(error);
          }
          if ((restrictionField & RestrictionField.MaxExclusive) == RestrictionField.MaxExclusive)
          {
            string str = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Sch_MaxExclusiveConstraintFailed, new object[1]
            {
              (object) simpleTypeConstraint.GetRestrictionValue(RestrictionField.MaxExclusive)
            });
            ValidationErrorInfo error = validationContext.ComposeSchemaValidationError(element, (OpenXmlElement) null, messageId, qname, value.InnerText, str);
            validationContext.EmitError(error);
          }
          if ((restrictionField & RestrictionField.Length) == RestrictionField.Length)
          {
            if (string.IsNullOrEmpty(value.InnerText))
            {
              ValidationErrorInfo error = validationContext.ComposeSchemaValidationError(element, (OpenXmlElement) null, messageId, qname, value.InnerText, isAttribute ? ValidationResources.Sch_EmptyAttributeValue : ValidationResources.Sch_EmptyElementValue);
              validationContext.EmitError(error);
            }
            else
            {
              string str = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Sch_LengthConstraintFailed, new object[2]
              {
                (object) simpleTypeConstraint.XsdType.GetXsdDataTypeName(),
                (object) simpleTypeConstraint.GetRestrictionValue(RestrictionField.Length)
              });
              ValidationErrorInfo error = validationContext.ComposeSchemaValidationError(element, (OpenXmlElement) null, messageId, qname, value.InnerText, str);
              validationContext.EmitError(error);
            }
          }
          if ((restrictionField & RestrictionField.MinLength) == RestrictionField.MinLength)
          {
            if (string.IsNullOrEmpty(value.InnerText))
            {
              ValidationErrorInfo error = validationContext.ComposeSchemaValidationError(element, (OpenXmlElement) null, messageId, qname, value.InnerText, isAttribute ? ValidationResources.Sch_EmptyAttributeValue : ValidationResources.Sch_EmptyElementValue);
              validationContext.EmitError(error);
            }
            else
            {
              string str = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Sch_MinLengthConstraintFailed, new object[2]
              {
                (object) simpleTypeConstraint.XsdType.GetXsdDataTypeName(),
                (object) simpleTypeConstraint.GetRestrictionValue(RestrictionField.MinLength)
              });
              ValidationErrorInfo error = validationContext.ComposeSchemaValidationError(element, (OpenXmlElement) null, messageId, qname, value.InnerText, str);
              validationContext.EmitError(error);
            }
          }
          if ((restrictionField & RestrictionField.MaxLength) == RestrictionField.MaxLength)
          {
            string str = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Sch_MaxLengthConstraintFailed, new object[2]
            {
              (object) simpleTypeConstraint.XsdType.GetXsdDataTypeName(),
              (object) simpleTypeConstraint.GetRestrictionValue(RestrictionField.MaxLength)
            });
            ValidationErrorInfo error = validationContext.ComposeSchemaValidationError(element, (OpenXmlElement) null, messageId, qname, value.InnerText, str);
            validationContext.EmitError(error);
          }
          if ((restrictionField & RestrictionField.Pattern) != RestrictionField.Pattern)
            return;
          string str1 = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Sch_PatternConstraintFailed, new object[1]
          {
            (object) simpleTypeConstraint.GetRestrictionValue(RestrictionField.Pattern)
          });
          ValidationErrorInfo error1 = validationContext.ComposeSchemaValidationError(element, (OpenXmlElement) null, messageId, qname, value.InnerText, str1);
          validationContext.EmitError(error1);
        }
      }
    }

    private static class EmptyComplexTypeValidator
    {
      internal static void Validate(ValidationContext validationContext)
      {
        OpenXmlLeafElement element = (OpenXmlLeafElement) validationContext.Element;
        if (element.ShadowElement == null)
          return;
        foreach (OpenXmlElement childElement in element.ShadowElement.ChildElements)
        {
          if (!(childElement is OpenXmlMiscNode))
          {
            ValidationErrorInfo error = validationContext.ComposeSchemaValidationError((OpenXmlElement) element, (OpenXmlElement) null, "Sch_InvalidChildinLeafElement", element.XmlQualifiedName.ToString());
            validationContext.EmitError(error);
            break;
          }
        }
      }
    }

    private static class EmptyRootComplexTypeValidator
    {
      internal static void Validate(ValidationContext validationContext)
      {
        OpenXmlCompositeElement element = (OpenXmlCompositeElement) validationContext.Element;
        foreach (OpenXmlElement childElement in element.ChildElements)
        {
          if (!(childElement is OpenXmlMiscNode))
          {
            ValidationErrorInfo error = validationContext.ComposeSchemaValidationError((OpenXmlElement) element, (OpenXmlElement) null, "Sch_InvalidChildinLeafElement", element.XmlQualifiedName.ToString());
            validationContext.EmitError(error);
            break;
          }
        }
      }
    }

    private static class SimpleContentComplexTypeValidator
    {
      internal static void Validate(ValidationContext validationContext, SimpleTypeRestriction simpleTypeConstraint)
      {
        SchemaTypeValidator.EmptyComplexTypeValidator.Validate(validationContext);
        OpenXmlLeafTextElement element = (OpenXmlLeafTextElement) validationContext.Element;
        OpenXmlSimpleType openXmlSimpleType = element.InnerTextToValue(element.Text);
        string qname = element.XmlQualifiedName.ToString();
        SchemaTypeValidator.ValidateValue(validationContext, simpleTypeConstraint, openXmlSimpleType, qname, false);
      }
    }

    private static class CompositeComplexTypeValidator
    {
      internal static void Validate(ValidationContext validationContext, ParticleConstraint particleConstraint)
      {
        switch (particleConstraint.ParticleType)
        {
          case ParticleType.All:
          case ParticleType.Choice:
          case ParticleType.Group:
          case ParticleType.Sequence:
            ((ParticleValidator) particleConstraint.ParticleValidator).Validate(validationContext);
            break;
        }
      }
    }
  }
}

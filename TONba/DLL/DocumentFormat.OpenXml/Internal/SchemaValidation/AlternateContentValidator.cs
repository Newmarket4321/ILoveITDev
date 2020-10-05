// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.AlternateContentValidator
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Validation;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  internal class AlternateContentValidator
  {
    internal static void Validate(ValidationContext validationContext)
    {
      AlternateContent element = (AlternateContent) validationContext.Element;
      AlternateContentValidator.ValidateMcAttributesOnAcb(validationContext, (OpenXmlElement) element);
      int num = 0;
      if (element.ChildElements.Count == 0)
      {
        ValidationErrorInfo error = validationContext.ComposeMcValidationError((OpenXmlElement) element, "Sch_IncompleteContentExpectingComplex", ValidationResources.MC_ShallContainChoice);
        validationContext.EmitError(error);
      }
      for (OpenXmlElement acElement = element.GetFirstNonMiscElementChild(); acElement != null; acElement = acElement.GetNextNonMiscElementSibling())
      {
        if (acElement is AlternateContent)
        {
          ValidationErrorInfo error = validationContext.ComposeMcValidationError((OpenXmlElement) element, "Sch_InvalidElementContentExpectingComplex", acElement.XmlQualifiedName.ToString(), ValidationResources.MC_ShallNotContainAlternateContent);
          validationContext.EmitError(error);
        }
        else
        {
          switch (num)
          {
            case 0:
              if (acElement is AlternateContentChoice)
              {
                AlternateContentValidator.ValidateMcAttributesOnAcb(validationContext, acElement);
                num = 1;
                continue;
              }
              ValidationErrorInfo error1 = validationContext.ComposeMcValidationError((OpenXmlElement) element, "Sch_IncompleteContentExpectingComplex", ValidationResources.MC_ShallContainChoice);
              validationContext.EmitError(error1);
              if (acElement is AlternateContentFallback)
              {
                AlternateContentValidator.ValidateMcAttributesOnAcb(validationContext, acElement);
                continue;
              }
              continue;
            case 1:
              if (acElement is AlternateContentChoice)
              {
                AlternateContentValidator.ValidateMcAttributesOnAcb(validationContext, acElement);
                num = 1;
                continue;
              }
              if (acElement is AlternateContentFallback)
              {
                AlternateContentValidator.ValidateMcAttributesOnAcb(validationContext, acElement);
                num = 2;
                continue;
              }
              ValidationErrorInfo error2 = validationContext.ComposeMcValidationError((OpenXmlElement) element, "Sch_InvalidElementContentExpectingComplex", acElement.XmlQualifiedName.ToString(), ValidationResources.MC_ShallContainChoice);
              validationContext.EmitError(error2);
              continue;
            case 2:
              ValidationErrorInfo error3 = validationContext.ComposeMcValidationError((OpenXmlElement) element, "Sch_InvalidElementContentExpectingComplex", acElement.XmlQualifiedName.ToString(), ValidationResources.MC_ShallContainChoice);
              validationContext.EmitError(error3);
              continue;
            default:
              continue;
          }
        }
      }
    }

    private static void ValidateMcAttributesOnAcb(ValidationContext validationContext, OpenXmlElement acElement)
    {
      if (acElement.ExtendedAttributes != null)
      {
        foreach (OpenXmlAttribute extendedAttribute in acElement.ExtendedAttributes)
        {
          if (string.IsNullOrEmpty(extendedAttribute.Prefix))
          {
            ValidationErrorInfo error = validationContext.ComposeMcValidationError(acElement, ValidationResources.MC_ErrorOnUnprefixedAttributeName, extendedAttribute.XmlQualifiedName.ToString());
            validationContext.EmitError(error);
          }
          if (AlternateContentValidator.IsXmlSpaceOrXmlLangAttribue(extendedAttribute))
          {
            ValidationErrorInfo error = validationContext.ComposeMcValidationError(acElement, "MC_InvalidXmlAttribute", acElement.LocalName);
            validationContext.EmitError(error);
          }
        }
      }
      CompatibilityRuleAttributesValidator.ValidateMcAttributes(validationContext);
      AlternateContentChoice alternateContentChoice = acElement as AlternateContentChoice;
      if (alternateContentChoice == null)
        return;
      if (alternateContentChoice.Requires == null)
      {
        ValidationErrorInfo error = validationContext.ComposeMcValidationError(acElement, "MC_MissedRequiresAttribute");
        validationContext.EmitError(error);
      }
      else
      {
        ListValue<StringValue> listValue = new ListValue<StringValue>();
        listValue.InnerText = (string) alternateContentChoice.Requires;
        foreach (StringValue stringValue in (IEnumerable<StringValue>) listValue.Items)
        {
          if (string.IsNullOrEmpty(alternateContentChoice.LookupNamespace((string) stringValue)))
          {
            ValidationErrorInfo error = validationContext.ComposeMcValidationError((OpenXmlElement) alternateContentChoice, "MC_InvalidRequiresAttribute", (string) alternateContentChoice.Requires);
            validationContext.EmitError(error);
          }
        }
      }
    }

    internal static bool IsXmlSpaceOrXmlLangAttribue(OpenXmlAttribute attribute)
    {
      return "http://www.w3.org/XML/1998/namespace" == attribute.NamespaceUri && (attribute.LocalName == "space" || attribute.LocalName == "lang");
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.CompatibilityRuleAttributesValidator
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Validation;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  internal static class CompatibilityRuleAttributesValidator
  {
    internal static void ValidateMcAttributes(ValidationContext validationContext)
    {
      OpenXmlElement element = validationContext.Element;
      if (element.MCAttributes == null)
        return;
      HashSet<string> ignorableNamespaces = (HashSet<string>) null;
      if (element.MCAttributes == null)
        return;
      if (!string.IsNullOrEmpty((string) element.MCAttributes.Ignorable))
      {
        ignorableNamespaces = new HashSet<string>();
        ListValue<StringValue> listValue = new ListValue<StringValue>();
        listValue.InnerText = (string) element.MCAttributes.Ignorable;
        foreach (StringValue stringValue in (IEnumerable<StringValue>) listValue.Items)
        {
          string str = element.LookupNamespace((string) stringValue);
          if (string.IsNullOrEmpty(str))
          {
            ValidationErrorInfo error = validationContext.ComposeMcValidationError(element, "MC_InvalidIgnorableAttribute", (string) element.MCAttributes.Ignorable);
            validationContext.EmitError(error);
          }
          else
            ignorableNamespaces.Add(str);
        }
      }
      if (!string.IsNullOrEmpty((string) element.MCAttributes.PreserveAttributes))
      {
        if (ignorableNamespaces == null)
        {
          ValidationErrorInfo error = validationContext.ComposeMcValidationError(element, "MC_InvalidPreserveAttributesAttribute", (string) element.MCAttributes.PreserveAttributes);
          validationContext.EmitError(error);
        }
        else if (!string.IsNullOrEmpty(CompatibilityRuleAttributesValidator.ValidateQNameList((string) element.MCAttributes.PreserveAttributes, ignorableNamespaces, validationContext)))
        {
          ValidationErrorInfo error = validationContext.ComposeMcValidationError(element, "MC_InvalidPreserveAttributesAttribute", (string) element.MCAttributes.PreserveAttributes);
          validationContext.EmitError(error);
        }
      }
      if (!string.IsNullOrEmpty((string) element.MCAttributes.PreserveElements))
      {
        if (ignorableNamespaces == null)
        {
          ValidationErrorInfo error = validationContext.ComposeMcValidationError(element, "MC_InvalidPreserveElementsAttribute", (string) element.MCAttributes.PreserveElements);
          validationContext.EmitError(error);
        }
        else if (!string.IsNullOrEmpty(CompatibilityRuleAttributesValidator.ValidateQNameList((string) element.MCAttributes.PreserveElements, ignorableNamespaces, validationContext)))
        {
          ValidationErrorInfo error = validationContext.ComposeMcValidationError(element, "MC_InvalidPreserveElementsAttribute", (string) element.MCAttributes.PreserveElements);
          validationContext.EmitError(error);
        }
      }
      if (!string.IsNullOrEmpty((string) element.MCAttributes.ProcessContent))
      {
        if (ignorableNamespaces == null)
        {
          ValidationErrorInfo error = validationContext.ComposeMcValidationError(element, "MC_InvalidProcessContentAttribute", (string) element.MCAttributes.ProcessContent);
          validationContext.EmitError(error);
        }
        else if (!string.IsNullOrEmpty(CompatibilityRuleAttributesValidator.ValidateQNameList((string) element.MCAttributes.ProcessContent, ignorableNamespaces, validationContext)))
        {
          ValidationErrorInfo error = validationContext.ComposeMcValidationError(element, "MC_InvalidProcessContentAttribute", (string) element.MCAttributes.ProcessContent);
          validationContext.EmitError(error);
        }
        foreach (OpenXmlAttribute extendedAttribute in element.ExtendedAttributes)
        {
          if (AlternateContentValidator.IsXmlSpaceOrXmlLangAttribue(extendedAttribute))
          {
            ValidationErrorInfo error = validationContext.ComposeMcValidationError(element, "MC_InvalidXmlAttributeWithProcessContent");
            validationContext.EmitError(error);
          }
        }
      }
      if (string.IsNullOrEmpty((string) element.MCAttributes.MustUnderstand))
        return;
      ListValue<StringValue> listValue1 = new ListValue<StringValue>();
      listValue1.InnerText = (string) element.MCAttributes.MustUnderstand;
      foreach (StringValue stringValue in (IEnumerable<StringValue>) listValue1.Items)
      {
        if (string.IsNullOrEmpty(element.LookupNamespace((string) stringValue)))
        {
          ValidationErrorInfo error = validationContext.ComposeMcValidationError(element, "MC_InvalidMustUnderstandAttribute", (string) element.MCAttributes.MustUnderstand);
          validationContext.EmitError(error);
        }
      }
    }

    internal static string ValidateQNameList(string qnameList, HashSet<string> ignorableNamespaces, ValidationContext validationContext)
    {
      ListValue<StringValue> listValue = new ListValue<StringValue>();
      listValue.InnerText = qnameList;
      foreach (StringValue stringValue in (IEnumerable<StringValue>) listValue.Items)
      {
        string[] strArray = stringValue.Value.Split(':');
        if (strArray.Length != 2)
          return (string) stringValue;
        string str = validationContext.Element.LookupNamespace(strArray[0]);
        if (string.IsNullOrEmpty(str))
          return (string) stringValue;
        if (!ignorableNamespaces.Contains(str))
          return (string) stringValue;
      }
      return (string) null;
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Validation.ValidationTraverser
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

namespace DocumentFormat.OpenXml.Validation
{
  internal static class ValidationTraverser
  {
    internal static void ValidatingTraverse(ValidationContext validationContext, ValidationTraverser.ValidationAction validateAction, ValidationTraverser.ValidationAction finishAction, ValidationTraverser.GetStopSignal getStopSignal)
    {
      if (getStopSignal != null && getStopSignal(validationContext))
        return;
      OpenXmlElement element = validationContext.Element;
      bool flag = false;
      validationContext.McContext.PushMCAttributes2(element.MCAttributes, (MCContext.LookupNamespace) (prefix => element.LookupNamespace(prefix)));
      if (element.IsStrongTypedElement())
      {
        if (element.IsInVersion(validationContext.FileFormat))
        {
          validateAction(validationContext);
          flag = true;
        }
        else
          validationContext.McContext.IsProcessContent(element);
        foreach (OpenXmlElement childElement in element.ChildElements)
        {
          validationContext.Element = childElement;
          ValidationTraverser.ValidatingTraverse(validationContext, validateAction, finishAction, getStopSignal);
        }
      }
      else if (element.ElementTypeId == 9002 || element.ElementTypeId == 9002)
      {
        if (validationContext.McContext.IsProcessContent(element))
        {
          foreach (OpenXmlElement childElement in element.ChildElements)
          {
            validationContext.Element = childElement;
            ValidationTraverser.ValidatingTraverse(validationContext, validateAction, finishAction, getStopSignal);
          }
        }
      }
      else if (element.ElementTypeId == 9003)
      {
        validateAction(validationContext);
        flag = true;
        OpenXmlCompositeElement contentFromAcBlock = validationContext.McContext.GetContentFromACBlock((AlternateContent) element, validationContext.FileFormat);
        if (contentFromAcBlock != null)
        {
          foreach (OpenXmlElement childElement in contentFromAcBlock.ChildElements)
          {
            validationContext.Element = childElement;
            ValidationTraverser.ValidatingTraverse(validationContext, validateAction, finishAction, getStopSignal);
          }
        }
      }
      else
      {
        int elementTypeId = element.ElementTypeId;
      }
      validationContext.McContext.PopMCAttributes2();
      if (!flag || finishAction == null)
        return;
      validationContext.Element = element;
      finishAction(validationContext);
    }

    internal delegate void ValidationAction(ValidationContext validationContext);

    internal delegate bool GetStopSignal(ValidationContext validationContext);
  }
}

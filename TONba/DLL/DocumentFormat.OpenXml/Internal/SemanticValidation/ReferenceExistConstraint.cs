// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SemanticValidation.ReferenceExistConstraint
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace DocumentFormat.OpenXml.Internal.SemanticValidation
{
  internal class ReferenceExistConstraint : SemanticConstraint
  {
    private byte _refAttribute;
    private string _partPath;
    private int _element;
    private string _elementName;
    private byte _attribute;
    private List<string> _referencedAttributes;
    private OpenXmlPart _relatedPart;

    public ReferenceExistConstraint(byte refAttribute, string part, int element, string elementName, byte attribute)
      : base(SemanticValidationLevel.PackageOnly)
    {
      this._refAttribute = refAttribute;
      this._partPath = part;
      this._element = element;
      this._elementName = elementName;
      this._attribute = attribute;
    }

    public override SemanticValidationLevel StateScope
    {
      get
      {
        return SemanticValidationLevel.Part;
      }
    }

    public override ValidationErrorInfo Validate(ValidationContext context)
    {
      OpenXmlSimpleType attribute = context.Element.Attributes[(int) this._refAttribute];
      if (attribute == null || string.IsNullOrEmpty(attribute.InnerText))
        return (ValidationErrorInfo) null;
      if (this.GetReferencedAttributes(context).Contains(attribute.InnerText))
        return (ValidationErrorInfo) null;
      return new ValidationErrorInfo()
      {
        Id = "Sem_MissingReferenceElement",
        ErrorType = ValidationErrorType.Semantic,
        Node = context.Element,
        RelatedPart = this._relatedPart,
        RelatedNode = (OpenXmlElement) null,
        Description = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Sem_MissingReferenceElement, (object) this._elementName, (object) context.Element.LocalName, (object) SemanticConstraint.GetAttributeQualifiedName(context.Element, this._refAttribute), this._relatedPart == null ? (object) this._partPath : (object) this._relatedPart.PackagePart.Uri.ToString(), (object) attribute.InnerText)
      };
    }

    public override void ClearState(ValidationContext context)
    {
      this._referencedAttributes = (List<string>) null;
    }

    private List<string> GetReferencedAttributes(ValidationContext context)
    {
      if (this._referencedAttributes == null)
      {
        this._referencedAttributes = new List<string>();
        OpenXmlPart referencedPart = SemanticConstraint.GetReferencedPart(context, this._partPath);
        this._relatedPart = referencedPart;
        if (referencedPart != null)
          ValidationTraverser.ValidatingTraverse(new ValidationContext()
          {
            FileFormat = context.FileFormat,
            Package = context.Package,
            Part = referencedPart,
            Element = (OpenXmlElement) referencedPart.RootElement
          }, new ValidationTraverser.ValidationAction(this.ElementTraverse), (ValidationTraverser.ValidationAction) null, (ValidationTraverser.GetStopSignal) null);
      }
      return this._referencedAttributes;
    }

    private void ElementTraverse(ValidationContext context)
    {
      if (context.Element.ElementTypeId != this._element)
        return;
      OpenXmlSimpleType attribute = context.Element.Attributes[(int) this._attribute];
      if (attribute == null || string.IsNullOrEmpty(attribute.InnerText))
        return;
      this._referencedAttributes.Add(attribute.InnerText);
    }
  }
}

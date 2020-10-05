// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SemanticValidation.IndexReferenceConstraint
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation;
using System;
using System.Globalization;

namespace DocumentFormat.OpenXml.Internal.SemanticValidation
{
  internal class IndexReferenceConstraint : SemanticConstraint
  {
    private int _refElementCount = -1;
    private byte _attribute;
    private string _refPartType;
    private int _refElementParent;
    private int _refElement;
    private string _refElementName;
    private int _indexBase;
    private OpenXmlPart _relatedPart;
    private bool _startCollect;

    public IndexReferenceConstraint(byte attribute, string referencedPart, int referencedElementParent, int referencedElement, string referencedElementName, int indexBase)
      : base(SemanticValidationLevel.PackageOnly)
    {
      this._attribute = attribute;
      this._refPartType = referencedPart;
      this._refElement = referencedElement;
      this._refElementParent = referencedElementParent;
      this._refElementName = referencedElementName;
      this._indexBase = indexBase;
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
      OpenXmlSimpleType attribute = context.Element.Attributes[(int) this._attribute];
      if (attribute == null || string.IsNullOrEmpty(attribute.InnerText))
        return (ValidationErrorInfo) null;
      int result;
      if (!int.TryParse((string) attribute, out result))
        return (ValidationErrorInfo) null;
      if (result < this.GetRefElementCount(context) + this._indexBase)
        return (ValidationErrorInfo) null;
      return new ValidationErrorInfo()
      {
        Id = "Sem_MissingIndexedElement",
        ErrorType = ValidationErrorType.Semantic,
        Node = context.Element,
        RelatedPart = this._relatedPart,
        RelatedNode = (OpenXmlElement) null,
        Description = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Sem_MissingIndexedElement, (object) this._refElementName, (object) context.Element.LocalName, (object) SemanticConstraint.GetAttributeQualifiedName(context.Element, this._attribute), this._relatedPart == null ? (object) this._refPartType : (object) this._relatedPart.PackagePart.Uri.ToString(), (object) result)
      };
    }

    public override void ClearState(ValidationContext context)
    {
      this._refElementCount = -1;
      this._startCollect = false;
    }

    private int GetRefElementCount(ValidationContext context)
    {
      if (this._refElementCount != -1)
        return this._refElementCount;
      this._refElementCount = 0;
      OpenXmlPart referencedPart = SemanticConstraint.GetReferencedPart(context, this._refPartType);
      if (referencedPart != null)
      {
        this._relatedPart = referencedPart;
        ValidationContext validationContext = new ValidationContext();
        validationContext.FileFormat = context.FileFormat;
        validationContext.Package = context.Package;
        validationContext.Part = referencedPart;
        validationContext.Element = (OpenXmlElement) referencedPart.RootElement;
        if (this._refElementParent == -1)
        {
          this._startCollect = true;
          ValidationTraverser.ValidatingTraverse(validationContext, new ValidationTraverser.ValidationAction(this.ElementTraverseStart), (ValidationTraverser.ValidationAction) null, (ValidationTraverser.GetStopSignal) null);
        }
        else
          ValidationTraverser.ValidatingTraverse(validationContext, new ValidationTraverser.ValidationAction(this.ElementTraverseStart), new ValidationTraverser.ValidationAction(this.ElementTraverseEnd), (ValidationTraverser.GetStopSignal) null);
      }
      return this._refElementCount;
    }

    private void ElementTraverseStart(ValidationContext context)
    {
      if (!this._startCollect)
      {
        this._startCollect = context.Element.ElementTypeId == this._refElementParent;
      }
      else
      {
        if (context.Element.ElementTypeId != this._refElement)
          return;
        ++this._refElementCount;
      }
    }

    private void ElementTraverseEnd(ValidationContext context)
    {
      if (!this._startCollect || context.Element.ElementTypeId != this._refElementParent)
        return;
      this._startCollect = false;
    }
  }
}

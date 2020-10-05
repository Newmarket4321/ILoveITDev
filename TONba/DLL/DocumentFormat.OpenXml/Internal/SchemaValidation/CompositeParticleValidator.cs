// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.CompositeParticleValidator
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Validation;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  internal abstract class CompositeParticleValidator : ParticleValidator
  {
    private ParticleMatchInfo _childMatchInfo = new ParticleMatchInfo();
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ParticleConstraint _particleConstraint;
    private ParticleMatchInfo _particleMatchInfo;

    protected ParticleConstraint ParticleConstraint
    {
      get
      {
        return this._particleConstraint;
      }
    }

    internal CompositeParticleValidator(ParticleConstraint particleConstraint)
    {
      this._particleConstraint = particleConstraint;
    }

    internal override void Validate(ValidationContext validationContext)
    {
      OpenXmlCompositeElement element = validationContext.Element as OpenXmlCompositeElement;
      OpenXmlElement firstChildMc = validationContext.GetFirstChildMc();
      if (firstChildMc == null)
      {
        if (this.ParticleConstraint.MinOccurs == 0)
          return;
        ExpectedChildren requiredElements = this.GetRequiredElements();
        if (requiredElements.Count <= 0)
          return;
        ValidationErrorInfo error = validationContext.ComposeSchemaValidationError((OpenXmlElement) element, (OpenXmlElement) null, "Sch_IncompleteContentExpectingComplex", ParticleValidator.GetExpectedChildrenMessage((OpenXmlElement) element, requiredElements));
        validationContext.EmitError(error);
      }
      else
      {
        if (this._particleMatchInfo == null)
          this._particleMatchInfo = new ParticleMatchInfo(firstChildMc);
        else
          this._particleMatchInfo.Reset(firstChildMc);
        this.TryMatch(this._particleMatchInfo, validationContext);
        switch (this._particleMatchInfo.Match)
        {
          case ParticleMatch.Nomatch:
            this.EmitInvalidElementError(validationContext, this._particleMatchInfo);
            break;
          case ParticleMatch.Partial:
            this.EmitInvalidElementError(validationContext, this._particleMatchInfo);
            break;
          case ParticleMatch.Matched:
            if (validationContext.GetNextChildMc(this._particleMatchInfo.LastMatchedElement) == null)
              break;
            this.EmitInvalidElementError(validationContext, this._particleMatchInfo);
            break;
        }
      }
    }

    public override void TryMatch(ParticleMatchInfo particleMatchInfo, ValidationContext validationContext)
    {
      if (this.ParticleConstraint.MaxOccurs == 1)
      {
        this.TryMatchOnce(particleMatchInfo, validationContext);
      }
      else
      {
        int count = 0;
        for (OpenXmlElement startElement = particleMatchInfo.StartElement; startElement != null && this.ParticleConstraint.MaxOccursGreaterThan(count); startElement = validationContext.GetNextChildMc(particleMatchInfo.LastMatchedElement))
        {
          this._childMatchInfo.Reset(startElement);
          this.TryMatchOnce(this._childMatchInfo, validationContext);
          if (this._childMatchInfo.Match != ParticleMatch.Nomatch)
          {
            if (this._childMatchInfo.Match == ParticleMatch.Matched)
            {
              ++count;
              particleMatchInfo.LastMatchedElement = this._childMatchInfo.LastMatchedElement;
            }
            else
            {
              particleMatchInfo.Match = ParticleMatch.Partial;
              particleMatchInfo.LastMatchedElement = this._childMatchInfo.LastMatchedElement;
              if (!validationContext.CollectExpectedChildren)
                return;
              particleMatchInfo.SetExpectedChildren(this._childMatchInfo.ExpectedChildren);
              return;
            }
          }
          else
            break;
        }
        if (count == 0)
        {
          particleMatchInfo.Match = ParticleMatch.Nomatch;
          if (!validationContext.CollectExpectedChildren)
            return;
          particleMatchInfo.SetExpectedChildren(this.GetExpectedElements());
        }
        else if (count >= this.ParticleConstraint.MinOccurs)
          particleMatchInfo.Match = ParticleMatch.Matched;
        else if (this.GetRequiredElements(particleMatchInfo.ExpectedChildren))
          particleMatchInfo.Match = ParticleMatch.Partial;
        else
          particleMatchInfo.Match = ParticleMatch.Matched;
      }
    }

    public override bool GetRequiredElements(ExpectedChildren result)
    {
      bool flag = false;
      if (this._particleConstraint.MinOccurs > 0)
      {
        foreach (ParticleConstraint childrenParticle in this._particleConstraint.ChildrenParticles)
        {
          if (childrenParticle.ParticleValidator.GetRequiredElements(result))
            flag = true;
        }
      }
      return flag;
    }

    public override bool GetExpectedElements(ExpectedChildren result)
    {
      foreach (ParticleConstraint childrenParticle in this.ParticleConstraint.ChildrenParticles)
        childrenParticle.ParticleValidator.GetExpectedElements(result);
      return true;
    }

    protected virtual void EmitInvalidElementError(ValidationContext validationContext, ParticleMatchInfo particleMatchInfo)
    {
      if (particleMatchInfo.Match != ParticleMatch.Nomatch)
      {
        OpenXmlElement firstChildMc = validationContext.GetFirstChildMc();
        validationContext.CollectExpectedChildren = true;
        particleMatchInfo.Reset(firstChildMc);
        particleMatchInfo.InitExpectedChildren();
        this.TryMatch(particleMatchInfo, validationContext);
        validationContext.CollectExpectedChildren = false;
      }
      OpenXmlElement element = validationContext.Element;
      OpenXmlElement child = particleMatchInfo.LastMatchedElement != null ? validationContext.GetNextChildMc(particleMatchInfo.LastMatchedElement) : validationContext.GetFirstChildMc();
      string str = (string) null;
      switch (particleMatchInfo.Match)
      {
        case ParticleMatch.Nomatch:
          str = ParticleValidator.GetExpectedChildrenMessage(validationContext.Element, this.GetExpectedElements());
          break;
        case ParticleMatch.Partial:
          if (child == null)
          {
            ValidationErrorInfo error = validationContext.ComposeSchemaValidationError(element, (OpenXmlElement) null, "Sch_IncompleteContentExpectingComplex", ParticleValidator.GetExpectedChildrenMessage(element, particleMatchInfo.ExpectedChildren));
            validationContext.EmitError(error);
            return;
          }
          str = ParticleValidator.GetExpectedChildrenMessage(validationContext.Element, particleMatchInfo.ExpectedChildren);
          break;
        case ParticleMatch.Matched:
          str = !this.ParticleConstraint.CanOccursMoreThanOne ? ParticleValidator.GetExpectedChildrenMessage(validationContext.Element, particleMatchInfo.ExpectedChildren) : ParticleValidator.GetExpectedChildrenMessage(validationContext.Element, this.GetExpectedElements());
          break;
      }
      ValidationErrorInfo error1;
      if (validationContext.Element.CanContainsChild(child))
        error1 = validationContext.ComposeSchemaValidationError(element, child, "Sch_UnexpectedElementContentExpectingComplex", child.XmlQualifiedName.ToString(), str);
      else if (element.TryCreateValidChild(validationContext.FileFormat, child.NamespaceUri, child.LocalName) == null)
        error1 = validationContext.ComposeSchemaValidationError(element, child, "Sch_InvalidElementContentExpectingComplex", child.XmlQualifiedName.ToString(), str);
      else
        error1 = validationContext.ComposeSchemaValidationError(element, child, "Sch_InvalidElementContentWrongType", child.XmlQualifiedName.ToString(), child.GetType().Name);
      validationContext.EmitError(error1);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.AllParticleValidator
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Validation;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  internal class AllParticleValidator : CompositeParticleValidator
  {
    private Dictionary<int, bool> _childrenParticles;

    internal AllParticleValidator(CompositeParticle particleConstraint)
      : base((ParticleConstraint) particleConstraint)
    {
      this._childrenParticles = new Dictionary<int, bool>(this.ParticleConstraint.ChildrenParticles.Length);
      foreach (ParticleConstraint childrenParticle in this.ParticleConstraint.ChildrenParticles)
        this._childrenParticles.Add(childrenParticle.ElementId, false);
    }

    public override void TryMatch(ParticleMatchInfo particleMatchInfo, ValidationContext validationContext)
    {
      this.TryMatchOnce(particleMatchInfo, validationContext);
    }

    public override void TryMatchOnce(ParticleMatchInfo particleMatchInfo, ValidationContext validationContext)
    {
      OpenXmlElement child = particleMatchInfo.StartElement;
      particleMatchInfo.LastMatchedElement = (OpenXmlElement) null;
      particleMatchInfo.Match = ParticleMatch.Nomatch;
      foreach (ParticleConstraint childrenParticle in this.ParticleConstraint.ChildrenParticles)
        this._childrenParticles[childrenParticle.ElementId] = false;
      bool flag;
      for (; child != null && (this._childrenParticles.TryGetValue(child.ElementTypeId, out flag) && !flag); child = validationContext.GetNextChildMc(child))
      {
        this._childrenParticles[child.ElementTypeId] = true;
        particleMatchInfo.LastMatchedElement = child;
      }
      if (particleMatchInfo.ExpectedChildren == null)
        particleMatchInfo.InitExpectedChildren();
      if (particleMatchInfo.LastMatchedElement == null)
      {
        particleMatchInfo.Match = ParticleMatch.Nomatch;
        foreach (ParticleConstraint childrenParticle in this.ParticleConstraint.ChildrenParticles)
          particleMatchInfo.ExpectedChildren.Add(childrenParticle.ElementId);
      }
      else
      {
        particleMatchInfo.Match = ParticleMatch.Matched;
        foreach (ParticleConstraint childrenParticle in this.ParticleConstraint.ChildrenParticles)
        {
          if (!this._childrenParticles[childrenParticle.ElementId] && childrenParticle.MinOccurs == 1)
            particleMatchInfo.Match = ParticleMatch.Partial;
        }
        foreach (ParticleConstraint childrenParticle in this.ParticleConstraint.ChildrenParticles)
        {
          if (!this._childrenParticles[childrenParticle.ElementId])
            particleMatchInfo.ExpectedChildren.Add(childrenParticle.ElementId);
        }
      }
    }

    protected override void EmitInvalidElementError(ValidationContext validationContext, ParticleMatchInfo particleMatchInfo)
    {
      OpenXmlElement element = validationContext.Element;
      OpenXmlElement child = particleMatchInfo.LastMatchedElement != null ? validationContext.GetNextChildMc(particleMatchInfo.LastMatchedElement) : validationContext.GetFirstChildMc();
      switch (particleMatchInfo.Match)
      {
        case ParticleMatch.Nomatch:
          string expectedChildrenMessage1 = ParticleValidator.GetExpectedChildrenMessage(validationContext.Element, this.GetExpectedElements());
          ValidationErrorInfo error1 = validationContext.ComposeSchemaValidationError(element, child, "Sch_InvalidElementContentExpectingComplex", child.XmlQualifiedName.ToString(), expectedChildrenMessage1);
          validationContext.EmitError(error1);
          break;
        case ParticleMatch.Partial:
        case ParticleMatch.Matched:
          if (this._childrenParticles.ContainsKey(child.ElementTypeId))
          {
            ValidationErrorInfo error2 = validationContext.ComposeSchemaValidationError(element, child, "Sch_AllElement", child.XmlQualifiedName.ToString());
            validationContext.EmitError(error2);
            break;
          }
          string expectedChildrenMessage2 = ParticleValidator.GetExpectedChildrenMessage(validationContext.Element, particleMatchInfo.ExpectedChildren);
          ValidationErrorInfo error3 = validationContext.ComposeSchemaValidationError(element, child, "Sch_InvalidElementContentExpectingComplex", child.XmlQualifiedName.ToString(), expectedChildrenMessage2);
          validationContext.EmitError(error3);
          break;
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.ParticleValidator
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Validation;
using System;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  internal abstract class ParticleValidator : IParticleValidator
  {
    internal ParticleValidator()
    {
    }

    internal abstract void Validate(ValidationContext validationContext);

    public virtual void TryMatchOnce(ParticleMatchInfo particleMatchInfo, ValidationContext validationContext)
    {
      particleMatchInfo.Match = ParticleMatch.Nomatch;
    }

    public virtual void TryMatch(ParticleMatchInfo particleMatchInfo, ValidationContext validationContext)
    {
      particleMatchInfo.Match = ParticleMatch.Nomatch;
    }

    public virtual bool GetRequiredElements(ExpectedChildren result)
    {
      return false;
    }

    public ExpectedChildren GetRequiredElements()
    {
      ExpectedChildren result = new ExpectedChildren();
      this.GetRequiredElements(result);
      return result;
    }

    public virtual bool GetExpectedElements(ExpectedChildren result)
    {
      return false;
    }

    public ExpectedChildren GetExpectedElements()
    {
      ExpectedChildren result = new ExpectedChildren();
      this.GetExpectedElements(result);
      return result;
    }

    internal static ParticleValidator CreateParticleValidator(ParticleConstraint particleConstraint)
    {
      CompositeParticle particleConstraint1 = particleConstraint as CompositeParticle;
      switch (particleConstraint.ParticleType)
      {
        case ParticleType.All:
          return (ParticleValidator) new AllParticleValidator(particleConstraint1);
        case ParticleType.Choice:
          return (ParticleValidator) new ChoiceParticleValidator(particleConstraint1);
        case ParticleType.Group:
          return (ParticleValidator) new GroupParticleValidator(particleConstraint1);
        case ParticleType.Sequence:
          return (ParticleValidator) new SequenceParticleValidator(particleConstraint1);
        default:
          throw new InvalidOperationException();
      }
    }

    internal static string GetExpectedChildrenMessage(OpenXmlElement parent, ExpectedChildren expectedChildrenIds)
    {
      if (expectedChildrenIds != null)
        return expectedChildrenIds.GetExpectedChildrenMessage(parent);
      return string.Empty;
    }
  }
}

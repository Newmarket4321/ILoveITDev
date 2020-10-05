// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.SequenceParticleValidator
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Validation;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  internal class SequenceParticleValidator : CompositeParticleValidator
  {
    private ParticleMatchInfo _childMatchInfo = new ParticleMatchInfo();

    internal SequenceParticleValidator(CompositeParticle particleConstraint)
      : base((ParticleConstraint) particleConstraint)
    {
    }

    public override void TryMatchOnce(ParticleMatchInfo particleMatchInfo, ValidationContext validationContext)
    {
      OpenXmlElement startElement = particleMatchInfo.StartElement;
      particleMatchInfo.LastMatchedElement = (OpenXmlElement) null;
      particleMatchInfo.Match = ParticleMatch.Nomatch;
      int index = 0;
      int length = this.ParticleConstraint.ChildrenParticles.Length;
      while (index < length && startElement != null)
      {
        ParticleConstraint childrenParticle = this.ParticleConstraint.ChildrenParticles[index];
        this._childMatchInfo.Reset(startElement);
        childrenParticle.ParticleValidator.TryMatch(this._childMatchInfo, validationContext);
        switch (this._childMatchInfo.Match)
        {
          case ParticleMatch.Nomatch:
            if (childrenParticle.ParticleValidator.GetRequiredElements((ExpectedChildren) null))
            {
              if (validationContext.CollectExpectedChildren)
              {
                if (particleMatchInfo.ExpectedChildren == null)
                {
                  particleMatchInfo.SetExpectedChildren(childrenParticle.ParticleValidator.GetRequiredElements());
                }
                else
                {
                  particleMatchInfo.ExpectedChildren.Clear();
                  childrenParticle.ParticleValidator.GetRequiredElements(particleMatchInfo.ExpectedChildren);
                }
              }
              if (startElement == particleMatchInfo.StartElement)
              {
                particleMatchInfo.Match = ParticleMatch.Nomatch;
                particleMatchInfo.LastMatchedElement = (OpenXmlElement) null;
                return;
              }
              particleMatchInfo.Match = ParticleMatch.Partial;
              return;
            }
            ++index;
            continue;
          case ParticleMatch.Partial:
            particleMatchInfo.Match = ParticleMatch.Partial;
            particleMatchInfo.LastMatchedElement = this._childMatchInfo.LastMatchedElement;
            if (!validationContext.CollectExpectedChildren)
              return;
            particleMatchInfo.SetExpectedChildren(this._childMatchInfo.ExpectedChildren);
            return;
          case ParticleMatch.Matched:
            particleMatchInfo.LastMatchedElement = this._childMatchInfo.LastMatchedElement;
            startElement = validationContext.GetNextChildMc(particleMatchInfo.LastMatchedElement);
            ++index;
            continue;
          default:
            continue;
        }
      }
      if (index == length)
      {
        if (particleMatchInfo.LastMatchedElement != null)
          particleMatchInfo.Match = ParticleMatch.Matched;
        else
          particleMatchInfo.Match = ParticleMatch.Nomatch;
      }
      else
      {
        for (; index < length; ++index)
        {
          if (this.ParticleConstraint.ChildrenParticles[index].ParticleValidator.GetRequiredElements((ExpectedChildren) null))
          {
            if (validationContext.CollectExpectedChildren)
            {
              if (particleMatchInfo.ExpectedChildren == null)
                particleMatchInfo.InitExpectedChildren();
              this.ParticleConstraint.ChildrenParticles[index].ParticleValidator.GetRequiredElements(particleMatchInfo.ExpectedChildren);
            }
            particleMatchInfo.Match = ParticleMatch.Partial;
            return;
          }
        }
        particleMatchInfo.Match = ParticleMatch.Matched;
      }
    }

    public override bool GetRequiredElements(ExpectedChildren result)
    {
      bool flag = false;
      if (this.ParticleConstraint.MinOccurs > 0)
      {
        foreach (ParticleConstraint childrenParticle in this.ParticleConstraint.ChildrenParticles)
        {
          if (childrenParticle.ParticleValidator.GetRequiredElements(result))
          {
            flag = true;
            break;
          }
        }
      }
      return flag;
    }

    public override bool GetExpectedElements(ExpectedChildren result)
    {
      if (this.ParticleConstraint.ChildrenParticles.Length <= 0)
        return false;
      this.ParticleConstraint.ChildrenParticles[0].ParticleValidator.GetExpectedElements(result);
      return true;
    }
  }
}

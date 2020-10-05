// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.ChoiceParticleValidator
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Validation;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  internal class ChoiceParticleValidator : CompositeParticleValidator
  {
    private ParticleMatchInfo _childMatchInfo = new ParticleMatchInfo();

    internal ChoiceParticleValidator(CompositeParticle particleConstraint)
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
            particleMatchInfo.Match = ParticleMatch.Matched;
            particleMatchInfo.LastMatchedElement = this._childMatchInfo.LastMatchedElement;
            return;
          default:
            continue;
        }
      }
    }

    public override bool GetRequiredElements(ExpectedChildren result)
    {
      bool flag = true;
      ExpectedChildren expectedChildren = new ExpectedChildren();
      if (this.ParticleConstraint.MinOccurs <= 0)
        return false;
      foreach (ParticleConstraint childrenParticle in this.ParticleConstraint.ChildrenParticles)
      {
        if (!childrenParticle.ParticleValidator.GetRequiredElements(expectedChildren))
          flag = false;
      }
      if (flag && result != null)
        result.Add(expectedChildren);
      return flag;
    }
  }
}

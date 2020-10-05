// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.AnyParticleValidator
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Validation;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  internal class AnyParticleValidator : IParticleValidator
  {
    private AnyParticle _particleConstraint;

    internal virtual ParticleConstraint ParticleConstraint
    {
      get
      {
        return (ParticleConstraint) this._particleConstraint;
      }
    }

    protected AnyParticleValidator()
    {
    }

    internal AnyParticleValidator(AnyParticle particleConstraint)
    {
      this._particleConstraint = particleConstraint;
    }

    public virtual void TryMatchOnce(ParticleMatchInfo particleMatchInfo, ValidationContext validationContext)
    {
      OpenXmlElement startElement = particleMatchInfo.StartElement;
      switch (this._particleConstraint.NamespaceValue)
      {
        case 0:
          particleMatchInfo.Match = ParticleMatch.Matched;
          particleMatchInfo.LastMatchedElement = startElement;
          break;
        case 1:
          if (string.IsNullOrEmpty(startElement.NamespaceUri) || startElement.Parent != null && startElement.NamespaceUri != startElement.Parent.NamespaceUri)
          {
            particleMatchInfo.Match = ParticleMatch.Matched;
            particleMatchInfo.LastMatchedElement = startElement;
            break;
          }
          particleMatchInfo.Match = ParticleMatch.Nomatch;
          break;
        case 2:
          if (string.IsNullOrEmpty(startElement.NamespaceUri))
          {
            particleMatchInfo.Match = ParticleMatch.Matched;
            particleMatchInfo.LastMatchedElement = startElement;
            break;
          }
          particleMatchInfo.Match = ParticleMatch.Nomatch;
          break;
        case 3:
          if (startElement.Parent != null && startElement.NamespaceUri == startElement.Parent.NamespaceUri)
          {
            particleMatchInfo.Match = ParticleMatch.Matched;
            particleMatchInfo.LastMatchedElement = startElement;
            break;
          }
          particleMatchInfo.Match = ParticleMatch.Nomatch;
          break;
      }
    }

    public void TryMatch(ParticleMatchInfo particleMatchInfo, ValidationContext validationContext)
    {
      if (this.ParticleConstraint.MaxOccurs == 1)
      {
        this.TryMatchOnce(particleMatchInfo, validationContext);
      }
      else
      {
        int count = 0;
        OpenXmlElement startElement = particleMatchInfo.StartElement;
        while (startElement != null && this.ParticleConstraint.MaxOccursGreaterThan(count))
        {
          ParticleMatchInfo particleMatchInfo1 = new ParticleMatchInfo(startElement);
          this.TryMatchOnce(particleMatchInfo1, validationContext);
          if (particleMatchInfo1.Match != ParticleMatch.Nomatch)
          {
            if (particleMatchInfo1.Match == ParticleMatch.Matched)
            {
              ++count;
              particleMatchInfo.LastMatchedElement = particleMatchInfo1.LastMatchedElement;
              startElement = validationContext.GetNextChildMc(particleMatchInfo.LastMatchedElement);
            }
          }
          else
            break;
        }
        if (count == 0)
          particleMatchInfo.Match = ParticleMatch.Nomatch;
        else if (count >= this.ParticleConstraint.MinOccurs)
          particleMatchInfo.Match = ParticleMatch.Matched;
        else
          particleMatchInfo.Match = ParticleMatch.Partial;
      }
    }

    public virtual bool GetRequiredElements(ExpectedChildren result)
    {
      if (this.ParticleConstraint.MinOccurs <= 0)
        return false;
      if (result != null)
        result.Add(XsdAnyPrefidefinedValue.GetNamespaceString(this._particleConstraint.NamespaceValue));
      return true;
    }

    public ExpectedChildren GetRequiredElements()
    {
      ExpectedChildren result = new ExpectedChildren();
      this.GetRequiredElements(result);
      return result;
    }

    public virtual bool GetExpectedElements(ExpectedChildren result)
    {
      if (result != null)
        result.Add(XsdAnyPrefidefinedValue.GetNamespaceString(this._particleConstraint.NamespaceValue));
      return true;
    }

    public ExpectedChildren GetExpectedElements()
    {
      ExpectedChildren result = new ExpectedChildren();
      this.GetExpectedElements(result);
      return result;
    }
  }
}

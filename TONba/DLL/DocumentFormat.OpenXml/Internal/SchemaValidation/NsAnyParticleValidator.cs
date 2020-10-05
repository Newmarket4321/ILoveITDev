// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.NsAnyParticleValidator
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Validation;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  internal class NsAnyParticleValidator : AnyParticleValidator
  {
    private NsAnyParticle _nsAnyParticleConstraint;

    internal override ParticleConstraint ParticleConstraint
    {
      get
      {
        return (ParticleConstraint) this._nsAnyParticleConstraint;
      }
    }

    internal NsAnyParticleValidator(NsAnyParticle particleConstraint)
    {
      this._nsAnyParticleConstraint = particleConstraint;
    }

    public override void TryMatchOnce(ParticleMatchInfo particleMatchInfo, ValidationContext validationContext)
    {
      OpenXmlElement startElement = particleMatchInfo.StartElement;
      if (startElement.NamespaceUri == NamespaceIdMap.GetNamespaceUri(this._nsAnyParticleConstraint.NamespaceId))
      {
        particleMatchInfo.Match = ParticleMatch.Matched;
        particleMatchInfo.LastMatchedElement = startElement;
      }
      else
        particleMatchInfo.Match = ParticleMatch.Nomatch;
    }

    public override bool GetRequiredElements(ExpectedChildren result)
    {
      if (this.ParticleConstraint.MinOccurs <= 0)
        return false;
      if (result != null)
        result.Add(NamespaceIdMap.GetNamespaceUri(this._nsAnyParticleConstraint.NamespaceId));
      return true;
    }

    public override bool GetExpectedElements(ExpectedChildren result)
    {
      if (result != null)
        result.Add(NamespaceIdMap.GetNamespaceUri(this._nsAnyParticleConstraint.NamespaceId));
      return true;
    }
  }
}

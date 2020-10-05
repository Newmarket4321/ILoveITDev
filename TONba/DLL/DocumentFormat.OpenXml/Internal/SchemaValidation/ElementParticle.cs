// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.ElementParticle
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Validation;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  [DebuggerDisplay("ElementId={ElementId}")]
  internal class ElementParticle : ParticleConstraint, IParticleValidator
  {
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private int _elementId;

    internal ElementParticle()
    {
    }

    internal override ParticleType ParticleType
    {
      get
      {
        return ParticleType.Element;
      }
      set
      {
      }
    }

    internal override int ElementId
    {
      get
      {
        return this._elementId;
      }
      set
      {
        this._elementId = value;
      }
    }

    internal override IParticleValidator ParticleValidator
    {
      get
      {
        return (IParticleValidator) this;
      }
    }

    public void TryMatchOnce(ParticleMatchInfo particleMatchInfo, ValidationContext validationContext)
    {
      if (particleMatchInfo.StartElement.ElementTypeId == this.ElementId)
      {
        particleMatchInfo.Match = ParticleMatch.Matched;
        particleMatchInfo.LastMatchedElement = particleMatchInfo.StartElement;
      }
      else
        particleMatchInfo.Match = ParticleMatch.Nomatch;
    }

    public void TryMatch(ParticleMatchInfo particleMatchInfo, ValidationContext validationContext)
    {
      if (this.ElementId != particleMatchInfo.StartElement.ElementTypeId)
        particleMatchInfo.Match = ParticleMatch.Nomatch;
      else if (this.MaxOccurs == 1)
      {
        particleMatchInfo.Match = ParticleMatch.Matched;
        particleMatchInfo.LastMatchedElement = particleMatchInfo.StartElement;
      }
      else
      {
        OpenXmlElement child = particleMatchInfo.StartElement;
        int count;
        for (count = 0; child != null && this.MaxOccursGreaterThan(count) && child.ElementTypeId == this.ElementId; child = validationContext.GetNextChildMc(child))
        {
          ++count;
          particleMatchInfo.LastMatchedElement = child;
        }
        if (count >= this.MinOccurs)
        {
          particleMatchInfo.Match = ParticleMatch.Matched;
        }
        else
        {
          particleMatchInfo.Match = ParticleMatch.Partial;
          if (!validationContext.CollectExpectedChildren)
            return;
          if (particleMatchInfo.ExpectedChildren == null)
            particleMatchInfo.InitExpectedChildren();
          particleMatchInfo.ExpectedChildren.Add(this.ElementId);
        }
      }
    }

    public bool GetRequiredElements(ExpectedChildren result)
    {
      if (this.MinOccurs <= 0)
        return false;
      if (result != null)
        result.Add(this.ElementId);
      return true;
    }

    public ExpectedChildren GetRequiredElements()
    {
      ExpectedChildren expectedChildren = new ExpectedChildren();
      if (this.MinOccurs > 0)
        expectedChildren.Add(this.ElementId);
      return expectedChildren;
    }

    public bool GetExpectedElements(ExpectedChildren result)
    {
      result.Add(this.ElementId);
      return true;
    }

    public ExpectedChildren GetExpectedElements()
    {
      ExpectedChildren expectedChildren = new ExpectedChildren();
      expectedChildren.Add(this.ElementId);
      return expectedChildren;
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.ParticleConstraint
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  internal abstract class ParticleConstraint
  {
    internal ParticleConstraint()
    {
    }

    internal virtual ParticleType ParticleType
    {
      get
      {
        return ParticleType.Invalid;
      }
      set
      {
        throw new InvalidOperationException();
      }
    }

    internal int MinOccurs { get; set; }

    internal int MaxOccurs { get; set; }

    internal bool UnboundedMaxOccurs
    {
      get
      {
        return this.MaxOccurs == 0;
      }
    }

    internal bool CanOccursMoreThanOne
    {
      get
      {
        if (!this.UnboundedMaxOccurs)
          return this.MaxOccurs > 1;
        return true;
      }
    }

    internal bool MaxOccursGreaterThan(int count)
    {
      if (!this.UnboundedMaxOccurs)
        return this.MaxOccurs > count;
      return true;
    }

    internal virtual int ElementId
    {
      get
      {
        return (int) ushort.MaxValue;
      }
      set
      {
      }
    }

    internal virtual ParticleConstraint[] ChildrenParticles
    {
      get
      {
        return (ParticleConstraint[]) null;
      }
      set
      {
        throw new InvalidOperationException();
      }
    }

    internal virtual IParticleValidator ParticleValidator
    {
      get
      {
        return (IParticleValidator) null;
      }
    }

    internal bool IsSimple()
    {
      bool flag = true;
      if (this.ChildrenParticles != null)
      {
        foreach (ParticleConstraint childrenParticle in this.ChildrenParticles)
        {
          if (childrenParticle.ParticleType == ParticleType.All || childrenParticle.ParticleType == ParticleType.Choice || (childrenParticle.ParticleType == ParticleType.Group || childrenParticle.ParticleType == ParticleType.Sequence) || (childrenParticle.ParticleType == ParticleType.Any || childrenParticle.ParticleType == ParticleType.AnyWithUri))
            flag = false;
        }
      }
      return flag;
    }

    internal static ParticleConstraint CreateParticleConstraint(ParticleType particleType)
    {
      switch (particleType)
      {
        case ParticleType.Element:
          return (ParticleConstraint) new ElementParticle();
        case ParticleType.Any:
          return (ParticleConstraint) new AnyParticle();
        case ParticleType.AnyWithUri:
          return (ParticleConstraint) new NsAnyParticle();
        case ParticleType.Invalid:
          return (ParticleConstraint) null;
        default:
          return (ParticleConstraint) new CompositeParticle();
      }
    }
  }
}

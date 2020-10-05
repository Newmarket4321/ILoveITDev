// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.NsAnyParticle
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.Diagnostics;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  [DebuggerDisplay("NamespaceId={NamespaceId}")]
  internal class NsAnyParticle : ParticleConstraint
  {
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte _namespaceId;
    private IParticleValidator _particleValidator;

    internal NsAnyParticle()
    {
      this._particleValidator = (IParticleValidator) new NsAnyParticleValidator(this);
    }

    internal override ParticleType ParticleType
    {
      get
      {
        return ParticleType.AnyWithUri;
      }
      set
      {
      }
    }

    internal override int ElementId
    {
      set
      {
        this._namespaceId = (byte) value;
      }
    }

    internal byte NamespaceId
    {
      get
      {
        return this._namespaceId;
      }
    }

    internal override IParticleValidator ParticleValidator
    {
      get
      {
        return this._particleValidator;
      }
    }
  }
}

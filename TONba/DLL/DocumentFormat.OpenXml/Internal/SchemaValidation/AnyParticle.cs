// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.AnyParticle
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.Diagnostics;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  [DebuggerDisplay("NamespaceValue={NamespaceValue}")]
  internal class AnyParticle : ParticleConstraint
  {
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort _xsdAnyValue;
    private IParticleValidator _particleValidator;

    internal AnyParticle()
    {
      this._particleValidator = (IParticleValidator) new AnyParticleValidator(this);
    }

    internal override ParticleType ParticleType
    {
      get
      {
        return ParticleType.Any;
      }
      set
      {
      }
    }

    internal override int ElementId
    {
      set
      {
        this._xsdAnyValue = (ushort) value;
      }
    }

    internal ushort NamespaceValue
    {
      get
      {
        return this._xsdAnyValue;
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

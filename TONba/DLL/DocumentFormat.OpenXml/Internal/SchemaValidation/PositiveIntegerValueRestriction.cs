// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.PositiveIntegerValueRestriction
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Validation;
using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  [Serializable]
  internal class PositiveIntegerValueRestriction : IntegerValueRestriction
  {
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [NonSerialized]
    private static readonly string clrTypeName = ValidationResources.TypeName_positiveInteger;

    protected override long MinValue
    {
      get
      {
        return 1;
      }
    }

    public PositiveIntegerValueRestriction()
    {
      this.RestrictionField = RestrictionField.MinInclusive;
      this.MinInclusive = 1L;
    }

    public override XsdType XsdType
    {
      get
      {
        return XsdType.PositiveInteger;
      }
      set
      {
      }
    }

    public override string ClrTypeName
    {
      get
      {
        return PositiveIntegerValueRestriction.clrTypeName;
      }
    }
  }
}

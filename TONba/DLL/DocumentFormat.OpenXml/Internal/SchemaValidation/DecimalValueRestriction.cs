// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.DecimalValueRestriction
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  [Serializable]
  internal class DecimalValueRestriction : SimpleValueRestriction<Decimal, DecimalValue>
  {
    protected override Decimal MinValue
    {
      get
      {
        return new Decimal(-1, -1, -1, true, (byte) 0);
      }
    }

    protected override Decimal MaxValue
    {
      get
      {
        return new Decimal(-1, -1, -1, false, (byte) 0);
      }
    }

    public override XsdType XsdType
    {
      get
      {
        return XsdType.Decimal;
      }
      set
      {
      }
    }
  }
}

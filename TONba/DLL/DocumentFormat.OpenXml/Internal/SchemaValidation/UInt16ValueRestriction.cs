// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.UInt16ValueRestriction
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  [Serializable]
  internal class UInt16ValueRestriction : SimpleValueRestriction<ushort, UInt16Value>
  {
    protected override ushort MinValue
    {
      get
      {
        return 0;
      }
    }

    protected override ushort MaxValue
    {
      get
      {
        return ushort.MaxValue;
      }
    }

    public override XsdType XsdType
    {
      get
      {
        return XsdType.UnsignedShort;
      }
      set
      {
      }
    }
  }
}

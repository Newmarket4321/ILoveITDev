// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.DoubleValueRestriction
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  [Serializable]
  internal class DoubleValueRestriction : SimpleValueRestriction<double, DoubleValue>
  {
    protected override double MinValue
    {
      get
      {
        return double.MinValue;
      }
    }

    protected override double MaxValue
    {
      get
      {
        return double.MaxValue;
      }
    }

    public override XsdType XsdType
    {
      get
      {
        return XsdType.Double;
      }
      set
      {
      }
    }

    public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
    {
      return attributeValue.HasValue;
    }
  }
}

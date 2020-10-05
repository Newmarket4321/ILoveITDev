// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.DecimalValue
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
  [DebuggerDisplay("{InnerText}")]
  public class DecimalValue : OpenXmlSimpleValue<Decimal>
  {
    public DecimalValue()
    {
    }

    public DecimalValue(Decimal value)
      : base(value)
    {
    }

    public DecimalValue(DecimalValue source)
      : base((OpenXmlSimpleValue<Decimal>) source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
    }

    public override string InnerText
    {
      get
      {
        if (this.TextValue == null && this.InnerValue.HasValue)
          this.TextValue = XmlConvert.ToString(this.InnerValue.Value);
        return this.TextValue;
      }
    }

    internal override void Parse()
    {
      this.InnerValue = new Decimal?(XmlConvert.ToDecimal(this.TextValue));
    }

    internal override bool TryParse()
    {
      this.InnerValue = new Decimal?();
      try
      {
        this.InnerValue = new Decimal?(XmlConvert.ToDecimal(this.TextValue));
        return true;
      }
      catch (FormatException ex)
      {
        return false;
      }
      catch (OverflowException ex)
      {
        return false;
      }
    }

    public static implicit operator Decimal(DecimalValue xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return DecimalValue.ToDecimal(xmlAttribute);
    }

    public static implicit operator DecimalValue(Decimal value)
    {
      return DecimalValue.FromDecimal(value);
    }

    public static DecimalValue FromDecimal(Decimal value)
    {
      return new DecimalValue(value);
    }

    public static Decimal ToDecimal(DecimalValue xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return xmlAttribute.Value;
    }

    internal override OpenXmlSimpleType CloneImp()
    {
      return (OpenXmlSimpleType) new DecimalValue(this);
    }
  }
}

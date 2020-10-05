// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.SByteValue
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
  [DebuggerDisplay("{InnerText}")]
  [CLSCompliant(false)]
  public class SByteValue : OpenXmlSimpleValue<sbyte>
  {
    public SByteValue()
    {
    }

    public SByteValue(sbyte value)
      : base(value)
    {
    }

    public SByteValue(SByteValue source)
      : base((OpenXmlSimpleValue<sbyte>) source)
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
      this.InnerValue = new sbyte?(XmlConvert.ToSByte(this.TextValue));
    }

    internal override bool TryParse()
    {
      this.InnerValue = new sbyte?();
      try
      {
        this.InnerValue = new sbyte?(XmlConvert.ToSByte(this.TextValue));
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

    public static implicit operator sbyte(SByteValue xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return SByteValue.ToSByte(xmlAttribute);
    }

    public static implicit operator SByteValue(sbyte value)
    {
      return SByteValue.FromSByte(value);
    }

    public static SByteValue FromSByte(sbyte value)
    {
      return new SByteValue(value);
    }

    public static sbyte ToSByte(SByteValue xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return xmlAttribute.Value;
    }

    internal override OpenXmlSimpleType CloneImp()
    {
      return (OpenXmlSimpleType) new SByteValue(this);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.ByteValue
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
  [DebuggerDisplay("{InnerText}")]
  public class ByteValue : OpenXmlSimpleValue<byte>
  {
    public ByteValue()
    {
    }

    public ByteValue(byte value)
      : base(value)
    {
    }

    public ByteValue(ByteValue source)
      : base((OpenXmlSimpleValue<byte>) source)
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
      this.InnerValue = new byte?(XmlConvert.ToByte(this.TextValue));
    }

    internal override bool TryParse()
    {
      this.InnerValue = new byte?();
      try
      {
        this.InnerValue = new byte?(XmlConvert.ToByte(this.TextValue));
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

    public static implicit operator byte(ByteValue xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return ByteValue.ToByte(xmlAttribute);
    }

    public static implicit operator ByteValue(byte value)
    {
      return ByteValue.FromByte(value);
    }

    public static ByteValue FromByte(byte value)
    {
      return new ByteValue(value);
    }

    public static byte ToByte(ByteValue xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return xmlAttribute.Value;
    }

    internal override OpenXmlSimpleType CloneImp()
    {
      return (OpenXmlSimpleType) new ByteValue(this);
    }
  }
}

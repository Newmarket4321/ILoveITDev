// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.UInt32Value
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
  [CLSCompliant(false)]
  [DebuggerDisplay("{InnerText}")]
  public class UInt32Value : OpenXmlSimpleValue<uint>
  {
    public UInt32Value()
    {
    }

    public UInt32Value(uint value)
      : base(value)
    {
    }

    public UInt32Value(UInt32Value source)
      : base((OpenXmlSimpleValue<uint>) source)
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
      this.InnerValue = new uint?(XmlConvert.ToUInt32(this.TextValue));
    }

    internal override bool TryParse()
    {
      this.InnerValue = new uint?();
      try
      {
        this.InnerValue = new uint?(XmlConvert.ToUInt32(this.TextValue));
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

    public static implicit operator uint(UInt32Value xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return UInt32Value.ToUInt32(xmlAttribute);
    }

    public static implicit operator UInt32Value(uint value)
    {
      return UInt32Value.FromUInt32(value);
    }

    public static UInt32Value FromUInt32(uint value)
    {
      return new UInt32Value(value);
    }

    public static uint ToUInt32(UInt32Value xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return xmlAttribute.Value;
    }

    internal override OpenXmlSimpleType CloneImp()
    {
      return (OpenXmlSimpleType) new UInt32Value(this);
    }
  }
}

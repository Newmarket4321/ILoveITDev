// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.UInt64Value
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
  public class UInt64Value : OpenXmlSimpleValue<ulong>
  {
    public UInt64Value()
    {
    }

    public UInt64Value(ulong value)
      : base(value)
    {
    }

    public UInt64Value(UInt64Value source)
      : base((OpenXmlSimpleValue<ulong>) source)
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
      this.InnerValue = new ulong?(XmlConvert.ToUInt64(this.TextValue));
    }

    internal override bool TryParse()
    {
      this.InnerValue = new ulong?();
      try
      {
        this.InnerValue = new ulong?(XmlConvert.ToUInt64(this.TextValue));
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

    public static implicit operator ulong(UInt64Value xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return UInt64Value.ToUInt64(xmlAttribute);
    }

    public static implicit operator UInt64Value(ulong value)
    {
      return UInt64Value.FromUInt64(value);
    }

    public static UInt64Value FromUInt64(ulong value)
    {
      return new UInt64Value(value);
    }

    public static ulong ToUInt64(UInt64Value xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return xmlAttribute.Value;
    }

    internal override OpenXmlSimpleType CloneImp()
    {
      return (OpenXmlSimpleType) new UInt64Value(this);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.UInt16Value
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
  public class UInt16Value : OpenXmlSimpleValue<ushort>
  {
    public UInt16Value()
    {
    }

    public UInt16Value(ushort value)
      : base(value)
    {
    }

    public UInt16Value(UInt16Value source)
      : base((OpenXmlSimpleValue<ushort>) source)
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
      this.InnerValue = new ushort?(XmlConvert.ToUInt16(this.TextValue));
    }

    internal override bool TryParse()
    {
      this.InnerValue = new ushort?();
      try
      {
        this.InnerValue = new ushort?(XmlConvert.ToUInt16(this.TextValue));
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

    public static implicit operator ushort(UInt16Value xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return UInt16Value.ToUInt16(xmlAttribute);
    }

    public static implicit operator UInt16Value(ushort value)
    {
      return UInt16Value.FromUInt16(value);
    }

    public static UInt16Value FromUInt16(ushort value)
    {
      return new UInt16Value(value);
    }

    public static ushort ToUInt16(UInt16Value xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return xmlAttribute.Value;
    }

    internal override OpenXmlSimpleType CloneImp()
    {
      return (OpenXmlSimpleType) new UInt16Value(this);
    }
  }
}

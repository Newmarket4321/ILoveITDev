// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Int64Value
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
  [DebuggerDisplay("{InnerText}")]
  public class Int64Value : OpenXmlSimpleValue<long>
  {
    public Int64Value()
    {
    }

    public Int64Value(long value)
      : base(value)
    {
    }

    public Int64Value(Int64Value source)
      : base((OpenXmlSimpleValue<long>) source)
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
      this.InnerValue = new long?(XmlConvert.ToInt64(this.TextValue));
    }

    internal override bool TryParse()
    {
      this.InnerValue = new long?();
      try
      {
        this.InnerValue = new long?(XmlConvert.ToInt64(this.TextValue));
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

    public static implicit operator long(Int64Value xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return Int64Value.ToInt64(xmlAttribute);
    }

    public static implicit operator Int64Value(long value)
    {
      return Int64Value.FromInt64(value);
    }

    public static Int64Value FromInt64(long value)
    {
      return new Int64Value(value);
    }

    public static long ToInt64(Int64Value xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return xmlAttribute.Value;
    }

    internal override OpenXmlSimpleType CloneImp()
    {
      return (OpenXmlSimpleType) new Int64Value(this);
    }
  }
}

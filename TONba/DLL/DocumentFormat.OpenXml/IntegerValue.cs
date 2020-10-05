// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.IntegerValue
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
  [DebuggerDisplay("{InnerText}")]
  public class IntegerValue : OpenXmlSimpleValue<long>
  {
    public IntegerValue()
    {
    }

    public IntegerValue(long value)
      : base(value)
    {
    }

    public IntegerValue(IntegerValue source)
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

    public static implicit operator long(IntegerValue xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return IntegerValue.ToInt64(xmlAttribute);
    }

    public static implicit operator IntegerValue(long value)
    {
      return IntegerValue.FromInt64(value);
    }

    public static IntegerValue FromInt64(long value)
    {
      return new IntegerValue(value);
    }

    public static long ToInt64(IntegerValue xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return xmlAttribute.Value;
    }

    internal override OpenXmlSimpleType CloneImp()
    {
      return (OpenXmlSimpleType) new IntegerValue(this);
    }
  }
}

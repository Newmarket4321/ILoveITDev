// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.DateTimeValue
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
  [DebuggerDisplay("{InnerText}")]
  public class DateTimeValue : OpenXmlSimpleValue<DateTime>
  {
    public DateTimeValue()
    {
    }

    public DateTimeValue(DateTime value)
      : base(value)
    {
    }

    public DateTimeValue(DateTimeValue source)
      : base((OpenXmlSimpleValue<DateTime>) source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
    }

    public override string InnerText
    {
      get
      {
        if (this.TextValue == null && this.InnerValue.HasValue)
          this.TextValue = XmlConvert.ToString(this.InnerValue.Value, XmlDateTimeSerializationMode.RoundtripKind);
        return this.TextValue;
      }
    }

    internal override void Parse()
    {
      this.InnerValue = new DateTime?(XmlConvert.ToDateTime(this.TextValue, XmlDateTimeSerializationMode.Utc));
    }

    internal override bool TryParse()
    {
      this.InnerValue = new DateTime?();
      try
      {
        this.InnerValue = new DateTime?(XmlConvert.ToDateTime(this.TextValue, XmlDateTimeSerializationMode.Utc));
        return true;
      }
      catch (FormatException ex)
      {
        return false;
      }
    }

    public static implicit operator DateTime(DateTimeValue xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return DateTimeValue.ToDateTime(xmlAttribute);
    }

    public static implicit operator DateTimeValue(DateTime value)
    {
      return DateTimeValue.FromDateTime(value);
    }

    public static DateTimeValue FromDateTime(DateTime value)
    {
      return new DateTimeValue(value);
    }

    public static DateTime ToDateTime(DateTimeValue xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return xmlAttribute.Value;
    }

    internal override OpenXmlSimpleType CloneImp()
    {
      return (OpenXmlSimpleType) new DateTimeValue(this);
    }
  }
}

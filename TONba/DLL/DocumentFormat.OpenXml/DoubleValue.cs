// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.DoubleValue
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
  [DebuggerDisplay("{InnerText}")]
  public class DoubleValue : OpenXmlSimpleValue<double>
  {
    public DoubleValue()
    {
    }

    public DoubleValue(double value)
      : base(value)
    {
    }

    public DoubleValue(DoubleValue source)
      : base((OpenXmlSimpleValue<double>) source)
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
      this.InnerValue = new double?(XmlConvert.ToDouble(this.TextValue));
    }

    internal override bool TryParse()
    {
      this.InnerValue = new double?();
      try
      {
        this.InnerValue = new double?(XmlConvert.ToDouble(this.TextValue));
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

    public static implicit operator double(DoubleValue xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return DoubleValue.ToDouble(xmlAttribute);
    }

    public static implicit operator DoubleValue(double value)
    {
      return DoubleValue.FromDouble(value);
    }

    public static DoubleValue FromDouble(double value)
    {
      return new DoubleValue(value);
    }

    public static double ToDouble(DoubleValue xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return xmlAttribute.Value;
    }

    internal override OpenXmlSimpleType CloneImp()
    {
      return (OpenXmlSimpleType) new DoubleValue(this);
    }
  }
}

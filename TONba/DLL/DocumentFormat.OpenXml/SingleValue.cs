// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.SingleValue
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
  [DebuggerDisplay("{InnerText}")]
  public class SingleValue : OpenXmlSimpleValue<float>
  {
    public SingleValue()
    {
    }

    public SingleValue(float value)
      : base(value)
    {
    }

    public SingleValue(SingleValue source)
      : base((OpenXmlSimpleValue<float>) source)
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
      this.InnerValue = new float?(XmlConvert.ToSingle(this.TextValue));
    }

    internal override bool TryParse()
    {
      this.InnerValue = new float?();
      try
      {
        this.Parse();
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

    public static implicit operator float(SingleValue xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return SingleValue.ToSingle(xmlAttribute);
    }

    public static implicit operator SingleValue(float value)
    {
      return SingleValue.FromSingle(value);
    }

    public static SingleValue FromSingle(float value)
    {
      return new SingleValue(value);
    }

    public static float ToSingle(SingleValue xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return xmlAttribute.Value;
    }

    internal override OpenXmlSimpleType CloneImp()
    {
      return (OpenXmlSimpleType) new SingleValue(this);
    }
  }
}

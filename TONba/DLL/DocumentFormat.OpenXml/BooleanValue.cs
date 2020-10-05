// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.BooleanValue
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
  [DebuggerDisplay("{InnerText}")]
  public class BooleanValue : OpenXmlSimpleValue<bool>
  {
    public BooleanValue()
    {
    }

    public BooleanValue(bool value)
      : base(value)
    {
    }

    public BooleanValue(BooleanValue source)
      : base((OpenXmlSimpleValue<bool>) source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
    }

    public override string InnerText
    {
      get
      {
        if (this.TextValue == null && this.InnerValue.HasValue)
          this.TextValue = this.InnerValue.Value ? "1" : "0";
        return this.TextValue;
      }
    }

    internal override void Parse()
    {
      this.InnerValue = new bool?(XmlConvert.ToBoolean(this.TextValue));
    }

    internal override bool TryParse()
    {
      this.InnerValue = new bool?();
      try
      {
        this.InnerValue = new bool?(XmlConvert.ToBoolean(this.TextValue));
        return true;
      }
      catch (FormatException ex)
      {
        return false;
      }
    }

    public static implicit operator bool(BooleanValue xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return BooleanValue.ToBoolean(xmlAttribute);
    }

    public static implicit operator BooleanValue(bool value)
    {
      return BooleanValue.FromBoolean(value);
    }

    public static BooleanValue FromBoolean(bool value)
    {
      return new BooleanValue(value);
    }

    public static bool ToBoolean(BooleanValue xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return xmlAttribute.Value;
    }

    internal override OpenXmlSimpleType CloneImp()
    {
      return (OpenXmlSimpleType) new BooleanValue(this);
    }
  }
}

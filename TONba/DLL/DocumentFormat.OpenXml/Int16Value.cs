// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Int16Value
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
  [DebuggerDisplay("{InnerText}")]
  public class Int16Value : OpenXmlSimpleValue<short>
  {
    public Int16Value()
    {
    }

    public Int16Value(short value)
      : base(value)
    {
    }

    public Int16Value(Int16Value source)
      : base((OpenXmlSimpleValue<short>) source)
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
      this.InnerValue = new short?(XmlConvert.ToInt16(this.TextValue));
    }

    internal override bool TryParse()
    {
      this.InnerValue = new short?();
      try
      {
        this.InnerValue = new short?(XmlConvert.ToInt16(this.TextValue));
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

    public static implicit operator short(Int16Value xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return Int16Value.ToInt16(xmlAttribute);
    }

    public static implicit operator Int16Value(short value)
    {
      return Int16Value.FromInt16(value);
    }

    public static Int16Value FromInt16(short value)
    {
      return new Int16Value(value);
    }

    public static short ToInt16(Int16Value xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return xmlAttribute.Value;
    }

    internal override OpenXmlSimpleType CloneImp()
    {
      return (OpenXmlSimpleType) new Int16Value(this);
    }
  }
}

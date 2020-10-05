// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Int32Value
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
  [DebuggerDisplay("{InnerText}")]
  public class Int32Value : OpenXmlSimpleValue<int>
  {
    public Int32Value()
    {
    }

    public Int32Value(int value)
      : base(value)
    {
    }

    public Int32Value(Int32Value source)
      : base((OpenXmlSimpleValue<int>) source)
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
      this.InnerValue = new int?(XmlConvert.ToInt32(this.TextValue));
    }

    internal override bool TryParse()
    {
      this.InnerValue = new int?();
      try
      {
        this.InnerValue = new int?(XmlConvert.ToInt32(this.TextValue));
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

    public static implicit operator int(Int32Value xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return Int32Value.ToInt32(xmlAttribute);
    }

    public static implicit operator Int32Value(int value)
    {
      return Int32Value.FromInt32(value);
    }

    public static Int32Value FromInt32(int value)
    {
      return new Int32Value(value);
    }

    public static int ToInt32(Int32Value xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return xmlAttribute.Value;
    }

    internal override OpenXmlSimpleType CloneImp()
    {
      return (OpenXmlSimpleType) new Int32Value(this);
    }
  }
}

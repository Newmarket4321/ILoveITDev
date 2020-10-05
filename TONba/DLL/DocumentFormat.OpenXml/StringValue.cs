// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.StringValue
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml
{
  [DebuggerDisplay("{InnerText}")]
  public class StringValue : OpenXmlSimpleType
  {
    public StringValue()
    {
    }

    public StringValue(string value)
    {
      this.TextValue = value;
    }

    public StringValue(StringValue source)
      : base((OpenXmlSimpleType) source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
    }

    public string Value
    {
      get
      {
        return this.TextValue;
      }
      set
      {
        this.TextValue = value;
      }
    }

    public static implicit operator string(StringValue xmlAttribute)
    {
      if (xmlAttribute == null)
        return (string) null;
      return StringValue.ToString(xmlAttribute);
    }

    public static implicit operator StringValue(string value)
    {
      return StringValue.FromString(value);
    }

    public static StringValue FromString(string value)
    {
      return new StringValue(value);
    }

    public static string ToString(StringValue xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return xmlAttribute.Value;
    }

    internal override OpenXmlSimpleType CloneImp()
    {
      return (OpenXmlSimpleType) new StringValue(this);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Base64BinaryValue
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml
{
  [DebuggerDisplay("{InnerText}")]
  public class Base64BinaryValue : OpenXmlSimpleType
  {
    public Base64BinaryValue()
    {
    }

    public Base64BinaryValue(string base64Binary)
    {
      this.TextValue = base64Binary;
    }

    public Base64BinaryValue(Base64BinaryValue source)
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

    public static implicit operator string(Base64BinaryValue xmlAttribute)
    {
      if (xmlAttribute == null)
        return (string) null;
      return Base64BinaryValue.ToString(xmlAttribute);
    }

    public static implicit operator Base64BinaryValue(string value)
    {
      return Base64BinaryValue.FromString(value);
    }

    public static Base64BinaryValue FromString(string value)
    {
      return new Base64BinaryValue(value);
    }

    public static string ToString(Base64BinaryValue xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return xmlAttribute.Value;
    }

    internal override OpenXmlSimpleType CloneImp()
    {
      return (OpenXmlSimpleType) new Base64BinaryValue(this);
    }
  }
}

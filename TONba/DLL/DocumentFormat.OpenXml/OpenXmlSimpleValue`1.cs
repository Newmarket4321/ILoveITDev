// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.OpenXmlSimpleValue`1
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml
{
  [DebuggerDisplay("{InnerText}")]
  public abstract class OpenXmlSimpleValue<T> : OpenXmlSimpleType where T : struct
  {
    private T? _value;

    internal T? InnerValue
    {
      get
      {
        return this._value;
      }
      set
      {
        this._value = value;
      }
    }

    protected OpenXmlSimpleValue()
    {
    }

    protected OpenXmlSimpleValue(T value)
    {
      this.Value = value;
    }

    protected OpenXmlSimpleValue(OpenXmlSimpleValue<T> source)
      : base((OpenXmlSimpleType) source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      this.InnerText = source.InnerText;
    }

    public override bool HasValue
    {
      get
      {
        if (!this._value.HasValue && !string.IsNullOrEmpty(this.TextValue))
          this.TryParse();
        return this._value.HasValue;
      }
    }

    public T Value
    {
      get
      {
        if (!this._value.HasValue && !string.IsNullOrEmpty(this.TextValue))
          this.Parse();
        return this._value.Value;
      }
      set
      {
        this._value = new T?(value);
        this.TextValue = (string) null;
      }
    }

    public override string InnerText
    {
      get
      {
        throw new NotImplementedException();
      }
      set
      {
        this.TextValue = value;
        this._value = new T?();
      }
    }

    public static implicit operator T(OpenXmlSimpleValue<T> xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return xmlAttribute.Value;
    }
  }
}

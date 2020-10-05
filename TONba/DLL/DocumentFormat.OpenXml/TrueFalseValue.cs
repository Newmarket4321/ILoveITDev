// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.TrueFalseValue
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml
{
  [DebuggerDisplay("{InnerText}")]
  public class TrueFalseValue : OpenXmlSimpleType
  {
    private TrueFalseValueImpl _impl;

    public TrueFalseValue()
    {
      this.Initialize();
    }

    public TrueFalseValue(bool value)
    {
      this.Initialize();
      this.Value = value;
    }

    public TrueFalseValue(TrueFalseValue source)
      : base((OpenXmlSimpleType) source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      this.Initialize();
      this._impl.InnerText = source.InnerText;
    }

    private void Initialize()
    {
      this._impl = new TrueFalseValueImpl(new Func<string, bool>(this.GetBooleanValue), new Func<bool, string>(this.GetDefaultTextValue));
    }

    public override bool HasValue
    {
      get
      {
        return this._impl.HasValue;
      }
    }

    public bool Value
    {
      get
      {
        return this._impl.Value;
      }
      set
      {
        this._impl.Value = value;
      }
    }

    public override string InnerText
    {
      get
      {
        return this._impl.InnerText;
      }
      set
      {
        this._impl.InnerText = value;
      }
    }

    public static implicit operator bool(TrueFalseValue xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return TrueFalseValue.ToBoolean(xmlAttribute);
    }

    public static implicit operator TrueFalseValue(bool value)
    {
      return TrueFalseValue.FromBoolean(value);
    }

    public static TrueFalseValue FromBoolean(bool value)
    {
      return new TrueFalseValue(value);
    }

    public static bool ToBoolean(TrueFalseValue xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return xmlAttribute.Value;
    }

    internal override OpenXmlSimpleType CloneImp()
    {
      return (OpenXmlSimpleType) new TrueFalseValue(this);
    }

    private bool GetBooleanValue(string textValue)
    {
      if (textValue == null)
        return false;
      if ("true".Equals(textValue))
        return true;
      if ("false".Equals(textValue))
        return false;
      if ("t".Equals(textValue))
        return true;
      if ("f".Equals(textValue))
        return false;
      throw new FormatException(ExceptionMessages.TextIsInvalidTrueFalseValue);
    }

    private string GetDefaultTextValue(bool boolValue)
    {
      return !boolValue ? "false" : "true";
    }
  }
}

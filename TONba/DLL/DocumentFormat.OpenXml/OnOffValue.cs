// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.OnOffValue
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml
{
  [DebuggerDisplay("{InnerText}")]
  public class OnOffValue : OpenXmlSimpleType
  {
    private TrueFalseValueImpl _impl;

    public OnOffValue()
    {
      this.Initialize();
    }

    public OnOffValue(bool value)
    {
      this.Initialize();
      this.Value = value;
    }

    public OnOffValue(OnOffValue source)
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

    private bool GetBooleanValue(string textValue)
    {
      if (textValue == null)
        return false;
      if ("true".Equals(textValue))
        return true;
      if ("false".Equals(textValue))
        return false;
      if ("on".Equals(textValue))
        return true;
      if ("off".Equals(textValue))
        return false;
      if ("1".Equals(textValue))
        return true;
      if ("0".Equals(textValue))
        return false;
      throw new FormatException(ExceptionMessages.TextIsInvalidOnOffValue);
    }

    private string GetDefaultTextValue(bool boolValue)
    {
      return !boolValue ? "false" : "true";
    }

    internal override OpenXmlSimpleType CloneImp()
    {
      return (OpenXmlSimpleType) new OnOffValue(this);
    }

    public static implicit operator bool(OnOffValue xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new ArgumentNullException(nameof (xmlAttribute));
      return OnOffValue.ToBoolean(xmlAttribute);
    }

    public static implicit operator OnOffValue(bool value)
    {
      return OnOffValue.FromBoolean(value);
    }

    public static OnOffValue FromBoolean(bool value)
    {
      return new OnOffValue(value);
    }

    public static bool ToBoolean(OnOffValue xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return xmlAttribute.Value;
    }
  }
}

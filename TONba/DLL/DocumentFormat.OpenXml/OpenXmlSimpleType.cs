// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.OpenXmlSimpleType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml
{
  public abstract class OpenXmlSimpleType : ICloneable
  {
    private string _textValue;

    protected OpenXmlSimpleType()
    {
    }

    protected OpenXmlSimpleType(OpenXmlSimpleType source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      this.TextValue = source.TextValue;
    }

    protected string TextValue
    {
      get
      {
        return this._textValue;
      }
      set
      {
        this._textValue = value;
      }
    }

    internal virtual void Parse()
    {
    }

    internal virtual bool TryParse()
    {
      return true;
    }

    public virtual bool HasValue
    {
      get
      {
        return this._textValue != null;
      }
    }

    public virtual string InnerText
    {
      get
      {
        return this._textValue;
      }
      set
      {
        this._textValue = value;
      }
    }

    public override string ToString()
    {
      return this.InnerText;
    }

    public object Clone()
    {
      return (object) this.CloneImp();
    }

    internal abstract OpenXmlSimpleType CloneImp();

    public static implicit operator string(OpenXmlSimpleType xmlAttribute)
    {
      if (xmlAttribute == null)
        return (string) null;
      return xmlAttribute.InnerText;
    }

    internal virtual IEnumerable<OpenXmlSimpleType> GetListItems()
    {
      throw new NotImplementedException();
    }

    internal virtual bool IsInVersion(FileFormatVersions fileFormat)
    {
      throw new NotImplementedException();
    }
  }
}

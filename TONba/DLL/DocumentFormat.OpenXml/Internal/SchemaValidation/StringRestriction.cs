// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.StringRestriction
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  [Serializable]
  internal class StringRestriction : SimpleTypeRestriction
  {
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [NonSerialized]
    private static readonly string clrTypeName = typeof (string).Name;

    public override int MaxLength { get; set; }

    public override int MinLength { get; set; }

    public override int Length { get; set; }

    public override XsdType XsdType
    {
      get
      {
        return XsdType.String;
      }
      set
      {
      }
    }

    public override string ClrTypeName
    {
      get
      {
        return StringRestriction.clrTypeName;
      }
    }

    public override bool IsPatternValid(OpenXmlSimpleType attributeValue)
    {
      if ((this.RestrictionField & RestrictionField.Pattern) != RestrictionField.Pattern)
        return true;
      string pattern = "\\A(" + this.Pattern + ")\\z";
      return Regex.IsMatch(attributeValue.InnerText, pattern, RegexOptions.CultureInvariant);
    }

    internal virtual int GetValueLength(OpenXmlSimpleType attributeValue)
    {
      return attributeValue.InnerText.Length;
    }

    public override bool IsLengthValid(OpenXmlSimpleType attributeValue)
    {
      return (this.RestrictionField & RestrictionField.Length) != RestrictionField.Length || this.GetValueLength(attributeValue) == this.Length;
    }

    public override bool IsMinLengthValid(OpenXmlSimpleType attributeValue)
    {
      return (this.RestrictionField & RestrictionField.MinLength) != RestrictionField.MinLength || this.GetValueLength(attributeValue) >= this.MinLength;
    }

    public override bool IsMaxLengthValid(OpenXmlSimpleType attributeValue)
    {
      return (this.RestrictionField & RestrictionField.MaxLength) != RestrictionField.MaxLength || this.GetValueLength(attributeValue) <= this.MaxLength;
    }
  }
}

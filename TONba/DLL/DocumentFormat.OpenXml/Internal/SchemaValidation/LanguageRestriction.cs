// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.LanguageRestriction
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Validation;
using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Xml;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  [Serializable]
  internal class LanguageRestriction : TokenRestriction
  {
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [NonSerialized]
    private static readonly string clrTypeName = ValidationResources.TypeName_language;
    [NonSerialized]
    private static string LanguageLexicalPattern = "\\A[a-zA-Z]{1,8}(-[a-zA-Z0-9]{1,8})*\\z";

    public override XsdType XsdType
    {
      get
      {
        return XsdType.Language;
      }
      set
      {
      }
    }

    public override string ClrTypeName
    {
      get
      {
        return LanguageRestriction.clrTypeName;
      }
    }

    public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
    {
      try
      {
        XmlConvert.VerifyTOKEN(attributeValue.InnerText);
      }
      catch (XmlException ex)
      {
        return false;
      }
      return Regex.IsMatch(attributeValue.InnerText, LanguageRestriction.LanguageLexicalPattern, RegexOptions.CultureInvariant);
    }
  }
}

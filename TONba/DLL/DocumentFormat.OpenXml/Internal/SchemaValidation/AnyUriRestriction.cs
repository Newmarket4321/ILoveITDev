// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.AnyUriRestriction
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  [Serializable]
  internal class AnyUriRestriction : StringRestriction
  {
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [NonSerialized]
    private static readonly string clrTypeName = typeof (Uri).Name;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [NonSerialized]
    private static char[] WhitespaceChars = new char[4]
    {
      ' ',
      '\t',
      '\n',
      '\r'
    };

    public override XsdType XsdType
    {
      get
      {
        return XsdType.AnyURI;
      }
      set
      {
      }
    }

    public override string ClrTypeName
    {
      get
      {
        return AnyUriRestriction.clrTypeName;
      }
    }

    public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
    {
      Uri result = (Uri) null;
      string uriString = attributeValue.InnerText;
      if (uriString != null && uriString.Length > 0)
      {
        uriString = uriString.Trim(AnyUriRestriction.WhitespaceChars);
        if (uriString.Length == 0 || uriString.IndexOf("##", StringComparison.Ordinal) != -1)
          return false;
      }
      return Uri.TryCreate(uriString, UriKind.RelativeOrAbsolute, out result);
    }
  }
}

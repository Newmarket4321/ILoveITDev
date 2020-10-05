// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.HexBinaryRestriction
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Validation;
using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  [Serializable]
  internal class HexBinaryRestriction : StringRestriction
  {
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [NonSerialized]
    private static readonly string clrTypeName = ValidationResources.TypeName_hexBinary;

    public override XsdType XsdType
    {
      get
      {
        return XsdType.HexBinary;
      }
      set
      {
      }
    }

    public override string ClrTypeName
    {
      get
      {
        return HexBinaryRestriction.clrTypeName;
      }
    }

    public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
    {
      if (attributeValue.InnerText == null)
        return false;
      if (attributeValue.InnerText.Length == 0)
        return true;
      string pattern = "\\A([0-9a-fA-F][0-9a-fA-F])+\\z";
      return Regex.IsMatch(attributeValue.InnerText, pattern, RegexOptions.CultureInvariant);
    }

    internal override int GetValueLength(OpenXmlSimpleType attributeValue)
    {
      return (attributeValue.InnerText.Length + 1) / 2;
    }
  }
}

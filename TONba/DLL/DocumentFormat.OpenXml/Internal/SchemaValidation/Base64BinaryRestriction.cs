// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.Base64BinaryRestriction
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Validation;
using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  [Serializable]
  internal class Base64BinaryRestriction : StringRestriction
  {
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [NonSerialized]
    private static readonly string clrTypeName = ValidationResources.TypeName_base64Binary;

    public override XsdType XsdType
    {
      get
      {
        return XsdType.Base64Binary;
      }
      set
      {
      }
    }

    public override string ClrTypeName
    {
      get
      {
        return Base64BinaryRestriction.clrTypeName;
      }
    }

    public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
    {
      if (attributeValue.InnerText == null)
        return false;
      if (attributeValue.InnerText.Length == 0)
        return true;
      try
      {
        Convert.FromBase64String(attributeValue.InnerText);
      }
      catch (FormatException ex)
      {
        return false;
      }
      return true;
    }

    internal override int GetValueLength(OpenXmlSimpleType attributeValue)
    {
      return Convert.FromBase64String(attributeValue.InnerText).Length;
    }
  }
}

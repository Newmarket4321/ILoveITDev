// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.NcNameRestriction
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Validation;
using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  [Serializable]
  internal class NcNameRestriction : StringRestriction
  {
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [NonSerialized]
    private static readonly string clrTypeName = ValidationResources.TypeName_NCName;

    public override XsdType XsdType
    {
      get
      {
        return XsdType.NCName;
      }
      set
      {
      }
    }

    public override string ClrTypeName
    {
      get
      {
        return NcNameRestriction.clrTypeName;
      }
    }

    public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
    {
      if (string.IsNullOrEmpty(attributeValue.InnerText))
        return false;
      try
      {
        XmlConvert.VerifyNCName(attributeValue.InnerText);
      }
      catch (XmlException ex)
      {
        return false;
      }
      return true;
    }
  }
}

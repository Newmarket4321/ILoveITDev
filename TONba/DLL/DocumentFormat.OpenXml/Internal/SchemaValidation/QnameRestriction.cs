﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.QnameRestriction
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
  internal class QnameRestriction : StringRestriction
  {
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [NonSerialized]
    private static readonly string clrTypeName = ValidationResources.TypeName_QName;

    public override XsdType XsdType
    {
      get
      {
        return XsdType.QName;
      }
      set
      {
      }
    }

    public override string ClrTypeName
    {
      get
      {
        return QnameRestriction.clrTypeName;
      }
    }

    public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
    {
      string innerText = attributeValue.InnerText;
      if (string.IsNullOrEmpty(innerText))
        return false;
      int length = innerText.IndexOf(":", StringComparison.Ordinal);
      if (length == 0 || length == innerText.Length - 1)
        return false;
      if (length > 0)
      {
        try
        {
          XmlConvert.VerifyNCName(innerText.Substring(0, length));
        }
        catch (XmlException ex)
        {
          return false;
        }
      }
      try
      {
        XmlConvert.VerifyNCName(innerText.Substring(length + 1));
      }
      catch (XmlException ex)
      {
        return false;
      }
      return true;
    }
  }
}

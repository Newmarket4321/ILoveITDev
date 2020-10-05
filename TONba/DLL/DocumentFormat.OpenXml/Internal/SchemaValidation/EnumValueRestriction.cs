// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.EnumValueRestriction
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  [Serializable]
  internal class EnumValueRestriction : SimpleTypeRestriction
  {
    public override XsdType XsdType
    {
      get
      {
        return XsdType.Enum;
      }
      set
      {
      }
    }

    public override string ClrTypeName
    {
      get
      {
        return string.Empty;
      }
    }

    public override bool IsEnum
    {
      get
      {
        return true;
      }
    }

    public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
    {
      if (attributeValue.HasValue)
        return attributeValue.IsInVersion(this.FileFormat);
      return false;
    }
  }
}

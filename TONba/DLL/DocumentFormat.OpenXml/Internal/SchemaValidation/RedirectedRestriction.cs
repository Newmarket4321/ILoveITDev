// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.RedirectedRestriction
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  [Serializable]
  internal class RedirectedRestriction : SimpleTypeRestriction
  {
    public SimpleTypeRestriction TargetRestriction { get; set; }

    internal int AttributeId { get; set; }

    public override XsdType XsdType
    {
      get
      {
        return XsdType.Redirected;
      }
      set
      {
      }
    }

    public override string ClrTypeName
    {
      get
      {
        return this.TargetRestriction.ClrTypeName;
      }
    }

    public OpenXmlSimpleType ConvertValue(OpenXmlSimpleType value)
    {
      OpenXmlSimpleType targetValueObject = UnionHelper.CreateTargetValueObject(this, this.FileFormat);
      targetValueObject.InnerText = value.InnerText;
      return targetValueObject;
    }
  }
}

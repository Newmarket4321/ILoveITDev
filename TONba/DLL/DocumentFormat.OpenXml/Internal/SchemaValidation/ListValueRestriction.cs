﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.ListValueRestriction
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  [Serializable]
  internal class ListValueRestriction : SimpleTypeRestriction
  {
    public override XsdType XsdType
    {
      get
      {
        return XsdType.List;
      }
      set
      {
      }
    }

    public override string ClrTypeName
    {
      get
      {
        return this.ListItemType.ClrTypeName;
      }
    }

    public override bool IsList
    {
      get
      {
        return true;
      }
    }

    public SimpleTypeRestriction ListItemType { get; set; }

    public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
    {
      if (!attributeValue.HasValue)
        return false;
      foreach (OpenXmlSimpleType listItem in attributeValue.GetListItems())
      {
        if (!this.ListItemType.ValidateValueType(listItem) || this.ListItemType.Validate(listItem) != RestrictionField.None)
          return false;
      }
      return true;
    }
  }
}

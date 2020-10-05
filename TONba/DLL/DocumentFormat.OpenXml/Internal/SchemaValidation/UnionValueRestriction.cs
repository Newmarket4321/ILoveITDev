// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.UnionValueRestriction
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  [Serializable]
  internal class UnionValueRestriction : SimpleTypeRestriction
  {
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private SimpleTypeRestriction[] unionField;

    public SimpleTypeRestriction[] UnionTypes
    {
      get
      {
        return this.unionField;
      }
      set
      {
        this.unionField = value;
      }
    }

    internal int UnionId { get; set; }

    public override XsdType XsdType
    {
      get
      {
        return XsdType.Union;
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

    public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
    {
      StringValue innerText = (StringValue) attributeValue.InnerText;
      OpenXmlSimpleType[] possibleMembers = UnionHelper.CreatePossibleMembers(this, this.FileFormat);
      int length = possibleMembers.Length;
      for (int index = 0; index < length; ++index)
      {
        OpenXmlSimpleType attributeValue1 = possibleMembers[index];
        attributeValue1.InnerText = (string) innerText;
        SimpleTypeRestriction unionType = this.UnionTypes[index];
        if (unionType.ValidateValueType(attributeValue1) && unionType.Validate(attributeValue1) == RestrictionField.None)
          return true;
      }
      return false;
    }
  }
}

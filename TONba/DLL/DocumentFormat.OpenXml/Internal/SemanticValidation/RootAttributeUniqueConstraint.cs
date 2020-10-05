// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SemanticValidation.RootAttributeUniqueConstraint
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Validation;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace DocumentFormat.OpenXml.Internal.SemanticValidation
{
  internal class RootAttributeUniqueConstraint : SemanticConstraint
  {
    private List<string> _values = new List<string>();
    private byte _attribute;
    private bool _caseSensitive;

    public RootAttributeUniqueConstraint(byte attribute, bool caseSensitive)
      : base(SemanticValidationLevel.PackageOnly)
    {
      this._attribute = attribute;
      this._caseSensitive = caseSensitive;
    }

    public override ValidationErrorInfo Validate(ValidationContext context)
    {
      OpenXmlSimpleType attributeValue = context.Element.Attributes[(int) this._attribute];
      if (attributeValue == null || string.IsNullOrEmpty(attributeValue.InnerText))
        return (ValidationErrorInfo) null;
      bool flag = false;
      if (this._values.Where<string>((Func<string, bool>) (v => string.Compare(v, attributeValue.InnerText, !this._caseSensitive, CultureInfo.InvariantCulture) == 0)).Count<string>() > 0)
        flag = true;
      else
        this._values.Add(attributeValue.InnerText);
      if (!flag)
        return (ValidationErrorInfo) null;
      string str = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Sem_AttributeValueUniqueInDocument, new object[2]
      {
        (object) SemanticConstraint.GetAttributeQualifiedName(context.Element, this._attribute),
        (object) attributeValue
      });
      return new ValidationErrorInfo()
      {
        Id = "Sem_AttributeValueUniqueInDocument",
        ErrorType = ValidationErrorType.Semantic,
        Node = context.Element,
        Description = str
      };
    }

    public override void ClearState(ValidationContext context)
    {
      this._values.Clear();
    }
  }
}

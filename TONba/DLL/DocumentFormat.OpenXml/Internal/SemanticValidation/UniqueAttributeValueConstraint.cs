// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SemanticValidation.UniqueAttributeValueConstraint
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
  internal class UniqueAttributeValueConstraint : SemanticConstraint
  {
    private Stack<List<string>> _stateStack = new Stack<List<string>>();
    private List<string> _values = new List<string>();
    private byte _attribute;
    private SemanticConstraintRegistry _reg;
    private bool _caseSensitive;
    private bool _partLevel;

    public UniqueAttributeValueConstraint(byte attribute, bool caseSensitive, bool partLevel, SemanticConstraintRegistry reg)
      : base(SemanticValidationLevel.Part)
    {
      this._attribute = attribute;
      this._reg = reg;
      this._caseSensitive = caseSensitive;
      this._partLevel = partLevel;
    }

    public override ValidationErrorInfo Validate(ValidationContext context)
    {
      if (this._values == null)
        return (ValidationErrorInfo) null;
      OpenXmlSimpleType attributeValue = context.Element.Attributes[(int) this._attribute];
      if (attributeValue == null || string.IsNullOrEmpty(attributeValue.InnerText))
        return (ValidationErrorInfo) null;
      if (this._values.Where<string>((Func<string, bool>) (v => string.Compare(v, attributeValue.InnerText, !this._caseSensitive, CultureInfo.InvariantCulture) == 0)).Count<string>() == 0)
      {
        this._values.Add(attributeValue.InnerText);
        return (ValidationErrorInfo) null;
      }
      return new ValidationErrorInfo()
      {
        Id = "Sem_UniqueAttributeValue",
        ErrorType = ValidationErrorType.Semantic,
        Node = context.Element,
        Description = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Sem_UniqueAttributeValue, new object[2]
        {
          (object) SemanticConstraint.GetAttributeQualifiedName(context.Element, this._attribute),
          (object) attributeValue.InnerText
        })
      };
    }

    public void AdjustState()
    {
      if (this._stateStack.Count<List<string>>() != 0)
        this._values = this._stateStack.Pop();
      else
        this._values = (List<string>) null;
    }

    public override void ClearState(ValidationContext context)
    {
      if (context == null)
      {
        this._stateStack.Clear();
        this._values = this._partLevel ? new List<string>() : (List<string>) null;
      }
      else
      {
        if (this._values != null)
          this._stateStack.Push(this._values);
        this._reg.AddCallBackMethod(context.Element, new CallBackMethod(this.AdjustState));
        this._values = new List<string>();
      }
    }
  }
}

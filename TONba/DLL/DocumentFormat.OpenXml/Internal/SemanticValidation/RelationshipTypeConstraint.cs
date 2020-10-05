// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SemanticValidation.RelationshipTypeConstraint
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace DocumentFormat.OpenXml.Internal.SemanticValidation
{
  internal class RelationshipTypeConstraint : SemanticConstraint
  {
    private byte _attribute;
    private string _type;

    public RelationshipTypeConstraint(byte attribute, string type)
      : base(SemanticValidationLevel.Part)
    {
      this._attribute = attribute;
      this._type = type;
    }

    public override ValidationErrorInfo Validate(ValidationContext context)
    {
      OpenXmlSimpleType attributeValue = context.Element.Attributes[(int) this._attribute];
      if (attributeValue == null || string.IsNullOrEmpty(attributeValue.InnerText))
        return (ValidationErrorInfo) null;
      string str = this._type;
      IEnumerable<ExternalRelationship> source1 = context.Part.ExternalRelationships.Where<ExternalRelationship>((Func<ExternalRelationship, bool>) (r => r.Id == attributeValue.InnerText));
      if (source1.Count<ExternalRelationship>() == 0)
      {
        IEnumerable<IdPartPair> source2 = context.Part.Parts.Where<IdPartPair>((Func<IdPartPair, bool>) (p => p.RelationshipId == attributeValue.InnerText));
        if (source2.Count<IdPartPair>() != 0)
          str = source2.First<IdPartPair>().OpenXmlPart.RelationshipType;
      }
      else
        str = source1.First<ExternalRelationship>().RelationshipType;
      if (str == this._type)
        return (ValidationErrorInfo) null;
      return new ValidationErrorInfo()
      {
        Id = "Sem_IncorrectRelationshipType",
        ErrorType = ValidationErrorType.Semantic,
        Node = context.Element,
        Description = string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Sem_IncorrectRelationshipType, (object) str, (object) SemanticConstraint.GetAttributeQualifiedName(context.Element, this._attribute), (object) this._type)
      };
    }
  }
}

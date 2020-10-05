// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SemanticValidation.SemanticConstraint
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml;

namespace DocumentFormat.OpenXml.Internal.SemanticValidation
{
  internal abstract class SemanticConstraint
  {
    public readonly SemanticValidationLevel SemanticValidationLevel;

    internal string ConstratintId
    {
      get
      {
        return string.Empty;
      }
      set
      {
      }
    }

    public virtual SemanticValidationLevel StateScope
    {
      get
      {
        return this.SemanticValidationLevel;
      }
    }

    public SemanticConstraint(SemanticValidationLevel level)
    {
      this.SemanticValidationLevel = level;
    }

    public virtual void ClearState(ValidationContext context)
    {
    }

    public abstract ValidationErrorInfo Validate(ValidationContext context);

    protected static OpenXmlPart GetReferencedPart(ValidationContext context, string path)
    {
      if (path == ".")
        return context.Part;
      string[] path1 = path.Split('/');
      if (string.IsNullOrEmpty(path1[0]))
        return SemanticConstraint.GetPartThroughPartPath(context.Package.Parts, ((IEnumerable<string>) path1).Skip<string>(1).ToArray<string>());
      if (path1[0] == "..")
        return new OpenXmlPackagePartIterator(context.Package).Where<OpenXmlPart>((Func<OpenXmlPart, bool>) (p => p.Parts.Select<IdPartPair, Uri>((Func<IdPartPair, Uri>) (r => r.OpenXmlPart.PackagePart.Uri)).Contains<Uri>(context.Part.PackagePart.Uri))).First<OpenXmlPart>();
      return SemanticConstraint.GetPartThroughPartPath(context.Part.Parts, path1);
    }

    protected static XmlQualifiedName GetAttributeQualifiedName(OpenXmlElement element, byte attributeID)
    {
      return new XmlQualifiedName(element.AttributeTagNames[(int) attributeID], NamespaceIdMap.GetNamespaceUri(element.AttributeNamespaceIds[(int) attributeID]));
    }

    private static bool CompareBooleanValue(bool value1, string value2)
    {
      bool result;
      if (bool.TryParse(value2, out result))
        return value1 == result;
      return false;
    }

    protected static bool AttributeValueEquals(OpenXmlSimpleType type, string value, bool ignoreCase)
    {
      HexBinaryValue hexBinaryValue = type as HexBinaryValue;
      if (hexBinaryValue != null)
      {
        if (!hexBinaryValue.HasValue)
          return true;
        return Convert.ToInt64(hexBinaryValue.Value, 16) == Convert.ToInt64(value, 16);
      }
      BooleanValue booleanValue = type as BooleanValue;
      if (booleanValue != null)
      {
        if (!booleanValue.HasValue)
          return false;
        if (SemanticConstraint.CompareBooleanValue(booleanValue.Value, value))
          return true;
      }
      OnOffValue onOffValue = type as OnOffValue;
      if (onOffValue != null)
      {
        if (!onOffValue.HasValue)
          return false;
        if (SemanticConstraint.CompareBooleanValue(onOffValue.Value, value))
          return true;
      }
      TrueFalseValue trueFalseValue = type as TrueFalseValue;
      if (trueFalseValue != null)
      {
        if (!trueFalseValue.HasValue)
          return false;
        if (SemanticConstraint.CompareBooleanValue(trueFalseValue.Value, value))
          return true;
      }
      TrueFalseBlankValue trueFalseBlankValue = type as TrueFalseBlankValue;
      if (trueFalseBlankValue != null)
      {
        if (!trueFalseBlankValue.HasValue)
          return false;
        if (SemanticConstraint.CompareBooleanValue(trueFalseBlankValue.Value, value))
          return true;
      }
      if (ignoreCase)
        return string.Equals(value, type.InnerText, StringComparison.OrdinalIgnoreCase);
      return string.Equals(value, type.InnerText, StringComparison.Ordinal);
    }

    protected static bool GetAttrNumVal(OpenXmlSimpleType attributeValue, out double value)
    {
      HexBinaryValue hexBinaryValue = attributeValue as HexBinaryValue;
      if (hexBinaryValue == null)
        return double.TryParse(attributeValue.InnerText, out value);
      long result = -1;
      bool flag = long.TryParse(hexBinaryValue.Value, NumberStyles.HexNumber, (IFormatProvider) CultureInfo.InvariantCulture, out result);
      value = (double) result;
      return flag;
    }

    private static OpenXmlPart GetPartThroughPartPath(IEnumerable<IdPartPair> pairs, string[] path)
    {
      OpenXmlPart openXmlPart = (OpenXmlPart) null;
      IEnumerable<IdPartPair> source1 = pairs;
      for (int i = 0; i < path.Length; ++i)
      {
        IEnumerable<OpenXmlPart> source2 = source1.Where<IdPartPair>((Func<IdPartPair, bool>) (p => p.OpenXmlPart.GetType().Name == path[i])).Select<IdPartPair, OpenXmlPart>((Func<IdPartPair, OpenXmlPart>) (t => t.OpenXmlPart));
        if (source2.Count<OpenXmlPart>() == 0)
          return (OpenXmlPart) null;
        openXmlPart = source2.First<OpenXmlPart>();
        source1 = openXmlPart.Parts;
      }
      return openXmlPart;
    }
  }
}

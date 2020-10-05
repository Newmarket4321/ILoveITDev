// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.SimpleTypeRestriction
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Diagnostics;
using System.Globalization;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  [DebuggerDisplay("RestrictionField={RestrictionField}")]
  [Serializable]
  internal abstract class SimpleTypeRestriction
  {
    [NonSerialized]
    private FileFormatVersions _fileFormat;

    internal FileFormatVersions FileFormat
    {
      get
      {
        return this._fileFormat;
      }
      set
      {
        this._fileFormat = value;
      }
    }

    public SimpleTypeRestriction()
    {
      this.RestrictionField = RestrictionField.None;
    }

    public abstract XsdType XsdType { get; set; }

    public abstract string ClrTypeName { get; }

    public virtual bool IsEnum
    {
      get
      {
        return false;
      }
    }

    public virtual bool IsList
    {
      get
      {
        return false;
      }
    }

    public string Pattern { get; set; }

    public virtual int MaxLength
    {
      get
      {
        throw new InvalidOperationException();
      }
      set
      {
        throw new InvalidOperationException();
      }
    }

    public virtual int MinLength
    {
      get
      {
        throw new InvalidOperationException();
      }
      set
      {
        throw new InvalidOperationException();
      }
    }

    public virtual int Length
    {
      get
      {
        throw new InvalidOperationException();
      }
      set
      {
        throw new InvalidOperationException();
      }
    }

    public virtual string GetRestrictionValue(RestrictionField restrictionField)
    {
      switch (restrictionField)
      {
        case RestrictionField.Length:
          return this.Length.ToString((IFormatProvider) CultureInfo.CurrentUICulture);
        case RestrictionField.MinLength:
          return this.MinLength.ToString((IFormatProvider) CultureInfo.CurrentUICulture);
        case RestrictionField.MaxLength:
          return this.MaxLength.ToString((IFormatProvider) CultureInfo.CurrentUICulture);
        case RestrictionField.Pattern:
          return this.Pattern;
        default:
          return string.Empty;
      }
    }

    public RestrictionField RestrictionField { get; set; }

    public virtual bool ValidateValueType(OpenXmlSimpleType attributeValue)
    {
      return attributeValue.HasValue;
    }

    public RestrictionField Validate(OpenXmlSimpleType attributeValue)
    {
      RestrictionField restrictionField = RestrictionField.None;
      if ((this.RestrictionField & RestrictionField.Pattern) == RestrictionField.Pattern && !this.IsPatternValid(attributeValue))
        restrictionField |= RestrictionField.Pattern;
      if ((this.RestrictionField & RestrictionField.Length) == RestrictionField.Length && !this.IsLengthValid(attributeValue))
        restrictionField |= RestrictionField.Length;
      if ((this.RestrictionField & RestrictionField.MinLength) == RestrictionField.MinLength && !this.IsMinLengthValid(attributeValue))
        restrictionField |= RestrictionField.MinLength;
      if ((this.RestrictionField & RestrictionField.MaxLength) == RestrictionField.MaxLength && !this.IsMaxLengthValid(attributeValue))
        restrictionField |= RestrictionField.MaxLength;
      if ((this.RestrictionField & RestrictionField.MinInclusive) == RestrictionField.MinInclusive && !this.IsMinInclusiveValid(attributeValue))
        restrictionField |= RestrictionField.MinInclusive;
      if ((this.RestrictionField & RestrictionField.MinExclusive) == RestrictionField.MinExclusive && !this.IsMinExclusiveValid(attributeValue))
        restrictionField |= RestrictionField.MinExclusive;
      if ((this.RestrictionField & RestrictionField.MaxInclusive) == RestrictionField.MaxInclusive && !this.IsMaxInclusiveValid(attributeValue))
        restrictionField |= RestrictionField.MaxInclusive;
      if ((this.RestrictionField & RestrictionField.MaxExclusive) == RestrictionField.MaxExclusive && !this.IsMaxExclusiveValid(attributeValue))
        restrictionField |= RestrictionField.MaxExclusive;
      return restrictionField;
    }

    public virtual bool IsPatternValid(OpenXmlSimpleType attributeValue)
    {
      return true;
    }

    public virtual bool IsLengthValid(OpenXmlSimpleType attributeValue)
    {
      throw new NotImplementedException();
    }

    public virtual bool IsMinLengthValid(OpenXmlSimpleType attributeValue)
    {
      throw new NotImplementedException();
    }

    public virtual bool IsMaxLengthValid(OpenXmlSimpleType attributeValue)
    {
      throw new NotImplementedException();
    }

    public virtual bool IsMinInclusiveValid(OpenXmlSimpleType attributeValue)
    {
      throw new NotImplementedException();
    }

    public virtual bool IsMinExclusiveValid(OpenXmlSimpleType attributeValue)
    {
      throw new NotImplementedException();
    }

    public virtual bool IsMaxInclusiveValid(OpenXmlSimpleType attributeValue)
    {
      throw new NotImplementedException();
    }

    public virtual bool IsMaxExclusiveValid(OpenXmlSimpleType attributeValue)
    {
      throw new NotImplementedException();
    }
  }
}

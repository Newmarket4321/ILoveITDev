// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.SimpleValueRestriction`2
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  [Serializable]
  internal abstract class SimpleValueRestriction<T, ST> : SimpleTypeRestriction where T : struct, IComparable<T> where ST : OpenXmlSimpleValue<T>, new()
  {
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [NonSerialized]
    private static readonly string clrTypeName = typeof (T).Name;

    protected abstract T MinValue { get; }

    protected abstract T MaxValue { get; }

    public SimpleValueRestriction()
    {
      this.MinInclusive = this.MinValue;
      this.MaxInclusive = this.MaxValue;
    }

    public override string ClrTypeName
    {
      get
      {
        return SimpleValueRestriction<T, ST>.clrTypeName;
      }
    }

    public T MinInclusive { get; set; }

    public T MaxInclusive { get; set; }

    public T MinExclusive { get; set; }

    public T MaxExclusive { get; set; }

    public override string GetRestrictionValue(RestrictionField restrictionField)
    {
      RestrictionField restrictionField1 = restrictionField;
      if ((uint) restrictionField1 <= 16U)
      {
        if (restrictionField1 == RestrictionField.MinInclusive)
          return this.MinInclusive.ToString();
        if (restrictionField1 == RestrictionField.MaxInclusive)
          return this.MaxInclusive.ToString();
      }
      else
      {
        if (restrictionField1 == RestrictionField.MinExclusive)
          return this.MinExclusive.ToString();
        if (restrictionField1 == RestrictionField.MaxExclusive)
          return this.MaxExclusive.ToString();
      }
      return base.GetRestrictionValue(restrictionField);
    }

    public virtual OpenXmlSimpleValue<T> StringToSimpleValue(string valueText)
    {
      if (string.IsNullOrEmpty(valueText))
        return (OpenXmlSimpleValue<T>) null;
      ST instance = Activator.CreateInstance<ST>();
      instance.InnerText = valueText;
      return (OpenXmlSimpleValue<T>) instance;
    }

    public override bool IsMinInclusiveValid(OpenXmlSimpleType attributeValue)
    {
      return (this.RestrictionField & RestrictionField.MinInclusive) != RestrictionField.MinInclusive || this.MinInclusive.CompareTo(((ST) attributeValue).Value) <= 0;
    }

    public override bool IsMinExclusiveValid(OpenXmlSimpleType attributeValue)
    {
      return (this.RestrictionField & RestrictionField.MinExclusive) != RestrictionField.MinExclusive || this.MinExclusive.CompareTo(((ST) attributeValue).Value) < 0;
    }

    public override bool IsMaxInclusiveValid(OpenXmlSimpleType attributeValue)
    {
      return (this.RestrictionField & RestrictionField.MaxInclusive) != RestrictionField.MaxInclusive || this.MaxInclusive.CompareTo(((ST) attributeValue).Value) >= 0;
    }

    public override bool IsMaxExclusiveValid(OpenXmlSimpleType attributeValue)
    {
      return (this.RestrictionField & RestrictionField.MaxExclusive) != RestrictionField.MaxExclusive || this.MaxExclusive.CompareTo(((ST) attributeValue).Value) > 0;
    }

    public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
    {
      if (!attributeValue.HasValue)
        return false;
      ST st = (ST) attributeValue;
      return st.Value.CompareTo(this.MinValue) >= 0 && st.Value.CompareTo(this.MaxValue) <= 0;
    }
  }
}

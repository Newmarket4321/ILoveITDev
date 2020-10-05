// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.EnumValue`1
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace DocumentFormat.OpenXml
{
  [DebuggerDisplay("{InnerText}")]
  public class EnumValue<T> : OpenXmlSimpleType where T : struct
  {
    private static object lockroot = new object();
    private const int Threshold = 11;
    private T? _enumValue;
    private static int parseCount;
    private static Dictionary<string, T> stringToValueLookupTable;
    private static Dictionary<T, FileFormatVersions> fileFormatInformations;
    private static bool fileFormatInformationLoaded;

    public EnumValue()
    {
    }

    public EnumValue(T value)
    {
      if (!Enum.IsDefined(typeof (T), (object) value))
        throw new ArgumentOutOfRangeException(nameof (value), ExceptionMessages.InvalidEnumValue);
      this.Value = value;
    }

    public EnumValue(EnumValue<T> source)
      : base((OpenXmlSimpleType) source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      this._enumValue = source._enumValue;
    }

    public override bool HasValue
    {
      get
      {
        if (!this._enumValue.HasValue && this.TextValue != null)
          this.TryParse();
        return this._enumValue.HasValue;
      }
    }

    public T Value
    {
      get
      {
        if (!this._enumValue.HasValue && !string.IsNullOrEmpty(this.TextValue))
          this.Parse();
        return this._enumValue.Value;
      }
      set
      {
        if (!Enum.IsDefined(typeof (T), (object) value))
          throw new ArgumentOutOfRangeException(nameof (value), ExceptionMessages.InvalidEnumValue);
        this._enumValue = new T?(value);
        this.TextValue = (string) null;
      }
    }

    public override string InnerText
    {
      get
      {
        if (this.TextValue == null && this._enumValue.HasValue)
          this.TextValue = EnumValue<T>.ToString(this._enumValue.Value);
        return this.TextValue;
      }
      set
      {
        this.TextValue = value;
        this._enumValue = new T?();
      }
    }

    public static implicit operator T(EnumValue<T> xmlAttribute)
    {
      if (xmlAttribute == null)
        throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
      return xmlAttribute.Value;
    }

    public static implicit operator EnumValue<T>(T value)
    {
      return new EnumValue<T>(value);
    }

    public static implicit operator string(EnumValue<T> value)
    {
      if (value == null)
        return (string) null;
      return value.InnerText;
    }

    internal override OpenXmlSimpleType CloneImp()
    {
      return (OpenXmlSimpleType) new EnumValue<T>(this);
    }

    internal override void Parse()
    {
      this._enumValue = new T?(EnumValue<T>.GetEnumValue(this.TextValue));
    }

    internal override bool TryParse()
    {
      this._enumValue = new T?();
      T result;
      if (!EnumValue<T>.TryGetEnumValue(this.TextValue, out result))
        return false;
      this._enumValue = new T?(result);
      return true;
    }

    internal static string ToString(T enumVal)
    {
      EnumStringAttribute customAttribute = Attribute.GetCustomAttribute((MemberInfo) enumVal.GetType().GetField(enumVal.ToString()), typeof (EnumStringAttribute)) as EnumStringAttribute;
      if (customAttribute != null)
        return customAttribute.Value;
      return string.Empty;
    }

    internal static bool TryGetEnumValue(string stringVal, out T result)
    {
      if (EnumValue<T>.parseCount > 11)
      {
        if (EnumValue<T>.stringToValueLookupTable == null)
        {
          Dictionary<string, T> dictionary = new Dictionary<string, T>();
          foreach (T obj in Enum.GetValues(typeof (T)))
          {
            EnumStringAttribute customAttribute = Attribute.GetCustomAttribute((MemberInfo) obj.GetType().GetField(obj.ToString()), typeof (EnumStringAttribute)) as EnumStringAttribute;
            dictionary.Add(customAttribute.Value, obj);
          }
          EnumValue<T>.stringToValueLookupTable = dictionary;
        }
        return EnumValue<T>.stringToValueLookupTable.TryGetValue(stringVal, out result);
      }
      ++EnumValue<T>.parseCount;
      foreach (T obj in Enum.GetValues(typeof (T)))
      {
        EnumStringAttribute customAttribute = Attribute.GetCustomAttribute((MemberInfo) obj.GetType().GetField(obj.ToString()), typeof (EnumStringAttribute)) as EnumStringAttribute;
        if (customAttribute != null && customAttribute.Value == stringVal)
        {
          result = obj;
          return true;
        }
      }
      result = default (T);
      return false;
    }

    internal static T GetEnumValue(string stringVal)
    {
      T result;
      if (EnumValue<T>.TryGetEnumValue(stringVal, out result))
        return result;
      throw new FormatException(ExceptionMessages.TextIsInvalidEnumValue);
    }

    internal override bool IsInVersion(FileFormatVersions fileFormat)
    {
      if (!EnumValue<T>.fileFormatInformationLoaded && EnumValue<T>.fileFormatInformations == null)
      {
        Dictionary<T, FileFormatVersions> dictionary = (Dictionary<T, FileFormatVersions>) null;
        foreach (T key in Enum.GetValues(typeof (T)))
        {
          OfficeAvailabilityAttribute customAttribute = Attribute.GetCustomAttribute((MemberInfo) this.Value.GetType().GetField(key.ToString()), typeof (OfficeAvailabilityAttribute)) as OfficeAvailabilityAttribute;
          if (customAttribute != null)
          {
            if (dictionary == null)
              dictionary = new Dictionary<T, FileFormatVersions>();
            dictionary.Add(key, customAttribute.OfficeVersion);
          }
        }
        lock (EnumValue<T>.lockroot)
        {
          EnumValue<T>.fileFormatInformations = dictionary;
          EnumValue<T>.fileFormatInformationLoaded = true;
        }
      }
      FileFormatVersions source;
      if (EnumValue<T>.fileFormatInformations != null && EnumValue<T>.fileFormatInformations.TryGetValue(this.Value, out source))
        return source.Includes(fileFormat);
      return true;
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Internal.SchemaValidation.ExpectedChildren
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Validation;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
  internal class ExpectedChildren
  {
    private ICollection<int> _elementTypeIds;
    private ICollection<string> _xsdanyNamespaces;

    internal ExpectedChildren()
    {
    }

    internal void Add(int elementTypeId)
    {
      if (this._elementTypeIds == null)
        this._elementTypeIds = (ICollection<int>) new List<int>();
      this._elementTypeIds.Add(elementTypeId);
    }

    internal void Add(string namesapceForXsdany)
    {
      if (this._xsdanyNamespaces == null)
        this._xsdanyNamespaces = (ICollection<string>) new List<string>();
      this._xsdanyNamespaces.Add(namesapceForXsdany);
    }

    internal void Add(ExpectedChildren expectedChildren)
    {
      if (expectedChildren._elementTypeIds != null && expectedChildren._elementTypeIds.Count > 0)
      {
        if (this._elementTypeIds == null)
          this._elementTypeIds = (ICollection<int>) new List<int>();
        foreach (int elementTypeId in (IEnumerable<int>) expectedChildren._elementTypeIds)
          this._elementTypeIds.Add(elementTypeId);
      }
      if (expectedChildren._xsdanyNamespaces == null || expectedChildren._xsdanyNamespaces.Count <= 0)
        return;
      if (this._xsdanyNamespaces == null)
        this._xsdanyNamespaces = (ICollection<string>) new List<string>();
      foreach (string xsdanyNamespace in (IEnumerable<string>) expectedChildren._xsdanyNamespaces)
        this._xsdanyNamespaces.Add(xsdanyNamespace);
    }

    internal int Count
    {
      get
      {
        int num = 0;
        if (this._elementTypeIds != null)
          num = this._elementTypeIds.Count;
        if (this._xsdanyNamespaces != null)
          num += this._xsdanyNamespaces.Count;
        return num;
      }
    }

    internal string GetExpectedChildrenMessage(OpenXmlElement parent)
    {
      if (this._elementTypeIds == null && this._xsdanyNamespaces == null)
        return string.Empty;
      StringBuilder stringBuilder = new StringBuilder();
      string str = string.Empty;
      if (this._elementTypeIds != null)
      {
        foreach (OpenXmlElement childrenElementsById in (IEnumerable<OpenXmlElement>) parent.CreateChildrenElementsByIds((IEnumerable<int>) this._elementTypeIds))
        {
          stringBuilder.Append(str);
          stringBuilder.Append(string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Fmt_ElementName, new object[2]
          {
            (object) childrenElementsById.NamespaceUri,
            (object) childrenElementsById.LocalName
          }));
          str = ValidationResources.Fmt_ElementNameSeparator;
        }
      }
      if (this._xsdanyNamespaces != null)
      {
        foreach (string xsdanyNamespace in (IEnumerable<string>) this._xsdanyNamespaces)
        {
          stringBuilder.Append(str);
          stringBuilder.Append(string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Fmt_AnyElementInNamespace, new object[1]
          {
            (object) xsdanyNamespace
          }));
        }
      }
      return string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ValidationResources.Fmt_ListOfPossibleElements, new object[1]
      {
        (object) stringBuilder.ToString()
      });
    }

    internal void Clear()
    {
      if (this._elementTypeIds != null)
        this._elementTypeIds.Clear();
      if (this._xsdanyNamespaces == null)
        return;
      this._xsdanyNamespaces.Clear();
    }
  }
}

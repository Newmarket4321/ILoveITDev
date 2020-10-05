// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.SchemaAttrAttribute
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;

namespace DocumentFormat.OpenXml
{
  [AttributeUsage(AttributeTargets.Property)]
  public sealed class SchemaAttrAttribute : Attribute
  {
    private string _tag;
    private byte _nsId;

    public SchemaAttrAttribute(byte nsId, string tag)
    {
      if (string.IsNullOrEmpty(tag))
        throw new ArgumentNullException(nameof (tag));
      this._nsId = nsId;
      this._tag = tag;
    }

    public string Tag
    {
      get
      {
        return this._tag;
      }
    }

    public string NamespaceUri
    {
      get
      {
        return NamespaceIdMap.GetNamespaceUri(this._nsId);
      }
    }
  }
}

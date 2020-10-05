// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.OpenXmlAttribute
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Xml;

namespace DocumentFormat.OpenXml
{
  public struct OpenXmlAttribute : IEquatable<OpenXmlAttribute>
  {
    private string _namespaceUri;
    private string _tagName;
    private string _prefix;
    private string _value;

    public OpenXmlAttribute(string qualifiedName, string namespaceUri, string value)
    {
      if (string.IsNullOrEmpty(qualifiedName))
        throw new ArgumentNullException(nameof (qualifiedName));
      this._namespaceUri = namespaceUri;
      OpenXmlElement.SplitName(qualifiedName, out this._prefix, out this._tagName);
      this._value = value;
    }

    public OpenXmlAttribute(string prefix, string localName, string namespaceUri, string value)
    {
      if (string.IsNullOrEmpty(localName))
        throw new ArgumentNullException(nameof (localName));
      this._namespaceUri = namespaceUri;
      this._tagName = localName;
      this._prefix = prefix;
      this._value = value;
    }

    public string NamespaceUri
    {
      get
      {
        if (this._namespaceUri == null)
          return string.Empty;
        return this._namespaceUri;
      }
      set
      {
        this._namespaceUri = value;
      }
    }

    public string LocalName
    {
      get
      {
        return this._tagName;
      }
      set
      {
        this._tagName = value;
      }
    }

    public string Prefix
    {
      get
      {
        return this._prefix;
      }
      set
      {
        this._prefix = value;
      }
    }

    public string Value
    {
      get
      {
        return this._value;
      }
      set
      {
        this._value = value;
      }
    }

    public XmlQualifiedName XmlQualifiedName
    {
      get
      {
        return new XmlQualifiedName(this._tagName, this._namespaceUri);
      }
    }

    public bool Equals(OpenXmlAttribute other)
    {
      if (this.LocalName == other.LocalName && this.NamespaceUri == other.NamespaceUri && this.Prefix == other.Prefix)
        return this.Value == other.Value;
      return false;
    }

    public static bool operator ==(OpenXmlAttribute attribute1, OpenXmlAttribute attribute2)
    {
      return attribute1.Equals(attribute2);
    }

    public static bool operator !=(OpenXmlAttribute attribute1, OpenXmlAttribute attribute2)
    {
      return !(attribute1 == attribute2);
    }

    public override bool Equals(object obj)
    {
      if (obj == null || !(obj is OpenXmlAttribute))
        return false;
      return this.Equals((OpenXmlAttribute) obj);
    }

    public override int GetHashCode()
    {
      int num = 0;
      if (this.LocalName != null)
        num ^= this.LocalName.GetHashCode();
      if (this.NamespaceUri != null)
        num ^= this.NamespaceUri.GetHashCode();
      if (this.Prefix != null)
        num ^= this.Prefix.GetHashCode();
      if (this.Value != null)
        num ^= this.Value.GetHashCode();
      return num;
    }
  }
}

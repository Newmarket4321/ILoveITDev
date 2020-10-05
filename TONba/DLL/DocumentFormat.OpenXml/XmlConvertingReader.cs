// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.XmlConvertingReader
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Xml;

namespace DocumentFormat.OpenXml
{
  internal class XmlConvertingReader : XmlReader
  {
    protected XmlReader BaseReader { get; set; }

    private bool _strictTranslation { get; set; }

    internal XmlConvertingReader(XmlReader baseReader, bool strictTranslation)
    {
      if (baseReader == null)
        throw new ArgumentNullException(nameof (baseReader));
      this._strictTranslation = strictTranslation;
      this.BaseReader = baseReader;
    }

    internal bool StrictTranslation
    {
      get
      {
        return this._strictTranslation;
      }
    }

    public override void Close()
    {
      this.BaseReader.Close();
    }

    protected override void Dispose(bool disposing)
    {
      if (this.ReadState != ReadState.Closed)
        this.Close();
      ((IDisposable) this.BaseReader).Dispose();
    }

    public override bool Read()
    {
      return this.BaseReader.Read();
    }

    public override string GetAttribute(int index)
    {
      return this.BaseReader.GetAttribute(index);
    }

    public override string GetAttribute(string name)
    {
      return this.BaseReader.GetAttribute(name);
    }

    public override string GetAttribute(string localName, string namespaceURI)
    {
      return this.BaseReader.GetAttribute(localName, namespaceURI);
    }

    public override string LookupNamespace(string prefix)
    {
      return this.BaseReader.LookupNamespace(prefix);
    }

    public override void MoveToAttribute(int index)
    {
      this.BaseReader.MoveToAttribute(index);
    }

    public override bool MoveToAttribute(string name)
    {
      return this.BaseReader.MoveToAttribute(name);
    }

    public override bool MoveToAttribute(string localName, string namespaceURI)
    {
      return this.BaseReader.MoveToAttribute(localName, namespaceURI);
    }

    public override bool MoveToElement()
    {
      return this.BaseReader.MoveToElement();
    }

    public override bool MoveToFirstAttribute()
    {
      return this.BaseReader.MoveToFirstAttribute();
    }

    public override bool MoveToNextAttribute()
    {
      return this.BaseReader.MoveToNextAttribute();
    }

    public override bool ReadAttributeValue()
    {
      return this.BaseReader.ReadAttributeValue();
    }

    public override void ResolveEntity()
    {
      this.BaseReader.ResolveEntity();
    }

    public override int ReadValueChunk(char[] buffer, int index, int count)
    {
      return this.BaseReader.ReadValueChunk(buffer, index, count);
    }

    public override int AttributeCount
    {
      get
      {
        return this.BaseReader.AttributeCount;
      }
    }

    public override string BaseURI
    {
      get
      {
        return this.BaseReader.BaseURI;
      }
    }

    public override bool CanReadBinaryContent
    {
      get
      {
        return this.BaseReader.CanReadBinaryContent;
      }
    }

    public override bool CanReadValueChunk
    {
      get
      {
        return this.BaseReader.CanReadValueChunk;
      }
    }

    public override bool CanResolveEntity
    {
      get
      {
        return this.BaseReader.CanResolveEntity;
      }
    }

    public override int Depth
    {
      get
      {
        return this.BaseReader.Depth;
      }
    }

    public override bool EOF
    {
      get
      {
        return this.BaseReader.EOF;
      }
    }

    public override bool HasValue
    {
      get
      {
        return this.BaseReader.HasValue;
      }
    }

    public override bool IsDefault
    {
      get
      {
        return this.BaseReader.IsDefault;
      }
    }

    public override bool IsEmptyElement
    {
      get
      {
        return this.BaseReader.IsEmptyElement;
      }
    }

    public override string this[int index]
    {
      get
      {
        return this.BaseReader[index];
      }
    }

    public override string this[string name]
    {
      get
      {
        return this.BaseReader[name];
      }
    }

    public override string this[string name, string namespaceURI]
    {
      get
      {
        return this.BaseReader[name, namespaceURI];
      }
    }

    public override string LocalName
    {
      get
      {
        return this.BaseReader.LocalName;
      }
    }

    public override string Name
    {
      get
      {
        return this.BaseReader.Name;
      }
    }

    public override string NamespaceURI
    {
      get
      {
        string str1 = this.BaseReader.NamespaceURI;
        string str2;
        if (!this._strictTranslation ? NamespaceIdMap.TryGetExtendedNamespace(str1, out str2) : NamespaceIdMap.TryGetTransitionalNamespace(str1, out str2))
          str1 = str2;
        return str1;
      }
    }

    public override XmlNameTable NameTable
    {
      get
      {
        return this.BaseReader.NameTable;
      }
    }

    public override XmlNodeType NodeType
    {
      get
      {
        return this.BaseReader.NodeType;
      }
    }

    public override string Prefix
    {
      get
      {
        return this.BaseReader.Prefix;
      }
    }

    public override char QuoteChar
    {
      get
      {
        return this.BaseReader.QuoteChar;
      }
    }

    public override ReadState ReadState
    {
      get
      {
        return this.BaseReader.ReadState;
      }
    }

    public override string Value
    {
      get
      {
        string str1 = this.BaseReader.Value;
        string str2;
        if (this.BaseReader.NodeType == XmlNodeType.Attribute && (!this._strictTranslation ? NamespaceIdMap.TryGetExtendedNamespace(str1, out str2) : NamespaceIdMap.TryGetTransitionalNamespace(str1, out str2)))
          str1 = str2;
        return str1;
      }
    }

    public override string XmlLang
    {
      get
      {
        return this.BaseReader.XmlLang;
      }
    }

    public override XmlSpace XmlSpace
    {
      get
      {
        return this.BaseReader.XmlSpace;
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.OpenXmlReader
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;

namespace DocumentFormat.OpenXml
{
  public abstract class OpenXmlReader : IDisposable
  {
    private bool _disposed;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool _readMiscNodes;

    protected OpenXmlReader()
    {
    }

    protected OpenXmlReader(bool readMiscNodes)
    {
      this._readMiscNodes = readMiscNodes;
    }

    public static OpenXmlReader Create(OpenXmlPart openXmlPart)
    {
      return (OpenXmlReader) new OpenXmlPartReader(openXmlPart);
    }

    public static OpenXmlReader Create(OpenXmlPart openXmlPart, bool readMiscNodes)
    {
      return (OpenXmlReader) new OpenXmlPartReader(openXmlPart, readMiscNodes);
    }

    public static OpenXmlReader Create(Stream partStream)
    {
      return (OpenXmlReader) new OpenXmlPartReader(partStream);
    }

    public static OpenXmlReader Create(Stream partStream, bool readMiscNodes)
    {
      return (OpenXmlReader) new OpenXmlPartReader(partStream, readMiscNodes);
    }

    public static OpenXmlReader Create(OpenXmlElement openXmlElement)
    {
      return (OpenXmlReader) new OpenXmlDomReader(openXmlElement);
    }

    public static OpenXmlReader Create(OpenXmlElement openXmlElement, bool readMiscNodes)
    {
      return (OpenXmlReader) new OpenXmlDomReader(openXmlElement, readMiscNodes);
    }

    public bool ReadMiscNodes
    {
      get
      {
        this.ThrowIfObjectDisposed();
        return this._readMiscNodes;
      }
    }

    public virtual string Encoding
    {
      get
      {
        this.ThrowIfObjectDisposed();
        return (string) null;
      }
    }

    public virtual bool? StandaloneXml
    {
      get
      {
        this.ThrowIfObjectDisposed();
        return new bool?();
      }
    }

    public virtual bool HasAttributes
    {
      get
      {
        this.ThrowIfObjectDisposed();
        return this.Attributes.Count > 0;
      }
    }

    public abstract ReadOnlyCollection<OpenXmlAttribute> Attributes { get; }

    public abstract IEnumerable<KeyValuePair<string, string>> NamespaceDeclarations { get; }

    public abstract Type ElementType { get; }

    public abstract bool IsMiscNode { get; }

    public abstract bool IsStartElement { get; }

    public abstract bool IsEndElement { get; }

    public abstract int Depth { get; }

    public abstract bool EOF { get; }

    public abstract string LocalName { get; }

    public abstract string NamespaceUri { get; }

    public abstract string Prefix { get; }

    public abstract bool Read();

    public abstract bool ReadFirstChild();

    public abstract bool ReadNextSibling();

    public abstract void Skip();

    public abstract OpenXmlElement LoadCurrentElement();

    public abstract string GetText();

    public abstract void Close();

    protected virtual void ThrowIfObjectDisposed()
    {
      if (this._disposed)
        throw new ObjectDisposedException(this.GetType().Name);
    }

    protected virtual void Dispose(bool disposing)
    {
      if (this._disposed)
        return;
      if (disposing)
        this.Close();
      this._disposed = true;
    }

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }
  }
}

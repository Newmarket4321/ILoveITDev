// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.OpenXmlWriter
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DocumentFormat.OpenXml
{
  public abstract class OpenXmlWriter : IDisposable
  {
    private bool _disposed;

    public static OpenXmlWriter Create(OpenXmlPart openXmlPart)
    {
      return (OpenXmlWriter) new OpenXmlPartWriter(openXmlPart);
    }

    public static OpenXmlWriter Create(OpenXmlPart openXmlPart, Encoding encoding)
    {
      return (OpenXmlWriter) new OpenXmlPartWriter(openXmlPart, encoding);
    }

    public static OpenXmlWriter Create(Stream partStream)
    {
      return (OpenXmlWriter) new OpenXmlPartWriter(partStream);
    }

    public static OpenXmlWriter Create(Stream partStream, Encoding encoding)
    {
      return (OpenXmlWriter) new OpenXmlPartWriter(partStream, encoding);
    }

    public abstract void WriteStartDocument();

    public abstract void WriteStartDocument(bool standalone);

    public abstract void WriteStartElement(OpenXmlReader elementReader);

    public abstract void WriteStartElement(OpenXmlReader elementReader, IEnumerable<OpenXmlAttribute> attributes);

    public abstract void WriteStartElement(OpenXmlReader elementReader, IEnumerable<OpenXmlAttribute> attributes, IEnumerable<KeyValuePair<string, string>> namespaceDeclarations);

    public abstract void WriteStartElement(OpenXmlElement elementObject);

    public abstract void WriteStartElement(OpenXmlElement elementObject, IEnumerable<OpenXmlAttribute> attributes);

    public abstract void WriteStartElement(OpenXmlElement elementObject, IEnumerable<OpenXmlAttribute> attributes, IEnumerable<KeyValuePair<string, string>> namespaceDeclarations);

    public abstract void WriteEndElement();

    public abstract void WriteElement(OpenXmlElement elementObject);

    public abstract void WriteString(string text);

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

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.OpenXmlPartWriter
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace DocumentFormat.OpenXml
{
  public class OpenXmlPartWriter : OpenXmlWriter
  {
    private static Type _openXmlLeafTextElementClass;
    private XmlWriter _xmlWriter;
    private bool _isLeafTextElementStart;

    private static Type OpenXmlLeafTextElementClass
    {
      get
      {
        if (OpenXmlPartWriter._openXmlLeafTextElementClass == (Type) null)
          OpenXmlPartWriter._openXmlLeafTextElementClass = typeof (OpenXmlLeafTextElement);
        return OpenXmlPartWriter._openXmlLeafTextElementClass;
      }
    }

    public OpenXmlPartWriter(OpenXmlPart openXmlPart)
      : this(openXmlPart, Encoding.UTF8)
    {
    }

    public OpenXmlPartWriter(OpenXmlPart openXmlPart, Encoding encoding)
    {
      if (openXmlPart == null)
        throw new ArgumentNullException(nameof (openXmlPart));
      if (encoding == null)
        throw new ArgumentNullException(nameof (encoding));
      this.Init(openXmlPart.GetStream(FileMode.Create), true, encoding);
    }

    public OpenXmlPartWriter(Stream partStream)
      : this(partStream, Encoding.UTF8)
    {
    }

    public OpenXmlPartWriter(Stream partStream, Encoding encoding)
    {
      if (partStream == null)
        throw new ArgumentNullException(nameof (partStream));
      if (encoding == null)
        throw new ArgumentNullException(nameof (encoding));
      this.Init(partStream, false, encoding);
    }

    public override void WriteStartDocument()
    {
      this.ThrowIfObjectDisposed();
      this._xmlWriter.WriteStartDocument();
    }

    public override void WriteStartDocument(bool standalone)
    {
      this.ThrowIfObjectDisposed();
      this._xmlWriter.WriteStartDocument(standalone);
    }

    public override void WriteStartElement(OpenXmlReader elementReader)
    {
      this.WriteStartElement(elementReader, (IEnumerable<OpenXmlAttribute>) elementReader.Attributes, elementReader.NamespaceDeclarations);
    }

    public override void WriteStartElement(OpenXmlReader elementReader, IEnumerable<OpenXmlAttribute> attributes)
    {
      this.WriteStartElement(elementReader, attributes, elementReader.NamespaceDeclarations);
    }

    public override void WriteStartElement(OpenXmlReader elementReader, IEnumerable<OpenXmlAttribute> attributes, IEnumerable<KeyValuePair<string, string>> namespaceDeclarations)
    {
      if (elementReader == null)
        throw new ArgumentNullException(nameof (elementReader));
      if (elementReader.IsEndElement)
        throw new ArgumentOutOfRangeException(nameof (elementReader));
      if (elementReader.IsMiscNode)
        throw new ArgumentOutOfRangeException(nameof (elementReader));
      this.ThrowIfObjectDisposed();
      this._xmlWriter.WriteStartElement(elementReader.Prefix, elementReader.LocalName, elementReader.NamespaceUri);
      if (namespaceDeclarations != null)
      {
        foreach (KeyValuePair<string, string> namespaceDeclaration in namespaceDeclarations)
          this._xmlWriter.WriteAttributeString("xmlns", namespaceDeclaration.Key, "http://www.w3.org/2000/xmlns/", namespaceDeclaration.Value);
      }
      if (attributes != null)
      {
        foreach (OpenXmlAttribute attribute in attributes)
          this._xmlWriter.WriteAttributeString(attribute.Prefix, attribute.LocalName, attribute.NamespaceUri, attribute.Value);
      }
      if (OpenXmlPartWriter.IsOpenXmlLeafTextElement(elementReader.ElementType))
        this._isLeafTextElementStart = true;
      else
        this._isLeafTextElementStart = false;
    }

    public override void WriteStartElement(OpenXmlElement elementObject)
    {
      if (elementObject == null)
        throw new ArgumentNullException(nameof (elementObject));
      if (elementObject is OpenXmlMiscNode)
        throw new ArgumentOutOfRangeException(nameof (elementObject));
      this.ThrowIfObjectDisposed();
      this._xmlWriter.WriteStartElement(elementObject.Prefix, elementObject.LocalName, elementObject.NamespaceUri);
      if (elementObject.HasAttributes)
      {
        foreach (OpenXmlAttribute attribute in (IEnumerable<OpenXmlAttribute>) elementObject.GetAttributes())
          this._xmlWriter.WriteAttributeString(attribute.Prefix, attribute.LocalName, attribute.NamespaceUri, attribute.Value);
      }
      if (OpenXmlPartWriter.IsOpenXmlLeafTextElement(elementObject))
        this._isLeafTextElementStart = true;
      else
        this._isLeafTextElementStart = false;
    }

    public override void WriteStartElement(OpenXmlElement elementObject, IEnumerable<OpenXmlAttribute> attributes)
    {
      this.WriteStartElement(elementObject, attributes, elementObject.NamespaceDeclarations);
    }

    public override void WriteStartElement(OpenXmlElement elementObject, IEnumerable<OpenXmlAttribute> attributes, IEnumerable<KeyValuePair<string, string>> namespaceDeclarations)
    {
      if (elementObject == null)
        throw new ArgumentNullException(nameof (elementObject));
      if (elementObject is OpenXmlMiscNode)
        throw new ArgumentOutOfRangeException(nameof (elementObject));
      this.ThrowIfObjectDisposed();
      this._xmlWriter.WriteStartElement(elementObject.Prefix, elementObject.LocalName, elementObject.NamespaceUri);
      if (namespaceDeclarations != null)
      {
        foreach (KeyValuePair<string, string> namespaceDeclaration in namespaceDeclarations)
          this._xmlWriter.WriteAttributeString("xmlns", namespaceDeclaration.Key, "http://www.w3.org/2000/xmlns/", namespaceDeclaration.Value);
      }
      if (attributes != null)
      {
        foreach (OpenXmlAttribute attribute in attributes)
          this._xmlWriter.WriteAttributeString(attribute.Prefix, attribute.LocalName, attribute.NamespaceUri, attribute.Value);
      }
      if (OpenXmlPartWriter.IsOpenXmlLeafTextElement(elementObject))
        this._isLeafTextElementStart = true;
      else
        this._isLeafTextElementStart = false;
    }

    public override void WriteEndElement()
    {
      this.ThrowIfObjectDisposed();
      this._xmlWriter.WriteEndElement();
      this._isLeafTextElementStart = false;
    }

    public override void WriteString(string text)
    {
      this.ThrowIfObjectDisposed();
      if (!this._isLeafTextElementStart)
        throw new InvalidOperationException(ExceptionMessages.InvalidWriteStringCall);
      this._xmlWriter.WriteString(text);
    }

    public override void WriteElement(OpenXmlElement elementObject)
    {
      if (elementObject == null)
        throw new ArgumentNullException(nameof (elementObject));
      this.ThrowIfObjectDisposed();
      elementObject.WriteTo(this._xmlWriter);
      this._isLeafTextElementStart = false;
    }

    public override void Close()
    {
      if (this._xmlWriter != null)
        this._xmlWriter.Close();
      this._isLeafTextElementStart = false;
    }

    private void Init(Stream partStream, bool closeOutput, Encoding encoding)
    {
      this._xmlWriter = XmlWriter.Create(partStream, new XmlWriterSettings()
      {
        CloseOutput = closeOutput,
        Encoding = encoding
      });
    }

    private static bool IsOpenXmlLeafTextElement(Type elementType)
    {
      return elementType.IsSubclassOf(OpenXmlPartWriter.OpenXmlLeafTextElementClass);
    }

    private static bool IsOpenXmlLeafTextElement(OpenXmlElement element)
    {
      return element is OpenXmlLeafTextElement;
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.OpenXmlUnknownElement
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.IO;
using System.Xml;

namespace DocumentFormat.OpenXml
{
  public class OpenXmlUnknownElement : OpenXmlCompositeElement
  {
    private string _namespaceUri;
    private string _tagName;
    private string _prefix;
    private string _text;

    protected internal OpenXmlUnknownElement()
    {
      this._tagName = string.Empty;
      this._prefix = string.Empty;
      this._namespaceUri = string.Empty;
    }

    public OpenXmlUnknownElement(string name)
      : this()
    {
      if (name == null)
        throw new ArgumentNullException(nameof (name));
      OpenXmlElement.SplitName(name, out this._prefix, out this._tagName);
    }

    public OpenXmlUnknownElement(string qualifiedName, string namespaceUri)
      : this()
    {
      if (qualifiedName == null)
        throw new ArgumentNullException(nameof (qualifiedName));
      OpenXmlElement.SplitName(qualifiedName, out this._prefix, out this._tagName);
      this._namespaceUri = namespaceUri;
    }

    public OpenXmlUnknownElement(string prefix, string localName, string namespaceUri)
      : this()
    {
      if (localName == null)
        throw new ArgumentNullException(nameof (localName));
      if (prefix == null)
        prefix = string.Empty;
      if (namespaceUri == null)
        namespaceUri = string.Empty;
      this._prefix = prefix;
      this._namespaceUri = namespaceUri;
      this._tagName = localName;
    }

    public static OpenXmlUnknownElement CreateOpenXmlUnknownElement(string outerXml)
    {
      if (string.IsNullOrEmpty(outerXml))
        throw new ArgumentNullException(nameof (outerXml));
      using (XmlReader xmlReader = XmlConvertingReaderFactory.Create((TextReader) new StringReader(outerXml), OpenXmlElementContext.CreateDefaultXmlReaderSettings()))
      {
        while (!xmlReader.Read() || xmlReader.NodeType != XmlNodeType.Element)
        {
          if (xmlReader.NodeType != XmlNodeType.Whitespace)
            throw new ArgumentException(ExceptionMessages.InvalidOuterXml, nameof (outerXml));
        }
        OpenXmlUnknownElement xmlUnknownElement = new OpenXmlUnknownElement(xmlReader.Prefix, xmlReader.LocalName, xmlReader.NamespaceURI);
        xmlUnknownElement.OuterXml = outerXml;
        return xmlUnknownElement;
      }
    }

    public override string LocalName
    {
      get
      {
        return this._tagName;
      }
    }

    public override string NamespaceUri
    {
      get
      {
        return this._namespaceUri;
      }
    }

    public override string Prefix
    {
      get
      {
        return this._prefix;
      }
    }

    public override XmlQualifiedName XmlQualifiedName
    {
      get
      {
        return new XmlQualifiedName(this._tagName, this._namespaceUri);
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        throw new InvalidOperationException();
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 9002;
      }
    }

    public override string InnerText
    {
      get
      {
        if (this.HasChildren)
          return base.InnerText;
        return this._text;
      }
    }

    public string Text
    {
      get
      {
        this.MakeSureParsed();
        return this._text;
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      OpenXmlUnknownElement xmlUnknownElement = new OpenXmlUnknownElement(this._prefix, this._tagName, this._namespaceUri);
      xmlUnknownElement._text = this.Text;
      xmlUnknownElement.CopyAttributes((OpenXmlElement) this);
      if (deep)
        xmlUnknownElement.CopyChilden((OpenXmlElement) this, deep);
      return (OpenXmlElement) xmlUnknownElement;
    }

    internal override void WriteContentTo(XmlWriter w)
    {
      if (this.HasChildren)
      {
        base.WriteContentTo(w);
      }
      else
      {
        if (this.Text == null)
          return;
        w.WriteString(this.Text);
      }
    }

    public override void WriteTo(XmlWriter xmlWriter)
    {
      if (xmlWriter == null)
        throw new ArgumentNullException(nameof (xmlWriter));
      if (this.XmlParsed)
      {
        xmlWriter.WriteStartElement(this.Prefix, this.LocalName, this.NamespaceUri);
        this.WriteAttributesTo(xmlWriter);
        this.WriteContentTo(xmlWriter);
        xmlWriter.WriteEndElement();
      }
      else
        xmlWriter.WriteRaw(this.RawOuterXml);
    }

    internal override void LazyLoad(XmlReader xmlReader)
    {
      this._tagName = xmlReader.LocalName;
      this._prefix = xmlReader.Prefix;
      this._namespaceUri = xmlReader.NamespaceURI;
      this.RawOuterXml = xmlReader.ReadOuterXml();
    }

    internal override void Populate(XmlReader xmlReader, OpenXmlLoadMode loadMode)
    {
      if (string.IsNullOrEmpty(this._tagName))
      {
        this._tagName = xmlReader.LocalName;
        this._prefix = xmlReader.Prefix;
        this._namespaceUri = xmlReader.NamespaceURI;
      }
      base.Populate(xmlReader, loadMode);
      if (this.FirstChild == null || this.FirstChild.NextSibling() != null)
        return;
      OpenXmlMiscNode firstChild = this.FirstChild as OpenXmlMiscNode;
      if (firstChild == null)
        return;
      switch (firstChild.XmlNodeType)
      {
        case XmlNodeType.Text:
        case XmlNodeType.CDATA:
        case XmlNodeType.SignificantWhitespace:
          this._text = firstChild.OuterXml;
          this.RemoveChild<OpenXmlMiscNode>(firstChild);
          break;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return false;
    }
  }
}

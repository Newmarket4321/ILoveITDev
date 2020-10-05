// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.OpenXmlLeafTextElement
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Xml;

namespace DocumentFormat.OpenXml
{
  [DebuggerDisplay("{Text}")]
  public abstract class OpenXmlLeafTextElement : OpenXmlLeafElement
  {
    private string _rawInnerText;

    protected OpenXmlLeafTextElement()
    {
    }

    protected OpenXmlLeafTextElement(string text)
    {
      this._rawInnerText = text;
    }

    internal string RawInnerText
    {
      get
      {
        return this._rawInnerText;
      }
      set
      {
        this._rawInnerText = value;
      }
    }

    internal virtual OpenXmlSimpleType InnerTextToValue(string text)
    {
      return (OpenXmlSimpleType) null;
    }

    public override bool HasChildren
    {
      get
      {
        return false;
      }
    }

    public override string InnerText
    {
      get
      {
        this.MakeSureParsed();
        if (this.RawInnerText != null)
          return this._rawInnerText;
        return string.Empty;
      }
      protected set
      {
        this.MakeSureParsed();
        this.RawInnerText = value;
        this.ShadowElement = (OpenXmlElement) null;
      }
    }

    public override string InnerXml
    {
      get
      {
        if (this.ShadowElement != null)
          return this.ShadowElement.InnerXml;
        StringWriter stringWriter = new StringWriter((IFormatProvider) CultureInfo.InvariantCulture);
        XmlDOMTextWriter xmlDomTextWriter = new XmlDOMTextWriter((TextWriter) stringWriter);
        try
        {
          this.WriteContentTo((XmlWriter) xmlDomTextWriter);
        }
        finally
        {
          xmlDomTextWriter.Close();
        }
        return stringWriter.ToString();
      }
      set
      {
        if (!string.IsNullOrEmpty(value))
          throw new InvalidOperationException(ExceptionMessages.LeafElementInnerXmlCannotBeSet);
        this.ShadowElement = (OpenXmlElement) null;
      }
    }

    public virtual string Text
    {
      get
      {
        return this.InnerText;
      }
      set
      {
        this.InnerText = value;
      }
    }

    internal override void WriteContentTo(XmlWriter w)
    {
      if (this.ShadowElement != null)
        this.ShadowElement.WriteContentTo(w);
      else
        w.WriteString(this.Text);
    }

    public override void RemoveAllChildren()
    {
      this.RawInnerText = (string) null;
    }

    internal override void Populate(XmlReader xmlReader, OpenXmlLoadMode loadMode)
    {
      this.LoadAttributes(xmlReader);
      if (!xmlReader.IsEmptyElement)
      {
        xmlReader.Read();
        this.RawInnerText = string.Empty;
        int num = 0;
        int index = -1;
        XmlNodeType xmlNodeType = XmlNodeType.Text;
        if (xmlReader.NodeType != XmlNodeType.EndElement)
        {
          while (!xmlReader.EOF && xmlReader.NodeType != XmlNodeType.EndElement)
          {
            if (string.IsNullOrEmpty(this.RawInnerText) && (xmlReader.NodeType == XmlNodeType.Text || xmlReader.NodeType == XmlNodeType.CDATA || (xmlReader.NodeType == XmlNodeType.SignificantWhitespace || xmlReader.NodeType == XmlNodeType.Whitespace)))
            {
              this.RawInnerText = xmlReader.Value;
              index = num;
              xmlNodeType = xmlReader.NodeType;
              xmlReader.Read();
            }
            else
            {
              OpenXmlElement newChild = this.ElementFactory(xmlReader);
              newChild.Load(xmlReader, OpenXmlLoadMode.Full);
              ++num;
              if (this.ShadowElement == null)
                this.ShadowElement = (OpenXmlElement) new OpenXmlUnknownElement(this.Prefix, this.LocalName, this.NamespaceUri);
              this.ShadowElement.AppendChild<OpenXmlElement>(newChild);
            }
          }
        }
        if (num != 0 && index > -1)
        {
          OpenXmlMiscNode newChild = (OpenXmlMiscNode) null;
          switch (xmlNodeType)
          {
            case XmlNodeType.Text:
              newChild = OpenXmlMiscNode.CreateFromText(this.RawInnerText);
              break;
            case XmlNodeType.CDATA:
              newChild = OpenXmlMiscNode.CreateFromCdata(this.RawInnerText);
              break;
            case XmlNodeType.Whitespace:
            case XmlNodeType.SignificantWhitespace:
              newChild = OpenXmlMiscNode.CreateFromSignificantWhitespace(this.RawInnerText);
              break;
          }
          this.ShadowElement.InsertAt<OpenXmlMiscNode>(newChild, index);
        }
      }
      xmlReader.Skip();
      this.RawOuterXml = string.Empty;
    }

    internal override T CloneImp<T>(bool deep)
    {
      T obj = base.CloneImp<T>(deep);
      ((object) obj as OpenXmlLeafTextElement).Text = this.Text;
      return obj;
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.OpenXmlMiscNode
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Globalization;
using System.IO;
using System.Xml;

namespace DocumentFormat.OpenXml
{
  public class OpenXmlMiscNode : OpenXmlElement
  {
    private const string strCDataSectionName = "#cdata-section";
    private const string strCommentName = "#comment";
    private const string strTextName = "#text";
    private const string strNonSignificantWhitespaceName = "#whitespace";
    private const string strSignificantWhitespaceName = "#significant-whitespace";
    private const string strXmlDeclaration = "xml-declaration";
    private XmlNodeType _nodeType;

    public OpenXmlMiscNode(XmlNodeType nodeType)
    {
      switch (nodeType)
      {
        case XmlNodeType.None:
        case XmlNodeType.Element:
        case XmlNodeType.Attribute:
        case XmlNodeType.EntityReference:
        case XmlNodeType.Entity:
        case XmlNodeType.Document:
        case XmlNodeType.DocumentType:
        case XmlNodeType.DocumentFragment:
        case XmlNodeType.Notation:
        case XmlNodeType.EndElement:
        case XmlNodeType.EndEntity:
          throw new ArgumentOutOfRangeException(nameof (nodeType));
        default:
          this.XmlNodeType = nodeType;
          break;
      }
    }

    public OpenXmlMiscNode(XmlNodeType nodeType, string outerXml)
      : this(nodeType)
    {
      if (string.IsNullOrEmpty(outerXml))
        throw new ArgumentNullException(nameof (outerXml));
      using (StringReader stringReader = new StringReader(outerXml))
      {
        using (XmlReader xmlReader = XmlConvertingReaderFactory.Create((TextReader) stringReader, new XmlReaderSettings()
        {
          DtdProcessing = DtdProcessing.Prohibit
        }))
        {
          xmlReader.Read();
          if (xmlReader.NodeType != nodeType)
            throw new ArgumentException(ExceptionMessages.InvalidOuterXmlForMiscNode);
          xmlReader.Close();
        }
      }
      this.RawOuterXml = outerXml;
    }

    public XmlNodeType XmlNodeType
    {
      get
      {
        return this._nodeType;
      }
      internal set
      {
        this._nodeType = value;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 9001;
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        throw new InvalidOperationException();
      }
    }

    public override bool HasChildren
    {
      get
      {
        return false;
      }
    }

    public override string LocalName
    {
      get
      {
        string str = string.Empty;
        switch (this._nodeType)
        {
          case XmlNodeType.Text:
            str = "#text";
            break;
          case XmlNodeType.CDATA:
            str = "#cdata-section";
            break;
          case XmlNodeType.ProcessingInstruction:
            using (StringReader stringReader = new StringReader(this.OuterXml))
            {
              using (XmlReader xmlReader = XmlConvertingReaderFactory.Create((TextReader) stringReader, new XmlReaderSettings()
              {
                DtdProcessing = DtdProcessing.Prohibit
              }))
              {
                xmlReader.Read();
                str = xmlReader.LocalName;
                xmlReader.Close();
                break;
              }
            }
          case XmlNodeType.Comment:
            str = "#comment";
            break;
          case XmlNodeType.Whitespace:
            str = "#whitespace";
            break;
          case XmlNodeType.SignificantWhitespace:
            str = "#significant-whitespace";
            break;
          case XmlNodeType.XmlDeclaration:
            str = "xml-declaration";
            break;
        }
        return str;
      }
    }

    public override string NamespaceUri
    {
      get
      {
        return string.Empty;
      }
    }

    public override string Prefix
    {
      get
      {
        return string.Empty;
      }
    }

    public override XmlQualifiedName XmlQualifiedName
    {
      get
      {
        throw new InvalidOperationException();
      }
    }

    public override string InnerXml
    {
      get
      {
        return string.Empty;
      }
      set
      {
        throw new InvalidOperationException(ExceptionMessages.InnerXmlCannotBeSet);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      OpenXmlMiscNode openXmlMiscNode = new OpenXmlMiscNode(this.XmlNodeType);
      openXmlMiscNode.OuterXml = this.OuterXml;
      return (OpenXmlElement) openXmlMiscNode;
    }

    public override void RemoveAllChildren()
    {
    }

    internal override void WriteContentTo(XmlWriter w)
    {
      throw new NotImplementedException(ExceptionMessages.NonImplemented);
    }

    public override void WriteTo(XmlWriter xmlWriter)
    {
      if (xmlWriter == null)
        throw new ArgumentNullException(nameof (xmlWriter));
      xmlWriter.WriteRaw(this.RawOuterXml);
    }

    internal override void LazyLoad(XmlReader xmlReader)
    {
      this.Populate(xmlReader, OpenXmlLoadMode.Full);
    }

    internal override void ParseXml()
    {
    }

    internal string Value { get; private set; }

    internal void LoadOuterXml(XmlReader xmlReader)
    {
      switch (xmlReader.NodeType)
      {
        case XmlNodeType.Text:
          this.Value = xmlReader.Value;
          this.RawOuterXml = xmlReader.Value;
          break;
        case XmlNodeType.CDATA:
          this.Value = xmlReader.Value;
          this.RawOuterXml = string.Format((IFormatProvider) CultureInfo.InvariantCulture, "<![CDATA[{0}]]>", new object[1]
          {
            (object) xmlReader.Value
          });
          break;
        case XmlNodeType.EntityReference:
          this.RawOuterXml = xmlReader.Name;
          break;
        case XmlNodeType.ProcessingInstruction:
          this.Value = xmlReader.Value;
          this.RawOuterXml = string.Format((IFormatProvider) CultureInfo.InvariantCulture, "<?{0} {1}?>", new object[2]
          {
            (object) xmlReader.Name,
            (object) xmlReader.Value
          });
          break;
        case XmlNodeType.Comment:
          this.Value = xmlReader.Value;
          this.RawOuterXml = string.Format((IFormatProvider) CultureInfo.InvariantCulture, "<!--{0}-->", new object[1]
          {
            (object) xmlReader.Value
          });
          break;
        case XmlNodeType.SignificantWhitespace:
          this.Value = xmlReader.Value;
          this.RawOuterXml = xmlReader.Value;
          break;
        case XmlNodeType.XmlDeclaration:
          this.Value = xmlReader.Value;
          break;
      }
    }

    internal override void LoadAttributes(XmlReader xmlReader)
    {
    }

    internal override void Populate(XmlReader xmlReader, OpenXmlLoadMode loadMode)
    {
      this.LoadOuterXml(xmlReader);
      xmlReader.Read();
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return true;
    }

    internal static OpenXmlMiscNode CreateFromText(string text)
    {
      OpenXmlMiscNode openXmlMiscNode = new OpenXmlMiscNode(XmlNodeType.Text);
      openXmlMiscNode.Value = text;
      openXmlMiscNode.RawOuterXml = text;
      return openXmlMiscNode;
    }

    internal static OpenXmlMiscNode CreateFromCdata(string value)
    {
      OpenXmlMiscNode openXmlMiscNode = new OpenXmlMiscNode(XmlNodeType.CDATA);
      openXmlMiscNode.Value = value;
      openXmlMiscNode.RawOuterXml = string.Format((IFormatProvider) CultureInfo.InvariantCulture, "<![CDATA[{0}]]>", new object[1]
      {
        (object) value
      });
      return openXmlMiscNode;
    }

    internal static OpenXmlMiscNode CreateFromSignificantWhitespace(string whitespace)
    {
      OpenXmlMiscNode openXmlMiscNode = new OpenXmlMiscNode(XmlNodeType.SignificantWhitespace);
      openXmlMiscNode.Value = whitespace;
      openXmlMiscNode.RawOuterXml = whitespace;
      return openXmlMiscNode;
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.OpenXmlLeafElement
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Xml;

namespace DocumentFormat.OpenXml
{
  public abstract class OpenXmlLeafElement : OpenXmlElement
  {
    internal OpenXmlElement ShadowElement { get; set; }

    public override bool HasChildren
    {
      get
      {
        return false;
      }
    }

    public override string InnerXml
    {
      get
      {
        if (this.ShadowElement != null)
          return this.ShadowElement.InnerXml;
        return string.Empty;
      }
      set
      {
        if (!string.IsNullOrEmpty(value))
          throw new InvalidOperationException(ExceptionMessages.LeafElementInnerXmlCannotBeSet);
        this.ShadowElement = (OpenXmlElement) null;
      }
    }

    internal override void WriteContentTo(XmlWriter w)
    {
      if (this.ShadowElement == null)
        return;
      this.ShadowElement.WriteContentTo(w);
    }

    public override void RemoveAllChildren()
    {
    }

    internal override void Populate(XmlReader xmlReader, OpenXmlLoadMode loadMode)
    {
      this.LoadAttributes(xmlReader);
      if (!xmlReader.IsEmptyElement)
      {
        this.ShadowElement = (OpenXmlElement) new OpenXmlUnknownElement(this.Prefix, this.LocalName, this.NamespaceUri);
        this.ShadowElement.InnerXml = xmlReader.ReadInnerXml();
      }
      else
        xmlReader.Skip();
      this.RawOuterXml = string.Empty;
    }
  }
}

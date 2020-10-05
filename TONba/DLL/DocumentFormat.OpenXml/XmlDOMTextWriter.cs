// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.XmlDOMTextWriter
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.IO;
using System.Text;
using System.Xml;

namespace DocumentFormat.OpenXml
{
  internal class XmlDOMTextWriter : XmlTextWriter
  {
    public XmlDOMTextWriter(TextWriter w)
      : base(w)
    {
    }

    public XmlDOMTextWriter(Stream w, Encoding encoding)
      : base(w, encoding)
    {
    }

    public XmlDOMTextWriter(string filename, Encoding encoding)
      : base(filename, encoding)
    {
    }

    public override void WriteStartAttribute(string prefix, string localName, string ns)
    {
      if (string.IsNullOrEmpty(localName))
        throw new ArgumentNullException(nameof (localName));
      if (prefix == null)
        prefix = string.Empty;
      if (ns == null)
        ns = string.Empty;
      if (ns.Length == 0 && prefix.Length != 0)
        prefix = string.Empty;
      base.WriteStartAttribute(prefix, localName, ns);
    }

    public override void WriteStartElement(string prefix, string localName, string ns)
    {
      if (string.IsNullOrEmpty(localName))
        throw new ArgumentNullException(nameof (localName));
      if (prefix == null)
        prefix = string.Empty;
      if (ns == null)
        ns = string.Empty;
      if (ns.Length == 0 && prefix.Length != 0)
        prefix = string.Empty;
      base.WriteStartElement(prefix, localName, ns);
    }
  }
}

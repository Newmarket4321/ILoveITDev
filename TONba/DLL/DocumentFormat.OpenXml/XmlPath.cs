// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.XmlPath
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DocumentFormat.OpenXml
{
  [DebuggerDisplay("XPath={XPath}")]
  public class XmlPath
  {
    private List<string> _namespacesDefinitions = new List<string>();

    private XmlPath()
    {
    }

    internal XmlPath(OpenXmlPart part)
    {
      this.PartUri = part.Uri;
    }

    public IList<string> NamespacesDefinitions
    {
      get
      {
        return (IList<string>) this._namespacesDefinitions;
      }
    }

    public string XPath { get; private set; }

    public Uri PartUri { get; private set; }

    internal static XmlPath GetXPath(OpenXmlElement element)
    {
      if (element == null)
        return (XmlPath) null;
      XmlPath xmlPath = new XmlPath();
      xmlPath.PartUri = element.GetPartUri();
      Dictionary<string, string> namespaces = new Dictionary<string, string>();
      StringBuilder xpath = new StringBuilder("");
      XmlPath.BuildXPath(element, xpath, namespaces);
      xmlPath.XPath = xpath.ToString();
      foreach (KeyValuePair<string, string> keyValuePair in namespaces)
      {
        StringBuilder stringBuilder = new StringBuilder("");
        stringBuilder.Append("xmlns:");
        stringBuilder.Append(keyValuePair.Key);
        stringBuilder.Append("=\"");
        stringBuilder.Append(keyValuePair.Value);
        stringBuilder.Append("\"");
        xmlPath.NamespacesDefinitions.Add(stringBuilder.ToString());
      }
      return xmlPath;
    }

    internal static void BuildXPath(OpenXmlElement element, StringBuilder xpath, Dictionary<string, string> namespaces)
    {
      if (element.Parent != null)
        XmlPath.BuildXPath(element.Parent, xpath, namespaces);
      xpath.Append("/");
      if (element is OpenXmlMiscNode)
      {
        xpath.Append(element.OuterXml);
      }
      else
      {
        if (!string.IsNullOrEmpty(element.Prefix))
        {
          if (!namespaces.ContainsKey(element.Prefix))
            namespaces.Add(element.Prefix, element.NamespaceUri);
          xpath.Append(element.Prefix);
          xpath.Append(":");
        }
        else if (!string.IsNullOrEmpty(element.NamespaceUri))
        {
          xpath.Append(element.NamespaceUri);
          xpath.Append(":");
        }
        xpath.Append(element.LocalName);
        xpath.Append("[");
        xpath.Append(element.GetXPathIndex());
        xpath.Append("]");
      }
    }
  }
}

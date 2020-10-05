// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.MiscAttrContainer
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.Collections.Generic;

namespace DocumentFormat.OpenXml
{
  internal class MiscAttrContainer
  {
    internal List<OpenXmlAttribute> ExtendedAttributesField { get; set; }

    internal MarkupCompatibilityAttributes _mcAttributes { get; set; }

    internal List<KeyValuePair<string, string>> _nsMappings { get; set; }
  }
}

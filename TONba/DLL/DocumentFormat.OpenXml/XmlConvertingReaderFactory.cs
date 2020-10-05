// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.XmlConvertingReaderFactory
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.IO;
using System.Xml;

namespace DocumentFormat.OpenXml
{
  internal static class XmlConvertingReaderFactory
  {
    public static XmlReader Create(XmlReader xmlReader, bool strictTranslation)
    {
      return (XmlReader) new XmlConvertingReader(xmlReader, strictTranslation);
    }

    public static XmlReader Create(Stream partStream, XmlReaderSettings settings)
    {
      return XmlConvertingReaderFactory.Create(partStream, settings, true);
    }

    public static XmlReader Create(Stream partStream, XmlReaderSettings settings, bool strictTranslation)
    {
      return (XmlReader) new XmlConvertingReader(XmlReader.Create(partStream, settings), strictTranslation);
    }

    public static XmlReader Create(TextReader textReader, XmlReaderSettings settings)
    {
      return XmlConvertingReaderFactory.Create(textReader, settings, true);
    }

    public static XmlReader Create(TextReader textReader, XmlReaderSettings settings, bool strictTranslation)
    {
      return (XmlReader) new XmlConvertingReader(XmlReader.Create(textReader, settings), strictTranslation);
    }

    public static XmlReader Create(TextReader textReader)
    {
      return XmlConvertingReaderFactory.Create(textReader, true);
    }

    public static XmlReader Create(TextReader textReader, bool strictTranslation)
    {
      return (XmlReader) new XmlConvertingReader(XmlReader.Create(textReader), strictTranslation);
    }
  }
}

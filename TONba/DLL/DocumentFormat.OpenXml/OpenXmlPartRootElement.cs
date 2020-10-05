// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.OpenXmlPartRootElement
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Xml;

namespace DocumentFormat.OpenXml
{
  public abstract class OpenXmlPartRootElement : OpenXmlCompositeElement
  {
    private bool? _standaloneDeclaration = new bool?();
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private OpenXmlElementContext _elementContext;

    protected OpenXmlPartRootElement()
    {
      this._elementContext = new OpenXmlElementContext();
    }

    protected OpenXmlPartRootElement(OpenXmlPart openXmlPart)
    {
      if (openXmlPart == null)
        throw new ArgumentNullException(nameof (openXmlPart));
      this._elementContext = new OpenXmlElementContext();
      this.LoadFromPart(openXmlPart);
    }

    protected OpenXmlPartRootElement(string outerXml)
      : base(outerXml)
    {
      this._elementContext = new OpenXmlElementContext();
    }

    protected OpenXmlPartRootElement(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
      this._elementContext = new OpenXmlElementContext();
    }

    protected OpenXmlPartRootElement(params OpenXmlElement[] childElements)
      : base(childElements)
    {
      this._elementContext = new OpenXmlElementContext();
    }

    internal override OpenXmlElementContext RootElementContext
    {
      get
      {
        return this._elementContext;
      }
    }

    internal void LoadFromPart(OpenXmlPart openXmlPart)
    {
      using (Stream stream = openXmlPart.GetStream(FileMode.Open))
        this.LoadFromPart(openXmlPart, stream);
    }

    internal bool LoadFromPart(OpenXmlPart openXmlPart, Stream partStream)
    {
      Profiler.CommentMarkProfile(Profiler.MarkId.OpenXmlPartRootElement_LoadFromPart_In);
      if (partStream.Length < 4L)
        return false;
      this.OpenXmlElementContext.XmlReaderSettings.MaxCharactersInDocument = openXmlPart.MaxCharactersInPart;
      this.OpenXmlElementContext.XmlReaderSettings.DtdProcessing = DtdProcessing.Prohibit;
      using (XmlReader xmlReader = XmlConvertingReaderFactory.Create(partStream, this.OpenXmlElementContext.XmlReaderSettings, openXmlPart.OpenXmlPackage.StrictTranslation))
      {
        this.OpenXmlElementContext.MCSettings = openXmlPart.MCSettings;
        xmlReader.Read();
        if (xmlReader.NodeType == XmlNodeType.XmlDeclaration)
        {
          string attribute = xmlReader.GetAttribute("standalone");
          if (attribute != null)
            this._standaloneDeclaration = new bool?(attribute.Equals("yes", StringComparison.OrdinalIgnoreCase));
        }
        if (!xmlReader.EOF)
        {
          int content = (int) xmlReader.MoveToContent();
        }
        if (xmlReader.EOF || XmlNodeType.Element != xmlReader.NodeType || !xmlReader.IsStartElement())
          return false;
        byte id;
        if (!NamespaceIdMap.TryGetNamespaceId(xmlReader.NamespaceURI, out id) || (int) id != (int) this.NamespaceId || xmlReader.LocalName != this.LocalName)
          throw new InvalidDataException(string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ExceptionMessages.Fmt_PartRootIsInvalid, new object[2]
          {
            (object) new XmlQualifiedName(xmlReader.LocalName, xmlReader.NamespaceURI).ToString(),
            (object) this.XmlQualifiedName.ToString()
          }));
        this.OuterXml = string.Empty;
        bool flag = this.PushMcContext(xmlReader);
        this.Load(xmlReader, this.OpenXmlElementContext.LoadMode);
        if (flag)
          this.PopMcContext();
      }
      Profiler.CommentMarkProfile(Profiler.MarkId.OpenXmlPartRootElement_LoadFromPart_Out);
      return true;
    }

    internal void LoadFromPart(OpenXmlPart openXmlPart, OpenXmlLoadMode loadMode)
    {
      this.OpenXmlElementContext.LoadMode = loadMode;
      this.LoadFromPart(openXmlPart);
    }

    internal void SaveToPart(OpenXmlPart openXmlPart)
    {
      if (openXmlPart == null)
        throw new ArgumentNullException(nameof (openXmlPart));
      XmlWriterSettings settings = new XmlWriterSettings();
      settings.CloseOutput = true;
      using (Stream stream = openXmlPart.GetStream(FileMode.Create))
      {
        using (XmlWriter xmlWriter = XmlWriter.Create(stream, settings))
        {
          if (this._standaloneDeclaration.HasValue)
            xmlWriter.WriteStartDocument(this._standaloneDeclaration.Value);
          this.WriteTo(xmlWriter);
          if (!this.XmlParsed)
            return;
          xmlWriter.WriteEndDocument();
        }
      }
    }

    public void Save(Stream stream)
    {
      using (XmlWriter xmlWriter = XmlWriter.Create(stream, new XmlWriterSettings()
      {
        CloseOutput = true
      }))
      {
        if (this._standaloneDeclaration.HasValue)
          xmlWriter.WriteStartDocument(this._standaloneDeclaration.Value);
        this.WriteTo(xmlWriter);
        if (!this.XmlParsed)
          return;
        xmlWriter.WriteEndDocument();
      }
    }

    internal OpenXmlPart OpenXmlPart { get; set; }

    public void Save()
    {
      if (this.OpenXmlPart == null)
        throw new InvalidOperationException(ExceptionMessages.CannotSaveDomTreeWithoutAssociatedPart);
      this.SaveToPart(this.OpenXmlPart);
    }

    public void Reload()
    {
      if (this.OpenXmlPart == null)
        throw new InvalidOperationException(ExceptionMessages.CannotReloadDomTreeWithoutAssociatedPart);
      this.LoadFromPart(this.OpenXmlPart);
    }

    public override void WriteTo(XmlWriter xmlWriter)
    {
      if (xmlWriter == null)
        throw new ArgumentNullException(nameof (xmlWriter));
      if (this.XmlParsed)
      {
        string prefix = this.LookupNamespaceLocal(this.NamespaceUri);
        if (this.Parent != null && string.IsNullOrEmpty(prefix))
          prefix = xmlWriter.LookupPrefix(this.NamespaceUri);
        if (string.IsNullOrEmpty(prefix))
          prefix = NamespaceIdMap.GetNamespacePrefix(this.NamespaceId);
        xmlWriter.WriteStartElement(prefix, this.LocalName, this.NamespaceUri);
        this.WriteNamespaceAtributes(xmlWriter);
        this.WriteAttributesTo(xmlWriter);
        if (this.HasChildren || !string.IsNullOrEmpty(this.InnerText))
        {
          this.WriteContentTo(xmlWriter);
          xmlWriter.WriteFullEndElement();
        }
        else
          xmlWriter.WriteEndElement();
      }
      else
        xmlWriter.WriteRaw(this.RawOuterXml);
    }

    private void WriteNamespaceAtributes(XmlWriter xmlWrite)
    {
      if (!this.WriteAllNamespaceOnRoot)
        return;
      Dictionary<string, string> dictionary = new Dictionary<string, string>();
      foreach (OpenXmlElement descendant in this.Descendants())
      {
        if (descendant.NamespaceDeclField != null)
        {
          foreach (KeyValuePair<string, string> keyValuePair in descendant.NamespaceDeclField)
          {
            if (!dictionary.ContainsKey(keyValuePair.Key))
              dictionary.Add(keyValuePair.Key, keyValuePair.Value);
          }
        }
      }
      foreach (KeyValuePair<string, string> keyValuePair in dictionary)
      {
        if (!string.IsNullOrEmpty(keyValuePair.Key) && this.NamespaceDeclField != null && (string.IsNullOrEmpty(this.LookupPrefixLocal(keyValuePair.Value)) && string.IsNullOrEmpty(this.LookupNamespaceLocal(keyValuePair.Key))))
          xmlWrite.WriteAttributeString("xmlns", keyValuePair.Key, "http://www.w3.org/2000/xmlns/", keyValuePair.Value);
      }
    }

    internal virtual bool WriteAllNamespaceOnRoot
    {
      get
      {
        return true;
      }
    }
  }
}

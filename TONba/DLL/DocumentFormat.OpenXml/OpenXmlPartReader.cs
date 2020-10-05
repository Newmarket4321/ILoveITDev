// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.OpenXmlPartReader
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Xml;

namespace DocumentFormat.OpenXml
{
  public class OpenXmlPartReader : OpenXmlReader
  {
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static ReadOnlyCollection<OpenXmlAttribute> _emptyReadOnlyList;
    private OpenXmlElementContext _elementContext;
    private XmlReader _xmlReader;
    private IList<OpenXmlAttribute> _attributeList;
    private IList<KeyValuePair<string, string>> _nsDecls;
    private Stack<OpenXmlElement> _elementStack;
    private ElementState _elementState;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private string _encoding;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool? _standalone;

    private OpenXmlPartReader()
    {
      this._attributeList = (IList<OpenXmlAttribute>) new List<OpenXmlAttribute>();
      this._nsDecls = (IList<KeyValuePair<string, string>>) new List<KeyValuePair<string, string>>();
      this._elementStack = new Stack<OpenXmlElement>();
      this._elementContext = new OpenXmlElementContext();
      this._elementState = ElementState.Null;
    }

    private OpenXmlPartReader(bool readMiscNodes)
      : base(readMiscNodes)
    {
      this._attributeList = (IList<OpenXmlAttribute>) new List<OpenXmlAttribute>();
      this._nsDecls = (IList<KeyValuePair<string, string>>) new List<KeyValuePair<string, string>>();
      this._elementStack = new Stack<OpenXmlElement>();
      this._elementContext = new OpenXmlElementContext();
      this._elementState = ElementState.Null;
    }

    public OpenXmlPartReader(OpenXmlPart openXmlPart)
      : this()
    {
      if (openXmlPart == null)
        throw new ArgumentNullException(nameof (openXmlPart));
      Stream stream = openXmlPart.GetStream(FileMode.Open);
      this._elementContext.XmlReaderSettings.MaxCharactersInDocument = openXmlPart.MaxCharactersInPart;
      this.Init(stream, true);
    }

    public OpenXmlPartReader(OpenXmlPart openXmlPart, bool readMiscNodes)
      : this(readMiscNodes)
    {
      if (openXmlPart == null)
        throw new ArgumentNullException(nameof (openXmlPart));
      this._elementContext.XmlReaderSettings.MaxCharactersInDocument = openXmlPart.MaxCharactersInPart;
      this.Init(openXmlPart.GetStream(FileMode.Open), true);
    }

    public OpenXmlPartReader(Stream partStream)
      : this()
    {
      if (partStream == null)
        throw new ArgumentNullException(nameof (partStream));
      this.Init(partStream, false);
    }

    public OpenXmlPartReader(Stream partStream, bool readMiscNodes)
      : this(readMiscNodes)
    {
      if (partStream == null)
        throw new ArgumentNullException(nameof (partStream));
      this.Init(partStream, false);
    }

    public override string Encoding
    {
      get
      {
        this.ThrowIfObjectDisposed();
        return this._encoding;
      }
    }

    public override bool? StandaloneXml
    {
      get
      {
        this.ThrowIfObjectDisposed();
        return this._standalone;
      }
    }

    public override ReadOnlyCollection<OpenXmlAttribute> Attributes
    {
      get
      {
        this.ThrowIfObjectDisposed();
        this.ThrowIfNull();
        this.ThrowIfEof();
        if (this._elementState == ElementState.Start || this._elementState == ElementState.LeafStart)
          return new ReadOnlyCollection<OpenXmlAttribute>(this._attributeList);
        if (OpenXmlPartReader._emptyReadOnlyList == null)
          OpenXmlPartReader._emptyReadOnlyList = new ReadOnlyCollection<OpenXmlAttribute>((IList<OpenXmlAttribute>) new List<OpenXmlAttribute>());
        return OpenXmlPartReader._emptyReadOnlyList;
      }
    }

    public override IEnumerable<KeyValuePair<string, string>> NamespaceDeclarations
    {
      get
      {
        this.ThrowIfObjectDisposed();
        this.ThrowIfNull();
        this.ThrowIfEof();
        if (this._elementState == ElementState.Start || this._elementState == ElementState.LeafStart)
          return (IEnumerable<KeyValuePair<string, string>>) this._nsDecls;
        return (IEnumerable<KeyValuePair<string, string>>) EmptyEnumerable<KeyValuePair<string, string>>.EmptyEnumerableSingleton;
      }
    }

    public override Type ElementType
    {
      get
      {
        this.ThrowIfObjectDisposed();
        this.ThrowIfNull();
        this.ThrowIfEof();
        return this._elementStack.Peek().GetType();
      }
    }

    public override bool IsMiscNode
    {
      get
      {
        this.ThrowIfObjectDisposed();
        this.ThrowIfNull();
        this.ThrowIfEof();
        return this._elementState == ElementState.MiscNode;
      }
    }

    public override bool IsStartElement
    {
      get
      {
        this.ThrowIfObjectDisposed();
        this.ThrowIfNull();
        this.ThrowIfEof();
        return !this.IsMiscNode && (this._elementState == ElementState.Start || this._elementState == ElementState.LeafStart);
      }
    }

    public override bool IsEndElement
    {
      get
      {
        this.ThrowIfObjectDisposed();
        this.ThrowIfNull();
        this.ThrowIfEof();
        return !this.IsMiscNode && (this._elementState == ElementState.End || this._elementState == ElementState.LeafEnd || this._elementState == ElementState.LoadEnd);
      }
    }

    public override int Depth
    {
      get
      {
        this.ThrowIfObjectDisposed();
        this.ThrowIfNull();
        this.ThrowIfEof();
        return this._elementStack.Count - 1;
      }
    }

    public override bool EOF
    {
      get
      {
        this.ThrowIfObjectDisposed();
        return this._elementState == ElementState.EOF;
      }
    }

    public override string LocalName
    {
      get
      {
        this.ThrowIfObjectDisposed();
        this.ThrowIfNull();
        this.ThrowIfEof();
        return this._elementStack.Peek().LocalName;
      }
    }

    public override string NamespaceUri
    {
      get
      {
        this.ThrowIfObjectDisposed();
        this.ThrowIfNull();
        this.ThrowIfEof();
        return this._elementStack.Peek().NamespaceUri;
      }
    }

    public override string Prefix
    {
      get
      {
        this.ThrowIfObjectDisposed();
        this.ThrowIfNull();
        this.ThrowIfEof();
        return this._elementStack.Peek().Prefix;
      }
    }

    public override bool Read()
    {
      this.ThrowIfObjectDisposed();
      bool nextElement = this.MoveToNextElement();
      if (nextElement && !this.ReadMiscNodes)
      {
        while (nextElement && this.IsMiscNode)
          nextElement = this.MoveToNextElement();
      }
      return nextElement;
    }

    public override bool ReadFirstChild()
    {
      this.ThrowIfObjectDisposed();
      bool flag = this.MoveToFirstChild();
      if (flag && !this.ReadMiscNodes)
      {
        while (flag && this.IsMiscNode)
          flag = this.MoveToNextSibling();
      }
      return flag;
    }

    public override bool ReadNextSibling()
    {
      this.ThrowIfObjectDisposed();
      bool nextSibling = this.MoveToNextSibling();
      if (nextSibling && !this.ReadMiscNodes)
      {
        while (nextSibling && this.IsMiscNode)
          nextSibling = this.MoveToNextSibling();
      }
      return nextSibling;
    }

    public override void Skip()
    {
      this.ThrowIfObjectDisposed();
      this.InnerSkip();
      if (this.EOF || this.ReadMiscNodes)
        return;
      while (!this.EOF && this.IsMiscNode)
        this.InnerSkip();
    }

    private bool MoveToNextElement()
    {
      switch (this._elementState)
      {
        case ElementState.Null:
          return this.ReadRoot();
        case ElementState.End:
        case ElementState.MiscNode:
          this._elementStack.Pop();
          break;
        case ElementState.LeafStart:
          this._elementState = ElementState.LeafEnd;
          return true;
        case ElementState.LeafEnd:
        case ElementState.LoadEnd:
          this._elementStack.Pop();
          if (this._elementStack.Count == 0)
          {
            this._elementState = ElementState.EOF;
            return false;
          }
          this.GetElementInformation();
          return true;
        case ElementState.EOF:
          return false;
      }
      this._elementState = ElementState.Null;
      if (this._xmlReader.EOF || !this._xmlReader.Read())
      {
        this._elementState = ElementState.EOF;
        return false;
      }
      this.GetElementInformation();
      return true;
    }

    private bool MoveToFirstChild()
    {
      switch (this._elementState)
      {
        case ElementState.Null:
          this.ThrowIfNull();
          break;
        case ElementState.Start:
          if (!this._xmlReader.Read())
            return false;
          this.GetElementInformation();
          return this._elementState != ElementState.End;
        case ElementState.End:
        case ElementState.LeafEnd:
        case ElementState.LoadEnd:
        case ElementState.MiscNode:
          return false;
        case ElementState.LeafStart:
          this._elementState = ElementState.LeafEnd;
          return false;
        case ElementState.EOF:
          return false;
      }
      return false;
    }

    private bool MoveToNextSibling()
    {
      if (this._elementState == ElementState.EOF)
        return false;
      this.InnerSkip();
      return this._elementState != ElementState.EOF && this._elementState != ElementState.End;
    }

    private void InnerSkip()
    {
      switch (this._elementState)
      {
        case ElementState.Null:
          this.ThrowIfNull();
          break;
        case ElementState.Start:
          this._xmlReader.Skip();
          this._elementStack.Pop();
          this.GetElementInformation();
          break;
        case ElementState.End:
        case ElementState.MiscNode:
          this._xmlReader.Skip();
          this._elementStack.Pop();
          this.GetElementInformation();
          break;
        case ElementState.LeafStart:
          this._elementStack.Pop();
          this.GetElementInformation();
          break;
        case ElementState.LeafEnd:
        case ElementState.LoadEnd:
          this._elementStack.Pop();
          this.GetElementInformation();
          break;
      }
    }

    public override OpenXmlElement LoadCurrentElement()
    {
      this.ThrowIfObjectDisposed();
      switch (this._elementState)
      {
        case ElementState.Null:
          this.ThrowIfNull();
          break;
        case ElementState.Start:
          OpenXmlElement openXmlElement1 = this._elementStack.Peek();
          openXmlElement1.Load(this._xmlReader, OpenXmlLoadMode.Full);
          this._elementState = ElementState.LoadEnd;
          return openXmlElement1;
        case ElementState.End:
        case ElementState.LeafEnd:
        case ElementState.LoadEnd:
          throw new InvalidOperationException(ExceptionMessages.ReaderInEndState);
        case ElementState.LeafStart:
          OpenXmlElement openXmlElement2 = this._elementStack.Pop();
          this._elementStack.Push(openXmlElement2.CloneNode(true));
          this._elementState = ElementState.LoadEnd;
          return openXmlElement2;
        case ElementState.MiscNode:
          OpenXmlElement openXmlElement3 = this._elementStack.Pop();
          openXmlElement3.Load(this._xmlReader, OpenXmlLoadMode.Full);
          this.GetElementInformation();
          return openXmlElement3;
        case ElementState.EOF:
          this.ThrowIfEof();
          break;
      }
      return (OpenXmlElement) null;
    }

    public override string GetText()
    {
      this.ThrowIfObjectDisposed();
      if (this._elementState == ElementState.LeafStart)
      {
        OpenXmlLeafTextElement xmlLeafTextElement = this._elementStack.Peek() as OpenXmlLeafTextElement;
        if (xmlLeafTextElement != null)
          return xmlLeafTextElement.Text;
      }
      return string.Empty;
    }

    public override void Close()
    {
      this.ThrowIfObjectDisposed();
      this._elementState = ElementState.EOF;
      this._elementStack.Clear();
      this._xmlReader.Close();
    }

    private void Init(Stream partStream, bool closeInput)
    {
      this._elementContext.XmlReaderSettings.CloseInput = closeInput;
      this._elementContext.XmlReaderSettings.DtdProcessing = DtdProcessing.Prohibit;
      this._elementContext.XmlReaderSettings.IgnoreWhitespace = true;
      this._xmlReader = XmlConvertingReaderFactory.Create(partStream, this._elementContext.XmlReaderSettings);
      this._xmlReader.Read();
      if (this._xmlReader.NodeType == XmlNodeType.XmlDeclaration)
      {
        this._encoding = this._xmlReader["encoding"];
        string str = this._xmlReader["standalone"];
        if (!string.IsNullOrEmpty(str))
          this._standalone = !(str == "yes") ? new bool?(false) : new bool?(true);
      }
      this._elementState = ElementState.Null;
    }

    private bool ReadRoot()
    {
      int content = (int) this._xmlReader.MoveToContent();
      while (!this._xmlReader.EOF && this._xmlReader.NodeType != XmlNodeType.Element)
        this._xmlReader.Skip();
      if (this._xmlReader.EOF || !this._xmlReader.IsStartElement())
        throw new InvalidDataException(ExceptionMessages.PartIsEmpty);
      OpenXmlElement element = RootElementFactory.CreateElement(this._xmlReader.NamespaceURI, this._xmlReader.LocalName);
      if (element == null)
        throw new InvalidDataException(ExceptionMessages.PartUnknown);
      this._elementStack.Push(element);
      this.LoadAttributes();
      if (this._xmlReader.IsEmptyElement)
      {
        this._elementState = ElementState.LeafStart;
        element.Load(this._xmlReader, OpenXmlLoadMode.Full);
      }
      else
        this._elementState = ElementState.Start;
      return true;
    }

    private void LoadAttributes()
    {
      this._attributeList.Clear();
      this._nsDecls.Clear();
      if (!this._xmlReader.HasAttributes)
        return;
      while (this._xmlReader.MoveToNextAttribute())
      {
        if (this._xmlReader.Prefix == "xmlns")
          this._nsDecls.Add(new KeyValuePair<string, string>(this._xmlReader.LocalName, this._xmlReader.Value));
        else
          this._attributeList.Add(new OpenXmlAttribute(this._xmlReader.Prefix, this._xmlReader.LocalName, this._xmlReader.NamespaceURI, this._xmlReader.Value));
      }
      this._xmlReader.MoveToElement();
    }

    private void GetElementInformation()
    {
      if (this._xmlReader.EOF)
      {
        this._elementState = ElementState.EOF;
      }
      else
      {
        switch (this._xmlReader.NodeType)
        {
          case XmlNodeType.Element:
            OpenXmlElement childElement1 = this.CreateChildElement();
            this.LoadAttributes();
            if (this._xmlReader.IsEmptyElement)
            {
              this._elementState = ElementState.LeafStart;
              childElement1.Load(this._xmlReader, OpenXmlLoadMode.Full);
            }
            else if (childElement1 is OpenXmlLeafElement || childElement1 is OpenXmlLeafTextElement)
            {
              this._elementState = ElementState.LeafStart;
              childElement1.Load(this._xmlReader, OpenXmlLoadMode.Full);
            }
            else
              this._elementState = !(childElement1 is OpenXmlUnknownElement) ? ElementState.Start : ElementState.Start;
            this._elementStack.Push(childElement1);
            break;
          case XmlNodeType.EndElement:
            this._elementState = ElementState.End;
            break;
          default:
            OpenXmlElement childElement2 = this.CreateChildElement();
            (childElement2 as OpenXmlMiscNode).LoadOuterXml(this._xmlReader);
            this._elementStack.Push(childElement2);
            this._elementState = ElementState.MiscNode;
            break;
        }
      }
    }

    private OpenXmlElement CreateChildElement()
    {
      OpenXmlElement newChild1 = this._elementStack.Peek();
      if ((newChild1 is AlternateContentChoice || newChild1 is AlternateContentFallback) && this._elementStack.Count > 2)
      {
        OpenXmlElement openXmlElement1 = this._elementStack.Pop();
        OpenXmlElement openXmlElement2 = this._elementStack.Pop();
        OpenXmlElement openXmlElement3 = this._elementStack.Peek().CloneNode(false);
        this._elementStack.Push(openXmlElement2);
        this._elementStack.Push(openXmlElement1);
        newChild1 = openXmlElement1.CloneNode(false);
        OpenXmlElement newChild2 = (OpenXmlElement) new AlternateContent();
        newChild2.AppendChild<OpenXmlElement>(newChild1);
        openXmlElement3.AppendChild<OpenXmlElement>(newChild2);
      }
      return newChild1.ElementFactory(this._xmlReader);
    }

    private void ThrowIfNull()
    {
      if (this._elementState == ElementState.Null)
        throw new InvalidOperationException(ExceptionMessages.ReaderInNullState);
    }

    private void ThrowIfEof()
    {
      if (this._elementState == ElementState.EOF || this._elementStack.Count <= 0)
        throw new InvalidOperationException(ExceptionMessages.ReaderInEofState);
    }
  }
}

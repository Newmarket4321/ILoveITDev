// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.OpenXmlDomReader
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace DocumentFormat.OpenXml
{
  public class OpenXmlDomReader : OpenXmlReader
  {
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static ReadOnlyCollection<OpenXmlAttribute> _emptyReadOnlyList;
    private OpenXmlElement _rootElement;
    private Stack<OpenXmlElement> _elementStack;
    private ElementState _elementState;

    private OpenXmlDomReader()
    {
      this._elementStack = new Stack<OpenXmlElement>();
      this._elementState = ElementState.Null;
    }

    private OpenXmlDomReader(bool readMiscNodes)
      : base(readMiscNodes)
    {
      this._elementStack = new Stack<OpenXmlElement>();
      this._elementState = ElementState.Null;
    }

    public OpenXmlDomReader(OpenXmlElement openXmlElement)
      : this()
    {
      if (openXmlElement == null)
        throw new ArgumentNullException(nameof (openXmlElement));
      this.Init(openXmlElement);
    }

    public OpenXmlDomReader(OpenXmlElement openXmlElement, bool readMiscNodes)
      : this(readMiscNodes)
    {
      if (openXmlElement == null)
        throw new ArgumentNullException(nameof (openXmlElement));
      this.Init(openXmlElement);
    }

    public override ReadOnlyCollection<OpenXmlAttribute> Attributes
    {
      get
      {
        this.ThrowIfObjectDisposed();
        this.ThrowIfNull();
        this.ThrowIfEof();
        if (this._elementState == ElementState.Start)
          return new ReadOnlyCollection<OpenXmlAttribute>(this._elementStack.Peek().GetAttributes());
        if (OpenXmlDomReader._emptyReadOnlyList == null)
          OpenXmlDomReader._emptyReadOnlyList = new ReadOnlyCollection<OpenXmlAttribute>((IList<OpenXmlAttribute>) new List<OpenXmlAttribute>());
        return OpenXmlDomReader._emptyReadOnlyList;
      }
    }

    public override IEnumerable<KeyValuePair<string, string>> NamespaceDeclarations
    {
      get
      {
        this.ThrowIfObjectDisposed();
        this.ThrowIfNull();
        this.ThrowIfEof();
        if (this._elementState == ElementState.Start)
          return this._elementStack.Peek().NamespaceDeclarations;
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
        return !this.IsMiscNode && this._elementState == ElementState.End;
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
      if (this._elementState == ElementState.Null)
        return this.ReadRoot();
      switch (this._elementState)
      {
        case ElementState.Start:
          OpenXmlElement openXmlElement1 = this._elementStack.Peek();
          if (openXmlElement1.HasChildren)
          {
            this._elementStack.Push(openXmlElement1.FirstChild);
            this._elementState = !(openXmlElement1.FirstChild is OpenXmlMiscNode) ? ElementState.Start : ElementState.MiscNode;
            break;
          }
          this._elementState = ElementState.End;
          break;
        case ElementState.End:
        case ElementState.MiscNode:
          OpenXmlElement openXmlElement2 = this._elementStack.Pop();
          if (this._elementStack.Count > 0)
          {
            OpenXmlElement openXmlElement3 = openXmlElement2.NextSibling();
            if (openXmlElement3 != null)
            {
              this._elementStack.Push(openXmlElement3);
              this._elementState = !(openXmlElement3 is OpenXmlMiscNode) ? ElementState.Start : ElementState.MiscNode;
              break;
            }
            this._elementState = ElementState.End;
            break;
          }
          this._elementState = ElementState.EOF;
          return false;
        case ElementState.EOF:
          return false;
        default:
          return false;
      }
      return true;
    }

    private bool MoveToFirstChild()
    {
      this.ThrowIfNull();
      if (this._elementState != ElementState.Start)
        return false;
      OpenXmlElement openXmlElement = this._elementStack.Peek();
      if (openXmlElement.HasChildren)
      {
        this._elementStack.Push(openXmlElement.FirstChild);
        this._elementState = !(openXmlElement.FirstChild is OpenXmlMiscNode) ? ElementState.Start : ElementState.MiscNode;
        return true;
      }
      this._elementState = ElementState.End;
      return false;
    }

    private bool MoveToNextSibling()
    {
      if (this._elementState == ElementState.EOF)
        return false;
      this.ThrowIfNull();
      if (this._elementStack.Count == 0)
      {
        this._elementState = ElementState.EOF;
        return false;
      }
      OpenXmlElement openXmlElement1 = this._elementStack.Pop();
      if (this._elementStack.Count == 0)
      {
        this._elementState = ElementState.EOF;
        return false;
      }
      OpenXmlElement openXmlElement2 = openXmlElement1.NextSibling();
      if (openXmlElement2 != null)
      {
        this._elementStack.Push(openXmlElement2);
        this._elementState = !(openXmlElement2 is OpenXmlMiscNode) ? ElementState.Start : ElementState.MiscNode;
        return true;
      }
      this._elementState = this._elementStack.Count <= 0 ? ElementState.EOF : ElementState.End;
      return false;
    }

    private void InnerSkip()
    {
      switch (this._elementState)
      {
        case ElementState.Null:
          this.ThrowIfNull();
          break;
        case ElementState.Start:
          this.MoveToNextSibling();
          break;
        case ElementState.End:
        case ElementState.MiscNode:
          this.MoveToNextElement();
          break;
      }
    }

    public override OpenXmlElement LoadCurrentElement()
    {
      this.ThrowIfObjectDisposed();
      this.ThrowIfNull();
      this.ThrowIfEof();
      if (this._elementState == ElementState.Start)
      {
        OpenXmlElement openXmlElement = this._elementStack.Peek();
        this._elementState = ElementState.End;
        return openXmlElement;
      }
      if (this._elementState != ElementState.MiscNode)
        throw new InvalidOperationException(ExceptionMessages.ReaderInEndState);
      OpenXmlElement openXmlElement1 = this._elementStack.Peek();
      this.Skip();
      return openXmlElement1;
    }

    public override string GetText()
    {
      this.ThrowIfObjectDisposed();
      if (this._elementState == ElementState.Start)
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
      this._rootElement = (OpenXmlElement) null;
    }

    private void Init(OpenXmlElement openXmlElement)
    {
      this._rootElement = openXmlElement;
      this._elementState = ElementState.Null;
    }

    private bool ReadRoot()
    {
      this._elementStack.Push(this._rootElement);
      this._elementState = !(this._rootElement is OpenXmlMiscNode) ? ElementState.Start : ElementState.MiscNode;
      return true;
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

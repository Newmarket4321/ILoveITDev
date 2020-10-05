// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.OpenXmlCompositeElement
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;

namespace DocumentFormat.OpenXml
{
  public abstract class OpenXmlCompositeElement : OpenXmlElement
  {
    private OpenXmlElement _lastChild;

    protected OpenXmlCompositeElement()
    {
    }

    protected OpenXmlCompositeElement(string outerXml)
      : base(outerXml)
    {
    }

    protected OpenXmlCompositeElement(IEnumerable childrenElements)
      : this()
    {
      if (childrenElements == null)
        throw new ArgumentNullException(nameof (childrenElements));
      foreach (OpenXmlElement childrenElement in childrenElements)
        this.AppendChild<OpenXmlElement>(childrenElement);
    }

    protected OpenXmlCompositeElement(IEnumerable<OpenXmlElement> childrenElements)
      : this()
    {
      if (childrenElements == null)
        throw new ArgumentNullException(nameof (childrenElements));
      foreach (OpenXmlElement childrenElement in childrenElements)
        this.AppendChild<OpenXmlElement>(childrenElement);
    }

    protected OpenXmlCompositeElement(params OpenXmlElement[] childrenElements)
      : this()
    {
      if (childrenElements == null)
        throw new ArgumentNullException(nameof (childrenElements));
      foreach (OpenXmlElement childrenElement in childrenElements)
        this.AppendChild<OpenXmlElement>(childrenElement);
    }

    public override OpenXmlElement FirstChild
    {
      get
      {
        this.MakeSureParsed();
        OpenXmlElement lastChild = this._lastChild;
        if (lastChild != null)
          return lastChild.next;
        return (OpenXmlElement) null;
      }
    }

    public override OpenXmlElement LastChild
    {
      get
      {
        this.MakeSureParsed();
        return this._lastChild;
      }
    }

    public override bool HasChildren
    {
      get
      {
        return this.LastChild != null;
      }
    }

    public override string InnerText
    {
      get
      {
        StringBuilder stringBuilder = new StringBuilder();
        foreach (OpenXmlElement childElement in this.ChildElements)
          stringBuilder.Append(childElement.InnerText);
        return stringBuilder.ToString();
      }
    }

    public override string InnerXml
    {
      set
      {
        this.RemoveAllChildren();
        if (string.IsNullOrEmpty(value))
          return;
        StringWriter stringWriter = new StringWriter((IFormatProvider) CultureInfo.InvariantCulture);
        XmlTextWriter xmlTextWriter = (XmlTextWriter) new XmlDOMTextWriter((TextWriter) stringWriter);
        try
        {
          xmlTextWriter.WriteStartElement(this.Prefix, this.LocalName, this.NamespaceUri);
          xmlTextWriter.WriteRaw(value);
          xmlTextWriter.WriteEndElement();
        }
        finally
        {
          xmlTextWriter.Close();
        }
        OpenXmlElement openXmlElement1 = this.CloneNode(false);
        openXmlElement1.OuterXml = stringWriter.ToString();
        OpenXmlElement oldChild = openXmlElement1.FirstChild;
        OpenXmlElement openXmlElement2;
        for (; oldChild != null; oldChild = openXmlElement2)
        {
          openXmlElement2 = oldChild.NextSibling();
          this.AppendChild<OpenXmlElement>(openXmlElement1.RemoveChild<OpenXmlElement>(oldChild));
        }
      }
    }

    public override T AppendChild<T>(T newChild)
    {
      if ((object) newChild == null)
        return default (T);
      if (newChild.Parent != null)
        throw new InvalidOperationException(ExceptionMessages.ElementIsPartOfTree);
      this.ElementInsertingEvent((OpenXmlElement) newChild);
      OpenXmlElement lastChild = this.LastChild;
      OpenXmlElement openXmlElement = (OpenXmlElement) newChild;
      if (lastChild == null)
      {
        openXmlElement.next = openXmlElement;
        this._lastChild = openXmlElement;
      }
      else
      {
        openXmlElement.next = lastChild.next;
        lastChild.next = openXmlElement;
        this._lastChild = openXmlElement;
      }
      newChild.Parent = (OpenXmlElement) this;
      this.ElementInsertedEvent((OpenXmlElement) newChild);
      return newChild;
    }

    public override T InsertAfter<T>(T newChild, OpenXmlElement refChild)
    {
      if ((object) newChild == null)
        return default (T);
      if (newChild.Parent != null)
        throw new InvalidOperationException(ExceptionMessages.ElementIsPartOfTree);
      if (refChild == null)
        return this.PrependChild<T>(newChild);
      if (refChild.Parent != this)
        throw new InvalidOperationException();
      this.ElementInsertingEvent((OpenXmlElement) newChild);
      OpenXmlElement openXmlElement1 = (OpenXmlElement) newChild;
      OpenXmlElement openXmlElement2 = refChild;
      if (openXmlElement2 == this._lastChild)
      {
        openXmlElement1.next = openXmlElement2.next;
        openXmlElement2.next = openXmlElement1;
        this._lastChild = openXmlElement1;
      }
      else
      {
        OpenXmlElement next = openXmlElement2.next;
        openXmlElement1.next = next;
        openXmlElement2.next = openXmlElement1;
      }
      newChild.Parent = (OpenXmlElement) this;
      this.ElementInsertedEvent((OpenXmlElement) newChild);
      return newChild;
    }

    public override T InsertBefore<T>(T newChild, OpenXmlElement refChild)
    {
      if ((object) newChild == null)
        return default (T);
      if (newChild.Parent != null)
        throw new InvalidOperationException(ExceptionMessages.ElementIsPartOfTree);
      if (refChild == null)
        return this.AppendChild<T>(newChild);
      if (refChild != null && refChild.Parent != this)
        throw new InvalidOperationException();
      this.ElementInsertingEvent((OpenXmlElement) newChild);
      OpenXmlElement openXmlElement1 = (OpenXmlElement) newChild;
      OpenXmlElement openXmlElement2 = refChild;
      if (openXmlElement2 == this.FirstChild)
      {
        openXmlElement1.next = openXmlElement2;
        this._lastChild.next = openXmlElement1;
      }
      else
      {
        OpenXmlElement openXmlElement3 = openXmlElement2.PreviousSibling();
        openXmlElement1.next = openXmlElement2;
        openXmlElement3.next = openXmlElement1;
      }
      newChild.Parent = (OpenXmlElement) this;
      this.ElementInsertedEvent((OpenXmlElement) newChild);
      return newChild;
    }

    public override T InsertAt<T>(T newChild, int index)
    {
      if ((object) newChild == null)
        return default (T);
      if (newChild.Parent != null)
        throw new InvalidOperationException(ExceptionMessages.ElementIsPartOfTree);
      if (index < 0 || index > this.ChildElements.Count)
        throw new ArgumentOutOfRangeException(nameof (index));
      if (index == 0)
        return this.PrependChild<T>(newChild);
      if (index == this.ChildElements.Count)
        return this.AppendChild<T>(newChild);
      OpenXmlElement childElement = this.ChildElements[index];
      return this.InsertBefore<T>(newChild, childElement);
    }

    public override T PrependChild<T>(T newChild)
    {
      if ((object) newChild == null)
        return default (T);
      if (newChild.Parent != null)
        throw new InvalidOperationException(ExceptionMessages.ElementIsPartOfTree);
      return this.InsertBefore<T>(newChild, this.FirstChild);
    }

    public override T RemoveChild<T>(T oldChild)
    {
      if ((object) oldChild == null)
        return default (T);
      if (oldChild.Parent != this)
        throw new InvalidOperationException(ExceptionMessages.ElementIsNotChild);
      T obj = oldChild;
      OpenXmlElement lastChild = this._lastChild;
      this.ElementRemovingEvent((OpenXmlElement) obj);
      if ((object) obj == this.FirstChild)
      {
        if ((object) obj == this._lastChild)
        {
          this._lastChild = (OpenXmlElement) null;
        }
        else
        {
          OpenXmlElement next = obj.next;
          lastChild.next = next;
        }
      }
      else if ((object) obj == this._lastChild)
      {
        OpenXmlElement openXmlElement = obj.PreviousSibling();
        OpenXmlElement next = obj.next;
        openXmlElement.next = next;
        this._lastChild = openXmlElement;
      }
      else
        obj.PreviousSibling().next = obj.next;
      obj.next = (OpenXmlElement) null;
      obj.Parent = (OpenXmlElement) null;
      this.ElementRemovedEvent((OpenXmlElement) obj);
      return obj;
    }

    public override void RemoveAllChildren()
    {
      OpenXmlElement openXmlElement;
      for (OpenXmlElement oldChild = this.FirstChild; oldChild != null; oldChild = openXmlElement)
      {
        openXmlElement = oldChild.NextSibling();
        this.RemoveChild<OpenXmlElement>(oldChild);
      }
    }

    public override T ReplaceChild<T>(OpenXmlElement newChild, T oldChild)
    {
      if ((object) oldChild == null)
        return default (T);
      if (newChild == null)
        throw new ArgumentNullException(nameof (newChild));
      if (oldChild.Parent != this)
        throw new InvalidOperationException(ExceptionMessages.ElementIsNotChild);
      if (newChild.Parent != null)
        throw new InvalidOperationException(ExceptionMessages.ElementIsPartOfTree);
      OpenXmlElement refChild = oldChild.NextSibling();
      this.RemoveChild<T>(oldChild);
      this.InsertBefore<OpenXmlElement>(newChild, refChild);
      return oldChild;
    }

    internal override void WriteContentTo(XmlWriter w)
    {
      if (!this.HasChildren)
        return;
      foreach (OpenXmlElement childElement in this.ChildElements)
        childElement.WriteTo(w);
    }

    internal void ElementInsertingEvent(OpenXmlElement element)
    {
      if (this.OpenXmlElementContext == null)
        return;
      this.OpenXmlElementContext.ElementInsertingEvent(element, (OpenXmlElement) this);
    }

    internal void ElementInsertedEvent(OpenXmlElement element)
    {
      if (this.OpenXmlElementContext == null)
        return;
      this.OpenXmlElementContext.ElementInsertedEvent(element, (OpenXmlElement) this);
    }

    internal void ElementRemovingEvent(OpenXmlElement element)
    {
      if (this.OpenXmlElementContext == null)
        return;
      this.OpenXmlElementContext.ElementRemovingEvent(element, (OpenXmlElement) this);
    }

    internal void ElementRemovedEvent(OpenXmlElement element)
    {
      if (this.OpenXmlElementContext == null)
        return;
      this.OpenXmlElementContext.ElementRemovedEvent(element, (OpenXmlElement) this);
    }

    internal override void Populate(XmlReader xmlReader, OpenXmlLoadMode loadMode)
    {
      this.LoadAttributes(xmlReader);
      if (!xmlReader.IsEmptyElement)
      {
        xmlReader.Read();
        while (!xmlReader.EOF)
        {
          if (xmlReader.NodeType == XmlNodeType.Whitespace)
          {
            xmlReader.Skip();
          }
          else
          {
            if (xmlReader.NodeType == XmlNodeType.EndElement)
            {
              xmlReader.Skip();
              break;
            }
            OpenXmlElement openXmlElement1 = this.ElementFactory(xmlReader);
            openXmlElement1.Parent = (OpenXmlElement) this;
            bool flag1 = openXmlElement1 is AlternateContent;
            if (flag1 && openXmlElement1.OpenXmlElementContext != null)
              ++openXmlElement1.OpenXmlElementContext.ACBlockLevel;
            bool flag2 = false;
            if (!(openXmlElement1 is OpenXmlMiscNode))
              flag2 = this.PushMcContext(xmlReader);
            ElementAction elementAction = ElementAction.Normal;
            if (this.OpenXmlElementContext != null && this.OpenXmlElementContext.MCSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess)
              elementAction = this.OpenXmlElementContext.MCContext.GetElementAction(openXmlElement1, this.OpenXmlElementContext.MCSettings.TargetFileFormatVersions);
            openXmlElement1.Load(xmlReader, loadMode);
            if (flag2)
              this.PopMcContext();
            if (flag1 && openXmlElement1.OpenXmlElementContext != null)
              --openXmlElement1.OpenXmlElementContext.ACBlockLevel;
            switch (elementAction)
            {
              case ElementAction.Normal:
                this.AddANode(openXmlElement1);
                continue;
              case ElementAction.Ignore:
                openXmlElement1.Parent = (OpenXmlElement) null;
                continue;
              case ElementAction.ProcessContent:
                openXmlElement1.Parent = (OpenXmlElement) null;
                while (openXmlElement1.ChildElements.Count > 0)
                {
                  OpenXmlElement firstChild = openXmlElement1.FirstChild;
                  firstChild.Remove();
                  OpenXmlElement openXmlElement2 = (OpenXmlElement) null;
                  if (firstChild is OpenXmlUnknownElement)
                  {
                    openXmlElement2 = this.ElementFactory(firstChild.Prefix, firstChild.LocalName, firstChild.NamespaceUri);
                    if (!(openXmlElement2 is OpenXmlUnknownElement))
                    {
                      openXmlElement2.OuterXml = firstChild.OuterXml;
                      OpenXmlCompositeElement.RemoveUnnecessaryExtAttr(firstChild, openXmlElement2);
                    }
                    else
                      openXmlElement2 = (OpenXmlElement) null;
                  }
                  if (openXmlElement2 != null)
                    this.AddANode(openXmlElement2);
                  else
                    this.AddANode(firstChild);
                }
                continue;
              case ElementAction.ACBlock:
                OpenXmlCompositeElement contentFromAcBlock = this.OpenXmlElementContext.MCContext.GetContentFromACBlock(openXmlElement1 as AlternateContent, this.OpenXmlElementContext.MCSettings.TargetFileFormatVersions);
                if (contentFromAcBlock != null)
                {
                  openXmlElement1.Parent = (OpenXmlElement) null;
                  contentFromAcBlock.Parent = (OpenXmlElement) null;
                  while (contentFromAcBlock.FirstChild != null)
                  {
                    OpenXmlElement firstChild = contentFromAcBlock.FirstChild;
                    firstChild.Remove();
                    this.AddANode(firstChild);
                    firstChild.CheckMustUnderstandAttr();
                  }
                  continue;
                }
                continue;
              default:
                continue;
            }
          }
        }
      }
      else
        xmlReader.Skip();
      this.RawOuterXml = string.Empty;
    }

    private static void RemoveUnnecessaryExtAttr(OpenXmlElement node, OpenXmlElement newnode)
    {
      node.MakeSureParsed();
      if (newnode.NamespaceDeclField == null || node.NamespaceDeclField == null)
        return;
      newnode.NamespaceDeclField = new List<KeyValuePair<string, string>>((IEnumerable<KeyValuePair<string, string>>) node.NamespaceDeclField);
    }

    internal virtual string[] ElementTagNames
    {
      get
      {
        return (string[]) null;
      }
    }

    internal virtual byte[] ElementNamespaceIds
    {
      get
      {
        return (byte[]) null;
      }
    }

    private int GetSequenceNumber(OpenXmlElement child)
    {
      for (int index = 0; index < this.ElementNamespaceIds.Length; ++index)
      {
        if ((int) this.ElementNamespaceIds[index] == (int) child.NamespaceId && object.Equals((object) this.ElementTagNames[index], (object) child.LocalName))
          return index;
      }
      return -1;
    }

    internal T GetElement<T>(int sequenceNumber) where T : OpenXmlElement
    {
      switch (this.OpenXmlCompositeType)
      {
        case OpenXmlCompositeType.Other:
          throw new InvalidOperationException();
        case OpenXmlCompositeType.OneSequence:
          OpenXmlElement openXmlElement1 = this.FirstChild;
          while (openXmlElement1 != null)
          {
            if (OpenXmlElement.IsKnownElement(openXmlElement1))
            {
              int sequenceNumber1 = this.GetSequenceNumber(openXmlElement1);
              if (sequenceNumber1 == sequenceNumber)
              {
                T obj = openXmlElement1 as T;
                if ((object) obj != null)
                  return obj;
                openXmlElement1 = openXmlElement1.NextSibling();
              }
              else
              {
                if (sequenceNumber1 > sequenceNumber)
                  return default (T);
                openXmlElement1 = openXmlElement1.NextSibling();
              }
            }
            else
              openXmlElement1 = openXmlElement1.NextSibling();
          }
          break;
        case OpenXmlCompositeType.OneChoice:
          OpenXmlElement openXmlElement2 = this.FirstChild;
          while (openXmlElement2 != null && !OpenXmlElement.IsKnownElement(openXmlElement2))
            openXmlElement2 = openXmlElement2.NextSibling();
          if (openXmlElement2 != null && this.GetSequenceNumber(openXmlElement2) == sequenceNumber)
          {
            T obj = openXmlElement2 as T;
            if ((object) obj != null)
              return obj;
            break;
          }
          break;
        case OpenXmlCompositeType.OneAll:
          using (IEnumerator<OpenXmlElement> enumerator = this.ChildElements.GetEnumerator())
          {
            while (enumerator.MoveNext())
            {
              OpenXmlElement current = enumerator.Current;
              if (OpenXmlElement.IsKnownElement(current) && this.GetSequenceNumber(current) == sequenceNumber)
              {
                T obj = current as T;
                if ((object) obj != null)
                  return obj;
              }
            }
            break;
          }
      }
      return default (T);
    }

    internal void SetElement<T>(int sequenceNumber, T newChild) where T : OpenXmlElement
    {
      switch (this.OpenXmlCompositeType)
      {
        case OpenXmlCompositeType.Other:
          throw new InvalidOperationException();
        case OpenXmlCompositeType.OneSequence:
          OpenXmlElement openXmlElement1 = this.FirstChild;
          OpenXmlElement refChild1 = (OpenXmlElement) null;
          for (; openXmlElement1 != null; openXmlElement1 = openXmlElement1.NextSibling())
          {
            if (OpenXmlElement.IsKnownElement(openXmlElement1))
            {
              int sequenceNumber1 = this.GetSequenceNumber(openXmlElement1);
              if (sequenceNumber1 == sequenceNumber)
              {
                if (openXmlElement1 is T)
                {
                  refChild1 = openXmlElement1.PreviousSibling();
                  this.RemoveChild<OpenXmlElement>(openXmlElement1);
                  break;
                }
                refChild1 = openXmlElement1;
              }
              else if (sequenceNumber1 <= sequenceNumber)
                refChild1 = openXmlElement1;
              else
                break;
            }
          }
          if ((object) newChild == null)
            break;
          this.InsertAfter<T>(newChild, refChild1);
          break;
        case OpenXmlCompositeType.OneChoice:
          OpenXmlElement openXmlElement2 = this.FirstChild;
          OpenXmlElement refChild2 = (OpenXmlElement) null;
          for (; openXmlElement2 != null && !OpenXmlElement.IsKnownElement(openXmlElement2); openXmlElement2 = openXmlElement2.NextSibling())
            refChild2 = openXmlElement2;
          OpenXmlElement openXmlElement3;
          for (; openXmlElement2 != null; openXmlElement2 = openXmlElement3)
          {
            openXmlElement3 = openXmlElement2.NextSibling();
            if (OpenXmlElement.IsKnownElement(openXmlElement2))
              this.RemoveChild<OpenXmlElement>(openXmlElement2);
          }
          if ((object) newChild == null)
            break;
          this.InsertAfter<T>(newChild, refChild2);
          break;
        case OpenXmlCompositeType.OneAll:
          T element = this.GetElement<T>(sequenceNumber);
          if ((object) element != null)
            this.RemoveChild<T>(element);
          if ((object) newChild == null)
            break;
          this.AppendChild<T>(newChild);
          break;
      }
    }

    internal virtual OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.Other;
      }
    }

    private void AddANode(OpenXmlElement node)
    {
      node.Parent = (OpenXmlElement) this;
      if (this._lastChild == null)
      {
        node.next = node;
        this._lastChild = node;
      }
      else
      {
        node.next = this._lastChild.next;
        this._lastChild.next = node;
        this._lastChild = node;
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.OpenXmlElement
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Xml;

namespace DocumentFormat.OpenXml
{
  public abstract class OpenXmlElement : IEnumerable<OpenXmlElement>, IEnumerable, ICloneable
  {
    private string _rawOuterXml = string.Empty;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private OpenXmlElement _parent;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private OpenXmlElement _next;
    private object _annotations;
    private OpenXmlSimpleType[] _fixedAttributes;

    internal MiscAttrContainer MiscAttrContainer { get; set; }

    private List<OpenXmlAttribute> ExtendedAttributesField
    {
      get
      {
        if (this.MiscAttrContainer == null)
          return (List<OpenXmlAttribute>) null;
        return this.MiscAttrContainer.ExtendedAttributesField;
      }
      set
      {
        if (this.MiscAttrContainer == null)
          this.MiscAttrContainer = new MiscAttrContainer();
        this.MiscAttrContainer.ExtendedAttributesField = value;
      }
    }

    private MarkupCompatibilityAttributes McAttributesFiled
    {
      get
      {
        if (this.MiscAttrContainer == null)
          return (MarkupCompatibilityAttributes) null;
        return this.MiscAttrContainer._mcAttributes;
      }
      set
      {
        if (this.MiscAttrContainer == null)
          this.MiscAttrContainer = new MiscAttrContainer();
        this.MiscAttrContainer._mcAttributes = value;
      }
    }

    internal List<KeyValuePair<string, string>> NamespaceDeclField
    {
      get
      {
        if (this.MiscAttrContainer == null)
          return (List<KeyValuePair<string, string>>) null;
        return this.MiscAttrContainer._nsMappings;
      }
      set
      {
        if (this.MiscAttrContainer == null)
          this.MiscAttrContainer = new MiscAttrContainer();
        this.MiscAttrContainer._nsMappings = value;
      }
    }

    protected OpenXmlElement()
    {
    }

    protected OpenXmlElement(string outerXml)
      : this()
    {
      if (string.IsNullOrEmpty(outerXml))
        return;
      if (!this.ValidOuterXml(outerXml, this.NamespaceUri, this.LocalName))
        throw new ArgumentException(ExceptionMessages.InvalidOuterXml, nameof (outerXml));
      this.RawOuterXml = outerXml;
    }

    internal OpenXmlElement next
    {
      get
      {
        return this._next;
      }
      set
      {
        this._next = value;
      }
    }

    internal bool XmlParsed
    {
      get
      {
        return string.IsNullOrEmpty(this._rawOuterXml);
      }
    }

    internal string RawOuterXml
    {
      get
      {
        return this._rawOuterXml;
      }
      set
      {
        if (string.IsNullOrEmpty(value))
          this._rawOuterXml = string.Empty;
        this._rawOuterXml = value;
      }
    }

    private OpenXmlSimpleType[] FixedAttributesArray
    {
      get
      {
        if (this._fixedAttributes == null && this.FixedAttributeTotal > 0)
          this._fixedAttributes = new OpenXmlSimpleType[this.FixedAttributeTotal];
        return this._fixedAttributes;
      }
    }

    internal OpenXmlSimpleType[] Attributes
    {
      get
      {
        this.MakeSureParsed();
        return this.FixedAttributesArray;
      }
    }

    internal abstract byte NamespaceId { get; }

    internal int FixedAttributeTotal
    {
      get
      {
        if (this.AttributeTagNames != null)
          return this.AttributeTagNames.Length;
        return 0;
      }
    }

    internal virtual string[] AttributeTagNames
    {
      get
      {
        return (string[]) null;
      }
    }

    internal virtual byte[] AttributeNamespaceIds
    {
      get
      {
        return (byte[]) null;
      }
    }

    internal virtual int ElementTypeId
    {
      get
      {
        return 9000;
      }
    }

    public OpenXmlElementContext OpenXmlElementContext
    {
      get
      {
        return this.RootElementContext;
      }
    }

    internal virtual OpenXmlElementContext RootElementContext
    {
      get
      {
        if (this.Parent != null)
          return this.Parent.RootElementContext;
        return (OpenXmlElementContext) null;
      }
    }

    public virtual OpenXmlElement FirstChild
    {
      get
      {
        return (OpenXmlElement) null;
      }
    }

    public virtual OpenXmlElement LastChild
    {
      get
      {
        return (OpenXmlElement) null;
      }
    }

    public bool HasAttributes
    {
      get
      {
        this.MakeSureParsed();
        if (this.ExtendedAttributesField != null && this.ExtendedAttributesField.Count != 0)
          return true;
        if (this.Attributes != null)
        {
          foreach (OpenXmlSimpleType attribute in this.Attributes)
          {
            if (attribute != null)
              return true;
          }
        }
        return this.MCAttributeCount() > 0;
      }
    }

    public IEnumerable<OpenXmlAttribute> ExtendedAttributes
    {
      get
      {
        this.MakeSureParsed();
        if (this.ExtendedAttributesField != null)
          return (IEnumerable<OpenXmlAttribute>) this.ExtendedAttributesField;
        return (IEnumerable<OpenXmlAttribute>) EmptyEnumerable<OpenXmlAttribute>.EmptyEnumerableSingleton;
      }
    }

    public abstract bool HasChildren { get; }

    public virtual OpenXmlElementList ChildElements
    {
      get
      {
        if (this.HasChildren)
          return (OpenXmlElementList) new OpenXmlChildElements(this);
        return (OpenXmlElementList) EmptyElementList.EmptyElementListSingleton;
      }
    }

    public OpenXmlElement Parent
    {
      get
      {
        return this._parent;
      }
      internal set
      {
        this._parent = value;
      }
    }

    public virtual string NamespaceUri
    {
      get
      {
        return NamespaceIdMap.GetNamespaceUri(this.NamespaceId);
      }
    }

    public virtual string LocalName
    {
      get
      {
        return (string) null;
      }
    }

    public virtual string Prefix
    {
      get
      {
        this.MakeSureParsed();
        string str = this.LookupPrefix(this.NamespaceUri);
        if (string.IsNullOrEmpty(str))
          str = NamespaceIdMap.GetNamespacePrefix(this.NamespaceId);
        return str;
      }
    }

    public IEnumerable<KeyValuePair<string, string>> NamespaceDeclarations
    {
      get
      {
        this.MakeSureParsed();
        if (this.NamespaceDeclField == null)
          return (IEnumerable<KeyValuePair<string, string>>) EmptyEnumerable<KeyValuePair<string, string>>.EmptyEnumerableSingleton;
        return (IEnumerable<KeyValuePair<string, string>>) this.NamespaceDeclField;
      }
    }

    public virtual XmlQualifiedName XmlQualifiedName
    {
      get
      {
        return new XmlQualifiedName(this.LocalName, this.NamespaceUri);
      }
    }

    public virtual string InnerText
    {
      get
      {
        return string.Empty;
      }
      protected set
      {
        throw new InvalidOperationException();
      }
    }

    public virtual string InnerXml
    {
      get
      {
        if (this.XmlParsed)
        {
          StringWriter stringWriter = new StringWriter((IFormatProvider) CultureInfo.InvariantCulture);
          XmlDOMTextWriter xmlDomTextWriter = new XmlDOMTextWriter((TextWriter) stringWriter);
          try
          {
            this.WriteContentTo((XmlWriter) xmlDomTextWriter);
          }
          finally
          {
            xmlDomTextWriter.Close();
          }
          return stringWriter.ToString();
        }
        using (TextReader textReader = (TextReader) new StringReader(this.RawOuterXml))
        {
          using (XmlReader xmlReader = XmlConvertingReaderFactory.Create(textReader))
          {
            xmlReader.Read();
            return xmlReader.ReadInnerXml();
          }
        }
      }
      set
      {
        throw new InvalidOperationException(ExceptionMessages.InnerXmlCannotBeSet);
      }
    }

    public string OuterXml
    {
      get
      {
        if (!this.XmlParsed)
          return this.RawOuterXml;
        StringWriter stringWriter = new StringWriter((IFormatProvider) CultureInfo.InvariantCulture);
        XmlTextWriter xmlTextWriter = (XmlTextWriter) new XmlDOMTextWriter((TextWriter) stringWriter);
        try
        {
          this.WriteTo((XmlWriter) xmlTextWriter);
        }
        finally
        {
          xmlTextWriter.Close();
        }
        return stringWriter.ToString();
      }
      internal set
      {
        if (this.XmlParsed)
        {
          this.RemoveAllChildren();
          this.NamespaceDeclField = (List<KeyValuePair<string, string>>) null;
          this.ExtendedAttributesField = (List<OpenXmlAttribute>) null;
          if (this.FixedAttributesArray != null)
          {
            for (int index = 0; index < this.FixedAttributesArray.Length; ++index)
              this.FixedAttributesArray[index] = (OpenXmlSimpleType) null;
          }
          this.MCAttributes = (MarkupCompatibilityAttributes) null;
        }
        if (!string.IsNullOrEmpty(value))
          this.RawOuterXml = value;
        else
          this._rawOuterXml = string.Empty;
      }
    }

    public OpenXmlAttribute GetAttribute(string localName, string namespaceUri)
    {
      if (localName == null)
        throw new ArgumentNullException(nameof (localName));
      if (namespaceUri == null)
        namespaceUri = string.Empty;
      if (localName == string.Empty)
        throw new ArgumentOutOfRangeException(nameof (localName), ExceptionMessages.StringIsEmpty);
      if (this.HasAttributes)
      {
        if (this.Attributes != null && namespaceUri != null)
        {
          for (int index = 0; index < this.Attributes.Length; ++index)
          {
            if (this.Attributes[index] != null && this.AttributeTagNames[index] == localName && NamespaceIdMap.GetNamespaceUri(this.AttributeNamespaceIds[index]) == namespaceUri)
              return new OpenXmlAttribute(NamespaceIdMap.GetNamespacePrefix(this.AttributeNamespaceIds[index]), this.AttributeTagNames[index], NamespaceIdMap.GetNamespaceUri(this.AttributeNamespaceIds[index]), this.Attributes[index].ToString());
          }
        }
        foreach (OpenXmlAttribute extendedAttribute in this.ExtendedAttributes)
        {
          if (extendedAttribute.LocalName == localName && extendedAttribute.NamespaceUri == namespaceUri)
            return new OpenXmlAttribute(extendedAttribute.Prefix, extendedAttribute.LocalName, extendedAttribute.NamespaceUri, extendedAttribute.Value);
        }
        if (namespaceUri == AlternateContent.MarkupCompatibilityNamespace)
          return this.GetMCAttribute(localName);
      }
      throw new KeyNotFoundException(ExceptionMessages.CannotFindAttribute);
    }

    public IList<OpenXmlAttribute> GetAttributes()
    {
      if (!this.HasAttributes)
        return (IList<OpenXmlAttribute>) new List<OpenXmlAttribute>();
      List<OpenXmlAttribute> openXmlAttributeList = new List<OpenXmlAttribute>();
      this.GetAttributes((ICollection<OpenXmlAttribute>) openXmlAttributeList);
      return (IList<OpenXmlAttribute>) openXmlAttributeList;
    }

    private void GetAttributes(ICollection<OpenXmlAttribute> attributes)
    {
      if (attributes == null)
        throw new ArgumentNullException(nameof (attributes));
      if (!this.HasAttributes)
        return;
      if (this.Attributes != null)
      {
        for (int index = 0; index < this.Attributes.Length; ++index)
        {
          if (this.Attributes[index] != null)
          {
            OpenXmlAttribute openXmlAttribute = new OpenXmlAttribute(NamespaceIdMap.GetNamespacePrefix(this.AttributeNamespaceIds[index]), this.AttributeTagNames[index], NamespaceIdMap.GetNamespaceUri(this.AttributeNamespaceIds[index]), this.Attributes[index].ToString());
            attributes.Add(openXmlAttribute);
          }
        }
      }
      foreach (OpenXmlAttribute extendedAttribute in this.ExtendedAttributes)
      {
        OpenXmlAttribute openXmlAttribute = new OpenXmlAttribute(extendedAttribute.Prefix, extendedAttribute.LocalName, extendedAttribute.NamespaceUri, extendedAttribute.Value);
        attributes.Add(openXmlAttribute);
      }
      if (this.MCAttributes == null)
        return;
      this.AddMCAttributes(attributes);
    }

    public void SetAttribute(OpenXmlAttribute openXmlAttribute)
    {
      if (string.IsNullOrEmpty(openXmlAttribute.LocalName))
        throw new ArgumentOutOfRangeException(nameof (openXmlAttribute), ExceptionMessages.LocalNameIsNull);
      if (openXmlAttribute.Prefix == "xmlns")
        throw new InvalidOperationException(ExceptionMessages.CannotSetAttribute);
      this.MakeSureParsed();
      if (this.TrySetFixedAttribute(openXmlAttribute.NamespaceUri, openXmlAttribute.LocalName, openXmlAttribute.Value, false) || openXmlAttribute.NamespaceUri == AlternateContent.MarkupCompatibilityNamespace && this.LoadMCAttribute(openXmlAttribute.LocalName, openXmlAttribute.Value))
        return;
      int index = 0;
      if (this.ExtendedAttributesField != null)
      {
        foreach (OpenXmlAttribute openXmlAttribute1 in this.ExtendedAttributesField)
        {
          if (openXmlAttribute1.LocalName == openXmlAttribute.LocalName && openXmlAttribute1.NamespaceUri == openXmlAttribute.NamespaceUri)
          {
            this.ExtendedAttributesField.RemoveAt(index);
            break;
          }
          ++index;
        }
      }
      if (this.ExtendedAttributesField == null)
        this.ExtendedAttributesField = new List<OpenXmlAttribute>();
      this.ExtendedAttributesField.Add(new OpenXmlAttribute(openXmlAttribute.Prefix, openXmlAttribute.LocalName, openXmlAttribute.NamespaceUri, openXmlAttribute.Value));
    }

    public void RemoveAttribute(string localName, string namespaceUri)
    {
      if (localName == null)
        throw new ArgumentNullException(nameof (localName));
      if (namespaceUri == null)
        namespaceUri = string.Empty;
      if (localName == string.Empty)
        throw new ArgumentOutOfRangeException(nameof (localName), ExceptionMessages.StringIsEmpty);
      if (!this.HasAttributes)
        return;
      bool flag = false;
      if (this.FixedAttributeTotal > 0)
      {
        int attributeIndex = this.TryFindAttributeIndex(namespaceUri, localName);
        if (attributeIndex >= 0)
        {
          this.FixedAttributesArray[attributeIndex] = (OpenXmlSimpleType) null;
          flag = true;
        }
      }
      if (!flag)
      {
        int index = 0;
        if (this.ExtendedAttributesField != null)
        {
          foreach (OpenXmlAttribute openXmlAttribute in this.ExtendedAttributesField)
          {
            if (openXmlAttribute.LocalName == localName && openXmlAttribute.NamespaceUri == namespaceUri)
            {
              this.ExtendedAttributesField.RemoveAt(index);
              return;
            }
            ++index;
          }
        }
      }
      if (!(namespaceUri == AlternateContent.MarkupCompatibilityNamespace))
        return;
      this.RemoveMCAttribute(localName);
    }

    public void SetAttributes(IEnumerable<OpenXmlAttribute> openXmlAttributes)
    {
      if (openXmlAttributes == null)
        throw new ArgumentNullException(nameof (openXmlAttributes));
      foreach (OpenXmlAttribute openXmlAttribute in openXmlAttributes)
        this.SetAttribute(openXmlAttribute);
    }

    public void ClearAllAttributes()
    {
      this.MakeSureParsed();
      if (this.FixedAttributesArray != null)
      {
        for (int index = 0; index < this.FixedAttributeTotal; ++index)
          this.FixedAttributesArray[index] = (OpenXmlSimpleType) null;
      }
      this.ExtendedAttributesField = (List<OpenXmlAttribute>) null;
      this.MCAttributes = (MarkupCompatibilityAttributes) null;
    }

    public void AddNamespaceDeclaration(string prefix, string uri)
    {
      if (string.IsNullOrEmpty(prefix))
        throw new ArgumentNullException(nameof (prefix));
      if (string.IsNullOrEmpty(uri))
        throw new ArgumentNullException(nameof (uri));
      this.MakeSureParsed();
      if (this.NamespaceDeclField == null)
        this.NamespaceDeclField = new List<KeyValuePair<string, string>>();
      foreach (KeyValuePair<string, string> keyValuePair in this.NamespaceDeclField)
      {
        if (keyValuePair.Key == prefix)
          throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ExceptionMessages.DuplicatedPrefix, new object[1]
          {
            (object) prefix
          }));
      }
      this.NamespaceDeclField.Add(new KeyValuePair<string, string>(prefix, uri));
    }

    public void RemoveNamespaceDeclaration(string prefix)
    {
      if (string.IsNullOrEmpty(prefix))
        throw new ArgumentNullException(nameof (prefix));
      this.MakeSureParsed();
      if (this.NamespaceDeclField == null)
        return;
      for (int index = 0; index < this.NamespaceDeclField.Count; ++index)
      {
        if (this.NamespaceDeclField[index].Key == prefix)
        {
          this.NamespaceDeclField.RemoveAt(index);
          break;
        }
      }
    }

    public T GetFirstChild<T>() where T : OpenXmlElement
    {
      return this.ChildElements.First<T>();
    }

    public OpenXmlElement PreviousSibling()
    {
      OpenXmlCompositeElement parent = this.Parent as OpenXmlCompositeElement;
      if (parent == null)
        return (OpenXmlElement) null;
      OpenXmlElement openXmlElement1;
      OpenXmlElement openXmlElement2;
      for (openXmlElement1 = parent.FirstChild; openXmlElement1 != null; openXmlElement1 = openXmlElement2)
      {
        openXmlElement2 = openXmlElement1.NextSibling();
        if (openXmlElement2 == this)
          return openXmlElement1;
      }
      return openXmlElement1;
    }

    public T PreviousSibling<T>() where T : OpenXmlElement
    {
      for (OpenXmlElement openXmlElement = this.PreviousSibling(); openXmlElement != null; openXmlElement = openXmlElement.PreviousSibling())
      {
        if (openXmlElement is T)
          return (T) openXmlElement;
      }
      return default (T);
    }

    public OpenXmlElement NextSibling()
    {
      OpenXmlElement parent = this.Parent;
      if (parent != null && this.next != parent.FirstChild)
        return this.next;
      return (OpenXmlElement) null;
    }

    public T NextSibling<T>() where T : OpenXmlElement
    {
      for (OpenXmlElement openXmlElement = this.NextSibling(); openXmlElement != null; openXmlElement = openXmlElement.NextSibling())
      {
        if (openXmlElement is T)
          return (T) openXmlElement;
      }
      return default (T);
    }

    public IEnumerable<OpenXmlElement> Ancestors()
    {
      for (OpenXmlElement ancestor = this.Parent; ancestor != null; ancestor = ancestor.Parent)
        yield return ancestor;
    }

    public IEnumerable<T> Ancestors<T>() where T : OpenXmlElement
    {
      for (OpenXmlElement ancestor = this.Parent; ancestor != null; ancestor = ancestor.Parent)
      {
        if (ancestor is T)
          yield return (T) ancestor;
      }
    }

    public IEnumerable<T> Elements<T>() where T : OpenXmlElement
    {
      return this.ChildElements.OfType<T>();
    }

    public IEnumerable<OpenXmlElement> Elements()
    {
      return (IEnumerable<OpenXmlElement>) this.ChildElements;
    }

    public IEnumerable<T> Descendants<T>() where T : OpenXmlElement
    {
      T elementT = default (T);
      foreach (OpenXmlElement descendant in this.Descendants())
      {
        elementT = descendant as T;
        if ((object) elementT != null)
          yield return elementT;
      }
    }

    public IEnumerable<OpenXmlElement> Descendants()
    {
      if (this.FirstChild != null)
      {
        OpenXmlElement root = this.FirstChild;
        yield return root;
        Stack<OpenXmlElement> stack = new Stack<OpenXmlElement>();
        stack.Push(root);
        while (true)
        {
          while (stack.Peek() != root || stack.Peek().FirstChild == null)
          {
            if (stack.Peek().NextSibling() != null)
            {
              root = stack.Peek().NextSibling();
              stack.Pop();
              stack.Push(root);
              yield return root;
            }
            else
            {
              stack.Pop();
              if (stack.Count == 0)
                yield break;
            }
          }
          root = stack.Peek().FirstChild;
          stack.Push(root);
          yield return root;
        }
      }
    }

    public IEnumerable<OpenXmlElement> ElementsBefore()
    {
      if (this.Parent != null)
      {
        for (OpenXmlElement element = this.Parent.FirstChild; element != this; element = element.NextSibling())
          yield return element;
      }
    }

    public IEnumerable<OpenXmlElement> ElementsAfter()
    {
      if (this.Parent != null)
      {
        for (OpenXmlElement element = this.NextSibling(); element != null; element = element.NextSibling())
          yield return element;
      }
    }

    public virtual OpenXmlElement CloneNode(bool deep)
    {
      throw new NotImplementedException(ExceptionMessages.NonImplemented);
    }

    public virtual void WriteTo(XmlWriter xmlWriter)
    {
      if (xmlWriter == null)
        throw new ArgumentNullException(nameof (xmlWriter));
      if (this.XmlParsed)
      {
        string prefix = this.LookupPrefixLocal(this.NamespaceUri);
        if (string.IsNullOrEmpty(prefix))
          prefix = xmlWriter.LookupPrefix(this.NamespaceUri);
        if (string.IsNullOrEmpty(prefix))
          prefix = NamespaceIdMap.GetNamespacePrefix(this.NamespaceId);
        xmlWriter.WriteStartElement(prefix, this.LocalName, this.NamespaceUri);
        this.WriteAttributesTo(xmlWriter);
        this.WriteContentTo(xmlWriter);
        xmlWriter.WriteEndElement();
      }
      else
        xmlWriter.WriteRaw(this.RawOuterXml);
    }

    public void Append(IEnumerable<OpenXmlElement> newChildren)
    {
      if (newChildren == null)
        throw new ArgumentNullException(nameof (newChildren));
      foreach (OpenXmlElement newChild in newChildren)
        this.AppendChild<OpenXmlElement>(newChild);
    }

    public void Append(params OpenXmlElement[] newChildren)
    {
      if (newChildren == null)
        return;
      foreach (OpenXmlElement newChild in newChildren)
        this.AppendChild<OpenXmlElement>(newChild);
    }

    public virtual T AppendChild<T>(T newChild) where T : OpenXmlElement
    {
      throw new InvalidOperationException(ExceptionMessages.NonCompositeNoChild);
    }

    public virtual T InsertAfter<T>(T newChild, OpenXmlElement refChild) where T : OpenXmlElement
    {
      throw new InvalidOperationException(ExceptionMessages.NonCompositeNoChild);
    }

    public virtual T InsertBefore<T>(T newChild, OpenXmlElement refChild) where T : OpenXmlElement
    {
      throw new InvalidOperationException(ExceptionMessages.NonCompositeNoChild);
    }

    public T InsertAfterSelf<T>(T newElement) where T : OpenXmlElement
    {
      if ((object) newElement == null)
        throw new ArgumentNullException(nameof (newElement));
      if (this.Parent == null)
        throw new InvalidOperationException(ExceptionMessages.ParentIsNull);
      return this.Parent.InsertAfter<T>(newElement, this);
    }

    public T InsertBeforeSelf<T>(T newElement) where T : OpenXmlElement
    {
      if ((object) newElement == null)
        throw new ArgumentNullException(nameof (newElement));
      if (this.Parent == null)
        throw new InvalidOperationException(ExceptionMessages.ParentIsNull);
      return this.Parent.InsertBefore<T>(newElement, this);
    }

    public virtual T InsertAt<T>(T newChild, int index) where T : OpenXmlElement
    {
      throw new InvalidOperationException(ExceptionMessages.NonCompositeNoChild);
    }

    public virtual T PrependChild<T>(T newChild) where T : OpenXmlElement
    {
      throw new InvalidOperationException(ExceptionMessages.NonCompositeNoChild);
    }

    public virtual T RemoveChild<T>(T oldChild) where T : OpenXmlElement
    {
      throw new InvalidOperationException(ExceptionMessages.NonCompositeNoChild);
    }

    public virtual T ReplaceChild<T>(OpenXmlElement newChild, T oldChild) where T : OpenXmlElement
    {
      throw new InvalidOperationException(ExceptionMessages.NonCompositeNoChild);
    }

    public abstract void RemoveAllChildren();

    public void RemoveAllChildren<T>() where T : OpenXmlElement
    {
      OpenXmlElement openXmlElement;
      for (OpenXmlElement oldChild = this.FirstChild; oldChild != null; oldChild = openXmlElement)
      {
        openXmlElement = oldChild.NextSibling();
        if (oldChild is T)
          this.RemoveChild<OpenXmlElement>(oldChild);
      }
    }

    public void Remove()
    {
      if (this.Parent == null)
        throw new InvalidOperationException(ExceptionMessages.ParentIsNull);
      this.Parent.RemoveChild<OpenXmlElement>(this);
    }

    public bool IsAfter(OpenXmlElement element)
    {
      if (element == null)
        throw new ArgumentNullException(nameof (element));
      return OpenXmlElement.GetOrder(this, element) == OpenXmlElement.ElementOrder.After;
    }

    public bool IsBefore(OpenXmlElement element)
    {
      if (element == null)
        throw new ArgumentNullException(nameof (element));
      return OpenXmlElement.GetOrder(this, element) == OpenXmlElement.ElementOrder.Before;
    }

    private static OpenXmlElement.ElementOrder GetOrder(OpenXmlElement element1, OpenXmlElement element2)
    {
      if (element1.Parent == null && element2.Parent == null)
        return OpenXmlElement.ElementOrder.NotInSameTree;
      if (object.ReferenceEquals((object) element1.Parent, (object) element2.Parent))
        return OpenXmlElement.GetSiblingOrder(element1, element2);
      Stack<OpenXmlElement> openXmlElementStack1 = new Stack<OpenXmlElement>();
      Stack<OpenXmlElement> openXmlElementStack2 = new Stack<OpenXmlElement>();
      openXmlElementStack1.Push(element1);
      openXmlElementStack2.Push(element2);
      foreach (OpenXmlElement ancestor in element1.Ancestors())
        openXmlElementStack1.Push(ancestor);
      foreach (OpenXmlElement ancestor in element2.Ancestors())
        openXmlElementStack2.Push(ancestor);
      if (openXmlElementStack1.Pop() != openXmlElementStack2.Pop())
        return OpenXmlElement.ElementOrder.NotInSameTree;
      while (openXmlElementStack1.Count > 0 && openXmlElementStack2.Count > 0)
      {
        OpenXmlElement.ElementOrder siblingOrder = OpenXmlElement.GetSiblingOrder(openXmlElementStack1.Pop(), openXmlElementStack2.Pop());
        if (siblingOrder != OpenXmlElement.ElementOrder.Same)
          return siblingOrder;
      }
      return openXmlElementStack1.Count == 0 ? OpenXmlElement.ElementOrder.Before : OpenXmlElement.ElementOrder.After;
    }

    private static OpenXmlElement.ElementOrder GetSiblingOrder(OpenXmlElement element1, OpenXmlElement element2)
    {
      if (element1 == element2)
        return OpenXmlElement.ElementOrder.Same;
      for (OpenXmlElement openXmlElement = element1.NextSibling(); openXmlElement != null; openXmlElement = openXmlElement.NextSibling())
      {
        if (object.ReferenceEquals((object) openXmlElement, (object) element2))
          return OpenXmlElement.ElementOrder.Before;
      }
      return OpenXmlElement.ElementOrder.After;
    }

    internal virtual void WriteAttributesTo(XmlWriter xmlWriter)
    {
      if (this.NamespaceDeclField != null)
      {
        foreach (KeyValuePair<string, string> keyValuePair in this.NamespaceDeclField)
          xmlWriter.WriteAttributeString("xmlns", keyValuePair.Key, "http://www.w3.org/2000/xmlns/", keyValuePair.Value);
      }
      if (!this.XmlParsed || !this.HasAttributes)
        return;
      int index = 0;
      if (this.Attributes != null)
      {
        foreach (OpenXmlSimpleType attribute in this.Attributes)
        {
          if (attribute != null)
          {
            string namespaceUri = NamespaceIdMap.GetNamespaceUri(this.AttributeNamespaceIds[index]);
            string prefix = string.Empty;
            if (!string.IsNullOrEmpty(namespaceUri))
            {
              prefix = xmlWriter.LookupPrefix(namespaceUri);
              if (string.IsNullOrEmpty(prefix))
                prefix = NamespaceIdMap.GetNamespacePrefix(this.AttributeNamespaceIds[index]);
            }
            xmlWriter.WriteStartAttribute(prefix, this.AttributeTagNames[index], namespaceUri);
            xmlWriter.WriteString(attribute.InnerText);
            xmlWriter.WriteEndAttribute();
          }
          ++index;
        }
      }
      foreach (OpenXmlAttribute extendedAttribute in this.ExtendedAttributes)
        xmlWriter.WriteAttributeString(extendedAttribute.Prefix, extendedAttribute.LocalName, extendedAttribute.NamespaceUri, extendedAttribute.Value);
      this.WriteMCAttribute(xmlWriter);
    }

    internal abstract void WriteContentTo(XmlWriter w);

    internal int TryFindAttributeIndex(string namespaceUri, string tagName)
    {
      byte id = 0;
      if (namespaceUri != null && NamespaceIdMap.TryGetNamespaceId(namespaceUri, out id))
      {
        for (int index = 0; index < this.AttributeTagNames.Length; ++index)
        {
          if (this.AttributeTagNames[index].Equals(tagName) && (int) this.AttributeNamespaceIds[index] == (int) id)
            return index;
        }
      }
      return -1;
    }

    internal bool TrySetFixedAttribute(string namespaceUri, string localName, string value, bool strictTranslation)
    {
      if (this.FixedAttributeTotal > 0)
      {
        if (!strictTranslation)
        {
          int attributeIndex = this.TryFindAttributeIndex(namespaceUri, localName);
          if (attributeIndex >= 0)
          {
            OpenXmlSimpleType openXmlSimpleType = this.AttributeFactory(namespaceUri, localName);
            this.FixedAttributesArray[attributeIndex] = openXmlSimpleType;
            openXmlSimpleType.InnerText = value;
            return true;
          }
        }
        else
        {
          bool flag1 = false;
          TagAttributeTranslator attributeTranslator = AttributeTranslator.Translate(this.LocalName, localName, value);
          if (attributeTranslator != null)
          {
            localName = attributeTranslator.LocalName;
            value = attributeTranslator.Value;
            if (value == "")
              return true;
            flag1 = attributeTranslator.Trait != 0L;
          }
          int attributeIndex = this.TryFindAttributeIndex(namespaceUri, localName);
          if (attributeIndex >= 0)
          {
            bool flag2 = this.FixedAttributesArray[attributeIndex] != null;
            if (flag1)
            {
              long num = 0;
              if (flag2)
              {
                string innerText = this.FixedAttributesArray[attributeIndex].InnerText;
                num = attributeTranslator.Formatter.StringToValue(innerText);
              }
              long longValue = value == "true" || value == "1" ? num | attributeTranslator.Trait : num & ~attributeTranslator.Trait;
              value = attributeTranslator.Formatter.ValueToString(longValue);
            }
            if (!flag2)
            {
              OpenXmlSimpleType openXmlSimpleType = this.AttributeFactory(namespaceUri, localName);
              this.FixedAttributesArray[attributeIndex] = openXmlSimpleType;
            }
            this.FixedAttributesArray[attributeIndex].InnerText = value;
            return true;
          }
        }
      }
      return false;
    }

    internal virtual void LoadAttributes(XmlReader xmlReader)
    {
      if (!xmlReader.HasAttributes)
        return;
      while (xmlReader.MoveToNextAttribute())
      {
        if (!this.TrySetFixedAttribute(xmlReader.NamespaceURI, xmlReader.LocalName, xmlReader.Value, ((XmlConvertingReader) xmlReader).StrictTranslation) && (!(xmlReader.NamespaceURI == AlternateContent.MarkupCompatibilityNamespace) || !this.LoadMCAttribute(xmlReader.LocalName, xmlReader.Value)))
        {
          if (!(xmlReader.NamespaceURI == "http://www.w3.org/2000/xmlns/"))
          {
            if (this.ExtendedAttributesField == null)
              this.ExtendedAttributesField = new List<OpenXmlAttribute>();
            this.ExtendedAttributesField.Add(new OpenXmlAttribute(xmlReader.Prefix, xmlReader.LocalName, xmlReader.NamespaceURI, xmlReader.Value));
          }
          else if (!string.IsNullOrEmpty(xmlReader.Prefix))
          {
            if (this.NamespaceDeclField == null)
              this.NamespaceDeclField = new List<KeyValuePair<string, string>>();
            this.NamespaceDeclField.Add(new KeyValuePair<string, string>(xmlReader.LocalName, xmlReader.Value));
          }
        }
      }
      this.RemoveAttributesBasedonMC();
      xmlReader.MoveToElement();
    }

    internal bool PushMcContext(XmlReader xmlReader)
    {
      if (this.OpenXmlElementContext != null && this.OpenXmlElementContext.MCSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess)
      {
        this.OpenXmlElementContext.MCContext.LookupNamespaceDelegate = new MCContext.LookupNamespace(xmlReader.LookupNamespace);
        MarkupCompatibilityAttributes compatibilityAttributes = OpenXmlElement.LoadMCAttribute(xmlReader);
        if (compatibilityAttributes != null)
        {
          this.OpenXmlElementContext.MCContext.PushMCAttributes(compatibilityAttributes);
          if ((int) this.OpenXmlElementContext.ACBlockLevel == 0)
            OpenXmlElement.CheckMustUnderstandAttr(xmlReader, compatibilityAttributes, this.OpenXmlElementContext.MCSettings);
          return true;
        }
      }
      return false;
    }

    internal void PopMcContext()
    {
      if (this.OpenXmlElementContext == null || this.OpenXmlElementContext.MCSettings.ProcessMode == MarkupCompatibilityProcessMode.NoProcess)
        return;
      this.OpenXmlElementContext.MCContext.PopMCAttributes();
    }

    internal static void CheckMustUnderstandAttr(XmlReader reader, MarkupCompatibilityAttributes mcAttributes, MarkupCompatibilityProcessSettings mcSettings)
    {
      if (mcAttributes.MustUnderstand == null || string.IsNullOrEmpty(mcAttributes.MustUnderstand.Value))
        return;
      string str = mcAttributes.MustUnderstand.Value.Trim();
      char[] chArray = new char[1]{ ' ' };
      foreach (string prefix in str.Split(chArray))
      {
        string ns = reader.LookupNamespace(prefix);
        if (string.IsNullOrEmpty(ns))
          throw new InvalidMCContentException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, ExceptionMessages.UnknowMCContent, new object[1]
          {
            (object) mcAttributes.MustUnderstand.Value
          }));
        if (!NamespaceIdMap.IsInFileFormat(ns, mcSettings.TargetFileFormatVersions))
          throw new NamespaceNotUnderstandException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, ExceptionMessages.NsNotUnderStand, new object[1]
          {
            (object) prefix
          }));
      }
    }

    internal void CheckMustUnderstandAttr()
    {
      if (this.MCAttributes == null || this.OpenXmlElementContext.MCSettings.ProcessMode == MarkupCompatibilityProcessMode.NoProcess)
        return;
      if (this.MCAttributes.MustUnderstand != null && !string.IsNullOrEmpty(this.MCAttributes.MustUnderstand.Value))
      {
        string str = this.MCAttributes.MustUnderstand.Value.Trim();
        char[] chArray = new char[1]{ ' ' };
        foreach (string prefix in str.Split(chArray))
        {
          string ns = this.LookupNamespace(prefix);
          if (string.IsNullOrEmpty(ns))
            throw new InvalidMCContentException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, ExceptionMessages.UnknowMCContent, new object[1]
            {
              (object) this.MCAttributes.MustUnderstand.Value
            }));
          if (!NamespaceIdMap.IsInFileFormat(ns, this.OpenXmlElementContext.MCSettings.TargetFileFormatVersions))
            throw new NamespaceNotUnderstandException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, ExceptionMessages.NsNotUnderStand, new object[1]
            {
              (object) prefix
            }));
        }
      }
      foreach (OpenXmlElement childElement in this.ChildElements)
        childElement.CheckMustUnderstandAttr();
    }

    internal void Load(XmlReader xmlReader, OpenXmlLoadMode loadMode)
    {
      switch (loadMode)
      {
        case OpenXmlLoadMode.Full:
          this.Populate(xmlReader, loadMode);
          break;
        case OpenXmlLoadMode.Lazy:
          if (this.OpenXmlElementContext != null && xmlReader.Depth < this.OpenXmlElementContext.LazySteps)
          {
            this.Populate(xmlReader, loadMode);
            break;
          }
          this.LazyLoad(xmlReader);
          break;
      }
    }

    internal void MakeSureParsed()
    {
      if (this.XmlParsed)
        return;
      this.ParseXml();
      this.RawOuterXml = string.Empty;
    }

    internal virtual void LazyLoad(XmlReader xmlReader)
    {
      this.RawOuterXml = xmlReader.ReadOuterXml();
    }

    internal abstract void Populate(XmlReader xmlReader, OpenXmlLoadMode loadMode);

    internal virtual void ParseXml()
    {
      if (string.IsNullOrEmpty(this.RawOuterXml))
        return;
      using (XmlReader xmlReader = this.CreateXmlReader())
      {
        xmlReader.Read();
        if (this.OpenXmlElementContext != null)
          this.Populate(xmlReader, this.OpenXmlElementContext.LoadMode);
        else
          this.Populate(xmlReader, OpenXmlLoadMode.Full);
      }
    }

    internal XmlReader CreateXmlReader()
    {
      TextReader textReader = (TextReader) new StringReader(this.RawOuterXml);
      XmlReader xmlReader;
      if (this.OpenXmlElementContext != null)
      {
        this.OpenXmlElementContext.XmlReaderSettings.DtdProcessing = DtdProcessing.Prohibit;
        xmlReader = XmlConvertingReaderFactory.Create(textReader, this.OpenXmlElementContext.XmlReaderSettings);
      }
      else
        xmlReader = XmlConvertingReaderFactory.Create(textReader, OpenXmlElementContext.CreateDefaultXmlReaderSettings());
      return xmlReader;
    }

    internal XmlReader CreateXmlReader(string outerXml)
    {
      TextReader textReader = (TextReader) new StringReader(outerXml);
      XmlReader xmlReader;
      if (this.OpenXmlElementContext != null)
      {
        this.OpenXmlElementContext.XmlReaderSettings.DtdProcessing = DtdProcessing.Prohibit;
        xmlReader = XmlConvertingReaderFactory.Create(textReader, this.OpenXmlElementContext.XmlReaderSettings);
      }
      else
        xmlReader = XmlConvertingReaderFactory.Create(textReader, OpenXmlElementContext.CreateDefaultXmlReaderSettings());
      return xmlReader;
    }

    internal virtual OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      return (OpenXmlSimpleType) null;
    }

    internal virtual OpenXmlSimpleType AttributeFactory(string namespaceUri, string name)
    {
      OpenXmlSimpleType openXmlSimpleType = (OpenXmlSimpleType) null;
      byte id;
      if (namespaceUri != null && NamespaceIdMap.TryGetNamespaceId(namespaceUri, out id))
        openXmlSimpleType = this.AttributeFactory(id, name);
      if (openXmlSimpleType == null)
        openXmlSimpleType = (OpenXmlSimpleType) new StringValue();
      return openXmlSimpleType;
    }

    internal OpenXmlElement ElementFactory(XmlReader xmlReader)
    {
      switch (xmlReader.NodeType)
      {
        case XmlNodeType.Element:
          return this.ElementFactory(xmlReader.Prefix, xmlReader.LocalName, xmlReader.NamespaceURI);
        case XmlNodeType.Text:
        case XmlNodeType.CDATA:
        case XmlNodeType.Whitespace:
        case XmlNodeType.SignificantWhitespace:
          return (OpenXmlElement) new OpenXmlMiscNode(xmlReader.NodeType);
        case XmlNodeType.ProcessingInstruction:
        case XmlNodeType.Comment:
        case XmlNodeType.XmlDeclaration:
          return (OpenXmlElement) new OpenXmlMiscNode(xmlReader.NodeType);
        default:
          throw new InvalidOperationException();
      }
    }

    internal virtual OpenXmlElement ElementFactory(string prefix, string name, string namespaceUri)
    {
      OpenXmlElement openXmlElement = (OpenXmlElement) null;
      byte id;
      if (!string.IsNullOrEmpty(namespaceUri) && NamespaceIdMap.TryGetNamespaceId(namespaceUri, out id))
      {
        openXmlElement = this.ElementFactory(id, name);
        if (openXmlElement == null && (int) AlternateContent.MarkupCompatibilityNamespaceId == (int) id && AlternateContent.TagName == name)
          openXmlElement = (OpenXmlElement) new AlternateContent();
      }
      if (openXmlElement == null)
        openXmlElement = (OpenXmlElement) new OpenXmlUnknownElement(prefix, name, namespaceUri);
      return openXmlElement;
    }

    internal virtual OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      return (OpenXmlElement) null;
    }

    internal virtual OpenXmlElement AlternateContentElementFactory(byte namespaceId, string name)
    {
      return (OpenXmlElement) null;
    }

    internal virtual T CloneImp<T>(bool deep) where T : OpenXmlElement, new()
    {
      T instance = Activator.CreateInstance<T>();
      instance.CopyAttributes(this);
      if (deep)
        instance.CopyChilden(this, deep);
      return instance;
    }

    internal void CopyAttributes(OpenXmlElement container)
    {
      if (container.HasAttributes)
      {
        if (container.ExtendedAttributesField != null)
          this.ExtendedAttributesField = new List<OpenXmlAttribute>((IEnumerable<OpenXmlAttribute>) container.ExtendedAttributesField);
        if (container.Attributes != null)
        {
          for (int index = 0; index < container.Attributes.Length; ++index)
          {
            OpenXmlSimpleType attribute = container.Attributes[index];
            if (attribute != null)
              this.FixedAttributesArray[index] = (OpenXmlSimpleType) attribute.Clone();
          }
        }
        if (container.MCAttributes != null)
          this.MCAttributes = OpenXmlElement.CloneMCAttributes(container.MCAttributes);
      }
      if (container.NamespaceDeclField == null)
        return;
      this.NamespaceDeclField = new List<KeyValuePair<string, string>>((IEnumerable<KeyValuePair<string, string>>) container.NamespaceDeclField);
    }

    private static MarkupCompatibilityAttributes CloneMCAttributes(MarkupCompatibilityAttributes source)
    {
      MarkupCompatibilityAttributes compatibilityAttributes = new MarkupCompatibilityAttributes();
      if (source.Ignorable != null)
        compatibilityAttributes.Ignorable = (StringValue) source.Ignorable.Clone();
      if (source.MustUnderstand != null)
        compatibilityAttributes.MustUnderstand = (StringValue) source.MustUnderstand.Clone();
      if (source.PreserveAttributes != null)
        compatibilityAttributes.PreserveAttributes = (StringValue) source.PreserveAttributes.Clone();
      if (source.PreserveElements != null)
        compatibilityAttributes.PreserveElements = (StringValue) source.PreserveElements.Clone();
      if (source.ProcessContent != null)
        compatibilityAttributes.ProcessContent = (StringValue) source.ProcessContent.Clone();
      return compatibilityAttributes;
    }

    internal void CopyChilden(OpenXmlElement container, bool deep)
    {
      foreach (OpenXmlElement childElement in container.ChildElements)
        this.Append(new OpenXmlElement[1]
        {
          childElement.CloneNode(deep)
        });
    }

    internal abstract bool IsInVersion(FileFormatVersions version);

    public void AddAnnotation(object annotation)
    {
      if (annotation == null)
        throw new ArgumentNullException(nameof (annotation));
      if (this._annotations == null)
      {
        object obj;
        if (!(annotation is object[]))
          obj = annotation;
        else
          obj = (object) new object[1]{ annotation };
        this._annotations = obj;
      }
      else
      {
        object[] annotations = this._annotations as object[];
        if (annotations == null)
        {
          this._annotations = (object) new object[2]
          {
            this._annotations,
            annotation
          };
        }
        else
        {
          int index = 0;
          while (index < annotations.Length && annotations[index] != null)
            ++index;
          if (index == annotations.Length)
          {
            Array.Resize<object>(ref annotations, index * 2);
            this._annotations = (object) annotations;
          }
          annotations[index] = annotation;
        }
      }
    }

    public T Annotation<T>() where T : class
    {
      if (this._annotations != null)
      {
        object[] annotations = this._annotations as object[];
        if (annotations == null)
          return this._annotations as T;
        for (int index = 0; index < annotations.Length; ++index)
        {
          object obj1 = annotations[index];
          if (obj1 != null)
          {
            T obj2 = obj1 as T;
            if ((object) obj2 != null)
              return obj2;
          }
          else
            break;
        }
      }
      return default (T);
    }

    public object Annotation(Type type)
    {
      if (type == (Type) null)
        throw new ArgumentNullException(nameof (type));
      if (this._annotations != null)
      {
        object[] annotations = this._annotations as object[];
        if (annotations == null)
        {
          if (type.IsInstanceOfType(this._annotations))
            return this._annotations;
        }
        else
        {
          for (int index = 0; index < annotations.Length; ++index)
          {
            object o = annotations[index];
            if (o != null)
            {
              if (type.IsInstanceOfType(o))
                return o;
            }
            else
              break;
          }
        }
      }
      return (object) null;
    }

    public IEnumerable<T> Annotations<T>() where T : class
    {
      if (this._annotations != null)
      {
        object[] annotations = this._annotations as object[];
        if (annotations == null)
        {
          if (this._annotations is T)
            yield return (T) this._annotations;
        }
        else
        {
          for (int i = 0; i < annotations.Length; ++i)
          {
            object obj = annotations[i];
            if (obj == null)
              break;
            if (obj is T)
              yield return (T) obj;
          }
        }
      }
    }

    public IEnumerable<object> Annotations(Type type)
    {
      if (type == (Type) null)
        throw new ArgumentNullException(nameof (type));
      if (this._annotations != null)
      {
        object[] annotations = this._annotations as object[];
        if (annotations == null)
        {
          if (type.IsInstanceOfType(this._annotations))
            yield return this._annotations;
        }
        else
        {
          for (int i = 0; i < annotations.Length; ++i)
          {
            object obj = annotations[i];
            if (obj == null)
              break;
            if (type.IsInstanceOfType(obj))
              yield return obj;
          }
        }
      }
    }

    public void RemoveAnnotations<T>() where T : class
    {
      if (this._annotations == null)
        return;
      object[] annotations = this._annotations as object[];
      if (annotations == null)
      {
        if (!(this._annotations is T))
          return;
        this._annotations = (object) null;
      }
      else
      {
        int index = 0;
        int num = 0;
        for (; index < annotations.Length; ++index)
        {
          object obj = annotations[index];
          if (obj != null)
          {
            if (!(obj is T))
              annotations[num++] = obj;
          }
          else
            break;
        }
        if (num != 0)
        {
          while (num < index)
            annotations[num++] = (object) null;
        }
        else
          this._annotations = (object) null;
      }
    }

    public void RemoveAnnotations(Type type)
    {
      if (type == (Type) null)
        throw new ArgumentNullException(nameof (type));
      if (this._annotations == null)
        return;
      object[] annotations = this._annotations as object[];
      if (annotations == null)
      {
        if (!type.IsInstanceOfType(this._annotations))
          return;
        this._annotations = (object) null;
      }
      else
      {
        int index = 0;
        int num = 0;
        for (; index < annotations.Length; ++index)
        {
          object o = annotations[index];
          if (o != null)
          {
            if (!type.IsInstanceOfType(o))
              annotations[num++] = o;
          }
          else
            break;
        }
        if (num != 0)
        {
          while (num < index)
            annotations[num++] = (object) null;
        }
        else
          this._annotations = (object) null;
      }
    }

    public IEnumerator<OpenXmlElement> GetEnumerator()
    {
      return new OpenXmlChildElements(this).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return (IEnumerator) new OpenXmlChildElements(this).GetEnumerator();
    }

    public object Clone()
    {
      return (object) this.CloneNode(true);
    }

    internal bool IsXmlnsUri(string nsUri)
    {
      if (this.OpenXmlElementContext != null)
        return this.OpenXmlElementContext.IsXmlnsUri(nsUri);
      return nsUri == "http://www.w3.org/2000/xmlns/";
    }

    internal static bool IsKnownNamespace(string namespaceUri)
    {
      byte id;
      return NamespaceIdMap.TryGetNamespaceId(namespaceUri, out id);
    }

    internal static bool IsKnownElement(OpenXmlElement element)
    {
      return !(element is OpenXmlUnknownElement) && !(element is OpenXmlMiscNode);
    }

    internal static void SplitName(string name, out string prefix, out string localName)
    {
      int length = name.IndexOf(':');
      if (-1 == length || length == 0 || name.Length - 1 == length)
      {
        prefix = string.Empty;
        localName = name;
      }
      else
      {
        prefix = name.Substring(0, length);
        localName = name.Substring(length + 1);
      }
    }

    private bool ValidOuterXml(string outerXml, string namespaceURI, string localName)
    {
      using (XmlReader xmlReader = this.CreateXmlReader(outerXml))
      {
        do
        {
          if (xmlReader.Read() && xmlReader.NodeType == XmlNodeType.Element)
            return string.Equals(namespaceURI, xmlReader.NamespaceURI) && string.Equals(localName, xmlReader.LocalName);
        }
        while (xmlReader.NodeType == XmlNodeType.Whitespace);
      }
      return false;
    }

    public MarkupCompatibilityAttributes MCAttributes
    {
      get
      {
        this.MakeSureParsed();
        return this.McAttributesFiled;
      }
      set
      {
        this.MakeSureParsed();
        this.McAttributesFiled = value;
      }
    }

    private bool LoadMCAttribute(string localName, string value)
    {
      if (this.McAttributesFiled == null)
        this.McAttributesFiled = new MarkupCompatibilityAttributes();
      if (localName.Equals("Ignorable"))
      {
        this.McAttributesFiled.Ignorable = (StringValue) value;
        return true;
      }
      if (localName.Equals("ProcessContent"))
      {
        this.McAttributesFiled.ProcessContent = (StringValue) value;
        return true;
      }
      if (localName.Equals("PreserveElements"))
      {
        this.McAttributesFiled.PreserveElements = (StringValue) value;
        return true;
      }
      if (localName.Equals("PreserveAttributes"))
      {
        this.McAttributesFiled.PreserveAttributes = (StringValue) value;
        return true;
      }
      if (!localName.Equals("MustUnderstand"))
        return false;
      this.McAttributesFiled.MustUnderstand = (StringValue) value;
      return true;
    }

    private static MarkupCompatibilityAttributes LoadMCAttribute(XmlReader xmlReader)
    {
      MarkupCompatibilityAttributes compatibilityAttributes = (MarkupCompatibilityAttributes) null;
      if (xmlReader.HasAttributes)
      {
        while (xmlReader.MoveToNextAttribute())
        {
          if (xmlReader.NamespaceURI == AlternateContent.MarkupCompatibilityNamespace)
          {
            switch (xmlReader.LocalName)
            {
              case "Ignorable":
                if (compatibilityAttributes == null)
                  compatibilityAttributes = new MarkupCompatibilityAttributes();
                compatibilityAttributes.Ignorable = (StringValue) xmlReader.Value;
                continue;
              case "ProcessContent":
                if (compatibilityAttributes == null)
                  compatibilityAttributes = new MarkupCompatibilityAttributes();
                compatibilityAttributes.ProcessContent = (StringValue) xmlReader.Value;
                continue;
              case "PreserveElements":
                if (compatibilityAttributes == null)
                  compatibilityAttributes = new MarkupCompatibilityAttributes();
                compatibilityAttributes.PreserveElements = (StringValue) xmlReader.Value;
                continue;
              case "PreserveAttributes":
                if (compatibilityAttributes == null)
                  compatibilityAttributes = new MarkupCompatibilityAttributes();
                compatibilityAttributes.PreserveAttributes = (StringValue) xmlReader.Value;
                continue;
              case "MustUnderstand":
                if (compatibilityAttributes == null)
                  compatibilityAttributes = new MarkupCompatibilityAttributes();
                compatibilityAttributes.MustUnderstand = (StringValue) xmlReader.Value;
                continue;
              default:
                continue;
            }
          }
        }
        xmlReader.MoveToElement();
      }
      return compatibilityAttributes;
    }

    private bool RemoveMCAttribute(string localName)
    {
      if (this.MCAttributes == null)
        return false;
      if (localName.Equals("Ignorable"))
      {
        this.MCAttributes.Ignorable = (StringValue) null;
        return true;
      }
      if (localName.Equals("ProcessContent"))
      {
        this.MCAttributes.ProcessContent = (StringValue) null;
        return true;
      }
      if (localName.Equals("PreserveElements"))
      {
        this.MCAttributes.PreserveElements = (StringValue) null;
        return true;
      }
      if (localName.Equals("PreserveAttributes"))
      {
        this.MCAttributes.PreserveAttributes = (StringValue) null;
        return true;
      }
      if (!localName.Equals("MustUnderstand"))
        return false;
      this.MCAttributes.MustUnderstand = (StringValue) null;
      return true;
    }

    private void AddMCAttributes(ICollection<OpenXmlAttribute> attributes)
    {
      string prefix = this.LookupPrefix(AlternateContent.MarkupCompatibilityNamespace);
      if (string.IsNullOrEmpty(prefix))
        prefix = MarkupCompatibilityAttributes.MCPrefix;
      if (this.MCAttributes.Ignorable != null)
        attributes.Add(new OpenXmlAttribute(prefix, "Ignorable", AlternateContent.MarkupCompatibilityNamespace, (string) this.MCAttributes.Ignorable));
      if (this.MCAttributes.ProcessContent != null)
        attributes.Add(new OpenXmlAttribute(prefix, "ProcessContent", AlternateContent.MarkupCompatibilityNamespace, (string) this.MCAttributes.ProcessContent));
      if (this.MCAttributes.PreserveElements != null)
        attributes.Add(new OpenXmlAttribute(prefix, "PreserveElements", AlternateContent.MarkupCompatibilityNamespace, (string) this.MCAttributes.PreserveElements));
      if (this.MCAttributes.PreserveAttributes != null)
        attributes.Add(new OpenXmlAttribute(prefix, "PreserveAttributes", AlternateContent.MarkupCompatibilityNamespace, (string) this.MCAttributes.PreserveAttributes));
      if (this.MCAttributes.MustUnderstand == null)
        return;
      attributes.Add(new OpenXmlAttribute(prefix, "MustUnderstand", AlternateContent.MarkupCompatibilityNamespace, (string) this.MCAttributes.MustUnderstand));
    }

    private OpenXmlAttribute GetMCAttribute(string localName)
    {
      if (this.MCAttributes == null)
        throw new KeyNotFoundException(ExceptionMessages.CannotFindAttribute);
      string prefix = this.LookupPrefix(AlternateContent.MarkupCompatibilityNamespace);
      if (string.IsNullOrEmpty(prefix))
        prefix = MarkupCompatibilityAttributes.MCPrefix;
      if (localName.Equals("Ignorable"))
        return new OpenXmlAttribute(prefix, localName, AlternateContent.MarkupCompatibilityNamespace, (string) this.MCAttributes.Ignorable);
      if (localName.Equals("ProcessContent"))
        return new OpenXmlAttribute(prefix, localName, AlternateContent.MarkupCompatibilityNamespace, (string) this.MCAttributes.ProcessContent);
      if (localName.Equals("PreserveElements"))
        return new OpenXmlAttribute(prefix, localName, AlternateContent.MarkupCompatibilityNamespace, (string) this.MCAttributes.PreserveElements);
      if (localName.Equals("PreserveAttributes"))
        return new OpenXmlAttribute(prefix, localName, AlternateContent.MarkupCompatibilityNamespace, (string) this.MCAttributes.PreserveAttributes);
      if (localName.Equals("MustUnderstand"))
        return new OpenXmlAttribute(prefix, localName, AlternateContent.MarkupCompatibilityNamespace, (string) this.MCAttributes.MustUnderstand);
      throw new KeyNotFoundException(ExceptionMessages.CannotFindAttribute);
    }

    private void WriteMCAttribute(XmlWriter xmlWriter)
    {
      if (this.MCAttributes == null)
        return;
      string prefix = xmlWriter.LookupPrefix(AlternateContent.MarkupCompatibilityNamespace);
      if (string.IsNullOrEmpty(prefix))
        prefix = MarkupCompatibilityAttributes.MCPrefix;
      if (this.MCAttributes.Ignorable != null)
        xmlWriter.WriteAttributeString(prefix, "Ignorable", AlternateContent.MarkupCompatibilityNamespace, (string) this.MCAttributes.Ignorable);
      if (this.MCAttributes.ProcessContent != null)
        xmlWriter.WriteAttributeString(prefix, "ProcessContent", AlternateContent.MarkupCompatibilityNamespace, (string) this.MCAttributes.ProcessContent);
      if (this.MCAttributes.PreserveElements != null)
        xmlWriter.WriteAttributeString(prefix, "PreserveElements", AlternateContent.MarkupCompatibilityNamespace, (string) this.MCAttributes.PreserveElements);
      if (this.MCAttributes.PreserveAttributes != null)
        xmlWriter.WriteAttributeString(prefix, "PreserveAttributes", AlternateContent.MarkupCompatibilityNamespace, (string) this.MCAttributes.PreserveAttributes);
      if (this.MCAttributes.MustUnderstand == null)
        return;
      xmlWriter.WriteAttributeString(prefix, "MustUnderstand", AlternateContent.MarkupCompatibilityNamespace, (string) this.MCAttributes.MustUnderstand);
    }

    private int MCAttributeCount()
    {
      if (this.MCAttributes == null)
        return 0;
      int num = 0;
      if (this.MCAttributes.Ignorable != null)
        ++num;
      if (this.MCAttributes.ProcessContent != null)
        ++num;
      if (this.MCAttributes.PreserveElements != null)
        ++num;
      if (this.MCAttributes.PreserveAttributes != null)
        ++num;
      if (this.MCAttributes.MustUnderstand != null)
        ++num;
      return num;
    }

    internal void RemoveAttributesBasedonMC()
    {
      if (this.OpenXmlElementContext == null || this.OpenXmlElementContext.MCSettings.ProcessMode == MarkupCompatibilityProcessMode.NoProcess || !this.OpenXmlElementContext.MCContext.HasIgnorable())
        return;
      if (this.FixedAttributesArray != null)
      {
        int index = 0;
        foreach (OpenXmlSimpleType fixedAttributes in this.FixedAttributesArray)
        {
          if (fixedAttributes != null && this.OpenXmlElementContext.MCContext.GetAttributeAction(NamespaceIdMap.GetNamespaceUri(this.AttributeNamespaceIds[index]), this.AttributeTagNames[index], this.OpenXmlElementContext.MCSettings.TargetFileFormatVersions) == AttributeAction.Ignore)
            this.FixedAttributesArray[index] = (OpenXmlSimpleType) null;
          ++index;
        }
      }
      if (this.ExtendedAttributesField == null)
        return;
      List<OpenXmlAttribute> openXmlAttributeList = new List<OpenXmlAttribute>();
      foreach (OpenXmlAttribute openXmlAttribute in this.ExtendedAttributesField)
      {
        if (this.OpenXmlElementContext.MCContext.GetAttributeAction(openXmlAttribute.NamespaceUri, openXmlAttribute.LocalName, this.OpenXmlElementContext.MCSettings.TargetFileFormatVersions) == AttributeAction.Ignore)
          openXmlAttributeList.Add(openXmlAttribute);
      }
      foreach (OpenXmlAttribute openXmlAttribute in openXmlAttributeList)
        this.ExtendedAttributesField.Remove(openXmlAttribute);
    }

    internal string LookupNamespaceLocal(string prefix)
    {
      if (this.NamespaceDeclField != null)
      {
        for (int index = 0; index < this.NamespaceDeclField.Count; ++index)
        {
          if (this.NamespaceDeclField[index].Key == prefix)
            return this.NamespaceDeclField[index].Value;
        }
      }
      return (string) null;
    }

    internal string LookupPrefixLocal(string uri)
    {
      if (this.NamespaceDeclField != null)
      {
        for (int index = 0; index < this.NamespaceDeclField.Count; ++index)
        {
          if (this.NamespaceDeclField[index].Value == uri)
            return this.NamespaceDeclField[index].Key;
        }
      }
      return (string) null;
    }

    public string LookupNamespace(string prefix)
    {
      if (prefix == null)
        throw new ArgumentNullException(nameof (prefix));
      OpenXmlElement openXmlElement = this;
      for (; openXmlElement != null; openXmlElement = openXmlElement.Parent)
      {
        string str = openXmlElement.LookupNamespaceLocal(prefix);
        if (!string.IsNullOrEmpty(str))
          return str;
      }
      return (string) null;
    }

    public string LookupPrefix(string namespaceUri)
    {
      if (string.IsNullOrEmpty(namespaceUri))
        throw new ArgumentNullException(nameof (namespaceUri));
      OpenXmlElement openXmlElement = this;
      for (; openXmlElement != null; openXmlElement = openXmlElement.Parent)
      {
        string str = openXmlElement.LookupPrefixLocal(namespaceUri);
        if (!string.IsNullOrEmpty(str))
          return str;
      }
      return (string) null;
    }

    internal OpenXmlElement GetNextNonMiscElementSibling()
    {
      OpenXmlElement openXmlElement = this.NextSibling();
      while (openXmlElement != null && openXmlElement is OpenXmlMiscNode)
        openXmlElement = openXmlElement.NextSibling();
      return openXmlElement;
    }

    internal OpenXmlElement GetFirstNonMiscElementChild()
    {
      OpenXmlElement firstChild = this.FirstChild;
      if (firstChild is OpenXmlMiscNode)
        return firstChild.GetNextNonMiscElementSibling();
      return firstChild;
    }

    internal OpenXmlPartRootElement GetPartRootElement()
    {
      OpenXmlElement openXmlElement = this;
      while (openXmlElement.Parent != null)
        openXmlElement = openXmlElement.Parent;
      return openXmlElement as OpenXmlPartRootElement;
    }

    private enum ElementOrder
    {
      Same,
      Before,
      After,
      NotInSameTree,
    }
  }
}

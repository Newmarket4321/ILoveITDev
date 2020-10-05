// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.MCContext
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;

namespace DocumentFormat.OpenXml
{
  internal class MCContext
  {
    private Stack<string> _currentIgnorable;
    private Stack<XmlQualifiedName> _currentPreserveAttr;
    private Stack<XmlQualifiedName> _currentPreserveEle;
    private Stack<XmlQualifiedName> _currentProcessContent;
    private Stack<int> _pushedIgnor;
    private Stack<int> _pushedPA;
    private Stack<int> _pushedPE;
    private Stack<int> _pushedPC;
    private bool _noExceptionOnError;

    internal MCContext()
    {
      this._currentIgnorable = new Stack<string>();
      this._currentPreserveAttr = new Stack<XmlQualifiedName>();
      this._currentPreserveEle = new Stack<XmlQualifiedName>();
      this._currentProcessContent = new Stack<XmlQualifiedName>();
      this._pushedIgnor = new Stack<int>();
      this._pushedPA = new Stack<int>();
      this._pushedPC = new Stack<int>();
      this._pushedPE = new Stack<int>();
    }

    internal MCContext(bool exceptionOnError)
      : this()
    {
      this._noExceptionOnError = !exceptionOnError;
    }

    internal MCContext.LookupNamespace LookupNamespaceDelegate { get; set; }

    internal void PushMCAttributes(MarkupCompatibilityAttributes attr)
    {
      this._pushedIgnor.Push(this.PushIgnorable(attr));
      this._pushedPA.Push(this.PushPreserveAttribute(attr));
      this._pushedPE.Push(this.PushPreserveElement(attr));
      this._pushedPC.Push(this.PushProcessContent(attr));
    }

    internal void PopMCAttributes()
    {
      this.PopIgnorable(this._pushedIgnor.Pop());
      this.PopPreserveAttribute(this._pushedPA.Pop());
      this.PopPreserveElement(this._pushedPE.Pop());
      this.PopProcessContent(this._pushedPC.Pop());
    }

    internal void PushMCAttributes2(MarkupCompatibilityAttributes attr, MCContext.LookupNamespace lookupNamespaceDelegate)
    {
      this.LookupNamespaceDelegate = lookupNamespaceDelegate;
      this._pushedIgnor.Push(this.PushIgnorable(attr));
      this._pushedPC.Push(this.PushProcessContent(attr));
    }

    internal void PopMCAttributes2()
    {
      this.PopIgnorable(this._pushedIgnor.Pop());
      this.PopProcessContent(this._pushedPC.Pop());
    }

    internal IEnumerable<string> ParsePrefixList(string ignorable, MCContext.OnInvalidValue onInvalidPrefix)
    {
      string[] prefixes = ignorable.Trim().Split(' ');
      foreach (string prefix in prefixes)
      {
        string ns = this.LookupNamespaceDelegate(prefix);
        if (string.IsNullOrEmpty(ns))
        {
          if (onInvalidPrefix(ignorable))
            break;
        }
        else
          yield return ns;
      }
    }

    internal IEnumerable<XmlQualifiedName> ParseQNameList(string qnameList, MCContext.OnInvalidValue onInvalidQName)
    {
      string[] qnames = qnameList.Trim().Split(' ');
      foreach (string str in qnames)
      {
        string[] items = str.Split(':');
        if (items.Length != 2)
        {
          if (onInvalidQName(qnameList))
            break;
        }
        else
        {
          string ns = this.LookupNamespaceDelegate(items[0]);
          if (string.IsNullOrEmpty(ns))
          {
            if (onInvalidQName(qnameList))
              break;
          }
          else
            yield return new XmlQualifiedName(items[1], ns);
        }
      }
    }

    internal bool HasIgnorable()
    {
      return this._currentIgnorable.Count > 0;
    }

    internal bool IsIgnorableNs(byte namespaceId)
    {
      return this._currentIgnorable.Count != 0 && this._currentIgnorable.Contains(NamespaceIdMap.GetNamespaceUri(namespaceId));
    }

    internal bool IsIgnorableNs(string ns)
    {
      return this._currentIgnorable.Count != 0 && !string.IsNullOrEmpty(ns) && this._currentIgnorable.Contains(ns);
    }

    internal bool IsPreservedAttribute(string ns, string localName)
    {
      return MCContext.ContainsQName(localName, ns, this._currentPreserveAttr);
    }

    internal bool IsPreservedElement(string ns, string localName)
    {
      return MCContext.ContainsQName(localName, ns, this._currentPreserveEle);
    }

    internal bool IsProcessContent(string ns, string localName)
    {
      return MCContext.ContainsQName(localName, ns, this._currentProcessContent);
    }

    internal bool IsProcessContent(OpenXmlElement element)
    {
      return MCContext.ContainsQName(element.LocalName, element.NamespaceUri, this._currentProcessContent);
    }

    internal AttributeAction GetAttributeAction(string ns, string localName, FileFormatVersions format)
    {
      return format == (FileFormatVersions.Office2007 | FileFormatVersions.Office2010) || format == (FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) || (string.IsNullOrEmpty(ns) || NamespaceIdMap.IsInFileFormat(ns, format)) || (!this.IsIgnorableNs(ns) || this.IsPreservedAttribute(ns, localName)) ? AttributeAction.Normal : AttributeAction.Ignore;
    }

    internal ElementAction GetElementAction(OpenXmlElement element, FileFormatVersions format)
    {
      if (format == (FileFormatVersions.Office2007 | FileFormatVersions.Office2010) || format == (FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013))
        return ElementAction.Normal;
      if (element is AlternateContent)
        return ElementAction.ACBlock;
      if (element.IsInVersion(format) || !this.IsIgnorableNs(element.NamespaceUri) || this.IsPreservedElement(element.NamespaceUri, element.LocalName))
        return ElementAction.Normal;
      return this.IsProcessContent(element.NamespaceUri, element.LocalName) ? ElementAction.ProcessContent : ElementAction.Ignore;
    }

    private static bool ContainsQName(string localName, string ns, Stack<XmlQualifiedName> stack)
    {
      XmlQualifiedName xmlQualifiedName1 = new XmlQualifiedName(localName, ns);
      foreach (XmlQualifiedName xmlQualifiedName2 in stack)
      {
        if (xmlQualifiedName2 == xmlQualifiedName1 || xmlQualifiedName2.Name == "*" && xmlQualifiedName2.Namespace == ns)
          return true;
      }
      return false;
    }

    private bool OnMcContextError(string value)
    {
      if (this._noExceptionOnError)
        return false;
      throw new InvalidMCContentException(string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ExceptionMessages.UnknowMCContent, new object[1]
      {
        (object) value
      }));
    }

    private int PushIgnorable(MarkupCompatibilityAttributes attr)
    {
      int num = 0;
      if (attr != null && attr.Ignorable != null && !string.IsNullOrEmpty(attr.Ignorable.Value))
      {
        foreach (string prefix in this.ParsePrefixList((string) attr.Ignorable, new MCContext.OnInvalidValue(this.OnMcContextError)))
        {
          this._currentIgnorable.Push(prefix);
          ++num;
        }
      }
      return num;
    }

    private int PushQName(Stack<XmlQualifiedName> stack, string value)
    {
      int num = 0;
      foreach (XmlQualifiedName qname in this.ParseQNameList(value, new MCContext.OnInvalidValue(this.OnMcContextError)))
      {
        stack.Push(qname);
        ++num;
      }
      return num;
    }

    private int PushPreserveAttribute(MarkupCompatibilityAttributes attr)
    {
      int num = 0;
      if (attr != null && attr.PreserveAttributes != null && !string.IsNullOrEmpty(attr.PreserveAttributes.Value))
        num = this.PushQName(this._currentPreserveAttr, attr.PreserveAttributes.Value);
      return num;
    }

    private int PushPreserveElement(MarkupCompatibilityAttributes attr)
    {
      int num = 0;
      if (attr != null && attr.PreserveElements != null && !string.IsNullOrEmpty(attr.PreserveElements.Value))
        num = this.PushQName(this._currentPreserveEle, attr.PreserveElements.Value);
      return num;
    }

    private int PushProcessContent(MarkupCompatibilityAttributes attr)
    {
      int num = 0;
      if (attr != null && attr.ProcessContent != null && !string.IsNullOrEmpty(attr.ProcessContent.Value))
        num = this.PushQName(this._currentProcessContent, attr.ProcessContent.Value);
      return num;
    }

    private void PopIgnorable(int count)
    {
      for (int index = 0; index < count; ++index)
        this._currentIgnorable.Pop();
    }

    private void PopPreserveAttribute(int count)
    {
      for (int index = 0; index < count; ++index)
        this._currentPreserveAttr.Pop();
    }

    private void PopPreserveElement(int count)
    {
      for (int index = 0; index < count; ++index)
        this._currentPreserveEle.Pop();
    }

    private void PopProcessContent(int count)
    {
      for (int index = 0; index < count; ++index)
        this._currentProcessContent.Pop();
    }

    internal OpenXmlCompositeElement GetContentFromACBlock(AlternateContent acblk, FileFormatVersions format)
    {
      foreach (AlternateContentChoice alternateContentChoice in acblk.ChildElements.OfType<AlternateContentChoice>())
      {
        if (alternateContentChoice.Requires != null)
        {
          string str1 = alternateContentChoice.Requires.InnerText.Trim();
          if (!string.IsNullOrEmpty(str1))
          {
            bool flag = true;
            string str2 = str1;
            char[] chArray = new char[1]{ ' ' };
            foreach (string prefix in str2.Split(chArray))
            {
              string ns = alternateContentChoice.LookupNamespace(prefix);
              if (ns == null)
              {
                if (this._noExceptionOnError)
                {
                  flag = false;
                  break;
                }
                throw new InvalidMCContentException(string.Format((IFormatProvider) CultureInfo.CurrentUICulture, ExceptionMessages.UnknowMCContent, new object[1]
                {
                  (object) prefix
                }));
              }
              if (!NamespaceIdMap.IsInFileFormat(ns, format))
              {
                flag = false;
                break;
              }
            }
            if (flag)
              return (OpenXmlCompositeElement) alternateContentChoice;
          }
        }
      }
      return (OpenXmlCompositeElement) acblk.GetFirstChild<AlternateContentFallback>() ?? (OpenXmlCompositeElement) null;
    }

    internal delegate string LookupNamespace(string prefix);

    internal delegate bool OnInvalidValue(string value);
  }
}

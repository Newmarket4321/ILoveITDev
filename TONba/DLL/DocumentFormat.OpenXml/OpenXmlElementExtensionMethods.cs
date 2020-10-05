// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.OpenXmlElementExtensionMethods
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml;

namespace DocumentFormat.OpenXml
{
  internal static class OpenXmlElementExtensionMethods
  {
    internal static int GetXPathIndex(this OpenXmlElement element)
    {
      if (element == null)
        throw new ArgumentNullException(nameof (element));
      if (element.Parent == null)
        return 1;
      int num = 1;
      if (element is OpenXmlMiscNode)
        return 1;
      if (element is OpenXmlUnknownElement)
      {
        foreach (OpenXmlElement childElement in element.Parent.ChildElements)
        {
          if (element == childElement)
            return num;
          if (childElement is OpenXmlUnknownElement && childElement.NamespaceUri == element.NamespaceUri && childElement.LocalName == element.LocalName)
            ++num;
        }
      }
      else
      {
        Type type = element.GetType();
        foreach (OpenXmlElement childElement in element.Parent.ChildElements)
        {
          if (element == childElement)
            return num;
          if (type == childElement.GetType())
            ++num;
        }
      }
      return num;
    }

    internal static OpenXmlPart GetPart(this OpenXmlElement element)
    {
      if (element == null)
        throw new ArgumentNullException(nameof (element));
      OpenXmlPartRootElement partRootElement = element.GetPartRootElement();
      if (partRootElement != null && partRootElement.OpenXmlPart != null)
        return partRootElement.OpenXmlPart;
      return (OpenXmlPart) null;
    }

    internal static Uri GetPartUri(this OpenXmlElement element)
    {
      OpenXmlPart part = element.GetPart();
      if (part != null)
        return part.Uri;
      return (Uri) null;
    }

    internal static object CreateInstance(string typeName)
    {
      return (object) Activator.CreateInstance((string) null, typeName);
    }

    internal static string GetAttributeValueEx(this OpenXmlElement element, string localName, string namespaceUri)
    {
      try
      {
        return element.GetAttribute(localName, namespaceUri).Value;
      }
      catch (KeyNotFoundException ex)
      {
        return (string) null;
      }
    }

    internal static XmlQualifiedName GetFixedAttributeQname(this OpenXmlElement element, int attriuteIndex)
    {
      return new XmlQualifiedName(element.AttributeTagNames[attriuteIndex], NamespaceIdMap.GetNamespaceUri(element.AttributeNamespaceIds[attriuteIndex]));
    }

    internal static ICollection<OpenXmlElement> CreateChildrenElementsByIds(this OpenXmlElement parent, IEnumerable<int> elementIds)
    {
      List<OpenXmlElement> openXmlElementList = new List<OpenXmlElement>();
      if (elementIds.Count<int>() > 0)
      {
        foreach (ChildElementInfoAttribute customAttribute in Attribute.GetCustomAttributes((MemberInfo) parent.GetType(), typeof (ChildElementInfoAttribute)))
        {
          OpenXmlElement instance = (OpenXmlElement) Activator.CreateInstance(customAttribute.ElementType);
          foreach (int elementId in elementIds)
          {
            if (instance.ElementTypeId == elementId)
              openXmlElementList.Add(instance);
          }
        }
      }
      return (ICollection<OpenXmlElement>) openXmlElementList;
    }

    internal static bool CanContainsChild(this OpenXmlElement parent, OpenXmlElement child)
    {
      if (parent is OpenXmlCompositeElement)
      {
        foreach (ChildElementInfoAttribute customAttribute in Attribute.GetCustomAttributes((MemberInfo) parent.GetType(), typeof (ChildElementInfoAttribute)))
        {
          if (customAttribute.ElementType.IsInstanceOfType((object) child))
            return true;
        }
      }
      return false;
    }

    internal static OpenXmlElement TryCreateValidChild(this OpenXmlElement parent, FileFormatVersions fileFormat, string namespaceUri, string localName)
    {
      OpenXmlElement openXmlElement = parent.ElementFactory(string.Empty, localName, namespaceUri);
      if (openXmlElement is OpenXmlUnknownElement || !openXmlElement.IsInVersion(fileFormat))
        return (OpenXmlElement) null;
      return openXmlElement;
    }
  }
}

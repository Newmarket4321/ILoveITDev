// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.AlternateContentChoice
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.Collections.Generic;

namespace DocumentFormat.OpenXml
{
  public class AlternateContentChoice : OpenXmlCompositeElement
  {
    private static string tagName = "Choice";
    private static string[] attributeTagNames = new string[1]
    {
      nameof (Requires)
    };
    private static byte[] attributeNamespaceIds = new byte[1];

    public AlternateContentChoice()
    {
    }

    public AlternateContentChoice(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public AlternateContentChoice(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public AlternateContentChoice(string outerXml)
      : base(outerXml)
    {
    }

    public static string TagName
    {
      get
      {
        return AlternateContentChoice.tagName;
      }
    }

    public override string LocalName
    {
      get
      {
        return AlternateContentChoice.tagName;
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return AlternateContent.MarkupCompatibilityNamespaceId;
      }
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return AlternateContentChoice.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return AlternateContentChoice.attributeNamespaceIds;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "Requires" == name)
        return (OpenXmlSimpleType) new StringValue();
      return (OpenXmlSimpleType) null;
    }

    public StringValue Requires
    {
      get
      {
        return (StringValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      OpenXmlElement openXmlElement = (OpenXmlElement) null;
      if (this.Parent != null && this.Parent is AlternateContent)
      {
        OpenXmlElement parent = this.Parent.Parent;
        if (parent != null)
          openXmlElement = parent.ElementFactory(namespaceId, name) ?? parent.AlternateContentElementFactory(namespaceId, name);
      }
      return openXmlElement;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<AlternateContentChoice>(deep);
    }

    internal override int ElementTypeId
    {
      get
      {
        return 9004;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return true;
    }
  }
}

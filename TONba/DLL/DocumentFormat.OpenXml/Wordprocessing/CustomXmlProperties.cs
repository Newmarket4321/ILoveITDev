// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.CustomXmlProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (CustomXmlPlaceholder))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (CustomXmlAttribute))]
  public class CustomXmlProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "placeholder",
      "attr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "customXmlPr";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11839;

    public override string LocalName
    {
      get
      {
        return "customXmlPr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11839;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public CustomXmlProperties()
    {
    }

    public CustomXmlProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public CustomXmlProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public CustomXmlProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "placeholder" == name)
        return (OpenXmlElement) new CustomXmlPlaceholder();
      if (23 == (int) namespaceId && "attr" == name)
        return (OpenXmlElement) new CustomXmlAttribute();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return CustomXmlProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return CustomXmlProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public CustomXmlPlaceholder CustomXmlPlaceholder
    {
      get
      {
        return this.GetElement<CustomXmlPlaceholder>(0);
      }
      set
      {
        this.SetElement<CustomXmlPlaceholder>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<CustomXmlProperties>(deep);
    }
  }
}

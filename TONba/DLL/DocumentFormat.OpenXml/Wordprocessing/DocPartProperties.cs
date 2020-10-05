// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.DocPartProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (DocPartName))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (DocPartTypes))]
  [ChildElementInfo(typeof (DocPartId))]
  [ChildElementInfo(typeof (Category))]
  [ChildElementInfo(typeof (StyleId))]
  [ChildElementInfo(typeof (Behaviors))]
  [ChildElementInfo(typeof (Description))]
  public class DocPartProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[7]
    {
      "name",
      "style",
      "category",
      "types",
      "behaviors",
      "description",
      "guid"
    };
    private static readonly byte[] eleNamespaceIds = new byte[7]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "docPartPr";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11991;

    public override string LocalName
    {
      get
      {
        return "docPartPr";
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
        return 11991;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public DocPartProperties()
    {
    }

    public DocPartProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DocPartProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DocPartProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && nameof (name) == name)
        return (OpenXmlElement) new DocPartName();
      if (23 == (int) namespaceId && "style" == name)
        return (OpenXmlElement) new StyleId();
      if (23 == (int) namespaceId && "category" == name)
        return (OpenXmlElement) new Category();
      if (23 == (int) namespaceId && "types" == name)
        return (OpenXmlElement) new DocPartTypes();
      if (23 == (int) namespaceId && "behaviors" == name)
        return (OpenXmlElement) new Behaviors();
      if (23 == (int) namespaceId && "description" == name)
        return (OpenXmlElement) new Description();
      if (23 == (int) namespaceId && "guid" == name)
        return (OpenXmlElement) new DocPartId();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DocPartProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DocPartProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public DocPartName DocPartName
    {
      get
      {
        return this.GetElement<DocPartName>(0);
      }
      set
      {
        this.SetElement<DocPartName>(0, value);
      }
    }

    public StyleId StyleId
    {
      get
      {
        return this.GetElement<StyleId>(1);
      }
      set
      {
        this.SetElement<StyleId>(1, value);
      }
    }

    public Category Category
    {
      get
      {
        return this.GetElement<Category>(2);
      }
      set
      {
        this.SetElement<Category>(2, value);
      }
    }

    public DocPartTypes DocPartTypes
    {
      get
      {
        return this.GetElement<DocPartTypes>(3);
      }
      set
      {
        this.SetElement<DocPartTypes>(3, value);
      }
    }

    public Behaviors Behaviors
    {
      get
      {
        return this.GetElement<Behaviors>(4);
      }
      set
      {
        this.SetElement<Behaviors>(4, value);
      }
    }

    public Description Description
    {
      get
      {
        return this.GetElement<Description>(5);
      }
      set
      {
        this.SetElement<Description>(5, value);
      }
    }

    public DocPartId DocPartId
    {
      get
      {
        return this.GetElement<DocPartId>(6);
      }
      set
      {
        this.SetElement<DocPartId>(6, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DocPartProperties>(deep);
    }
  }
}

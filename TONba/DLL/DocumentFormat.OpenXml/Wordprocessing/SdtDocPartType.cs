// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.SdtDocPartType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (DocPartGallery))]
  [ChildElementInfo(typeof (DocPartUnique))]
  [ChildElementInfo(typeof (DocPartCategory))]
  public abstract class SdtDocPartType : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[3]
    {
      "docPartGallery",
      "docPartCategory",
      "docPartUnique"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23
    };

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "docPartGallery" == name)
        return (OpenXmlElement) new DocPartGallery();
      if (23 == (int) namespaceId && "docPartCategory" == name)
        return (OpenXmlElement) new DocPartCategory();
      if (23 == (int) namespaceId && "docPartUnique" == name)
        return (OpenXmlElement) new DocPartUnique();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return SdtDocPartType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return SdtDocPartType.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public DocPartGallery DocPartGallery
    {
      get
      {
        return this.GetElement<DocPartGallery>(0);
      }
      set
      {
        this.SetElement<DocPartGallery>(0, value);
      }
    }

    public DocPartCategory DocPartCategory
    {
      get
      {
        return this.GetElement<DocPartCategory>(1);
      }
      set
      {
        this.SetElement<DocPartCategory>(1, value);
      }
    }

    public DocPartUnique DocPartUnique
    {
      get
      {
        return this.GetElement<DocPartUnique>(2);
      }
      set
      {
        this.SetElement<DocPartUnique>(2, value);
      }
    }

    protected SdtDocPartType()
    {
    }

    protected SdtDocPartType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected SdtDocPartType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected SdtDocPartType(string outerXml)
      : base(outerXml)
    {
    }
  }
}

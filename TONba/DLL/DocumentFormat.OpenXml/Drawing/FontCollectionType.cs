// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.FontCollectionType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (LatinFont))]
  [ChildElementInfo(typeof (EastAsianFont))]
  [ChildElementInfo(typeof (ComplexScriptFont))]
  [ChildElementInfo(typeof (SupplementalFont))]
  [ChildElementInfo(typeof (ExtensionList))]
  public abstract class FontCollectionType : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[5]
    {
      "latin",
      "ea",
      "cs",
      "font",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[5]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10
    };

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "latin" == name)
        return (OpenXmlElement) new LatinFont();
      if (10 == (int) namespaceId && "ea" == name)
        return (OpenXmlElement) new EastAsianFont();
      if (10 == (int) namespaceId && "cs" == name)
        return (OpenXmlElement) new ComplexScriptFont();
      if (10 == (int) namespaceId && "font" == name)
        return (OpenXmlElement) new SupplementalFont();
      if (10 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return FontCollectionType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return FontCollectionType.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public LatinFont LatinFont
    {
      get
      {
        return this.GetElement<LatinFont>(0);
      }
      set
      {
        this.SetElement<LatinFont>(0, value);
      }
    }

    public EastAsianFont EastAsianFont
    {
      get
      {
        return this.GetElement<EastAsianFont>(1);
      }
      set
      {
        this.SetElement<EastAsianFont>(1, value);
      }
    }

    public ComplexScriptFont ComplexScriptFont
    {
      get
      {
        return this.GetElement<ComplexScriptFont>(2);
      }
      set
      {
        this.SetElement<ComplexScriptFont>(2, value);
      }
    }

    protected FontCollectionType()
    {
    }

    protected FontCollectionType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected FontCollectionType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected FontCollectionType(string outerXml)
      : base(outerXml)
    {
    }
  }
}

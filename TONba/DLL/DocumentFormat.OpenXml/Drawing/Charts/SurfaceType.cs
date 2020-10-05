// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.SurfaceType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (PictureOptions))]
  [ChildElementInfo(typeof (ShapeProperties))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Thickness))]
  [ChildElementInfo(typeof (ExtensionList))]
  public abstract class SurfaceType : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[4]
    {
      "thickness",
      "spPr",
      "pictureOptions",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 11,
      (byte) 11,
      (byte) 11,
      (byte) 11
    };

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "thickness" == name)
        return (OpenXmlElement) new Thickness();
      if (11 == (int) namespaceId && "spPr" == name)
        return (OpenXmlElement) new ShapeProperties();
      if (11 == (int) namespaceId && "pictureOptions" == name)
        return (OpenXmlElement) new PictureOptions();
      if (11 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return SurfaceType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return SurfaceType.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Thickness Thickness
    {
      get
      {
        return this.GetElement<Thickness>(0);
      }
      set
      {
        this.SetElement<Thickness>(0, value);
      }
    }

    public ShapeProperties ShapeProperties
    {
      get
      {
        return this.GetElement<ShapeProperties>(1);
      }
      set
      {
        this.SetElement<ShapeProperties>(1, value);
      }
    }

    public PictureOptions PictureOptions
    {
      get
      {
        return this.GetElement<PictureOptions>(2);
      }
      set
      {
        this.SetElement<PictureOptions>(2, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(3);
      }
      set
      {
        this.SetElement<ExtensionList>(3, value);
      }
    }

    protected SurfaceType()
    {
    }

    protected SurfaceType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected SurfaceType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected SurfaceType(string outerXml)
      : base(outerXml)
    {
    }
  }
}

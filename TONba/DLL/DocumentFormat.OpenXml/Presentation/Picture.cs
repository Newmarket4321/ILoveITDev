// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.Picture
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (NonVisualPictureProperties))]
  [ChildElementInfo(typeof (ShapeProperties))]
  [ChildElementInfo(typeof (ShapeStyle))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (BlipFill))]
  [ChildElementInfo(typeof (ExtensionListWithModification))]
  public class Picture : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[5]
    {
      "nvPicPr",
      "blipFill",
      "spPr",
      "style",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[5]
    {
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "pic";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12365;

    public override string LocalName
    {
      get
      {
        return "pic";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 24;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12365;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Picture()
    {
    }

    public Picture(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Picture(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Picture(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "nvPicPr" == name)
        return (OpenXmlElement) new NonVisualPictureProperties();
      if (24 == (int) namespaceId && "blipFill" == name)
        return (OpenXmlElement) new BlipFill();
      if (24 == (int) namespaceId && "spPr" == name)
        return (OpenXmlElement) new ShapeProperties();
      if (24 == (int) namespaceId && "style" == name)
        return (OpenXmlElement) new ShapeStyle();
      if (24 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionListWithModification();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Picture.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Picture.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public NonVisualPictureProperties NonVisualPictureProperties
    {
      get
      {
        return this.GetElement<NonVisualPictureProperties>(0);
      }
      set
      {
        this.SetElement<NonVisualPictureProperties>(0, value);
      }
    }

    public BlipFill BlipFill
    {
      get
      {
        return this.GetElement<BlipFill>(1);
      }
      set
      {
        this.SetElement<BlipFill>(1, value);
      }
    }

    public ShapeProperties ShapeProperties
    {
      get
      {
        return this.GetElement<ShapeProperties>(2);
      }
      set
      {
        this.SetElement<ShapeProperties>(2, value);
      }
    }

    public ShapeStyle ShapeStyle
    {
      get
      {
        return this.GetElement<ShapeStyle>(3);
      }
      set
      {
        this.SetElement<ShapeStyle>(3, value);
      }
    }

    public ExtensionListWithModification ExtensionListWithModification
    {
      get
      {
        return this.GetElement<ExtensionListWithModification>(4);
      }
      set
      {
        this.SetElement<ExtensionListWithModification>(4, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Picture>(deep);
    }
  }
}

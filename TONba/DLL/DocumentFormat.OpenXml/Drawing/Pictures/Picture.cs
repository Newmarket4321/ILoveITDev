// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Pictures.Picture
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2010.Drawing.Pictures;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Pictures
{
  [ChildElementInfo(typeof (BlipFill))]
  [ChildElementInfo(typeof (NonVisualPictureProperties))]
  [ChildElementInfo(typeof (ShapeProperties))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.Drawing.Pictures.ShapeStyle), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (OfficeArtExtensionList), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
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
      (byte) 17,
      (byte) 17,
      (byte) 17,
      (byte) 50,
      (byte) 50
    };
    private const string tagName = "pic";
    private const byte tagNsId = 17;
    internal const int ElementTypeIdConst = 10780;

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
        return 17;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10780;
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
      if (17 == (int) namespaceId && "nvPicPr" == name)
        return (OpenXmlElement) new NonVisualPictureProperties();
      if (17 == (int) namespaceId && "blipFill" == name)
        return (OpenXmlElement) new BlipFill();
      if (17 == (int) namespaceId && "spPr" == name)
        return (OpenXmlElement) new ShapeProperties();
      if (50 == (int) namespaceId && "style" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.Drawing.Pictures.ShapeStyle();
      if (50 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new OfficeArtExtensionList();
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

    public DocumentFormat.OpenXml.Office2010.Drawing.Pictures.ShapeStyle ShapeStyle
    {
      get
      {
        return this.GetElement<DocumentFormat.OpenXml.Office2010.Drawing.Pictures.ShapeStyle>(3);
      }
      set
      {
        this.SetElement<DocumentFormat.OpenXml.Office2010.Drawing.Pictures.ShapeStyle>(3, value);
      }
    }

    public OfficeArtExtensionList OfficeArtExtensionList
    {
      get
      {
        return this.GetElement<OfficeArtExtensionList>(4);
      }
      set
      {
        this.SetElement<OfficeArtExtensionList>(4, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Picture>(deep);
    }
  }
}

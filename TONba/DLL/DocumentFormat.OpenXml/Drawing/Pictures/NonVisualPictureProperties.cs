﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Pictures.NonVisualPictureProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Pictures
{
  [ChildElementInfo(typeof (NonVisualPictureDrawingProperties))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (NonVisualDrawingProperties))]
  public class NonVisualPictureProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "cNvPr",
      "cNvPicPr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 17,
      (byte) 17
    };
    private const string tagName = "nvPicPr";
    private const byte tagNsId = 17;
    internal const int ElementTypeIdConst = 10783;

    public override string LocalName
    {
      get
      {
        return "nvPicPr";
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
        return 10783;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public NonVisualPictureProperties()
    {
    }

    public NonVisualPictureProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public NonVisualPictureProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public NonVisualPictureProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (17 == (int) namespaceId && "cNvPr" == name)
        return (OpenXmlElement) new NonVisualDrawingProperties();
      if (17 == (int) namespaceId && "cNvPicPr" == name)
        return (OpenXmlElement) new NonVisualPictureDrawingProperties();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return NonVisualPictureProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return NonVisualPictureProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public NonVisualDrawingProperties NonVisualDrawingProperties
    {
      get
      {
        return this.GetElement<NonVisualDrawingProperties>(0);
      }
      set
      {
        this.SetElement<NonVisualDrawingProperties>(0, value);
      }
    }

    public NonVisualPictureDrawingProperties NonVisualPictureDrawingProperties
    {
      get
      {
        return this.GetElement<NonVisualPictureDrawingProperties>(1);
      }
      set
      {
        this.SetElement<NonVisualPictureDrawingProperties>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<NonVisualPictureProperties>(deep);
    }
  }
}

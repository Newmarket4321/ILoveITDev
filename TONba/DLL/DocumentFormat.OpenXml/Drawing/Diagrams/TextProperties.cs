﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Diagrams.TextProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Diagrams
{
  [ChildElementInfo(typeof (Shape3DType))]
  [ChildElementInfo(typeof (FlatText))]
  [GeneratedCode("DomGen", "2.0")]
  public class TextProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "sp3d",
      "flatTx"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "txPr";
    private const byte tagNsId = 14;
    internal const int ElementTypeIdConst = 10745;

    public override string LocalName
    {
      get
      {
        return "txPr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 14;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10745;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public TextProperties()
    {
    }

    public TextProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TextProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TextProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "sp3d" == name)
        return (OpenXmlElement) new Shape3DType();
      if (10 == (int) namespaceId && "flatTx" == name)
        return (OpenXmlElement) new FlatText();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TextProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TextProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public Shape3DType Shape3DType
    {
      get
      {
        return this.GetElement<Shape3DType>(0);
      }
      set
      {
        this.SetElement<Shape3DType>(0, value);
      }
    }

    public FlatText FlatText
    {
      get
      {
        return this.GetElement<FlatText>(1);
      }
      set
      {
        this.SetElement<FlatText>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TextProperties>(deep);
    }
  }
}

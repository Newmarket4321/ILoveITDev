// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.TextShape
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (TextBody))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (UseShapeRectangle))]
  [ChildElementInfo(typeof (Transform2D))]
  [ChildElementInfo(typeof (ExtensionList))]
  public class TextShape : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[4]
    {
      "txBody",
      "useSpRect",
      "xfrm",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "txSp";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10183;

    public override string LocalName
    {
      get
      {
        return "txSp";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 10;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10183;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public TextShape()
    {
    }

    public TextShape(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TextShape(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TextShape(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "txBody" == name)
        return (OpenXmlElement) new TextBody();
      if (10 == (int) namespaceId && "useSpRect" == name)
        return (OpenXmlElement) new UseShapeRectangle();
      if (10 == (int) namespaceId && "xfrm" == name)
        return (OpenXmlElement) new Transform2D();
      if (10 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TextShape.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TextShape.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public TextBody TextBody
    {
      get
      {
        return this.GetElement<TextBody>(0);
      }
      set
      {
        this.SetElement<TextBody>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TextShape>(deep);
    }
  }
}

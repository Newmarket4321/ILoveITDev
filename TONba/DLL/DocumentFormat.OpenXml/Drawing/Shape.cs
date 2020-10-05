// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Shape
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ShapeProperties))]
  [ChildElementInfo(typeof (NonVisualShapeProperties))]
  [ChildElementInfo(typeof (TextShape))]
  [ChildElementInfo(typeof (ShapeStyle))]
  [ChildElementInfo(typeof (ExtensionList))]
  public class Shape : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[5]
    {
      "nvSpPr",
      "spPr",
      "txSp",
      "style",
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
    private const string tagName = "sp";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10317;

    public override string LocalName
    {
      get
      {
        return "sp";
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
        return 10317;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Shape()
    {
    }

    public Shape(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Shape(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Shape(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "nvSpPr" == name)
        return (OpenXmlElement) new NonVisualShapeProperties();
      if (10 == (int) namespaceId && "spPr" == name)
        return (OpenXmlElement) new ShapeProperties();
      if (10 == (int) namespaceId && "txSp" == name)
        return (OpenXmlElement) new TextShape();
      if (10 == (int) namespaceId && "style" == name)
        return (OpenXmlElement) new ShapeStyle();
      if (10 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Shape.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Shape.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public NonVisualShapeProperties NonVisualShapeProperties
    {
      get
      {
        return this.GetElement<NonVisualShapeProperties>(0);
      }
      set
      {
        this.SetElement<NonVisualShapeProperties>(0, value);
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

    public TextShape TextShape
    {
      get
      {
        return this.GetElement<TextShape>(2);
      }
      set
      {
        this.SetElement<TextShape>(2, value);
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

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(4);
      }
      set
      {
        this.SetElement<ExtensionList>(4, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Shape>(deep);
    }
  }
}

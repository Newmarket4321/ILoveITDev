// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.ConnectionShape
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (NonVisualConnectionShapeProperties))]
  [ChildElementInfo(typeof (ShapeProperties))]
  [ChildElementInfo(typeof (ExtensionListWithModification))]
  [ChildElementInfo(typeof (ShapeStyle))]
  public class ConnectionShape : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[4]
    {
      "nvCxnSpPr",
      "spPr",
      "style",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "cxnSp";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12381;

    public override string LocalName
    {
      get
      {
        return "cxnSp";
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
        return 12381;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public ConnectionShape()
    {
    }

    public ConnectionShape(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ConnectionShape(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ConnectionShape(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "nvCxnSpPr" == name)
        return (OpenXmlElement) new NonVisualConnectionShapeProperties();
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
        return ConnectionShape.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ConnectionShape.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public NonVisualConnectionShapeProperties NonVisualConnectionShapeProperties
    {
      get
      {
        return this.GetElement<NonVisualConnectionShapeProperties>(0);
      }
      set
      {
        this.SetElement<NonVisualConnectionShapeProperties>(0, value);
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

    public ShapeStyle ShapeStyle
    {
      get
      {
        return this.GetElement<ShapeStyle>(2);
      }
      set
      {
        this.SetElement<ShapeStyle>(2, value);
      }
    }

    public ExtensionListWithModification ExtensionListWithModification
    {
      get
      {
        return this.GetElement<ExtensionListWithModification>(3);
      }
      set
      {
        this.SetElement<ExtensionListWithModification>(3, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ConnectionShape>(deep);
    }
  }
}

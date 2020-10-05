// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.GraphicFrame
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (Transform))]
  [ChildElementInfo(typeof (Graphic))]
  [ChildElementInfo(typeof (ExtensionListWithModification))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (NonVisualGraphicFrameProperties))]
  public class GraphicFrame : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[4]
    {
      "nvGraphicFramePr",
      "xfrm",
      "graphic",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 24,
      (byte) 24,
      (byte) 10,
      (byte) 24
    };
    private const string tagName = "graphicFrame";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12380;

    public override string LocalName
    {
      get
      {
        return "graphicFrame";
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
        return 12380;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public GraphicFrame()
    {
    }

    public GraphicFrame(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public GraphicFrame(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public GraphicFrame(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "nvGraphicFramePr" == name)
        return (OpenXmlElement) new NonVisualGraphicFrameProperties();
      if (24 == (int) namespaceId && "xfrm" == name)
        return (OpenXmlElement) new Transform();
      if (10 == (int) namespaceId && "graphic" == name)
        return (OpenXmlElement) new Graphic();
      if (24 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionListWithModification();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return GraphicFrame.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return GraphicFrame.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public NonVisualGraphicFrameProperties NonVisualGraphicFrameProperties
    {
      get
      {
        return this.GetElement<NonVisualGraphicFrameProperties>(0);
      }
      set
      {
        this.SetElement<NonVisualGraphicFrameProperties>(0, value);
      }
    }

    public Transform Transform
    {
      get
      {
        return this.GetElement<Transform>(1);
      }
      set
      {
        this.SetElement<Transform>(1, value);
      }
    }

    public Graphic Graphic
    {
      get
      {
        return this.GetElement<Graphic>(2);
      }
      set
      {
        this.SetElement<Graphic>(2, value);
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
      return (OpenXmlElement) this.CloneImp<GraphicFrame>(deep);
    }
  }
}

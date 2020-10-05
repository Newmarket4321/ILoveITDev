// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.GraphicFrame
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ExtensionList))]
  [ChildElementInfo(typeof (NonVisualGraphicFrameProperties))]
  [ChildElementInfo(typeof (Graphic))]
  [ChildElementInfo(typeof (Transform2D))]
  public class GraphicFrame : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[4]
    {
      "nvGraphicFramePr",
      "graphic",
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
    private const string tagName = "graphicFrame";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10320;

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
        return 10;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10320;
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
      if (10 == (int) namespaceId && "nvGraphicFramePr" == name)
        return (OpenXmlElement) new NonVisualGraphicFrameProperties();
      if (10 == (int) namespaceId && "graphic" == name)
        return (OpenXmlElement) new Graphic();
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

    public Graphic Graphic
    {
      get
      {
        return this.GetElement<Graphic>(1);
      }
      set
      {
        this.SetElement<Graphic>(1, value);
      }
    }

    public Transform2D Transform2D
    {
      get
      {
        return this.GetElement<Transform2D>(2);
      }
      set
      {
        this.SetElement<Transform2D>(2, value);
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

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<GraphicFrame>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameDrawingProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.ChartDrawing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (GraphicFrameLocks))]
  [ChildElementInfo(typeof (ExtensionList))]
  public class NonVisualGraphicFrameDrawingProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "graphicFrameLocks",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "cNvGraphicFramePr";
    private const byte tagNsId = 12;
    internal const int ElementTypeIdConst = 10670;

    public override string LocalName
    {
      get
      {
        return "cNvGraphicFramePr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 12;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10670;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public NonVisualGraphicFrameDrawingProperties()
    {
    }

    public NonVisualGraphicFrameDrawingProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public NonVisualGraphicFrameDrawingProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public NonVisualGraphicFrameDrawingProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "graphicFrameLocks" == name)
        return (OpenXmlElement) new GraphicFrameLocks();
      if (10 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return NonVisualGraphicFrameDrawingProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return NonVisualGraphicFrameDrawingProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public GraphicFrameLocks GraphicFrameLocks
    {
      get
      {
        return this.GetElement<GraphicFrameLocks>(0);
      }
      set
      {
        this.SetElement<GraphicFrameLocks>(0, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(1);
      }
      set
      {
        this.SetElement<ExtensionList>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<NonVisualGraphicFrameDrawingProperties>(deep);
    }
  }
}

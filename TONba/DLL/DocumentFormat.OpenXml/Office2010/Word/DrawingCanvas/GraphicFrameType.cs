// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Word.DrawingCanvas.GraphicFrameType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Word.DrawingCanvas
{
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.Transform2D), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualGraphicFrameProperties), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualDrawingProperties), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Graphic))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.OfficeArtExtensionList), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public class GraphicFrameType : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[5]
    {
      "cNvPr",
      "cNvFrPr",
      "xfrm",
      "graphic",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[5]
    {
      (byte) 60,
      (byte) 60,
      (byte) 60,
      (byte) 10,
      (byte) 60
    };
    private const string tagName = "graphicFrame";
    private const byte tagNsId = 59;
    internal const int ElementTypeIdConst = 13185;

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
        return 59;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13185;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public GraphicFrameType()
    {
    }

    public GraphicFrameType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public GraphicFrameType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public GraphicFrameType(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (60 == (int) namespaceId && "cNvPr" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualDrawingProperties();
      if (60 == (int) namespaceId && "cNvFrPr" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualGraphicFrameProperties();
      if (60 == (int) namespaceId && "xfrm" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.Transform2D();
      if (10 == (int) namespaceId && "graphic" == name)
        return (OpenXmlElement) new Graphic();
      if (60 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.OfficeArtExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return GraphicFrameType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return GraphicFrameType.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualDrawingProperties NonVisualDrawingProperties
    {
      get
      {
        return this.GetElement<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualDrawingProperties>(0);
      }
      set
      {
        this.SetElement<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualDrawingProperties>(0, value);
      }
    }

    public DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualGraphicFrameProperties NonVisualGraphicFrameProperties
    {
      get
      {
        return this.GetElement<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualGraphicFrameProperties>(1);
      }
      set
      {
        this.SetElement<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualGraphicFrameProperties>(1, value);
      }
    }

    public DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.Transform2D Transform2D
    {
      get
      {
        return this.GetElement<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.Transform2D>(2);
      }
      set
      {
        this.SetElement<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.Transform2D>(2, value);
      }
    }

    public Graphic Graphic
    {
      get
      {
        return this.GetElement<Graphic>(3);
      }
      set
      {
        this.SetElement<Graphic>(3, value);
      }
    }

    public DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.OfficeArtExtensionList OfficeArtExtensionList
    {
      get
      {
        return this.GetElement<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.OfficeArtExtensionList>(4);
      }
      set
      {
        this.SetElement<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.OfficeArtExtensionList>(4, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<GraphicFrameType>(deep);
    }
  }
}

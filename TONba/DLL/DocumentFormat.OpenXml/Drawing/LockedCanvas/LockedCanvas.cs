// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.LockedCanvas.LockedCanvas
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2010.Drawing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.LockedCanvas
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (TextShape))]
  [ChildElementInfo(typeof (Picture))]
  [ChildElementInfo(typeof (GvmlContentPart), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (GraphicFrame))]
  [ChildElementInfo(typeof (GroupShape))]
  [ChildElementInfo(typeof (GvmlGroupShapeExtensionList))]
  [ChildElementInfo(typeof (Shape))]
  [ChildElementInfo(typeof (ConnectionShape))]
  [ChildElementInfo(typeof (VisualGroupShapeProperties))]
  [ChildElementInfo(typeof (NonVisualGroupShapeProperties))]
  public class LockedCanvas : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[10]
    {
      "nvGrpSpPr",
      "grpSpPr",
      "txSp",
      "sp",
      "cxnSp",
      "pic",
      "contentPart",
      "graphicFrame",
      "grpSp",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[10]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 48,
      (byte) 10,
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "lockedCanvas";
    private const byte tagNsId = 15;
    internal const int ElementTypeIdConst = 10759;

    public override string LocalName
    {
      get
      {
        return "lockedCanvas";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 15;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10759;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public LockedCanvas()
    {
    }

    public LockedCanvas(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public LockedCanvas(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public LockedCanvas(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "nvGrpSpPr" == name)
        return (OpenXmlElement) new NonVisualGroupShapeProperties();
      if (10 == (int) namespaceId && "grpSpPr" == name)
        return (OpenXmlElement) new VisualGroupShapeProperties();
      if (10 == (int) namespaceId && "txSp" == name)
        return (OpenXmlElement) new TextShape();
      if (10 == (int) namespaceId && "sp" == name)
        return (OpenXmlElement) new Shape();
      if (10 == (int) namespaceId && "cxnSp" == name)
        return (OpenXmlElement) new ConnectionShape();
      if (10 == (int) namespaceId && "pic" == name)
        return (OpenXmlElement) new Picture();
      if (48 == (int) namespaceId && "contentPart" == name)
        return (OpenXmlElement) new GvmlContentPart();
      if (10 == (int) namespaceId && "graphicFrame" == name)
        return (OpenXmlElement) new GraphicFrame();
      if (10 == (int) namespaceId && "grpSp" == name)
        return (OpenXmlElement) new GroupShape();
      if (10 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new GvmlGroupShapeExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DocumentFormat.OpenXml.Drawing.LockedCanvas.LockedCanvas.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DocumentFormat.OpenXml.Drawing.LockedCanvas.LockedCanvas.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public NonVisualGroupShapeProperties NonVisualGroupShapeProperties
    {
      get
      {
        return this.GetElement<NonVisualGroupShapeProperties>(0);
      }
      set
      {
        this.SetElement<NonVisualGroupShapeProperties>(0, value);
      }
    }

    public VisualGroupShapeProperties VisualGroupShapeProperties
    {
      get
      {
        return this.GetElement<VisualGroupShapeProperties>(1);
      }
      set
      {
        this.SetElement<VisualGroupShapeProperties>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DocumentFormat.OpenXml.Drawing.LockedCanvas.LockedCanvas>(deep);
    }
  }
}

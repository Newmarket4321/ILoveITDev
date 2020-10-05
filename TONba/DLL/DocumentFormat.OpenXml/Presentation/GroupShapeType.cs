// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.GroupShapeType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (ConnectionShape))]
  [ChildElementInfo(typeof (ContentPart), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (Shape))]
  [ChildElementInfo(typeof (GroupShape))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (NonVisualGroupShapeProperties))]
  [ChildElementInfo(typeof (GroupShapeProperties))]
  [ChildElementInfo(typeof (GraphicFrame))]
  [ChildElementInfo(typeof (Picture))]
  [ChildElementInfo(typeof (ExtensionListWithModification))]
  public abstract class GroupShapeType : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[9]
    {
      "nvGrpSpPr",
      "grpSpPr",
      "sp",
      "grpSp",
      "graphicFrame",
      "cxnSp",
      "pic",
      "contentPart",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[9]
    {
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24,
      (byte) 24
    };

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "nvGrpSpPr" == name)
        return (OpenXmlElement) new NonVisualGroupShapeProperties();
      if (24 == (int) namespaceId && "grpSpPr" == name)
        return (OpenXmlElement) new GroupShapeProperties();
      if (24 == (int) namespaceId && "sp" == name)
        return (OpenXmlElement) new Shape();
      if (24 == (int) namespaceId && "grpSp" == name)
        return (OpenXmlElement) new GroupShape();
      if (24 == (int) namespaceId && "graphicFrame" == name)
        return (OpenXmlElement) new GraphicFrame();
      if (24 == (int) namespaceId && "cxnSp" == name)
        return (OpenXmlElement) new ConnectionShape();
      if (24 == (int) namespaceId && "pic" == name)
        return (OpenXmlElement) new Picture();
      if (24 == (int) namespaceId && "contentPart" == name)
        return (OpenXmlElement) new ContentPart();
      if (24 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionListWithModification();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return GroupShapeType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return GroupShapeType.eleNamespaceIds;
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

    public GroupShapeProperties GroupShapeProperties
    {
      get
      {
        return this.GetElement<GroupShapeProperties>(1);
      }
      set
      {
        this.SetElement<GroupShapeProperties>(1, value);
      }
    }

    protected GroupShapeType()
    {
    }

    protected GroupShapeType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected GroupShapeType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected GroupShapeType(string outerXml)
      : base(outerXml)
    {
    }
  }
}

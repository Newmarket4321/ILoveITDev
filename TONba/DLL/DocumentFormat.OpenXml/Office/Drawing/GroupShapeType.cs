// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.Drawing.GroupShapeType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office.Drawing
{
  [ChildElementInfo(typeof (OfficeArtExtensionList))]
  [ChildElementInfo(typeof (Shape))]
  [ChildElementInfo(typeof (GroupShapeNonVisualProperties))]
  [ChildElementInfo(typeof (GroupShapeProperties))]
  [ChildElementInfo(typeof (GroupShape))]
  [GeneratedCode("DomGen", "2.0")]
  public abstract class GroupShapeType : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[5]
    {
      "nvGrpSpPr",
      "grpSpPr",
      "sp",
      "grpSp",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[5]
    {
      (byte) 56,
      (byte) 56,
      (byte) 56,
      (byte) 56,
      (byte) 56
    };

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (56 == (int) namespaceId && "nvGrpSpPr" == name)
        return (OpenXmlElement) new GroupShapeNonVisualProperties();
      if (56 == (int) namespaceId && "grpSpPr" == name)
        return (OpenXmlElement) new GroupShapeProperties();
      if (56 == (int) namespaceId && "sp" == name)
        return (OpenXmlElement) new Shape();
      if (56 == (int) namespaceId && "grpSp" == name)
        return (OpenXmlElement) new GroupShape();
      if (56 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new OfficeArtExtensionList();
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

    public GroupShapeNonVisualProperties GroupShapeNonVisualProperties
    {
      get
      {
        return this.GetElement<GroupShapeNonVisualProperties>(0);
      }
      set
      {
        this.SetElement<GroupShapeNonVisualProperties>(0, value);
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

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.ChartDrawing
{
  [ChildElementInfo(typeof (GraphicFrame))]
  [ChildElementInfo(typeof (ConnectionShape))]
  [ChildElementInfo(typeof (NonVisualGroupShapeProperties))]
  [ChildElementInfo(typeof (GroupShapeProperties))]
  [ChildElementInfo(typeof (Shape))]
  [ChildElementInfo(typeof (GroupShape))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Picture))]
  [ChildElementInfo(typeof (ContentPart), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public class GroupShape : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[8]
    {
      "nvGrpSpPr",
      "grpSpPr",
      "sp",
      "grpSp",
      "graphicFrame",
      "cxnSp",
      "pic",
      "contentPart"
    };
    private static readonly byte[] eleNamespaceIds = new byte[8]
    {
      (byte) 12,
      (byte) 12,
      (byte) 12,
      (byte) 12,
      (byte) 12,
      (byte) 12,
      (byte) 12,
      (byte) 47
    };
    private const string tagName = "grpSp";
    private const byte tagNsId = 12;
    internal const int ElementTypeIdConst = 10655;

    public override string LocalName
    {
      get
      {
        return "grpSp";
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
        return 10655;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public GroupShape()
    {
    }

    public GroupShape(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public GroupShape(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public GroupShape(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (12 == (int) namespaceId && "nvGrpSpPr" == name)
        return (OpenXmlElement) new NonVisualGroupShapeProperties();
      if (12 == (int) namespaceId && "grpSpPr" == name)
        return (OpenXmlElement) new GroupShapeProperties();
      if (12 == (int) namespaceId && "sp" == name)
        return (OpenXmlElement) new Shape();
      if (12 == (int) namespaceId && "grpSp" == name)
        return (OpenXmlElement) new GroupShape();
      if (12 == (int) namespaceId && "graphicFrame" == name)
        return (OpenXmlElement) new GraphicFrame();
      if (12 == (int) namespaceId && "cxnSp" == name)
        return (OpenXmlElement) new ConnectionShape();
      if (12 == (int) namespaceId && "pic" == name)
        return (OpenXmlElement) new Picture();
      if (47 == (int) namespaceId && "contentPart" == name)
        return (OpenXmlElement) new ContentPart();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return GroupShape.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return GroupShape.eleNamespaceIds;
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

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<GroupShape>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.WordprocessingGroupType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing.Pictures;
using DocumentFormat.OpenXml.Office2010.Word.DrawingShape;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Word.DrawingGroup
{
  [ChildElementInfo(typeof (GroupShapeProperties), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (NonVisualDrawingProperties), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (NonVisualGroupDrawingShapeProperties), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (WordprocessingShape), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (GroupShape), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (GraphicFrame), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Picture))]
  [ChildElementInfo(typeof (ContentPart), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (OfficeArtExtensionList), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public abstract class WordprocessingGroupType : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[9]
    {
      "cNvPr",
      "cNvGrpSpPr",
      "grpSpPr",
      "wsp",
      "grpSp",
      "graphicFrame",
      "pic",
      "contentPart",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[9]
    {
      (byte) 60,
      (byte) 60,
      (byte) 60,
      (byte) 61,
      (byte) 60,
      (byte) 60,
      (byte) 17,
      (byte) 52,
      (byte) 60
    };

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (60 == (int) namespaceId && "cNvPr" == name)
        return (OpenXmlElement) new NonVisualDrawingProperties();
      if (60 == (int) namespaceId && "cNvGrpSpPr" == name)
        return (OpenXmlElement) new NonVisualGroupDrawingShapeProperties();
      if (60 == (int) namespaceId && "grpSpPr" == name)
        return (OpenXmlElement) new GroupShapeProperties();
      if (61 == (int) namespaceId && "wsp" == name)
        return (OpenXmlElement) new WordprocessingShape();
      if (60 == (int) namespaceId && "grpSp" == name)
        return (OpenXmlElement) new GroupShape();
      if (60 == (int) namespaceId && "graphicFrame" == name)
        return (OpenXmlElement) new GraphicFrame();
      if (17 == (int) namespaceId && "pic" == name)
        return (OpenXmlElement) new Picture();
      if (52 == (int) namespaceId && "contentPart" == name)
        return (OpenXmlElement) new ContentPart();
      if (60 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new OfficeArtExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return WordprocessingGroupType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return WordprocessingGroupType.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public NonVisualDrawingProperties NonVisualDrawingProperties
    {
      get
      {
        return this.GetElement<NonVisualDrawingProperties>(0);
      }
      set
      {
        this.SetElement<NonVisualDrawingProperties>(0, value);
      }
    }

    public NonVisualGroupDrawingShapeProperties NonVisualGroupDrawingShapeProperties
    {
      get
      {
        return this.GetElement<NonVisualGroupDrawingShapeProperties>(1);
      }
      set
      {
        this.SetElement<NonVisualGroupDrawingShapeProperties>(1, value);
      }
    }

    public GroupShapeProperties GroupShapeProperties
    {
      get
      {
        return this.GetElement<GroupShapeProperties>(2);
      }
      set
      {
        this.SetElement<GroupShapeProperties>(2, value);
      }
    }

    protected WordprocessingGroupType()
    {
    }

    protected WordprocessingGroupType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected WordprocessingGroupType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected WordprocessingGroupType(string outerXml)
      : base(outerXml)
    {
    }
  }
}

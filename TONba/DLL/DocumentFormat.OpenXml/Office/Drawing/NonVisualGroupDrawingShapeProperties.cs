// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.Drawing.NonVisualGroupDrawingShapeProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (NonVisualGroupDrawingShapePropsExtensionList))]
  [ChildElementInfo(typeof (GroupShapeLocks))]
  public class NonVisualGroupDrawingShapeProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "grpSpLocks",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "cNvGrpSpPr";
    private const byte tagNsId = 56;
    internal const int ElementTypeIdConst = 13093;

    public override string LocalName
    {
      get
      {
        return "cNvGrpSpPr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 56;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13093;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public NonVisualGroupDrawingShapeProperties()
    {
    }

    public NonVisualGroupDrawingShapeProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public NonVisualGroupDrawingShapeProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public NonVisualGroupDrawingShapeProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "grpSpLocks" == name)
        return (OpenXmlElement) new GroupShapeLocks();
      if (10 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new NonVisualGroupDrawingShapePropsExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return NonVisualGroupDrawingShapeProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return NonVisualGroupDrawingShapeProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public GroupShapeLocks GroupShapeLocks
    {
      get
      {
        return this.GetElement<GroupShapeLocks>(0);
      }
      set
      {
        this.SetElement<GroupShapeLocks>(0, value);
      }
    }

    public NonVisualGroupDrawingShapePropsExtensionList NonVisualGroupDrawingShapePropsExtensionList
    {
      get
      {
        return this.GetElement<NonVisualGroupDrawingShapePropsExtensionList>(1);
      }
      set
      {
        this.SetElement<NonVisualGroupDrawingShapePropsExtensionList>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<NonVisualGroupDrawingShapeProperties>(deep);
    }
  }
}

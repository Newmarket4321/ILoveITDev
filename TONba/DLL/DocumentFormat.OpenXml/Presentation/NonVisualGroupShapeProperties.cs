// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.NonVisualGroupShapeProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ApplicationNonVisualDrawingProperties))]
  [ChildElementInfo(typeof (NonVisualDrawingProperties))]
  [ChildElementInfo(typeof (NonVisualGroupShapeDrawingProperties))]
  public class NonVisualGroupShapeProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[3]
    {
      "cNvPr",
      "cNvGrpSpPr",
      "nvPr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 24,
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "nvGrpSpPr";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12376;

    public override string LocalName
    {
      get
      {
        return "nvGrpSpPr";
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
        return 12376;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public NonVisualGroupShapeProperties()
    {
    }

    public NonVisualGroupShapeProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public NonVisualGroupShapeProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public NonVisualGroupShapeProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "cNvPr" == name)
        return (OpenXmlElement) new NonVisualDrawingProperties();
      if (24 == (int) namespaceId && "cNvGrpSpPr" == name)
        return (OpenXmlElement) new NonVisualGroupShapeDrawingProperties();
      if (24 == (int) namespaceId && "nvPr" == name)
        return (OpenXmlElement) new ApplicationNonVisualDrawingProperties();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return NonVisualGroupShapeProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return NonVisualGroupShapeProperties.eleNamespaceIds;
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

    public NonVisualGroupShapeDrawingProperties NonVisualGroupShapeDrawingProperties
    {
      get
      {
        return this.GetElement<NonVisualGroupShapeDrawingProperties>(1);
      }
      set
      {
        this.SetElement<NonVisualGroupShapeDrawingProperties>(1, value);
      }
    }

    public ApplicationNonVisualDrawingProperties ApplicationNonVisualDrawingProperties
    {
      get
      {
        return this.GetElement<ApplicationNonVisualDrawingProperties>(2);
      }
      set
      {
        this.SetElement<ApplicationNonVisualDrawingProperties>(2, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<NonVisualGroupShapeProperties>(deep);
    }
  }
}

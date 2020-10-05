// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.NonVisualGroupShapeProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (NonVisualDrawingProperties))]
  [ChildElementInfo(typeof (NonVisualGroupShapeDrawingProperties))]
  [GeneratedCode("DomGen", "2.0")]
  public class NonVisualGroupShapeProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "cNvPr",
      "cNvGrpSpPr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "nvGrpSpPr";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10315;

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
        return 10;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10315;
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
      if (10 == (int) namespaceId && "cNvPr" == name)
        return (OpenXmlElement) new NonVisualDrawingProperties();
      if (10 == (int) namespaceId && "cNvGrpSpPr" == name)
        return (OpenXmlElement) new NonVisualGroupShapeDrawingProperties();
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

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<NonVisualGroupShapeProperties>(deep);
    }
  }
}

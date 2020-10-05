// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.ChartDrawing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (NonVisualDrawingProperties))]
  [ChildElementInfo(typeof (NonVisualShapeDrawingProperties))]
  public class NonVisualShapeProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "cNvPr",
      "cNvSpPr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 12,
      (byte) 12
    };
    private const string tagName = "nvSpPr";
    private const byte tagNsId = 12;
    internal const int ElementTypeIdConst = 10661;

    public override string LocalName
    {
      get
      {
        return "nvSpPr";
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
        return 10661;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public NonVisualShapeProperties()
    {
    }

    public NonVisualShapeProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public NonVisualShapeProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public NonVisualShapeProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (12 == (int) namespaceId && "cNvPr" == name)
        return (OpenXmlElement) new NonVisualDrawingProperties();
      if (12 == (int) namespaceId && "cNvSpPr" == name)
        return (OpenXmlElement) new NonVisualShapeDrawingProperties();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return NonVisualShapeProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return NonVisualShapeProperties.eleNamespaceIds;
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

    public NonVisualShapeDrawingProperties NonVisualShapeDrawingProperties
    {
      get
      {
        return this.GetElement<NonVisualShapeDrawingProperties>(1);
      }
      set
      {
        this.SetElement<NonVisualShapeDrawingProperties>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<NonVisualShapeProperties>(deep);
    }
  }
}

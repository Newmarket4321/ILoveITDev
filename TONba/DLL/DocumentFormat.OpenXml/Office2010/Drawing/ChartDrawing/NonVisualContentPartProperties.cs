// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualContentPartProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing
{
  [ChildElementInfo(typeof (NonVisualDrawingProperties), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (NonVisualInkContentPartProperties), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public class NonVisualContentPartProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "cNvPr",
      "cNvContentPartPr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 47,
      (byte) 47
    };
    private const string tagName = "nvContentPartPr";
    private const byte tagNsId = 47;
    internal const int ElementTypeIdConst = 12777;

    public override string LocalName
    {
      get
      {
        return "nvContentPartPr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 47;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12777;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public NonVisualContentPartProperties()
    {
    }

    public NonVisualContentPartProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public NonVisualContentPartProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public NonVisualContentPartProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (47 == (int) namespaceId && "cNvPr" == name)
        return (OpenXmlElement) new NonVisualDrawingProperties();
      if (47 == (int) namespaceId && "cNvContentPartPr" == name)
        return (OpenXmlElement) new NonVisualInkContentPartProperties();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return NonVisualContentPartProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return NonVisualContentPartProperties.eleNamespaceIds;
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

    public NonVisualInkContentPartProperties NonVisualInkContentPartProperties
    {
      get
      {
        return this.GetElement<NonVisualInkContentPartProperties>(1);
      }
      set
      {
        this.SetElement<NonVisualInkContentPartProperties>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<NonVisualContentPartProperties>(deep);
    }
  }
}

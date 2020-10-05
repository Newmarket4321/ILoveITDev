// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.PowerPoint.NonVisualContentPartProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.PowerPoint
{
  [ChildElementInfo(typeof (NonVisualInkContentPartProperties), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (NonVisualDrawingProperties), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (ApplicationNonVisualDrawingProperties), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public class NonVisualContentPartProperties : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[3]
    {
      "cNvPr",
      "cNvContentPartPr",
      "nvPr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 49,
      (byte) 49,
      (byte) 49
    };
    private const string tagName = "nvContentPartPr";
    private const byte tagNsId = 49;
    internal const int ElementTypeIdConst = 12831;

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
        return 49;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12831;
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
      if (49 == (int) namespaceId && "cNvPr" == name)
        return (OpenXmlElement) new NonVisualDrawingProperties();
      if (49 == (int) namespaceId && "cNvContentPartPr" == name)
        return (OpenXmlElement) new NonVisualInkContentPartProperties();
      if (49 == (int) namespaceId && "nvPr" == name)
        return (OpenXmlElement) new ApplicationNonVisualDrawingProperties();
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
      return (OpenXmlElement) this.CloneImp<NonVisualContentPartProperties>(deep);
    }
  }
}

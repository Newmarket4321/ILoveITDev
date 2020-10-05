// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.BuildSubElement
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Drawing.BuildDiagram))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (BuildChart))]
  public class BuildSubElement : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "bldDgm",
      "bldChart"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "bldSub";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12293;

    public override string LocalName
    {
      get
      {
        return "bldSub";
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
        return 12293;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public BuildSubElement()
    {
    }

    public BuildSubElement(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public BuildSubElement(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public BuildSubElement(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "bldDgm" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Drawing.BuildDiagram();
      if (10 == (int) namespaceId && "bldChart" == name)
        return (OpenXmlElement) new BuildChart();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return BuildSubElement.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return BuildSubElement.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public DocumentFormat.OpenXml.Drawing.BuildDiagram BuildDiagram
    {
      get
      {
        return this.GetElement<DocumentFormat.OpenXml.Drawing.BuildDiagram>(0);
      }
      set
      {
        this.SetElement<DocumentFormat.OpenXml.Drawing.BuildDiagram>(0, value);
      }
    }

    public BuildChart BuildChart
    {
      get
      {
        return this.GetElement<BuildChart>(1);
      }
      set
      {
        this.SetElement<BuildChart>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<BuildSubElement>(deep);
    }
  }
}

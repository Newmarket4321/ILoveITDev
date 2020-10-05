// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.BuildList
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (BuildDiagram))]
  [ChildElementInfo(typeof (BuildParagraph))]
  [ChildElementInfo(typeof (BuildGraphics))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (BuildOleChart))]
  public class BuildList : OpenXmlCompositeElement
  {
    private const string tagName = "bldLst";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12298;

    public override string LocalName
    {
      get
      {
        return "bldLst";
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
        return 12298;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public BuildList()
    {
    }

    public BuildList(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public BuildList(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public BuildList(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "bldP" == name)
        return (OpenXmlElement) new BuildParagraph();
      if (24 == (int) namespaceId && "bldDgm" == name)
        return (OpenXmlElement) new BuildDiagram();
      if (24 == (int) namespaceId && "bldOleChart" == name)
        return (OpenXmlElement) new BuildOleChart();
      if (24 == (int) namespaceId && "bldGraphic" == name)
        return (OpenXmlElement) new BuildGraphics();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<BuildList>(deep);
    }
  }
}

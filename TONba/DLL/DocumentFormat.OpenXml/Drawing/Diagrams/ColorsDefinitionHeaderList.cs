// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinitionHeaderList
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Diagrams
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ColorsDefinitionHeader))]
  public class ColorsDefinitionHeaderList : OpenXmlCompositeElement
  {
    private const string tagName = "colorsDefHdrLst";
    private const byte tagNsId = 14;
    internal const int ElementTypeIdConst = 10684;

    public override string LocalName
    {
      get
      {
        return "colorsDefHdrLst";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 14;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10684;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public ColorsDefinitionHeaderList()
    {
    }

    public ColorsDefinitionHeaderList(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ColorsDefinitionHeaderList(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ColorsDefinitionHeaderList(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (14 == (int) namespaceId && "colorsDefHdr" == name)
        return (OpenXmlElement) new ColorsDefinitionHeader();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ColorsDefinitionHeaderList>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinitionHeaderList
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Diagrams
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (LayoutDefinitionHeader))]
  public class LayoutDefinitionHeaderList : OpenXmlCompositeElement
  {
    private const string tagName = "layoutDefHdrLst";
    private const byte tagNsId = 14;
    internal const int ElementTypeIdConst = 10688;

    public override string LocalName
    {
      get
      {
        return "layoutDefHdrLst";
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
        return 10688;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public LayoutDefinitionHeaderList()
    {
    }

    public LayoutDefinitionHeaderList(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public LayoutDefinitionHeaderList(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public LayoutDefinitionHeaderList(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (14 == (int) namespaceId && "layoutDefHdr" == name)
        return (OpenXmlElement) new LayoutDefinitionHeader();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<LayoutDefinitionHeaderList>(deep);
    }
  }
}

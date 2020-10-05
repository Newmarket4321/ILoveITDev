// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.DocParts
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (DocPart))]
  [GeneratedCode("DomGen", "2.0")]
  public class DocParts : OpenXmlCompositeElement
  {
    private const string tagName = "docParts";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11983;

    public override string LocalName
    {
      get
      {
        return "docParts";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11983;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public DocParts()
    {
    }

    public DocParts(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DocParts(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DocParts(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "docPart" == name)
        return (OpenXmlElement) new DocPart();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DocParts>(deep);
    }
  }
}

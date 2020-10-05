// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.PowerPoint.SectionSlideIdList
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.PowerPoint
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (SectionSlideIdListEntry), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public class SectionSlideIdList : OpenXmlCompositeElement
  {
    private const string tagName = "sldIdLst";
    private const byte tagNsId = 49;
    internal const int ElementTypeIdConst = 12876;

    public override string LocalName
    {
      get
      {
        return "sldIdLst";
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
        return 12876;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public SectionSlideIdList()
    {
    }

    public SectionSlideIdList(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SectionSlideIdList(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SectionSlideIdList(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (49 == (int) namespaceId && "sldId" == name)
        return (OpenXmlElement) new SectionSlideIdListEntry();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SectionSlideIdList>(deep);
    }
  }
}

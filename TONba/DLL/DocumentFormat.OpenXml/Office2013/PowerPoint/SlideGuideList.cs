// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.PowerPoint.SlideGuideList
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.PowerPoint
{
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class SlideGuideList : ExtendedGuideList
  {
    private const string tagName = "sldGuideLst";
    private const byte tagNsId = 68;
    internal const int ElementTypeIdConst = 13328;

    public override string LocalName
    {
      get
      {
        return "sldGuideLst";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 68;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13328;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public SlideGuideList()
    {
    }

    public SlideGuideList(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SlideGuideList(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SlideGuideList(string outerXml)
      : base(outerXml)
    {
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SlideGuideList>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Excel.TimelineCacheReferences
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Excel
{
  [ChildElementInfo(typeof (TimelineCacheReference), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class TimelineCacheReferences : OpenXmlCompositeElement
  {
    private const string tagName = "timelineCacheRefs";
    private const byte tagNsId = 71;
    internal const int ElementTypeIdConst = 13362;

    public override string LocalName
    {
      get
      {
        return "timelineCacheRefs";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 71;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13362;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public TimelineCacheReferences()
    {
    }

    public TimelineCacheReferences(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TimelineCacheReferences(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TimelineCacheReferences(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (71 == (int) namespaceId && "timelineCacheRef" == name)
        return (OpenXmlElement) new TimelineCacheReference();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TimelineCacheReferences>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.SlicerCaches
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (SlicerCache), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public class SlicerCaches : OpenXmlCompositeElement
  {
    private const string tagName = "slicerCaches";
    private const byte tagNsId = 53;
    internal const int ElementTypeIdConst = 12970;

    public override string LocalName
    {
      get
      {
        return "slicerCaches";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 53;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12970;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public SlicerCaches()
    {
    }

    public SlicerCaches(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SlicerCaches(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SlicerCaches(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (53 == (int) namespaceId && "slicerCache" == name)
        return (OpenXmlElement) new SlicerCache();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SlicerCaches>(deep);
    }
  }
}

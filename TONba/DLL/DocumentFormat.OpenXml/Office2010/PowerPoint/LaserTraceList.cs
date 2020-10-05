// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.PowerPoint.LaserTraceList
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.PowerPoint
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (TracePointList), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class LaserTraceList : OpenXmlCompositeElement
  {
    private const string tagName = "laserTraceLst";
    private const byte tagNsId = 49;
    internal const int ElementTypeIdConst = 12862;

    public override string LocalName
    {
      get
      {
        return "laserTraceLst";
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
        return 12862;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public LaserTraceList()
    {
    }

    public LaserTraceList(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public LaserTraceList(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public LaserTraceList(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (49 == (int) namespaceId && "tracePtLst" == name)
        return (OpenXmlElement) new TracePointList();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<LaserTraceList>(deep);
    }
  }
}

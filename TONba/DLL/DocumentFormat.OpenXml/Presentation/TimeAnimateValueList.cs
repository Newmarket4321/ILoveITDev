// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.TimeAnimateValueList
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (TimeAnimateValue))]
  [GeneratedCode("DomGen", "2.0")]
  public class TimeAnimateValueList : OpenXmlCompositeElement
  {
    private const string tagName = "tavLst";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12403;

    public override string LocalName
    {
      get
      {
        return "tavLst";
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
        return 12403;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public TimeAnimateValueList()
    {
    }

    public TimeAnimateValueList(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TimeAnimateValueList(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TimeAnimateValueList(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "tav" == name)
        return (OpenXmlElement) new TimeAnimateValue();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TimeAnimateValueList>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.GuideList
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (Guide))]
  [GeneratedCode("DomGen", "2.0")]
  public class GuideList : OpenXmlCompositeElement
  {
    private const string tagName = "guideLst";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12353;

    public override string LocalName
    {
      get
      {
        return "guideLst";
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
        return 12353;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public GuideList()
    {
    }

    public GuideList(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public GuideList(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public GuideList(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "guide" == name)
        return (OpenXmlElement) new Guide();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<GuideList>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Diagrams.AdjustList
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Diagrams
{
  [ChildElementInfo(typeof (Adjust))]
  [GeneratedCode("DomGen", "2.0")]
  public class AdjustList : OpenXmlCompositeElement
  {
    private const string tagName = "adjLst";
    private const byte tagNsId = 14;
    internal const int ElementTypeIdConst = 10710;

    public override string LocalName
    {
      get
      {
        return "adjLst";
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
        return 10710;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public AdjustList()
    {
    }

    public AdjustList(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public AdjustList(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public AdjustList(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (14 == (int) namespaceId && "adj" == name)
        return (OpenXmlElement) new Adjust();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<AdjustList>(deep);
    }
  }
}

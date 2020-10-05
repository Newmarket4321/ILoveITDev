// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.FillStyleList
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (GradientFill))]
  [ChildElementInfo(typeof (GroupFill))]
  [ChildElementInfo(typeof (SolidFill))]
  [ChildElementInfo(typeof (NoFill))]
  [ChildElementInfo(typeof (BlipFill))]
  [ChildElementInfo(typeof (PatternFill))]
  public class FillStyleList : OpenXmlCompositeElement
  {
    private const string tagName = "fillStyleLst";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10140;

    public override string LocalName
    {
      get
      {
        return "fillStyleLst";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 10;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10140;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public FillStyleList()
    {
    }

    public FillStyleList(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public FillStyleList(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public FillStyleList(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "noFill" == name)
        return (OpenXmlElement) new NoFill();
      if (10 == (int) namespaceId && "solidFill" == name)
        return (OpenXmlElement) new SolidFill();
      if (10 == (int) namespaceId && "gradFill" == name)
        return (OpenXmlElement) new GradientFill();
      if (10 == (int) namespaceId && "blipFill" == name)
        return (OpenXmlElement) new BlipFill();
      if (10 == (int) namespaceId && "pattFill" == name)
        return (OpenXmlElement) new PatternFill();
      if (10 == (int) namespaceId && "grpFill" == name)
        return (OpenXmlElement) new GroupFill();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<FillStyleList>(deep);
    }
  }
}

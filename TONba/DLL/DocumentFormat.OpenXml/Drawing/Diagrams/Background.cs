// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Diagrams.Background
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Diagrams
{
  [ChildElementInfo(typeof (GradientFill))]
  [ChildElementInfo(typeof (PatternFill))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (SolidFill))]
  [ChildElementInfo(typeof (BlipFill))]
  [ChildElementInfo(typeof (NoFill))]
  [ChildElementInfo(typeof (GroupFill))]
  [ChildElementInfo(typeof (EffectList))]
  [ChildElementInfo(typeof (EffectDag))]
  public class Background : OpenXmlCompositeElement
  {
    private const string tagName = "bg";
    private const byte tagNsId = 14;
    internal const int ElementTypeIdConst = 10752;

    public override string LocalName
    {
      get
      {
        return "bg";
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
        return 10752;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Background()
    {
    }

    public Background(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Background(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Background(string outerXml)
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
      if (10 == (int) namespaceId && "effectLst" == name)
        return (OpenXmlElement) new EffectList();
      if (10 == (int) namespaceId && "effectDag" == name)
        return (OpenXmlElement) new EffectDag();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Background>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.EffectStyle
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (EffectDag))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Shape3DType))]
  [ChildElementInfo(typeof (Scene3DType))]
  [ChildElementInfo(typeof (EffectList))]
  public class EffectStyle : OpenXmlCompositeElement
  {
    private const string tagName = "effectStyle";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10139;

    public override string LocalName
    {
      get
      {
        return "effectStyle";
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
        return 10139;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public EffectStyle()
    {
    }

    public EffectStyle(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public EffectStyle(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public EffectStyle(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "effectLst" == name)
        return (OpenXmlElement) new EffectList();
      if (10 == (int) namespaceId && "effectDag" == name)
        return (OpenXmlElement) new EffectDag();
      if (10 == (int) namespaceId && "scene3d" == name)
        return (OpenXmlElement) new Scene3DType();
      if (10 == (int) namespaceId && "sp3d" == name)
        return (OpenXmlElement) new Shape3DType();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<EffectStyle>(deep);
    }
  }
}

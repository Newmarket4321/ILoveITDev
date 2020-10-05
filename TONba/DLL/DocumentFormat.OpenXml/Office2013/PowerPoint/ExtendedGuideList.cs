// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.PowerPoint.ExtendedGuideList
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.PowerPoint
{
  [ChildElementInfo(typeof (ExtendedGuide), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ExtensionList), FileFormatVersions.Office2013)]
  public abstract class ExtendedGuideList : OpenXmlCompositeElement
  {
    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (68 == (int) namespaceId && "guide" == name)
        return (OpenXmlElement) new ExtendedGuide();
      if (68 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    protected ExtendedGuideList()
    {
    }

    protected ExtendedGuideList(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected ExtendedGuideList(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected ExtendedGuideList(string outerXml)
      : base(outerXml)
    {
    }
  }
}

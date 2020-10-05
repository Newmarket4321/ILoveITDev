// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.GeometryGuideListType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ShapeGuide))]
  public abstract class GeometryGuideListType : OpenXmlCompositeElement
  {
    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "gd" == name)
        return (OpenXmlElement) new ShapeGuide();
      return (OpenXmlElement) null;
    }

    protected GeometryGuideListType()
    {
    }

    protected GeometryGuideListType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected GeometryGuideListType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected GeometryGuideListType(string outerXml)
      : base(outerXml)
    {
    }
  }
}

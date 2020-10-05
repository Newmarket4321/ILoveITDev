// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.ShapeDefaultsType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Vml.Office;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (ShapeLayout))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Vml.Office.ShapeDefaults))]
  [GeneratedCode("DomGen", "2.0")]
  public abstract class ShapeDefaultsType : OpenXmlCompositeElement
  {
    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (27 == (int) namespaceId && "shapedefaults" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Vml.Office.ShapeDefaults();
      if (27 == (int) namespaceId && "shapelayout" == name)
        return (OpenXmlElement) new ShapeLayout();
      return (OpenXmlElement) null;
    }

    protected ShapeDefaultsType()
    {
    }

    protected ShapeDefaultsType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected ShapeDefaultsType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected ShapeDefaultsType(string outerXml)
      : base(outerXml)
    {
    }
  }
}

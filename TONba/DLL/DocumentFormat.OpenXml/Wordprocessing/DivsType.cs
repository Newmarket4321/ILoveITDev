// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.DivsType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (Div))]
  [GeneratedCode("DomGen", "2.0")]
  public abstract class DivsType : OpenXmlCompositeElement
  {
    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "div" == name)
        return (OpenXmlElement) new Div();
      return (OpenXmlElement) null;
    }

    protected DivsType()
    {
    }

    protected DivsType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected DivsType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected DivsType(string outerXml)
      : base(outerXml)
    {
    }
  }
}

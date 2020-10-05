// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.TimeListTimeConditionalListType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Condition))]
  public abstract class TimeListTimeConditionalListType : OpenXmlCompositeElement
  {
    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "cond" == name)
        return (OpenXmlElement) new Condition();
      return (OpenXmlElement) null;
    }

    protected TimeListTimeConditionalListType()
    {
    }

    protected TimeListTimeConditionalListType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected TimeListTimeConditionalListType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected TimeListTimeConditionalListType(string outerXml)
      : base(outerXml)
    {
    }
  }
}

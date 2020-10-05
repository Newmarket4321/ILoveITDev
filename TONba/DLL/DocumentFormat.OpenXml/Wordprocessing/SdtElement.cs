// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.SdtElement
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  public abstract class SdtElement : OpenXmlCompositeElement
  {
    protected SdtElement(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected SdtElement(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected SdtElement(string outerXml)
      : base(outerXml)
    {
    }

    public SdtProperties SdtProperties
    {
      get
      {
        return this.GetElement<SdtProperties>(0);
      }
      set
      {
        this.SetElement<SdtProperties>(0, value);
      }
    }

    public SdtEndCharProperties SdtEndCharProperties
    {
      get
      {
        return this.GetElement<SdtEndCharProperties>(1);
      }
      set
      {
        this.SetElement<SdtEndCharProperties>(1, value);
      }
    }
  }
}

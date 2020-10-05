// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.OpenXmlChildElements
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml
{
  internal class OpenXmlChildElements : OpenXmlElementList
  {
    private OpenXmlElement _container;

    public OpenXmlChildElements(OpenXmlElement container)
    {
      this._container = container;
    }

    public override IEnumerator<OpenXmlElement> GetEnumerator()
    {
      if (this._container.HasChildren && this._container.FirstChild != null)
      {
        for (OpenXmlElement element = this._container.FirstChild; element != null; element = element.NextSibling())
          yield return element;
      }
    }

    public override OpenXmlElement GetItem(int index)
    {
      if (this._container.HasChildren)
      {
        for (OpenXmlElement openXmlElement = this._container.FirstChild; openXmlElement != null; openXmlElement = openXmlElement.NextSibling())
        {
          if (index == 0)
            return openXmlElement;
          --index;
        }
      }
      throw new ArgumentOutOfRangeException(nameof (index));
    }

    public override int Count
    {
      get
      {
        int num = 0;
        if (this._container.HasChildren)
        {
          for (OpenXmlElement openXmlElement = this._container.FirstChild; openXmlElement != null; openXmlElement = openXmlElement.NextSibling())
            ++num;
        }
        return num;
      }
    }
  }
}

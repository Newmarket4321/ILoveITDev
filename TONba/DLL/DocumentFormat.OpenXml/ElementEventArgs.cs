// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.ElementEventArgs
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;

namespace DocumentFormat.OpenXml
{
  public class ElementEventArgs : EventArgs
  {
    private OpenXmlElement _element;
    private OpenXmlElement _parentElement;

    public ElementEventArgs(OpenXmlElement element, OpenXmlElement parentElement)
    {
      this._element = element;
      this._parentElement = parentElement;
    }

    public OpenXmlElement Element
    {
      get
      {
        return this._element;
      }
    }

    public OpenXmlElement ParentElement
    {
      get
      {
        return this._parentElement;
      }
    }
  }
}

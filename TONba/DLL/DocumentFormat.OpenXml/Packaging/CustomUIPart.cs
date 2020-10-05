// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.CustomUIPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Packaging
{
  public abstract class CustomUIPart : OpenXmlPart
  {
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private DocumentFormat.OpenXml.Office.CustomUI.CustomUI _rootEle;

    internal override OpenXmlPartRootElement _rootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this._rootEle;
      }
      set
      {
        this._rootEle = value as DocumentFormat.OpenXml.Office.CustomUI.CustomUI;
      }
    }

    internal override OpenXmlPartRootElement PartRootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this.CustomUI;
      }
    }

    public DocumentFormat.OpenXml.Office.CustomUI.CustomUI CustomUI
    {
      get
      {
        if (this._rootEle == null)
          this.LoadDomTree<DocumentFormat.OpenXml.Office.CustomUI.CustomUI>();
        return this._rootEle;
      }
      set
      {
        if (value == null)
          throw new ArgumentNullException(nameof (value));
        this.SetDomTree((OpenXmlPartRootElement) value);
      }
    }
  }
}

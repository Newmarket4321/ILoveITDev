// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Packaging.StylesPart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Packaging
{
  public abstract class StylesPart : OpenXmlPart
  {
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private Styles _rootEle;

    internal override OpenXmlPartRootElement _rootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this._rootEle;
      }
      set
      {
        this._rootEle = value as Styles;
      }
    }

    internal override OpenXmlPartRootElement PartRootElement
    {
      get
      {
        return (OpenXmlPartRootElement) this.Styles;
      }
    }

    public Styles Styles
    {
      get
      {
        if (this._rootEle == null)
          this.LoadDomTree<Styles>();
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

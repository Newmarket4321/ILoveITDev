﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.CustomUI.Tabs
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office.CustomUI
{
  [ChildElementInfo(typeof (Tab))]
  [GeneratedCode("DomGen", "2.0")]
  public class Tabs : OpenXmlCompositeElement
  {
    private const string tagName = "tabs";
    private const byte tagNsId = 34;
    internal const int ElementTypeIdConst = 12684;

    public override string LocalName
    {
      get
      {
        return "tabs";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 34;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12684;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Tabs()
    {
    }

    public Tabs(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Tabs(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Tabs(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (34 == (int) namespaceId && "tab" == name)
        return (OpenXmlElement) new Tab();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Tabs>(deep);
    }
  }
}

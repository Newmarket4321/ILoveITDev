﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.Word.Mcds
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office.Word
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Mcd))]
  public class Mcds : OpenXmlCompositeElement
  {
    private const string tagName = "mcds";
    private const byte tagNsId = 33;
    internal const int ElementTypeIdConst = 12609;

    public override string LocalName
    {
      get
      {
        return "mcds";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 33;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12609;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Mcds()
    {
    }

    public Mcds(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Mcds(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Mcds(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (33 == (int) namespaceId && "mcd" == name)
        return (OpenXmlElement) new Mcd();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Mcds>(deep);
    }
  }
}

﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Bibliography.Editor
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Bibliography
{
  [GeneratedCode("DomGen", "2.0")]
  public class Editor : NameType
  {
    private const string tagName = "Editor";
    private const byte tagNsId = 9;
    internal const int ElementTypeIdConst = 10839;

    public override string LocalName
    {
      get
      {
        return nameof (Editor);
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 9;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10839;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Editor()
    {
    }

    public Editor(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Editor(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Editor(string outerXml)
      : base(outerXml)
    {
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Editor>(deep);
    }
  }
}

﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.PathList
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Path))]
  public class PathList : OpenXmlCompositeElement
  {
    private const string tagName = "pathLst";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10231;

    public override string LocalName
    {
      get
      {
        return "pathLst";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 10;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10231;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public PathList()
    {
    }

    public PathList(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PathList(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PathList(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "path" == name)
        return (OpenXmlElement) new Path();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PathList>(deep);
    }
  }
}

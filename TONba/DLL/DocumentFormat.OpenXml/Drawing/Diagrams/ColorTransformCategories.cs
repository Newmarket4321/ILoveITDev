﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategories
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Diagrams
{
  [ChildElementInfo(typeof (ColorTransformCategory))]
  [GeneratedCode("DomGen", "2.0")]
  public class ColorTransformCategories : OpenXmlCompositeElement
  {
    private const string tagName = "catLst";
    private const byte tagNsId = 14;
    internal const int ElementTypeIdConst = 10703;

    public override string LocalName
    {
      get
      {
        return "catLst";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 14;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10703;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public ColorTransformCategories()
    {
    }

    public ColorTransformCategories(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ColorTransformCategories(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ColorTransformCategories(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (14 == (int) namespaceId && "cat" == name)
        return (OpenXmlElement) new ColorTransformCategory();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ColorTransformCategories>(deep);
    }
  }
}

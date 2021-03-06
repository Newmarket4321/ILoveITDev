﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.SdtEndCharProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (RunProperties))]
  [GeneratedCode("DomGen", "2.0")]
  public class SdtEndCharProperties : OpenXmlCompositeElement
  {
    private const string tagName = "sdtEndPr";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11833;

    public override string LocalName
    {
      get
      {
        return "sdtEndPr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11833;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public SdtEndCharProperties()
    {
    }

    public SdtEndCharProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SdtEndCharProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SdtEndCharProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "rPr" == name)
        return (OpenXmlElement) new RunProperties();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SdtEndCharProperties>(deep);
    }
  }
}

﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifest
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office.Word
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (AllocatedCommandManifestEntry))]
  public class AllocatedCommandManifest : OpenXmlCompositeElement
  {
    private const string tagName = "acdManifest";
    private const byte tagNsId = 33;
    internal const int ElementTypeIdConst = 12635;

    public override string LocalName
    {
      get
      {
        return "acdManifest";
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
        return 12635;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public AllocatedCommandManifest()
    {
    }

    public AllocatedCommandManifest(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public AllocatedCommandManifest(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public AllocatedCommandManifest(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (33 == (int) namespaceId && "acdEntry" == name)
        return (OpenXmlElement) new AllocatedCommandManifestEntry();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<AllocatedCommandManifest>(deep);
    }
  }
}

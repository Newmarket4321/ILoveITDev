﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Charts.SerAxExtensionList
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
  [ChildElementInfo(typeof (SerAxExtension))]
  [GeneratedCode("DomGen", "2.0")]
  public class SerAxExtensionList : OpenXmlCompositeElement
  {
    private const string tagName = "extLst";
    private const byte tagNsId = 11;
    internal const int ElementTypeIdConst = 10635;

    public override string LocalName
    {
      get
      {
        return "extLst";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 11;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10635;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public SerAxExtensionList()
    {
    }

    public SerAxExtensionList(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SerAxExtensionList(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SerAxExtensionList(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (11 == (int) namespaceId && "ext" == name)
        return (OpenXmlElement) new SerAxExtension();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SerAxExtensionList>(deep);
    }
  }
}

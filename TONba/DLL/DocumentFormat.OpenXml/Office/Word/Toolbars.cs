// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.Word.Toolbars
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office.Word
{
  [ChildElementInfo(typeof (AllocatedCommandManifest))]
  [ChildElementInfo(typeof (ToolbarData))]
  [GeneratedCode("DomGen", "2.0")]
  public class Toolbars : OpenXmlCompositeElement
  {
    private const string tagName = "toolbars";
    private const byte tagNsId = 33;
    internal const int ElementTypeIdConst = 12639;

    public override string LocalName
    {
      get
      {
        return "toolbars";
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
        return 12639;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Toolbars()
    {
    }

    public Toolbars(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Toolbars(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Toolbars(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (33 == (int) namespaceId && "acdManifest" == name)
        return (OpenXmlElement) new AllocatedCommandManifest();
      if (33 == (int) namespaceId && "toolbarData" == name)
        return (OpenXmlElement) new ToolbarData();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Toolbars>(deep);
    }
  }
}

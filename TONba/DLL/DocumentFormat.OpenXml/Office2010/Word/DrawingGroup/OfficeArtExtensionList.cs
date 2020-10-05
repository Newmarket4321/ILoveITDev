// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.OfficeArtExtensionList
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Word.DrawingGroup
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Extension))]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class OfficeArtExtensionList : OpenXmlCompositeElement
  {
    private const string tagName = "extLst";
    private const byte tagNsId = 60;
    internal const int ElementTypeIdConst = 13191;

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
        return 60;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13191;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public OfficeArtExtensionList()
    {
    }

    public OfficeArtExtensionList(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public OfficeArtExtensionList(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public OfficeArtExtensionList(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "ext" == name)
        return (OpenXmlElement) new Extension();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<OfficeArtExtensionList>(deep);
    }
  }
}

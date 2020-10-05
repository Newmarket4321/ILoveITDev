// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Theme.ThemeVariantList
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Theme
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ThemeVariant), FileFormatVersions.Office2013)]
  public class ThemeVariantList : OpenXmlCompositeElement
  {
    private const string tagName = "themeVariantLst";
    private const byte tagNsId = 73;
    internal const int ElementTypeIdConst = 13435;

    public override string LocalName
    {
      get
      {
        return "themeVariantLst";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 73;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13435;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public ThemeVariantList()
    {
    }

    public ThemeVariantList(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ThemeVariantList(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ThemeVariantList(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (73 == (int) namespaceId && "themeVariant" == name)
        return (OpenXmlElement) new ThemeVariant();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ThemeVariantList>(deep);
    }
  }
}

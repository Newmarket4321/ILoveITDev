// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.ExtraColorSchemeList
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (ExtraColorScheme))]
  [GeneratedCode("DomGen", "2.0")]
  public class ExtraColorSchemeList : OpenXmlCompositeElement
  {
    private const string tagName = "extraClrSchemeLst";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10338;

    public override string LocalName
    {
      get
      {
        return "extraClrSchemeLst";
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
        return 10338;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public ExtraColorSchemeList()
    {
    }

    public ExtraColorSchemeList(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ExtraColorSchemeList(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ExtraColorSchemeList(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "extraClrScheme" == name)
        return (OpenXmlElement) new ExtraColorScheme();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ExtraColorSchemeList>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.Hyperlinks
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (Hyperlink))]
  [GeneratedCode("DomGen", "2.0")]
  public class Hyperlinks : OpenXmlCompositeElement
  {
    private const string tagName = "hyperlinks";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11499;

    public override string LocalName
    {
      get
      {
        return "hyperlinks";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 22;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11499;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Hyperlinks()
    {
    }

    public Hyperlinks(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Hyperlinks(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Hyperlinks(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "hyperlink" == name)
        return (OpenXmlElement) new Hyperlink();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Hyperlinks>(deep);
    }
  }
}

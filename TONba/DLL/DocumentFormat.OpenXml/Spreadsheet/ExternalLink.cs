// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.ExternalLink
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (ExternalBook))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (DdeLink))]
  [ChildElementInfo(typeof (OleLink))]
  [ChildElementInfo(typeof (ExtensionList))]
  public class ExternalLink : OpenXmlPartRootElement
  {
    private const string tagName = "externalLink";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11111;

    public override string LocalName
    {
      get
      {
        return "externalLink";
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
        return 11111;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal ExternalLink(ExternalWorkbookPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(ExternalWorkbookPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public ExternalWorkbookPart ExternalWorkbookPart
    {
      get
      {
        return this.OpenXmlPart as ExternalWorkbookPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public ExternalLink(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ExternalLink(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ExternalLink(string outerXml)
      : base(outerXml)
    {
    }

    public ExternalLink()
    {
    }

    public void Save(ExternalWorkbookPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "externalBook" == name)
        return (OpenXmlElement) new ExternalBook();
      if (22 == (int) namespaceId && "ddeLink" == name)
        return (OpenXmlElement) new DdeLink();
      if (22 == (int) namespaceId && "oleLink" == name)
        return (OpenXmlElement) new OleLink();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ExternalLink>(deep);
    }
  }
}

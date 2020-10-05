// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionReferenceList
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.WebExtension
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (WebExtensionStoreReference), FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class WebExtensionReferenceList : OpenXmlCompositeElement
  {
    private const string tagName = "alternateReferences";
    private const byte tagNsId = 66;
    internal const int ElementTypeIdConst = 13317;

    public override string LocalName
    {
      get
      {
        return "alternateReferences";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 66;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13317;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public WebExtensionReferenceList()
    {
    }

    public WebExtensionReferenceList(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public WebExtensionReferenceList(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public WebExtensionReferenceList(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (66 == (int) namespaceId && "reference" == name)
        return (OpenXmlElement) new WebExtensionStoreReference();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<WebExtensionReferenceList>(deep);
    }
  }
}

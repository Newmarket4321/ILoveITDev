// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBindingList
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.WebExtension
{
  [ChildElementInfo(typeof (WebExtensionBinding), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class WebExtensionBindingList : OpenXmlCompositeElement
  {
    private const string tagName = "bindings";
    private const byte tagNsId = 66;
    internal const int ElementTypeIdConst = 13319;

    public override string LocalName
    {
      get
      {
        return "bindings";
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
        return 13319;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public WebExtensionBindingList()
    {
    }

    public WebExtensionBindingList(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public WebExtensionBindingList(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public WebExtensionBindingList(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (66 == (int) namespaceId && "binding" == name)
        return (OpenXmlElement) new WebExtensionBinding();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<WebExtensionBindingList>(deep);
    }
  }
}

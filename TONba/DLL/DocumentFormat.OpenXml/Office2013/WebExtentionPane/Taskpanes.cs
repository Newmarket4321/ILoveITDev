// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.WebExtentionPane.Taskpanes
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.WebExtentionPane
{
  [ChildElementInfo(typeof (WebExtensionTaskpane), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class Taskpanes : OpenXmlPartRootElement
  {
    private const string tagName = "taskpanes";
    private const byte tagNsId = 70;
    internal const int ElementTypeIdConst = 13353;

    public override string LocalName
    {
      get
      {
        return "taskpanes";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 70;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13353;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    internal Taskpanes(WebExTaskpanesPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(WebExTaskpanesPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public WebExTaskpanesPart WebExTaskpanesPart
    {
      get
      {
        return this.OpenXmlPart as WebExTaskpanesPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public Taskpanes(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Taskpanes(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Taskpanes(string outerXml)
      : base(outerXml)
    {
    }

    public Taskpanes()
    {
    }

    public void Save(WebExTaskpanesPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (70 == (int) namespaceId && "taskpane" == name)
        return (OpenXmlElement) new WebExtensionTaskpane();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Taskpanes>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.CustomUI.SimpleGroups
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.CustomUI
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (BackstageGroup), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (TaskGroup), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public class SimpleGroups : OpenXmlCompositeElement
  {
    private const string tagName = "secondColumn";
    private const byte tagNsId = 57;
    internal const int ElementTypeIdConst = 13173;

    public override string LocalName
    {
      get
      {
        return "secondColumn";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 57;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13173;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public SimpleGroups()
    {
    }

    public SimpleGroups(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SimpleGroups(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SimpleGroups(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (57 == (int) namespaceId && "group" == name)
        return (OpenXmlElement) new BackstageGroup();
      if (57 == (int) namespaceId && "taskGroup" == name)
        return (OpenXmlElement) new TaskGroup();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SimpleGroups>(deep);
    }
  }
}

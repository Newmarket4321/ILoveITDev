// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Bibliography.NameList
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Bibliography
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Person))]
  public class NameList : OpenXmlCompositeElement
  {
    private const string tagName = "NameList";
    private const byte tagNsId = 9;
    internal const int ElementTypeIdConst = 10829;

    public override string LocalName
    {
      get
      {
        return nameof (NameList);
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 9;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10829;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public NameList()
    {
    }

    public NameList(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public NameList(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public NameList(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (9 == (int) namespaceId && "Person" == name)
        return (OpenXmlElement) new Person();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<NameList>(deep);
    }
  }
}

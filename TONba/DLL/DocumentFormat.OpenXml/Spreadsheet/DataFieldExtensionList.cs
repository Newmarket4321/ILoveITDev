// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.DataFieldExtensionList
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (DataFieldExtension))]
  public class DataFieldExtensionList : OpenXmlCompositeElement
  {
    private const string tagName = "extLst";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11489;

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
        return 22;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11489;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public DataFieldExtensionList()
    {
    }

    public DataFieldExtensionList(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DataFieldExtensionList(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DataFieldExtensionList(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "ext" == name)
        return (OpenXmlElement) new DataFieldExtension();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DataFieldExtensionList>(deep);
    }
  }
}

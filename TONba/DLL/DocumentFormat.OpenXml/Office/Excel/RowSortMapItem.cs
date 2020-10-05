// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.Excel.RowSortMapItem
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office.Excel
{
  [GeneratedCode("DomGen", "2.0")]
  public class RowSortMapItem : SortMapItemType
  {
    private const string tagName = "row";
    private const byte tagNsId = 32;
    internal const int ElementTypeIdConst = 12606;

    public override string LocalName
    {
      get
      {
        return "row";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 32;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12606;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<RowSortMapItem>(deep);
    }
  }
}

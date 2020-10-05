// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.Excel.ColumnSortMapItem
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office.Excel
{
  [GeneratedCode("DomGen", "2.0")]
  public class ColumnSortMapItem : SortMapItemType
  {
    private const string tagName = "col";
    private const byte tagNsId = 32;
    internal const int ElementTypeIdConst = 12607;

    public override string LocalName
    {
      get
      {
        return "col";
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
        return 12607;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ColumnSortMapItem>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.TableRowProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2010.Word;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (TableCellSpacing))]
  [ChildElementInfo(typeof (CantSplit))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (DivId))]
  [ChildElementInfo(typeof (GridBefore))]
  [ChildElementInfo(typeof (GridAfter))]
  [ChildElementInfo(typeof (WidthBeforeTableRow))]
  [ChildElementInfo(typeof (WidthAfterTableRow))]
  [ChildElementInfo(typeof (TableRowHeight))]
  [ChildElementInfo(typeof (Hidden))]
  [ChildElementInfo(typeof (ConditionalFormatStyle))]
  [ChildElementInfo(typeof (TableHeader))]
  [ChildElementInfo(typeof (TableJustification))]
  [ChildElementInfo(typeof (Inserted))]
  [ChildElementInfo(typeof (Deleted))]
  [ChildElementInfo(typeof (TableRowPropertiesChange))]
  [ChildElementInfo(typeof (ConflictInsertion), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ConflictDeletion), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public class TableRowProperties : OpenXmlCompositeElement
  {
    private const string tagName = "trPr";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 12071;

    public override string LocalName
    {
      get
      {
        return "trPr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12071;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public TableRowProperties()
    {
    }

    public TableRowProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TableRowProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TableRowProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "cnfStyle" == name)
        return (OpenXmlElement) new ConditionalFormatStyle();
      if (23 == (int) namespaceId && "divId" == name)
        return (OpenXmlElement) new DivId();
      if (23 == (int) namespaceId && "gridBefore" == name)
        return (OpenXmlElement) new GridBefore();
      if (23 == (int) namespaceId && "gridAfter" == name)
        return (OpenXmlElement) new GridAfter();
      if (23 == (int) namespaceId && "wBefore" == name)
        return (OpenXmlElement) new WidthBeforeTableRow();
      if (23 == (int) namespaceId && "wAfter" == name)
        return (OpenXmlElement) new WidthAfterTableRow();
      if (23 == (int) namespaceId && "trHeight" == name)
        return (OpenXmlElement) new TableRowHeight();
      if (23 == (int) namespaceId && "hidden" == name)
        return (OpenXmlElement) new Hidden();
      if (23 == (int) namespaceId && "cantSplit" == name)
        return (OpenXmlElement) new CantSplit();
      if (23 == (int) namespaceId && "tblHeader" == name)
        return (OpenXmlElement) new TableHeader();
      if (23 == (int) namespaceId && "tblCellSpacing" == name)
        return (OpenXmlElement) new TableCellSpacing();
      if (23 == (int) namespaceId && "jc" == name)
        return (OpenXmlElement) new TableJustification();
      if (23 == (int) namespaceId && "ins" == name)
        return (OpenXmlElement) new Inserted();
      if (23 == (int) namespaceId && "del" == name)
        return (OpenXmlElement) new Deleted();
      if (23 == (int) namespaceId && "trPrChange" == name)
        return (OpenXmlElement) new TableRowPropertiesChange();
      if (52 == (int) namespaceId && "conflictIns" == name)
        return (OpenXmlElement) new ConflictInsertion();
      if (52 == (int) namespaceId && "conflictDel" == name)
        return (OpenXmlElement) new ConflictDeletion();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TableRowProperties>(deep);
    }
  }
}

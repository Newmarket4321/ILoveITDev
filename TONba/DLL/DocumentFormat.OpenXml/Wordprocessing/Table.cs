// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.Table
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office2010.Word;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (CustomXmlConflictInsertionRangeStart), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (BookmarkStart))]
  [ChildElementInfo(typeof (BookmarkEnd))]
  [ChildElementInfo(typeof (CommentRangeStart))]
  [ChildElementInfo(typeof (CommentRangeEnd))]
  [ChildElementInfo(typeof (MoveFromRangeStart))]
  [ChildElementInfo(typeof (MoveFromRangeEnd))]
  [ChildElementInfo(typeof (MoveToRangeStart))]
  [ChildElementInfo(typeof (MoveToRangeEnd))]
  [ChildElementInfo(typeof (CustomXmlInsRangeStart))]
  [ChildElementInfo(typeof (CustomXmlInsRangeEnd))]
  [ChildElementInfo(typeof (CustomXmlDelRangeStart))]
  [ChildElementInfo(typeof (CustomXmlDelRangeEnd))]
  [ChildElementInfo(typeof (CustomXmlMoveFromRangeStart))]
  [ChildElementInfo(typeof (CustomXmlMoveFromRangeEnd))]
  [ChildElementInfo(typeof (CustomXmlMoveToRangeStart))]
  [ChildElementInfo(typeof (CustomXmlMoveToRangeEnd))]
  [ChildElementInfo(typeof (ProofError))]
  [ChildElementInfo(typeof (RunConflictDeletion), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (CustomXmlConflictDeletionRangeStart), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (CustomXmlConflictDeletionRangeEnd), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (TableProperties))]
  [ChildElementInfo(typeof (TableGrid))]
  [ChildElementInfo(typeof (TableRow))]
  [ChildElementInfo(typeof (CustomXmlRow))]
  [ChildElementInfo(typeof (SdtRow))]
  [ChildElementInfo(typeof (CustomXmlConflictInsertionRangeEnd), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (PermStart))]
  [ChildElementInfo(typeof (PermEnd))]
  [ChildElementInfo(typeof (InsertedRun))]
  [ChildElementInfo(typeof (DeletedRun))]
  [ChildElementInfo(typeof (MoveFromRun))]
  [ChildElementInfo(typeof (MoveToRun))]
  [ChildElementInfo(typeof (ContentPart), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (RunConflictInsertion), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public class Table : OpenXmlCompositeElement
  {
    private const string tagName = "tbl";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11682;

    public override string LocalName
    {
      get
      {
        return "tbl";
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
        return 11682;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public Table()
    {
    }

    public Table(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Table(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Table(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "bookmarkStart" == name)
        return (OpenXmlElement) new BookmarkStart();
      if (23 == (int) namespaceId && "bookmarkEnd" == name)
        return (OpenXmlElement) new BookmarkEnd();
      if (23 == (int) namespaceId && "commentRangeStart" == name)
        return (OpenXmlElement) new CommentRangeStart();
      if (23 == (int) namespaceId && "commentRangeEnd" == name)
        return (OpenXmlElement) new CommentRangeEnd();
      if (23 == (int) namespaceId && "moveFromRangeStart" == name)
        return (OpenXmlElement) new MoveFromRangeStart();
      if (23 == (int) namespaceId && "moveFromRangeEnd" == name)
        return (OpenXmlElement) new MoveFromRangeEnd();
      if (23 == (int) namespaceId && "moveToRangeStart" == name)
        return (OpenXmlElement) new MoveToRangeStart();
      if (23 == (int) namespaceId && "moveToRangeEnd" == name)
        return (OpenXmlElement) new MoveToRangeEnd();
      if (23 == (int) namespaceId && "customXmlInsRangeStart" == name)
        return (OpenXmlElement) new CustomXmlInsRangeStart();
      if (23 == (int) namespaceId && "customXmlInsRangeEnd" == name)
        return (OpenXmlElement) new CustomXmlInsRangeEnd();
      if (23 == (int) namespaceId && "customXmlDelRangeStart" == name)
        return (OpenXmlElement) new CustomXmlDelRangeStart();
      if (23 == (int) namespaceId && "customXmlDelRangeEnd" == name)
        return (OpenXmlElement) new CustomXmlDelRangeEnd();
      if (23 == (int) namespaceId && "customXmlMoveFromRangeStart" == name)
        return (OpenXmlElement) new CustomXmlMoveFromRangeStart();
      if (23 == (int) namespaceId && "customXmlMoveFromRangeEnd" == name)
        return (OpenXmlElement) new CustomXmlMoveFromRangeEnd();
      if (23 == (int) namespaceId && "customXmlMoveToRangeStart" == name)
        return (OpenXmlElement) new CustomXmlMoveToRangeStart();
      if (23 == (int) namespaceId && "customXmlMoveToRangeEnd" == name)
        return (OpenXmlElement) new CustomXmlMoveToRangeEnd();
      if (52 == (int) namespaceId && "customXmlConflictInsRangeStart" == name)
        return (OpenXmlElement) new CustomXmlConflictInsertionRangeStart();
      if (52 == (int) namespaceId && "customXmlConflictInsRangeEnd" == name)
        return (OpenXmlElement) new CustomXmlConflictInsertionRangeEnd();
      if (52 == (int) namespaceId && "customXmlConflictDelRangeStart" == name)
        return (OpenXmlElement) new CustomXmlConflictDeletionRangeStart();
      if (52 == (int) namespaceId && "customXmlConflictDelRangeEnd" == name)
        return (OpenXmlElement) new CustomXmlConflictDeletionRangeEnd();
      if (23 == (int) namespaceId && "tblPr" == name)
        return (OpenXmlElement) new TableProperties();
      if (23 == (int) namespaceId && "tblGrid" == name)
        return (OpenXmlElement) new TableGrid();
      if (23 == (int) namespaceId && "tr" == name)
        return (OpenXmlElement) new TableRow();
      if (23 == (int) namespaceId && "customXml" == name)
        return (OpenXmlElement) new CustomXmlRow();
      if (23 == (int) namespaceId && "sdt" == name)
        return (OpenXmlElement) new SdtRow();
      if (23 == (int) namespaceId && "proofErr" == name)
        return (OpenXmlElement) new ProofError();
      if (23 == (int) namespaceId && "permStart" == name)
        return (OpenXmlElement) new PermStart();
      if (23 == (int) namespaceId && "permEnd" == name)
        return (OpenXmlElement) new PermEnd();
      if (23 == (int) namespaceId && "ins" == name)
        return (OpenXmlElement) new InsertedRun();
      if (23 == (int) namespaceId && "del" == name)
        return (OpenXmlElement) new DeletedRun();
      if (23 == (int) namespaceId && "moveFrom" == name)
        return (OpenXmlElement) new MoveFromRun();
      if (23 == (int) namespaceId && "moveTo" == name)
        return (OpenXmlElement) new MoveToRun();
      if (23 == (int) namespaceId && "contentPart" == name)
        return (OpenXmlElement) new ContentPart();
      if (52 == (int) namespaceId && "conflictIns" == name)
        return (OpenXmlElement) new RunConflictInsertion();
      if (52 == (int) namespaceId && "conflictDel" == name)
        return (OpenXmlElement) new RunConflictDeletion();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Table>(deep);
    }
  }
}

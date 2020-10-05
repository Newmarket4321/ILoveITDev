// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Word.RunTrackChangeType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Wordprocessing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Word
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (EquationArray))]
  [ChildElementInfo(typeof (Delimiter))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Math.Paragraph))]
  [ChildElementInfo(typeof (RunConflictDeletion), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (PermStart))]
  [ChildElementInfo(typeof (PermEnd))]
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
  [ChildElementInfo(typeof (CustomXmlConflictInsertionRangeStart), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (CustomXmlConflictInsertionRangeEnd), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (CustomXmlConflictDeletionRangeStart), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (CustomXmlConflictDeletionRangeEnd), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (InsertedRun))]
  [ChildElementInfo(typeof (DeletedRun))]
  [ChildElementInfo(typeof (MoveFromRun))]
  [ChildElementInfo(typeof (MoveToRun))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Wordprocessing.ContentPart), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (RunConflictInsertion), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Phantom))]
  [ChildElementInfo(typeof (Nary))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Math.OfficeMath))]
  [ChildElementInfo(typeof (Accent))]
  [ChildElementInfo(typeof (Bar))]
  [ChildElementInfo(typeof (Box))]
  [ChildElementInfo(typeof (BorderBox))]
  [ChildElementInfo(typeof (SdtRun))]
  [ChildElementInfo(typeof (Fraction))]
  [ChildElementInfo(typeof (MathFunction))]
  [ChildElementInfo(typeof (GroupChar))]
  [ChildElementInfo(typeof (LimitLower))]
  [ChildElementInfo(typeof (LimitUpper))]
  [ChildElementInfo(typeof (Matrix))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Math.Run))]
  [ChildElementInfo(typeof (ProofError))]
  [ChildElementInfo(typeof (Superscript))]
  [ChildElementInfo(typeof (PreSubSuper))]
  [ChildElementInfo(typeof (Subscript))]
  [ChildElementInfo(typeof (SubSuperscript))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Wordprocessing.Run))]
  [ChildElementInfo(typeof (Radical))]
  [ChildElementInfo(typeof (BidirectionalOverride), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (BidirectionalEmbedding), FileFormatVersions.Office2010)]
  public abstract class RunTrackChangeType : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "author",
      "date",
      "id"
    };
    private static byte[] attributeNamespaceIds = new byte[3]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23
    };

    internal override string[] AttributeTagNames
    {
      get
      {
        return RunTrackChangeType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return RunTrackChangeType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "author")]
    public StringValue Author
    {
      get
      {
        return (StringValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "date")]
    public DateTimeValue Date
    {
      get
      {
        return (DateTimeValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "id")]
    public StringValue Id
    {
      get
      {
        return (StringValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "sdt" == name)
        return (OpenXmlElement) new SdtRun();
      if (23 == (int) namespaceId && "proofErr" == name)
        return (OpenXmlElement) new ProofError();
      if (23 == (int) namespaceId && "permStart" == name)
        return (OpenXmlElement) new PermStart();
      if (23 == (int) namespaceId && "permEnd" == name)
        return (OpenXmlElement) new PermEnd();
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
      if (23 == (int) namespaceId && "ins" == name)
        return (OpenXmlElement) new InsertedRun();
      if (23 == (int) namespaceId && "del" == name)
        return (OpenXmlElement) new DeletedRun();
      if (23 == (int) namespaceId && "moveFrom" == name)
        return (OpenXmlElement) new MoveFromRun();
      if (23 == (int) namespaceId && "moveTo" == name)
        return (OpenXmlElement) new MoveToRun();
      if (23 == (int) namespaceId && "contentPart" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Wordprocessing.ContentPart();
      if (52 == (int) namespaceId && "conflictIns" == name)
        return (OpenXmlElement) new RunConflictInsertion();
      if (52 == (int) namespaceId && "conflictDel" == name)
        return (OpenXmlElement) new RunConflictDeletion();
      if (21 == (int) namespaceId && "oMathPara" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Math.Paragraph();
      if (21 == (int) namespaceId && "oMath" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Math.OfficeMath();
      if (21 == (int) namespaceId && "acc" == name)
        return (OpenXmlElement) new Accent();
      if (21 == (int) namespaceId && "bar" == name)
        return (OpenXmlElement) new Bar();
      if (21 == (int) namespaceId && "box" == name)
        return (OpenXmlElement) new Box();
      if (21 == (int) namespaceId && "borderBox" == name)
        return (OpenXmlElement) new BorderBox();
      if (21 == (int) namespaceId && "d" == name)
        return (OpenXmlElement) new Delimiter();
      if (21 == (int) namespaceId && "eqArr" == name)
        return (OpenXmlElement) new EquationArray();
      if (21 == (int) namespaceId && "f" == name)
        return (OpenXmlElement) new Fraction();
      if (21 == (int) namespaceId && "func" == name)
        return (OpenXmlElement) new MathFunction();
      if (21 == (int) namespaceId && "groupChr" == name)
        return (OpenXmlElement) new GroupChar();
      if (21 == (int) namespaceId && "limLow" == name)
        return (OpenXmlElement) new LimitLower();
      if (21 == (int) namespaceId && "limUpp" == name)
        return (OpenXmlElement) new LimitUpper();
      if (21 == (int) namespaceId && "m" == name)
        return (OpenXmlElement) new Matrix();
      if (21 == (int) namespaceId && "nary" == name)
        return (OpenXmlElement) new Nary();
      if (21 == (int) namespaceId && "phant" == name)
        return (OpenXmlElement) new Phantom();
      if (21 == (int) namespaceId && "rad" == name)
        return (OpenXmlElement) new Radical();
      if (21 == (int) namespaceId && "sPre" == name)
        return (OpenXmlElement) new PreSubSuper();
      if (21 == (int) namespaceId && "sSub" == name)
        return (OpenXmlElement) new Subscript();
      if (21 == (int) namespaceId && "sSubSup" == name)
        return (OpenXmlElement) new SubSuperscript();
      if (21 == (int) namespaceId && "sSup" == name)
        return (OpenXmlElement) new Superscript();
      if (21 == (int) namespaceId && "r" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Math.Run();
      if (23 == (int) namespaceId && "r" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Wordprocessing.Run();
      if (23 == (int) namespaceId && "bdo" == name)
        return (OpenXmlElement) new BidirectionalOverride();
      if (23 == (int) namespaceId && "dir" == name)
        return (OpenXmlElement) new BidirectionalEmbedding();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "author" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "date" == name)
        return (OpenXmlSimpleType) new DateTimeValue();
      if (23 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    protected RunTrackChangeType()
    {
    }

    protected RunTrackChangeType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected RunTrackChangeType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected RunTrackChangeType(string outerXml)
      : base(outerXml)
    {
    }
  }
}

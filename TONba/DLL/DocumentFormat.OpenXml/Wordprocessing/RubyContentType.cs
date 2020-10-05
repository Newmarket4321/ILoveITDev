// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.RubyContentType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Office2010.Word;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (MoveFromRangeStart))]
  [ChildElementInfo(typeof (DeletedRun))]
  [ChildElementInfo(typeof (MoveFromRun))]
  [ChildElementInfo(typeof (CustomXmlRuby))]
  [ChildElementInfo(typeof (SimpleFieldRuby))]
  [ChildElementInfo(typeof (HyperlinkRuby))]
  [ChildElementInfo(typeof (Run))]
  [ChildElementInfo(typeof (SdtRunRuby))]
  [ChildElementInfo(typeof (ProofError))]
  [ChildElementInfo(typeof (PermStart))]
  [ChildElementInfo(typeof (PermEnd))]
  [ChildElementInfo(typeof (BookmarkStart))]
  [ChildElementInfo(typeof (BookmarkEnd))]
  [ChildElementInfo(typeof (CommentRangeStart))]
  [ChildElementInfo(typeof (CommentRangeEnd))]
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
  [ChildElementInfo(typeof (MathFunction))]
  [ChildElementInfo(typeof (MoveToRun))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (RunConflictInsertion), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (RunConflictDeletion), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Math.Paragraph))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Math.OfficeMath))]
  [ChildElementInfo(typeof (Accent))]
  [ChildElementInfo(typeof (Bar))]
  [ChildElementInfo(typeof (Box))]
  [ChildElementInfo(typeof (BorderBox))]
  [ChildElementInfo(typeof (Delimiter))]
  [ChildElementInfo(typeof (EquationArray))]
  [ChildElementInfo(typeof (Fraction))]
  [ChildElementInfo(typeof (ContentPart), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (GroupChar))]
  [ChildElementInfo(typeof (LimitLower))]
  [ChildElementInfo(typeof (LimitUpper))]
  [ChildElementInfo(typeof (Matrix))]
  [ChildElementInfo(typeof (Nary))]
  [ChildElementInfo(typeof (Phantom))]
  [ChildElementInfo(typeof (Radical))]
  [ChildElementInfo(typeof (PreSubSuper))]
  [ChildElementInfo(typeof (Subscript))]
  [ChildElementInfo(typeof (SubSuperscript))]
  [ChildElementInfo(typeof (Superscript))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Math.Run))]
  public abstract class RubyContentType : OpenXmlCompositeElement
  {
    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "customXml" == name)
        return (OpenXmlElement) new CustomXmlRuby();
      if (23 == (int) namespaceId && "fldSimple" == name)
        return (OpenXmlElement) new SimpleFieldRuby();
      if (23 == (int) namespaceId && "hyperlink" == name)
        return (OpenXmlElement) new HyperlinkRuby();
      if (23 == (int) namespaceId && "r" == name)
        return (OpenXmlElement) new Run();
      if (23 == (int) namespaceId && "sdt" == name)
        return (OpenXmlElement) new SdtRunRuby();
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
        return (OpenXmlElement) new ContentPart();
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
      return (OpenXmlElement) null;
    }

    protected RubyContentType()
    {
    }

    protected RubyContentType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected RubyContentType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected RubyContentType(string outerXml)
      : base(outerXml)
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.Hyperlink
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Office2010.Word;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (CustomXmlDelRangeStart))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (MoveFromRun))]
  [ChildElementInfo(typeof (CustomXmlRun))]
  [ChildElementInfo(typeof (SimpleField))]
  [ChildElementInfo(typeof (Hyperlink))]
  [ChildElementInfo(typeof (SdtRun))]
  [ChildElementInfo(typeof (ProofError))]
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
  [ChildElementInfo(typeof (GroupChar))]
  [ChildElementInfo(typeof (SubDocumentReference))]
  [ChildElementInfo(typeof (ContentPart), FileFormatVersions.Office2010)]
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
  [ChildElementInfo(typeof (MathFunction))]
  [ChildElementInfo(typeof (MoveToRun))]
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
  [ChildElementInfo(typeof (Run))]
  [ChildElementInfo(typeof (BidirectionalOverride), FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (BidirectionalEmbedding), FileFormatVersions.Office2010)]
  public class Hyperlink : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[6]
    {
      "tgtFrame",
      "tooltip",
      "docLocation",
      "history",
      "anchor",
      "id"
    };
    private static byte[] attributeNamespaceIds = new byte[6]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 19
    };
    private const string tagName = "hyperlink";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11691;

    public override string LocalName
    {
      get
      {
        return "hyperlink";
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
        return 11691;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return Hyperlink.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Hyperlink.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "tgtFrame")]
    public StringValue TargetFrame
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

    [SchemaAttr(23, "tooltip")]
    public StringValue Tooltip
    {
      get
      {
        return (StringValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "docLocation")]
    public StringValue DocLocation
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

    [SchemaAttr(23, "history")]
    public OnOffValue History
    {
      get
      {
        return (OnOffValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "anchor")]
    public StringValue Anchor
    {
      get
      {
        return (StringValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(19, "id")]
    public StringValue Id
    {
      get
      {
        return (StringValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    public Hyperlink()
    {
    }

    public Hyperlink(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Hyperlink(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Hyperlink(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "customXml" == name)
        return (OpenXmlElement) new CustomXmlRun();
      if (23 == (int) namespaceId && "fldSimple" == name)
        return (OpenXmlElement) new SimpleField();
      if (23 == (int) namespaceId && "hyperlink" == name)
        return (OpenXmlElement) new Hyperlink();
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
      if (23 == (int) namespaceId && "r" == name)
        return (OpenXmlElement) new Run();
      if (23 == (int) namespaceId && "bdo" == name)
        return (OpenXmlElement) new BidirectionalOverride();
      if (23 == (int) namespaceId && "dir" == name)
        return (OpenXmlElement) new BidirectionalEmbedding();
      if (23 == (int) namespaceId && "subDoc" == name)
        return (OpenXmlElement) new SubDocumentReference();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "tgtFrame" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "tooltip" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "docLocation" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "history" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "anchor" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (19 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Hyperlink>(deep);
    }
  }
}

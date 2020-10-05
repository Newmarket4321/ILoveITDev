// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.Comment
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ProofError))]
  [ChildElementInfo(typeof (CommentRangeEnd))]
  [ChildElementInfo(typeof (CustomXmlBlock))]
  [ChildElementInfo(typeof (SdtBlock))]
  [ChildElementInfo(typeof (Paragraph))]
  [ChildElementInfo(typeof (Table))]
  [ChildElementInfo(typeof (AltChunk))]
  [ChildElementInfo(typeof (PermStart))]
  [ChildElementInfo(typeof (PermEnd))]
  [ChildElementInfo(typeof (BookmarkStart))]
  [ChildElementInfo(typeof (BookmarkEnd))]
  [ChildElementInfo(typeof (CommentRangeStart))]
  public class Comment : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "initials",
      "author",
      "date",
      "id"
    };
    private static byte[] attributeNamespaceIds = new byte[4]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "comment";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11973;

    public override string LocalName
    {
      get
      {
        return "comment";
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
        return 11973;
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
        return Comment.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Comment.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "initials")]
    public StringValue Initials
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

    [SchemaAttr(23, "author")]
    public StringValue Author
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

    [SchemaAttr(23, "date")]
    public DateTimeValue Date
    {
      get
      {
        return (DateTimeValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "id")]
    public StringValue Id
    {
      get
      {
        return (StringValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    public Comment()
    {
    }

    public Comment(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Comment(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Comment(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "altChunk" == name)
        return (OpenXmlElement) new AltChunk();
      if (23 == (int) namespaceId && "customXml" == name)
        return (OpenXmlElement) new CustomXmlBlock();
      if (23 == (int) namespaceId && "sdt" == name)
        return (OpenXmlElement) new SdtBlock();
      if (23 == (int) namespaceId && "p" == name)
        return (OpenXmlElement) new Paragraph();
      if (23 == (int) namespaceId && "tbl" == name)
        return (OpenXmlElement) new Table();
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
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "initials" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "author" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "date" == name)
        return (OpenXmlSimpleType) new DateTimeValue();
      if (23 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Comment>(deep);
    }
  }
}

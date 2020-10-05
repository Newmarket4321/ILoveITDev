// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.Comment
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (Text))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (CommentExtensionList))]
  [ChildElementInfo(typeof (Position))]
  public class Comment : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "authorId",
      "dt",
      "idx"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private static readonly string[] eleTagNames = new string[3]
    {
      "pos",
      "text",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 24,
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "cm";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12308;

    public override string LocalName
    {
      get
      {
        return "cm";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 24;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12308;
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

    [SchemaAttr(0, "authorId")]
    public UInt32Value AuthorId
    {
      get
      {
        return (UInt32Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "dt")]
    public DateTimeValue DateTime
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

    [SchemaAttr(0, "idx")]
    public UInt32Value Index
    {
      get
      {
        return (UInt32Value) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
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
      if (24 == (int) namespaceId && "pos" == name)
        return (OpenXmlElement) new Position();
      if (24 == (int) namespaceId && "text" == name)
        return (OpenXmlElement) new Text();
      if (24 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new CommentExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Comment.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Comment.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Position Position
    {
      get
      {
        return this.GetElement<Position>(0);
      }
      set
      {
        this.SetElement<Position>(0, value);
      }
    }

    public Text Text
    {
      get
      {
        return this.GetElement<Text>(1);
      }
      set
      {
        this.SetElement<Text>(1, value);
      }
    }

    public CommentExtensionList CommentExtensionList
    {
      get
      {
        return this.GetElement<CommentExtensionList>(2);
      }
      set
      {
        this.SetElement<CommentExtensionList>(2, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "authorId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "dt" == name)
        return (OpenXmlSimpleType) new DateTimeValue();
      if ((int) namespaceId == 0 && "idx" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Comment>(deep);
    }
  }
}

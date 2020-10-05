// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.Comments
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (Authors))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ExtensionList))]
  [ChildElementInfo(typeof (CommentList))]
  public class Comments : OpenXmlPartRootElement
  {
    private static readonly string[] eleTagNames = new string[3]
    {
      "authors",
      "commentList",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 22,
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "comments";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11094;

    public override string LocalName
    {
      get
      {
        return "comments";
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
        return 11094;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal Comments(WorksheetCommentsPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(WorksheetCommentsPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public WorksheetCommentsPart WorksheetCommentsPart
    {
      get
      {
        return this.OpenXmlPart as WorksheetCommentsPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public Comments(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Comments(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Comments(string outerXml)
      : base(outerXml)
    {
    }

    public Comments()
    {
    }

    public void Save(WorksheetCommentsPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "authors" == name)
        return (OpenXmlElement) new Authors();
      if (22 == (int) namespaceId && "commentList" == name)
        return (OpenXmlElement) new CommentList();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Comments.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Comments.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Authors Authors
    {
      get
      {
        return this.GetElement<Authors>(0);
      }
      set
      {
        this.SetElement<Authors>(0, value);
      }
    }

    public CommentList CommentList
    {
      get
      {
        return this.GetElement<CommentList>(1);
      }
      set
      {
        this.SetElement<CommentList>(1, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(2);
      }
      set
      {
        this.SetElement<ExtensionList>(2, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Comments>(deep);
    }
  }
}

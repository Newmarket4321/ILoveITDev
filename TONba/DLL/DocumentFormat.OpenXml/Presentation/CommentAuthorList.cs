// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.CommentAuthorList
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (CommentAuthor))]
  public class CommentAuthorList : OpenXmlPartRootElement
  {
    private const string tagName = "cmAuthorLst";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12233;

    public override string LocalName
    {
      get
      {
        return "cmAuthorLst";
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
        return 12233;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal CommentAuthorList(CommentAuthorsPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(CommentAuthorsPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public CommentAuthorsPart CommentAuthorsPart
    {
      get
      {
        return this.OpenXmlPart as CommentAuthorsPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public CommentAuthorList(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public CommentAuthorList(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public CommentAuthorList(string outerXml)
      : base(outerXml)
    {
    }

    public CommentAuthorList()
    {
    }

    public void Save(CommentAuthorsPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "cmAuthor" == name)
        return (OpenXmlElement) new CommentAuthor();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<CommentAuthorList>(deep);
    }
  }
}

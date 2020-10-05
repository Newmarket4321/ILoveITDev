// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.CommentList
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (Comment))]
  [GeneratedCode("DomGen", "2.0")]
  public class CommentList : OpenXmlPartRootElement
  {
    private const string tagName = "cmLst";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12234;

    public override string LocalName
    {
      get
      {
        return "cmLst";
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
        return 12234;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal CommentList(SlideCommentsPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(SlideCommentsPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public SlideCommentsPart SlideCommentsPart
    {
      get
      {
        return this.OpenXmlPart as SlideCommentsPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public CommentList(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public CommentList(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public CommentList(string outerXml)
      : base(outerXml)
    {
    }

    public CommentList()
    {
    }

    public void Save(SlideCommentsPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "cm" == name)
        return (OpenXmlElement) new Comment();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<CommentList>(deep);
    }
  }
}

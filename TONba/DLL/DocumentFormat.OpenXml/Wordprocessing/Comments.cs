// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.Comments
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Comment))]
  public class Comments : OpenXmlPartRootElement
  {
    private const string tagName = "comments";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11755;

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
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11755;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal Comments(WordprocessingCommentsPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(WordprocessingCommentsPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public WordprocessingCommentsPart WordprocessingCommentsPart
    {
      get
      {
        return this.OpenXmlPart as WordprocessingCommentsPart;
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

    public void Save(WordprocessingCommentsPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "comment" == name)
        return (OpenXmlElement) new Comment();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Comments>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Word.CommentsEx
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Word
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (CommentEx), FileFormatVersions.Office2013)]
  public class CommentsEx : OpenXmlPartRootElement
  {
    private const string tagName = "commentsEx";
    private const byte tagNsId = 69;
    internal const int ElementTypeIdConst = 13338;

    public override string LocalName
    {
      get
      {
        return "commentsEx";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 69;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13338;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    internal CommentsEx(WordprocessingCommentsExPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(WordprocessingCommentsExPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public WordprocessingCommentsExPart WordprocessingCommentsExPart
    {
      get
      {
        return this.OpenXmlPart as WordprocessingCommentsExPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public CommentsEx(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public CommentsEx(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public CommentsEx(string outerXml)
      : base(outerXml)
    {
    }

    public CommentsEx()
    {
    }

    public void Save(WordprocessingCommentsExPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (69 == (int) namespaceId && "commentEx" == name)
        return (OpenXmlElement) new CommentEx();
      return (OpenXmlElement) null;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<CommentsEx>(deep);
    }
  }
}

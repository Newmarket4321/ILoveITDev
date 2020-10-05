// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.PowerPoint.NotesGuideList
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.PowerPoint
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class NotesGuideList : ExtendedGuideList
  {
    private const string tagName = "notesGuideLst";
    private const byte tagNsId = 68;
    internal const int ElementTypeIdConst = 13329;

    public override string LocalName
    {
      get
      {
        return "notesGuideLst";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 68;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13329;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public NotesGuideList()
    {
    }

    public NotesGuideList(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public NotesGuideList(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public NotesGuideList(string outerXml)
      : base(outerXml)
    {
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<NotesGuideList>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.GroupShape
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Word.DrawingGroup
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class GroupShape : WordprocessingGroupType
  {
    private const string tagName = "grpSp";
    private const byte tagNsId = 60;
    internal const int ElementTypeIdConst = 13194;

    public override string LocalName
    {
      get
      {
        return "grpSp";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 60;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13194;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public GroupShape()
    {
    }

    public GroupShape(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public GroupShape(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public GroupShape(string outerXml)
      : base(outerXml)
    {
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<GroupShape>(deep);
    }
  }
}

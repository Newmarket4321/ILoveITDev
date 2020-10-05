// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2010.Word
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [GeneratedCode("DomGen", "2.0")]
  public class CustomXmlConflictInsertionRangeStart : TrackChangeType
  {
    private const string tagName = "customXmlConflictInsRangeStart";
    private const byte tagNsId = 52;
    internal const int ElementTypeIdConst = 12935;

    public override string LocalName
    {
      get
      {
        return "customXmlConflictInsRangeStart";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 52;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12935;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<CustomXmlConflictInsertionRangeStart>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.ToMarker
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [GeneratedCode("DomGen", "2.0")]
  public class ToMarker : MarkerType
  {
    private const string tagName = "to";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11368;

    public override string LocalName
    {
      get
      {
        return "to";
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
        return 11368;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2010 & version) > FileFormatVersions.None;
    }

    public ToMarker()
    {
    }

    public ToMarker(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ToMarker(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ToMarker(string outerXml)
      : base(outerXml)
    {
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ToMarker>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.FromMarker
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [GeneratedCode("DomGen", "2.0")]
  public class FromMarker : MarkerType
  {
    private const string tagName = "from";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11367;

    public override string LocalName
    {
      get
      {
        return "from";
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
        return 11367;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2010 & version) > FileFormatVersions.None;
    }

    public FromMarker()
    {
    }

    public FromMarker(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public FromMarker(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public FromMarker(string outerXml)
      : base(outerXml)
    {
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<FromMarker>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.StartBorder
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [GeneratedCode("DomGen", "2.0")]
  public class StartBorder : BorderPropertiesType
  {
    private const string tagName = "start";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11377;

    public override string LocalName
    {
      get
      {
        return "start";
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
        return 11377;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2010 & version) > FileFormatVersions.None;
    }

    public StartBorder()
    {
    }

    public StartBorder(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public StartBorder(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public StartBorder(string outerXml)
      : base(outerXml)
    {
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<StartBorder>(deep);
    }
  }
}

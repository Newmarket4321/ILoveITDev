// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Spreadsheet.ColumnOffset
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Drawing.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  public class ColumnOffset : OpenXmlLeafTextElement
  {
    private const string tagName = "colOff";
    private const byte tagNsId = 18;
    internal const int ElementTypeIdConst = 10806;

    public override string LocalName
    {
      get
      {
        return "colOff";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 18;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10806;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public ColumnOffset()
    {
    }

    public ColumnOffset(string text)
      : base(text)
    {
    }

    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
      Int64Value int64Value = new Int64Value();
      int64Value.InnerText = text;
      return (OpenXmlSimpleType) int64Value;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ColumnOffset>(deep);
    }
  }
}

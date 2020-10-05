// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Vml.Spreadsheet.MoveWithCells
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Vml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  public class MoveWithCells : OpenXmlLeafTextElement
  {
    private const string tagName = "MoveWithCells";
    private const byte tagNsId = 29;
    internal const int ElementTypeIdConst = 12508;

    public override string LocalName
    {
      get
      {
        return nameof (MoveWithCells);
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 29;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12508;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public MoveWithCells()
    {
    }

    public MoveWithCells(string text)
      : base(text)
    {
    }

    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
      EnumValue<BooleanEntryWithBlankValues> enumValue = new EnumValue<BooleanEntryWithBlankValues>();
      enumValue.InnerText = text;
      return (OpenXmlSimpleType) enumValue;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<MoveWithCells>(deep);
    }
  }
}

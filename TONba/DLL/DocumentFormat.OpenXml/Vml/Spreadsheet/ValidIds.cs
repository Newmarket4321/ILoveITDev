// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Vml.Spreadsheet.ValidIds
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Vml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  public class ValidIds : OpenXmlLeafTextElement
  {
    private const string tagName = "ValidIds";
    private const byte tagNsId = 29;
    internal const int ElementTypeIdConst = 12538;

    public override string LocalName
    {
      get
      {
        return nameof (ValidIds);
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
        return 12538;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public ValidIds()
    {
    }

    public ValidIds(string text)
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
      return (OpenXmlElement) this.CloneImp<ValidIds>(deep);
    }
  }
}

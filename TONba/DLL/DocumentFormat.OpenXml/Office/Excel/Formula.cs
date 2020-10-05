// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.Excel.Formula
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office.Excel
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [GeneratedCode("DomGen", "2.0")]
  public class Formula : OpenXmlLeafTextElement
  {
    private const string tagName = "f";
    private const byte tagNsId = 32;
    internal const int ElementTypeIdConst = 12603;

    public override string LocalName
    {
      get
      {
        return "f";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 32;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12603;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2010 & version) > FileFormatVersions.None;
    }

    public Formula()
    {
    }

    public Formula(string text)
      : base(text)
    {
    }

    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
      StringValue stringValue = new StringValue();
      stringValue.InnerText = text;
      return (OpenXmlSimpleType) stringValue;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Formula>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.VariantTypes.VTDate
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.VariantTypes
{
  [GeneratedCode("DomGen", "2.0")]
  public class VTDate : OpenXmlLeafTextElement
  {
    private const string tagName = "date";
    private const byte tagNsId = 5;
    internal const int ElementTypeIdConst = 11052;

    public override string LocalName
    {
      get
      {
        return "date";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 5;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11052;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public VTDate()
    {
    }

    public VTDate(string text)
      : base(text)
    {
    }

    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
      DateTimeValue dateTimeValue = new DateTimeValue();
      dateTimeValue.InnerText = text;
      return (OpenXmlSimpleType) dateTimeValue;
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<VTDate>(deep);
    }
  }
}

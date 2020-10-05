// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Excel.DescriptionPrSurveyElementPr
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Excel
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class DescriptionPrSurveyElementPr : OpenXmlSurveyElementPrElement
  {
    private const string tagName = "descriptionPr";
    private const byte tagNsId = 71;
    internal const int ElementTypeIdConst = 13418;

    public override string LocalName
    {
      get
      {
        return "descriptionPr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 71;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13418;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public DescriptionPrSurveyElementPr()
    {
    }

    public DescriptionPrSurveyElementPr(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DescriptionPrSurveyElementPr(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DescriptionPrSurveyElementPr(string outerXml)
      : base(outerXml)
    {
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DescriptionPrSurveyElementPr>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Excel.SurveyPrSurveyElementPr
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Excel
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class SurveyPrSurveyElementPr : OpenXmlSurveyElementPrElement
  {
    private const string tagName = "surveyPr";
    private const byte tagNsId = 71;
    internal const int ElementTypeIdConst = 13416;

    public override string LocalName
    {
      get
      {
        return "surveyPr";
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
        return 13416;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public SurveyPrSurveyElementPr()
    {
    }

    public SurveyPrSurveyElementPr(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SurveyPrSurveyElementPr(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SurveyPrSurveyElementPr(string outerXml)
      : base(outerXml)
    {
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SurveyPrSurveyElementPr>(deep);
    }
  }
}

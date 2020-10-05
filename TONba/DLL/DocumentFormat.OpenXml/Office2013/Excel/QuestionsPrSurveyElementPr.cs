// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Excel.QuestionsPrSurveyElementPr
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Excel
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class QuestionsPrSurveyElementPr : OpenXmlSurveyElementPrElement
  {
    private const string tagName = "questionsPr";
    private const byte tagNsId = 71;
    internal const int ElementTypeIdConst = 13420;

    public override string LocalName
    {
      get
      {
        return "questionsPr";
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
        return 13420;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public QuestionsPrSurveyElementPr()
    {
    }

    public QuestionsPrSurveyElementPr(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public QuestionsPrSurveyElementPr(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public QuestionsPrSurveyElementPr(string outerXml)
      : base(outerXml)
    {
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<QuestionsPrSurveyElementPr>(deep);
    }
  }
}

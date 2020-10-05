// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Excel.SurveyQuestions
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Excel
{
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (QuestionsPrSurveyElementPr), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (SurveyQuestion), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class SurveyQuestions : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "questionsPr",
      "question"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 71,
      (byte) 71
    };
    private const string tagName = "questions";
    private const byte tagNsId = 71;
    internal const int ElementTypeIdConst = 13419;

    public override string LocalName
    {
      get
      {
        return "questions";
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
        return 13419;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    public SurveyQuestions()
    {
    }

    public SurveyQuestions(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SurveyQuestions(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SurveyQuestions(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (71 == (int) namespaceId && "questionsPr" == name)
        return (OpenXmlElement) new QuestionsPrSurveyElementPr();
      if (71 == (int) namespaceId && "question" == name)
        return (OpenXmlElement) new SurveyQuestion();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return SurveyQuestions.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return SurveyQuestions.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public QuestionsPrSurveyElementPr QuestionsPrSurveyElementPr
    {
      get
      {
        return this.GetElement<QuestionsPrSurveyElementPr>(0);
      }
      set
      {
        this.SetElement<QuestionsPrSurveyElementPr>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SurveyQuestions>(deep);
    }
  }
}

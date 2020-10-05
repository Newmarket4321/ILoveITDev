// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Excel.Survey
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Excel
{
  [ChildElementInfo(typeof (SurveyQuestions), FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (SurveyPrSurveyElementPr), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (TitlePrSurveyElementPr), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (DescriptionPrSurveyElementPr), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ExtensionList), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class Survey : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "id",
      "guid",
      "title",
      "description"
    };
    private static byte[] attributeNamespaceIds = new byte[4];
    private static readonly string[] eleTagNames = new string[5]
    {
      "surveyPr",
      "titlePr",
      "descriptionPr",
      "questions",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[5]
    {
      (byte) 71,
      (byte) 71,
      (byte) 71,
      (byte) 71,
      (byte) 71
    };
    private const string tagName = "survey";
    private const byte tagNsId = 71;
    internal const int ElementTypeIdConst = 13385;

    public override string LocalName
    {
      get
      {
        return "survey";
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
        return 13385;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return Survey.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Survey.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "id")]
    public UInt32Value Id
    {
      get
      {
        return (UInt32Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "guid")]
    public StringValue Guid
    {
      get
      {
        return (StringValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "title")]
    public StringValue Title
    {
      get
      {
        return (StringValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "description")]
    public StringValue Description
    {
      get
      {
        return (StringValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    public Survey()
    {
    }

    public Survey(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Survey(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Survey(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (71 == (int) namespaceId && "surveyPr" == name)
        return (OpenXmlElement) new SurveyPrSurveyElementPr();
      if (71 == (int) namespaceId && "titlePr" == name)
        return (OpenXmlElement) new TitlePrSurveyElementPr();
      if (71 == (int) namespaceId && "descriptionPr" == name)
        return (OpenXmlElement) new DescriptionPrSurveyElementPr();
      if (71 == (int) namespaceId && "questions" == name)
        return (OpenXmlElement) new SurveyQuestions();
      if (71 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Survey.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Survey.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public SurveyPrSurveyElementPr SurveyPrSurveyElementPr
    {
      get
      {
        return this.GetElement<SurveyPrSurveyElementPr>(0);
      }
      set
      {
        this.SetElement<SurveyPrSurveyElementPr>(0, value);
      }
    }

    public TitlePrSurveyElementPr TitlePrSurveyElementPr
    {
      get
      {
        return this.GetElement<TitlePrSurveyElementPr>(1);
      }
      set
      {
        this.SetElement<TitlePrSurveyElementPr>(1, value);
      }
    }

    public DescriptionPrSurveyElementPr DescriptionPrSurveyElementPr
    {
      get
      {
        return this.GetElement<DescriptionPrSurveyElementPr>(2);
      }
      set
      {
        this.SetElement<DescriptionPrSurveyElementPr>(2, value);
      }
    }

    public SurveyQuestions SurveyQuestions
    {
      get
      {
        return this.GetElement<SurveyQuestions>(3);
      }
      set
      {
        this.SetElement<SurveyQuestions>(3, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(4);
      }
      set
      {
        this.SetElement<ExtensionList>(4, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "id" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "guid" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "title" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "description" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Survey>(deep);
    }
  }
}

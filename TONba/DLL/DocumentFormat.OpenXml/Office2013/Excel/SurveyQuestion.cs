// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Excel.SurveyQuestion
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Excel
{
  [ChildElementInfo(typeof (ExtensionList), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (QuestionPrSurveyElementPr), FileFormatVersions.Office2013)]
  public class SurveyQuestion : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[9]
    {
      "binding",
      "text",
      "type",
      "format",
      "helpText",
      "required",
      "defaultValue",
      "decimalPlaces",
      "rowSource"
    };
    private static byte[] attributeNamespaceIds = new byte[9];
    private static readonly string[] eleTagNames = new string[2]
    {
      "questionPr",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 71,
      (byte) 71
    };
    private const string tagName = "question";
    private const byte tagNsId = 71;
    internal const int ElementTypeIdConst = 13421;

    public override string LocalName
    {
      get
      {
        return "question";
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
        return 13421;
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
        return SurveyQuestion.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return SurveyQuestion.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "binding")]
    public UInt32Value Binding
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

    [SchemaAttr(0, "text")]
    public StringValue Text
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

    [SchemaAttr(0, "type")]
    public EnumValue<QuestionType> Type
    {
      get
      {
        return (EnumValue<QuestionType>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "format")]
    public EnumValue<QuestionFormat> Format
    {
      get
      {
        return (EnumValue<QuestionFormat>) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "helpText")]
    public StringValue HelpText
    {
      get
      {
        return (StringValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "required")]
    public BooleanValue Required
    {
      get
      {
        return (BooleanValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "defaultValue")]
    public StringValue DefaultValue
    {
      get
      {
        return (StringValue) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "decimalPlaces")]
    public UInt32Value DecimalPlaces
    {
      get
      {
        return (UInt32Value) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "rowSource")]
    public StringValue RowSource
    {
      get
      {
        return (StringValue) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    public SurveyQuestion()
    {
    }

    public SurveyQuestion(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SurveyQuestion(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SurveyQuestion(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (71 == (int) namespaceId && "questionPr" == name)
        return (OpenXmlElement) new QuestionPrSurveyElementPr();
      if (71 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return SurveyQuestion.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return SurveyQuestion.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public QuestionPrSurveyElementPr QuestionPrSurveyElementPr
    {
      get
      {
        return this.GetElement<QuestionPrSurveyElementPr>(0);
      }
      set
      {
        this.SetElement<QuestionPrSurveyElementPr>(0, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(1);
      }
      set
      {
        this.SetElement<ExtensionList>(1, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "binding" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "text" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "type" == name)
        return (OpenXmlSimpleType) new EnumValue<QuestionType>();
      if ((int) namespaceId == 0 && "format" == name)
        return (OpenXmlSimpleType) new EnumValue<QuestionFormat>();
      if ((int) namespaceId == 0 && "helpText" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "required" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "defaultValue" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "decimalPlaces" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "rowSource" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SurveyQuestion>(deep);
    }
  }
}

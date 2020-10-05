// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.DataValidation
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (ReferenceSequence))]
  [ChildElementInfo(typeof (DataValidationForumla1), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (DataValidationForumla2), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public class DataValidation : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[12]
    {
      "type",
      "errorStyle",
      "imeMode",
      "operator",
      "allowBlank",
      "showDropDown",
      "showInputMessage",
      "showErrorMessage",
      "errorTitle",
      "error",
      "promptTitle",
      "prompt"
    };
    private static byte[] attributeNamespaceIds = new byte[12];
    private static readonly string[] eleTagNames = new string[3]
    {
      "formula1",
      "formula2",
      "sqref"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 53,
      (byte) 53,
      (byte) 32
    };
    private const string tagName = "dataValidation";
    private const byte tagNsId = 53;
    internal const int ElementTypeIdConst = 12998;

    public override string LocalName
    {
      get
      {
        return "dataValidation";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 53;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12998;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return DataValidation.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return DataValidation.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "type")]
    public EnumValue<DataValidationValues> Type
    {
      get
      {
        return (EnumValue<DataValidationValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "errorStyle")]
    public EnumValue<DataValidationErrorStyleValues> ErrorStyle
    {
      get
      {
        return (EnumValue<DataValidationErrorStyleValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "imeMode")]
    public EnumValue<DataValidationImeModeValues> ImeMode
    {
      get
      {
        return (EnumValue<DataValidationImeModeValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "operator")]
    public EnumValue<DataValidationOperatorValues> Operator
    {
      get
      {
        return (EnumValue<DataValidationOperatorValues>) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "allowBlank")]
    public BooleanValue AllowBlank
    {
      get
      {
        return (BooleanValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "showDropDown")]
    public BooleanValue ShowDropDown
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

    [SchemaAttr(0, "showInputMessage")]
    public BooleanValue ShowInputMessage
    {
      get
      {
        return (BooleanValue) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "showErrorMessage")]
    public BooleanValue ShowErrorMessage
    {
      get
      {
        return (BooleanValue) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "errorTitle")]
    public StringValue ErrorTitle
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

    [SchemaAttr(0, "error")]
    public StringValue Error
    {
      get
      {
        return (StringValue) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "promptTitle")]
    public StringValue PromptTitle
    {
      get
      {
        return (StringValue) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "prompt")]
    public StringValue Prompt
    {
      get
      {
        return (StringValue) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    public DataValidation()
    {
    }

    public DataValidation(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DataValidation(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DataValidation(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (53 == (int) namespaceId && "formula1" == name)
        return (OpenXmlElement) new DataValidationForumla1();
      if (53 == (int) namespaceId && "formula2" == name)
        return (OpenXmlElement) new DataValidationForumla2();
      if (32 == (int) namespaceId && "sqref" == name)
        return (OpenXmlElement) new ReferenceSequence();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DataValidation.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DataValidation.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public DataValidationForumla1 DataValidationForumla1
    {
      get
      {
        return this.GetElement<DataValidationForumla1>(0);
      }
      set
      {
        this.SetElement<DataValidationForumla1>(0, value);
      }
    }

    public DataValidationForumla2 DataValidationForumla2
    {
      get
      {
        return this.GetElement<DataValidationForumla2>(1);
      }
      set
      {
        this.SetElement<DataValidationForumla2>(1, value);
      }
    }

    public ReferenceSequence ReferenceSequence
    {
      get
      {
        return this.GetElement<ReferenceSequence>(2);
      }
      set
      {
        this.SetElement<ReferenceSequence>(2, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "type" == name)
        return (OpenXmlSimpleType) new EnumValue<DataValidationValues>();
      if ((int) namespaceId == 0 && "errorStyle" == name)
        return (OpenXmlSimpleType) new EnumValue<DataValidationErrorStyleValues>();
      if ((int) namespaceId == 0 && "imeMode" == name)
        return (OpenXmlSimpleType) new EnumValue<DataValidationImeModeValues>();
      if ((int) namespaceId == 0 && "operator" == name)
        return (OpenXmlSimpleType) new EnumValue<DataValidationOperatorValues>();
      if ((int) namespaceId == 0 && "allowBlank" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showDropDown" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showInputMessage" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showErrorMessage" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "errorTitle" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "error" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "promptTitle" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "prompt" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DataValidation>(deep);
    }
  }
}

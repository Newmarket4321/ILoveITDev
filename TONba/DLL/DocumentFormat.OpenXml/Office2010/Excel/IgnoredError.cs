// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.IgnoredError
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Office.Excel;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (ReferenceSequence))]
  [GeneratedCode("DomGen", "2.0")]
  public class IgnoredError : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[9]
    {
      "evalError",
      "twoDigitTextYear",
      "numberStoredAsText",
      "formula",
      "formulaRange",
      "unlockedFormula",
      "emptyCellReference",
      "listDataValidation",
      "calculatedColumn"
    };
    private static byte[] attributeNamespaceIds = new byte[9];
    private static readonly string[] eleTagNames = new string[1]
    {
      "sqref"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 32
    };
    private const string tagName = "ignoredError";
    private const byte tagNsId = 53;
    internal const int ElementTypeIdConst = 13054;

    public override string LocalName
    {
      get
      {
        return "ignoredError";
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
        return 13054;
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
        return IgnoredError.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return IgnoredError.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "evalError")]
    public BooleanValue EvalError
    {
      get
      {
        return (BooleanValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "twoDigitTextYear")]
    public BooleanValue TwoDigitTextYear
    {
      get
      {
        return (BooleanValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "numberStoredAsText")]
    public BooleanValue NumberStoredAsText
    {
      get
      {
        return (BooleanValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "formula")]
    public BooleanValue Formula
    {
      get
      {
        return (BooleanValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "formulaRange")]
    public BooleanValue FormulaRange
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

    [SchemaAttr(0, "unlockedFormula")]
    public BooleanValue UnlockedFormula
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

    [SchemaAttr(0, "emptyCellReference")]
    public BooleanValue EmptyCellReference
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

    [SchemaAttr(0, "listDataValidation")]
    public BooleanValue ListDataValidation
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

    [SchemaAttr(0, "calculatedColumn")]
    public BooleanValue CalculatedColumn
    {
      get
      {
        return (BooleanValue) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    public IgnoredError()
    {
    }

    public IgnoredError(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public IgnoredError(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public IgnoredError(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (32 == (int) namespaceId && "sqref" == name)
        return (OpenXmlElement) new ReferenceSequence();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return IgnoredError.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return IgnoredError.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ReferenceSequence ReferenceSequence
    {
      get
      {
        return this.GetElement<ReferenceSequence>(0);
      }
      set
      {
        this.SetElement<ReferenceSequence>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "evalError" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "twoDigitTextYear" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "numberStoredAsText" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "formula" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "formulaRange" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "unlockedFormula" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "emptyCellReference" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "listDataValidation" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "calculatedColumn" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<IgnoredError>(deep);
    }
  }
}

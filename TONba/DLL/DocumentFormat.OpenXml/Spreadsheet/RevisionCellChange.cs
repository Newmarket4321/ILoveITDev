// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.RevisionCellChange
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (NewCell))]
  [ChildElementInfo(typeof (OldDifferentialFormat))]
  [ChildElementInfo(typeof (NewDifferentialFormat))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (OldCell))]
  [ChildElementInfo(typeof (ExtensionList))]
  public class RevisionCellChange : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[14]
    {
      "rId",
      "ua",
      "ra",
      "sId",
      "odxf",
      "xfDxf",
      "s",
      "dxf",
      "numFmtId",
      "quotePrefix",
      "oldQuotePrefix",
      "ph",
      "oldPh",
      "endOfListFormulaUpdate"
    };
    private static byte[] attributeNamespaceIds = new byte[14];
    private static readonly string[] eleTagNames = new string[5]
    {
      "oc",
      "nc",
      "odxf",
      "ndxf",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[5]
    {
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "rcc";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11224;

    public override string LocalName
    {
      get
      {
        return "rcc";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 22;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11224;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return RevisionCellChange.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return RevisionCellChange.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "rId")]
    public UInt32Value RevisionId
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

    [SchemaAttr(0, "ua")]
    public BooleanValue Ua
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

    [SchemaAttr(0, "ra")]
    public BooleanValue Ra
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

    [SchemaAttr(0, "sId")]
    public UInt32Value SheetId
    {
      get
      {
        return (UInt32Value) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "odxf")]
    public BooleanValue OldFormatting
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

    [SchemaAttr(0, "xfDxf")]
    public BooleanValue RowColumnFormattingAffected
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

    [SchemaAttr(0, "s")]
    public BooleanValue StyleRevision
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

    [SchemaAttr(0, "dxf")]
    public BooleanValue Format
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

    [SchemaAttr(0, "numFmtId")]
    public UInt32Value NumberFormatId
    {
      get
      {
        return (UInt32Value) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "quotePrefix")]
    public BooleanValue QuotePrefix
    {
      get
      {
        return (BooleanValue) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "oldQuotePrefix")]
    public BooleanValue OldQuotePrefix
    {
      get
      {
        return (BooleanValue) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "ph")]
    public BooleanValue HasPhoneticText
    {
      get
      {
        return (BooleanValue) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "oldPh")]
    public BooleanValue OldPhoneticText
    {
      get
      {
        return (BooleanValue) this.Attributes[12];
      }
      set
      {
        this.Attributes[12] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "endOfListFormulaUpdate")]
    public BooleanValue EndOfListFormulaUpdate
    {
      get
      {
        return (BooleanValue) this.Attributes[13];
      }
      set
      {
        this.Attributes[13] = (OpenXmlSimpleType) value;
      }
    }

    public RevisionCellChange()
    {
    }

    public RevisionCellChange(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public RevisionCellChange(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public RevisionCellChange(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "oc" == name)
        return (OpenXmlElement) new OldCell();
      if (22 == (int) namespaceId && "nc" == name)
        return (OpenXmlElement) new NewCell();
      if (22 == (int) namespaceId && "odxf" == name)
        return (OpenXmlElement) new OldDifferentialFormat();
      if (22 == (int) namespaceId && "ndxf" == name)
        return (OpenXmlElement) new NewDifferentialFormat();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return RevisionCellChange.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return RevisionCellChange.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public OldCell OldCell
    {
      get
      {
        return this.GetElement<OldCell>(0);
      }
      set
      {
        this.SetElement<OldCell>(0, value);
      }
    }

    public NewCell NewCell
    {
      get
      {
        return this.GetElement<NewCell>(1);
      }
      set
      {
        this.SetElement<NewCell>(1, value);
      }
    }

    public OldDifferentialFormat OldDifferentialFormat
    {
      get
      {
        return this.GetElement<OldDifferentialFormat>(2);
      }
      set
      {
        this.SetElement<OldDifferentialFormat>(2, value);
      }
    }

    public NewDifferentialFormat NewDifferentialFormat
    {
      get
      {
        return this.GetElement<NewDifferentialFormat>(3);
      }
      set
      {
        this.SetElement<NewDifferentialFormat>(3, value);
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
      if ((int) namespaceId == 0 && "rId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "ua" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "ra" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "sId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "odxf" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "xfDxf" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "s" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "dxf" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "numFmtId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "quotePrefix" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "oldQuotePrefix" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "ph" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "oldPh" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "endOfListFormulaUpdate" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<RevisionCellChange>(deep);
    }
  }
}

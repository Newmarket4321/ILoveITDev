// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.CellFormat
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (Alignment))]
  [ChildElementInfo(typeof (ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Protection))]
  public class CellFormat : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[13]
    {
      "numFmtId",
      "fontId",
      "fillId",
      "borderId",
      "xfId",
      "quotePrefix",
      "pivotButton",
      "applyNumberFormat",
      "applyFont",
      "applyFill",
      "applyBorder",
      "applyAlignment",
      "applyProtection"
    };
    private static byte[] attributeNamespaceIds = new byte[13];
    private static readonly string[] eleTagNames = new string[3]
    {
      "alignment",
      "protection",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 22,
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "xf";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11325;

    public override string LocalName
    {
      get
      {
        return "xf";
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
        return 11325;
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
        return CellFormat.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return CellFormat.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "numFmtId")]
    public UInt32Value NumberFormatId
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

    [SchemaAttr(0, "fontId")]
    public UInt32Value FontId
    {
      get
      {
        return (UInt32Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "fillId")]
    public UInt32Value FillId
    {
      get
      {
        return (UInt32Value) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "borderId")]
    public UInt32Value BorderId
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

    [SchemaAttr(0, "xfId")]
    public UInt32Value FormatId
    {
      get
      {
        return (UInt32Value) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "quotePrefix")]
    public BooleanValue QuotePrefix
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

    [SchemaAttr(0, "pivotButton")]
    public BooleanValue PivotButton
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

    [SchemaAttr(0, "applyNumberFormat")]
    public BooleanValue ApplyNumberFormat
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

    [SchemaAttr(0, "applyFont")]
    public BooleanValue ApplyFont
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

    [SchemaAttr(0, "applyFill")]
    public BooleanValue ApplyFill
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

    [SchemaAttr(0, "applyBorder")]
    public BooleanValue ApplyBorder
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

    [SchemaAttr(0, "applyAlignment")]
    public BooleanValue ApplyAlignment
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

    [SchemaAttr(0, "applyProtection")]
    public BooleanValue ApplyProtection
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

    public CellFormat()
    {
    }

    public CellFormat(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public CellFormat(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public CellFormat(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "alignment" == name)
        return (OpenXmlElement) new Alignment();
      if (22 == (int) namespaceId && "protection" == name)
        return (OpenXmlElement) new Protection();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return CellFormat.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return CellFormat.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Alignment Alignment
    {
      get
      {
        return this.GetElement<Alignment>(0);
      }
      set
      {
        this.SetElement<Alignment>(0, value);
      }
    }

    public Protection Protection
    {
      get
      {
        return this.GetElement<Protection>(1);
      }
      set
      {
        this.SetElement<Protection>(1, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(2);
      }
      set
      {
        this.SetElement<ExtensionList>(2, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "numFmtId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "fontId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "fillId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "borderId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "xfId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "quotePrefix" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "pivotButton" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "applyNumberFormat" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "applyFont" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "applyFill" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "applyBorder" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "applyAlignment" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "applyProtection" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<CellFormat>(deep);
    }
  }
}

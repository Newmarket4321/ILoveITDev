// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.NewCell
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ExtensionList))]
  [ChildElementInfo(typeof (CellFormula))]
  [ChildElementInfo(typeof (CellValue))]
  [ChildElementInfo(typeof (InlineString))]
  public class NewCell : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[6]
    {
      "r",
      "s",
      "t",
      "cm",
      "vm",
      "ph"
    };
    private static byte[] attributeNamespaceIds = new byte[6];
    private static readonly string[] eleTagNames = new string[4]
    {
      "f",
      "v",
      "is",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[4]
    {
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "nc";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11236;

    public override string LocalName
    {
      get
      {
        return "nc";
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
        return 11236;
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
        return NewCell.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return NewCell.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "r")]
    public StringValue CellReference
    {
      get
      {
        return (StringValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "s")]
    public UInt32Value StyleIndex
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

    [SchemaAttr(0, "t")]
    public EnumValue<CellValues> DataType
    {
      get
      {
        return (EnumValue<CellValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "cm")]
    public UInt32Value CellMetaIndex
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

    [SchemaAttr(0, "vm")]
    public UInt32Value ValueMetaIndex
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

    [SchemaAttr(0, "ph")]
    public BooleanValue ShowPhonetic
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

    public NewCell()
    {
    }

    public NewCell(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public NewCell(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public NewCell(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "f" == name)
        return (OpenXmlElement) new CellFormula();
      if (22 == (int) namespaceId && "v" == name)
        return (OpenXmlElement) new CellValue();
      if (22 == (int) namespaceId && "is" == name)
        return (OpenXmlElement) new InlineString();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return NewCell.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return NewCell.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public CellFormula CellFormula
    {
      get
      {
        return this.GetElement<CellFormula>(0);
      }
      set
      {
        this.SetElement<CellFormula>(0, value);
      }
    }

    public CellValue CellValue
    {
      get
      {
        return this.GetElement<CellValue>(1);
      }
      set
      {
        this.SetElement<CellValue>(1, value);
      }
    }

    public InlineString InlineString
    {
      get
      {
        return this.GetElement<InlineString>(2);
      }
      set
      {
        this.SetElement<InlineString>(2, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(3);
      }
      set
      {
        this.SetElement<ExtensionList>(3, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "r" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "s" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "t" == name)
        return (OpenXmlSimpleType) new EnumValue<CellValues>();
      if ((int) namespaceId == 0 && "cm" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "vm" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "ph" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<NewCell>(deep);
    }
  }
}

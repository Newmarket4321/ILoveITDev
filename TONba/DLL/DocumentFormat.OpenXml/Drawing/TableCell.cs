// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.TableCell
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (TextBody))]
  [ChildElementInfo(typeof (TableCellProperties))]
  [ChildElementInfo(typeof (ExtensionList))]
  public class TableCell : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "rowSpan",
      "gridSpan",
      "hMerge",
      "vMerge"
    };
    private static byte[] attributeNamespaceIds = new byte[4];
    private static readonly string[] eleTagNames = new string[3]
    {
      "txBody",
      "tcPr",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[3]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10
    };
    private const string tagName = "tc";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10255;

    public override string LocalName
    {
      get
      {
        return "tc";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 10;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10255;
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
        return TableCell.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TableCell.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "rowSpan")]
    public Int32Value RowSpan
    {
      get
      {
        return (Int32Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "gridSpan")]
    public Int32Value GridSpan
    {
      get
      {
        return (Int32Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "hMerge")]
    public BooleanValue HorizontalMerge
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

    [SchemaAttr(0, "vMerge")]
    public BooleanValue VerticalMerge
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

    public TableCell()
    {
    }

    public TableCell(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TableCell(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TableCell(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "txBody" == name)
        return (OpenXmlElement) new TextBody();
      if (10 == (int) namespaceId && "tcPr" == name)
        return (OpenXmlElement) new TableCellProperties();
      if (10 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TableCell.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TableCell.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public TextBody TextBody
    {
      get
      {
        return this.GetElement<TextBody>(0);
      }
      set
      {
        this.SetElement<TextBody>(0, value);
      }
    }

    public TableCellProperties TableCellProperties
    {
      get
      {
        return this.GetElement<TableCellProperties>(1);
      }
      set
      {
        this.SetElement<TableCellProperties>(1, value);
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
      if ((int) namespaceId == 0 && "rowSpan" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "gridSpan" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "hMerge" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "vMerge" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TableCell>(deep);
    }
  }
}

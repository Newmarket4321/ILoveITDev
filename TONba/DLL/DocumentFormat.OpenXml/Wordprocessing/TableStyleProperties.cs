// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (StyleParagraphProperties))]
  [ChildElementInfo(typeof (RunPropertiesBaseStyle))]
  [ChildElementInfo(typeof (TableStyleConditionalFormattingTableProperties))]
  [ChildElementInfo(typeof (TableStyleConditionalFormattingTableRowProperties))]
  [ChildElementInfo(typeof (TableStyleConditionalFormattingTableCellProperties))]
  public class TableStyleProperties : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "type"
    };
    private static byte[] attributeNamespaceIds = new byte[1]
    {
      (byte) 23
    };
    private static readonly string[] eleTagNames = new string[5]
    {
      "pPr",
      "rPr",
      "tblPr",
      "trPr",
      "tcPr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[5]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "tblStylePr";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11958;

    public override string LocalName
    {
      get
      {
        return "tblStylePr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11958;
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
        return TableStyleProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TableStyleProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "type")]
    public EnumValue<TableStyleOverrideValues> Type
    {
      get
      {
        return (EnumValue<TableStyleOverrideValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    public TableStyleProperties()
    {
    }

    public TableStyleProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TableStyleProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TableStyleProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "pPr" == name)
        return (OpenXmlElement) new StyleParagraphProperties();
      if (23 == (int) namespaceId && "rPr" == name)
        return (OpenXmlElement) new RunPropertiesBaseStyle();
      if (23 == (int) namespaceId && "tblPr" == name)
        return (OpenXmlElement) new TableStyleConditionalFormattingTableProperties();
      if (23 == (int) namespaceId && "trPr" == name)
        return (OpenXmlElement) new TableStyleConditionalFormattingTableRowProperties();
      if (23 == (int) namespaceId && "tcPr" == name)
        return (OpenXmlElement) new TableStyleConditionalFormattingTableCellProperties();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TableStyleProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TableStyleProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public StyleParagraphProperties StyleParagraphProperties
    {
      get
      {
        return this.GetElement<StyleParagraphProperties>(0);
      }
      set
      {
        this.SetElement<StyleParagraphProperties>(0, value);
      }
    }

    public RunPropertiesBaseStyle RunPropertiesBaseStyle
    {
      get
      {
        return this.GetElement<RunPropertiesBaseStyle>(1);
      }
      set
      {
        this.SetElement<RunPropertiesBaseStyle>(1, value);
      }
    }

    public TableStyleConditionalFormattingTableProperties TableStyleConditionalFormattingTableProperties
    {
      get
      {
        return this.GetElement<TableStyleConditionalFormattingTableProperties>(2);
      }
      set
      {
        this.SetElement<TableStyleConditionalFormattingTableProperties>(2, value);
      }
    }

    public TableStyleConditionalFormattingTableRowProperties TableStyleConditionalFormattingTableRowProperties
    {
      get
      {
        return this.GetElement<TableStyleConditionalFormattingTableRowProperties>(3);
      }
      set
      {
        this.SetElement<TableStyleConditionalFormattingTableRowProperties>(3, value);
      }
    }

    public TableStyleConditionalFormattingTableCellProperties TableStyleConditionalFormattingTableCellProperties
    {
      get
      {
        return this.GetElement<TableStyleConditionalFormattingTableCellProperties>(4);
      }
      set
      {
        this.SetElement<TableStyleConditionalFormattingTableCellProperties>(4, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "type" == name)
        return (OpenXmlSimpleType) new EnumValue<TableStyleOverrideValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TableStyleProperties>(deep);
    }
  }
}

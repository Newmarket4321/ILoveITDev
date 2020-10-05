// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.TableStyles
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (TableStyle))]
  [GeneratedCode("DomGen", "2.0")]
  public class TableStyles : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "count",
      "defaultTableStyle",
      "defaultPivotStyle"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private const string tagName = "tableStyles";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11515;

    public override string LocalName
    {
      get
      {
        return "tableStyles";
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
        return 11515;
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
        return TableStyles.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TableStyles.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "count")]
    public UInt32Value Count
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

    [SchemaAttr(0, "defaultTableStyle")]
    public StringValue DefaultTableStyle
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

    [SchemaAttr(0, "defaultPivotStyle")]
    public StringValue DefaultPivotStyle
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

    public TableStyles()
    {
    }

    public TableStyles(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TableStyles(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TableStyles(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "tableStyle" == name)
        return (OpenXmlElement) new TableStyle();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "count" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "defaultTableStyle" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "defaultPivotStyle" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TableStyles>(deep);
    }
  }
}

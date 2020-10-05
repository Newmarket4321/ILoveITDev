// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Excel.PivotTableData
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Excel
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (PivotRow), FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class PivotTableData : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "rowCount",
      "columnCount",
      "cacheId"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private const string tagName = "pivotTableData";
    private const byte tagNsId = 71;
    internal const int ElementTypeIdConst = 13377;

    public override string LocalName
    {
      get
      {
        return "pivotTableData";
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
        return 13377;
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
        return PivotTableData.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return PivotTableData.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "rowCount")]
    public UInt32Value RowCount
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

    [SchemaAttr(0, "columnCount")]
    public UInt32Value ColumnCount
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

    [SchemaAttr(0, "cacheId")]
    public UInt32Value CacheId
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

    public PivotTableData()
    {
    }

    public PivotTableData(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PivotTableData(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PivotTableData(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (71 == (int) namespaceId && "pivotRow" == name)
        return (OpenXmlElement) new PivotRow();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "rowCount" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "columnCount" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "cacheId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PivotTableData>(deep);
    }
  }
}

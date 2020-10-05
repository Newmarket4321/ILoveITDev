// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.Excel.RowSortMap
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office.Excel
{
  [ChildElementInfo(typeof (RowSortMapItem))]
  [GeneratedCode("DomGen", "2.0")]
  public class RowSortMap : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "ref",
      "count"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private const string tagName = "rowSortMap";
    private const byte tagNsId = 32;
    internal const int ElementTypeIdConst = 12604;

    public override string LocalName
    {
      get
      {
        return "rowSortMap";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 32;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12604;
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
        return RowSortMap.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return RowSortMap.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "ref")]
    public StringValue Ref
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

    [SchemaAttr(0, "count")]
    public UInt32Value Count
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

    public RowSortMap()
    {
    }

    public RowSortMap(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public RowSortMap(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public RowSortMap(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (32 == (int) namespaceId && "row" == name)
        return (OpenXmlElement) new RowSortMapItem();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "ref" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "count" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<RowSortMap>(deep);
    }
  }
}

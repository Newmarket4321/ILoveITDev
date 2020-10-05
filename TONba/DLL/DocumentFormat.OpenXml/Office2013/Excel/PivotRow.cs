// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Excel.PivotRow
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Excel
{
  [ChildElementInfo(typeof (PivotValueCell), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class PivotRow : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "r",
      "count"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private const string tagName = "pivotRow";
    private const byte tagNsId = 71;
    internal const int ElementTypeIdConst = 13430;

    public override string LocalName
    {
      get
      {
        return "pivotRow";
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
        return 13430;
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
        return PivotRow.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return PivotRow.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "r")]
    public UInt32Value Reference
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

    public PivotRow()
    {
    }

    public PivotRow(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PivotRow(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PivotRow(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (71 == (int) namespaceId && "c" == name)
        return (OpenXmlElement) new PivotValueCell();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "r" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "count" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PivotRow>(deep);
    }
  }
}

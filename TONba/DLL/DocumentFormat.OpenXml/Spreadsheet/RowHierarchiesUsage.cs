// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.RowHierarchiesUsage
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (RowHierarchyUsage))]
  public class RowHierarchiesUsage : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "count"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "rowHierarchiesUsage";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11485;

    public override string LocalName
    {
      get
      {
        return "rowHierarchiesUsage";
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
        return 11485;
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
        return RowHierarchiesUsage.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return RowHierarchiesUsage.attributeNamespaceIds;
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

    public RowHierarchiesUsage()
    {
    }

    public RowHierarchiesUsage(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public RowHierarchiesUsage(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public RowHierarchiesUsage(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "rowHierarchyUsage" == name)
        return (OpenXmlElement) new RowHierarchyUsage();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "count" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<RowHierarchiesUsage>(deep);
    }
  }
}

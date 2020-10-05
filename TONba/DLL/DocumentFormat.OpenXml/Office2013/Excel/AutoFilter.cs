// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Excel.AutoFilter
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Spreadsheet;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Excel
{
  [ChildElementInfo(typeof (FilterColumn))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Spreadsheet.ExtensionList))]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (SortState))]
  [GeneratedCode("DomGen", "2.0")]
  public class AutoFilter : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "ref"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private const string tagName = "autoFilter";
    private const byte tagNsId = 71;
    internal const int ElementTypeIdConst = 13427;

    public override string LocalName
    {
      get
      {
        return "autoFilter";
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
        return 13427;
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
        return AutoFilter.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return AutoFilter.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "ref")]
    public StringValue Reference
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

    public AutoFilter()
    {
    }

    public AutoFilter(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public AutoFilter(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public AutoFilter(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "filterColumn" == name)
        return (OpenXmlElement) new FilterColumn();
      if (22 == (int) namespaceId && "sortState" == name)
        return (OpenXmlElement) new SortState();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Spreadsheet.ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "ref" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<AutoFilter>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.SortState
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (SortCondition))]
  [ChildElementInfo(typeof (DocumentFormat.OpenXml.Office2010.Excel.SortCondition), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public class SortState : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "columnSort",
      "caseSensitive",
      "sortMethod",
      "ref"
    };
    private static byte[] attributeNamespaceIds = new byte[4];
    private const string tagName = "sortState";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11116;

    public override string LocalName
    {
      get
      {
        return "sortState";
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
        return 11116;
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
        return SortState.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return SortState.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "columnSort")]
    public BooleanValue ColumnSort
    {
      get
      {
        return (BooleanValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "caseSensitive")]
    public BooleanValue CaseSensitive
    {
      get
      {
        return (BooleanValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "sortMethod")]
    public EnumValue<SortMethodValues> SortMethod
    {
      get
      {
        return (EnumValue<SortMethodValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "ref")]
    public StringValue Reference
    {
      get
      {
        return (StringValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    public SortState()
    {
    }

    public SortState(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SortState(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SortState(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (53 == (int) namespaceId && "sortCondition" == name)
        return (OpenXmlElement) new DocumentFormat.OpenXml.Office2010.Excel.SortCondition();
      if (22 == (int) namespaceId && "sortCondition" == name)
        return (OpenXmlElement) new SortCondition();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "columnSort" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "caseSensitive" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "sortMethod" == name)
        return (OpenXmlSimpleType) new EnumValue<SortMethodValues>();
      if ((int) namespaceId == 0 && "ref" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SortState>(deep);
    }
  }
}

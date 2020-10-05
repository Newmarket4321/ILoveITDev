// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.TupleSet
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (SortByTuple))]
  [ChildElementInfo(typeof (Tuples))]
  [GeneratedCode("DomGen", "2.0")]
  public class TupleSet : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[5]
    {
      "count",
      "maxRank",
      "setDefinition",
      "sortType",
      "queryFailed"
    };
    private static byte[] attributeNamespaceIds = new byte[5];
    private const string tagName = "set";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11162;

    public override string LocalName
    {
      get
      {
        return "set";
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
        return 11162;
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
        return TupleSet.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TupleSet.attributeNamespaceIds;
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

    [SchemaAttr(0, "maxRank")]
    public Int32Value MaxRank
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

    [SchemaAttr(0, "setDefinition")]
    public StringValue SetDefinition
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

    [SchemaAttr(0, "sortType")]
    public EnumValue<SortValues> SortType
    {
      get
      {
        return (EnumValue<SortValues>) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "queryFailed")]
    public BooleanValue QueryFailed
    {
      get
      {
        return (BooleanValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    public TupleSet()
    {
    }

    public TupleSet(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TupleSet(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TupleSet(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "tpls" == name)
        return (OpenXmlElement) new Tuples();
      if (22 == (int) namespaceId && "sortByTuple" == name)
        return (OpenXmlElement) new SortByTuple();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "count" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "maxRank" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "setDefinition" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "sortType" == name)
        return (OpenXmlSimpleType) new EnumValue<SortValues>();
      if ((int) namespaceId == 0 && "queryFailed" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TupleSet>(deep);
    }
  }
}

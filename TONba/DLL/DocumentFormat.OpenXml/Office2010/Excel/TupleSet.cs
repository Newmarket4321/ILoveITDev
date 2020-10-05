// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.TupleSet
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (TupleSetHeaders), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (TupleSetRows), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public class TupleSet : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "rowCount",
      "columnCount"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private static readonly string[] eleTagNames = new string[2]
    {
      "headers",
      "rows"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 53,
      (byte) 53
    };
    private const string tagName = "tupleSet";
    private const byte tagNsId = 53;
    internal const int ElementTypeIdConst = 13017;

    public override string LocalName
    {
      get
      {
        return "tupleSet";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 53;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13017;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
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
      if (53 == (int) namespaceId && "headers" == name)
        return (OpenXmlElement) new TupleSetHeaders();
      if (53 == (int) namespaceId && "rows" == name)
        return (OpenXmlElement) new TupleSetRows();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TupleSet.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TupleSet.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public TupleSetHeaders TupleSetHeaders
    {
      get
      {
        return this.GetElement<TupleSetHeaders>(0);
      }
      set
      {
        this.SetElement<TupleSetHeaders>(0, value);
      }
    }

    public TupleSetRows TupleSetRows
    {
      get
      {
        return this.GetElement<TupleSetRows>(1);
      }
      set
      {
        this.SetElement<TupleSetRows>(1, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "rowCount" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "columnCount" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TupleSet>(deep);
    }
  }
}

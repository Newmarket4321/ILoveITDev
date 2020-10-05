// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.TableStyleType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (Band1Horizontal))]
  [ChildElementInfo(typeof (ExtensionList))]
  [ChildElementInfo(typeof (LastColumn))]
  [ChildElementInfo(typeof (FirstColumn))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (WholeTable))]
  [ChildElementInfo(typeof (Band2Horizontal))]
  [ChildElementInfo(typeof (Band1Vertical))]
  [ChildElementInfo(typeof (Band2Vertical))]
  [ChildElementInfo(typeof (TableBackground))]
  [ChildElementInfo(typeof (LastRow))]
  [ChildElementInfo(typeof (SoutheastCell))]
  [ChildElementInfo(typeof (SouthwestCell))]
  [ChildElementInfo(typeof (FirstRow))]
  [ChildElementInfo(typeof (NortheastCell))]
  [ChildElementInfo(typeof (NorthwestCell))]
  public abstract class TableStyleType : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "styleId",
      "styleName"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private static readonly string[] eleTagNames = new string[15]
    {
      "tblBg",
      "wholeTbl",
      "band1H",
      "band2H",
      "band1V",
      "band2V",
      "lastCol",
      "firstCol",
      "lastRow",
      "seCell",
      "swCell",
      "firstRow",
      "neCell",
      "nwCell",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[15]
    {
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10,
      (byte) 10
    };

    internal override string[] AttributeTagNames
    {
      get
      {
        return TableStyleType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TableStyleType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "styleId")]
    public StringValue StyleId
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

    [SchemaAttr(0, "styleName")]
    public StringValue StyleName
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

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "tblBg" == name)
        return (OpenXmlElement) new TableBackground();
      if (10 == (int) namespaceId && "wholeTbl" == name)
        return (OpenXmlElement) new WholeTable();
      if (10 == (int) namespaceId && "band1H" == name)
        return (OpenXmlElement) new Band1Horizontal();
      if (10 == (int) namespaceId && "band2H" == name)
        return (OpenXmlElement) new Band2Horizontal();
      if (10 == (int) namespaceId && "band1V" == name)
        return (OpenXmlElement) new Band1Vertical();
      if (10 == (int) namespaceId && "band2V" == name)
        return (OpenXmlElement) new Band2Vertical();
      if (10 == (int) namespaceId && "lastCol" == name)
        return (OpenXmlElement) new LastColumn();
      if (10 == (int) namespaceId && "firstCol" == name)
        return (OpenXmlElement) new FirstColumn();
      if (10 == (int) namespaceId && "lastRow" == name)
        return (OpenXmlElement) new LastRow();
      if (10 == (int) namespaceId && "seCell" == name)
        return (OpenXmlElement) new SoutheastCell();
      if (10 == (int) namespaceId && "swCell" == name)
        return (OpenXmlElement) new SouthwestCell();
      if (10 == (int) namespaceId && "firstRow" == name)
        return (OpenXmlElement) new FirstRow();
      if (10 == (int) namespaceId && "neCell" == name)
        return (OpenXmlElement) new NortheastCell();
      if (10 == (int) namespaceId && "nwCell" == name)
        return (OpenXmlElement) new NorthwestCell();
      if (10 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TableStyleType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TableStyleType.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public TableBackground TableBackground
    {
      get
      {
        return this.GetElement<TableBackground>(0);
      }
      set
      {
        this.SetElement<TableBackground>(0, value);
      }
    }

    public WholeTable WholeTable
    {
      get
      {
        return this.GetElement<WholeTable>(1);
      }
      set
      {
        this.SetElement<WholeTable>(1, value);
      }
    }

    public Band1Horizontal Band1Horizontal
    {
      get
      {
        return this.GetElement<Band1Horizontal>(2);
      }
      set
      {
        this.SetElement<Band1Horizontal>(2, value);
      }
    }

    public Band2Horizontal Band2Horizontal
    {
      get
      {
        return this.GetElement<Band2Horizontal>(3);
      }
      set
      {
        this.SetElement<Band2Horizontal>(3, value);
      }
    }

    public Band1Vertical Band1Vertical
    {
      get
      {
        return this.GetElement<Band1Vertical>(4);
      }
      set
      {
        this.SetElement<Band1Vertical>(4, value);
      }
    }

    public Band2Vertical Band2Vertical
    {
      get
      {
        return this.GetElement<Band2Vertical>(5);
      }
      set
      {
        this.SetElement<Band2Vertical>(5, value);
      }
    }

    public LastColumn LastColumn
    {
      get
      {
        return this.GetElement<LastColumn>(6);
      }
      set
      {
        this.SetElement<LastColumn>(6, value);
      }
    }

    public FirstColumn FirstColumn
    {
      get
      {
        return this.GetElement<FirstColumn>(7);
      }
      set
      {
        this.SetElement<FirstColumn>(7, value);
      }
    }

    public LastRow LastRow
    {
      get
      {
        return this.GetElement<LastRow>(8);
      }
      set
      {
        this.SetElement<LastRow>(8, value);
      }
    }

    public SoutheastCell SoutheastCell
    {
      get
      {
        return this.GetElement<SoutheastCell>(9);
      }
      set
      {
        this.SetElement<SoutheastCell>(9, value);
      }
    }

    public SouthwestCell SouthwestCell
    {
      get
      {
        return this.GetElement<SouthwestCell>(10);
      }
      set
      {
        this.SetElement<SouthwestCell>(10, value);
      }
    }

    public FirstRow FirstRow
    {
      get
      {
        return this.GetElement<FirstRow>(11);
      }
      set
      {
        this.SetElement<FirstRow>(11, value);
      }
    }

    public NortheastCell NortheastCell
    {
      get
      {
        return this.GetElement<NortheastCell>(12);
      }
      set
      {
        this.SetElement<NortheastCell>(12, value);
      }
    }

    public NorthwestCell NorthwestCell
    {
      get
      {
        return this.GetElement<NorthwestCell>(13);
      }
      set
      {
        this.SetElement<NorthwestCell>(13, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(14);
      }
      set
      {
        this.SetElement<ExtensionList>(14, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "styleId" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "styleName" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    protected TableStyleType()
    {
    }

    protected TableStyleType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected TableStyleType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected TableStyleType(string outerXml)
      : base(outerXml)
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.TableCellPropertiesChange
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (PreviousTableCellProperties))]
  public class TableCellPropertiesChange : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "author",
      "date",
      "id"
    };
    private static byte[] attributeNamespaceIds = new byte[3]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private static readonly string[] eleTagNames = new string[1]
    {
      "tcPr"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 23
    };
    private const string tagName = "tcPrChange";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11844;

    public override string LocalName
    {
      get
      {
        return "tcPrChange";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11844;
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
        return TableCellPropertiesChange.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TableCellPropertiesChange.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "author")]
    public StringValue Author
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

    [SchemaAttr(23, "date")]
    public DateTimeValue Date
    {
      get
      {
        return (DateTimeValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "id")]
    public StringValue Id
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

    public TableCellPropertiesChange()
    {
    }

    public TableCellPropertiesChange(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TableCellPropertiesChange(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TableCellPropertiesChange(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "tcPr" == name)
        return (OpenXmlElement) new PreviousTableCellProperties();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return TableCellPropertiesChange.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return TableCellPropertiesChange.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public PreviousTableCellProperties PreviousTableCellProperties
    {
      get
      {
        return this.GetElement<PreviousTableCellProperties>(0);
      }
      set
      {
        this.SetElement<PreviousTableCellProperties>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "author" == name)
        return (OpenXmlSimpleType) new StringValue();
      if (23 == (int) namespaceId && "date" == name)
        return (OpenXmlSimpleType) new DateTimeValue();
      if (23 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TableCellPropertiesChange>(deep);
    }
  }
}

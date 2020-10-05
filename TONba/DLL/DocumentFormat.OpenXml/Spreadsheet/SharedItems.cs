// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.SharedItems
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (NumberItem))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (BooleanItem))]
  [ChildElementInfo(typeof (MissingItem))]
  [ChildElementInfo(typeof (ErrorItem))]
  [ChildElementInfo(typeof (StringItem))]
  [ChildElementInfo(typeof (DateTimeItem))]
  public class SharedItems : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[14]
    {
      "containsSemiMixedTypes",
      "containsNonDate",
      "containsDate",
      "containsString",
      "containsBlank",
      "containsMixedTypes",
      "containsNumber",
      "containsInteger",
      "minValue",
      "maxValue",
      "minDate",
      "maxDate",
      "count",
      "longText"
    };
    private static byte[] attributeNamespaceIds = new byte[14];
    private const string tagName = "sharedItems";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11460;

    public override string LocalName
    {
      get
      {
        return "sharedItems";
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
        return 11460;
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
        return SharedItems.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return SharedItems.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "containsSemiMixedTypes")]
    public BooleanValue ContainsSemiMixedTypes
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

    [SchemaAttr(0, "containsNonDate")]
    public BooleanValue ContainsNonDate
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

    [SchemaAttr(0, "containsDate")]
    public BooleanValue ContainsDate
    {
      get
      {
        return (BooleanValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "containsString")]
    public BooleanValue ContainsString
    {
      get
      {
        return (BooleanValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "containsBlank")]
    public BooleanValue ContainsBlank
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

    [SchemaAttr(0, "containsMixedTypes")]
    public BooleanValue ContainsMixedTypes
    {
      get
      {
        return (BooleanValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "containsNumber")]
    public BooleanValue ContainsNumber
    {
      get
      {
        return (BooleanValue) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "containsInteger")]
    public BooleanValue ContainsInteger
    {
      get
      {
        return (BooleanValue) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "minValue")]
    public DoubleValue MinValue
    {
      get
      {
        return (DoubleValue) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "maxValue")]
    public DoubleValue MaxValue
    {
      get
      {
        return (DoubleValue) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "minDate")]
    public DateTimeValue MinDate
    {
      get
      {
        return (DateTimeValue) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "maxDate")]
    public DateTimeValue MaxDate
    {
      get
      {
        return (DateTimeValue) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "count")]
    public UInt32Value Count
    {
      get
      {
        return (UInt32Value) this.Attributes[12];
      }
      set
      {
        this.Attributes[12] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "longText")]
    public BooleanValue LongText
    {
      get
      {
        return (BooleanValue) this.Attributes[13];
      }
      set
      {
        this.Attributes[13] = (OpenXmlSimpleType) value;
      }
    }

    public SharedItems()
    {
    }

    public SharedItems(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SharedItems(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SharedItems(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "m" == name)
        return (OpenXmlElement) new MissingItem();
      if (22 == (int) namespaceId && "n" == name)
        return (OpenXmlElement) new NumberItem();
      if (22 == (int) namespaceId && "b" == name)
        return (OpenXmlElement) new BooleanItem();
      if (22 == (int) namespaceId && "e" == name)
        return (OpenXmlElement) new ErrorItem();
      if (22 == (int) namespaceId && "s" == name)
        return (OpenXmlElement) new StringItem();
      if (22 == (int) namespaceId && "d" == name)
        return (OpenXmlElement) new DateTimeItem();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "containsSemiMixedTypes" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "containsNonDate" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "containsDate" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "containsString" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "containsBlank" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "containsMixedTypes" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "containsNumber" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "containsInteger" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "minValue" == name)
        return (OpenXmlSimpleType) new DoubleValue();
      if ((int) namespaceId == 0 && "maxValue" == name)
        return (OpenXmlSimpleType) new DoubleValue();
      if ((int) namespaceId == 0 && "minDate" == name)
        return (OpenXmlSimpleType) new DateTimeValue();
      if ((int) namespaceId == 0 && "maxDate" == name)
        return (OpenXmlSimpleType) new DateTimeValue();
      if ((int) namespaceId == 0 && "count" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "longText" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SharedItems>(deep);
    }
  }
}

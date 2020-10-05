// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.DataBar
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
  [ChildElementInfo(typeof (FillColor), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ConditionalFormattingValueObject), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (BarAxisColor), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (BorderColor), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (NegativeFillColor), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (NegativeBorderColor), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [GeneratedCode("DomGen", "2.0")]
  public class DataBar : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[9]
    {
      "minLength",
      "maxLength",
      "showValue",
      "border",
      "gradient",
      "direction",
      "negativeBarColorSameAsPositive",
      "negativeBarBorderColorSameAsPositive",
      "axisPosition"
    };
    private static byte[] attributeNamespaceIds = new byte[9];
    private const string tagName = "dataBar";
    private const byte tagNsId = 53;
    internal const int ElementTypeIdConst = 13026;

    public override string LocalName
    {
      get
      {
        return "dataBar";
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
        return 13026;
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
        return DataBar.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return DataBar.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "minLength")]
    public UInt32Value MinLength
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

    [SchemaAttr(0, "maxLength")]
    public UInt32Value MaxLength
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

    [SchemaAttr(0, "showValue")]
    public BooleanValue ShowValue
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

    [SchemaAttr(0, "border")]
    public BooleanValue Border
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

    [SchemaAttr(0, "gradient")]
    public BooleanValue Gradient
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

    [SchemaAttr(0, "direction")]
    public EnumValue<DataBarDirectionValues> Direction
    {
      get
      {
        return (EnumValue<DataBarDirectionValues>) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "negativeBarColorSameAsPositive")]
    public BooleanValue NegativeBarColorSameAsPositive
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

    [SchemaAttr(0, "negativeBarBorderColorSameAsPositive")]
    public BooleanValue NegativeBarBorderColorSameAsPositive
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

    [SchemaAttr(0, "axisPosition")]
    public EnumValue<DataBarAxisPositionValues> AxisPosition
    {
      get
      {
        return (EnumValue<DataBarAxisPositionValues>) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    public DataBar()
    {
    }

    public DataBar(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DataBar(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DataBar(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (53 == (int) namespaceId && "cfvo" == name)
        return (OpenXmlElement) new ConditionalFormattingValueObject();
      if (53 == (int) namespaceId && "fillColor" == name)
        return (OpenXmlElement) new FillColor();
      if (53 == (int) namespaceId && "borderColor" == name)
        return (OpenXmlElement) new BorderColor();
      if (53 == (int) namespaceId && "negativeFillColor" == name)
        return (OpenXmlElement) new NegativeFillColor();
      if (53 == (int) namespaceId && "negativeBorderColor" == name)
        return (OpenXmlElement) new NegativeBorderColor();
      if (53 == (int) namespaceId && "axisColor" == name)
        return (OpenXmlElement) new BarAxisColor();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "minLength" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "maxLength" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "showValue" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "border" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "gradient" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "direction" == name)
        return (OpenXmlSimpleType) new EnumValue<DataBarDirectionValues>();
      if ((int) namespaceId == 0 && "negativeBarColorSameAsPositive" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "negativeBarBorderColorSameAsPositive" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "axisPosition" == name)
        return (OpenXmlSimpleType) new EnumValue<DataBarAxisPositionValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DataBar>(deep);
    }
  }
}

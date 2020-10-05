// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.IconSet
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
  [ChildElementInfo(typeof (ConditionalFormattingValueObject), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (ConditionalFormattingIcon), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  public class IconSet : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[5]
    {
      "iconSet",
      "showValue",
      "percent",
      "reverse",
      "custom"
    };
    private static byte[] attributeNamespaceIds = new byte[5];
    private const string tagName = "iconSet";
    private const byte tagNsId = 53;
    internal const int ElementTypeIdConst = 13027;

    public override string LocalName
    {
      get
      {
        return "iconSet";
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
        return 13027;
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
        return IconSet.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return IconSet.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "iconSet")]
    public EnumValue<IconSetTypeValues> IconSetTypes
    {
      get
      {
        return (EnumValue<IconSetTypeValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "showValue")]
    public BooleanValue ShowValue
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

    [SchemaAttr(0, "percent")]
    public BooleanValue Percent
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

    [SchemaAttr(0, "reverse")]
    public BooleanValue Reverse
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

    [SchemaAttr(0, "custom")]
    public BooleanValue Custom
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

    public IconSet()
    {
    }

    public IconSet(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public IconSet(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public IconSet(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (53 == (int) namespaceId && "cfvo" == name)
        return (OpenXmlElement) new ConditionalFormattingValueObject();
      if (53 == (int) namespaceId && "cfIcon" == name)
        return (OpenXmlElement) new ConditionalFormattingIcon();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "iconSet" == name)
        return (OpenXmlSimpleType) new EnumValue<IconSetTypeValues>();
      if ((int) namespaceId == 0 && "showValue" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "percent" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "reverse" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "custom" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<IconSet>(deep);
    }
  }
}

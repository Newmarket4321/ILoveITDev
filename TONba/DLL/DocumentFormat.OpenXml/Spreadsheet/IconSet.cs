// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.IconSet
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ConditionalFormatValueObject))]
  public class IconSet : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "iconSet",
      "showValue",
      "percent",
      "reverse"
    };
    private static byte[] attributeNamespaceIds = new byte[4];
    private const string tagName = "iconSet";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11400;

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
        return 22;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11400;
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
    public EnumValue<IconSetValues> IconSetValue
    {
      get
      {
        return (EnumValue<IconSetValues>) this.Attributes[0];
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
      if (22 == (int) namespaceId && "cfvo" == name)
        return (OpenXmlElement) new ConditionalFormatValueObject();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "iconSet" == name)
        return (OpenXmlSimpleType) new EnumValue<IconSetValues>();
      if ((int) namespaceId == 0 && "showValue" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "percent" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "reverse" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<IconSet>(deep);
    }
  }
}

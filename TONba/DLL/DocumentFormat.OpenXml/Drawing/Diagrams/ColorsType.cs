// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.Diagrams.ColorsType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing.Diagrams
{
  [ChildElementInfo(typeof (RgbColorModelPercentage))]
  [ChildElementInfo(typeof (SystemColor))]
  [ChildElementInfo(typeof (SchemeColor))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (RgbColorModelHex))]
  [ChildElementInfo(typeof (HslColor))]
  [ChildElementInfo(typeof (PresetColor))]
  public abstract class ColorsType : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "meth",
      "hueDir"
    };
    private static byte[] attributeNamespaceIds = new byte[2];

    internal override string[] AttributeTagNames
    {
      get
      {
        return ColorsType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ColorsType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "meth")]
    public EnumValue<ColorApplicationMethodValues> Method
    {
      get
      {
        return (EnumValue<ColorApplicationMethodValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "hueDir")]
    public EnumValue<HueDirectionValues> HueDirection
    {
      get
      {
        return (EnumValue<HueDirectionValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "scrgbClr" == name)
        return (OpenXmlElement) new RgbColorModelPercentage();
      if (10 == (int) namespaceId && "srgbClr" == name)
        return (OpenXmlElement) new RgbColorModelHex();
      if (10 == (int) namespaceId && "hslClr" == name)
        return (OpenXmlElement) new HslColor();
      if (10 == (int) namespaceId && "sysClr" == name)
        return (OpenXmlElement) new SystemColor();
      if (10 == (int) namespaceId && "schemeClr" == name)
        return (OpenXmlElement) new SchemeColor();
      if (10 == (int) namespaceId && "prstClr" == name)
        return (OpenXmlElement) new PresetColor();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "meth" == name)
        return (OpenXmlSimpleType) new EnumValue<ColorApplicationMethodValues>();
      if ((int) namespaceId == 0 && "hueDir" == name)
        return (OpenXmlSimpleType) new EnumValue<HueDirectionValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    protected ColorsType()
    {
    }

    protected ColorsType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected ColorsType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected ColorsType(string outerXml)
      : base(outerXml)
    {
    }
  }
}

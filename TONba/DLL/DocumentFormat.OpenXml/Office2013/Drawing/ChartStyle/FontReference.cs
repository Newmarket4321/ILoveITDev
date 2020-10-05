// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle
{
  [ChildElementInfo(typeof (SchemeColor))]
  [ChildElementInfo(typeof (RgbColorModelPercentage))]
  [ChildElementInfo(typeof (RgbColorModelHex))]
  [ChildElementInfo(typeof (HslColor))]
  [ChildElementInfo(typeof (SystemColor))]
  [ChildElementInfo(typeof (PresetColor))]
  [ChildElementInfo(typeof (StyleColor), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class FontReference : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "idx",
      "mods"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private const string tagName = "fontRef";
    private const byte tagNsId = 65;
    internal const int ElementTypeIdConst = 13265;

    public override string LocalName
    {
      get
      {
        return "fontRef";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 65;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13265;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return FontReference.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return FontReference.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "idx")]
    public EnumValue<FontCollectionIndexValues> Index
    {
      get
      {
        return (EnumValue<FontCollectionIndexValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "mods")]
    public ListValue<StringValue> Modifiers
    {
      get
      {
        return (ListValue<StringValue>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    public FontReference()
    {
    }

    public FontReference(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public FontReference(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public FontReference(string outerXml)
      : base(outerXml)
    {
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
      if (65 == (int) namespaceId && "styleClr" == name)
        return (OpenXmlElement) new StyleColor();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "idx" == name)
        return (OpenXmlSimpleType) new EnumValue<FontCollectionIndexValues>();
      if ((int) namespaceId == 0 && "mods" == name)
        return (OpenXmlSimpleType) new ListValue<StringValue>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<FontReference>(deep);
    }
  }
}

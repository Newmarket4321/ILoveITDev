// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyle
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle
{
  [ChildElementInfo(typeof (RgbColorModelHex))]
  [ChildElementInfo(typeof (RgbColorModelPercentage))]
  [ChildElementInfo(typeof (HslColor))]
  [ChildElementInfo(typeof (SystemColor))]
  [ChildElementInfo(typeof (SchemeColor))]
  [ChildElementInfo(typeof (PresetColor))]
  [ChildElementInfo(typeof (ColorStyleVariation), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (OfficeArtExtensionList), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class ColorStyle : OpenXmlPartRootElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "meth",
      "id"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private const string tagName = "colorStyle";
    private const byte tagNsId = 65;
    internal const int ElementTypeIdConst = 13256;

    public override string LocalName
    {
      get
      {
        return "colorStyle";
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
        return 13256;
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
        return ColorStyle.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return ColorStyle.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "meth")]
    public StringValue Method
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

    [SchemaAttr(0, "id")]
    public UInt32Value Id
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

    internal ColorStyle(ChartColorStylePart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(ChartColorStylePart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public ChartColorStylePart ChartColorStylePart
    {
      get
      {
        return this.OpenXmlPart as ChartColorStylePart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public ColorStyle(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ColorStyle(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ColorStyle(string outerXml)
      : base(outerXml)
    {
    }

    public ColorStyle()
    {
    }

    public void Save(ChartColorStylePart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
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
      if (65 == (int) namespaceId && "variation" == name)
        return (OpenXmlElement) new ColorStyleVariation();
      if (65 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new OfficeArtExtensionList();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "meth" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "id" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ColorStyle>(deep);
    }
  }
}

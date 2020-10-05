// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Word.SchemeColor
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.Word
{
  [ChildElementInfo(typeof (Shade), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Tint), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Alpha), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (HueModulation), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Saturation), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (SaturationOffset), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (SaturationModulation), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Luminance), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (LuminanceOffset), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (LuminanceModulation), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [GeneratedCode("DomGen", "2.0")]
  public class SchemeColor : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "val"
    };
    private static byte[] attributeNamespaceIds = new byte[1]
    {
      (byte) 52
    };
    private const string tagName = "schemeClr";
    private const byte tagNsId = 52;
    internal const int ElementTypeIdConst = 12910;

    public override string LocalName
    {
      get
      {
        return "schemeClr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 52;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12910;
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
        return SchemeColor.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return SchemeColor.attributeNamespaceIds;
      }
    }

    [SchemaAttr(52, "val")]
    public EnumValue<SchemeColorValues> Val
    {
      get
      {
        return (EnumValue<SchemeColorValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    public SchemeColor()
    {
    }

    public SchemeColor(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SchemeColor(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SchemeColor(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (52 == (int) namespaceId && "tint" == name)
        return (OpenXmlElement) new Tint();
      if (52 == (int) namespaceId && "shade" == name)
        return (OpenXmlElement) new Shade();
      if (52 == (int) namespaceId && "alpha" == name)
        return (OpenXmlElement) new Alpha();
      if (52 == (int) namespaceId && "hueMod" == name)
        return (OpenXmlElement) new HueModulation();
      if (52 == (int) namespaceId && "sat" == name)
        return (OpenXmlElement) new Saturation();
      if (52 == (int) namespaceId && "satOff" == name)
        return (OpenXmlElement) new SaturationOffset();
      if (52 == (int) namespaceId && "satMod" == name)
        return (OpenXmlElement) new SaturationModulation();
      if (52 == (int) namespaceId && "lum" == name)
        return (OpenXmlElement) new Luminance();
      if (52 == (int) namespaceId && "lumOff" == name)
        return (OpenXmlElement) new LuminanceOffset();
      if (52 == (int) namespaceId && "lumMod" == name)
        return (OpenXmlElement) new LuminanceModulation();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (52 == (int) namespaceId && "val" == name)
        return (OpenXmlSimpleType) new EnumValue<SchemeColorValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SchemeColor>(deep);
    }
  }
}

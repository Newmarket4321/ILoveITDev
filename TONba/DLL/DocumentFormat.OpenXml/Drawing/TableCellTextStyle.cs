// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.TableCellTextStyle
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [ChildElementInfo(typeof (HslColor))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (RgbColorModelHex))]
  [ChildElementInfo(typeof (ExtensionList))]
  [ChildElementInfo(typeof (FontReference))]
  [ChildElementInfo(typeof (RgbColorModelPercentage))]
  [ChildElementInfo(typeof (Fonts))]
  [ChildElementInfo(typeof (SystemColor))]
  [ChildElementInfo(typeof (SchemeColor))]
  [ChildElementInfo(typeof (PresetColor))]
  public class TableCellTextStyle : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "b",
      "i"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private const string tagName = "tcTxStyle";
    private const byte tagNsId = 10;
    internal const int ElementTypeIdConst = 10272;

    public override string LocalName
    {
      get
      {
        return "tcTxStyle";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 10;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10272;
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
        return TableCellTextStyle.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TableCellTextStyle.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "b")]
    public EnumValue<BooleanStyleValues> Bold
    {
      get
      {
        return (EnumValue<BooleanStyleValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "i")]
    public EnumValue<BooleanStyleValues> Italic
    {
      get
      {
        return (EnumValue<BooleanStyleValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    public TableCellTextStyle()
    {
    }

    public TableCellTextStyle(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public TableCellTextStyle(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public TableCellTextStyle(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "font" == name)
        return (OpenXmlElement) new Fonts();
      if (10 == (int) namespaceId && "fontRef" == name)
        return (OpenXmlElement) new FontReference();
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
      if (10 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "b" == name)
        return (OpenXmlSimpleType) new EnumValue<BooleanStyleValues>();
      if ((int) namespaceId == 0 && "i" == name)
        return (OpenXmlSimpleType) new EnumValue<BooleanStyleValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TableCellTextStyle>(deep);
    }
  }
}

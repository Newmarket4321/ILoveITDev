// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.PrintingProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  public class PrintingProperties : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[5]
    {
      "prnWhat",
      "clrMode",
      "hiddenSlides",
      "scaleToFitPaper",
      "frameSlides"
    };
    private static byte[] attributeNamespaceIds = new byte[5];
    private static readonly string[] eleTagNames = new string[1]
    {
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 24
    };
    private const string tagName = "prnPr";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12428;

    public override string LocalName
    {
      get
      {
        return "prnPr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 24;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12428;
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
        return PrintingProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return PrintingProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "prnWhat")]
    public EnumValue<PrintOutputValues> PrintWhat
    {
      get
      {
        return (EnumValue<PrintOutputValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "clrMode")]
    public EnumValue<PrintColorModeValues> ColorMode
    {
      get
      {
        return (EnumValue<PrintColorModeValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "hiddenSlides")]
    public BooleanValue HiddenSlides
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

    [SchemaAttr(0, "scaleToFitPaper")]
    public BooleanValue ScaleToFitPaper
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

    [SchemaAttr(0, "frameSlides")]
    public BooleanValue FrameSlides
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

    public PrintingProperties()
    {
    }

    public PrintingProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public PrintingProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public PrintingProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return PrintingProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return PrintingProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(0);
      }
      set
      {
        this.SetElement<ExtensionList>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "prnWhat" == name)
        return (OpenXmlSimpleType) new EnumValue<PrintOutputValues>();
      if ((int) namespaceId == 0 && "clrMode" == name)
        return (OpenXmlSimpleType) new EnumValue<PrintColorModeValues>();
      if ((int) namespaceId == 0 && "hiddenSlides" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "scaleToFitPaper" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "frameSlides" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PrintingProperties>(deep);
    }
  }
}

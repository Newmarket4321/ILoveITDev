// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.PageSetup
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  public class PageSetup : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[17]
    {
      "paperSize",
      "scale",
      "firstPageNumber",
      "fitToWidth",
      "fitToHeight",
      "pageOrder",
      "orientation",
      "usePrinterDefaults",
      "blackAndWhite",
      "draft",
      "cellComments",
      "useFirstPageNumber",
      "errors",
      "horizontalDpi",
      "verticalDpi",
      "copies",
      "id"
    };
    private static byte[] attributeNamespaceIds = new byte[17]
    {
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 19
    };
    private const string tagName = "pageSetup";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11261;

    public override string LocalName
    {
      get
      {
        return "pageSetup";
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
        return 11261;
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
        return PageSetup.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return PageSetup.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "paperSize")]
    public UInt32Value PaperSize
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

    [SchemaAttr(0, "scale")]
    public UInt32Value Scale
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

    [SchemaAttr(0, "firstPageNumber")]
    public UInt32Value FirstPageNumber
    {
      get
      {
        return (UInt32Value) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "fitToWidth")]
    public UInt32Value FitToWidth
    {
      get
      {
        return (UInt32Value) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "fitToHeight")]
    public UInt32Value FitToHeight
    {
      get
      {
        return (UInt32Value) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "pageOrder")]
    public EnumValue<PageOrderValues> PageOrder
    {
      get
      {
        return (EnumValue<PageOrderValues>) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "orientation")]
    public EnumValue<OrientationValues> Orientation
    {
      get
      {
        return (EnumValue<OrientationValues>) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "usePrinterDefaults")]
    public BooleanValue UsePrinterDefaults
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

    [SchemaAttr(0, "blackAndWhite")]
    public BooleanValue BlackAndWhite
    {
      get
      {
        return (BooleanValue) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "draft")]
    public BooleanValue Draft
    {
      get
      {
        return (BooleanValue) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "cellComments")]
    public EnumValue<CellCommentsValues> CellComments
    {
      get
      {
        return (EnumValue<CellCommentsValues>) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "useFirstPageNumber")]
    public BooleanValue UseFirstPageNumber
    {
      get
      {
        return (BooleanValue) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "errors")]
    public EnumValue<PrintErrorValues> Errors
    {
      get
      {
        return (EnumValue<PrintErrorValues>) this.Attributes[12];
      }
      set
      {
        this.Attributes[12] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "horizontalDpi")]
    public UInt32Value HorizontalDpi
    {
      get
      {
        return (UInt32Value) this.Attributes[13];
      }
      set
      {
        this.Attributes[13] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "verticalDpi")]
    public UInt32Value VerticalDpi
    {
      get
      {
        return (UInt32Value) this.Attributes[14];
      }
      set
      {
        this.Attributes[14] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "copies")]
    public UInt32Value Copies
    {
      get
      {
        return (UInt32Value) this.Attributes[15];
      }
      set
      {
        this.Attributes[15] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(19, "id")]
    public StringValue Id
    {
      get
      {
        return (StringValue) this.Attributes[16];
      }
      set
      {
        this.Attributes[16] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "paperSize" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "scale" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "firstPageNumber" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "fitToWidth" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "fitToHeight" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "pageOrder" == name)
        return (OpenXmlSimpleType) new EnumValue<PageOrderValues>();
      if ((int) namespaceId == 0 && "orientation" == name)
        return (OpenXmlSimpleType) new EnumValue<OrientationValues>();
      if ((int) namespaceId == 0 && "usePrinterDefaults" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "blackAndWhite" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "draft" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "cellComments" == name)
        return (OpenXmlSimpleType) new EnumValue<CellCommentsValues>();
      if ((int) namespaceId == 0 && "useFirstPageNumber" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "errors" == name)
        return (OpenXmlSimpleType) new EnumValue<PrintErrorValues>();
      if ((int) namespaceId == 0 && "horizontalDpi" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "verticalDpi" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "copies" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if (19 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PageSetup>(deep);
    }
  }
}

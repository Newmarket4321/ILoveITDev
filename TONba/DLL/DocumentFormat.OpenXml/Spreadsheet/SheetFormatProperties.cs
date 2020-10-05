// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.SheetFormatProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  public class SheetFormatProperties : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[10]
    {
      "baseColWidth",
      "defaultColWidth",
      "defaultRowHeight",
      "customHeight",
      "zeroHeight",
      "thickTop",
      "thickBottom",
      "outlineLevelRow",
      "outlineLevelCol",
      "dyDescent"
    };
    private static byte[] attributeNamespaceIds = new byte[10]
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
      (byte) 55
    };
    private const string tagName = "sheetFormatPr";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11406;

    public override string LocalName
    {
      get
      {
        return "sheetFormatPr";
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
        return 11406;
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
        return SheetFormatProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return SheetFormatProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "baseColWidth")]
    public UInt32Value BaseColumnWidth
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

    [SchemaAttr(0, "defaultColWidth")]
    public DoubleValue DefaultColumnWidth
    {
      get
      {
        return (DoubleValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "defaultRowHeight")]
    public DoubleValue DefaultRowHeight
    {
      get
      {
        return (DoubleValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "customHeight")]
    public BooleanValue CustomHeight
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

    [SchemaAttr(0, "zeroHeight")]
    public BooleanValue ZeroHeight
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

    [SchemaAttr(0, "thickTop")]
    public BooleanValue ThickTop
    {
      get
      {
        return (BooleanValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "thickBottom")]
    public BooleanValue ThickBottom
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

    [SchemaAttr(0, "outlineLevelRow")]
    public ByteValue OutlineLevelRow
    {
      get
      {
        return (ByteValue) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "outlineLevelCol")]
    public ByteValue OutlineLevelColumn
    {
      get
      {
        return (ByteValue) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(55, "dyDescent")]
    public DoubleValue DyDescent
    {
      get
      {
        return (DoubleValue) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "baseColWidth" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "defaultColWidth" == name)
        return (OpenXmlSimpleType) new DoubleValue();
      if ((int) namespaceId == 0 && "defaultRowHeight" == name)
        return (OpenXmlSimpleType) new DoubleValue();
      if ((int) namespaceId == 0 && "customHeight" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "zeroHeight" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "thickTop" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "thickBottom" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "outlineLevelRow" == name)
        return (OpenXmlSimpleType) new ByteValue();
      if ((int) namespaceId == 0 && "outlineLevelCol" == name)
        return (OpenXmlSimpleType) new ByteValue();
      if (55 == (int) namespaceId && "dyDescent" == name)
        return (OpenXmlSimpleType) new DoubleValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SheetFormatProperties>(deep);
    }
  }
}

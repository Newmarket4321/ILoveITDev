// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public class TablePositionProperties : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[10]
    {
      "leftFromText",
      "rightFromText",
      "topFromText",
      "bottomFromText",
      "vertAnchor",
      "horzAnchor",
      "tblpXSpec",
      "tblpX",
      "tblpYSpec",
      "tblpY"
    };
    private static byte[] attributeNamespaceIds = new byte[10]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "tblpPr";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11718;

    public override string LocalName
    {
      get
      {
        return "tblpPr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11718;
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
        return TablePositionProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TablePositionProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "leftFromText")]
    public Int16Value LeftFromText
    {
      get
      {
        return (Int16Value) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "rightFromText")]
    public Int16Value RightFromText
    {
      get
      {
        return (Int16Value) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "topFromText")]
    public Int16Value TopFromText
    {
      get
      {
        return (Int16Value) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "bottomFromText")]
    public Int16Value BottomFromText
    {
      get
      {
        return (Int16Value) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "vertAnchor")]
    public EnumValue<VerticalAnchorValues> VerticalAnchor
    {
      get
      {
        return (EnumValue<VerticalAnchorValues>) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "horzAnchor")]
    public EnumValue<HorizontalAnchorValues> HorizontalAnchor
    {
      get
      {
        return (EnumValue<HorizontalAnchorValues>) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "tblpXSpec")]
    public EnumValue<HorizontalAlignmentValues> TablePositionXAlignment
    {
      get
      {
        return (EnumValue<HorizontalAlignmentValues>) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "tblpX")]
    public Int32Value TablePositionX
    {
      get
      {
        return (Int32Value) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "tblpYSpec")]
    public EnumValue<VerticalAlignmentValues> TablePositionYAlignment
    {
      get
      {
        return (EnumValue<VerticalAlignmentValues>) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "tblpY")]
    public Int32Value TablePositionY
    {
      get
      {
        return (Int32Value) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "leftFromText" == name)
        return (OpenXmlSimpleType) new Int16Value();
      if (23 == (int) namespaceId && "rightFromText" == name)
        return (OpenXmlSimpleType) new Int16Value();
      if (23 == (int) namespaceId && "topFromText" == name)
        return (OpenXmlSimpleType) new Int16Value();
      if (23 == (int) namespaceId && "bottomFromText" == name)
        return (OpenXmlSimpleType) new Int16Value();
      if (23 == (int) namespaceId && "vertAnchor" == name)
        return (OpenXmlSimpleType) new EnumValue<VerticalAnchorValues>();
      if (23 == (int) namespaceId && "horzAnchor" == name)
        return (OpenXmlSimpleType) new EnumValue<HorizontalAnchorValues>();
      if (23 == (int) namespaceId && "tblpXSpec" == name)
        return (OpenXmlSimpleType) new EnumValue<HorizontalAlignmentValues>();
      if (23 == (int) namespaceId && "tblpX" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if (23 == (int) namespaceId && "tblpYSpec" == name)
        return (OpenXmlSimpleType) new EnumValue<VerticalAlignmentValues>();
      if (23 == (int) namespaceId && "tblpY" == name)
        return (OpenXmlSimpleType) new Int32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TablePositionProperties>(deep);
    }
  }
}

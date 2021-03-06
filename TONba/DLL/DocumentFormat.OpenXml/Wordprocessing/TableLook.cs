﻿// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.TableLook
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [GeneratedCode("DomGen", "2.0")]
  public class TableLook : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[7]
    {
      "val",
      "firstRow",
      "lastRow",
      "firstColumn",
      "lastColumn",
      "noHBand",
      "noVBand"
    };
    private static byte[] attributeNamespaceIds = new byte[7]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "tblLook";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11731;

    public override string LocalName
    {
      get
      {
        return "tblLook";
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
        return 11731;
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
        return TableLook.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return TableLook.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "val")]
    public HexBinaryValue Val
    {
      get
      {
        return (HexBinaryValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    [SchemaAttr(23, "firstRow")]
    public OnOffValue FirstRow
    {
      get
      {
        return (OnOffValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "lastRow")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public OnOffValue LastRow
    {
      get
      {
        return (OnOffValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "firstColumn")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public OnOffValue FirstColumn
    {
      get
      {
        return (OnOffValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    [SchemaAttr(23, "lastColumn")]
    public OnOffValue LastColumn
    {
      get
      {
        return (OnOffValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(23, "noHBand")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public OnOffValue NoHorizontalBand
    {
      get
      {
        return (OnOffValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [OfficeAvailability(FileFormatVersions.Office2010)]
    [SchemaAttr(23, "noVBand")]
    public OnOffValue NoVerticalBand
    {
      get
      {
        return (OnOffValue) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "val" == name)
        return (OpenXmlSimpleType) new HexBinaryValue();
      if (23 == (int) namespaceId && "firstRow" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "lastRow" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "firstColumn" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "lastColumn" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "noHBand" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      if (23 == (int) namespaceId && "noVBand" == name)
        return (OpenXmlSimpleType) new OnOffValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<TableLook>(deep);
    }
  }
}

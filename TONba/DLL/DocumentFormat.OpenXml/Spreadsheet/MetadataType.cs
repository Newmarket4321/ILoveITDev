// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.MetadataType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  public class MetadataType : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[28]
    {
      "name",
      "minSupportedVersion",
      "ghostRow",
      "ghostCol",
      "edit",
      "delete",
      "copy",
      "pasteAll",
      "pasteFormulas",
      "pasteValues",
      "pasteFormats",
      "pasteComments",
      "pasteDataValidation",
      "pasteBorders",
      "pasteColWidths",
      "pasteNumberFormats",
      "merge",
      "splitFirst",
      "splitAll",
      "rowColShift",
      "clearAll",
      "clearFormats",
      "clearContents",
      "clearComments",
      "assign",
      "coerce",
      "adjust",
      "cellMeta"
    };
    private static byte[] attributeNamespaceIds = new byte[28];
    private const string tagName = "metadataType";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11296;

    public override string LocalName
    {
      get
      {
        return "metadataType";
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
        return 11296;
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
        return MetadataType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return MetadataType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "name")]
    public StringValue Name
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

    [SchemaAttr(0, "minSupportedVersion")]
    public UInt32Value MinSupportedVersion
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

    [SchemaAttr(0, "ghostRow")]
    public BooleanValue GhostRow
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

    [SchemaAttr(0, "ghostCol")]
    public BooleanValue GhostColumn
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

    [SchemaAttr(0, "edit")]
    public BooleanValue Edit
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

    [SchemaAttr(0, "delete")]
    public BooleanValue Delete
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

    [SchemaAttr(0, "copy")]
    public BooleanValue Copy
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

    [SchemaAttr(0, "pasteAll")]
    public BooleanValue PasteAll
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

    [SchemaAttr(0, "pasteFormulas")]
    public BooleanValue PasteFormulas
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

    [SchemaAttr(0, "pasteValues")]
    public BooleanValue PasteValues
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

    [SchemaAttr(0, "pasteFormats")]
    public BooleanValue PasteFormats
    {
      get
      {
        return (BooleanValue) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "pasteComments")]
    public BooleanValue PasteComments
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

    [SchemaAttr(0, "pasteDataValidation")]
    public BooleanValue PasteDataValidation
    {
      get
      {
        return (BooleanValue) this.Attributes[12];
      }
      set
      {
        this.Attributes[12] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "pasteBorders")]
    public BooleanValue PasteBorders
    {
      get
      {
        return (BooleanValue) this.Attributes[13];
      }
      set
      {
        this.Attributes[13] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "pasteColWidths")]
    public BooleanValue PasteColWidths
    {
      get
      {
        return (BooleanValue) this.Attributes[14];
      }
      set
      {
        this.Attributes[14] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "pasteNumberFormats")]
    public BooleanValue PasteNumberFormats
    {
      get
      {
        return (BooleanValue) this.Attributes[15];
      }
      set
      {
        this.Attributes[15] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "merge")]
    public BooleanValue Merge
    {
      get
      {
        return (BooleanValue) this.Attributes[16];
      }
      set
      {
        this.Attributes[16] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "splitFirst")]
    public BooleanValue SplitFirst
    {
      get
      {
        return (BooleanValue) this.Attributes[17];
      }
      set
      {
        this.Attributes[17] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "splitAll")]
    public BooleanValue SplitAll
    {
      get
      {
        return (BooleanValue) this.Attributes[18];
      }
      set
      {
        this.Attributes[18] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "rowColShift")]
    public BooleanValue RowColumnShift
    {
      get
      {
        return (BooleanValue) this.Attributes[19];
      }
      set
      {
        this.Attributes[19] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "clearAll")]
    public BooleanValue ClearAll
    {
      get
      {
        return (BooleanValue) this.Attributes[20];
      }
      set
      {
        this.Attributes[20] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "clearFormats")]
    public BooleanValue ClearFormats
    {
      get
      {
        return (BooleanValue) this.Attributes[21];
      }
      set
      {
        this.Attributes[21] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "clearContents")]
    public BooleanValue ClearContents
    {
      get
      {
        return (BooleanValue) this.Attributes[22];
      }
      set
      {
        this.Attributes[22] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "clearComments")]
    public BooleanValue ClearComments
    {
      get
      {
        return (BooleanValue) this.Attributes[23];
      }
      set
      {
        this.Attributes[23] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "assign")]
    public BooleanValue Assign
    {
      get
      {
        return (BooleanValue) this.Attributes[24];
      }
      set
      {
        this.Attributes[24] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "coerce")]
    public BooleanValue Coerce
    {
      get
      {
        return (BooleanValue) this.Attributes[25];
      }
      set
      {
        this.Attributes[25] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "adjust")]
    public BooleanValue Adjust
    {
      get
      {
        return (BooleanValue) this.Attributes[26];
      }
      set
      {
        this.Attributes[26] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "cellMeta")]
    public BooleanValue CellMeta
    {
      get
      {
        return (BooleanValue) this.Attributes[27];
      }
      set
      {
        this.Attributes[27] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "minSupportedVersion" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "ghostRow" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "ghostCol" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "edit" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "delete" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "copy" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "pasteAll" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "pasteFormulas" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "pasteValues" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "pasteFormats" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "pasteComments" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "pasteDataValidation" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "pasteBorders" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "pasteColWidths" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "pasteNumberFormats" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "merge" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "splitFirst" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "splitAll" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "rowColShift" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "clearAll" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "clearFormats" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "clearContents" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "clearComments" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "assign" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "coerce" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "adjust" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "cellMeta" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<MetadataType>(deep);
    }
  }
}

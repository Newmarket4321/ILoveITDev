// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.RevisionRowColumn
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (RevisionFormat))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Undo))]
  [ChildElementInfo(typeof (RevisionCellChange))]
  public class RevisionRowColumn : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[8]
    {
      "rId",
      "ua",
      "ra",
      "sId",
      "eol",
      "ref",
      "action",
      "edge"
    };
    private static byte[] attributeNamespaceIds = new byte[8];
    private const string tagName = "rrc";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11219;

    public override string LocalName
    {
      get
      {
        return "rrc";
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
        return 11219;
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
        return RevisionRowColumn.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return RevisionRowColumn.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "rId")]
    public UInt32Value RevisionId
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

    [SchemaAttr(0, "ua")]
    public BooleanValue Ua
    {
      get
      {
        return (BooleanValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "ra")]
    public BooleanValue Ra
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

    [SchemaAttr(0, "sId")]
    public UInt32Value SheetId
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

    [SchemaAttr(0, "eol")]
    public BooleanValue EndOfList
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

    [SchemaAttr(0, "ref")]
    public StringValue Reference
    {
      get
      {
        return (StringValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "action")]
    public EnumValue<RowColumnActionValues> Action
    {
      get
      {
        return (EnumValue<RowColumnActionValues>) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "edge")]
    public BooleanValue Edge
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

    public RevisionRowColumn()
    {
    }

    public RevisionRowColumn(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public RevisionRowColumn(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public RevisionRowColumn(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "undo" == name)
        return (OpenXmlElement) new Undo();
      if (22 == (int) namespaceId && "rcc" == name)
        return (OpenXmlElement) new RevisionCellChange();
      if (22 == (int) namespaceId && "rfmt" == name)
        return (OpenXmlElement) new RevisionFormat();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "rId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "ua" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "ra" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "sId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "eol" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "ref" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "action" == name)
        return (OpenXmlSimpleType) new EnumValue<RowColumnActionValues>();
      if ((int) namespaceId == 0 && "edge" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<RevisionRowColumn>(deep);
    }
  }
}

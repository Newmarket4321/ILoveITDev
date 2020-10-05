// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.PivotTableStyle
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  public class PivotTableStyle : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[6]
    {
      "name",
      "showRowHeaders",
      "showColHeaders",
      "showRowStripes",
      "showColStripes",
      "showLastColumn"
    };
    private static byte[] attributeNamespaceIds = new byte[6];
    private const string tagName = "pivotTableStyleInfo";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11483;

    public override string LocalName
    {
      get
      {
        return "pivotTableStyleInfo";
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
        return 11483;
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
        return PivotTableStyle.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return PivotTableStyle.attributeNamespaceIds;
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

    [SchemaAttr(0, "showRowHeaders")]
    public BooleanValue ShowRowHeaders
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

    [SchemaAttr(0, "showColHeaders")]
    public BooleanValue ShowColumnHeaders
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

    [SchemaAttr(0, "showRowStripes")]
    public BooleanValue ShowRowStripes
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

    [SchemaAttr(0, "showColStripes")]
    public BooleanValue ShowColumnStripes
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

    [SchemaAttr(0, "showLastColumn")]
    public BooleanValue ShowLastColumn
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

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && nameof (name) == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "showRowHeaders" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showColHeaders" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showRowStripes" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showColStripes" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showLastColumn" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<PivotTableStyle>(deep);
    }
  }
}

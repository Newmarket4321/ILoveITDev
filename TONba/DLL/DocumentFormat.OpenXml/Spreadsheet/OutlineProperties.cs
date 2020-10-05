// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.OutlineProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  public class OutlineProperties : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "applyStyles",
      "summaryBelow",
      "summaryRight",
      "showOutlineSymbols"
    };
    private static byte[] attributeNamespaceIds = new byte[4];
    private const string tagName = "outlinePr";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11250;

    public override string LocalName
    {
      get
      {
        return "outlinePr";
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
        return 11250;
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
        return OutlineProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return OutlineProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "applyStyles")]
    public BooleanValue ApplyStyles
    {
      get
      {
        return (BooleanValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "summaryBelow")]
    public BooleanValue SummaryBelow
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

    [SchemaAttr(0, "summaryRight")]
    public BooleanValue SummaryRight
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

    [SchemaAttr(0, "showOutlineSymbols")]
    public BooleanValue ShowOutlineSymbols
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

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "applyStyles" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "summaryBelow" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "summaryRight" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "showOutlineSymbols" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<OutlineProperties>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.Excel.SlicerStyleElement
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  public class SlicerStyleElement : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "type",
      "dxfId"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private const string tagName = "slicerStyleElement";
    private const byte tagNsId = 53;
    internal const int ElementTypeIdConst = 13053;

    public override string LocalName
    {
      get
      {
        return "slicerStyleElement";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 53;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13053;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return SlicerStyleElement.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return SlicerStyleElement.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "type")]
    public EnumValue<SlicerStyleTypeValues> Type
    {
      get
      {
        return (EnumValue<SlicerStyleTypeValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "dxfId")]
    public UInt32Value FormatId
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

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "type" == name)
        return (OpenXmlSimpleType) new EnumValue<SlicerStyleTypeValues>();
      if ((int) namespaceId == 0 && "dxfId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SlicerStyleElement>(deep);
    }
  }
}

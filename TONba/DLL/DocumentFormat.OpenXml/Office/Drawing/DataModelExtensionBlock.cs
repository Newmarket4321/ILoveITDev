// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.Drawing.DataModelExtensionBlock
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  public class DataModelExtensionBlock : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "relId",
      "minVer"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private const string tagName = "dataModelExt";
    private const byte tagNsId = 56;
    internal const int ElementTypeIdConst = 13084;

    public override string LocalName
    {
      get
      {
        return "dataModelExt";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 56;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13084;
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
        return DataModelExtensionBlock.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return DataModelExtensionBlock.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "relId")]
    public StringValue RelId
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

    [SchemaAttr(0, "minVer")]
    public StringValue MinVer
    {
      get
      {
        return (StringValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "relId" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "minVer" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DataModelExtensionBlock>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.Drawing.BackgroundProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Drawing;
using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Office2013.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class BackgroundProperties : OpenXmlLeafElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "bwMode",
      "bwPure",
      "bwNormal",
      "targetScreenSize"
    };
    private static byte[] attributeNamespaceIds = new byte[4];
    private const string tagName = "backgroundPr";
    private const byte tagNsId = 67;
    internal const int ElementTypeIdConst = 13321;

    public override string LocalName
    {
      get
      {
        return "backgroundPr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 67;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13321;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return (FileFormatVersions.Office2013 & version) > FileFormatVersions.None;
    }

    internal override string[] AttributeTagNames
    {
      get
      {
        return BackgroundProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return BackgroundProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "bwMode")]
    public EnumValue<BlackWhiteModeValues> Mode
    {
      get
      {
        return (EnumValue<BlackWhiteModeValues>) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "bwPure")]
    public EnumValue<BlackWhiteModeValues> Pure
    {
      get
      {
        return (EnumValue<BlackWhiteModeValues>) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "bwNormal")]
    public EnumValue<BlackWhiteModeValues> Normal
    {
      get
      {
        return (EnumValue<BlackWhiteModeValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "targetScreenSize")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.TargetScreenSize> TargetScreenSize
    {
      get
      {
        return (EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.TargetScreenSize>) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "bwMode" == name)
        return (OpenXmlSimpleType) new EnumValue<BlackWhiteModeValues>();
      if ((int) namespaceId == 0 && "bwPure" == name)
        return (OpenXmlSimpleType) new EnumValue<BlackWhiteModeValues>();
      if ((int) namespaceId == 0 && "bwNormal" == name)
        return (OpenXmlSimpleType) new EnumValue<BlackWhiteModeValues>();
      if ((int) namespaceId == 0 && "targetScreenSize" == name)
        return (OpenXmlSimpleType) new EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.TargetScreenSize>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<BackgroundProperties>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.XmlProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (ExtensionList))]
  [GeneratedCode("DomGen", "2.0")]
  public class XmlProperties : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "mapId",
      "xpath",
      "xmlDataType"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private static readonly string[] eleTagNames = new string[1]
    {
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 22
    };
    private const string tagName = "xmlPr";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11308;

    public override string LocalName
    {
      get
      {
        return "xmlPr";
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
        return 11308;
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
        return XmlProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return XmlProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "mapId")]
    public UInt32Value MapId
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

    [SchemaAttr(0, "xpath")]
    public StringValue XPath
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

    [SchemaAttr(0, "xmlDataType")]
    public EnumValue<XmlDataValues> XmlDataType
    {
      get
      {
        return (EnumValue<XmlDataValues>) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    public XmlProperties()
    {
    }

    public XmlProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public XmlProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public XmlProperties(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return XmlProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return XmlProperties.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(0);
      }
      set
      {
        this.SetElement<ExtensionList>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "mapId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "xpath" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "xmlDataType" == name)
        return (OpenXmlSimpleType) new EnumValue<XmlDataValues>();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<XmlProperties>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.WebExtension
{
  [ChildElementInfo(typeof (OfficeArtExtensionList), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class WebExtensionStoreReference : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "id",
      "version",
      "store",
      "storeType"
    };
    private static byte[] attributeNamespaceIds = new byte[4];
    private static readonly string[] eleTagNames = new string[1]
    {
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 66
    };
    private const string tagName = "reference";
    private const byte tagNsId = 66;
    internal const int ElementTypeIdConst = 13316;

    public override string LocalName
    {
      get
      {
        return "reference";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 66;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 13316;
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
        return WebExtensionStoreReference.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return WebExtensionStoreReference.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "id")]
    public StringValue Id
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

    [SchemaAttr(0, "version")]
    public StringValue Version
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

    [SchemaAttr(0, "store")]
    public StringValue Store
    {
      get
      {
        return (StringValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "storeType")]
    public StringValue StoreType
    {
      get
      {
        return (StringValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    public WebExtensionStoreReference()
    {
    }

    public WebExtensionStoreReference(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public WebExtensionStoreReference(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public WebExtensionStoreReference(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (66 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new OfficeArtExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return WebExtensionStoreReference.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return WebExtensionStoreReference.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public OfficeArtExtensionList OfficeArtExtensionList
    {
      get
      {
        return this.GetElement<OfficeArtExtensionList>(0);
      }
      set
      {
        this.SetElement<OfficeArtExtensionList>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "version" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "store" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "storeType" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<WebExtensionStoreReference>(deep);
    }
  }
}

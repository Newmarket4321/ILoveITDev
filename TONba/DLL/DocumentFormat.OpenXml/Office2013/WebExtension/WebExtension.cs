// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2013.WebExtension
{
  [ChildElementInfo(typeof (WebExtensionPropertyBag), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (WebExtensionStoreReference), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (WebExtensionReferenceList), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (Snapshot), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (WebExtensionBindingList), FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (OfficeArtExtensionList), FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2013)]
  public class WebExtension : OpenXmlPartRootElement
  {
    private static string[] attributeTagNames = new string[2]
    {
      "id",
      "frozen"
    };
    private static byte[] attributeNamespaceIds = new byte[2];
    private static readonly string[] eleTagNames = new string[6]
    {
      "reference",
      "alternateReferences",
      "properties",
      "bindings",
      "snapshot",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[6]
    {
      (byte) 66,
      (byte) 66,
      (byte) 66,
      (byte) 66,
      (byte) 66,
      (byte) 66
    };
    private const string tagName = "webextension";
    private const byte tagNsId = 66;
    internal const int ElementTypeIdConst = 13310;

    public override string LocalName
    {
      get
      {
        return "webextension";
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
        return 13310;
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
        return DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension.attributeNamespaceIds;
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

    [SchemaAttr(0, "frozen")]
    public BooleanValue Fronzen
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

    internal WebExtension(WebExtensionPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(WebExtensionPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public WebExtensionPart WebExtensionPart
    {
      get
      {
        return this.OpenXmlPart as WebExtensionPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public WebExtension(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public WebExtension(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public WebExtension(string outerXml)
      : base(outerXml)
    {
    }

    public WebExtension()
    {
    }

    public void Save(WebExtensionPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (66 == (int) namespaceId && "reference" == name)
        return (OpenXmlElement) new WebExtensionStoreReference();
      if (66 == (int) namespaceId && "alternateReferences" == name)
        return (OpenXmlElement) new WebExtensionReferenceList();
      if (66 == (int) namespaceId && "properties" == name)
        return (OpenXmlElement) new WebExtensionPropertyBag();
      if (66 == (int) namespaceId && "bindings" == name)
        return (OpenXmlElement) new WebExtensionBindingList();
      if (66 == (int) namespaceId && "snapshot" == name)
        return (OpenXmlElement) new Snapshot();
      if (66 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new OfficeArtExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public WebExtensionStoreReference WebExtensionStoreReference
    {
      get
      {
        return this.GetElement<WebExtensionStoreReference>(0);
      }
      set
      {
        this.SetElement<WebExtensionStoreReference>(0, value);
      }
    }

    public WebExtensionReferenceList WebExtensionReferenceList
    {
      get
      {
        return this.GetElement<WebExtensionReferenceList>(1);
      }
      set
      {
        this.SetElement<WebExtensionReferenceList>(1, value);
      }
    }

    public WebExtensionPropertyBag WebExtensionPropertyBag
    {
      get
      {
        return this.GetElement<WebExtensionPropertyBag>(2);
      }
      set
      {
        this.SetElement<WebExtensionPropertyBag>(2, value);
      }
    }

    public WebExtensionBindingList WebExtensionBindingList
    {
      get
      {
        return this.GetElement<WebExtensionBindingList>(3);
      }
      set
      {
        this.SetElement<WebExtensionBindingList>(3, value);
      }
    }

    public Snapshot Snapshot
    {
      get
      {
        return this.GetElement<Snapshot>(4);
      }
      set
      {
        this.SetElement<Snapshot>(4, value);
      }
    }

    public OfficeArtExtensionList OfficeArtExtensionList
    {
      get
      {
        return this.GetElement<OfficeArtExtensionList>(5);
      }
      set
      {
        this.SetElement<OfficeArtExtensionList>(5, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "frozen" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension>(deep);
    }
  }
}

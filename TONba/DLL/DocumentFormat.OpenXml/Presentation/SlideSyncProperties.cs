// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.SlideSyncProperties
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (ExtensionList))]
  public class SlideSyncProperties : OpenXmlPartRootElement
  {
    private static string[] attributeTagNames = new string[3]
    {
      "serverSldId",
      "serverSldModifiedTime",
      "clientInsertedTime"
    };
    private static byte[] attributeNamespaceIds = new byte[3];
    private static readonly string[] eleTagNames = new string[1]
    {
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 24
    };
    private const string tagName = "sldSyncPr";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12244;

    public override string LocalName
    {
      get
      {
        return "sldSyncPr";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 24;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12244;
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
        return SlideSyncProperties.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return SlideSyncProperties.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "serverSldId")]
    public StringValue ServerSlideId
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

    [SchemaAttr(0, "serverSldModifiedTime")]
    public DateTimeValue ServerSlideModifiedTime
    {
      get
      {
        return (DateTimeValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "clientInsertedTime")]
    public DateTimeValue ClientInsertedTime
    {
      get
      {
        return (DateTimeValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    internal SlideSyncProperties(SlideSyncDataPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(SlideSyncDataPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public SlideSyncDataPart SlideSyncDataPart
    {
      get
      {
        return this.OpenXmlPart as SlideSyncDataPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public SlideSyncProperties(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SlideSyncProperties(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SlideSyncProperties(string outerXml)
      : base(outerXml)
    {
    }

    public SlideSyncProperties()
    {
    }

    public void Save(SlideSyncDataPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return SlideSyncProperties.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return SlideSyncProperties.eleNamespaceIds;
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
      if ((int) namespaceId == 0 && "serverSldId" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "serverSldModifiedTime" == name)
        return (OpenXmlSimpleType) new DateTimeValue();
      if ((int) namespaceId == 0 && "clientInsertedTime" == name)
        return (OpenXmlSimpleType) new DateTimeValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SlideSyncProperties>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.CustomXmlDataProperties.DataStoreItem
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.CustomXmlDataProperties
{
  [ChildElementInfo(typeof (SchemaReferences))]
  [GeneratedCode("DomGen", "2.0")]
  public class DataStoreItem : OpenXmlPartRootElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "itemID"
    };
    private static byte[] attributeNamespaceIds = new byte[1]
    {
      (byte) 20
    };
    private static readonly string[] eleTagNames = new string[1]
    {
      "schemaRefs"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 20
    };
    private const string tagName = "datastoreItem";
    private const byte tagNsId = 20;
    internal const int ElementTypeIdConst = 10900;

    public override string LocalName
    {
      get
      {
        return "datastoreItem";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 20;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 10900;
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
        return DataStoreItem.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return DataStoreItem.attributeNamespaceIds;
      }
    }

    [SchemaAttr(20, "itemID")]
    public StringValue ItemId
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

    internal DataStoreItem(CustomXmlPropertiesPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(CustomXmlPropertiesPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public CustomXmlPropertiesPart CustomXmlPropertiesPart
    {
      get
      {
        return this.OpenXmlPart as CustomXmlPropertiesPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public DataStoreItem(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DataStoreItem(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DataStoreItem(string outerXml)
      : base(outerXml)
    {
    }

    public DataStoreItem()
    {
    }

    public void Save(CustomXmlPropertiesPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (20 == (int) namespaceId && "schemaRefs" == name)
        return (OpenXmlElement) new SchemaReferences();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DataStoreItem.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DataStoreItem.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public SchemaReferences SchemaReferences
    {
      get
      {
        return this.GetElement<SchemaReferences>(0);
      }
      set
      {
        this.SetElement<SchemaReferences>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (20 == (int) namespaceId && "itemID" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DataStoreItem>(deep);
    }
  }
}

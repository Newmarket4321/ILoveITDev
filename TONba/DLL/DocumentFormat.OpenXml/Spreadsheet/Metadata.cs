// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.Metadata
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (MdxMetadata))]
  [ChildElementInfo(typeof (MetadataTypes))]
  [ChildElementInfo(typeof (MetadataStrings))]
  [ChildElementInfo(typeof (CellMetadata))]
  [ChildElementInfo(typeof (ExtensionList))]
  [ChildElementInfo(typeof (FutureMetadata))]
  [ChildElementInfo(typeof (ValueMetadata))]
  public class Metadata : OpenXmlPartRootElement
  {
    private static readonly string[] eleTagNames = new string[7]
    {
      "metadataTypes",
      "metadataStrings",
      "mdxMetadata",
      "futureMetadata",
      "cellMetadata",
      "valueMetadata",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[7]
    {
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "metadata";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11108;

    public override string LocalName
    {
      get
      {
        return "metadata";
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
        return 11108;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    internal Metadata(CellMetadataPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(CellMetadataPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public CellMetadataPart CellMetadataPart
    {
      get
      {
        return this.OpenXmlPart as CellMetadataPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public Metadata(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Metadata(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Metadata(string outerXml)
      : base(outerXml)
    {
    }

    public Metadata()
    {
    }

    public void Save(CellMetadataPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "metadataTypes" == name)
        return (OpenXmlElement) new MetadataTypes();
      if (22 == (int) namespaceId && "metadataStrings" == name)
        return (OpenXmlElement) new MetadataStrings();
      if (22 == (int) namespaceId && "mdxMetadata" == name)
        return (OpenXmlElement) new MdxMetadata();
      if (22 == (int) namespaceId && "futureMetadata" == name)
        return (OpenXmlElement) new FutureMetadata();
      if (22 == (int) namespaceId && "cellMetadata" == name)
        return (OpenXmlElement) new CellMetadata();
      if (22 == (int) namespaceId && "valueMetadata" == name)
        return (OpenXmlElement) new ValueMetadata();
      if (22 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Metadata.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Metadata.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public MetadataTypes MetadataTypes
    {
      get
      {
        return this.GetElement<MetadataTypes>(0);
      }
      set
      {
        this.SetElement<MetadataTypes>(0, value);
      }
    }

    public MetadataStrings MetadataStrings
    {
      get
      {
        return this.GetElement<MetadataStrings>(1);
      }
      set
      {
        this.SetElement<MetadataStrings>(1, value);
      }
    }

    public MdxMetadata MdxMetadata
    {
      get
      {
        return this.GetElement<MdxMetadata>(2);
      }
      set
      {
        this.SetElement<MdxMetadata>(2, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Metadata>(deep);
    }
  }
}

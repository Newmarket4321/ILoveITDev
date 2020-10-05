// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.FieldMapData
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (ColumnIndex))]
  [ChildElementInfo(typeof (MappedName))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Name))]
  [ChildElementInfo(typeof (MailMergeFieldType))]
  [ChildElementInfo(typeof (LanguageId))]
  [ChildElementInfo(typeof (DynamicAddress))]
  public class FieldMapData : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[6]
    {
      "type",
      "name",
      "mappedName",
      "column",
      "lid",
      "dynamicAddress"
    };
    private static readonly byte[] eleNamespaceIds = new byte[6]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "fieldMapData";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11871;

    public override string LocalName
    {
      get
      {
        return "fieldMapData";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11871;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public FieldMapData()
    {
    }

    public FieldMapData(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public FieldMapData(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public FieldMapData(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "type" == name)
        return (OpenXmlElement) new MailMergeFieldType();
      if (23 == (int) namespaceId && nameof (name) == name)
        return (OpenXmlElement) new Name();
      if (23 == (int) namespaceId && "mappedName" == name)
        return (OpenXmlElement) new MappedName();
      if (23 == (int) namespaceId && "column" == name)
        return (OpenXmlElement) new ColumnIndex();
      if (23 == (int) namespaceId && "lid" == name)
        return (OpenXmlElement) new LanguageId();
      if (23 == (int) namespaceId && "dynamicAddress" == name)
        return (OpenXmlElement) new DynamicAddress();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return FieldMapData.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return FieldMapData.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneAll;
      }
    }

    public MailMergeFieldType MailMergeFieldType
    {
      get
      {
        return this.GetElement<MailMergeFieldType>(0);
      }
      set
      {
        this.SetElement<MailMergeFieldType>(0, value);
      }
    }

    public Name Name
    {
      get
      {
        return this.GetElement<Name>(1);
      }
      set
      {
        this.SetElement<Name>(1, value);
      }
    }

    public MappedName MappedName
    {
      get
      {
        return this.GetElement<MappedName>(2);
      }
      set
      {
        this.SetElement<MappedName>(2, value);
      }
    }

    public ColumnIndex ColumnIndex
    {
      get
      {
        return this.GetElement<ColumnIndex>(3);
      }
      set
      {
        this.SetElement<ColumnIndex>(3, value);
      }
    }

    public LanguageId LanguageId
    {
      get
      {
        return this.GetElement<LanguageId>(4);
      }
      set
      {
        this.SetElement<LanguageId>(4, value);
      }
    }

    public DynamicAddress DynamicAddress
    {
      get
      {
        return this.GetElement<DynamicAddress>(5);
      }
      set
      {
        this.SetElement<DynamicAddress>(5, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<FieldMapData>(deep);
    }
  }
}

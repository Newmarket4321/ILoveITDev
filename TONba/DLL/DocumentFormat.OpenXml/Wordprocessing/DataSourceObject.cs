// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.DataSourceObject
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (SourceReference))]
  [ChildElementInfo(typeof (MailMergeSource))]
  [ChildElementInfo(typeof (FirstRowHeader))]
  [ChildElementInfo(typeof (ColumnDelimiter))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (DataSourceTableName))]
  [ChildElementInfo(typeof (UdlConnectionString))]
  [ChildElementInfo(typeof (FieldMapData))]
  [ChildElementInfo(typeof (RecipientDataReference))]
  public class DataSourceObject : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[8]
    {
      "udl",
      "table",
      "src",
      "colDelim",
      "type",
      "fHdr",
      "fieldMapData",
      "recipientData"
    };
    private static readonly byte[] eleNamespaceIds = new byte[8]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "odso";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11888;

    public override string LocalName
    {
      get
      {
        return "odso";
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
        return 11888;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public DataSourceObject()
    {
    }

    public DataSourceObject(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DataSourceObject(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DataSourceObject(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "udl" == name)
        return (OpenXmlElement) new UdlConnectionString();
      if (23 == (int) namespaceId && "table" == name)
        return (OpenXmlElement) new DataSourceTableName();
      if (23 == (int) namespaceId && "src" == name)
        return (OpenXmlElement) new SourceReference();
      if (23 == (int) namespaceId && "colDelim" == name)
        return (OpenXmlElement) new ColumnDelimiter();
      if (23 == (int) namespaceId && "type" == name)
        return (OpenXmlElement) new MailMergeSource();
      if (23 == (int) namespaceId && "fHdr" == name)
        return (OpenXmlElement) new FirstRowHeader();
      if (23 == (int) namespaceId && "fieldMapData" == name)
        return (OpenXmlElement) new FieldMapData();
      if (23 == (int) namespaceId && "recipientData" == name)
        return (OpenXmlElement) new RecipientDataReference();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DataSourceObject.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DataSourceObject.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public UdlConnectionString UdlConnectionString
    {
      get
      {
        return this.GetElement<UdlConnectionString>(0);
      }
      set
      {
        this.SetElement<UdlConnectionString>(0, value);
      }
    }

    public DataSourceTableName DataSourceTableName
    {
      get
      {
        return this.GetElement<DataSourceTableName>(1);
      }
      set
      {
        this.SetElement<DataSourceTableName>(1, value);
      }
    }

    public SourceReference SourceReference
    {
      get
      {
        return this.GetElement<SourceReference>(2);
      }
      set
      {
        this.SetElement<SourceReference>(2, value);
      }
    }

    public ColumnDelimiter ColumnDelimiter
    {
      get
      {
        return this.GetElement<ColumnDelimiter>(3);
      }
      set
      {
        this.SetElement<ColumnDelimiter>(3, value);
      }
    }

    public MailMergeSource MailMergeSource
    {
      get
      {
        return this.GetElement<MailMergeSource>(4);
      }
      set
      {
        this.SetElement<MailMergeSource>(4, value);
      }
    }

    public FirstRowHeader FirstRowHeader
    {
      get
      {
        return this.GetElement<FirstRowHeader>(5);
      }
      set
      {
        this.SetElement<FirstRowHeader>(5, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DataSourceObject>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.MailMerge
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (ConnectString))]
  [ChildElementInfo(typeof (AddressFieldName))]
  [ChildElementInfo(typeof (MailSubject))]
  [ChildElementInfo(typeof (MainDocumentType))]
  [ChildElementInfo(typeof (LinkToQuery))]
  [ChildElementInfo(typeof (DataType))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Query))]
  [ChildElementInfo(typeof (DataSourceReference))]
  [ChildElementInfo(typeof (HeaderSource))]
  [ChildElementInfo(typeof (DoNotSuppressBlankLines))]
  [ChildElementInfo(typeof (Destination))]
  [ChildElementInfo(typeof (MailAsAttachment))]
  [ChildElementInfo(typeof (ViewMergedData))]
  [ChildElementInfo(typeof (ActiveRecord))]
  [ChildElementInfo(typeof (CheckErrors))]
  [ChildElementInfo(typeof (DataSourceObject))]
  public class MailMerge : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[16]
    {
      "mainDocumentType",
      "linkToQuery",
      "dataType",
      "connectString",
      "query",
      "dataSource",
      "headerSource",
      "doNotSuppressBlankLines",
      "destination",
      "addressFieldName",
      "mailSubject",
      "mailAsAttachment",
      "viewMergedData",
      "activeRecord",
      "checkErrors",
      "odso"
    };
    private static readonly byte[] eleNamespaceIds = new byte[16]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "mailMerge";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 12132;

    public override string LocalName
    {
      get
      {
        return "mailMerge";
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
        return 12132;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public MailMerge()
    {
    }

    public MailMerge(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public MailMerge(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public MailMerge(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "mainDocumentType" == name)
        return (OpenXmlElement) new MainDocumentType();
      if (23 == (int) namespaceId && "linkToQuery" == name)
        return (OpenXmlElement) new LinkToQuery();
      if (23 == (int) namespaceId && "dataType" == name)
        return (OpenXmlElement) new DataType();
      if (23 == (int) namespaceId && "connectString" == name)
        return (OpenXmlElement) new ConnectString();
      if (23 == (int) namespaceId && "query" == name)
        return (OpenXmlElement) new Query();
      if (23 == (int) namespaceId && "dataSource" == name)
        return (OpenXmlElement) new DataSourceReference();
      if (23 == (int) namespaceId && "headerSource" == name)
        return (OpenXmlElement) new HeaderSource();
      if (23 == (int) namespaceId && "doNotSuppressBlankLines" == name)
        return (OpenXmlElement) new DoNotSuppressBlankLines();
      if (23 == (int) namespaceId && "destination" == name)
        return (OpenXmlElement) new Destination();
      if (23 == (int) namespaceId && "addressFieldName" == name)
        return (OpenXmlElement) new AddressFieldName();
      if (23 == (int) namespaceId && "mailSubject" == name)
        return (OpenXmlElement) new MailSubject();
      if (23 == (int) namespaceId && "mailAsAttachment" == name)
        return (OpenXmlElement) new MailAsAttachment();
      if (23 == (int) namespaceId && "viewMergedData" == name)
        return (OpenXmlElement) new ViewMergedData();
      if (23 == (int) namespaceId && "activeRecord" == name)
        return (OpenXmlElement) new ActiveRecord();
      if (23 == (int) namespaceId && "checkErrors" == name)
        return (OpenXmlElement) new CheckErrors();
      if (23 == (int) namespaceId && "odso" == name)
        return (OpenXmlElement) new DataSourceObject();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return MailMerge.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return MailMerge.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public MainDocumentType MainDocumentType
    {
      get
      {
        return this.GetElement<MainDocumentType>(0);
      }
      set
      {
        this.SetElement<MainDocumentType>(0, value);
      }
    }

    public LinkToQuery LinkToQuery
    {
      get
      {
        return this.GetElement<LinkToQuery>(1);
      }
      set
      {
        this.SetElement<LinkToQuery>(1, value);
      }
    }

    public DataType DataType
    {
      get
      {
        return this.GetElement<DataType>(2);
      }
      set
      {
        this.SetElement<DataType>(2, value);
      }
    }

    public ConnectString ConnectString
    {
      get
      {
        return this.GetElement<ConnectString>(3);
      }
      set
      {
        this.SetElement<ConnectString>(3, value);
      }
    }

    public Query Query
    {
      get
      {
        return this.GetElement<Query>(4);
      }
      set
      {
        this.SetElement<Query>(4, value);
      }
    }

    public DataSourceReference DataSourceReference
    {
      get
      {
        return this.GetElement<DataSourceReference>(5);
      }
      set
      {
        this.SetElement<DataSourceReference>(5, value);
      }
    }

    public HeaderSource HeaderSource
    {
      get
      {
        return this.GetElement<HeaderSource>(6);
      }
      set
      {
        this.SetElement<HeaderSource>(6, value);
      }
    }

    public DoNotSuppressBlankLines DoNotSuppressBlankLines
    {
      get
      {
        return this.GetElement<DoNotSuppressBlankLines>(7);
      }
      set
      {
        this.SetElement<DoNotSuppressBlankLines>(7, value);
      }
    }

    public Destination Destination
    {
      get
      {
        return this.GetElement<Destination>(8);
      }
      set
      {
        this.SetElement<Destination>(8, value);
      }
    }

    public AddressFieldName AddressFieldName
    {
      get
      {
        return this.GetElement<AddressFieldName>(9);
      }
      set
      {
        this.SetElement<AddressFieldName>(9, value);
      }
    }

    public MailSubject MailSubject
    {
      get
      {
        return this.GetElement<MailSubject>(10);
      }
      set
      {
        this.SetElement<MailSubject>(10, value);
      }
    }

    public MailAsAttachment MailAsAttachment
    {
      get
      {
        return this.GetElement<MailAsAttachment>(11);
      }
      set
      {
        this.SetElement<MailAsAttachment>(11, value);
      }
    }

    public ViewMergedData ViewMergedData
    {
      get
      {
        return this.GetElement<ViewMergedData>(12);
      }
      set
      {
        this.SetElement<ViewMergedData>(12, value);
      }
    }

    public ActiveRecord ActiveRecord
    {
      get
      {
        return this.GetElement<ActiveRecord>(13);
      }
      set
      {
        this.SetElement<ActiveRecord>(13, value);
      }
    }

    public CheckErrors CheckErrors
    {
      get
      {
        return this.GetElement<CheckErrors>(14);
      }
      set
      {
        this.SetElement<CheckErrors>(14, value);
      }
    }

    public DataSourceObject DataSourceObject
    {
      get
      {
        return this.GetElement<DataSourceObject>(15);
      }
      set
      {
        this.SetElement<DataSourceObject>(15, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<MailMerge>(deep);
    }
  }
}

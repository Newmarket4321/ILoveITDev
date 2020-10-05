// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.Word.SingleDataSourceRecord
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office.Word
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (RecordHashCode))]
  [ChildElementInfo(typeof (RecordIncluded))]
  public class SingleDataSourceRecord : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "active",
      "hash"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 33,
      (byte) 33
    };
    private const string tagName = "recipientData";
    private const byte tagNsId = 33;
    internal const int ElementTypeIdConst = 12643;

    public override string LocalName
    {
      get
      {
        return "recipientData";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 33;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12643;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public SingleDataSourceRecord()
    {
    }

    public SingleDataSourceRecord(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SingleDataSourceRecord(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SingleDataSourceRecord(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (33 == (int) namespaceId && "active" == name)
        return (OpenXmlElement) new RecordIncluded();
      if (33 == (int) namespaceId && "hash" == name)
        return (OpenXmlElement) new RecordHashCode();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return SingleDataSourceRecord.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return SingleDataSourceRecord.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public RecordIncluded RecordIncluded
    {
      get
      {
        return this.GetElement<RecordIncluded>(0);
      }
      set
      {
        this.SetElement<RecordIncluded>(0, value);
      }
    }

    public RecordHashCode RecordHashCode
    {
      get
      {
        return this.GetElement<RecordHashCode>(1);
      }
      set
      {
        this.SetElement<RecordHashCode>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SingleDataSourceRecord>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.Headers
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using DocumentFormat.OpenXml.Packaging;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (Header))]
  public class Headers : OpenXmlPartRootElement
  {
    private static string[] attributeTagNames = new string[12]
    {
      "guid",
      "lastGuid",
      "shared",
      "diskRevisions",
      "history",
      "trackRevisions",
      "exclusive",
      "revisionId",
      "version",
      "keepChangeHistory",
      "protected",
      "preserveHistory"
    };
    private static byte[] attributeNamespaceIds = new byte[12];
    private const string tagName = "headers";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11102;

    public override string LocalName
    {
      get
      {
        return "headers";
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
        return 11102;
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
        return Headers.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Headers.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "guid")]
    public StringValue Guid
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

    [SchemaAttr(0, "lastGuid")]
    public StringValue LastGuid
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

    [SchemaAttr(0, "shared")]
    public BooleanValue Shared
    {
      get
      {
        return (BooleanValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "diskRevisions")]
    public BooleanValue DiskRevisions
    {
      get
      {
        return (BooleanValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "history")]
    public BooleanValue History
    {
      get
      {
        return (BooleanValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "trackRevisions")]
    public BooleanValue TrackRevisions
    {
      get
      {
        return (BooleanValue) this.Attributes[5];
      }
      set
      {
        this.Attributes[5] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "exclusive")]
    public BooleanValue Exclusive
    {
      get
      {
        return (BooleanValue) this.Attributes[6];
      }
      set
      {
        this.Attributes[6] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "revisionId")]
    public UInt32Value RevisionId
    {
      get
      {
        return (UInt32Value) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "version")]
    public Int32Value Version
    {
      get
      {
        return (Int32Value) this.Attributes[8];
      }
      set
      {
        this.Attributes[8] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "keepChangeHistory")]
    public BooleanValue KeepChangeHistory
    {
      get
      {
        return (BooleanValue) this.Attributes[9];
      }
      set
      {
        this.Attributes[9] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "protected")]
    public BooleanValue Protected
    {
      get
      {
        return (BooleanValue) this.Attributes[10];
      }
      set
      {
        this.Attributes[10] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "preserveHistory")]
    public UInt32Value PreserveHistory
    {
      get
      {
        return (UInt32Value) this.Attributes[11];
      }
      set
      {
        this.Attributes[11] = (OpenXmlSimpleType) value;
      }
    }

    internal Headers(WorkbookRevisionHeaderPart ownerPart)
      : base((OpenXmlPart) ownerPart)
    {
    }

    public void Load(WorkbookRevisionHeaderPart openXmlPart)
    {
      this.LoadFromPart((OpenXmlPart) openXmlPart);
    }

    public WorkbookRevisionHeaderPart WorkbookRevisionHeaderPart
    {
      get
      {
        return this.OpenXmlPart as WorkbookRevisionHeaderPart;
      }
      internal set
      {
        this.OpenXmlPart = (OpenXmlPart) value;
      }
    }

    public Headers(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Headers(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Headers(string outerXml)
      : base(outerXml)
    {
    }

    public Headers()
    {
    }

    public void Save(WorkbookRevisionHeaderPart openXmlPart)
    {
      this.SaveToPart((OpenXmlPart) openXmlPart);
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "header" == name)
        return (OpenXmlElement) new Header();
      return (OpenXmlElement) null;
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "guid" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "lastGuid" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "shared" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "diskRevisions" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "history" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "trackRevisions" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "exclusive" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "revisionId" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      if ((int) namespaceId == 0 && "version" == name)
        return (OpenXmlSimpleType) new Int32Value();
      if ((int) namespaceId == 0 && "keepChangeHistory" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "protected" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "preserveHistory" == name)
        return (OpenXmlSimpleType) new UInt32Value();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Headers>(deep);
    }
  }
}

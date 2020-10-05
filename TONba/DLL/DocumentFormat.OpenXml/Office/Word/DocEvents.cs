// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office.Word.DocEvents
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office.Word
{
  [ChildElementInfo(typeof (EventDocNewXsdString))]
  [ChildElementInfo(typeof (EventDocContentControlBeforeDeleteXsdString))]
  [ChildElementInfo(typeof (EventDocOpenXsdString))]
  [ChildElementInfo(typeof (EventDocCloseXsdString))]
  [ChildElementInfo(typeof (EventDocSyncXsdString))]
  [ChildElementInfo(typeof (EventDocXmlAfterInsertXsdString))]
  [ChildElementInfo(typeof (EventDocXmlBeforeDeleteXsdString))]
  [ChildElementInfo(typeof (EventDocContentControlAfterInsertXsdString))]
  [ChildElementInfo(typeof (EventDocContentControlUpdateXsdString))]
  [ChildElementInfo(typeof (EventDocContentControlOnExistXsdString))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (EventDocStoreUpdateXsdString))]
  [ChildElementInfo(typeof (EventDocContentControlOnEnterXsdString))]
  [ChildElementInfo(typeof (EventDocBuildingBlockAfterInsertXsdString))]
  public class DocEvents : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[13]
    {
      "eventDocNew",
      "eventDocOpen",
      "eventDocClose",
      "eventDocSync",
      "eventDocXmlAfterInsert",
      "eventDocXmlBeforeDelete",
      "eventDocContentControlAfterInsert",
      "eventDocContentControlBeforeDelete",
      "eventDocContentControlOnExit",
      "eventDocContentControlOnEnter",
      "eventDocStoreUpdate",
      "eventDocContentControlContentUpdate",
      "eventDocBuildingBlockAfterInsert"
    };
    private static readonly byte[] eleNamespaceIds = new byte[13]
    {
      (byte) 33,
      (byte) 33,
      (byte) 33,
      (byte) 33,
      (byte) 33,
      (byte) 33,
      (byte) 33,
      (byte) 33,
      (byte) 33,
      (byte) 33,
      (byte) 33,
      (byte) 33,
      (byte) 33
    };
    private const string tagName = "docEvents";
    private const byte tagNsId = 33;
    internal const int ElementTypeIdConst = 12633;

    public override string LocalName
    {
      get
      {
        return "docEvents";
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
        return 12633;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public DocEvents()
    {
    }

    public DocEvents(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public DocEvents(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public DocEvents(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (33 == (int) namespaceId && "eventDocNew" == name)
        return (OpenXmlElement) new EventDocNewXsdString();
      if (33 == (int) namespaceId && "eventDocOpen" == name)
        return (OpenXmlElement) new EventDocOpenXsdString();
      if (33 == (int) namespaceId && "eventDocClose" == name)
        return (OpenXmlElement) new EventDocCloseXsdString();
      if (33 == (int) namespaceId && "eventDocSync" == name)
        return (OpenXmlElement) new EventDocSyncXsdString();
      if (33 == (int) namespaceId && "eventDocXmlAfterInsert" == name)
        return (OpenXmlElement) new EventDocXmlAfterInsertXsdString();
      if (33 == (int) namespaceId && "eventDocXmlBeforeDelete" == name)
        return (OpenXmlElement) new EventDocXmlBeforeDeleteXsdString();
      if (33 == (int) namespaceId && "eventDocContentControlAfterInsert" == name)
        return (OpenXmlElement) new EventDocContentControlAfterInsertXsdString();
      if (33 == (int) namespaceId && "eventDocContentControlBeforeDelete" == name)
        return (OpenXmlElement) new EventDocContentControlBeforeDeleteXsdString();
      if (33 == (int) namespaceId && "eventDocContentControlOnExit" == name)
        return (OpenXmlElement) new EventDocContentControlOnExistXsdString();
      if (33 == (int) namespaceId && "eventDocContentControlOnEnter" == name)
        return (OpenXmlElement) new EventDocContentControlOnEnterXsdString();
      if (33 == (int) namespaceId && "eventDocStoreUpdate" == name)
        return (OpenXmlElement) new EventDocStoreUpdateXsdString();
      if (33 == (int) namespaceId && "eventDocContentControlContentUpdate" == name)
        return (OpenXmlElement) new EventDocContentControlUpdateXsdString();
      if (33 == (int) namespaceId && "eventDocBuildingBlockAfterInsert" == name)
        return (OpenXmlElement) new EventDocBuildingBlockAfterInsertXsdString();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return DocEvents.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return DocEvents.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public EventDocNewXsdString EventDocNewXsdString
    {
      get
      {
        return this.GetElement<EventDocNewXsdString>(0);
      }
      set
      {
        this.SetElement<EventDocNewXsdString>(0, value);
      }
    }

    public EventDocOpenXsdString EventDocOpenXsdString
    {
      get
      {
        return this.GetElement<EventDocOpenXsdString>(1);
      }
      set
      {
        this.SetElement<EventDocOpenXsdString>(1, value);
      }
    }

    public EventDocCloseXsdString EventDocCloseXsdString
    {
      get
      {
        return this.GetElement<EventDocCloseXsdString>(2);
      }
      set
      {
        this.SetElement<EventDocCloseXsdString>(2, value);
      }
    }

    public EventDocSyncXsdString EventDocSyncXsdString
    {
      get
      {
        return this.GetElement<EventDocSyncXsdString>(3);
      }
      set
      {
        this.SetElement<EventDocSyncXsdString>(3, value);
      }
    }

    public EventDocXmlAfterInsertXsdString EventDocXmlAfterInsertXsdString
    {
      get
      {
        return this.GetElement<EventDocXmlAfterInsertXsdString>(4);
      }
      set
      {
        this.SetElement<EventDocXmlAfterInsertXsdString>(4, value);
      }
    }

    public EventDocXmlBeforeDeleteXsdString EventDocXmlBeforeDeleteXsdString
    {
      get
      {
        return this.GetElement<EventDocXmlBeforeDeleteXsdString>(5);
      }
      set
      {
        this.SetElement<EventDocXmlBeforeDeleteXsdString>(5, value);
      }
    }

    public EventDocContentControlAfterInsertXsdString EventDocContentControlAfterInsertXsdString
    {
      get
      {
        return this.GetElement<EventDocContentControlAfterInsertXsdString>(6);
      }
      set
      {
        this.SetElement<EventDocContentControlAfterInsertXsdString>(6, value);
      }
    }

    public EventDocContentControlBeforeDeleteXsdString EventDocContentControlBeforeDeleteXsdString
    {
      get
      {
        return this.GetElement<EventDocContentControlBeforeDeleteXsdString>(7);
      }
      set
      {
        this.SetElement<EventDocContentControlBeforeDeleteXsdString>(7, value);
      }
    }

    public EventDocContentControlOnExistXsdString EventDocContentControlOnExistXsdString
    {
      get
      {
        return this.GetElement<EventDocContentControlOnExistXsdString>(8);
      }
      set
      {
        this.SetElement<EventDocContentControlOnExistXsdString>(8, value);
      }
    }

    public EventDocContentControlOnEnterXsdString EventDocContentControlOnEnterXsdString
    {
      get
      {
        return this.GetElement<EventDocContentControlOnEnterXsdString>(9);
      }
      set
      {
        this.SetElement<EventDocContentControlOnEnterXsdString>(9, value);
      }
    }

    public EventDocStoreUpdateXsdString EventDocStoreUpdateXsdString
    {
      get
      {
        return this.GetElement<EventDocStoreUpdateXsdString>(10);
      }
      set
      {
        this.SetElement<EventDocStoreUpdateXsdString>(10, value);
      }
    }

    public EventDocContentControlUpdateXsdString EventDocContentControlUpdateXsdString
    {
      get
      {
        return this.GetElement<EventDocContentControlUpdateXsdString>(11);
      }
      set
      {
        this.SetElement<EventDocContentControlUpdateXsdString>(11, value);
      }
    }

    public EventDocBuildingBlockAfterInsertXsdString EventDocBuildingBlockAfterInsertXsdString
    {
      get
      {
        return this.GetElement<EventDocBuildingBlockAfterInsertXsdString>(12);
      }
      set
      {
        this.SetElement<EventDocBuildingBlockAfterInsertXsdString>(12, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<DocEvents>(deep);
    }
  }
}

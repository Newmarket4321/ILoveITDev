// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Office2010.PowerPoint.ShowEventRecordList
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Office2010.PowerPoint
{
  [ChildElementInfo(typeof (PauseEventRecord), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (ResumeEventRecord), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (SeekEventRecord), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (NullEventRecord), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [GeneratedCode("DomGen", "2.0")]
  [OfficeAvailability(FileFormatVersions.Office2010)]
  [ChildElementInfo(typeof (PlayEventRecord), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (StopEventRecord), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  [ChildElementInfo(typeof (TriggerEventRecord), FileFormatVersions.Office2010 | FileFormatVersions.Office2013)]
  public class ShowEventRecordList : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[7]
    {
      "triggerEvt",
      "playEvt",
      "stopEvt",
      "pauseEvt",
      "resumeEvt",
      "seekEvt",
      "nullEvt"
    };
    private static readonly byte[] eleNamespaceIds = new byte[7]
    {
      (byte) 49,
      (byte) 49,
      (byte) 49,
      (byte) 49,
      (byte) 49,
      (byte) 49,
      (byte) 49
    };
    private const string tagName = "showEvtLst";
    private const byte tagNsId = 49;
    internal const int ElementTypeIdConst = 12865;

    public override string LocalName
    {
      get
      {
        return "showEvtLst";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 49;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 12865;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public ShowEventRecordList()
    {
    }

    public ShowEventRecordList(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public ShowEventRecordList(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public ShowEventRecordList(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (49 == (int) namespaceId && "triggerEvt" == name)
        return (OpenXmlElement) new TriggerEventRecord();
      if (49 == (int) namespaceId && "playEvt" == name)
        return (OpenXmlElement) new PlayEventRecord();
      if (49 == (int) namespaceId && "stopEvt" == name)
        return (OpenXmlElement) new StopEventRecord();
      if (49 == (int) namespaceId && "pauseEvt" == name)
        return (OpenXmlElement) new PauseEventRecord();
      if (49 == (int) namespaceId && "resumeEvt" == name)
        return (OpenXmlElement) new ResumeEventRecord();
      if (49 == (int) namespaceId && "seekEvt" == name)
        return (OpenXmlElement) new SeekEventRecord();
      if (49 == (int) namespaceId && "nullEvt" == name)
        return (OpenXmlElement) new NullEventRecord();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return ShowEventRecordList.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return ShowEventRecordList.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneAll;
      }
    }

    public TriggerEventRecord TriggerEventRecord
    {
      get
      {
        return this.GetElement<TriggerEventRecord>(0);
      }
      set
      {
        this.SetElement<TriggerEventRecord>(0, value);
      }
    }

    public PlayEventRecord PlayEventRecord
    {
      get
      {
        return this.GetElement<PlayEventRecord>(1);
      }
      set
      {
        this.SetElement<PlayEventRecord>(1, value);
      }
    }

    public StopEventRecord StopEventRecord
    {
      get
      {
        return this.GetElement<StopEventRecord>(2);
      }
      set
      {
        this.SetElement<StopEventRecord>(2, value);
      }
    }

    public PauseEventRecord PauseEventRecord
    {
      get
      {
        return this.GetElement<PauseEventRecord>(3);
      }
      set
      {
        this.SetElement<PauseEventRecord>(3, value);
      }
    }

    public ResumeEventRecord ResumeEventRecord
    {
      get
      {
        return this.GetElement<ResumeEventRecord>(4);
      }
      set
      {
        this.SetElement<ResumeEventRecord>(4, value);
      }
    }

    public SeekEventRecord SeekEventRecord
    {
      get
      {
        return this.GetElement<SeekEventRecord>(5);
      }
      set
      {
        this.SetElement<SeekEventRecord>(5, value);
      }
    }

    public NullEventRecord NullEventRecord
    {
      get
      {
        return this.GetElement<NullEventRecord>(6);
      }
      set
      {
        this.SetElement<NullEventRecord>(6, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<ShowEventRecordList>(deep);
    }
  }
}

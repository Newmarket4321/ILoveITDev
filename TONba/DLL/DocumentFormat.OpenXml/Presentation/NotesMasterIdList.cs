// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.NotesMasterIdList
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (NotesMasterId))]
  public class NotesMasterIdList : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[1]
    {
      "notesMasterId"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 24
    };
    private const string tagName = "notesMasterIdLst";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12413;

    public override string LocalName
    {
      get
      {
        return "notesMasterIdLst";
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
        return 12413;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public NotesMasterIdList()
    {
    }

    public NotesMasterIdList(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public NotesMasterIdList(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public NotesMasterIdList(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "notesMasterId" == name)
        return (OpenXmlElement) new NotesMasterId();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return NotesMasterIdList.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return NotesMasterIdList.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public NotesMasterId NotesMasterId
    {
      get
      {
        return this.GetElement<NotesMasterId>(0);
      }
      set
      {
        this.SetElement<NotesMasterId>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<NotesMasterIdList>(deep);
    }
  }
}

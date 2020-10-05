// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.HandoutMasterIdList
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (HandoutMasterId))]
  [GeneratedCode("DomGen", "2.0")]
  public class HandoutMasterIdList : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[1]
    {
      "handoutMasterId"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 24
    };
    private const string tagName = "handoutMasterIdLst";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12414;

    public override string LocalName
    {
      get
      {
        return "handoutMasterIdLst";
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
        return 12414;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public HandoutMasterIdList()
    {
    }

    public HandoutMasterIdList(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public HandoutMasterIdList(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public HandoutMasterIdList(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "handoutMasterId" == name)
        return (OpenXmlElement) new HandoutMasterId();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return HandoutMasterIdList.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return HandoutMasterIdList.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public HandoutMasterId HandoutMasterId
    {
      get
      {
        return this.GetElement<HandoutMasterId>(0);
      }
      set
      {
        this.SetElement<HandoutMasterId>(0, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<HandoutMasterIdList>(deep);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.SoundAction
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (EndSoundAction))]
  [ChildElementInfo(typeof (StartSoundAction))]
  [GeneratedCode("DomGen", "2.0")]
  public class SoundAction : OpenXmlCompositeElement
  {
    private static readonly string[] eleTagNames = new string[2]
    {
      "stSnd",
      "endSnd"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 24,
      (byte) 24
    };
    private const string tagName = "sndAc";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12467;

    public override string LocalName
    {
      get
      {
        return "sndAc";
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
        return 12467;
      }
    }

    internal override bool IsInVersion(FileFormatVersions version)
    {
      return ((FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013) & version) > FileFormatVersions.None;
    }

    public SoundAction()
    {
    }

    public SoundAction(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public SoundAction(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public SoundAction(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "stSnd" == name)
        return (OpenXmlElement) new StartSoundAction();
      if (24 == (int) namespaceId && "endSnd" == name)
        return (OpenXmlElement) new EndSoundAction();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return SoundAction.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return SoundAction.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneChoice;
      }
    }

    public StartSoundAction StartSoundAction
    {
      get
      {
        return this.GetElement<StartSoundAction>(0);
      }
      set
      {
        this.SetElement<StartSoundAction>(0, value);
      }
    }

    public EndSoundAction EndSoundAction
    {
      get
      {
        return this.GetElement<EndSoundAction>(1);
      }
      set
      {
        this.SetElement<EndSoundAction>(1, value);
      }
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<SoundAction>(deep);
    }
  }
}

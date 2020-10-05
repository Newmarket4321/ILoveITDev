// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.StartSoundAction
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (Sound))]
  [GeneratedCode("DomGen", "2.0")]
  public class StartSoundAction : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "loop"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[1]
    {
      "snd"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 24
    };
    private const string tagName = "stSnd";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12249;

    public override string LocalName
    {
      get
      {
        return "stSnd";
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
        return 12249;
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
        return StartSoundAction.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return StartSoundAction.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "loop")]
    public BooleanValue Loop
    {
      get
      {
        return (BooleanValue) this.Attributes[0];
      }
      set
      {
        this.Attributes[0] = (OpenXmlSimpleType) value;
      }
    }

    public StartSoundAction()
    {
    }

    public StartSoundAction(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public StartSoundAction(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public StartSoundAction(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "snd" == name)
        return (OpenXmlElement) new Sound();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return StartSoundAction.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return StartSoundAction.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public Sound Sound
    {
      get
      {
        return this.GetElement<Sound>(0);
      }
      set
      {
        this.SetElement<Sound>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "loop" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<StartSoundAction>(deep);
    }
  }
}

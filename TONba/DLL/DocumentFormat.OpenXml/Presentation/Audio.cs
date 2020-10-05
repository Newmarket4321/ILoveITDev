// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Presentation.Audio
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Presentation
{
  [ChildElementInfo(typeof (CommonMediaNode))]
  [GeneratedCode("DomGen", "2.0")]
  public class Audio : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "isNarration"
    };
    private static byte[] attributeNamespaceIds = new byte[1];
    private static readonly string[] eleTagNames = new string[1]
    {
      "cMediaNode"
    };
    private static readonly byte[] eleNamespaceIds = new byte[1]
    {
      (byte) 24
    };
    private const string tagName = "audio";
    private const byte tagNsId = 24;
    internal const int ElementTypeIdConst = 12270;

    public override string LocalName
    {
      get
      {
        return "audio";
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
        return 12270;
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
        return Audio.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Audio.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "isNarration")]
    public BooleanValue IsNarration
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

    public Audio()
    {
    }

    public Audio(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Audio(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Audio(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (24 == (int) namespaceId && "cMediaNode" == name)
        return (OpenXmlElement) new CommonMediaNode();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Audio.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Audio.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public CommonMediaNode CommonMediaNode
    {
      get
      {
        return this.GetElement<CommonMediaNode>(0);
      }
      set
      {
        this.SetElement<CommonMediaNode>(0, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "isNarration" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Audio>(deep);
    }
  }
}

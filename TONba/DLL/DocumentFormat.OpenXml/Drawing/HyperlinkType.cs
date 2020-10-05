// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Drawing.HyperlinkType
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Drawing
{
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (HyperlinkSound))]
  [ChildElementInfo(typeof (ExtensionList))]
  public abstract class HyperlinkType : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[8]
    {
      "id",
      "invalidUrl",
      "action",
      "tgtFrame",
      "tooltip",
      "history",
      "highlightClick",
      "endSnd"
    };
    private static byte[] attributeNamespaceIds = new byte[8]
    {
      (byte) 19,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private static readonly string[] eleTagNames = new string[2]
    {
      "snd",
      "extLst"
    };
    private static readonly byte[] eleNamespaceIds = new byte[2]
    {
      (byte) 10,
      (byte) 10
    };

    internal override string[] AttributeTagNames
    {
      get
      {
        return HyperlinkType.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return HyperlinkType.attributeNamespaceIds;
      }
    }

    [SchemaAttr(19, "id")]
    public StringValue Id
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

    [SchemaAttr(0, "invalidUrl")]
    public StringValue InvalidUrl
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

    [SchemaAttr(0, "action")]
    public StringValue Action
    {
      get
      {
        return (StringValue) this.Attributes[2];
      }
      set
      {
        this.Attributes[2] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "tgtFrame")]
    public StringValue TargetFrame
    {
      get
      {
        return (StringValue) this.Attributes[3];
      }
      set
      {
        this.Attributes[3] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "tooltip")]
    public StringValue Tooltip
    {
      get
      {
        return (StringValue) this.Attributes[4];
      }
      set
      {
        this.Attributes[4] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "history")]
    public BooleanValue History
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

    [SchemaAttr(0, "highlightClick")]
    public BooleanValue HighlightClick
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

    [SchemaAttr(0, "endSnd")]
    public BooleanValue EndSound
    {
      get
      {
        return (BooleanValue) this.Attributes[7];
      }
      set
      {
        this.Attributes[7] = (OpenXmlSimpleType) value;
      }
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (10 == (int) namespaceId && "snd" == name)
        return (OpenXmlElement) new HyperlinkSound();
      if (10 == (int) namespaceId && "extLst" == name)
        return (OpenXmlElement) new ExtensionList();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return HyperlinkType.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return HyperlinkType.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public HyperlinkSound HyperlinkSound
    {
      get
      {
        return this.GetElement<HyperlinkSound>(0);
      }
      set
      {
        this.SetElement<HyperlinkSound>(0, value);
      }
    }

    public ExtensionList ExtensionList
    {
      get
      {
        return this.GetElement<ExtensionList>(1);
      }
      set
      {
        this.SetElement<ExtensionList>(1, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (19 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "invalidUrl" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "action" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "tgtFrame" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "tooltip" == name)
        return (OpenXmlSimpleType) new StringValue();
      if ((int) namespaceId == 0 && "history" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "highlightClick" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "endSnd" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    protected HyperlinkType()
    {
    }

    protected HyperlinkType(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    protected HyperlinkType(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    protected HyperlinkType(string outerXml)
      : base(outerXml)
    {
    }
  }
}

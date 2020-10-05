// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Wordprocessing.Div
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
  [ChildElementInfo(typeof (RightMarginDiv))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (LeftMarginDiv))]
  [ChildElementInfo(typeof (BlockQuote))]
  [ChildElementInfo(typeof (BodyDiv))]
  [ChildElementInfo(typeof (BottomMarginDiv))]
  [ChildElementInfo(typeof (DivsChild))]
  [ChildElementInfo(typeof (TopMarginDiv))]
  [ChildElementInfo(typeof (DivBorder))]
  public class Div : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[1]
    {
      "id"
    };
    private static byte[] attributeNamespaceIds = new byte[1]
    {
      (byte) 23
    };
    private static readonly string[] eleTagNames = new string[8]
    {
      "blockQuote",
      "bodyDiv",
      "marLeft",
      "marRight",
      "marTop",
      "marBottom",
      "divBdr",
      "divsChild"
    };
    private static readonly byte[] eleNamespaceIds = new byte[8]
    {
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23,
      (byte) 23
    };
    private const string tagName = "div";
    private const byte tagNsId = 23;
    internal const int ElementTypeIdConst = 11972;

    public override string LocalName
    {
      get
      {
        return "div";
      }
    }

    internal override byte NamespaceId
    {
      get
      {
        return 23;
      }
    }

    internal override int ElementTypeId
    {
      get
      {
        return 11972;
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
        return Div.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return Div.attributeNamespaceIds;
      }
    }

    [SchemaAttr(23, "id")]
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

    public Div()
    {
    }

    public Div(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public Div(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public Div(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "blockQuote" == name)
        return (OpenXmlElement) new BlockQuote();
      if (23 == (int) namespaceId && "bodyDiv" == name)
        return (OpenXmlElement) new BodyDiv();
      if (23 == (int) namespaceId && "marLeft" == name)
        return (OpenXmlElement) new LeftMarginDiv();
      if (23 == (int) namespaceId && "marRight" == name)
        return (OpenXmlElement) new RightMarginDiv();
      if (23 == (int) namespaceId && "marTop" == name)
        return (OpenXmlElement) new TopMarginDiv();
      if (23 == (int) namespaceId && "marBottom" == name)
        return (OpenXmlElement) new BottomMarginDiv();
      if (23 == (int) namespaceId && "divBdr" == name)
        return (OpenXmlElement) new DivBorder();
      if (23 == (int) namespaceId && "divsChild" == name)
        return (OpenXmlElement) new DivsChild();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return Div.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return Div.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public BlockQuote BlockQuote
    {
      get
      {
        return this.GetElement<BlockQuote>(0);
      }
      set
      {
        this.SetElement<BlockQuote>(0, value);
      }
    }

    public BodyDiv BodyDiv
    {
      get
      {
        return this.GetElement<BodyDiv>(1);
      }
      set
      {
        this.SetElement<BodyDiv>(1, value);
      }
    }

    public LeftMarginDiv LeftMarginDiv
    {
      get
      {
        return this.GetElement<LeftMarginDiv>(2);
      }
      set
      {
        this.SetElement<LeftMarginDiv>(2, value);
      }
    }

    public RightMarginDiv RightMarginDiv
    {
      get
      {
        return this.GetElement<RightMarginDiv>(3);
      }
      set
      {
        this.SetElement<RightMarginDiv>(3, value);
      }
    }

    public TopMarginDiv TopMarginDiv
    {
      get
      {
        return this.GetElement<TopMarginDiv>(4);
      }
      set
      {
        this.SetElement<TopMarginDiv>(4, value);
      }
    }

    public BottomMarginDiv BottomMarginDiv
    {
      get
      {
        return this.GetElement<BottomMarginDiv>(5);
      }
      set
      {
        this.SetElement<BottomMarginDiv>(5, value);
      }
    }

    public DivBorder DivBorder
    {
      get
      {
        return this.GetElement<DivBorder>(6);
      }
      set
      {
        this.SetElement<DivBorder>(6, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if (23 == (int) namespaceId && "id" == name)
        return (OpenXmlSimpleType) new StringValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<Div>(deep);
    }
  }
}

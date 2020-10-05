// Decompiled with JetBrains decompiler
// Type: DocumentFormat.OpenXml.Spreadsheet.HeaderFooter
// Assembly: DocumentFormat.OpenXml, Version=2.5.5631.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: A7316BF1-EDFD-42B4-84FD-A64CEF0DCF01
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\DocumentFormat.OpenXml.dll

using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Spreadsheet
{
  [ChildElementInfo(typeof (OddFooter))]
  [ChildElementInfo(typeof (EvenFooter))]
  [ChildElementInfo(typeof (FirstHeader))]
  [GeneratedCode("DomGen", "2.0")]
  [ChildElementInfo(typeof (EvenHeader))]
  [ChildElementInfo(typeof (OddHeader))]
  [ChildElementInfo(typeof (FirstFooter))]
  public class HeaderFooter : OpenXmlCompositeElement
  {
    private static string[] attributeTagNames = new string[4]
    {
      "differentOddEven",
      "differentFirst",
      "scaleWithDoc",
      "alignWithMargins"
    };
    private static byte[] attributeNamespaceIds = new byte[4];
    private static readonly string[] eleTagNames = new string[6]
    {
      "oddHeader",
      "oddFooter",
      "evenHeader",
      "evenFooter",
      "firstHeader",
      "firstFooter"
    };
    private static readonly byte[] eleNamespaceIds = new byte[6]
    {
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22,
      (byte) 22
    };
    private const string tagName = "headerFooter";
    private const byte tagNsId = 22;
    internal const int ElementTypeIdConst = 11262;

    public override string LocalName
    {
      get
      {
        return "headerFooter";
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
        return 11262;
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
        return HeaderFooter.attributeTagNames;
      }
    }

    internal override byte[] AttributeNamespaceIds
    {
      get
      {
        return HeaderFooter.attributeNamespaceIds;
      }
    }

    [SchemaAttr(0, "differentOddEven")]
    public BooleanValue DifferentOddEven
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

    [SchemaAttr(0, "differentFirst")]
    public BooleanValue DifferentFirst
    {
      get
      {
        return (BooleanValue) this.Attributes[1];
      }
      set
      {
        this.Attributes[1] = (OpenXmlSimpleType) value;
      }
    }

    [SchemaAttr(0, "scaleWithDoc")]
    public BooleanValue ScaleWithDoc
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

    [SchemaAttr(0, "alignWithMargins")]
    public BooleanValue AlignWithMargins
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

    public HeaderFooter()
    {
    }

    public HeaderFooter(IEnumerable<OpenXmlElement> childElements)
      : base(childElements)
    {
    }

    public HeaderFooter(params OpenXmlElement[] childElements)
      : base(childElements)
    {
    }

    public HeaderFooter(string outerXml)
      : base(outerXml)
    {
    }

    internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
    {
      if (22 == (int) namespaceId && "oddHeader" == name)
        return (OpenXmlElement) new OddHeader();
      if (22 == (int) namespaceId && "oddFooter" == name)
        return (OpenXmlElement) new OddFooter();
      if (22 == (int) namespaceId && "evenHeader" == name)
        return (OpenXmlElement) new EvenHeader();
      if (22 == (int) namespaceId && "evenFooter" == name)
        return (OpenXmlElement) new EvenFooter();
      if (22 == (int) namespaceId && "firstHeader" == name)
        return (OpenXmlElement) new FirstHeader();
      if (22 == (int) namespaceId && "firstFooter" == name)
        return (OpenXmlElement) new FirstFooter();
      return (OpenXmlElement) null;
    }

    internal override string[] ElementTagNames
    {
      get
      {
        return HeaderFooter.eleTagNames;
      }
    }

    internal override byte[] ElementNamespaceIds
    {
      get
      {
        return HeaderFooter.eleNamespaceIds;
      }
    }

    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
      get
      {
        return OpenXmlCompositeType.OneSequence;
      }
    }

    public OddHeader OddHeader
    {
      get
      {
        return this.GetElement<OddHeader>(0);
      }
      set
      {
        this.SetElement<OddHeader>(0, value);
      }
    }

    public OddFooter OddFooter
    {
      get
      {
        return this.GetElement<OddFooter>(1);
      }
      set
      {
        this.SetElement<OddFooter>(1, value);
      }
    }

    public EvenHeader EvenHeader
    {
      get
      {
        return this.GetElement<EvenHeader>(2);
      }
      set
      {
        this.SetElement<EvenHeader>(2, value);
      }
    }

    public EvenFooter EvenFooter
    {
      get
      {
        return this.GetElement<EvenFooter>(3);
      }
      set
      {
        this.SetElement<EvenFooter>(3, value);
      }
    }

    public FirstHeader FirstHeader
    {
      get
      {
        return this.GetElement<FirstHeader>(4);
      }
      set
      {
        this.SetElement<FirstHeader>(4, value);
      }
    }

    public FirstFooter FirstFooter
    {
      get
      {
        return this.GetElement<FirstFooter>(5);
      }
      set
      {
        this.SetElement<FirstFooter>(5, value);
      }
    }

    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
    {
      if ((int) namespaceId == 0 && "differentOddEven" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "differentFirst" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "scaleWithDoc" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      if ((int) namespaceId == 0 && "alignWithMargins" == name)
        return (OpenXmlSimpleType) new BooleanValue();
      return base.AttributeFactory(namespaceId, name);
    }

    public override OpenXmlElement CloneNode(bool deep)
    {
      return (OpenXmlElement) this.CloneImp<HeaderFooter>(deep);
    }
  }
}
